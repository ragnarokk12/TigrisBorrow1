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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItemForm))
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.pnlControlBx = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.cbexit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlControlBx.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cmbCategory.BorderRadius = 7
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(212, 99)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(200, 36)
        Me.cmbCategory.TabIndex = 0
        '
        'txtNewItemName
        '
        Me.txtNewItemName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtNewItemName.BorderRadius = 7
        Me.txtNewItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewItemName.DefaultText = ""
        Me.txtNewItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewItemName.Location = New System.Drawing.Point(430, 141)
        Me.txtNewItemName.Name = "txtNewItemName"
        Me.txtNewItemName.PlaceholderText = ""
        Me.txtNewItemName.SelectedText = ""
        Me.txtNewItemName.Size = New System.Drawing.Size(200, 36)
        Me.txtNewItemName.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtQuantity.BorderRadius = 7
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Empty
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(24, 434)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(200, 36)
        Me.txtQuantity.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnCancel.BorderRadius = 7
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(329, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'cmbExistingItemName
        '
        Me.cmbExistingItemName.BackColor = System.Drawing.Color.Transparent
        Me.cmbExistingItemName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cmbExistingItemName.BorderRadius = 7
        Me.cmbExistingItemName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbExistingItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingItemName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingItemName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbExistingItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbExistingItemName.ItemHeight = 30
        Me.cmbExistingItemName.Location = New System.Drawing.Point(212, 141)
        Me.cmbExistingItemName.Name = "cmbExistingItemName"
        Me.cmbExistingItemName.Size = New System.Drawing.Size(200, 36)
        Me.cmbExistingItemName.TabIndex = 5
        '
        'cmbItemCondition
        '
        Me.cmbItemCondition.BackColor = System.Drawing.Color.Transparent
        Me.cmbItemCondition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cmbItemCondition.BorderRadius = 7
        Me.cmbItemCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemCondition.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItemCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItemCondition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbItemCondition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbItemCondition.ItemHeight = 30
        Me.cmbItemCondition.Location = New System.Drawing.Point(212, 183)
        Me.cmbItemCondition.Name = "cmbItemCondition"
        Me.cmbItemCondition.Size = New System.Drawing.Size(200, 36)
        Me.cmbItemCondition.TabIndex = 6
        '
        'cmbExistingBrand
        '
        Me.cmbExistingBrand.BackColor = System.Drawing.Color.Transparent
        Me.cmbExistingBrand.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cmbExistingBrand.BorderRadius = 7
        Me.cmbExistingBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbExistingBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingBrand.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbExistingBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbExistingBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbExistingBrand.ItemHeight = 30
        Me.cmbExistingBrand.Location = New System.Drawing.Point(212, 279)
        Me.cmbExistingBrand.Name = "cmbExistingBrand"
        Me.cmbExistingBrand.Size = New System.Drawing.Size(200, 36)
        Me.cmbExistingBrand.TabIndex = 7
        '
        'txtNewBrand
        '
        Me.txtNewBrand.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtNewBrand.BorderRadius = 7
        Me.txtNewBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewBrand.DefaultText = ""
        Me.txtNewBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewBrand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewBrand.Location = New System.Drawing.Point(430, 279)
        Me.txtNewBrand.Name = "txtNewBrand"
        Me.txtNewBrand.PlaceholderText = ""
        Me.txtNewBrand.SelectedText = ""
        Me.txtNewBrand.Size = New System.Drawing.Size(200, 36)
        Me.txtNewBrand.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtModel.BorderRadius = 7
        Me.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtModel.DefaultText = ""
        Me.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModel.Location = New System.Drawing.Point(212, 321)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.PlaceholderText = ""
        Me.txtModel.SelectedText = ""
        Me.txtModel.Size = New System.Drawing.Size(200, 36)
        Me.txtModel.TabIndex = 9
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtSerialNumber.BorderRadius = 7
        Me.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerialNumber.DefaultText = ""
        Me.txtSerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerialNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerialNumber.Location = New System.Drawing.Point(212, 363)
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
        Me.lblItemType.Location = New System.Drawing.Point(47, 55)
        Me.lblItemType.Name = "lblItemType"
        Me.lblItemType.Size = New System.Drawing.Size(88, 15)
        Me.lblItemType.TabIndex = 11
        Me.lblItemType.Text = "Guna2HtmlLabel1"
        Me.lblItemType.Visible = False
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(147, 110)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(57, 15)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.Text = "Category:"
        '
        'lblItemName
        '
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(138, 151)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(67, 15)
        Me.lblItemName.TabIndex = 13
        Me.lblItemName.Text = "Item Name:"
        '
        'lblItemCondition
        '
        Me.lblItemCondition.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCondition.Location = New System.Drawing.Point(122, 193)
        Me.lblItemCondition.Name = "lblItemCondition"
        Me.lblItemCondition.Size = New System.Drawing.Size(88, 15)
        Me.lblItemCondition.TabIndex = 14
        Me.lblItemCondition.Text = "Item Condition:"
        '
        'lblItemBrand
        '
        Me.lblItemBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblItemBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBrand.Location = New System.Drawing.Point(159, 289)
        Me.lblItemBrand.Name = "lblItemBrand"
        Me.lblItemBrand.Size = New System.Drawing.Size(40, 15)
        Me.lblItemBrand.TabIndex = 15
        Me.lblItemBrand.Text = "Brand:"
        '
        'lblItemModel
        '
        Me.lblItemModel.BackColor = System.Drawing.Color.Transparent
        Me.lblItemModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemModel.Location = New System.Drawing.Point(159, 342)
        Me.lblItemModel.Name = "lblItemModel"
        Me.lblItemModel.Size = New System.Drawing.Size(41, 15)
        Me.lblItemModel.TabIndex = 16
        Me.lblItemModel.Text = "Model:"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNumber.Location = New System.Drawing.Point(122, 374)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(86, 15)
        Me.lblSerialNumber.TabIndex = 17
        Me.lblSerialNumber.Text = "Serial Number:"
        Me.lblSerialNumber.Visible = False
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Location = New System.Drawing.Point(24, 413)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(45, 15)
        Me.lblQuantity.TabIndex = 18
        Me.lblQuantity.Text = "Quantity:"
        '
        'cmbAccessoryType
        '
        Me.cmbAccessoryType.BackColor = System.Drawing.Color.Transparent
        Me.cmbAccessoryType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cmbAccessoryType.BorderRadius = 7
        Me.cmbAccessoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAccessoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessoryType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccessoryType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccessoryType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAccessoryType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAccessoryType.ItemHeight = 30
        Me.cmbAccessoryType.Location = New System.Drawing.Point(212, 225)
        Me.cmbAccessoryType.Name = "cmbAccessoryType"
        Me.cmbAccessoryType.Size = New System.Drawing.Size(200, 36)
        Me.cmbAccessoryType.TabIndex = 19
        '
        'lblAccessoryType
        '
        Me.lblAccessoryType.BackColor = System.Drawing.Color.Transparent
        Me.lblAccessoryType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessoryType.Location = New System.Drawing.Point(112, 236)
        Me.lblAccessoryType.Name = "lblAccessoryType"
        Me.lblAccessoryType.Size = New System.Drawing.Size(97, 15)
        Me.lblAccessoryType.TabIndex = 20
        Me.lblAccessoryType.Text = "Accessory Type:"
        '
        'txtNewAccessoryType
        '
        Me.txtNewAccessoryType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtNewAccessoryType.BorderRadius = 7
        Me.txtNewAccessoryType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAccessoryType.DefaultText = ""
        Me.txtNewAccessoryType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessoryType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessoryType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessoryType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewAccessoryType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessoryType.Location = New System.Drawing.Point(430, 225)
        Me.txtNewAccessoryType.Name = "txtNewAccessoryType"
        Me.txtNewAccessoryType.PlaceholderText = ""
        Me.txtNewAccessoryType.SelectedText = ""
        Me.txtNewAccessoryType.Size = New System.Drawing.Size(200, 36)
        Me.txtNewAccessoryType.TabIndex = 21
        '
        'pnlControlBx
        '
        Me.pnlControlBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlControlBx.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlControlBx.Controls.Add(Me.cbMinimize)
        Me.pnlControlBx.Controls.Add(Me.cbexit)
        Me.pnlControlBx.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControlBx.Location = New System.Drawing.Point(0, 0)
        Me.pnlControlBx.Name = "pnlControlBx"
        Me.pnlControlBx.Size = New System.Drawing.Size(769, 28)
        Me.pnlControlBx.TabIndex = 22
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(125, 18)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "TIGRIS BORROW"
        '
        'cbMinimize
        '
        Me.cbMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMinimize.BackColor = System.Drawing.Color.Transparent
        Me.cbMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.cbMinimize.FillColor = System.Drawing.Color.Transparent
        Me.cbMinimize.IconColor = System.Drawing.Color.Black
        Me.cbMinimize.Location = New System.Drawing.Point(679, -2)
        Me.cbMinimize.Name = "cbMinimize"
        Me.cbMinimize.Size = New System.Drawing.Size(45, 29)
        Me.cbMinimize.TabIndex = 1
        '
        'cbexit
        '
        Me.cbexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbexit.BackColor = System.Drawing.Color.Transparent
        Me.cbexit.FillColor = System.Drawing.Color.Transparent
        Me.cbexit.IconColor = System.Drawing.Color.Black
        Me.cbexit.Location = New System.Drawing.Point(724, -2)
        Me.cbexit.Name = "cbexit"
        Me.cbexit.Size = New System.Drawing.Size(45, 29)
        Me.cbexit.TabIndex = 0
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblItemType)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnCancel)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtNewAccessoryType)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnAdd)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbCategory)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblAccessoryType)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtNewItemName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbAccessoryType)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtQuantity)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblQuantity)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbExistingItemName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblSerialNumber)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbItemCondition)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblItemModel)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbExistingBrand)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblItemBrand)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtNewBrand)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblItemCondition)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtModel)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblItemName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtSerialNumber)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCategory)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 43)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(742, 509)
        Me.Guna2ShadowPanel1.TabIndex = 23
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlControlBx
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderRadius = 7
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = Global.TigrisBorrow.My.Resources.Resources.add1
        Me.btnAdd.Location = New System.Drawing.Point(532, 432)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(180, 45)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(329, 42)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(113, 26)
        Me.Guna2HtmlLabel2.TabIndex = 22
        Me.Guna2HtmlLabel2.Text = "ADD ITEMS"
        '
        'AddItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 573)
        Me.Controls.Add(Me.pnlControlBx)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddItemForm"
        Me.Text = "AddItemForm"
        Me.pnlControlBx.ResumeLayout(False)
        Me.pnlControlBx.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents pnlControlBx As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents cbexit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
