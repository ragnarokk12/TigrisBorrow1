Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
'Imports Excel = Microsoft.Office.Interop.Excel

Public Class AdminStaffDashboardForm

    Private conn As MySqlConnection = Common.getDBConnection()
    Private role As String = ""
    Private WithEvents searchTimer As New Timer With {.Interval = 500} ' 500ms debounce interval
    Private Const InventorySearchPlaceholder As String = "Search Inventory"

    Private Sub AdminStaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserRole()
        LoadInventory()
        LoadAccounts()
        SetAccessByRole()
        LoadBorrowRequests()
        PopulateMonthAndYearFilters()   ' Populate the month and year combo boxes.
        LoadActionTypeOptions()           ' Populate the action type ComboBox.
        LoadDailyReport()               ' Load daily report if needed.
        LoadCategoryFilter()
        LoadAccountRoleFilter()
        txtSearchInv.Text = InventorySearchPlaceholder
        txtSearchInv.ForeColor = Color.Gray
        txtSearchInv.AccessibleName = "Inventory Search"
        txtSearchInv.AccessibleDescription = "Enter keywords to search inventory items."
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

    ' Updated LoadInventory method with an additional category filter parameter.
    Private Sub LoadInventory(Optional ByVal search As String = "", Optional ByVal sortBy As String = "item_name", Optional ByVal sortOrder As String = "ASC", Optional ByVal categoryFilter As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim validColumns As New List(Of String)({"item_name", "category", "status", "quantity", "added_at"})
            If Not validColumns.Contains(sortBy) Then sortBy = "item_name"
            If sortOrder.ToUpper() <> "ASC" AndAlso sortOrder.ToUpper() <> "DESC" Then sortOrder = "ASC"

            Dim query As String = "SELECT * FROM unified_inventory WHERE (item_name LIKE @search OR serial_number LIKE @search)"
            ' Apply category filter if not empty.
            If Not String.IsNullOrEmpty(categoryFilter) Then
                query &= " AND category = @categoryFilter"
            End If
            query &= $" ORDER BY {sortBy} {sortOrder}"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                If Not String.IsNullOrEmpty(categoryFilter) Then
                    cmd.Parameters.AddWithValue("@categoryFilter", categoryFilter)
                End If
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvInventory.DataSource = table
            End Using

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If dgvInventory.Columns.Contains("item_id") Then dgvInventory.Columns("item_id").Visible = False

            ' Update headers as needed.
            If dgvInventory.Columns.Contains("item_name") Then dgvInventory.Columns("item_name").HeaderText = "Item Name"
            If dgvInventory.Columns.Contains("item_type") Then dgvInventory.Columns("item_type").HeaderText = "Item Type"
            If dgvInventory.Columns.Contains("category") Then dgvInventory.Columns("category").HeaderText = "Category"
            If dgvInventory.Columns.Contains("brand") Then dgvInventory.Columns("brand").HeaderText = "Brand"
            If dgvInventory.Columns.Contains("model") Then dgvInventory.Columns("model").HeaderText = "Model"
            If dgvInventory.Columns.Contains("serial_number") Then dgvInventory.Columns("serial_number").HeaderText = "Serial Number"
            If dgvInventory.Columns.Contains("status") Then dgvInventory.Columns("status").HeaderText = "Status"
            If dgvInventory.Columns.Contains("quantity") Then dgvInventory.Columns("quantity").HeaderText = "Quantity"
            If dgvInventory.Columns.Contains("added_at") Then
                dgvInventory.Columns("added_at").HeaderText = "Date Added"
                dgvInventory.Columns("added_at").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.Title = "Save Daily Data Report as CSV"
            sfd.FileName = "DailyDataReport.csv"

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Using sw As New System.IO.StreamWriter(sfd.FileName)
                ' Write column headers.
                Dim headerValues As New List(Of String)
                For Each col As DataGridViewColumn In dgvDailyDataReport.Columns
                    headerValues.Add("""" & col.HeaderText.Replace("""", """""") & """")
                Next
                sw.WriteLine(String.Join(",", headerValues))

                ' Write data rows.
                For Each row As DataGridViewRow In dgvDailyDataReport.Rows
                    ' Skip the new row placeholder.
                    If Not row.IsNewRow Then
                        Dim rowValues As New List(Of String)
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.Value IsNot Nothing Then
                                rowValues.Add("""" & cell.Value.ToString().Replace("""", """""") & """")
                            Else
                                rowValues.Add("")
                            End If
                        Next
                        sw.WriteLine(String.Join(",", rowValues))
                    End If
                Next

                ' Add a blank line and then a summary count.
                sw.WriteLine()
                sw.WriteLine("Total Records: " & dgvDailyDataReport.Rows.Count.ToString())
            End Using

            MessageBox.Show("CSV export successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error exporting CSV: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    '    Try
    '        ' Create an instance of Excel and add a workbook.
    '        Dim xlApp As New Excel.Application
    '        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
    '        Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)

    '        ' Save the header image (from project resources) to a temporary file.
    '        ' Build the full path to the image from the application's startup path.
    '        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "Logo", "HeaderImage.png")

    '        ' Verify that the image file exists.
    '        If Not IO.File.Exists(imagePath) Then
    '            MessageBox.Show("Header image not found at: " & imagePath)
    '            Return
    '        End If

    '        ' Use the imagePath directly when adding the picture.
    '        xlWorksheet.Shapes.AddPicture(imagePath,
    '                          LinkToFile:=False,
    '                          SaveWithDocument:=True,
    '                          Left:=10,
    '                          Top:=10,
    '                          Width:=100,
    '                          Height:=50)


    '        ' Define starting positions for the export (leave room for the image).
    '        Dim startRow As Integer = 3
    '        Dim startCol As Integer = 1

    '        ' Write column headers from dgvDailyDataReport.
    '        For colIndex As Integer = 0 To dgvDailyDataReport.Columns.Count - 1
    '            xlWorksheet.Cells(startRow, startCol + colIndex) = dgvDailyDataReport.Columns(colIndex).HeaderText

    '            ' Get the range for the header cell.
    '            Dim headerRange As Excel.Range = CType(xlWorksheet.Cells(startRow, startCol + colIndex), Excel.Range)
    '            headerRange.Font.Bold = True

    '            ' Apply a subtle gradient-like effect using a light pink background.
    '            ' (Note: True gradient fill via Interop is more complex. Here we use a solid fill for simplicity.)
    '            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightPink)
    '        Next

    '        ' Write data rows starting just below the headers.
    '        For rowIndex As Integer = 0 To dgvDailyDataReport.Rows.Count - 1
    '            For colIndex As Integer = 0 To dgvDailyDataReport.Columns.Count - 1
    '                Dim cellValue = dgvDailyDataReport.Rows(rowIndex).Cells(colIndex).Value
    '                xlWorksheet.Cells(startRow + 1 + rowIndex, startCol + colIndex) = cellValue
    '            Next
    '        Next

    '        ' Add a summary count at the end (total records).
    '        Dim summaryRow As Integer = startRow + 1 + dgvDailyDataReport.Rows.Count
    '        xlWorksheet.Cells(summaryRow, startCol) = "Total Records: " & dgvDailyDataReport.Rows.Count.ToString()

    '        ' Auto-fit columns for better appearance.
    '        xlWorksheet.Columns.AutoFit()

    '        ' Show a SaveFileDialog to choose where to save the Excel file.
    '        Dim sfd As New SaveFileDialog()
    '        sfd.Filter = "Excel Workbook|*.xlsx"
    '        sfd.Title = "Save Daily Data Report"
    '        sfd.FileName = "DailyDataReport.xlsx"

    '        If sfd.ShowDialog() = DialogResult.OK Then
    '            xlWorkbook.SaveAs(sfd.FileName)
    '            MessageBox.Show("Export successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '        ' Clean up Excel objects.
    '        xlWorkbook.Close()
    '        xlApp.Quit()
    '        ReleaseObject(xlWorksheet)
    '        ReleaseObject(xlWorkbook)
    '        ReleaseObject(xlApp)

    '        ' Delete the temporary image file.
    '        If IO.File.Exists(tempImagePath) Then
    '            IO.File.Delete(tempImagePath)
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Error exporting report: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '' Helper subroutine to release COM objects.
    'Private Sub ReleaseObject(ByVal obj As Object)
    '    Try
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
    '        obj = Nothing
    '    Catch ex As Exception
    '        obj = Nothing
    '    Finally
    '        GC.Collect()
    '    End Try
    'End Sub

    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
        ' Check if a row is selected in the inventory DataGridView.
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an accessory from the inventory.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
        Dim itemCategory As String = selectedRow.Cells("category").Value.ToString().ToLower()

        ' Ensure the selected item is an accessory.
        If itemCategory <> "accessory" Then
            MessageBox.Show("Quantity editing is only applicable for accessories.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Retrieve the accessory ID and current quantity.
        Dim accessoryId As Integer
        Dim currentQuantity As Integer
        If Not Integer.TryParse(selectedRow.Cells("item_id").Value.ToString(), accessoryId) Then
            MessageBox.Show("Failed to retrieve accessory ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(selectedRow.Cells("quantity").Value.ToString(), currentQuantity) Then
            MessageBox.Show("Failed to retrieve current quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Prompt the user for the new quantity.
        Dim input As String = InputBox("Enter the new quantity for the selected accessory:", "Edit Quantity", currentQuantity.ToString())
        Dim newQuantity As Integer
        If String.IsNullOrWhiteSpace(input) Then
            MessageBox.Show("No quantity entered. Operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not Integer.TryParse(input, newQuantity) OrElse newQuantity < 0 Then
            MessageBox.Show("Please enter a valid non-negative integer for quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update the quantity in the database.
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim updateQuery As String = "UPDATE accessories SET quantity = @quantity WHERE accessory_id = @accessoryId"
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@quantity", newQuantity)
                cmd.Parameters.AddWithValue("@accessoryId", accessoryId)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Accessory quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadInventory() ' Refresh the inventory to reflect changes.
                Else
                    MessageBox.Show("No changes were made. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating accessory quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
    End Sub
    Private Sub LoadCategoryFilter()
        cbCategoryFilter.Items.Clear()
        cbCategoryFilter.Items.Add("All")
        cbCategoryFilter.Items.Add("Accessory")
        cbCategoryFilter.Items.Add("Equipment")
        cbCategoryFilter.SelectedIndex = 0  ' This sets the default text to "All"
    End Sub

    ' New subroutine to apply inventory filters.
    Private Sub ApplyInventoryFilters()
        Dim searchTerm As String = If(txtSearchInv.Text = InventorySearchPlaceholder, "", txtSearchInv.Text.Trim())
        Dim categoryFilter As String = ""
        If cbCategoryFilter.SelectedItem IsNot Nothing AndAlso cbCategoryFilter.SelectedItem.ToString().ToLower() <> "all" Then
            categoryFilter = cbCategoryFilter.SelectedItem.ToString()
        End If
        LoadInventory(searchTerm, "item_name", "ASC", categoryFilter)
        lblFilterSummary.Text = "Filters - Search: " & If(String.IsNullOrEmpty(searchTerm), "None", searchTerm) & ", Category: " & If(String.IsNullOrEmpty(categoryFilter), "All", categoryFilter)
    End Sub
    ' Event handler for when the category filter changes.
    Private Sub cbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoryFilter.SelectedIndexChanged
        ApplyInventoryFilters()
    End Sub
    ' Event handler for Clear Filters button.
    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        txtSearchInv.Text = InventorySearchPlaceholder
        cbCategoryFilter.SelectedItem = "All"
        lblFilterSummary.Text = "Filters - None"
        LoadInventory() ' Reload inventory without filters.
    End Sub

    Private Sub btnRefreshInventory_Click(sender As Object, e As EventArgs) Handles btnRefreshInventory.Click
        ' Reset filters to default values.
        txtSearchInv.Text = InventorySearchPlaceholder
        cbCategoryFilter.SelectedIndex = 0
        lblFilterSummary.Text = "Filters - None"

        ' Reload the inventory.
        LoadInventory()

        MessageBox.Show("Inventory refreshed.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshDeploy.Click
        LoadBorrowRequests()
        LoadDailyReport() ' Refresh the daily report as well
    End Sub
    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        ' Ensure a row is selected.
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
        Dim itemCategory As String = selectedRow.Cells("category").Value.ToString().ToLower()
        Dim itemId As Integer
        If Not Integer.TryParse(selectedRow.Cells("item_id").Value.ToString(), itemId) Then
            MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion with the user.
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected " & itemCategory & " item?",
                                                         "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim deleteQuery As String = ""

            ' Determine which underlying table to delete from.
            If itemCategory = "accessory" Then
                deleteQuery = "DELETE FROM accessories WHERE accessory_id = @itemId"
            ElseIf itemCategory = "equipment" Then
                deleteQuery = "DELETE FROM equipment WHERE equipment_id = @itemId"
            Else
                MessageBox.Show("Unknown item category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using cmd As New MySqlCommand(deleteQuery, conn)
                cmd.Parameters.AddWithValue("@itemId", itemId)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadInventory() ' Refresh inventory to reflect deletion.
                Else
                    MessageBox.Show("Failed to delete the item. It may have already been removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
    End Sub

    Private Sub txtSearchInv_Enter(sender As Object, e As EventArgs) Handles txtSearchInv.Enter
        If txtSearchInv.Text = InventorySearchPlaceholder Then
            txtSearchInv.Text = ""
            txtSearchInv.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchInv_Leave(sender As Object, e As EventArgs) Handles txtSearchInv.Leave
        If String.IsNullOrWhiteSpace(txtSearchInv.Text) Then
            txtSearchInv.Text = InventorySearchPlaceholder
            txtSearchInv.ForeColor = Color.Gray
        End If
    End Sub
    ' Trigger search on Enter key press.
    Private Sub txtSearchInv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchInv.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent default beep sound.
            Dim searchTerm As String = If(txtSearchInv.Text = InventorySearchPlaceholder, "", txtSearchInv.Text.Trim())
            LoadInventory(searchTerm)
        End If
    End Sub

    ' Debounce search while typing to avoid excessive calls.
    Private Sub txtSearchInv_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInv.TextChanged
        searchTimer.Stop()
        searchTimer.Start()
    End Sub

    ' Timer tick event to trigger the search after the debounce interval.
    Private Sub searchTimer_Tick(sender As Object, e As EventArgs) Handles searchTimer.Tick
        searchTimer.Stop()
        Dim searchTerm As String = If(txtSearchInv.Text = InventorySearchPlaceholder, "", txtSearchInv.Text.Trim())
        LoadInventory(searchTerm)
        ApplyInventoryFilters()
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

    Private Sub LoadAccounts(Optional ByVal searchQuery As String = "", Optional ByVal roleFilter As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT user_id, first_name, last_name, email, contact_number, role, created_at FROM users"
            Dim whereClauses As New List(Of String)

            If Not String.IsNullOrEmpty(searchQuery) Then
                whereClauses.Add("(user_id LIKE @search OR first_name LIKE @search OR last_name LIKE @search OR email LIKE @search)")
            End If

            If Not String.IsNullOrEmpty(roleFilter) AndAlso roleFilter.ToLower() <> "all" Then
                whereClauses.Add("role = @roleFilter")
            End If

            If whereClauses.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClauses)
            End If

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrEmpty(searchQuery) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                End If
                If Not String.IsNullOrEmpty(roleFilter) AndAlso roleFilter.ToLower() <> "all" Then
                    cmd.Parameters.AddWithValue("@roleFilter", roleFilter.ToLower())
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

    Private Sub ApplyAccountFilters()
        Dim searchQuery As String = ""
        If txtSearchAccount.Text <> AccountSearchPlaceholder Then
            searchQuery = txtSearchAccount.Text.Trim()
        End If

        Dim roleFilter As String = ""
        If cbAccountRoleFilter.SelectedItem IsNot Nothing AndAlso cbAccountRoleFilter.SelectedItem.ToString().ToLower() <> "all" Then
            roleFilter = cbAccountRoleFilter.SelectedItem.ToString()
        End If

        LoadAccounts(searchQuery, roleFilter)
    End Sub


    Private Const AccountSearchPlaceholder As String = "Search Account"
    Private Sub txtSearchAccount_Enter(sender As Object, e As EventArgs) Handles txtSearchAccount.Enter
        If txtSearchAccount.Text = AccountSearchPlaceholder Then
            txtSearchAccount.Text = ""
            txtSearchAccount.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchAccount_Leave(sender As Object, e As EventArgs) Handles txtSearchAccount.Leave
        If String.IsNullOrWhiteSpace(txtSearchAccount.Text) Then
            txtSearchAccount.Text = AccountSearchPlaceholder
            txtSearchAccount.ForeColor = Color.Gray
        End If
    End Sub


    ' When the search text changes (you can use a debounce mechanism similar to inventory if needed)
    Private Sub txtSearchAccount_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAccount.TextChanged
        ApplyAccountFilters()
    End Sub

    ' When the role filter selection changes
    Private Sub cbAccountRoleFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountRoleFilter.SelectedIndexChanged
        ApplyAccountFilters()
    End Sub

    Private Sub btnClearAccountFilters_Click(sender As Object, e As EventArgs) Handles btnClearAccountFilters.Click
        txtSearchAccount.Text = AccountSearchPlaceholder
        txtSearchAccount.ForeColor = Color.Gray
        cbAccountRoleFilter.SelectedIndex = 0 ' Assuming "All" is the first item.
        LoadAccounts()
    End Sub
    Private Sub LoadAccountRoleFilter()
        cbAccountRoleFilter.Items.Clear()
        cbAccountRoleFilter.Items.Add("All")
        cbAccountRoleFilter.Items.Add("admin")
        cbAccountRoleFilter.Items.Add("staff")
        cbAccountRoleFilter.Items.Add("student")
        cbAccountRoleFilter.SelectedIndex = 0
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

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        ' Ensure only admin can reset passwords.
        If role <> "admin" Then
            MessageBox.Show("Only admin users can reset passwords.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if an account is selected in the DataGridView.
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an account to reset its password.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvAccount.SelectedRows(0)
        Dim selectedUserId As String = selectedRow.Cells("user_id").Value.ToString()

        ' Confirm the reset action.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset the password for account: " & selectedUserId & "?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then Return

        ' Define the default password and hash it.
        Dim defaultPassword As String = "password123"
        Dim hashedPassword As String = HashPassword(defaultPassword)

        ' Update the user's password, last_password_change, and force a password change.
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "UPDATE users SET password_hash = @hashedPassword, last_password_change = NOW(), force_password_change = TRUE WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword)
                cmd.Parameters.AddWithValue("@userId", selectedUserId)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    ' Log the admin action.
                    Common.LogAction("RESET_PASSWORD", selectedUserId, "USER", "Password reset to default by admin.")
                    MessageBox.Show("Password reset successfully. The default password is: " & defaultPassword, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to reset the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
    End Sub


    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub SetAccessByRole()
        btnAdditem.Enabled = (role = "admin")
        btnDeleteItems.Enabled = (role = "admin")
        tbcAdminDashboard.Enabled = (role = "admin" Or role = "staff")
        btnApprove.Enabled = (role = "admin" Or role = "staff")
        btnDeny.Enabled = (role = "admin" Or role = "staff")
        btnCheckReturn.Enabled = (role = "admin" Or role = "staff")
    End Sub

    Private Sub LoadBorrowRequests(Optional ByVal statusFilter As String = "", Optional ByVal search As String = "")
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
    bt.borrow_quantity AS quantity,
    bt.status,
    bt.approved_by,
    bt.approval_date,
    bt.return_date,
    bt.return_condition
FROM borrow_transactions bt
JOIN users u ON bt.user_id = u.user_id
LEFT JOIN equipment e ON bt.equipment_id = e.equipment_id
LEFT JOIN accessories a ON bt.accessory_id = a.accessory_id
WHERE 1 = 1
"
            ' Append status filter if provided.
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND bt.status = @statusFilter"
            End If

            ' Append search filter if provided.
            If Not String.IsNullOrEmpty(search) Then
                query &= " AND (CONCAT(u.first_name, ' ', u.last_name) LIKE @search OR e.equipment_name LIKE @search OR a.accessory_name LIKE @search)"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If Not String.IsNullOrEmpty(statusFilter) Then
                cmd.Parameters.AddWithValue("@statusFilter", statusFilter)
            End If
            If Not String.IsNullOrEmpty(search) Then
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvBorrowRequests.DataSource = table

            dgvBorrowRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If dgvBorrowRequests.Columns.Contains("transaction_id") Then
                dgvBorrowRequests.Columns("transaction_id").Visible = False
            End If

            ' Set header text for clarity.
            If dgvBorrowRequests.Columns.Contains("borrower") Then
                dgvBorrowRequests.Columns("borrower").HeaderText = "Borrower"
            End If
            If dgvBorrowRequests.Columns.Contains("item_category") Then
                dgvBorrowRequests.Columns("item_category").HeaderText = "Category"
            End If
            If dgvBorrowRequests.Columns.Contains("item_name") Then
                dgvBorrowRequests.Columns("item_name").HeaderText = "Item Name"
            End If
            If dgvBorrowRequests.Columns.Contains("borrow_date") Then
                dgvBorrowRequests.Columns("borrow_date").HeaderText = "Borrow Date"
                dgvBorrowRequests.Columns("borrow_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            If dgvBorrowRequests.Columns.Contains("due_date") Then
                dgvBorrowRequests.Columns("due_date").HeaderText = "Due Date"
                dgvBorrowRequests.Columns("due_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            If dgvBorrowRequests.Columns.Contains("condition_before") Then
                dgvBorrowRequests.Columns("condition_before").HeaderText = "Condition Before"
            End If
            If dgvBorrowRequests.Columns.Contains("quantity") Then
                dgvBorrowRequests.Columns("quantity").HeaderText = "Quantity"
            End If
            If dgvBorrowRequests.Columns.Contains("status") Then
                dgvBorrowRequests.Columns("status").HeaderText = "Status"
            End If
            If dgvBorrowRequests.Columns.Contains("approved_by") Then
                dgvBorrowRequests.Columns("approved_by").HeaderText = "Approved By"
            End If
            If dgvBorrowRequests.Columns.Contains("approval_date") Then
                dgvBorrowRequests.Columns("approval_date").HeaderText = "Approval Date"
            End If
            If dgvBorrowRequests.Columns.Contains("return_date") Then
                dgvBorrowRequests.Columns("return_date").HeaderText = "Return Date"
            End If
            If dgvBorrowRequests.Columns.Contains("return_condition") Then
                dgvBorrowRequests.Columns("return_condition").HeaderText = "Return Condition"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading borrow requests: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ApplyBorrowRequestFilters()
        Dim searchTerm As String = txtSearchBorrowRequests.Text.Trim() ' Ensure this textbox exists on your form.
        Dim statusFilter As String = ""

        ' Optionally, use a ComboBox for status filtering.
        If cbBorrowStatusFilter.SelectedItem IsNot Nothing AndAlso cbBorrowStatusFilter.SelectedItem.ToString().ToLower() <> "all" Then
            statusFilter = cbBorrowStatusFilter.SelectedItem.ToString()
        End If

        LoadBorrowRequests(statusFilter, searchTerm)
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

    ' Updated btnDeny_Click event handler
    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a borrow request to decline.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("transaction_id").Value)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim updateQuery As String = "
UPDATE borrow_transactions
SET status = 'declined'
WHERE transaction_id = @transactionId AND status = 'pending'
"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@transactionId", transactionId)
            Dim rowsAffected = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Borrow request declined successfully.")
            Else
                MessageBox.Show("Failed to decline the request. It may have been updated already.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error declining borrow request: " & ex.Message)
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

        Dim currentStatus As String = dgvBorrowRequests.SelectedRows(0).Cells("status").Value.ToString().ToLower()
        If currentStatus <> "returned" Then
            MessageBox.Show("Selected transaction is not marked as returned.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("transaction_id").Value)
        Dim itemCategory As String = dgvBorrowRequests.SelectedRows(0).Cells("item_category").Value.ToString()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            If itemCategory = "Equipment" Then
                ' For equipment, prompt for condition and then update directly to "completed"
                Dim conditionInput As String = InputBox("Enter the condition of the equipment upon return (new, good, fair, poor, damaged):", "Return Condition")
                If String.IsNullOrEmpty(conditionInput) Then
                    MessageBox.Show("Return condition is required for equipment.")
                    Return
                End If

                Dim validConditions As New List(Of String) From {"new", "good", "fair", "poor", "damaged"}
                If Not validConditions.Contains(conditionInput.ToLower()) Then
                    MessageBox.Show("Invalid condition entered. Please enter one of: new, good, fair, poor, damaged.")
                    Return
                End If

                Dim updateQuery As String = "
UPDATE borrow_transactions
SET return_condition = @condition,
    status = 'completed'
WHERE transaction_id = @transactionId AND status = 'returned'"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@condition", conditionInput.ToLower())
                    cmd.Parameters.AddWithValue("@transactionId", transactionId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Equipment return processed and marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update equipment return. It may have been updated already.")
                    End If
                End Using

            ElseIf itemCategory = "Accessory" Then
                ' For accessories, update status directly to "completed"
                Dim updateQuery As String = "
UPDATE borrow_transactions
SET status = 'completed'
WHERE transaction_id = @transactionId AND status = 'returned'"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@transactionId", transactionId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Accessory return processed and marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update accessory return. It may have been updated already.")
                    End If
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating return status: " & ex.Message)
        Finally
            conn.Close()
        End Try

        LoadBorrowRequests()
    End Sub


    ' Update LoadDailyReport to show item name in the Details column.
    Private Sub LoadDailyReport(Optional ByVal startDate As DateTime? = Nothing, Optional ByVal endDate As DateTime? = Nothing, Optional ByVal actionTypeFilter As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT u.user_id AS ID, " &
                              "CONCAT(u.first_name, ' ', u.last_name) AS UserName, " &
                              "bt.status AS ActionType, " &
                              "CASE " &
                              "    WHEN bt.equipment_id IS NOT NULL THEN e.equipment_name " &
                              "    WHEN bt.accessory_id IS NOT NULL THEN a.accessory_name " &
                              "    ELSE 'N/A' " &
                              "END AS Details, " &
                              "bt.borrow_date AS ActionTime, " &
                              "bt.approved_by AS ApprovedBy, " &
                              "bt.return_condition AS ReturnCondition " &
                              "FROM borrow_transactions bt " &
                              "JOIN users u ON bt.user_id = u.user_id " &
                              "LEFT JOIN equipment e ON bt.equipment_id = e.equipment_id " &
                              "LEFT JOIN accessories a ON bt.accessory_id = a.accessory_id " &
                              "WHERE 1=1 AND bt.status <> 'pending'"

            ' Add date range filters:
            If startDate.HasValue Then
                query &= " AND bt.borrow_date >= @startDate"
            End If
            If endDate.HasValue Then
                query &= " AND bt.borrow_date <= @endDate"
            End If

            ' Add action type filter if not "All"
            If Not String.IsNullOrEmpty(actionTypeFilter) AndAlso actionTypeFilter <> "All" Then
                query &= " AND bt.status = @actionTypeFilter"
            End If

            query &= " ORDER BY ActionTime DESC"

            Using cmd As New MySqlCommand(query, conn)
                If startDate.HasValue Then cmd.Parameters.AddWithValue("@startDate", startDate.Value)
                If endDate.HasValue Then cmd.Parameters.AddWithValue("@endDate", endDate.Value)
                If Not String.IsNullOrEmpty(actionTypeFilter) AndAlso actionTypeFilter <> "All" Then
                    cmd.Parameters.AddWithValue("@actionTypeFilter", actionTypeFilter)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvDailyDataReport.DataSource = table
            End Using

            dgvDailyDataReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If dgvDailyDataReport.Columns.Contains("ID") Then dgvDailyDataReport.Columns("ID").HeaderText = "User ID"
            If dgvDailyDataReport.Columns.Contains("UserName") Then dgvDailyDataReport.Columns("UserName").HeaderText = "User Name"
            If dgvDailyDataReport.Columns.Contains("ActionType") Then dgvDailyDataReport.Columns("ActionType").HeaderText = "Action Type"
            If dgvDailyDataReport.Columns.Contains("Details") Then dgvDailyDataReport.Columns("Details").HeaderText = "Item Name"
            If dgvDailyDataReport.Columns.Contains("ActionTime") Then
                dgvDailyDataReport.Columns("ActionTime").HeaderText = "Action Time"
                dgvDailyDataReport.Columns("ActionTime").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            End If
            If dgvDailyDataReport.Columns.Contains("ApprovedBy") Then dgvDailyDataReport.Columns("ApprovedBy").HeaderText = "Approved By"
            If dgvDailyDataReport.Columns.Contains("ReturnCondition") Then dgvDailyDataReport.Columns("ReturnCondition").HeaderText = "Return Condition"

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
        ' Always use the dtp values.
        Dim startDate As DateTime = dtpStartDate.Value
        Dim endDate As DateTime = dtpEndDate.Value

        Dim actionTypeFilter As String = ""
        If cbActionType.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbActionType.SelectedItem.ToString()) Then
            actionTypeFilter = cbActionType.SelectedItem.ToString()
        End If

        ' Reload the daily report with the current filter values.
        LoadDailyReport(startDate, endDate, actionTypeFilter)
    End Sub


    Private Sub LoadActionTypeOptions()
        cbActionType.Items.Clear()
        ' "All" includes all action types except pending (which is always excluded by the query)
        cbActionType.Items.Add("All")
        cbActionType.Items.Add("approved")
        cbActionType.Items.Add("declined")
        cbActionType.Items.Add("returned")
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
                              "SUM(CASE WHEN status = 'declined' THEN 1 ELSE 0 END) AS Declined, " &
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
