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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnReturnItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgvBorrowRequests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearchInventory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmitRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.tbcNotification = New System.Windows.Forms.TabPage()
        Me.btnClearNotifications = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvNotifications = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblActiveRequests = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItemsBorrowed = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblOverdueItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tabControlDashboard.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcNotification.SuspendLayout()
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControlDashboard
        '
        Me.tabControlDashboard.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabControlDashboard.Controls.Add(Me.TabPage1)
        Me.tabControlDashboard.Controls.Add(Me.TabPage3)
        Me.tabControlDashboard.Controls.Add(Me.tbcNotification)
        Me.tabControlDashboard.ItemSize = New System.Drawing.Size(180, 40)
        Me.tabControlDashboard.Location = New System.Drawing.Point(1, 70)
        Me.tabControlDashboard.Name = "tabControlDashboard"
        Me.tabControlDashboard.SelectedIndex = 0
        Me.tabControlDashboard.Size = New System.Drawing.Size(1222, 558)
        Me.tabControlDashboard.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabControlDashboard.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tabControlDashboard.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tabControlDashboard.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabControlDashboard.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tabControlDashboard.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tabControlDashboard.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabControlDashboard.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tabControlDashboard.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabControlDashboard.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tabControlDashboard.TabIndex = 1
        Me.tabControlDashboard.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
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
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1034, 550)
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
        Me.btnResetPassword.Location = New System.Drawing.Point(364, 326)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(180, 45)
        Me.btnResetPassword.TabIndex = 8
        Me.btnResetPassword.Text = "Reset Password"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(224, 207)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(31, 15)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.Location = New System.Drawing.Point(224, 249)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(77, 15)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Location = New System.Drawing.Point(221, 156)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(34, 15)
        Me.lblFullName.TabIndex = 5
        Me.lblFullName.Text = "Name:"
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Location = New System.Drawing.Point(195, 102)
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
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Location = New System.Drawing.Point(364, 102)
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
        Me.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(364, 228)
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
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(364, 186)
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
        Me.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.Location = New System.Drawing.Point(364, 144)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = ""
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(200, 36)
        Me.txtFullName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnReturnItem)
        Me.TabPage3.Controls.Add(Me.btnSearchInventory)
        Me.TabPage3.Controls.Add(Me.dgvInventory)
        Me.TabPage3.Controls.Add(Me.dgvBorrowRequests)
        Me.TabPage3.Controls.Add(Me.txtSearchInventory)
        Me.TabPage3.Controls.Add(Me.btnSubmitRequest)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1034, 550)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Borrow Request"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnReturnItem
        '
        Me.btnReturnItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturnItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturnItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReturnItem.ForeColor = System.Drawing.Color.White
        Me.btnReturnItem.Location = New System.Drawing.Point(756, 498)
        Me.btnReturnItem.Name = "btnReturnItem"
        Me.btnReturnItem.Size = New System.Drawing.Size(180, 45)
        Me.btnReturnItem.TabIndex = 4
        Me.btnReturnItem.Text = "Return Item"
        '
        'btnSearchInventory
        '
        Me.btnSearchInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchInventory.ForeColor = System.Drawing.Color.White
        Me.btnSearchInventory.Location = New System.Drawing.Point(271, 0)
        Me.btnSearchInventory.Name = "btnSearchInventory"
        Me.btnSearchInventory.Size = New System.Drawing.Size(180, 45)
        Me.btnSearchInventory.TabIndex = 2
        Me.btnSearchInventory.Text = "Search"
        '
        'dgvInventory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventory.ColumnHeadersHeight = 4
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.Location = New System.Drawing.Point(6, 45)
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
        Me.dgvInventory.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvInventory.ThemeStyle.ReadOnly = True
        Me.dgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.Height = 22
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dgvBorrowRequests
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvBorrowRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBorrowRequests.ColumnHeadersHeight = 4
        Me.dgvBorrowRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowRequests.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBorrowRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBorrowRequests.Location = New System.Drawing.Point(702, 21)
        Me.dgvBorrowRequests.Name = "dgvBorrowRequests"
        Me.dgvBorrowRequests.ReadOnly = True
        Me.dgvBorrowRequests.RowHeadersVisible = False
        Me.dgvBorrowRequests.Size = New System.Drawing.Size(326, 471)
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
        Me.txtSearchInventory.Location = New System.Drawing.Point(36, 3)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.PlaceholderText = ""
        Me.txtSearchInventory.SelectedText = ""
        Me.txtSearchInventory.Size = New System.Drawing.Size(200, 36)
        Me.txtSearchInventory.TabIndex = 1
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmitRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmitRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmitRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmitRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.btnSubmitRequest.Location = New System.Drawing.Point(398, 498)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.Size = New System.Drawing.Size(180, 45)
        Me.btnSubmitRequest.TabIndex = 0
        Me.btnSubmitRequest.Text = "Sumbit"
        '
        'tbcNotification
        '
        Me.tbcNotification.Controls.Add(Me.btnClearNotifications)
        Me.tbcNotification.Controls.Add(Me.dgvNotifications)
        Me.tbcNotification.Location = New System.Drawing.Point(184, 4)
        Me.tbcNotification.Name = "tbcNotification"
        Me.tbcNotification.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcNotification.Size = New System.Drawing.Size(1034, 550)
        Me.tbcNotification.TabIndex = 4
        Me.tbcNotification.Text = "Notification"
        Me.tbcNotification.UseVisualStyleBackColor = True
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
        'dgvNotifications
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvNotifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotifications.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvNotifications.ColumnHeadersHeight = 4
        Me.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotifications.DefaultCellStyle = DataGridViewCellStyle9
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
        'lblActiveRequests
        '
        Me.lblActiveRequests.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveRequests.Location = New System.Drawing.Point(488, 25)
        Me.lblActiveRequests.Name = "lblActiveRequests"
        Me.lblActiveRequests.Size = New System.Drawing.Size(148, 15)
        Me.lblActiveRequests.TabIndex = 2
        Me.lblActiveRequests.Text = "Active Borrow Requests Count"
        '
        'lblItemsBorrowed
        '
        Me.lblItemsBorrowed.BackColor = System.Drawing.Color.Transparent
        Me.lblItemsBorrowed.Location = New System.Drawing.Point(488, 46)
        Me.lblItemsBorrowed.Name = "lblItemsBorrowed"
        Me.lblItemsBorrowed.Size = New System.Drawing.Size(120, 15)
        Me.lblItemsBorrowed.TabIndex = 3
        Me.lblItemsBorrowed.Text = "Items Currently Borrowed"
        '
        'lblOverdueItems
        '
        Me.lblOverdueItems.BackColor = System.Drawing.Color.Transparent
        Me.lblOverdueItems.Location = New System.Drawing.Point(640, 25)
        Me.lblOverdueItems.Name = "lblOverdueItems"
        Me.lblOverdueItems.Size = New System.Drawing.Size(103, 15)
        Me.lblOverdueItems.TabIndex = 4
        Me.lblOverdueItems.Text = "Overdue Items Count"
        '
        'UserDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 629)
        Me.Controls.Add(Me.lblOverdueItems)
        Me.Controls.Add(Me.lblItemsBorrowed)
        Me.Controls.Add(Me.lblActiveRequests)
        Me.Controls.Add(Me.tabControlDashboard)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents tabControlDashboard As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchInventory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbcNotification As TabPage
    Friend WithEvents lblActiveRequests As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItemsBorrowed As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblOverdueItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnSubmitRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvNotifications As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearNotifications As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvBorrowRequests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnReturnItem As Guna.UI2.WinForms.Guna2Button
End Class
