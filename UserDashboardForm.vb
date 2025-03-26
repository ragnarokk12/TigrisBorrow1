Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class UserDashboardForm
    Private WithEvents Timer1 As New Timer()
    Private conn As MySqlConnection = Common.getDBConnection()
    Private TimerTickHandler As EventHandler = AddressOf Timer1_Tick

    Public Sub New()
        InitializeComponent()
        ' Ensure the Timer Tick delegate is kept alive.
        AddHandler Timer1.Tick, TimerTickHandler
    End Sub

    Private Sub UserDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "User Dashboard"
        'lblActiveRequests.Text = "Active Requests: 0"
        'lblItemsBorrowed.Text = "Items Borrowed: 0"
        'lblOverdueItems.Text = "Overdue Items: 0"

        LoadUserProfileData()
        LoadUserDisplayName()      ' Add this call to update lblDisplayName.
        LoadUserDisplayIdNumber()  ' Add this call to update lblDisplayIdNumber.
        LoadBorrowRequestData()
        LoadInventoryData()
        LoadNotificationsData()
        UpdateDashboardSummary()

        ' Load the status filter options.
        LoadStatusFilterOptions()

        ' Configure and start Timer (1 second interval)
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()

        ' Check if user is forced to change password.
        If UserMustChangePassword(Common.CurrentUserId) Then
            MessageBox.Show("Your password has been reset by an administrator. You must change your password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim changeForm As New ChangePasswordForm()
            Do
                If changeForm.ShowDialog(Me) = DialogResult.OK Then
                    Dim newPwd As String = changeForm.NewPasswordText
                    If UpdateUserPassword(Common.CurrentUserId, newPwd) Then
                        MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Do
                    Else
                        MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("You must change your password to continue.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Loop
        End If
    End Sub
    Private Sub LoadUserDisplayName()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT first_name, last_name FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblDisplayName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                        Else
                            MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user display name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub LoadUserDisplayIdNumber()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT user_id FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblDisplayIdNumber.Text = reader("user_id").ToString()
                        Else
                            MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user ID number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckForOverdueRequests()
        LoadNotificationsData()
        UpdateNotificationTab()  ' Refresh tab header with unread count.
    End Sub

    Private Sub LoadUserProfileData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                ' Include phone_number in the SELECT statement.
                Dim query As String = "SELECT email, first_name, last_name, user_id, contact_number FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEmail.Text = reader("email").ToString()
                            txtFullName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                            txtStudentID.Text = reader("user_id").ToString()
                            ' Assign the phone number to the textbox.
                            txtPhoneNumber.Text = reader("contact_number").ToString()
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


    ' Reset Password Button Implementation.
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim changeForm As New ChangePasswordForm()
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

    Private Function UserMustChangePassword(userId As String) As Boolean
        Dim mustChange As Boolean = False
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT force_password_change FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Boolean.TryParse(result.ToString(), mustChange) Then
                        Return mustChange
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking password change requirement: " & ex.Message)
            End Try
        End Using
        Return mustChange
    End Function

    Private _borrowRequestsDT As DataTable

    ' Call this method to load the data (e.g., from Form_Load).
    Private Sub LoadBorrowRequestData()
        Using conn As MySqlConnection = Common.getDBConnection()
            _borrowRequestsDT = New DataTable()
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
                    adapter.Fill(_borrowRequestsDT)
                End Using
                dgvBorrowRequests.DataSource = _borrowRequestsDT.DefaultView
                If dgvBorrowRequests.Columns.Contains("RequestID") Then dgvBorrowRequests.Columns("RequestID").Visible = False
            Catch ex As Exception
                MessageBox.Show("Error loading borrow transactions: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Populate the ComboBox with status options.
    Private Sub LoadStatusFilterOptions()
        cbStatusFilter.Items.Clear()
        cbStatusFilter.Items.Add("All")
        cbStatusFilter.Items.Add("pending")
        cbStatusFilter.Items.Add("approved")
        cbStatusFilter.Items.Add("returned")
        cbStatusFilter.Items.Add("overdue")
        cbStatusFilter.Items.Add("declined")
        ' Optionally set "All" as the default selection.
        cbStatusFilter.SelectedIndex = 0
    End Sub

    ' Real-time filtering when a new status is selected.
    Private Sub cbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatusFilter.SelectedIndexChanged
        If _borrowRequestsDT IsNot Nothing Then
            Dim selectedStatus As String = cbStatusFilter.SelectedItem.ToString()
            If selectedStatus = "All" Then
                _borrowRequestsDT.DefaultView.RowFilter = ""
            Else
                _borrowRequestsDT.DefaultView.RowFilter = "Status = '" & selectedStatus.Replace("'", "''") & "'"
            End If
        End If
    End Sub

    '' Reset filter button clears the filter.
    'Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
    '    If _borrowRequestsDT IsNot Nothing Then
    '        _borrowRequestsDT.DefaultView.RowFilter = ""
    '        cbStatusFilter.SelectedIndex = 0 ' Reset selection to "All"
    '    End If
    'End Sub

    ' Borrow Request submission.
    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        Try
            ' Ensure an item is selected from the inventory DataGridView.
            If dgvInventory.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an item to borrow.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim itemId As Integer = Convert.ToInt32(selectedRow.Cells("Colitem_id").Value)
            Dim category As String = selectedRow.Cells("Colcategory").Value.ToString().ToLower()
            Dim itemStatus As String = selectedRow.Cells("colstatus").Value.ToString().ToLower()

            ' Check if the item is available.
            If itemStatus <> "available" Then
                MessageBox.Show("The selected item is not available for borrowing.", "Unavailable Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim borrowDate As DateTime = DateTime.Now
            Dim dueDate As DateTime = DateTime.Now.AddDays(7)

            Using conn As MySqlConnection = Common.getDBConnection()
                conn.Open()
                Dim query As String = ""
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                cmd.Parameters.AddWithValue("@borrowDate", borrowDate)
                cmd.Parameters.AddWithValue("@dueDate", dueDate)

                If category = "equipment" Then
                    ' Check for duplicate equipment request.
                    Dim checkQuery As String = "SELECT COUNT(*) FROM borrow_transactions WHERE user_id = @userId AND equipment_id = @itemId AND status IN ('pending','approved')"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                        checkCmd.Parameters.AddWithValue("@itemId", itemId)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("You have already requested this equipment. Cannot request again.", "Duplicate Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    End Using

                    ' Insert new equipment borrow request.
                    query = "INSERT INTO borrow_transactions (user_id, equipment_id, accessory_id, borrow_date, due_date, status) " &
                        "VALUES (@userId, @itemId, NULL, @borrowDate, @dueDate, 'pending')"
                    cmd.Parameters.AddWithValue("@itemId", itemId)

                ElseIf category = "accessory" Then
                    ' Check for duplicate accessory request.
                    Dim checkQuery As String = "SELECT COUNT(*) FROM borrow_transactions WHERE user_id = @userId AND accessory_id = @itemId AND status IN ('pending','approved')"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                        checkCmd.Parameters.AddWithValue("@itemId", itemId)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("You have already requested this accessory. Cannot request again.", "Duplicate Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    End Using

                    ' Prompt for borrow quantity.
                    Dim inputQuantity As String = InputBox("Enter the quantity to borrow:", "Quantity", "1")
                    Dim borrowQuantity As Integer = 0
                    If Not Integer.TryParse(inputQuantity, borrowQuantity) OrElse borrowQuantity <= 0 Then
                        MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ' Retrieve available quantity from the DataGridView (from the unified_inventory view).
                    Dim availableQuantity As Integer = Convert.ToInt32(selectedRow.Cells("quantity").Value)
                    If availableQuantity < borrowQuantity Then
                        MessageBox.Show("The requested quantity exceeds the available stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ' Insert new accessory borrow request.
                    query = "INSERT INTO borrow_transactions (user_id, equipment_id, accessory_id, borrow_date, due_date, status, borrow_quantity) " &
                        "VALUES (@userId, NULL, @itemId, @borrowDate, @dueDate, 'pending', @borrowQuantity)"
                    cmd.Parameters.AddWithValue("@itemId", itemId)
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
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoryFilterOptions()
        cbCategoryFilter.SelectedIndex = 0  ' Default to "All"
        LoadInventoryData()
    End Sub
    Private Sub LoadCategoryFilterOptions()
        cbCategoryFilter.Items.Clear()
        cbCategoryFilter.Items.Add("All")
        cbCategoryFilter.Items.Add("Equipment")
        cbCategoryFilter.Items.Add("Accessories")
        cbCategoryFilter.SelectedIndex = 0 ' Default to "All"
    End Sub
    ' Event handler to reload the inventory when the selected category changes.
    Private Sub cbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoryFilter.SelectedIndexChanged
        LoadInventoryData()
    End Sub
    ' Load inventory data from the unified_inventory view with optional category filtering.
    Private Sub LoadInventoryData()
        Using conn As MySqlConnection = Common.getDBConnection()
            Dim dt As New DataTable()
            Try
                conn.Open()
                Dim query As String = "SELECT item_id, item_name, item_type, quantity, status, added_at, brand, model, serial_number, category FROM unified_inventory"

                ' Check that the ComboBox has a selection and it's not "All"
                If cbCategoryFilter.SelectedItem IsNot Nothing AndAlso cbCategoryFilter.SelectedItem.ToString() <> "All" Then
                    query &= " WHERE category = @category"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If cbCategoryFilter.SelectedItem IsNot Nothing AndAlso cbCategoryFilter.SelectedItem.ToString() <> "All" Then
                        cmd.Parameters.AddWithValue("@category", cbCategoryFilter.SelectedItem.ToString())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvInventory.AutoGenerateColumns = False
                dgvInventory.DataSource = dt

                ' Optionally hide columns that you do not want to display.
                If dgvInventory.Columns.Contains("item_id") Then dgvInventory.Columns("item_id").Visible = False
                If dgvInventory.Columns.Contains("added_at") Then dgvInventory.Columns("added_at").Visible = False
                If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").Visible = False

                ' Map DataGridView columns to the DataTable columns.
                If dgvInventory.Columns.Contains("COLitem_name") Then dgvInventory.Columns("COLitem_name").DataPropertyName = "item_name"
                If dgvInventory.Columns.Contains("Colitem_type") Then dgvInventory.Columns("Colitem_type").DataPropertyName = "item_type"
                If dgvInventory.Columns.Contains("Colbrand") Then dgvInventory.Columns("Colbrand").DataPropertyName = "brand"
                If dgvInventory.Columns.Contains("Colmodel") Then dgvInventory.Columns("Colmodel").DataPropertyName = "model"
                If dgvInventory.Columns.Contains("Colcategory") Then dgvInventory.Columns("Colcategory").DataPropertyName = "category"
                If dgvInventory.Columns.Contains("Colitem_id") Then dgvInventory.Columns("Colitem_id").DataPropertyName = "item_id"
                If dgvInventory.Columns.Contains("Colstatus") Then dgvInventory.Columns("Colstatus").DataPropertyName = "status"

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
                Dim query As String = "SELECT notification_id, message, created_at FROM notifications WHERE user_id = @userId ORDER BY created_at DESC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dgvNotifications.AutoGenerateColumns = False
                ' Setup columns if none exist.
                If dgvNotifications.Columns.Count = 0 Then
                    Dim colId As New DataGridViewTextBoxColumn()
                    colId.Name = "notification_id"
                    colId.DataPropertyName = "notification_id"
                    colId.Visible = False
                    dgvNotifications.Columns.Add(colId)

                    Dim colMsg As New DataGridViewTextBoxColumn()
                    colMsg.Name = "Notification"
                    colMsg.HeaderText = "Notification"
                    colMsg.DataPropertyName = "message"
                    dgvNotifications.Columns.Add(colMsg)

                    Dim colDate As New DataGridViewTextBoxColumn()
                    colDate.Name = "Date"
                    colDate.HeaderText = "Date"
                    colDate.DataPropertyName = "created_at"
                    dgvNotifications.Columns.Add(colDate)
                End If
                dgvNotifications.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading notifications: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Style overdue notifications in dgvNotifications.
    Private Sub dgvNotifications_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvNotifications.DataBindingComplete
        For Each row As DataGridViewRow In dgvNotifications.Rows
            row.DefaultCellStyle.BackColor = Color.Empty
        Next
    End Sub

    Private Sub btnClearNotifications_Click(sender As Object, e As EventArgs) Handles btnClearNotifications.Click
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE notifications SET is_read = 1 WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("All notifications marked as read.", "Notifications Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Refresh notifications and update the notification tab.
                LoadNotificationsData()
                UpdateNotificationTab()
            Catch ex As Exception
                MessageBox.Show("Error clearing notifications: " & ex.Message)
            End Try
        End Using
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

                'lblActiveRequests.Text = "Active Requests: " & activeCount.ToString()
                'lblItemsBorrowed.Text = "Items Borrowed: " & borrowedCount.ToString()
                'lblOverdueItems.Text = "Overdue Items: " & overdueCount.ToString()
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

    ' Check for overdue requests and insert a notification that includes the item name.
    Private Sub CheckForOverdueRequests()
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim overdueQuery As String = "
                SELECT bt.transaction_id, bt.user_id,
                CASE 
                    WHEN bt.equipment_id IS NOT NULL THEN 
                        (SELECT item_name FROM unified_inventory WHERE category = 'Equipment' AND item_id = bt.equipment_id)
                    WHEN bt.accessory_id IS NOT NULL THEN 
                        (SELECT item_name FROM unified_inventory WHERE category = 'Accessory' AND item_id = bt.accessory_id)
                    ELSE 'Unknown'
                END AS ItemName
                FROM borrow_transactions bt
                WHERE bt.due_date < NOW() AND bt.status = 'approved'"
                Dim dtOverdue As New DataTable()
                Using cmd As New MySqlCommand(overdueQuery, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtOverdue)
                End Using

                For Each row As DataRow In dtOverdue.Rows
                    Dim transactionId As Integer = Convert.ToInt32(row("transaction_id"))
                    Dim userId As String = row("user_id").ToString()
                    Dim itemName As String = row("ItemName").ToString()
                    ' Build a notification message that only shows the item name.
                    Dim messageText As String = "Your borrow request for " & itemName & " is now overdue."

                    Dim checkQuery As String = "SELECT COUNT(*) FROM notifications WHERE message LIKE @msg AND user_id = @userId"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@msg", messageText & "%")
                        checkCmd.Parameters.AddWithValue("@userId", userId)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count = 0 Then
                            Dim insertQuery As String = "INSERT INTO notifications (user_id, message, is_read, created_at) VALUES (@userId, @message, 0, NOW())"
                            Using insertCmd As New MySqlCommand(insertQuery, conn)
                                insertCmd.Parameters.AddWithValue("@userId", userId)
                                insertCmd.Parameters.AddWithValue("@message", messageText)
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

    Private Sub UpdateNotificationTab()
        Dim unreadCount As Integer = 0
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM notifications WHERE user_id = @userId AND is_read = 0"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    unreadCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating notification count: " & ex.Message)
            End Try
        End Using

        ' Update the text of the notifications tab.
        If unreadCount > 0 Then
            tbcNotification.Text = "Notifications (" & unreadCount.ToString() & ")"
        Else
            tbcNotification.Text = "Notifications"
        End If
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Clear the current user session
        Common.CurrentUserId = ""
        ' Optionally, clear other session variables if needed:
        ' Common.CurrentUserRole = ""

        ' Close the current dashboard form
        Me.Close()
    End Sub

    Private Sub dgvNotifications_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotifications.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvNotifications.Rows(e.RowIndex)
            ' Retrieve the notification ID from the hidden column.
            Dim notificationId As Integer = Convert.ToInt32(row.Cells("notification_id").Value)
            ' Mark the notification as read.
            MarkNotificationAsRead(notificationId)
            ' Optionally, display the notification details.
            Dim msg As String = row.Cells("Notification").Value.ToString()
            MessageBox.Show(msg, "Notification Detail", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Refresh the notifications and tab count.
            LoadNotificationsData()
            UpdateNotificationTab()
        End If
    End Sub

    Private Sub MarkNotificationAsRead(notificationId As Integer)
        Using conn As MySqlConnection = Common.getDBConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE notifications SET is_read = 1 WHERE notification_id = @notificationId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@notificationId", notificationId)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error marking notification as read: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Guna2ShadowPanel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel4.Paint

    End Sub
End Class
