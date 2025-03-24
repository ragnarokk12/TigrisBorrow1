Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class UserDashboardForm
    Private WithEvents Timer1 As New Timer()

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

        ' Configure Timer
        Timer1.Interval = 1000 ' 1 second
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckForOverdueRequests()  ' Check and update overdue requests.
        LoadNotificationsData()     ' Refresh the notifications grid.
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

    ' Reset Password Button Implementation
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim changeForm As New ChangePasswordForm()
        ' Show the ChangePasswordForm as a modal dialog.
        If changeForm.ShowDialog(Me) = DialogResult.OK Then
            Dim newPwd As String = changeForm.NewPasswordText
            If UpdateUserPassword(Common.CurrentUserId, newPwd) Then
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' Updates the user's password in the database.
    Private Function UpdateUserPassword(userId As String, newPassword As String) As Boolean
        Dim hashedPassword As String = HashPassword(newPassword)
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE users SET password_hash = @hashedPassword, last_password_change = NOW(), force_password_change = FALSE WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating password: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' HashPassword helper: hashes a password using SHA256.
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

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

                ' Hide the RequestID column.
                If dgvBorrowRequests.Columns.Contains("RequestID") Then dgvBorrowRequests.Columns("RequestID").Visible = False

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
            Dim itemId As Integer = Convert.ToInt32(selectedRow.Cells("Colitem_id").Value)
            Dim category As String = selectedRow.Cells("Colcategory").Value.ToString()
            Dim itemStatus As String = selectedRow.Cells("colstatus").Value.ToString() ' Ensure correct column name

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
                    query = "INSERT INTO borrow_transactions (user_id, equipment_id, accessory_id, borrow_date, due_date, status) " &
                        "VALUES (@userId, @equipmentId, @accessoryId, @borrowDate, @dueDate, 'pending')"
                    cmd.Parameters.AddWithValue("@equipmentId", itemId)
                    cmd.Parameters.AddWithValue("@accessoryId", DBNull.Value)
                ElseIf category.ToLower() = "accessory" Then
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
                dgvInventory.AutoGenerateColumns = False
                dgvInventory.DataSource = dt

                ' Hide unwanted columns.
                If dgvInventory.Columns.Contains("item_id") Then dgvInventory.Columns("item_id").Visible = False
                If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").Visible = False
                If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").Visible = False
                If dgvInventory.Columns.Contains("added_at") Then dgvInventory.Columns("added_at").Visible = False
                If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").Visible = False

                dgvInventory.Columns("COLitem_name").DataPropertyName = "item_name"
                dgvInventory.Columns("Colitem_type").DataPropertyName = "item_type"
                dgvInventory.Columns("Colbrand").DataPropertyName = "brand"
                dgvInventory.Columns("Colmodel").DataPropertyName = "model"
                dgvInventory.Columns("Colcategory").DataPropertyName = "category"
                dgvInventory.Columns("Colitem_id").DataPropertyName = "item_id"
                dgvInventory.Columns("Colstatus").DataPropertyName = "status"

            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadNotificationsData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT message AS 'Notification', created_at AS 'Date' FROM notifications WHERE user_id = @userId ORDER BY created_at DESC"
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
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a transaction to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvBorrowRequests.SelectedRows(0)
        Dim transactionId As Integer = Convert.ToInt32(selectedRow.Cells("RequestID").Value)
        Dim currentStatus As String = selectedRow.Cells("Status").Value.ToString().ToLower()

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
                        LoadBorrowRequestData()
                        UpdateDashboardSummary()
                    Else
                        MessageBox.Show("Failed to update the transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error returning item: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateBorrowRequestStatus(transactionId As Integer, newStatus As String)
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE borrow_transactions SET status = @newStatus WHERE transaction_id = @transactionId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@newStatus", newStatus)
                    cmd.Parameters.AddWithValue("@transactionId", transactionId)
                    cmd.ExecuteNonQuery()
                End Using

                Dim notificationMessage As String = "Your borrow request (ID: " & transactionId.ToString() & ") has been " & newStatus & "."
                Dim insertQuery As String = "INSERT INTO notifications (user_id, message, is_read, created_at) VALUES (@userId, @message, 0, NOW())"
                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    insertCmd.Parameters.AddWithValue("@message", notificationMessage)
                    insertCmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating request status: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CheckForOverdueRequests()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim overdueQuery As String = "SELECT transaction_id, user_id FROM borrow_transactions WHERE due_date < NOW() AND status = 'approved'"
                Dim dtOverdue As New DataTable()
                Using cmd As New MySqlCommand(overdueQuery, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtOverdue)
                End Using

                For Each row As DataRow In dtOverdue.Rows
                    Dim transactionId As Integer = Convert.ToInt32(row("transaction_id"))
                    Dim userId As String = row("user_id").ToString()
                    Dim checkQuery As String = "SELECT COUNT(*) FROM notifications WHERE message LIKE @msg AND user_id = @userId"
                    Dim msgPattern As String = "Your borrow request (ID: " & transactionId.ToString() & ") is now overdue%"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@msg", msgPattern)
                        checkCmd.Parameters.AddWithValue("@userId", userId)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count = 0 Then
                            Dim insertQuery As String = "INSERT INTO notifications (user_id, message, is_read, created_at) VALUES (@userId, @message, 0, NOW())"
                            Using insertCmd As New MySqlCommand(insertQuery, conn)
                                insertCmd.Parameters.AddWithValue("@userId", userId)
                                insertCmd.Parameters.AddWithValue("@message", "Your borrow request (ID: " & transactionId.ToString() & ") is now overdue.")
                                insertCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using

                    Dim updateQuery As String = "UPDATE borrow_transactions SET status = 'overdue' WHERE transaction_id = @transactionId"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@transactionId", transactionId)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Next
            Catch ex As Exception
                MessageBox.Show("Error checking overdue requests: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ontextchange(sender As Object, e As EventArgs) Handles txtSearchInventory.TextChanged
        Dim searchTerm As String = txtSearchInventory.Text.Trim()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT item_id, item_name, item_type, quantity, status, added_at, brand, model, serial_number, category " &
                                      "FROM unified_inventory " &
                                      "WHERE item_id LIKE @searchTerm OR " &
                                      "item_name LIKE @searchTerm OR " &
                                      "item_type LIKE @searchTerm OR " &
                                      "quantity LIKE @searchTerm OR " &
                                      "status LIKE @searchTerm OR " &
                                      "added_at LIKE @searchTerm OR " &
                                      "brand LIKE @searchTerm OR " &
                                      "model LIKE @searchTerm OR " &
                                      "serial_number LIKE @searchTerm OR " &
                                      "category LIKE @searchTerm"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvInventory.AutoGenerateColumns = False
                dgvInventory.DataSource = dt

                If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").Visible = False
                If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").Visible = False
                If dgvInventory.Columns.Contains("added_at") Then dgvInventory.Columns("added_at").Visible = False
                If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").Visible = False

                If dgvInventory.Columns.Contains("COLitem_name") Then dgvInventory.Columns("COLitem_name").DataPropertyName = "item_name"
                If dgvInventory.Columns.Contains("Colitem_type") Then dgvInventory.Columns("Colitem_type").DataPropertyName = "item_type"
                If dgvInventory.Columns.Contains("Colbrand") Then dgvInventory.Columns("Colbrand").DataPropertyName = "brand"
                If dgvInventory.Columns.Contains("Colmodel") Then dgvInventory.Columns("Colmodel").DataPropertyName = "model"
                If dgvInventory.Columns.Contains("Colcategory") Then dgvInventory.Columns("Colcategory").DataPropertyName = "category"
                If dgvInventory.Columns.Contains("Colitem_id") Then dgvInventory.Columns("Colitem_id").DataPropertyName = "item_id"
                If dgvInventory.Columns.Contains("Colstatus") Then dgvInventory.Columns("Colstatus").DataPropertyName = "status"

            Catch ex As Exception
                MessageBox.Show("Error searching inventory: " & ex.Message)
            End Try
        End Using
    End Sub

End Class
