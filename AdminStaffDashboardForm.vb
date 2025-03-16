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

    ' -------------------- UPDATED ADD ITEM HANDLER --------------------
    ' Opens the AddItemForm and, if the item is successfully added, refreshes the inventory.
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        ' Only allow admins to add items.
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If

        ' Open AddItemForm as a modal dialog.
        Dim addForm As New AddItemForm()
        If addForm.ShowDialog() = DialogResult.OK AndAlso addForm.Added Then
            ' Since AddItemForm already performed the insert, simply refresh the data grid.
            MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadInventory()
        End If
    End Sub

    ' -------------------- DELETE ITEM HANDLER --------------------
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
        Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString().ToLower()

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult <> DialogResult.Yes Then Return

        ' For accessories, if quantity > 1, prompt for partial deletion.
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

                    If deleteQty < currentQuantity Then
                        Try
                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim updateQuery As String = "UPDATE accessories SET quantity = quantity - @deleteQty WHERE accessory_id = @itemId"
                            Using cmd As New MySqlCommand(updateQuery, conn)
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
                End If
            End If
        End If

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

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using cmd As New MySqlCommand(query, conn)
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

    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        Dim signUpForm As New SignUpForm()
        signUpForm.ShowDialog()
        LoadAccounts()
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
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty
        Me.Close()
    End Sub

End Class
