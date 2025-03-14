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
    ' Loads inventory data into the DataGridView with optional search, sort column, and sort order.
    Private Sub LoadInventory(Optional ByVal search As String = "", Optional ByVal sortBy As String = "item_name", Optional ByVal sortOrder As String = "ASC")
        Try
            ' Open the connection if closed.
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Define allowed columns and validate sortBy.
            Dim validColumns As New List(Of String)({"item_name", "category", "status", "quantity", "added_at"})
            If Not validColumns.Contains(sortBy) Then sortBy = "item_name"

            ' Validate sortOrder (only ASC or DESC allowed).
            If sortOrder.ToUpper() <> "ASC" AndAlso sortOrder.ToUpper() <> "DESC" Then
                sortOrder = "ASC"
            End If

            ' Build the SQL query with parameters.
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

    ' Called when the "Go" button is clicked; loads inventory using the search text.
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        LoadInventory(txtSearchInv.Text.Trim())
    End Sub

    ' Called when the "Sort" button is clicked; applies sorting based on the selected options.
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim sortBy As String = If(cbSortBy.SelectedItem IsNot Nothing, cbSortBy.SelectedItem.ToString(), "item_name")
        Dim sortOrder As String = If(chkDescending.Checked, "DESC", "ASC")
        LoadInventory(txtSearchInv.Text.Trim(), sortBy, sortOrder)
    End Sub

    ' Opens the AddItemForm to allow admins to add a new item.
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        ' Only allow admins to add items.
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If

        ' Open AddItemForm as a modal dialog.
        Dim addForm As New AddItemForm()
        If addForm.ShowDialog() = DialogResult.OK AndAlso addForm.Added Then
            Dim category As String = addForm.Category.ToLower()  ' "accessory" or "equipment"
            Dim itemName As String = addForm.ItemName
            Dim quantity As Integer = addForm.Quantity
            Dim status As String = "available"

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Build the INSERT query based on the selected category.
                Dim query As String = ""
                If category = "accessory" Then
                    query = "INSERT INTO accessories (accessory_name, accessory_type, quantity, status, added_at) VALUES (@name, 'General', @quantity, @status, NOW())"
                ElseIf category = "equipment" Then
                    query = "INSERT INTO equipment (equipment_name, equipment_type, brand, model, serial_number, status, location, added_at) VALUES (@name, 'General', '', '', '', @status, '', NOW())"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", itemName)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show($"{category} item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' (Optional) Log the addition if you use structured logging.
                Dim details As String = "{""item_name"":""" & itemName & """, ""category"":""" & category & """, ""quantity"":""" & quantity.ToString() & """}"
                Common.LogAction("ADD_ITEM", "", "ITEM", details)

                ' Refresh the inventory list.
                LoadInventory()
            Catch ex As Exception
                MessageBox.Show("Error adding item: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        ' Only allow admins to delete items.
        If role <> "admin" Then
            MessageBox.Show("Only admins can delete items.")
            Return
        End If

        ' Ensure an item is selected in the DataGridView.
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        ' Retrieve the selected item's ID and category.
        Dim itemId As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("item_id").Value)
        Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString().ToLower()

        ' Confirmation popup to prevent accidental deletion.
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult <> DialogResult.Yes Then Return

        ' For accessories, if quantity > 1, prompt the admin for partial deletion.
        If category = "accessory" Then
            Dim currentQuantityObj As Object = dgvInventory.SelectedRows(0).Cells("quantity").Value
            Dim currentQuantity As Integer = 0
            If currentQuantityObj IsNot Nothing AndAlso Integer.TryParse(currentQuantityObj.ToString(), currentQuantity) Then
                If currentQuantity > 1 Then
                    Dim inputQtyStr As String = InputBox("This item has a quantity of " & currentQuantity.ToString() & ". Enter the number of units to delete:", "Delete Quantity", currentQuantity.ToString())
                    Dim deleteQty As Integer
                    If Not Integer.TryParse(inputQtyStr, deleteQty) OrElse deleteQty <= 0 OrElse deleteQty > currentQuantity Then
                        MessageBox.Show("Invalid quantity entered.")
                        Return
                    End If

                    ' If the admin wants to delete only a portion of the units, update the quantity.
                    If deleteQty < currentQuantity Then
                        Try
                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim updateQuery As String = "UPDATE accessories SET quantity = quantity - @deleteQty WHERE accessory_id = @itemId"
                            Using cmd As New MySqlCommand(updateQuery, conn)
                                ' Use parameters to prevent SQL injection.
                                cmd.Parameters.AddWithValue("@deleteQty", deleteQty)
                                cmd.Parameters.AddWithValue("@itemId", itemId)
                                cmd.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Item quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadInventory()
                            Return
                        Catch ex As Exception
                            MessageBox.Show("Error updating item quantity: " & ex.Message)
                            Return
                        Finally
                            conn.Close()
                        End Try
                    End If
                    ' If deleteQty equals currentQuantity, then proceed with full deletion.
                End If
            End If
        End If

        ' Determine the DELETE query based on the category.
        Dim query As String = ""
        Select Case category
            Case "accessory"
                query = "DELETE FROM accessories WHERE accessory_id = @itemId"
            Case "equipment"
                query = "DELETE FROM equipment WHERE equipment_id = @itemId"
            Case Else
                MessageBox.Show("Invalid category.")
                Return
        End Select

        ' Execute the full deletion query.
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Bind parameter to prevent SQL injection.
                cmd.Parameters.AddWithValue("@itemId", itemId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

End Class
