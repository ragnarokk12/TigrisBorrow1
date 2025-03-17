Imports MySql.Data.MySqlClient

Public Class AddItemForm
    ' Public properties to hold the item data.
    Public Property Added As Boolean = False
    Public Property Category As String = ""
    Public Property ItemName As String = ""
    Public Property Quantity As Integer = 0
    Public Property ItemCondition As String = ""
    Public Property Brand As String = ""
    Public Property Model As String = ""
    Public Property SerialNumber As String = ""
    Public Property AccessoryType As String = ""

    Private Sub AddItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the Category ComboBox.
        cmbCategory.Items.Clear()
        cmbCategory.Items.AddRange(New String() {"Accessory", "Equipment"})
        cmbCategory.SelectedIndex = 0
        txtQuantity.Enabled = True
        lblItemType.Text = ""

        ' Populate the Condition ComboBox.
        cmbItemCondition.Items.Clear()
        cmbItemCondition.Items.AddRange(New String() {"new", "good", "fair", "poor", "damaged"})
        cmbItemCondition.SelectedIndex = 0

        ' Load data for existing item names, brands, and accessory types.
        LoadExistingItemNames("accessory")
        LoadExistingBrands("accessory")
        LoadExistingAccessoryTypes()

        ' Set accessory-specific controls.
        txtModel.Enabled = False
        cmbAccessoryType.Enabled = True
        txtNewAccessoryType.Enabled = False

        ' For accessories, disable the condition field.
        If cmbCategory.SelectedItem.ToString().ToLower() = "accessory" Then
            cmbItemCondition.Enabled = False
        Else
            cmbItemCondition.Enabled = True
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()
        If selectedCategory = "equipment" Then
            txtQuantity.Enabled = False
            txtQuantity.Text = "1"
            lblItemType.Text = "IT Equipment"
            cmbExistingBrand.Enabled = True
            txtNewBrand.Enabled = True
            txtModel.Enabled = True
            cmbAccessoryType.Enabled = False
            txtNewAccessoryType.Enabled = False
            cmbItemCondition.Enabled = True
        Else ' Accessory
            txtQuantity.Enabled = True
            txtQuantity.Text = "1"
            lblItemType.Text = ""
            cmbExistingBrand.Enabled = False
            txtNewBrand.Enabled = False
            If cmbExistingBrand.Items.Count > 0 Then cmbExistingBrand.SelectedIndex = 0
            txtNewBrand.Text = "N/A"
            txtModel.Enabled = False
            cmbAccessoryType.Enabled = True
            If cmbAccessoryType.SelectedItem IsNot Nothing AndAlso cmbAccessoryType.SelectedItem.ToString().ToLower() = "new" Then
                txtNewAccessoryType.Enabled = True
                txtNewAccessoryType.Text = ""
            Else
                txtNewAccessoryType.Enabled = False
                If cmbAccessoryType.SelectedItem IsNot Nothing Then
                    txtNewAccessoryType.Text = cmbAccessoryType.SelectedItem.ToString()
                Else
                    txtNewAccessoryType.Text = ""
                End If
            End If
            cmbItemCondition.Enabled = False
        End If

        ' Reload the data based on the new category.
        LoadExistingItemNames(selectedCategory)
        LoadExistingBrands(selectedCategory)
    End Sub

    Private Sub cmbAccessoryType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccessoryType.SelectedIndexChanged
        If cmbAccessoryType.SelectedItem.ToString().ToLower() = "new" Then
            txtNewAccessoryType.Enabled = True
            txtNewAccessoryType.Text = ""
        Else
            txtNewAccessoryType.Enabled = False
            txtNewAccessoryType.Text = cmbAccessoryType.SelectedItem.ToString()
        End If
    End Sub

    ' Corrected method to load existing item names.
    Private Sub LoadExistingItemNames(ByVal category As String)
        Try
            cmbExistingItemName.Items.Clear()
            cmbExistingItemName.Items.Add("New")
            Using conn As MySqlConnection = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = ""
                If category.ToLower() = "accessory" Then
                    query = "SELECT DISTINCT accessory_name FROM accessories"
                ElseIf category.ToLower() = "equipment" Then
                    query = "SELECT DISTINCT equipment_name FROM equipment"
                End If
                If Not String.IsNullOrEmpty(query) Then
                    Using cmd As New MySqlCommand(query, conn)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                cmbExistingItemName.Items.Add(reader(0).ToString())
                            End While
                        End Using
                    End Using
                End If
            End Using
            If cmbExistingItemName.Items.Count > 0 Then cmbExistingItemName.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading existing item names: " & ex.Message)
        End Try
    End Sub

    ' Corrected method to load existing brands.
    Private Sub LoadExistingBrands(ByVal category As String)
        Try
            cmbExistingBrand.Items.Clear()
            If category.ToLower() = "equipment" Then
                cmbExistingBrand.Items.Add("New")
                Using conn As MySqlConnection = Common.getDBConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim query As String = "SELECT DISTINCT brand FROM equipment WHERE brand IS NOT NULL AND brand <> ''"
                    Using cmd As New MySqlCommand(query, conn)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                cmbExistingBrand.Items.Add(reader(0).ToString())
                            End While
                        End Using
                    End Using
                End Using
            Else
                cmbExistingBrand.Items.Add("N/A")
            End If
            If cmbExistingBrand.Items.Count > 0 Then cmbExistingBrand.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading existing brands: " & ex.Message)
        End Try
    End Sub

    ' Method to load existing accessory types.
    Private Sub LoadExistingAccessoryTypes()
        cmbAccessoryType.Items.Clear()
        cmbAccessoryType.Items.Add("New")
        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT DISTINCT accessory_type FROM accessories WHERE accessory_type IS NOT NULL AND accessory_type <> ''"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbAccessoryType.Items.Add(reader(0).ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading accessory types: " & ex.Message)
        End Try
        If cmbAccessoryType.Items.Count > 0 Then cmbAccessoryType.SelectedIndex = 0
    End Sub

    Private Sub cmbExistingItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingItemName.SelectedIndexChanged
        If cmbExistingItemName.SelectedItem.ToString().ToLower() = "new" Then
            txtNewItemName.Enabled = True
            txtNewItemName.Text = ""
        Else
            txtNewItemName.Enabled = False
            txtNewItemName.Text = cmbExistingItemName.SelectedItem.ToString()
        End If
    End Sub

    Private Sub cmbExistingBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingBrand.SelectedIndexChanged
        If cmbExistingBrand.SelectedItem.ToString().ToLower() = "new" AndAlso cmbCategory.SelectedItem.ToString().ToLower() = "equipment" Then
            txtNewBrand.Enabled = True
            txtNewBrand.Text = ""
        Else
            txtNewBrand.Enabled = False
            txtNewBrand.Text = cmbExistingBrand.SelectedItem.ToString()
        End If
    End Sub

    ' Button to add the item.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()
        Dim itemNameInput As String = If(cmbExistingItemName.SelectedItem.ToString().ToLower() = "new", txtNewItemName.Text.Trim(), cmbExistingItemName.SelectedItem.ToString())

        Dim brandInput As String = ""
        Dim modelInput As String = txtModel.Text.Trim()
        If selectedCategory = "equipment" Then
            brandInput = If(cmbExistingBrand.SelectedItem.ToString().ToLower() = "new", txtNewBrand.Text.Trim(), cmbExistingBrand.SelectedItem.ToString())
            If String.IsNullOrEmpty(brandInput) Then
                MessageBox.Show("Brand cannot be empty for equipment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            brandInput = "N/A"
            modelInput = "N/A"
        End If

        If String.IsNullOrEmpty(itemNameInput) Then
            MessageBox.Show("Item name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = 1
        If selectedCategory = "accessory" Then
            Dim quantityInput As String = txtQuantity.Text.Trim()
            If Not Integer.TryParse(quantityInput, qty) OrElse qty <= 0 Then
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim accessoryTypeInput As String = ""
        If selectedCategory = "accessory" Then
            If cmbAccessoryType.SelectedItem.ToString().ToLower() = "new" Then
                accessoryTypeInput = txtNewAccessoryType.Text.Trim()
            Else
                accessoryTypeInput = cmbAccessoryType.SelectedItem.ToString()
            End If
            If String.IsNullOrEmpty(accessoryTypeInput) Then
                MessageBox.Show("Please enter an accessory type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim conditionInput As String = cmbItemCondition.SelectedItem.ToString().ToLower()
        Dim serialInput As String = ""

        If selectedCategory = "equipment" Then
            Try
                Using conn As MySqlConnection = Common.getDBConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim query As String = "INSERT INTO equipment (equipment_name, equipment_type, brand, model, item_condition) VALUES (@name, 'IT Equipment', @brand, @model, @condition)"
                    Dim equipmentId As Long = 0
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", itemNameInput)
                        cmd.Parameters.AddWithValue("@brand", brandInput)
                        cmd.Parameters.AddWithValue("@model", modelInput)
                        cmd.Parameters.AddWithValue("@condition", conditionInput)
                        cmd.ExecuteNonQuery()
                        equipmentId = cmd.LastInsertedId
                    End Using

                    Dim brandAbbrev As String = If(brandInput.Length >= 3, brandInput.Substring(0, 3).ToUpper(), brandInput.ToUpper())
                    If String.IsNullOrEmpty(modelInput) Then modelInput = "MODEL"
                    serialInput = "SN-" & brandAbbrev & "-" & modelInput.ToUpper() & "-" & equipmentId.ToString()

                    Dim updateQuery As String = "UPDATE equipment SET serial_number = @serial WHERE equipment_id = @id"
                    Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                        cmdUpdate.Parameters.AddWithValue("@serial", serialInput)
                        cmdUpdate.Parameters.AddWithValue("@id", equipmentId)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding equipment: " & ex.Message)
                Return
            End Try
        ElseIf selectedCategory = "accessory" Then
            serialInput = "N/A"
            Try
                Using conn As MySqlConnection = Common.getDBConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim checkQuery As String = "SELECT accessory_id, quantity FROM accessories WHERE accessory_name = @name AND accessory_type = @accessoryType"
                    Dim existingId As Integer = 0
                    Dim existingQty As Integer = 0
                    Using cmdCheck As New MySqlCommand(checkQuery, conn)
                        cmdCheck.Parameters.AddWithValue("@name", itemNameInput)
                        cmdCheck.Parameters.AddWithValue("@accessoryType", accessoryTypeInput)
                        Dim reader = cmdCheck.ExecuteReader()
                        If reader.Read() Then
                            existingId = Convert.ToInt32(reader("accessory_id"))
                            existingQty = Convert.ToInt32(reader("quantity"))
                        End If
                        reader.Close()
                    End Using

                    If existingId > 0 Then
                        Dim updateQuery As String = "UPDATE accessories SET quantity = quantity + @qty WHERE accessory_id = @id"
                        Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                            cmdUpdate.Parameters.AddWithValue("@qty", qty)
                            cmdUpdate.Parameters.AddWithValue("@id", existingId)
                            cmdUpdate.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Accessory updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Category = selectedCategory
                        ItemName = itemNameInput
                        Quantity = qty + existingQty
                        ItemCondition = conditionInput
                        Brand = brandInput
                        Model = modelInput
                        SerialNumber = serialInput
                        AccessoryType = accessoryTypeInput
                        Added = True
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                        Exit Sub
                    Else
                        Dim insertQuery As String = "INSERT INTO accessories (accessory_name, accessory_type, quantity, item_condition) VALUES (@name, @accessoryType, @quantity, @condition)"
                        Using cmdInsert As New MySqlCommand(insertQuery, conn)
                            cmdInsert.Parameters.AddWithValue("@name", itemNameInput)
                            cmdInsert.Parameters.AddWithValue("@accessoryType", accessoryTypeInput)
                            cmdInsert.Parameters.AddWithValue("@quantity", qty)
                            cmdInsert.Parameters.AddWithValue("@condition", conditionInput)
                            cmdInsert.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding accessory: " & ex.Message)
                Return
            End Try
        End If

        Category = selectedCategory
        ItemName = itemNameInput
        Quantity = qty
        ItemCondition = conditionInput
        Brand = brandInput
        Model = modelInput
        SerialNumber = serialInput
        AccessoryType = accessoryTypeInput
        Added = True

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
