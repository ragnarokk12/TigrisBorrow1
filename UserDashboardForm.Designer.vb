<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboardForm
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.tabControlDashboard = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhoneNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cbCategoryFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbStatusFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnReturnItem = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.COLitem_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colitem_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colbrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colitem_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBorrowRequests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearchInventory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmitRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.tbcNotification = New System.Windows.Forms.TabPage()
        Me.dgvNotifications = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClearNotifications = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.tabControlDashboard.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcNotification.SuspendLayout()
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlDashboard
        '
        Me.tabControlDashboard.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabControlDashboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControlDashboard.Controls.Add(Me.TabPage1)
        Me.tabControlDashboard.Controls.Add(Me.TabPage3)
        Me.tabControlDashboard.Controls.Add(Me.tbcNotification)
        Me.tabControlDashboard.ItemSize = New System.Drawing.Size(180, 40)
        Me.tabControlDashboard.Location = New System.Drawing.Point(0, 85)
        Me.tabControlDashboard.Name = "tabControlDashboard"
        Me.tabControlDashboard.SelectedIndex = 0
        Me.tabControlDashboard.Size = New System.Drawing.Size(1226, 558)
        Me.tabControlDashboard.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.tabControlDashboard.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tabControlDashboard.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.tabControlDashboard.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.tabControlDashboard.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tabControlDashboard.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabControlDashboard.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tabControlDashboard.TabIndex = 1
        Me.tabControlDashboard.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(205, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnResetPassword)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.lblPhoneNumber)
        Me.TabPage1.Controls.Add(Me.lblFullName)
        Me.TabPage1.Controls.Add(Me.lblStudentID)
        Me.TabPage1.Controls.Add(Me.txtStudentID)
        Me.TabPage1.Controls.Add(Me.txtPhoneNumber)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtFullName)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1038, 550)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Profile"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnResetPassword
        '
        Me.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResetPassword.ForeColor = System.Drawing.Color.White
        Me.btnResetPassword.Location = New System.Drawing.Point(481, 341)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(180, 45)
        Me.btnResetPassword.TabIndex = 8
        Me.btnResetPassword.Text = "Reset Password"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(341, 222)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(31, 15)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.Location = New System.Drawing.Point(341, 264)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(77, 15)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Location = New System.Drawing.Point(338, 171)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(34, 15)
        Me.lblFullName.TabIndex = 5
        Me.lblFullName.Text = "Name:"
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Location = New System.Drawing.Point(312, 117)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(57, 15)
        Me.lblStudentID.TabIndex = 4
        Me.lblStudentID.Text = "Student ID:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.HideSelection = False
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Location = New System.Drawing.Point(481, 117)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PlaceholderText = ""
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.Size = New System.Drawing.Size(200, 36)
        Me.txtStudentID.TabIndex = 3
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.DefaultText = ""
        Me.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNumber.HideSelection = False
        Me.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(481, 243)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PlaceholderText = ""
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 36)
        Me.txtPhoneNumber.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.Enabled = False
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HideSelection = False
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(481, 201)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.Enabled = False
        Me.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFullName.HideSelection = False
        Me.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.Location = New System.Drawing.Point(481, 159)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = ""
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(200, 36)
        Me.txtFullName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cbCategoryFilter)
        Me.TabPage3.Controls.Add(Me.cbStatusFilter)
        Me.TabPage3.Controls.Add(Me.btnReturnItem)
        Me.TabPage3.Controls.Add(Me.dgvInventory)
        Me.TabPage3.Controls.Add(Me.dgvBorrowRequests)
        Me.TabPage3.Controls.Add(Me.txtSearchInventory)
        Me.TabPage3.Controls.Add(Me.btnSubmitRequest)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1038, 550)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Borrow Request"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbCategoryFilter
        '
        Me.cbCategoryFilter.BackColor = System.Drawing.Color.Transparent
        Me.cbCategoryFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoryFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCategoryFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCategoryFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCategoryFilter.ItemHeight = 30
        Me.cbCategoryFilter.Location = New System.Drawing.Point(403, 9)
        Me.cbCategoryFilter.Name = "cbCategoryFilter"
        Me.cbCategoryFilter.Size = New System.Drawing.Size(140, 36)
        Me.cbCategoryFilter.TabIndex = 7
        '
        'cbStatusFilter
        '
        Me.cbStatusFilter.BackColor = System.Drawing.Color.Transparent
        Me.cbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStatusFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbStatusFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbStatusFilter.ItemHeight = 30
        Me.cbStatusFilter.Location = New System.Drawing.Point(714, 9)
        Me.cbStatusFilter.Name = "cbStatusFilter"
        Me.cbStatusFilter.Size = New System.Drawing.Size(140, 36)
        Me.cbStatusFilter.TabIndex = 5
        '
        'btnReturnItem
        '
        Me.btnReturnItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturnItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturnItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnReturnItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReturnItem.ForeColor = System.Drawing.Color.White
        Me.btnReturnItem.Location = New System.Drawing.Point(792, 504)
        Me.btnReturnItem.Name = "btnReturnItem"
        Me.btnReturnItem.Size = New System.Drawing.Size(180, 43)
        Me.btnReturnItem.TabIndex = 4
        Me.btnReturnItem.Text = "Return Item"
        '
        'dgvInventory
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvInventory.ColumnHeadersHeight = 15
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLitem_name, Me.Colitem_type, Me.Colbrand, Me.Colmodel, Me.Colcategory, Me.Colstatus, Me.Colitem_id})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.Location = New System.Drawing.Point(32, 51)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.Size = New System.Drawing.Size(664, 447)
        Me.dgvInventory.TabIndex = 3
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
        Me.dgvInventory.ThemeStyle.HeaderStyle.Height = 15
        Me.dgvInventory.ThemeStyle.ReadOnly = True
        Me.dgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.Height = 22
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'COLitem_name
        '
        Me.COLitem_name.FillWeight = 200.0!
        Me.COLitem_name.HeaderText = "Name"
        Me.COLitem_name.Name = "COLitem_name"
        Me.COLitem_name.ReadOnly = True
        '
        'Colitem_type
        '
        Me.Colitem_type.HeaderText = "type"
        Me.Colitem_type.Name = "Colitem_type"
        Me.Colitem_type.ReadOnly = True
        '
        'Colbrand
        '
        Me.Colbrand.HeaderText = "brand"
        Me.Colbrand.Name = "Colbrand"
        Me.Colbrand.ReadOnly = True
        '
        'Colmodel
        '
        Me.Colmodel.HeaderText = "Model"
        Me.Colmodel.Name = "Colmodel"
        Me.Colmodel.ReadOnly = True
        '
        'Colcategory
        '
        Me.Colcategory.HeaderText = "Category"
        Me.Colcategory.Name = "Colcategory"
        Me.Colcategory.ReadOnly = True
        '
        'Colstatus
        '
        Me.Colstatus.HeaderText = "status"
        Me.Colstatus.Name = "Colstatus"
        Me.Colstatus.ReadOnly = True
        Me.Colstatus.Visible = False
        '
        'Colitem_id
        '
        Me.Colitem_id.HeaderText = "item_id"
        Me.Colitem_id.Name = "Colitem_id"
        Me.Colitem_id.ReadOnly = True
        Me.Colitem_id.Visible = False
        '
        'dgvBorrowRequests
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvBorrowRequests.ColumnHeadersHeight = 4
        Me.dgvBorrowRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowRequests.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvBorrowRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBorrowRequests.Location = New System.Drawing.Point(702, 51)
        Me.dgvBorrowRequests.Name = "dgvBorrowRequests"
        Me.dgvBorrowRequests.ReadOnly = True
        Me.dgvBorrowRequests.RowHeadersVisible = False
        Me.dgvBorrowRequests.Size = New System.Drawing.Size(326, 426)
        Me.dgvBorrowRequests.TabIndex = 1
        Me.dgvBorrowRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBorrowRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBorrowRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBorrowRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBorrowRequests.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBorrowRequests.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvBorrowRequests.ThemeStyle.ReadOnly = True
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.Height = 22
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBorrowRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtSearchInventory
        '
        Me.txtSearchInventory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchInventory.DefaultText = ""
        Me.txtSearchInventory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchInventory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchInventory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchInventory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchInventory.Location = New System.Drawing.Point(32, 9)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.PlaceholderText = "Search inventory..."
        Me.txtSearchInventory.SelectedText = ""
        Me.txtSearchInventory.Size = New System.Drawing.Size(331, 36)
        Me.txtSearchInventory.TabIndex = 1
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmitRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmitRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmitRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmitRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSubmitRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.btnSubmitRequest.Location = New System.Drawing.Point(403, 504)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.Size = New System.Drawing.Size(180, 38)
        Me.btnSubmitRequest.TabIndex = 0
        Me.btnSubmitRequest.Text = "Sumbit"
        '
        'tbcNotification
        '
        Me.tbcNotification.Controls.Add(Me.dgvNotifications)
        Me.tbcNotification.Controls.Add(Me.btnClearNotifications)
        Me.tbcNotification.Location = New System.Drawing.Point(184, 4)
        Me.tbcNotification.Name = "tbcNotification"
        Me.tbcNotification.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcNotification.Size = New System.Drawing.Size(1038, 550)
        Me.tbcNotification.TabIndex = 4
        Me.tbcNotification.Text = "Notification"
        Me.tbcNotification.UseVisualStyleBackColor = True
        '
        'dgvNotifications
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.dgvNotifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotifications.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvNotifications.ColumnHeadersHeight = 4
        Me.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotifications.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvNotifications.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvNotifications.Location = New System.Drawing.Point(71, 26)
        Me.dgvNotifications.Name = "dgvNotifications"
        Me.dgvNotifications.RowHeadersVisible = False
        Me.dgvNotifications.Size = New System.Drawing.Size(730, 374)
        Me.dgvNotifications.TabIndex = 0
        Me.dgvNotifications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvNotifications.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvNotifications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvNotifications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvNotifications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvNotifications.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvNotifications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvNotifications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvNotifications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNotifications.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvNotifications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvNotifications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvNotifications.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvNotifications.ThemeStyle.ReadOnly = False
        Me.dgvNotifications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvNotifications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvNotifications.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvNotifications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvNotifications.ThemeStyle.RowsStyle.Height = 22
        Me.dgvNotifications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvNotifications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnClearNotifications
        '
        Me.btnClearNotifications.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearNotifications.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearNotifications.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearNotifications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearNotifications.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearNotifications.ForeColor = System.Drawing.Color.White
        Me.btnClearNotifications.Location = New System.Drawing.Point(126, 434)
        Me.btnClearNotifications.Name = "btnClearNotifications"
        Me.btnClearNotifications.Size = New System.Drawing.Size(180, 45)
        Me.btnClearNotifications.TabIndex = 1
        Me.btnClearNotifications.Text = "Clear Notification"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2CustomGradientPanel4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1226, 85)
        Me.Guna2Panel1.TabIndex = 10
        '
        'Guna2CustomGradientPanel4
        '
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.btnLogout)
        Me.Guna2CustomGradientPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2CustomGradientPanel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Me.Guna2CustomGradientPanel4.Size = New System.Drawing.Size(1226, 149)
        Me.Guna2CustomGradientPanel4.TabIndex = 10
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(31, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(180, 45)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        '
        'UserDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 643)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.tabControlDashboard)
        Me.MinimumSize = New System.Drawing.Size(1242, 659)
        Me.Name = "UserDashboardForm"
        Me.Text = "UserDashboardForm"
        Me.tabControlDashboard.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorrowRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcNotification.ResumeLayout(False)
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents tabControlDashboard As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtSearchInventory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbcNotification As TabPage
    Friend WithEvents btnSubmitRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvNotifications As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearNotifications As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvBorrowRequests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnReturnItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents dgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents COLitem_name As DataGridViewTextBoxColumn
    Friend WithEvents Colitem_type As DataGridViewTextBoxColumn
    Friend WithEvents Colbrand As DataGridViewTextBoxColumn
    Friend WithEvents Colmodel As DataGridViewTextBoxColumn
    Friend WithEvents Colcategory As DataGridViewTextBoxColumn
    Friend WithEvents Colitem_id As DataGridViewTextBoxColumn
    Friend WithEvents Colstatus As DataGridViewTextBoxColumn
    Friend WithEvents cbStatusFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbCategoryFilter As Guna.UI2.WinForms.Guna2ComboBox
End Class
