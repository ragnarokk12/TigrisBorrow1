Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

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

    ' Inventory loading remains unchanged.
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

    ' Refresh Button event handler.
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshDeploy.Click
        LoadInventory()
        LoadBorrowRequests()
        MessageBox.Show("Dashboard refreshed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' **************** NEW: Add Item Button Event Handler ****************
    Private Sub btnAdditem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        ' Only admins can add items.
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
    ' ********************************************************************

    ' Account management: Load Accounts.
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
        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnGoAccount_Click(sender As Object, e As EventArgs) Handles btnGoAccount.Click
        LoadAccounts(txtSearchAccount.Text.Trim())
    End Sub

    ' Trigger search on Enter key.
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty
        Me.Close()
    End Sub

    ' Borrow Requests loading.
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

            ' Set friendly headers.
            dgvBorrowRequests.Columns("transaction_id").HeaderText = "Transaction ID"
            dgvBorrowRequests.Columns("borrower").HeaderText = "Borrower"
            dgvBorrowRequests.Columns("item_category").HeaderText = "Category"
            dgvBorrowRequests.Columns("item_name").HeaderText = "Item Name"
            dgvBorrowRequests.Columns("borrow_date").HeaderText = "Borrow Date"
            dgvBorrowRequests.Columns("due_date").HeaderText = "Due Date"
            dgvBorrowRequests.Columns("condition_before").HeaderText = "Condition Before"
            dgvBorrowRequests.Columns("quantity").HeaderText = "Quantity"
            dgvBorrowRequests.Columns("status").HeaderText = "Status"
            dgvBorrowRequests.Columns("approved_by").HeaderText = "Approved By"
            dgvBorrowRequests.Columns("approval_date").HeaderText = "Approval Date"
            dgvBorrowRequests.Columns("approval_time").HeaderText = "Approval Time"
            dgvBorrowRequests.Columns("return_date").HeaderText = "Return Date"
            dgvBorrowRequests.Columns("return_condition").HeaderText = "Return Condition"

        Catch ex As Exception
            MessageBox.Show("Error loading borrow requests: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Approve Borrow Request.
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

    ' Deny Borrow Request.
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

    ' Check Return – update status to pending_inspection.
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

    ' Data Report: Load Audit Logs.
    Private Sub LoadAuditLogs()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "
SELECT 
    l.log_id,
    CONCAT(u.first_name, ' ', u.last_name) AS admin_name,
    l.action_type,
    l.target_id,
    l.target_type,
    l.details,
    l.action_time
FROM admin_logs l
LEFT JOIN users u ON l.admin_id = u.user_id
WHERE l.action_type IN ('Borrow', 'Return')
ORDER BY l.action_time DESC
"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDailyDataReport.DataSource = table

            dgvDailyDataReport.Columns("log_id").HeaderText = "Log ID"
            dgvDailyDataReport.Columns("admin_name").HeaderText = "Admin Name"
            dgvDailyDataReport.Columns("action_type").HeaderText = "Action Type"
            dgvDailyDataReport.Columns("target_id").HeaderText = "Target ID"
            dgvDailyDataReport.Columns("target_type").HeaderText = "Target Type"
            dgvDailyDataReport.Columns("details").HeaderText = "Details"
            dgvDailyDataReport.Columns("action_time").HeaderText = "Action Time"
        Catch ex As Exception
            MessageBox.Show("Error loading audit logs: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        LoadAuditLogs()
    End Sub

    ' Optional: Refresh report on tab enter.
    Private Sub tbcReport_Enter(sender As Object, e As EventArgs) Handles tbcReport.Enter
        LoadAuditLogs()
    End Sub

    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        Dim signUpForm As New SignUpForm()
        signUpForm.FromLogin = False
        signUpForm.OpenLoginOnCancel = False
        signUpForm.ShowDialog()
    End Sub
End Class
