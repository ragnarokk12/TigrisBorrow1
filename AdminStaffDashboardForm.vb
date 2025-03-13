Imports MySql.Data.MySqlClient

Public Class AdminStaffDashboardForm
    Dim role As String = "staff" ' This should be set dynamically based on the logged-in user's role

    Private Sub AdminStaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
        SetAccessByRole()
    End Sub

    ' Loads inventory items from the unified_inventory view
    Private Sub LoadInventory(Optional ByVal search As String = "")
        Try
            Dim conn = Common.getDBConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query the unified view rather than just the equipment table.
            Dim query As String = "SELECT * FROM unified_inventory WHERE item_name LIKE @search"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvInventory.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        End Try
    End Sub

    ' Sets access permissions based on the user's role.
    ' Staff cannot add or delete items, while admins can.
    Private Sub SetAccessByRole()
        If role = "staff" Then
            btnAdditem.Enabled = False
            btnDeleteItems.Enabled = False
        Else
            btnAdditem.Enabled = True
            btnDeleteItems.Enabled = True
        End If
    End Sub

    ' Trigger inventory search when clicking the "Go" button
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        LoadInventory(txtSearchInv.Text.Trim())
    End Sub

    ' Sorts inventory by item name (alphabetically) from the unified view
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Try
            Dim conn = Common.getDBConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT * FROM unified_inventory ORDER BY item_name ASC"
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvInventory.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sorting inventory: " & ex.Message)
        End Try
    End Sub

    ' Adds a new item (only if the user is an admin)
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If

        ' Functionality to add an item goes here.
        MessageBox.Show("Add item functionality not implemented yet.")
    End Sub

    ' Deletes a selected item.
    ' Checks the item's category to determine which table to delete from.
    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can delete items.")
            Return
        End If

        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        ' Retrieve the item ID and category from the selected row.
        Dim itemId As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("item_id").Value)
        Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim conn = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = ""
                ' Determine which table to delete from based on category
                If category.Equals("Accessory", StringComparison.OrdinalIgnoreCase) Then
                    query = "DELETE FROM accessories WHERE accessory_id = @itemId"
                ElseIf category.Equals("Equipment", StringComparison.OrdinalIgnoreCase) Then
                    query = "DELETE FROM equipment WHERE equipment_id = @itemId"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@itemId", itemId)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Item deleted successfully.")
                LoadInventory() ' Reload the inventory after deletion
            Catch ex As Exception
                MessageBox.Show("Error deleting item: " & ex.Message)
            End Try
        End If
    End Sub
End Class
