<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.lblUserID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblContact = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblConfirmPass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSecQ1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSecQ2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSecQ3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecQ1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecQ2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecQ3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbSecQ1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSecQ2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSecQ3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlTOP = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.spnlSecurity = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSignup = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.pnlTOP.SuspendLayout()
        Me.spnlSecurity.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(42, 98)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(77, 19)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "ID Number:"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.Transparent
        Me.txtUserID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtUserID.BorderRadius = 15
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = ""
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.Location = New System.Drawing.Point(130, 80)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PlaceholderText = "Enter your student ID"
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.Size = New System.Drawing.Size(259, 57)
        Me.txtUserID.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(42, 174)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(75, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtFirstName.BorderRadius = 15
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(130, 154)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PlaceholderText = "Enter your full name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(259, 57)
        Me.txtFirstName.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Sifonn", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(622, 109)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(284, 85)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "SIGN UP"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(520, 94)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 23)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(430, 189)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(138, 23)
        Me.lblContact.TabIndex = 6
        Me.lblContact.Text = "Contact Number:"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(493, 293)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPass.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(423, 408)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(145, 23)
        Me.lblConfirmPass.TabIndex = 8
        Me.lblConfirmPass.Text = "Confirm Password:"
        '
        'lblSecQ1
        '
        Me.lblSecQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblSecQ1.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecQ1.Location = New System.Drawing.Point(36, 83)
        Me.lblSecQ1.Name = "lblSecQ1"
        Me.lblSecQ1.Size = New System.Drawing.Size(156, 23)
        Me.lblSecQ1.TabIndex = 9
        Me.lblSecQ1.Text = "Security Question 1:"
        '
        'lblSecQ2
        '
        Me.lblSecQ2.BackColor = System.Drawing.Color.Transparent
        Me.lblSecQ2.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecQ2.Location = New System.Drawing.Point(36, 282)
        Me.lblSecQ2.Name = "lblSecQ2"
        Me.lblSecQ2.Size = New System.Drawing.Size(159, 23)
        Me.lblSecQ2.TabIndex = 10
        Me.lblSecQ2.Text = "Security Question 2:"
        '
        'lblSecQ3
        '
        Me.lblSecQ3.BackColor = System.Drawing.Color.Transparent
        Me.lblSecQ3.Font = New System.Drawing.Font("Sifonn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecQ3.Location = New System.Drawing.Point(36, 478)
        Me.lblSecQ3.Name = "lblSecQ3"
        Me.lblSecQ3.Size = New System.Drawing.Size(159, 23)
        Me.lblSecQ3.TabIndex = 11
        Me.lblSecQ3.Text = "Security Question 3:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtEmail.BorderRadius = 15
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(578, 77)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = "example@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(259, 57)
        Me.txtEmail.TabIndex = 14
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.Transparent
        Me.txtContact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtContact.BorderRadius = 15
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(578, 173)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PlaceholderText = "09xxxxxxxxx"
        Me.txtContact.SelectedText = ""
        Me.txtContact.Size = New System.Drawing.Size(259, 57)
        Me.txtContact.TabIndex = 15
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(578, 273)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Enter password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(259, 57)
        Me.txtPassword.TabIndex = 16
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtConfirmPass.BorderRadius = 15
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Location = New System.Drawing.Point(578, 387)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PlaceholderText = "Re-enter password"
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.Size = New System.Drawing.Size(259, 57)
        Me.txtConfirmPass.TabIndex = 17
        '
        'txtSecQ1
        '
        Me.txtSecQ1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSecQ1.BorderRadius = 15
        Me.txtSecQ1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecQ1.DefaultText = ""
        Me.txtSecQ1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecQ1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecQ1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSecQ1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ1.Location = New System.Drawing.Point(36, 148)
        Me.txtSecQ1.Name = "txtSecQ1"
        Me.txtSecQ1.PlaceholderText = "Answer to security question 1"
        Me.txtSecQ1.SelectedText = ""
        Me.txtSecQ1.Size = New System.Drawing.Size(299, 59)
        Me.txtSecQ1.TabIndex = 18
        '
        'txtSecQ2
        '
        Me.txtSecQ2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSecQ2.BorderRadius = 15
        Me.txtSecQ2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecQ2.DefaultText = ""
        Me.txtSecQ2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecQ2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecQ2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSecQ2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ2.Location = New System.Drawing.Point(36, 353)
        Me.txtSecQ2.Name = "txtSecQ2"
        Me.txtSecQ2.PlaceholderText = "Answer to security question 2"
        Me.txtSecQ2.SelectedText = ""
        Me.txtSecQ2.Size = New System.Drawing.Size(299, 57)
        Me.txtSecQ2.TabIndex = 19
        '
        'txtSecQ3
        '
        Me.txtSecQ3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSecQ3.BorderRadius = 15
        Me.txtSecQ3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecQ3.DefaultText = ""
        Me.txtSecQ3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecQ3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecQ3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQ3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSecQ3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecQ3.Location = New System.Drawing.Point(36, 549)
        Me.txtSecQ3.Name = "txtSecQ3"
        Me.txtSecQ3.PlaceholderText = "Answer to Security question 3"
        Me.txtSecQ3.SelectedText = ""
        Me.txtSecQ3.Size = New System.Drawing.Size(299, 57)
        Me.txtSecQ3.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.White
        Me.btnCancel.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(242, 816)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        '
        'cmbSecQ1
        '
        Me.cmbSecQ1.BackColor = System.Drawing.Color.Transparent
        Me.cmbSecQ1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cmbSecQ1.BorderRadius = 15
        Me.cmbSecQ1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSecQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecQ1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSecQ1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSecQ1.ItemHeight = 30
        Me.cmbSecQ1.Location = New System.Drawing.Point(36, 106)
        Me.cmbSecQ1.Name = "cmbSecQ1"
        Me.cmbSecQ1.Size = New System.Drawing.Size(299, 36)
        Me.cmbSecQ1.TabIndex = 23
        '
        'cmbSecQ2
        '
        Me.cmbSecQ2.BackColor = System.Drawing.Color.Transparent
        Me.cmbSecQ2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cmbSecQ2.BorderRadius = 15
        Me.cmbSecQ2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSecQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecQ2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSecQ2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSecQ2.ItemHeight = 30
        Me.cmbSecQ2.Location = New System.Drawing.Point(36, 311)
        Me.cmbSecQ2.Name = "cmbSecQ2"
        Me.cmbSecQ2.Size = New System.Drawing.Size(299, 36)
        Me.cmbSecQ2.TabIndex = 24
        '
        'cmbSecQ3
        '
        Me.cmbSecQ3.BackColor = System.Drawing.Color.Transparent
        Me.cmbSecQ3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cmbSecQ3.BorderRadius = 15
        Me.cmbSecQ3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSecQ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecQ3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecQ3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSecQ3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSecQ3.ItemHeight = 30
        Me.cmbSecQ3.Location = New System.Drawing.Point(36, 507)
        Me.cmbSecQ3.Name = "cmbSecQ3"
        Me.cmbSecQ3.Size = New System.Drawing.Size(299, 36)
        Me.cmbSecQ3.TabIndex = 25
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 0
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(578, 346)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(123, 21)
        Me.chkShowPassword.TabIndex = 26
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 0
        Me.chkShowPassword.UncheckedState.BorderThickness = 0
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1395, -1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 27
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1350, -1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 28
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(42, 253)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 19)
        Me.lblLastName.TabIndex = 29
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Animated = True
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtLastName.BorderRadius = 15
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(130, 225)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PlaceholderText = "Enter your Last name"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(259, 65)
        Me.txtLastName.TabIndex = 30
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.pnlTOP
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'pnlTOP
        '
        Me.pnlTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTOP.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlTOP.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlTOP.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTOP.Location = New System.Drawing.Point(0, 0)
        Me.pnlTOP.Name = "pnlTOP"
        Me.pnlTOP.Size = New System.Drawing.Size(1440, 27)
        Me.pnlTOP.TabIndex = 31
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 5)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(112, 19)
        Me.Guna2HtmlLabel1.TabIndex = 29
        Me.Guna2HtmlLabel1.Text = "TIGRIS BORROW"
        '
        'spnlSecurity
        '
        Me.spnlSecurity.BackColor = System.Drawing.Color.Transparent
        Me.spnlSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.spnlSecurity.Controls.Add(Me.Guna2HtmlLabel3)
        Me.spnlSecurity.Controls.Add(Me.Guna2HtmlLabel2)
        Me.spnlSecurity.Controls.Add(Me.lblSecQ1)
        Me.spnlSecurity.Controls.Add(Me.lblSecQ2)
        Me.spnlSecurity.Controls.Add(Me.lblSecQ3)
        Me.spnlSecurity.Controls.Add(Me.txtSecQ1)
        Me.spnlSecurity.Controls.Add(Me.txtSecQ2)
        Me.spnlSecurity.Controls.Add(Me.cmbSecQ3)
        Me.spnlSecurity.Controls.Add(Me.txtSecQ3)
        Me.spnlSecurity.Controls.Add(Me.cmbSecQ2)
        Me.spnlSecurity.Controls.Add(Me.cmbSecQ1)
        Me.spnlSecurity.EdgeWidth = 10
        Me.spnlSecurity.FillColor = System.Drawing.Color.White
        Me.spnlSecurity.Location = New System.Drawing.Point(1009, 97)
        Me.spnlSecurity.Name = "spnlSecurity"
        Me.spnlSecurity.Radius = 15
        Me.spnlSecurity.ShadowColor = System.Drawing.Color.DimGray
        Me.spnlSecurity.ShadowDepth = 255
        Me.spnlSecurity.ShadowShift = 10
        Me.spnlSecurity.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.spnlSecurity.Size = New System.Drawing.Size(386, 692)
        Me.spnlSecurity.TabIndex = 32
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(36, 51)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(215, 19)
        Me.Guna2HtmlLabel3.TabIndex = 34
        Me.Guna2HtmlLabel3.Text = "Incase you forgot your Password."
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Sifonn", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(36, 23)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(138, 29)
        Me.Guna2HtmlLabel2.TabIndex = 33
        Me.Guna2HtmlLabel2.Text = "IMPORTANT!"
        '
        'btnSignup
        '
        Me.btnSignup.Animated = True
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BorderRadius = 5
        Me.btnSignup.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSignup.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignup.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSignup.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSignup.Font = New System.Drawing.Font("Sifonn", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnSignup.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSignup.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSignup.Location = New System.Drawing.Point(49, 816)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(180, 45)
        Me.btnSignup.TabIndex = 33
        Me.btnSignup.Text = "Sign Up"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Sifonn", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(44, 182)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(136, 27)
        Me.Guna2HtmlLabel4.TabIndex = 35
        Me.Guna2HtmlLabel4.Text = "LPU LAGUNA"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-46, 67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(520, 185)
        Me.Guna2PictureBox1.TabIndex = 34
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtUserID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblUserID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblFirstName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtFirstName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblEmail)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblContact)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtLastName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblConfirmPass)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblLastName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtEmail)
        Me.Guna2ShadowPanel1.Controls.Add(Me.chkShowPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtContact)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtConfirmPass)
        Me.Guna2ShadowPanel1.EdgeWidth = 10
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(44, 258)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 15
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DimGray
        Me.Guna2ShadowPanel1.ShadowDepth = 255
        Me.Guna2ShadowPanel1.ShadowShift = 10
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(945, 531)
        Me.Guna2ShadowPanel1.TabIndex = 35
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 895)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.spnlSecurity)
        Me.Controls.Add(Me.pnlTOP)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpForm"
        Me.Text = "SignUpForm"
        Me.pnlTOP.ResumeLayout(False)
        Me.pnlTOP.PerformLayout()
        Me.spnlSecurity.ResumeLayout(False)
        Me.spnlSecurity.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblContact As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblConfirmPass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSecQ1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSecQ2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSecQ3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSecQ1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSecQ2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSecQ3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbSecQ1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSecQ2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSecQ3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlTOP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents spnlSecurity As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSignup As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
