<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblForgotPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkShowPassword2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblInstruction = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlControlPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.lblLogin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlControlPanel.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.Animated = True
        Me.btnSignUp.BorderRadius = 5
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.Transparent
        Me.btnSignUp.Font = New System.Drawing.Font("Sifonn", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.Location = New System.Drawing.Point(40, 334)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(180, 45)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign-Up"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.BorderRadius = 6
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtPassword.IconLeft = Global.TigrisBorrow.My.Resources.Resources.key__1_
        Me.txtPassword.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtPassword.IconLeftSize = New System.Drawing.Size(17, 17)
        Me.txtPassword.Location = New System.Drawing.Point(27, 155)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.AutoSize = False
        Me.lblForgotPassword.AutoSizeHeightOnly = True
        Me.lblForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblForgotPassword.Location = New System.Drawing.Point(77, 262)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(106, 14)
        Me.lblForgotPassword.TabIndex = 2
        Me.lblForgotPassword.Text = "Forgot Password?"
        '
        'chkShowPassword2
        '
        Me.chkShowPassword2.AutoSize = True
        Me.chkShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.CheckedState.BorderRadius = 0
        Me.chkShowPassword2.CheckedState.BorderThickness = 0
        Me.chkShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.Location = New System.Drawing.Point(562, 237)
        Me.chkShowPassword2.Name = "chkShowPassword2"
        Me.chkShowPassword2.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword2.TabIndex = 5
        Me.chkShowPassword2.Text = "Show Password"
        Me.chkShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword2.UncheckedState.BorderRadius = 0
        Me.chkShowPassword2.UncheckedState.BorderThickness = 0
        Me.chkShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'txtUserID
        '
        Me.txtUserID.Animated = True
        Me.txtUserID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUserID.BorderRadius = 6
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = ""
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUserID.ForeColor = System.Drawing.Color.Black
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtUserID.IconLeft = Global.TigrisBorrow.My.Resources.Resources.envelope
        Me.txtUserID.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtUserID.IconLeftSize = New System.Drawing.Size(17, 17)
        Me.txtUserID.Location = New System.Drawing.Point(27, 113)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PlaceholderText = "2000-00000"
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.Size = New System.Drawing.Size(200, 36)
        Me.txtUserID.TabIndex = 0
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Location = New System.Drawing.Point(32, 91)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(197, 15)
        Me.lblInstruction.TabIndex = 6
        Me.lblInstruction.Text = "Please enter your User ID and Password."
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlControlPanel
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'pnlControlPanel
        '
        Me.pnlControlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlControlPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlControlPanel.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlControlPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControlPanel.ForeColor = System.Drawing.Color.Transparent
        Me.pnlControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlControlPanel.Name = "pnlControlPanel"
        Me.pnlControlPanel.Size = New System.Drawing.Size(819, 29)
        Me.pnlControlPanel.TabIndex = 9
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sifonn", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(112, 19)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "TIGRIS BORROW"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(729, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(774, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2ShadowPanel1.AutoSize = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblInstruction)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.chkShowPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblLogin)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnLogin)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSignUp)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblForgotPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtUserID)
        Me.Guna2ShadowPanel1.EdgeWidth = 10
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(503, 28)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 15
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DimGray
        Me.Guna2ShadowPanel1.ShadowDepth = 255
        Me.Guna2ShadowPanel1.ShadowShift = 10
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(266, 419)
        Me.Guna2ShadowPanel1.TabIndex = 7
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(57, 198)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(79, 15)
        Me.Guna2HtmlLabel4.TabIndex = 10
        Me.Guna2HtmlLabel4.Text = "Show Password"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Animated = True
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 2
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.Transparent
        Me.chkShowPassword.Location = New System.Drawing.Point(36, 197)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(15, 15)
        Me.chkShowPassword.TabIndex = 9
        Me.chkShowPassword.Text = "dewsdg"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 2
        Me.chkShowPassword.UncheckedState.BorderThickness = 1
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Sifonn", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(70, 38)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(121, 47)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "LOGIN"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderRadius = 5
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Sifonn", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnLogin.Location = New System.Drawing.Point(40, 282)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(180, 45)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-45, 106)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(520, 185)
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Sifonn", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(45, 221)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(20, 3, 20, 3)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(136, 27)
        Me.Guna2HtmlLabel2.TabIndex = 10
        Me.Guna2HtmlLabel2.Text = "LPU LAGUNA"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Sifonn", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(45, 371)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(20, 3, 20, 3)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(414, 21)
        Me.Guna2HtmlLabel3.TabIndex = 11
        Me.Guna2HtmlLabel3.Text = "The only app you'll need to get the equipment you seek!"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoSize = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(819, 484)
        Me.Guna2Panel1.TabIndex = 12
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 7
        Me.Guna2Elipse1.TargetControl = Me
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 513)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlControlPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.pnlControlPanel.ResumeLayout(False)
        Me.pnlControlPanel.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblForgotPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chkShowPassword2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblInstruction As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblLogin As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlControlPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
