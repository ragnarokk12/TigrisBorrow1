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

    ' On form load, populate controls.
    Private Sub AddItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the category ComboBox.
        cmbCategory.Items.Clear()
        cmbCategory.Items.AddRange(New String() {"Accessory", "Equipment"})
        cmbCategory.SelectedIndex = 0   ' Default is Accessory.
        txtQuantity.Enabled = True
        lblItemType.Text = ""           ' Clear the locked item type label initially.

        ' Populate the condition ComboBox.
        cmbItemCondition.Items.Clear()
        cmbItemCondition.Items.AddRange(New String() {"new", "good", "fair", "poor", "damaged"})
        cmbItemCondition.SelectedIndex = 0

        ' Load existing item names for the default category ("accessory").
        LoadExistingItemNames("accessory")

        ' Load existing brands based on the selected category.
        LoadExistingBrands(cmbCategory.SelectedItem.ToString().ToLower())
    End Sub

    ' When the category changes, adjust controls and reload existing names/brands.
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()

        If selectedCategory = "equipment" Then
            ' For equipment: disable quantity input and lock item type.
            txtQuantity.Enabled = False
            txtQuantity.Text = "1"
            lblItemType.Text = "IT Equipment" ' Locked value
        Else
            ' For accessories: enable quantity.
            txtQuantity.Enabled = True
            txtQuantity.Text = ""
            lblItemType.Text = ""
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
        cmbExistingItemName.SelectedIndex = 0
    End Sub

    ' Loads existing brands only for equipment. For accessories, defaults to "New".
    Private Sub LoadExistingBrands(ByVal category As String)
        cmbExistingBrand.Items.Clear()
        cmbExistingBrand.Items.Add("New")
        If category = "equipment" Then
            Try
                Using conn As MySqlConnection = Common.getDBConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    ' Only load brands from equipment as accessories do not have brand.
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
        cmbExistingBrand.SelectedIndex = 0
    End Sub

    ' Enable or disable the new item name textbox based on selection.
    Private Sub cmbExistingItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingItemName.SelectedIndexChanged
        If cmbExistingItemName.SelectedItem.ToString().ToLower() = "new" Then
            txtNewItemName.Enabled = True
            txtNewItemName.Text = ""
        Else
            txtNewItemName.Enabled = False
            txtNewItemName.Text = cmbExistingItemName.SelectedItem.ToString()
        End If
    End Sub

    ' Enable or disable the new brand textbox based on selection.
    Private Sub cmbExistingBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingBrand.SelectedIndexChanged
        If cmbExistingBrand.SelectedItem.ToString().ToLower() = "new" Then
            txtNewBrand.Enabled = True
            txtNewBrand.Text = ""
        Else
            txtNewBrand.Enabled = False
            txtNewBrand.Text = cmbExistingBrand.SelectedItem.ToString()
        End If
    End Sub

    ' When the admin clicks the Add button, validate input and set public properties.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString().ToLower()
        Dim itemNameInput As String = If(cmbExistingItemName.SelectedItem.ToString().ToLower() = "new",
                                        txtNewItemName.Text.Trim(), cmbExistingItemName.SelectedItem.ToString())
        Dim brandInput As String = If(cmbExistingBrand.SelectedItem.ToString().ToLower() = "new",
                                     txtNewBrand.Text.Trim(), cmbExistingBrand.SelectedItem.ToString())

        If String.IsNullOrEmpty(itemNameInput) OrElse String.IsNullOrEmpty(brandInput) Then
            MessageBox.Show("Item name and brand cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = If(selectedCategory = "accessory" AndAlso Integer.TryParse(txtQuantity.Text.Trim(), qty) AndAlso qty > 0, qty, 1)

        Dim conditionInput As String = cmbItemCondition.SelectedItem.ToString().ToLower()
        Dim modelInput As String = txtModel.Text.Trim()
        Dim serialInput As String = txtSerialNumber.Text.Trim()

        Category = selectedCategory
        ItemName = itemNameInput
        Quantity = qty
        ItemCondition = conditionInput
        Brand = brandInput
        Model = modelInput
        SerialNumber = serialInput
        Added = True

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Cancel and close the form without saving.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
