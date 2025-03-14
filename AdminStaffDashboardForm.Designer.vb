<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminStaffDashboardForm
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbcAdminDashboard = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tbpDeployment = New System.Windows.Forms.TabPage()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.tbpInventory = New System.Windows.Forms.TabPage()
        Me.txtSearchInv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkDescending = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbSortBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnInvEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnSort = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteItems = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdditem = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbpAccount = New System.Windows.Forms.TabPage()
        Me.txtSearchAccount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEditAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGoAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvAccount = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnNewAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbcReport = New System.Windows.Forms.TabPage()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnGenReport = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDataReport = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblYourName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.tbcAdminDashboard.SuspendLayout()
        Me.tbpDeployment.SuspendLayout()
        Me.tbpInventory.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAccount.SuspendLayout()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcReport.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(866, 21)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(87, 34)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Log Out"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(6, 6)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(314, 26)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "Deployment / Pull-Out Dashboard"
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(22, 37)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(41, 18)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Admin"
        '
        'tbcAdminDashboard
        '
        Me.tbcAdminDashboard.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tbcAdminDashboard.Controls.Add(Me.tbpDeployment)
        Me.tbcAdminDashboard.Controls.Add(Me.tbpInventory)
        Me.tbcAdminDashboard.Controls.Add(Me.tbpAccount)
        Me.tbcAdminDashboard.Controls.Add(Me.tbcReport)
        Me.tbcAdminDashboard.ItemSize = New System.Drawing.Size(180, 40)
        Me.tbcAdminDashboard.Location = New System.Drawing.Point(0, 71)
        Me.tbcAdminDashboard.Name = "tbcAdminDashboard"
        Me.tbcAdminDashboard.SelectedIndex = 0
        Me.tbcAdminDashboard.Size = New System.Drawing.Size(964, 458)
        Me.tbcAdminDashboard.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tbcAdminDashboard.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tbcAdminDashboard.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tbcAdminDashboard.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tbcAdminDashboard.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tbcAdminDashboard.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tbcAdminDashboard.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tbcAdminDashboard.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tbcAdminDashboard.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcAdminDashboard.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tbcAdminDashboard.TabIndex = 6
        Me.tbcAdminDashboard.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'tbpDeployment
        '
        Me.tbpDeployment.Controls.Add(Me.Guna2Separator1)
        Me.tbpDeployment.Controls.Add(Me.Guna2HtmlLabel2)
        Me.tbpDeployment.Location = New System.Drawing.Point(184, 4)
        Me.tbpDeployment.Name = "tbpDeployment"
        Me.tbpDeployment.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDeployment.Size = New System.Drawing.Size(776, 450)
        Me.tbpDeployment.TabIndex = 0
        Me.tbpDeployment.Text = "Deployment"
        Me.tbpDeployment.UseVisualStyleBackColor = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(6, 34)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(763, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'tbpInventory
        '
        Me.tbpInventory.Controls.Add(Me.txtSearchInv)
        Me.tbpInventory.Controls.Add(Me.chkDescending)
        Me.tbpInventory.Controls.Add(Me.cbSortBy)
        Me.tbpInventory.Controls.Add(Me.btnInvEdit)
        Me.tbpInventory.Controls.Add(Me.Guna2Separator2)
        Me.tbpInventory.Controls.Add(Me.btnSort)
        Me.tbpInventory.Controls.Add(Me.btnGo)
        Me.tbpInventory.Controls.Add(Me.btnDeleteItems)
        Me.tbpInventory.Controls.Add(Me.btnAdditem)
        Me.tbpInventory.Controls.Add(Me.Guna2HtmlLabel4)
        Me.tbpInventory.Controls.Add(Me.dgvInventory)
        Me.tbpInventory.Location = New System.Drawing.Point(184, 4)
        Me.tbpInventory.Name = "tbpInventory"
        Me.tbpInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInventory.Size = New System.Drawing.Size(776, 450)
        Me.tbpInventory.TabIndex = 1
        Me.tbpInventory.Text = "Inventory"
        Me.tbpInventory.UseVisualStyleBackColor = True
        '
        'txtSearchInv
        '
        Me.txtSearchInv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchInv.DefaultText = ""
        Me.txtSearchInv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchInv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchInv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchInv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchInv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchInv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchInv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchInv.Location = New System.Drawing.Point(6, 38)
        Me.txtSearchInv.Name = "txtSearchInv"
        Me.txtSearchInv.PlaceholderText = ""
        Me.txtSearchInv.SelectedText = ""
        Me.txtSearchInv.Size = New System.Drawing.Size(200, 36)
        Me.txtSearchInv.TabIndex = 12
        '
        'chkDescending
        '
        Me.chkDescending.AutoSize = True
        Me.chkDescending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkDescending.CheckedState.BorderRadius = 0
        Me.chkDescending.CheckedState.BorderThickness = 0
        Me.chkDescending.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkDescending.Location = New System.Drawing.Point(646, 53)
        Me.chkDescending.Name = "chkDescending"
        Me.chkDescending.Size = New System.Drawing.Size(51, 17)
        Me.chkDescending.TabIndex = 10
        Me.chkDescending.Text = "Desc"
        Me.chkDescending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkDescending.UncheckedState.BorderRadius = 0
        Me.chkDescending.UncheckedState.BorderThickness = 0
        Me.chkDescending.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'cbSortBy
        '
        Me.cbSortBy.BackColor = System.Drawing.Color.Transparent
        Me.cbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSortBy.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSortBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSortBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSortBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSortBy.ItemHeight = 30
        Me.cbSortBy.Location = New System.Drawing.Point(500, 38)
        Me.cbSortBy.Name = "cbSortBy"
        Me.cbSortBy.Size = New System.Drawing.Size(140, 36)
        Me.cbSortBy.TabIndex = 9
        '
        'btnInvEdit
        '
        Me.btnInvEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInvEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInvEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInvEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInvEdit.ForeColor = System.Drawing.Color.White
        Me.btnInvEdit.Location = New System.Drawing.Point(665, 6)
        Me.btnInvEdit.Name = "btnInvEdit"
        Me.btnInvEdit.Size = New System.Drawing.Size(104, 29)
        Me.btnInvEdit.TabIndex = 3
        Me.btnInvEdit.Text = "Edit"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(8, 34)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(755, 10)
        Me.Guna2Separator2.TabIndex = 7
        '
        'btnSort
        '
        Me.btnSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSort.ForeColor = System.Drawing.Color.White
        Me.btnSort.Location = New System.Drawing.Point(715, 50)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(55, 20)
        Me.btnSort.TabIndex = 6
        Me.btnSort.Text = "Sort"
        '
        'btnGo
        '
        Me.btnGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(206, 50)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(51, 20)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go"
        '
        'btnDeleteItems
        '
        Me.btnDeleteItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteItems.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeleteItems.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItems.Location = New System.Drawing.Point(665, 411)
        Me.btnDeleteItems.Name = "btnDeleteItems"
        Me.btnDeleteItems.Size = New System.Drawing.Size(104, 29)
        Me.btnDeleteItems.TabIndex = 2
        Me.btnDeleteItems.Text = "Delete Items"
        '
        'btnAdditem
        '
        Me.btnAdditem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdditem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdditem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdditem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdditem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdditem.ForeColor = System.Drawing.Color.White
        Me.btnAdditem.Location = New System.Drawing.Point(555, 411)
        Me.btnAdditem.Name = "btnAdditem"
        Me.btnAdditem.Size = New System.Drawing.Size(104, 29)
        Me.btnAdditem.TabIndex = 1
        Me.btnAdditem.Text = "Add Items"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(6, 6)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(195, 26)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "Inventory Dashboard"
        '
        'dgvInventory
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvInventory.ColumnHeadersHeight = 4
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.Location = New System.Drawing.Point(3, 53)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.Size = New System.Drawing.Size(761, 352)
        Me.dgvInventory.TabIndex = 8
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvInventory.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvInventory.ThemeStyle.ReadOnly = False
        Me.dgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.Height = 22
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tbpAccount
        '
        Me.tbpAccount.Controls.Add(Me.txtSearchAccount)
        Me.tbpAccount.Controls.Add(Me.btnEditAccount)
        Me.tbpAccount.Controls.Add(Me.btnGoAccount)
        Me.tbpAccount.Controls.Add(Me.dgvAccount)
        Me.tbpAccount.Controls.Add(Me.btnNewAccount)
        Me.tbpAccount.Controls.Add(Me.Guna2HtmlLabel5)
        Me.tbpAccount.Location = New System.Drawing.Point(184, 4)
        Me.tbpAccount.Name = "tbpAccount"
        Me.tbpAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAccount.Size = New System.Drawing.Size(776, 450)
        Me.tbpAccount.TabIndex = 2
        Me.tbpAccount.Text = "Account"
        Me.tbpAccount.UseVisualStyleBackColor = True
        '
        'txtSearchAccount
        '
        Me.txtSearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchAccount.DefaultText = ""
        Me.txtSearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchAccount.Location = New System.Drawing.Point(0, 23)
        Me.txtSearchAccount.Name = "txtSearchAccount"
        Me.txtSearchAccount.PlaceholderText = ""
        Me.txtSearchAccount.SelectedText = ""
        Me.txtSearchAccount.Size = New System.Drawing.Size(200, 36)
        Me.txtSearchAccount.TabIndex = 10
        '
        'btnEditAccount
        '
        Me.btnEditAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditAccount.ForeColor = System.Drawing.Color.White
        Me.btnEditAccount.Location = New System.Drawing.Point(410, 14)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.Size = New System.Drawing.Size(180, 45)
        Me.btnEditAccount.TabIndex = 9
        Me.btnEditAccount.Text = "Edit"
        '
        'btnGoAccount
        '
        Me.btnGoAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGoAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGoAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGoAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGoAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGoAccount.ForeColor = System.Drawing.Color.White
        Me.btnGoAccount.Location = New System.Drawing.Point(207, 39)
        Me.btnGoAccount.Name = "btnGoAccount"
        Me.btnGoAccount.Size = New System.Drawing.Size(51, 20)
        Me.btnGoAccount.TabIndex = 7
        Me.btnGoAccount.Text = "Go"
        '
        'dgvAccount
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvAccount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvAccount.ColumnHeadersHeight = 15
        Me.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccount.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvAccount.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAccount.Location = New System.Drawing.Point(7, 65)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.RowHeadersVisible = False
        Me.dgvAccount.Size = New System.Drawing.Size(763, 350)
        Me.dgvAccount.TabIndex = 4
        Me.dgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAccount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAccount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAccount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAccount.ThemeStyle.HeaderStyle.Height = 15
        Me.dgvAccount.ThemeStyle.ReadOnly = False
        Me.dgvAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAccount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvAccount.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnNewAccount
        '
        Me.btnNewAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNewAccount.ForeColor = System.Drawing.Color.White
        Me.btnNewAccount.Location = New System.Drawing.Point(612, 20)
        Me.btnNewAccount.Name = "btnNewAccount"
        Me.btnNewAccount.Size = New System.Drawing.Size(144, 26)
        Me.btnNewAccount.TabIndex = 1
        Me.btnNewAccount.Text = "Create New Account"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(7, 7)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(207, 26)
        Me.Guna2HtmlLabel5.TabIndex = 0
        Me.Guna2HtmlLabel5.Text = "Account Management"
        '
        'tbcReport
        '
        Me.tbcReport.Controls.Add(Me.Guna2DataGridView1)
        Me.tbcReport.Controls.Add(Me.btnGenReport)
        Me.tbcReport.Controls.Add(Me.lblDataReport)
        Me.tbcReport.Location = New System.Drawing.Point(184, 4)
        Me.tbcReport.Name = "tbcReport"
        Me.tbcReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcReport.Size = New System.Drawing.Size(776, 450)
        Me.tbcReport.TabIndex = 3
        Me.tbcReport.Text = "Data Report"
        Me.tbcReport.UseVisualStyleBackColor = True
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.Guna2DataGridView1.ColumnHeadersHeight = 15
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(6, 40)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(763, 405)
        Me.Guna2DataGridView1.TabIndex = 3
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnGenReport
        '
        Me.btnGenReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGenReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGenReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGenReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenReport.ForeColor = System.Drawing.Color.White
        Me.btnGenReport.Location = New System.Drawing.Point(644, 6)
        Me.btnGenReport.Name = "btnGenReport"
        Me.btnGenReport.Size = New System.Drawing.Size(125, 28)
        Me.btnGenReport.TabIndex = 2
        Me.btnGenReport.Text = "Generate Report"
        '
        'lblDataReport
        '
        Me.lblDataReport.BackColor = System.Drawing.Color.Transparent
        Me.lblDataReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataReport.Location = New System.Drawing.Point(6, 8)
        Me.lblDataReport.Name = "lblDataReport"
        Me.lblDataReport.Size = New System.Drawing.Size(112, 26)
        Me.lblDataReport.TabIndex = 1
        Me.lblDataReport.Text = "Data Report"
        '
        'lblYourName
        '
        Me.lblYourName.BackColor = System.Drawing.Color.Transparent
        Me.lblYourName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourName.Location = New System.Drawing.Point(20, 15)
        Me.lblYourName.Name = "lblYourName"
        Me.lblYourName.Size = New System.Drawing.Size(126, 26)
        Me.lblYourName.TabIndex = 8
        Me.lblYourName.Text = "YOUR NAME"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.tbcAdminDashboard)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnLogout)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblYourName)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblRole)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 1)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(964, 529)
        Me.Guna2CustomGradientPanel1.TabIndex = 9
        '
        'AdminStaffDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 596)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "AdminStaffDashboardForm"
        Me.Text = " "
        Me.tbcAdminDashboard.ResumeLayout(False)
        Me.tbpDeployment.ResumeLayout(False)
        Me.tbpDeployment.PerformLayout()
        Me.tbpInventory.ResumeLayout(False)
        Me.tbpInventory.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAccount.ResumeLayout(False)
        Me.tbpAccount.PerformLayout()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcReport.ResumeLayout(False)
        Me.tbcReport.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbcAdminDashboard As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tbpDeployment As TabPage
    Friend WithEvents tbpInventory As TabPage
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbpAccount As TabPage
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdditem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInvEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteItems As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblYourName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnGo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSort As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tbcReport As TabPage
    Friend WithEvents lblDataReport As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvAccount As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnGenReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGoAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents chkDescending As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbSortBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnEditAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchAccount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchInv As Guna.UI2.WinForms.Guna2TextBox
End Class
