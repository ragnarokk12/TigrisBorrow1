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
    Public Property AccessoryType As String = ""  ' For accessories only

    ' On form load, populate controls.
    Private Sub AddItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the category ComboBox.
        cmbCategory.Items.Clear()
        cmbCategory.Items.AddRange(New String() {"Accessory", "Equipment"})
        cmbCategory.SelectedIndex = 0   ' Default is Accessory.
        txtQuantity.Enabled = True
        lblItemType.Text = ""           ' Clear locked item type label.

        ' Populate condition ComboBox.
        cmbItemCondition.Items.Clear()
        cmbItemCondition.Items.AddRange(New String() {"new", "good", "fair", "poor", "damaged"})
        cmbItemCondition.SelectedIndex = 0

        ' Load existing item names for the default category ("accessory").
        LoadExistingItemNames("accessory")

        ' Load existing brands based on category.
        LoadExistingBrands("accessory")

        ' Load existing accessory types.
        LoadExistingAccessoryTypes()
    End Sub

    ' When category changes, adjust controls and reload data.
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()

        If selectedCategory = "equipment" Then
            ' Equipment: disable quantity input, set default to 1, lock item type, and enable brand controls.
            txtQuantity.Enabled = False
            txtQuantity.Text = "1"
            lblItemType.Text = "IT Equipment"
            cmbExistingBrand.Enabled = True
            txtNewBrand.Enabled = True
        Else
            ' Accessory: enable quantity input, clear locked type, disable brand controls.
            txtQuantity.Enabled = True
            txtQuantity.Text = ""
            lblItemType.Text = ""
            cmbExistingBrand.Enabled = False
            txtNewBrand.Enabled = False
            ' Set brand to a default value.
            If cmbExistingBrand.Items.Count > 0 Then cmbExistingBrand.SelectedIndex = 0
            txtNewBrand.Text = "N/A"
        End If

        ' Reload the existing item names and brands for the selected category.
        LoadExistingItemNames(selectedCategory)
        LoadExistingBrands(selectedCategory)
    End Sub

    ' Loads existing item names from the database for the given category.
    Private Sub LoadExistingItemNames(ByVal category As String)
        cmbExistingItemName.Items.Clear()
        cmbExistingItemName.Items.Add("New")
        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = ""
                If category = "accessory" Then
                    query = "SELECT DISTINCT accessory_name FROM accessories"
                ElseIf category = "equipment" Then
                    query = "SELECT DISTINCT equipment_name FROM equipment"
                End If
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbExistingItemName.Items.Add(reader(0).ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading existing item names: " & ex.Message)
        End Try
        If cmbExistingItemName.Items.Count > 0 Then cmbExistingItemName.SelectedIndex = 0
    End Sub

    ' Loads existing accessory types from the accessories table.
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

    ' Loads existing brands from the database for the given category.
    Private Sub LoadExistingBrands(ByVal category As String)
        cmbExistingBrand.Items.Clear()
        cmbExistingBrand.Items.Add("New")
        If category = "equipment" Then
            Try
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
            Catch ex As Exception
                MessageBox.Show("Error loading existing brands: " & ex.Message)
            End Try
        End If
        If cmbExistingBrand.Items.Count > 0 Then cmbExistingBrand.SelectedIndex = 0
    End Sub

    ' Enable or disable new item name textbox based on selection.
    Private Sub cmbExistingItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingItemName.SelectedIndexChanged
        If cmbExistingItemName.SelectedItem.ToString().ToLower() = "new" Then
            txtNewItemName.Enabled = True
            txtNewItemName.Text = ""
        Else
            txtNewItemName.Enabled = False
            txtNewItemName.Text = cmbExistingItemName.SelectedItem.ToString()
        End If
    End Sub

    ' Enable or disable new brand textbox based on selection.
    Private Sub cmbExistingBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingBrand.SelectedIndexChanged
        If cmbExistingBrand.SelectedItem.ToString().ToLower() = "new" AndAlso cmbCategory.SelectedItem.ToString().ToLower() = "equipment" Then
            txtNewBrand.Enabled = True
            txtNewBrand.Text = ""
        Else
            txtNewBrand.Enabled = False
            txtNewBrand.Text = cmbExistingBrand.SelectedItem.ToString()
        End If
    End Sub

    ' When the admin clicks the Add button, validate input and insert the record.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()
        Dim itemNameInput As String = If(cmbExistingItemName.SelectedItem.ToString().ToLower() = "new", txtNewItemName.Text.Trim(), cmbExistingItemName.SelectedItem.ToString())

        ' For equipment, brand is required; for accessories, set to "N/A".
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

        ' For accessories, capture the accessory type.
        Dim accessoryTypeInput As String = ""
        If selectedCategory = "accessory" Then
            accessoryTypeInput = If(cmbAccessoryType.SelectedItem IsNot Nothing, cmbAccessoryType.SelectedItem.ToString(), "")
            If String.IsNullOrEmpty(accessoryTypeInput) Then
                MessageBox.Show("Please select an accessory type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim conditionInput As String = cmbItemCondition.SelectedItem.ToString().ToLower()

        ' Auto-generate serial number for equipment.
        Dim serialInput As String = ""
        If selectedCategory = "equipment" Then
            Dim nextId As Integer = GetNextEquipmentId()
            Dim brandAbbrev As String = ""
            If brandInput.Length >= 3 Then
                brandAbbrev = brandInput.Substring(0, 3).ToUpper()
            Else
                brandAbbrev = brandInput.ToUpper()
            End If
            If String.IsNullOrEmpty(modelInput) Then modelInput = "MODEL"
            serialInput = "SN-" & brandAbbrev & "-" & modelInput.ToUpper() & "-" & nextId.ToString()
        Else
            serialInput = "N/A"
        End If

        ' Set public properties.
        Category = selectedCategory
        ItemName = itemNameInput
        Quantity = qty
        ItemCondition = conditionInput
        Brand = brandInput
        Model = modelInput
        SerialNumber = serialInput
        AccessoryType = accessoryTypeInput
        Added = True

        ' Insert the record into the appropriate table.
        Dim query As String = ""
        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                If selectedCategory = "equipment" Then
                    query = "INSERT INTO equipment (equipment_name, equipment_type, brand, model, serial_number, item_condition) VALUES (@name, 'IT Equipment', @brand, @model, @serial, @condition)"
                ElseIf selectedCategory = "accessory" Then
                    query = "INSERT INTO accessories (accessory_name, accessory_type, quantity, item_condition) VALUES (@name, @accessoryType, @quantity, @condition)"
                End If
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", itemNameInput)
                    If selectedCategory = "equipment" Then
                        cmd.Parameters.AddWithValue("@brand", brandInput)
                        cmd.Parameters.AddWithValue("@model", modelInput)
                        cmd.Parameters.AddWithValue("@serial", serialInput)
                        cmd.Parameters.AddWithValue("@condition", conditionInput)
                    ElseIf selectedCategory = "accessory" Then
                        cmd.Parameters.AddWithValue("@accessoryType", accessoryTypeInput)
                        cmd.Parameters.AddWithValue("@quantity", qty)
                        cmd.Parameters.AddWithValue("@condition", conditionInput)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message)
            Return
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Helper function: Gets the next equipment ID by querying the equipment table.
    Private Function GetNextEquipmentId() As Integer
        Dim nextId As Integer = 1
        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT IFNULL(MAX(equipment_id), 0) + 1 FROM equipment"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), nextId) Then
                        Return nextId
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating equipment ID: " & ex.Message)
        End Try
        Return nextId
    End Function

    ' Cancel and close the form without saving.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
