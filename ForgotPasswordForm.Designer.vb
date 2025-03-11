<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
    Inherits System.Windows.Forms.Form

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
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCheckEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.grpSecurityQuestions = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblQuestion1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAnswer2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblQuestion2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQuestion3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAnswer3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnVerifyAnswers = New Guna.UI2.WinForms.Guna2Button()
        Me.grpResetPassword = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAnswer1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = "User enters email"
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(56, 259)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.TabIndex = 0
        '
        'btnCheckEmail
        '
        Me.btnCheckEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheckEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheckEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCheckEmail.ForeColor = System.Drawing.Color.White
        Me.btnCheckEmail.Location = New System.Drawing.Point(67, 315)
        Me.btnCheckEmail.Name = "btnCheckEmail"
        Me.btnCheckEmail.Size = New System.Drawing.Size(180, 45)
        Me.btnCheckEmail.TabIndex = 1
        Me.btnCheckEmail.Text = "Checks if email exists"
        '
        'grpSecurityQuestions
        '
        Me.grpSecurityQuestions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpSecurityQuestions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpSecurityQuestions.Location = New System.Drawing.Point(67, 53)
        Me.grpSecurityQuestions.Name = "grpSecurityQuestions"
        Me.grpSecurityQuestions.Size = New System.Drawing.Size(300, 200)
        Me.grpSecurityQuestions.TabIndex = 2
        Me.grpSecurityQuestions.Text = "Holds security questions"
        Me.grpSecurityQuestions.Visible = False
        '
        'lblQuestion1
        '
        Me.lblQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion1.Location = New System.Drawing.Point(113, 32)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(96, 15)
        Me.lblQuestion1.TabIndex = 3
        Me.lblQuestion1.Text = "Displays Question 1"
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer2.DefaultText = "Answer for Question 2" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer2.Location = New System.Drawing.Point(488, 259)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.PlaceholderText = ""
        Me.txtAnswer2.SelectedText = ""
        Me.txtAnswer2.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer2.TabIndex = 4
        '
        'lblQuestion2
        '
        Me.lblQuestion2.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion2.Location = New System.Drawing.Point(394, 32)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(96, 15)
        Me.lblQuestion2.TabIndex = 5
        Me.lblQuestion2.Text = "Displays Question 2"
        '
        'lblQuestion3
        '
        Me.lblQuestion3.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion3.Location = New System.Drawing.Point(723, 32)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(96, 15)
        Me.lblQuestion3.TabIndex = 6
        Me.lblQuestion3.Text = "Displays Question 3"
        '
        'txtAnswer3
        '
        Me.txtAnswer3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer3.DefaultText = "Answer for Question 3" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtAnswer3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer3.Location = New System.Drawing.Point(723, 259)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.PlaceholderText = ""
        Me.txtAnswer3.SelectedText = ""
        Me.txtAnswer3.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer3.TabIndex = 7
        '
        'btnVerifyAnswers
        '
        Me.btnVerifyAnswers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVerifyAnswers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVerifyAnswers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVerifyAnswers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVerifyAnswers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVerifyAnswers.ForeColor = System.Drawing.Color.White
        Me.btnVerifyAnswers.Location = New System.Drawing.Point(358, 315)
        Me.btnVerifyAnswers.Name = "btnVerifyAnswers"
        Me.btnVerifyAnswers.Size = New System.Drawing.Size(180, 45)
        Me.btnVerifyAnswers.TabIndex = 8
        Me.btnVerifyAnswers.Text = "Verifies answers" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpResetPassword
        '
        Me.grpResetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpResetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpResetPassword.Location = New System.Drawing.Point(588, 53)
        Me.grpResetPassword.Name = "grpResetPassword"
        Me.grpResetPassword.Size = New System.Drawing.Size(300, 200)
        Me.grpResetPassword.TabIndex = 9
        Me.grpResetPassword.Text = "Holds password reset fields" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.grpResetPassword.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = "Enter new password"
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(113, 435)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtNewPassword.TabIndex = 10
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = "Confirm new password" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(358, 434)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PlaceholderText = ""
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtConfirmPassword.TabIndex = 11
        '
        'btnResetPassword
        '
        Me.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResetPassword.ForeColor = System.Drawing.Color.White
        Me.btnResetPassword.Location = New System.Drawing.Point(588, 426)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(180, 45)
        Me.btnResetPassword.TabIndex = 12
        Me.btnResetPassword.Text = "Updates password in database"
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer1.DefaultText = "Answer for Question 1"
        Me.txtAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer1.Location = New System.Drawing.Point(271, 259)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.PlaceholderText = ""
        Me.txtAnswer1.SelectedText = ""
        Me.txtAnswer1.Size = New System.Drawing.Size(200, 36)
        Me.txtAnswer1.TabIndex = 13
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 499)
        Me.Controls.Add(Me.txtAnswer1)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.grpResetPassword)
        Me.Controls.Add(Me.btnVerifyAnswers)
        Me.Controls.Add(Me.txtAnswer3)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.grpSecurityQuestions)
        Me.Controls.Add(Me.btnCheckEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "ForgotPasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCheckEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpSecurityQuestions As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblQuestion1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAnswer2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblQuestion2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQuestion3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAnswer3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnVerifyAnswers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpResetPassword As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAnswer1 As Guna.UI2.WinForms.Guna2TextBox
End Class
