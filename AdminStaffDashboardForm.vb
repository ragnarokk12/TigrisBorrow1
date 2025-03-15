Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class AdminStaffDashboardForm

    Private conn As MySqlConnection = Common.getDBConnection()
    Private role As String = "" ' Role will be dynamically fetched

    ' -------------------- FORM LOAD --------------------
    Private Sub AdminStaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserRole()
        LoadInventory()
        LoadAccounts() ' Now accepts an optional parameter; default is empty string.
        SetAccessByRole()
        LoadSortOptions()
    End Sub

    ' -------------------- FETCH USER ROLE --------------------
    Private Sub FetchUserRole()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT role FROM users WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                ' Ensure the current user id is trimmed and output it for debugging.
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


    ' -------------------- INVENTORY MANAGEMENT --------------------
    Private Sub LoadInventory(Optional ByVal search As String = "", Optional ByVal sortBy As String = "item_name", Optional ByVal sortOrder As String = "ASC")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim validColumns As New List(Of String)({"item_name", "category", "status", "quantity", "added_at"})
            If Not validColumns.Contains(sortBy) Then sortBy = "item_name"

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

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If

        Dim category As String = InputBox("Enter Category (Accessory/Equipment):").Trim().ToLower()
        If category <> "accessory" AndAlso category <> "equipment" Then
            MessageBox.Show("Invalid category. Please enter either 'Accessory' or 'Equipment'.")
            Return
        End If

        Dim itemName As String = InputBox("Enter Item Name:").Trim()
        If String.IsNullOrWhiteSpace(itemName) Then
            MessageBox.Show("Item name cannot be empty.")
            Return
        End If

        Dim quantityStr As String = InputBox("Enter Quantity:")
        If Not Integer.TryParse(quantityStr, Nothing) OrElse Convert.ToInt32(quantityStr) <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.")
            Return
        End If
        Dim quantity As Integer = Convert.ToInt32(quantityStr)
        Dim status As String = "available"

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = If(category = "accessory",
                "INSERT INTO accessories (accessory_name, accessory_type, quantity, status, added_at) VALUES (@name, 'General', @quantity, @status, NOW())",
                "INSERT INTO equipment (equipment_name, equipment_type, brand, model, serial_number, status, location, added_at) VALUES (@name, 'General', '', '', '', @status, '', NOW())")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", itemName)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show($"{category} item added successfully.")
            LoadInventory()
        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can delete items.")
            Return
        End If

        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        Dim itemId As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("item_id").Value)
        Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString()

        Dim query As String = If(category = "Accessory",
            "DELETE FROM accessories WHERE accessory_id = @itemId",
            "DELETE FROM equipment WHERE equipment_id = @itemId")

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@itemId", itemId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item deleted successfully.")
            LoadInventory()
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' -------------------- ACCOUNT MANAGEMENT --------------------
    ' Loads accounts into dgvAccount with an optional search filter.
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

    ' Trigger search for accounts.
    Private Sub btnGoAccount_Click(sender As Object, e As EventArgs) Handles btnGoAccount.Click
        LoadAccounts(txtSearchAccount.Text.Trim())
    End Sub

    ' Opens the SignUpForm for creating a new account.
    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        Dim signUpForm As New SignUpForm()
        signUpForm.ShowDialog()
        LoadAccounts()
    End Sub

    ' New: Edit Account Button – allows an admin to change all details of a user.
    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        ' Ensure a user is selected in dgvAccount.
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the selected user's school ID (user_id).
        Dim userId As String = dgvAccount.SelectedRows(0).Cells("user_id").Value.ToString()

        ' Open EditUserForm to allow editing of user details.
        Dim editForm As New EditUserForm()
        editForm.UserId = userId  ' Pass the user_id to the edit form.
        If editForm.ShowDialog() = DialogResult.OK Then
            ' Log the change with structured logging.
            Common.LogAction("EDIT_USER", userId, "USER", "User details updated by admin.")
            ' Refresh the accounts DataGridView after successful editing.
            LoadAccounts(txtSearchAccount.Text.Trim())
        End If
    End Sub



    ' -------------------- COMMON --------------------
    Private Sub LoadSortOptions()
        cbSortBy.Items.Clear()
        cbSortBy.Items.AddRange(New String() {"item_name", "category", "status", "quantity", "added_at"})
        cbSortBy.SelectedIndex = 0
    End Sub

    Private Sub SetAccessByRole()
        btnAdditem.Enabled = (role = "admin")
        btnDeleteItems.Enabled = (role = "admin")
        tbcAdminDashboard.Enabled = (role = "admin")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Clear global properties if needed
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty

        ' Simply close the dashboard form.
        Me.Close()
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub
End Class
