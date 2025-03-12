Imports MySql.Data.MySqlClient

Public Class AdminStaffDashboardForm
    Dim role As String = "staff" ' Set this dynamically based on the logged-in user's role

    Private Sub AdminStaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
        SetAccessByRole()
    End Sub

    Private Sub LoadInventory(Optional ByVal search As String = "")
        Try
            Dim conn = Common.getDBConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT * FROM equipment WHERE item_name LIKE @search"
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

    Private Sub SetAccessByRole()
        If role = "staff" Then
            btnAdditem.Enabled = False
            btnDeleteItems.Enabled = False
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        LoadInventory(txtSearchInv.Text.Trim())
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Try
            Dim conn = Common.getDBConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT * FROM equipment ORDER BY item_name ASC"
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

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        If role <> "admin" Then
            MessageBox.Show("Only admins can add items.")
            Return
        End If


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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim conn = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "DELETE FROM equipment WHERE item_id = @itemId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@itemId", itemId)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Item deleted successfully.")
                LoadInventory()
            Catch ex As Exception
                MessageBox.Show("Error deleting item: " & ex.Message)
            End Try
        End If
    End Sub
End Class
