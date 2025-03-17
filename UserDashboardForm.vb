Imports MySql.Data.MySqlClient

Public Class UserDashboardForm

    Private Sub UserDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "User Dashboard"
        lblActiveRequests.Text = "Active Requests: 0"
        lblItemsBorrowed.Text = "Items Borrowed: 0"
        lblOverdueItems.Text = "Overdue Items: 0"

        LoadUserProfileData()
        LoadBorrowRequestData()
        LoadInventoryData()
        LoadNotificationsData()
        UpdateDashboardSummary()
    End Sub

    Private Sub LoadUserProfileData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT email, first_name, last_name, user_id FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEmail.Text = reader("email").ToString()
                            txtFullName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                            txtStudentID.Text = reader("user_id").ToString()
                        Else
                            MessageBox.Show("User profile not found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user profile: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        MessageBox.Show("Reset Password clicked. Implement password reset functionality.")
    End Sub

    Private Sub LoadBorrowRequestData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "
                    SELECT 
                        bt.transaction_id AS 'RequestID', 
                        (CASE 
                            WHEN bt.equipment_id IS NOT NULL THEN 
                                (SELECT item_name FROM unified_inventory WHERE category='Equipment' AND item_id = bt.equipment_id)
                            WHEN bt.accessory_id IS NOT NULL THEN 
                                (SELECT item_name FROM unified_inventory WHERE category='Accessory' AND item_id = bt.accessory_id)
                            ELSE 'Unknown'
                         END) AS 'ItemName',
                        bt.borrow_date AS 'RequestDate', 
                        bt.due_date AS 'DueDate',
                        bt.status AS 'Status'
                    FROM borrow_transactions bt
                    WHERE bt.user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dgvBorrowRequests.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading borrow transactions: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Borrow Request submission: if the item is an accessory, prompt for quantity.
    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        Try
            ' Ensure an inventory item is selected.
            If dgvInventory.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an item to borrow.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim itemId As Integer = Convert.ToInt32(selectedRow.Cells("item_id").Value)
            Dim category As String = selectedRow.Cells("category").Value.ToString()
            Dim itemStatus As String = selectedRow.Cells("status").Value.ToString()

            If itemStatus.ToLower() <> "available" Then
                MessageBox.Show("The selected item is not available for borrowing.", "Unavailable Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Set default borrow details.
            Dim dueDate As DateTime = DateTime.Now.AddDays(7)
            Dim borrowDate As DateTime = DateTime.Now

            Using conn As MySqlConnection = Common.getDBConnection()
                conn.Open()
                Dim query As String = ""
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                cmd.Parameters.AddWithValue("@borrowDate", borrowDate)
                cmd.Parameters.AddWithValue("@dueDate", dueDate)

                If category.ToLower() = "equipment" Then
                    ' For equipment, no quantity input is needed.
                    query = "INSERT INTO borrow_transactions (user_id, equipment_id, accessory_id, borrow_date, due_date, status) " &
                            "VALUES (@userId, @equipmentId, @accessoryId, @borrowDate, @dueDate, 'pending')"
                    cmd.Parameters.AddWithValue("@equipmentId", itemId)
                    cmd.Parameters.AddWithValue("@accessoryId", DBNull.Value)
                ElseIf category.ToLower() = "accessory" Then
                    ' For accessories, prompt the user for quantity.
                    Dim inputQuantity As String = InputBox("Enter the quantity to borrow:", "Quantity", "1")
                    Dim borrowQuantity As Integer = 0
                    If Not Integer.TryParse(inputQuantity, borrowQuantity) OrElse borrowQuantity <= 0 Then
                        MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    query = "INSERT INTO borrow_transactions (user_id, equipment_id, accessory_id, borrow_date, due_date, status, borrow_quantity) " &
                            "VALUES (@userId, @equipmentId, @accessoryId, @borrowDate, @dueDate, 'pending', @borrowQuantity)"
                    cmd.Parameters.AddWithValue("@equipmentId", DBNull.Value)
                    cmd.Parameters.AddWithValue("@accessoryId", itemId)
                    cmd.Parameters.AddWithValue("@borrowQuantity", borrowQuantity)
                Else
                    MessageBox.Show("Unrecognized item category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                cmd.CommandText = query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Borrow request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadBorrowRequestData()
                    UpdateDashboardSummary()
                Else
                    MessageBox.Show("Failed to submit borrow request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error submitting borrow request: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadInventoryData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT item_id, item_name, item_type, quantity, status, added_at, brand, model, serial_number, category FROM unified_inventory"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dgvInventory.DataSource = dt

                ' Hide unwanted columns.
                If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").Visible = False
                If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").Visible = False
                If dgvInventory.Columns.Contains("added_at") Then dgvInventory.Columns("added_at").Visible = False
                If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearchInventory_Click(sender As Object, e As EventArgs) Handles btnSearchInventory.Click
        Dim searchTerm As String = txtSearchInventory.Text.Trim()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT item_id, item_name, item_type, quantity, status, added_at, brand, model, serial_number, category " &
                                      "FROM unified_inventory WHERE item_name LIKE @searchTerm"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dgvInventory.DataSource = dt

                ' Hide unwanted columns after search.
                If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").Visible = False
                If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").Visible = False
                If dgvInventory.Columns.Contains("added_at") Then dgvInventory.Columns("added_at").Visible = False
                If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error searching inventory: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadNotificationsData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT message AS 'Notification', created_at AS 'Date' FROM notifications WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dgvNotifications.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading notifications: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnClearNotifications_Click(sender As Object, e As EventArgs) Handles btnClearNotifications.Click
        MessageBox.Show("Clear Notifications clicked. Implement notification clearing.")
    End Sub

    Private Sub UpdateDashboardSummary()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim queryActive As String = "SELECT COUNT(*) FROM borrow_transactions WHERE user_id = @userId AND status = 'pending'"
                Dim activeCount As Integer = 0
                Using cmd As New MySqlCommand(queryActive, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    activeCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim queryBorrowed As String = "SELECT COUNT(*) FROM borrow_transactions WHERE user_id = @userId AND status = 'approved'"
                Dim borrowedCount As Integer = 0
                Using cmd As New MySqlCommand(queryBorrowed, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    borrowedCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim queryOverdue As String = "SELECT COUNT(*) FROM borrow_transactions WHERE user_id = @userId AND status = 'overdue'"
                Dim overdueCount As Integer = 0
                Using cmd As New MySqlCommand(queryOverdue, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    overdueCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                lblActiveRequests.Text = "Active Requests: " & activeCount.ToString()
                lblItemsBorrowed.Text = "Items Borrowed: " & borrowedCount.ToString()
                lblOverdueItems.Text = "Overdue Items: " & overdueCount.ToString()
            Catch ex As Exception
                MessageBox.Show("Error updating dashboard summary: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Return Item process: Prevents returning an item if its request status is "denied."
    Private Sub btnReturnItem_Click(sender As Object, e As EventArgs) Handles btnReturnItem.Click
        ' Ensure a borrow transaction is selected.
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a transaction to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvBorrowRequests.SelectedRows(0)
        Dim transactionId As Integer = Convert.ToInt32(selectedRow.Cells("RequestID").Value)
        Dim currentStatus As String = selectedRow.Cells("Status").Value.ToString().ToLower()

        ' Prevent return if the status is "denied."
        If currentStatus = "denied" Then
            MessageBox.Show("You cannot return an item when the request status is 'denied'.", "Return Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                conn.Open()
                Dim query As String = "UPDATE borrow_transactions SET return_date = @returnDate, status = 'returned' WHERE transaction_id = @transactionId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@returnDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@transactionId", transactionId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Item returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadBorrowRequestData()  ' Refresh the borrow request grid.
                        UpdateDashboardSummary() ' Update dashboard counts.
                    Else
                        MessageBox.Show("Failed to update the transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error returning item: " & ex.Message)
        End Try
    End Sub

End Class
