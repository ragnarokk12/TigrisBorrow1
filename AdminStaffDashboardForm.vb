Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization

Public Class AdminStaffDashboardForm

    Private conn As MySqlConnection = Common.getDBConnection()
    Private role As String = ""

    Private Sub AdminStaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserRole()
        LoadInventory()
        LoadAccounts()
        SetAccessByRole()
        LoadSortOptions()
        LoadBorrowRequests()
        PopulateMonthAndYearFilters()   ' Populate the combo boxes
        LoadDailyReport()               ' Load daily report if needed
        ' Optionally, load monthly report without filters to test:
        ' Await LoadMonthlyReportAsync() ' if using Async in an Async Form_Load event
    End Sub

    Private Sub FetchUserRole()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT role FROM users WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                Dim currentUser = Common.CurrentUserId.Trim()
                Debug.WriteLine("CurrentUserId = " & currentUser)
                cmd.Parameters.AddWithValue("@userId", currentUser)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    role = result.ToString().ToLower()
                Else
                    MessageBox.Show("User role not found for user id: " & currentUser)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user role: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadInventory(Optional ByVal search As String = "", Optional ByVal sortBy As String = "item_name", Optional ByVal sortOrder As String = "ASC")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim validColumns As New List(Of String)({"item_name", "category", "status", "quantity", "added_at"})
            If Not validColumns.Contains(sortBy) Then sortBy = "item_name"
            If sortOrder.ToUpper() <> "ASC" AndAlso sortOrder.ToUpper() <> "DESC" Then
                sortOrder = "ASC"
            End If
            Dim query As String = $"SELECT * FROM unified_inventory WHERE item_name LIKE @search ORDER BY {sortBy} {sortOrder}"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvInventory.DataSource = table
            End Using

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If dgvInventory.Columns.Contains("item_name") Then dgvInventory.Columns("item_name").HeaderText = "Item Name"
            If dgvInventory.Columns.Contains("category") Then dgvInventory.Columns("category").HeaderText = "Category"
            If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").HeaderText = "Status"
            If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").HeaderText = "Quantity"
            If dgvInventory.Columns.Contains("added_at") Then
                dgvInventory.Columns("added_at").HeaderText = "Added At"
                dgvInventory.Columns("added_at").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        LoadInventory(txtSearchInv.Text.Trim())
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim sortBy As String = If(cbSortBy.SelectedItem IsNot Nothing, cbSortBy.SelectedItem.ToString(), "item_name")
        Dim sortOrder As String = If(chkDescending.Checked, "DESC", "ASC")
        LoadInventory(txtSearchInv.Text.Trim(), sortBy, sortOrder)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshDeploy.Click
        LoadInventory()
        LoadBorrowRequests()
        LoadDailyReport() ' Refresh the daily report as well
        MessageBox.Show("Dashboard refreshed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAdditem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If

        Dim addForm As New AddItemForm()
        If addForm.ShowDialog() = DialogResult.OK AndAlso addForm.Added Then
            MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadInventory()
        End If
    End Sub

    Private Sub LoadAccounts(Optional ByVal searchQuery As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT user_id, first_name, last_name, email, contact_number, role, created_at FROM users"
            If Not String.IsNullOrEmpty(searchQuery) Then
                query &= " WHERE user_id LIKE @search OR first_name LIKE @search OR last_name LIKE @search OR email LIKE @search"
            End If
            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrEmpty(searchQuery) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                End If
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAccount.DataSource = table
            End Using

            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If dgvAccount.Columns.Contains("user_id") Then dgvAccount.Columns("user_id").HeaderText = "User ID"
            If dgvAccount.Columns.Contains("first_name") Then dgvAccount.Columns("first_name").HeaderText = "First Name"
            If dgvAccount.Columns.Contains("last_name") Then dgvAccount.Columns("last_name").HeaderText = "Last Name"
            If dgvAccount.Columns.Contains("email") Then dgvAccount.Columns("email").HeaderText = "Email"
            If dgvAccount.Columns.Contains("contact_number") Then dgvAccount.Columns("contact_number").HeaderText = "Contact Number"
            If dgvAccount.Columns.Contains("role") Then dgvAccount.Columns("role").HeaderText = "Role"
            If dgvAccount.Columns.Contains("created_at") Then
                dgvAccount.Columns("created_at").HeaderText = "Created At"
                dgvAccount.Columns("created_at").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnGoAccount_Click(sender As Object, e As EventArgs) Handles btnGoAccount.Click
        LoadAccounts(txtSearchAccount.Text.Trim())
    End Sub

    Private Sub txtSearchAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGoAccount.PerformClick()
        End If
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As String = dgvAccount.SelectedRows(0).Cells("user_id").Value.ToString()
        Dim editForm As New EditUserForm()
        editForm.UserId = userId
        If editForm.ShowDialog() = DialogResult.OK Then
            Common.LogAction("EDIT_USER", userId, "USER", "User details updated by admin.")
            LoadAccounts(txtSearchAccount.Text.Trim())
        End If
    End Sub

    Private Sub LoadSortOptions()
        cbSortBy.Items.Clear()
        cbSortBy.Items.AddRange(New String() {"item_name", "category", "status", "quantity", "added_at"})
        cbSortBy.SelectedIndex = 0
    End Sub

    Private Sub SetAccessByRole()
        btnAdditem.Enabled = (role = "admin")
        btnDeleteItems.Enabled = (role = "admin")
        tbcAdminDashboard.Enabled = (role = "admin" Or role = "staff")
        btnApprove.Enabled = (role = "admin" Or role = "staff")
        btnDeny.Enabled = (role = "admin" Or role = "staff")
        btnCheckReturn.Enabled = (role = "admin" Or role = "staff")
    End Sub

    Private Sub LoadBorrowRequests(Optional ByVal statusFilter As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "
SELECT 
    bt.transaction_id,
    CONCAT(u.first_name, ' ', u.last_name) AS borrower,
    CASE 
         WHEN bt.equipment_id IS NOT NULL THEN 'Equipment'
         WHEN bt.accessory_id IS NOT NULL THEN 'Accessory'
    END AS item_category,
    CASE 
         WHEN bt.equipment_id IS NOT NULL THEN e.equipment_name
         WHEN bt.accessory_id IS NOT NULL THEN a.accessory_name
    END AS item_name,
    bt.borrow_date,
    bt.due_date,
    CASE 
         WHEN bt.equipment_id IS NOT NULL THEN e.item_condition
         WHEN bt.accessory_id IS NOT NULL THEN a.item_condition
    END AS condition_before,
    CASE 
         WHEN bt.accessory_id IS NOT NULL THEN a.quantity 
         ELSE NULL 
    END AS quantity,
    bt.status,
    bt.approved_by,
    bt.approval_date,
    bt.approval_time,
    bt.return_date,
    bt.return_condition
FROM borrow_transactions bt
JOIN users u ON bt.user_id = u.user_id
LEFT JOIN equipment e ON bt.equipment_id = e.equipment_id
LEFT JOIN accessories a ON bt.accessory_id = a.accessory_id
"
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE bt.status = @statusFilter"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If Not String.IsNullOrEmpty(statusFilter) Then
                cmd.Parameters.AddWithValue("@statusFilter", statusFilter)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvBorrowRequests.DataSource = table

            dgvBorrowRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If dgvBorrowRequests.Columns.Contains("transaction_id") Then dgvBorrowRequests.Columns("transaction_id").HeaderText = "Transaction ID"
            If dgvBorrowRequests.Columns.Contains("borrower") Then dgvBorrowRequests.Columns("borrower").HeaderText = "Borrower"
            If dgvBorrowRequests.Columns.Contains("item_category") Then dgvBorrowRequests.Columns("item_category").HeaderText = "Category"
            If dgvBorrowRequests.Columns.Contains("item_name") Then dgvBorrowRequests.Columns("item_name").HeaderText = "Item Name"
            If dgvBorrowRequests.Columns.Contains("borrow_date") Then
                dgvBorrowRequests.Columns("borrow_date").HeaderText = "Borrow Date"
                dgvBorrowRequests.Columns("borrow_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            If dgvBorrowRequests.Columns.Contains("due_date") Then
                dgvBorrowRequests.Columns("due_date").HeaderText = "Due Date"
                dgvBorrowRequests.Columns("due_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            If dgvBorrowRequests.Columns.Contains("condition_before") Then dgvBorrowRequests.Columns("condition_before").HeaderText = "Condition Before"
            If dgvBorrowRequests.Columns.Contains("quantity") Then dgvBorrowRequests.Columns("quantity").HeaderText = "Quantity"
            If dgvBorrowRequests.Columns.Contains("status") Then dgvBorrowRequests.Columns("status").HeaderText = "Status"
            If dgvBorrowRequests.Columns.Contains("approved_by") Then dgvBorrowRequests.Columns("approved_by").HeaderText = "Approved By"
            If dgvBorrowRequests.Columns.Contains("approval_date") Then dgvBorrowRequests.Columns("approval_date").HeaderText = "Approval Date"
            If dgvBorrowRequests.Columns.Contains("approval_time") Then dgvBorrowRequests.Columns("approval_time").HeaderText = "Approval Time"
            If dgvBorrowRequests.Columns.Contains("return_date") Then dgvBorrowRequests.Columns("return_date").HeaderText = "Return Date"
            If dgvBorrowRequests.Columns.Contains("return_condition") Then dgvBorrowRequests.Columns("return_condition").HeaderText = "Return Condition"
        Catch ex As Exception
            MessageBox.Show("Error loading borrow requests: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a borrow request to approve.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("transaction_id").Value)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim updateQuery As String = "
UPDATE borrow_transactions
SET approved_by = @approved_by,
    approval_date = NOW(),
    approval_time = CURTIME(),
    status = 'approved'
WHERE transaction_id = @transactionId AND status = 'pending'
"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@approved_by", Common.CurrentUserId)
            cmd.Parameters.AddWithValue("@transactionId", transactionId)
            Dim rowsAffected = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Borrow request approved successfully.")
            Else
                MessageBox.Show("Failed to approve the request. It may have been updated already.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error approving borrow request: " & ex.Message)
        Finally
            conn.Close()
        End Try
        LoadBorrowRequests()
    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a borrow request to deny.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("transaction_id").Value)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim updateQuery As String = "
UPDATE borrow_transactions
SET status = 'denied'
WHERE transaction_id = @transactionId AND status = 'pending'
"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@transactionId", transactionId)
            Dim rowsAffected = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Borrow request denied successfully.")
            Else
                MessageBox.Show("Failed to deny the request. It may have been updated already.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error denying borrow request: " & ex.Message)
        Finally
            conn.Close()
        End Try
        LoadBorrowRequests()
    End Sub

    Private Sub btnCheckReturn_Click(sender As Object, e As EventArgs) Handles btnCheckReturn.Click
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a returned borrow transaction.")
            Return
        End If

        Dim status As String = dgvBorrowRequests.SelectedRows(0).Cells("status").Value.ToString()
        If status <> "returned" Then
            MessageBox.Show("Selected transaction is not marked as returned.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("transaction_id").Value)
        Dim returnCondition As String = InputBox("Enter the condition of the item upon return (new, good, fair, poor, damaged):", "Return Condition")

        If String.IsNullOrEmpty(returnCondition) Then
            MessageBox.Show("Return condition is required.")
            Return
        End If

        Dim validConditions As New List(Of String) From {"new", "good", "fair", "poor", "damaged"}
        If Not validConditions.Contains(returnCondition.ToLower()) Then
            MessageBox.Show("Invalid condition entered. Please enter one of: new, good, fair, poor, damaged.")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim updateQuery As String = "
UPDATE borrow_transactions
SET return_condition = @return_condition,
    status = 'pending_inspection'
WHERE transaction_id = @transactionId AND status = 'returned'
"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@return_condition", returnCondition.ToLower())
            cmd.Parameters.AddWithValue("@transactionId", transactionId)
            Dim rowsAffected = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Return approved and status updated to pending inspection.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update the return information. It may have been updated already.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating return condition: " & ex.Message)
        Finally
            conn.Close()
        End Try
        LoadBorrowRequests()
    End Sub

    Private Sub LoadDailyReport(Optional ByVal startDate As DateTime? = Nothing, Optional ByVal endDate As DateTime? = Nothing, Optional ByVal actionTypeFilter As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT CAST(bt.transaction_id AS CHAR) AS ID, CONCAT(u.first_name, ' ', u.last_name) AS UserName, " &
                              "bt.status AS ActionType, CONCAT('Borrow Date: ', DATE_FORMAT(bt.borrow_date, '%Y-%m-%d'), ', Due Date: ', DATE_FORMAT(bt.due_date, '%Y-%m-%d')) AS Details, " &
                              "bt.borrow_date AS ActionTime " &
                              "FROM borrow_transactions bt JOIN users u ON bt.user_id = u.user_id WHERE 1=1"

            ' Append filters if provided
            If startDate.HasValue Then query &= " AND bt.borrow_date >= @startDate"
            If endDate.HasValue Then query &= " AND bt.borrow_date <= @endDate"
            If Not String.IsNullOrEmpty(actionTypeFilter) Then query &= " AND bt.status = @actionTypeFilter"

            query &= " ORDER BY ActionTime DESC"

            Using cmd As New MySqlCommand(query, conn)
                If startDate.HasValue Then cmd.Parameters.AddWithValue("@startDate", startDate.Value)
                If endDate.HasValue Then cmd.Parameters.AddWithValue("@endDate", endDate.Value)
                If Not String.IsNullOrEmpty(actionTypeFilter) Then cmd.Parameters.AddWithValue("@actionTypeFilter", actionTypeFilter)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvDailyDataReport.DataSource = table
            End Using

            dgvDailyDataReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If dgvDailyDataReport.Columns.Contains("ID") Then dgvDailyDataReport.Columns("ID").HeaderText = "ID"
            If dgvDailyDataReport.Columns.Contains("UserName") Then dgvDailyDataReport.Columns("UserName").HeaderText = "User Name"
            If dgvDailyDataReport.Columns.Contains("ActionType") Then dgvDailyDataReport.Columns("ActionType").HeaderText = "Action Type"
            If dgvDailyDataReport.Columns.Contains("Details") Then dgvDailyDataReport.Columns("Details").HeaderText = "Details"
            If dgvDailyDataReport.Columns.Contains("ActionTime") Then
                dgvDailyDataReport.Columns("ActionTime").HeaderText = "Action Time"
                dgvDailyDataReport.Columns("ActionTime").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            End If

            lblSummary.Text = "Total Records: " & dgvDailyDataReport.Rows.Count.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading daily report: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Event handlers for dynamic filtering:
    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        ApplyDailyReportFilters()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        ApplyDailyReportFilters()
    End Sub

    Private Sub cbActionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbActionType.SelectedIndexChanged
        ApplyDailyReportFilters()
    End Sub

    ' Common subroutine to apply filters:
    Private Sub ApplyDailyReportFilters()
        Dim startDate As DateTime? = Nothing
        Dim endDate As DateTime? = Nothing

        ' Use the Checked property to see if the DateTimePicker is enabled for filtering.
        If dtpStartDate.Checked Then startDate = dtpStartDate.Value
        If dtpEndDate.Checked Then endDate = dtpEndDate.Value

        Dim actionTypeFilter As String = ""
        If cbActionType.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbActionType.SelectedItem.ToString()) Then
            actionTypeFilter = cbActionType.SelectedItem.ToString()
        End If

        ' Reload the daily report with the current filter values.
        LoadDailyReport(startDate, endDate, actionTypeFilter)
    End Sub

    Private Sub LoadActionTypeOptions()
        cbActionType.Items.Clear()
        ' Add the action types you want for filtering
        cbActionType.Items.Add("approved")
        cbActionType.Items.Add("denied")
        cbActionType.Items.Add("returned")
        cbActionType.Items.Add("pending")
        ' Optionally, set a default selected index
        cbActionType.SelectedIndex = 0
    End Sub


    ' Event handler for Reports tab entry – now calls LoadDailyReport
    Private Sub tbcReport_Enter(sender As Object, e As EventArgs) Handles tbcReport.Enter
        LoadDailyReport()
    End Sub

    ' Example filter button event to apply date and action type filters on the daily report
    Private Sub btnFilterDailyReport_Click(sender As Object, e As EventArgs)
        Dim startDate As DateTime? = Nothing
        Dim endDate As DateTime? = Nothing

        If dtpStartDate.Checked Then startDate = dtpStartDate.Value
        If dtpEndDate.Checked Then endDate = dtpEndDate.Value

        Dim actionTypeFilter As String = ""
        If cbActionType.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbActionType.SelectedItem.ToString()) Then
            actionTypeFilter = cbActionType.SelectedItem.ToString()
        End If

        LoadDailyReport(startDate, endDate, actionTypeFilter)
    End Sub

    Private Async Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        If cbMonth.SelectedItem Is Nothing OrElse cbYear.SelectedItem Is Nothing Then
            Return
        End If

        Dim selectedMonthName As String = cbMonth.SelectedItem.ToString()
        Dim selectedMonth As Integer = DateTime.ParseExact(selectedMonthName, "MMMM", CultureInfo.CurrentCulture).Month

        Dim selectedYear As Integer
        If Integer.TryParse(cbYear.SelectedItem.ToString(), selectedYear) Then
            Await LoadMonthlyReportAsync(selectedMonth, selectedYear)
        End If
    End Sub

    Private Async Sub cbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        If cbMonth.SelectedItem Is Nothing OrElse cbYear.SelectedItem Is Nothing Then
            Return
        End If

        Dim selectedMonthName As String = cbMonth.SelectedItem.ToString()
        Dim selectedMonth As Integer = DateTime.ParseExact(selectedMonthName, "MMMM", CultureInfo.CurrentCulture).Month

        Dim selectedYear As Integer
        If Integer.TryParse(cbYear.SelectedItem.ToString(), selectedYear) Then
            Await LoadMonthlyReportAsync(selectedMonth, selectedYear)
        End If
    End Sub



    Private Async Function LoadMonthlyReportAsync(Optional ByVal selectedMonth As Integer? = Nothing, Optional ByVal selectedYear As Integer? = Nothing) As Task
        Dim localConn As MySqlConnection = Common.getDBConnection()
        Try
            If localConn.State = ConnectionState.Closed Then localConn.Open()

            Dim query As String = "SELECT YEAR(borrow_date) AS Year, " &
                              "MAX(MONTHNAME(borrow_date)) AS MonthName, " &
                              "COUNT(*) AS TotalTransactions, " &
                              "SUM(CASE WHEN status = 'approved' THEN 1 ELSE 0 END) AS Approved, " &
                              "SUM(CASE WHEN status = 'denied' THEN 1 ELSE 0 END) AS Denied, " &
                              "SUM(CASE WHEN status = 'returned' THEN 1 ELSE 0 END) AS Returned " &
                              "FROM borrow_transactions WHERE 1=1 "

            If selectedYear.HasValue Then
                query &= " AND YEAR(borrow_date) = @selectedYear"
            End If
            If selectedMonth.HasValue Then
                query &= " AND MONTH(borrow_date) = @selectedMonth"
            End If

            query &= " GROUP BY YEAR(borrow_date), MONTH(borrow_date) ORDER BY Year DESC, MONTH(borrow_date) DESC"

            Dim cmd As New MySqlCommand(query, localConn)
            If selectedYear.HasValue Then
                cmd.Parameters.AddWithValue("@selectedYear", selectedYear.Value)
            End If
            If selectedMonth.HasValue Then
                cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth.Value)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            Await Task.Run(Sub() adapter.Fill(table))

            dgvMonthlyDataReport.DataSource = table
            dgvMonthlyDataReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If table.Rows.Count = 0 Then
                MessageBox.Show("No monthly data available for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading monthly report: " & ex.Message)
        Finally
            localConn.Close()
        End Try
    End Function

    Private Sub PopulateMonthAndYearFilters()
        cbMonth.Items.Clear()
        For i As Integer = 1 To 12
            Dim monthName As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i)
            cbMonth.Items.Add(monthName)
        Next

        ' Populate years (e.g., currentYear - 5 to currentYear)
        cbYear.Items.Clear()
        Dim currentYear As Integer = DateTime.Now.Year
        For y As Integer = currentYear - 5 To currentYear
            cbYear.Items.Add(y.ToString())
        Next

        ' Set default selections to current month and year.
        cbMonth.SelectedItem = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)
        cbYear.SelectedItem = currentYear.ToString()
    End Sub


    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        Dim signUpForm As New SignUpForm()
        signUpForm.FromLogin = False
        signUpForm.OpenLoginOnCancel = False
        signUpForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty
        Me.Close()
    End Sub


End Class
