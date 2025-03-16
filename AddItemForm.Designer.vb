<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemForm
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbExistingItemName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbItemCondition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbExistingBrand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewBrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtModel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSerialNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblItemType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItemName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItemCondition = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItemBrand = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItemModel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSerialNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbAccessoryType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblAccessoryType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNewAccessoryType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(200, 78)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(140, 36)
        Me.cmbCategory.TabIndex = 0
        '
        'txtNewItemName
        '
        Me.txtNewItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewItemName.DefaultText = ""
        Me.txtNewItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewItemName.Location = New System.Drawing.Point(346, 120)
        Me.txtNewItemName.Name = "txtNewItemName"
        Me.txtNewItemName.PlaceholderText = ""
        Me.txtNewItemName.SelectedText = ""
        Me.txtNewItemName.Size = New System.Drawing.Size(200, 36)
        Me.txtNewItemName.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(12, 402)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(200, 36)
        Me.txtQuantity.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(577, 342)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(180, 45)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        '
        'btnCancel
        '
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(577, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'cmbExistingItemName
        '
        Me.cmbExistingItemName.BackColor = System.Drawing.Color.Transparent
        Me.cmbExistingItemName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbExistingItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingItemName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingItemName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbExistingItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbExistingItemName.ItemHeight = 30
        Me.cmbExistingItemName.Location = New System.Drawing.Point(200, 120)
        Me.cmbExistingItemName.Name = "cmbExistingItemName"
        Me.cmbExistingItemName.Size = New System.Drawing.Size(140, 36)
        Me.cmbExistingItemName.TabIndex = 5
        '
        'cmbItemCondition
        '
        Me.cmbItemCondition.BackColor = System.Drawing.Color.Transparent
        Me.cmbItemCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemCondition.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItemCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItemCondition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbItemCondition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbItemCondition.ItemHeight = 30
        Me.cmbItemCondition.Location = New System.Drawing.Point(200, 162)
        Me.cmbItemCondition.Name = "cmbItemCondition"
        Me.cmbItemCondition.Size = New System.Drawing.Size(140, 36)
        Me.cmbItemCondition.TabIndex = 6
        '
        'cmbExistingBrand
        '
        Me.cmbExistingBrand.BackColor = System.Drawing.Color.Transparent
        Me.cmbExistingBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbExistingBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingBrand.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbExistingBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbExistingBrand.ItemHeight = 30
        Me.cmbExistingBrand.Location = New System.Drawing.Point(200, 258)
        Me.cmbExistingBrand.Name = "cmbExistingBrand"
        Me.cmbExistingBrand.Size = New System.Drawing.Size(140, 36)
        Me.cmbExistingBrand.TabIndex = 7
        '
        'txtNewBrand
        '
        Me.txtNewBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewBrand.DefaultText = ""
        Me.txtNewBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewBrand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewBrand.Location = New System.Drawing.Point(346, 258)
        Me.txtNewBrand.Name = "txtNewBrand"
        Me.txtNewBrand.PlaceholderText = ""
        Me.txtNewBrand.SelectedText = ""
        Me.txtNewBrand.Size = New System.Drawing.Size(200, 36)
        Me.txtNewBrand.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtModel.DefaultText = ""
        Me.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModel.Location = New System.Drawing.Point(200, 300)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.PlaceholderText = ""
        Me.txtModel.SelectedText = ""
        Me.txtModel.Size = New System.Drawing.Size(200, 36)
        Me.txtModel.TabIndex = 9
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerialNumber.DefaultText = ""
        Me.txtSerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerialNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerialNumber.Location = New System.Drawing.Point(200, 342)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.PlaceholderText = ""
        Me.txtSerialNumber.ReadOnly = True
        Me.txtSerialNumber.SelectedText = ""
        Me.txtSerialNumber.Size = New System.Drawing.Size(200, 36)
        Me.txtSerialNumber.TabIndex = 10
        Me.txtSerialNumber.Visible = False
        '
        'lblItemType
        '
        Me.lblItemType.BackColor = System.Drawing.Color.Transparent
        Me.lblItemType.Location = New System.Drawing.Point(35, 34)
        Me.lblItemType.Name = "lblItemType"
        Me.lblItemType.Size = New System.Drawing.Size(88, 15)
        Me.lblItemType.TabIndex = 11
        Me.lblItemType.Text = "Guna2HtmlLabel1"
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Location = New System.Drawing.Point(146, 89)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(48, 15)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.Text = "Category:"
        '
        'lblItemName
        '
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Location = New System.Drawing.Point(137, 130)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(57, 15)
        Me.lblItemName.TabIndex = 13
        Me.lblItemName.Text = "Item Name:"
        '
        'lblItemCondition
        '
        Me.lblItemCondition.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCondition.Location = New System.Drawing.Point(121, 172)
        Me.lblItemCondition.Name = "lblItemCondition"
        Me.lblItemCondition.Size = New System.Drawing.Size(73, 15)
        Me.lblItemCondition.TabIndex = 14
        Me.lblItemCondition.Text = "Item Condition:"
        '
        'lblItemBrand
        '
        Me.lblItemBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblItemBrand.Location = New System.Drawing.Point(158, 268)
        Me.lblItemBrand.Name = "lblItemBrand"
        Me.lblItemBrand.Size = New System.Drawing.Size(34, 15)
        Me.lblItemBrand.TabIndex = 15
        Me.lblItemBrand.Text = "Brand:"
        '
        'lblItemModel
        '
        Me.lblItemModel.BackColor = System.Drawing.Color.Transparent
        Me.lblItemModel.Location = New System.Drawing.Point(158, 321)
        Me.lblItemModel.Name = "lblItemModel"
        Me.lblItemModel.Size = New System.Drawing.Size(35, 15)
        Me.lblItemModel.TabIndex = 16
        Me.lblItemModel.Text = "Model:"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialNumber.Location = New System.Drawing.Point(121, 353)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(72, 15)
        Me.lblSerialNumber.TabIndex = 17
        Me.lblSerialNumber.Text = "Serial Number:"
        Me.lblSerialNumber.Visible = False
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Location = New System.Drawing.Point(12, 381)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(45, 15)
        Me.lblQuantity.TabIndex = 18
        Me.lblQuantity.Text = "Quantity:"
        '
        'cmbAccessoryType
        '
        Me.cmbAccessoryType.BackColor = System.Drawing.Color.Transparent
        Me.cmbAccessoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAccessoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessoryType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccessoryType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccessoryType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAccessoryType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAccessoryType.ItemHeight = 30
        Me.cmbAccessoryType.Location = New System.Drawing.Point(200, 204)
        Me.cmbAccessoryType.Name = "cmbAccessoryType"
        Me.cmbAccessoryType.Size = New System.Drawing.Size(140, 36)
        Me.cmbAccessoryType.TabIndex = 19
        '
        'lblAccessoryType
        '
        Me.lblAccessoryType.BackColor = System.Drawing.Color.Transparent
        Me.lblAccessoryType.Location = New System.Drawing.Point(111, 215)
        Me.lblAccessoryType.Name = "lblAccessoryType"
        Me.lblAccessoryType.Size = New System.Drawing.Size(82, 15)
        Me.lblAccessoryType.TabIndex = 20
        Me.lblAccessoryType.Text = "Accessory Type:"
        '
        'txtNewAccessoryType
        '
        Me.txtNewAccessoryType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAccessoryType.DefaultText = ""
        Me.txtNewAccessoryType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessoryType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessoryType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewAccessoryType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessoryType.Location = New System.Drawing.Point(346, 204)
        Me.txtNewAccessoryType.Name = "txtNewAccessoryType"
        Me.txtNewAccessoryType.PlaceholderText = ""
        Me.txtNewAccessoryType.SelectedText = ""
        Me.txtNewAccessoryType.Size = New System.Drawing.Size(200, 36)
        Me.txtNewAccessoryType.TabIndex = 21
        '
        'AddItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNewAccessoryType)
        Me.Controls.Add(Me.lblAccessoryType)
        Me.Controls.Add(Me.cmbAccessoryType)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.lblItemModel)
        Me.Controls.Add(Me.lblItemBrand)
        Me.Controls.Add(Me.lblItemCondition)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblItemType)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtNewBrand)
        Me.Controls.Add(Me.cmbExistingBrand)
        Me.Controls.Add(Me.cmbItemCondition)
        Me.Controls.Add(Me.cmbExistingItemName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtNewItemName)
        Me.Controls.Add(Me.cmbCategory)
        Me.Name = "AddItemForm"
        Me.Text = "AddItemForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbExistingItemName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbItemCondition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbExistingBrand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewBrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtModel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSerialNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblItemType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItemName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItemCondition As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItemBrand As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItemModel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSerialNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbAccessoryType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblAccessoryType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNewAccessoryType As Guna.UI2.WinForms.Guna2TextBox
End Class
