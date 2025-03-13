<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        Me.TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirmEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelSecurityQuestions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnBackQuestion = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirmQuestion = New Guna.UI2.WinForms.Guna2Button()
        Me.cboQuestion3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboQuestion2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboQuestion1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtAnswer3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAnswer2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAnswer1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnBackPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirmPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelNewPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(962, 686)
        Me.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelEmail)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnConfirmEmail)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(954, 638)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Step 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PanelEmail
        '
        Me.PanelEmail.BackColor = System.Drawing.Color.Transparent
        Me.PanelEmail.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEmail.Location = New System.Drawing.Point(310, 144)
        Me.PanelEmail.Name = "PanelEmail"
        Me.PanelEmail.Size = New System.Drawing.Size(322, 47)
        Me.PanelEmail.TabIndex = 3
        Me.PanelEmail.Text = "Enter Registered Email"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(376, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnConfirmEmail
        '
        Me.btnConfirmEmail.BorderRadius = 10
        Me.btnConfirmEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfirmEmail.ForeColor = System.Drawing.Color.White
        Me.btnConfirmEmail.Location = New System.Drawing.Point(376, 309)
        Me.btnConfirmEmail.Name = "btnConfirmEmail"
        Me.btnConfirmEmail.Size = New System.Drawing.Size(180, 45)
        Me.btnConfirmEmail.TabIndex = 1
        Me.btnConfirmEmail.Text = "Confirm"
        '
        'txtEmail
        '
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
        Me.txtEmail.Location = New System.Drawing.Point(334, 230)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = "example@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(259, 57)
        Me.txtEmail.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelSecurityQuestions)
        Me.TabPage2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.TabPage2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.TabPage2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.TabPage2.Controls.Add(Me.btnBackQuestion)
        Me.TabPage2.Controls.Add(Me.btnConfirmQuestion)
        Me.TabPage2.Controls.Add(Me.cboQuestion3)
        Me.TabPage2.Controls.Add(Me.cboQuestion2)
        Me.TabPage2.Controls.Add(Me.cboQuestion1)
        Me.TabPage2.Controls.Add(Me.txtAnswer3)
        Me.TabPage2.Controls.Add(Me.txtAnswer2)
        Me.TabPage2.Controls.Add(Me.txtAnswer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(954, 638)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Step 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PanelSecurityQuestions
        '
        Me.PanelSecurityQuestions.BackColor = System.Drawing.Color.Transparent
        Me.PanelSecurityQuestions.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecurityQuestions.Location = New System.Drawing.Point(357, 16)
        Me.PanelSecurityQuestions.Name = "PanelSecurityQuestions"
        Me.PanelSecurityQuestions.Size = New System.Drawing.Size(267, 47)
        Me.PanelSecurityQuestions.TabIndex = 11
        Me.PanelSecurityQuestions.Text = "Security Questions"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Nirmala UI", 9.75!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(446, 371)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(66, 19)
        Me.Guna2HtmlLabel4.TabIndex = 10
        Me.Guna2HtmlLabel4.Text = "Question 3"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Nirmala UI", 9.75!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(446, 228)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(66, 19)
        Me.Guna2HtmlLabel3.TabIndex = 9
        Me.Guna2HtmlLabel3.Text = "Question 2"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(446, 84)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(66, 19)
        Me.Guna2HtmlLabel2.TabIndex = 8
        Me.Guna2HtmlLabel2.Text = "Question 1"
        '
        'btnBackQuestion
        '
        Me.btnBackQuestion.BorderRadius = 10
        Me.btnBackQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackQuestion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackQuestion.ForeColor = System.Drawing.Color.White
        Me.btnBackQuestion.Location = New System.Drawing.Point(277, 520)
        Me.btnBackQuestion.Name = "btnBackQuestion"
        Me.btnBackQuestion.Size = New System.Drawing.Size(180, 45)
        Me.btnBackQuestion.TabIndex = 7
        Me.btnBackQuestion.Text = "Back"
        '
        'btnConfirmQuestion
        '
        Me.btnConfirmQuestion.BorderRadius = 10
        Me.btnConfirmQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmQuestion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfirmQuestion.ForeColor = System.Drawing.Color.White
        Me.btnConfirmQuestion.Location = New System.Drawing.Point(514, 520)
        Me.btnConfirmQuestion.Name = "btnConfirmQuestion"
        Me.btnConfirmQuestion.Size = New System.Drawing.Size(180, 45)
        Me.btnConfirmQuestion.TabIndex = 6
        Me.btnConfirmQuestion.Text = "Confirm"
        '
        'cboQuestion3
        '
        Me.cboQuestion3.BackColor = System.Drawing.Color.Transparent
        Me.cboQuestion3.BorderRadius = 15
        Me.cboQuestion3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboQuestion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboQuestion3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboQuestion3.ItemHeight = 30
        Me.cboQuestion3.Location = New System.Drawing.Point(314, 396)
        Me.cboQuestion3.Name = "cboQuestion3"
        Me.cboQuestion3.Size = New System.Drawing.Size(344, 36)
        Me.cboQuestion3.TabIndex = 5
        '
        'cboQuestion2
        '
        Me.cboQuestion2.BackColor = System.Drawing.Color.Transparent
        Me.cboQuestion2.BorderRadius = 15
        Me.cboQuestion2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboQuestion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboQuestion2.ItemHeight = 30
        Me.cboQuestion2.Location = New System.Drawing.Point(314, 253)
        Me.cboQuestion2.Name = "cboQuestion2"
        Me.cboQuestion2.Size = New System.Drawing.Size(344, 36)
        Me.cboQuestion2.TabIndex = 4
        '
        'cboQuestion1
        '
        Me.cboQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.cboQuestion1.BorderRadius = 15
        Me.cboQuestion1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboQuestion1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboQuestion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboQuestion1.ItemHeight = 30
        Me.cboQuestion1.Location = New System.Drawing.Point(314, 109)
        Me.cboQuestion1.Name = "cboQuestion1"
        Me.cboQuestion1.Size = New System.Drawing.Size(344, 36)
        Me.cboQuestion1.TabIndex = 3
        '
        'txtAnswer3
        '
        Me.txtAnswer3.BorderRadius = 15
        Me.txtAnswer3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer3.DefaultText = ""
        Me.txtAnswer3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer3.Location = New System.Drawing.Point(383, 450)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.PlaceholderText = "Answer"
        Me.txtAnswer3.SelectedText = ""
        Me.txtAnswer3.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer3.TabIndex = 2
        '
        'txtAnswer2
        '
        Me.txtAnswer2.BorderRadius = 15
        Me.txtAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer2.DefaultText = ""
        Me.txtAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer2.Location = New System.Drawing.Point(383, 310)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.PlaceholderText = "Answer"
        Me.txtAnswer2.SelectedText = ""
        Me.txtAnswer2.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer2.TabIndex = 1
        '
        'txtAnswer1
        '
        Me.txtAnswer1.BorderRadius = 15
        Me.txtAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer1.DefaultText = ""
        Me.txtAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer1.Location = New System.Drawing.Point(383, 163)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.PlaceholderText = "Answer"
        Me.txtAnswer1.SelectedText = ""
        Me.txtAnswer1.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnBackPassword)
        Me.TabPage3.Controls.Add(Me.btnConfirmPassword)
        Me.TabPage3.Controls.Add(Me.chkShowPassword)
        Me.TabPage3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.TabPage3.Controls.Add(Me.PanelNewPassword)
        Me.TabPage3.Controls.Add(Me.txtConfirmPassword)
        Me.TabPage3.Controls.Add(Me.txtNewPassword)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(954, 638)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Step 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnBackPassword
        '
        Me.btnBackPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackPassword.ForeColor = System.Drawing.Color.White
        Me.btnBackPassword.Location = New System.Drawing.Point(402, 449)
        Me.btnBackPassword.Name = "btnBackPassword"
        Me.btnBackPassword.Size = New System.Drawing.Size(180, 45)
        Me.btnBackPassword.TabIndex = 6
        Me.btnBackPassword.Text = "Back"
        '
        'btnConfirmPassword
        '
        Me.btnConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.btnConfirmPassword.Location = New System.Drawing.Point(402, 382)
        Me.btnConfirmPassword.Name = "btnConfirmPassword"
        Me.btnConfirmPassword.Size = New System.Drawing.Size(180, 45)
        Me.btnConfirmPassword.TabIndex = 5
        Me.btnConfirmPassword.Text = "Confirm"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 0
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(368, 198)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(108, 19)
        Me.chkShowPassword.TabIndex = 4
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 0
        Me.chkShowPassword.UncheckedState.BorderThickness = 0
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(402, 256)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(167, 23)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "Confirm New Password"
        '
        'PanelNewPassword
        '
        Me.PanelNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.PanelNewPassword.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelNewPassword.Location = New System.Drawing.Point(408, 106)
        Me.PanelNewPassword.Name = "PanelNewPassword"
        Me.PanelNewPassword.Size = New System.Drawing.Size(155, 23)
        Me.PanelNewPassword.TabIndex = 2
        Me.PanelNewPassword.Text = "Create New Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderRadius = 15
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(356, 289)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PlaceholderText = "Re-enter new password"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(259, 57)
        Me.txtConfirmPassword.TabIndex = 1
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderRadius = 15
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(356, 135)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PlaceholderText = "Enter new password"
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(259, 57)
        Me.txtNewPassword.TabIndex = 0
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 686)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "ForgotPasswordForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnBackQuestion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmQuestion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboQuestion3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboQuestion2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboQuestion1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtAnswer3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAnswer2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAnswer1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PanelNewPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelSecurityQuestions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnBackPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmPassword As Guna.UI2.WinForms.Guna2Button
End Class
