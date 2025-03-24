<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.lblNewPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblConfirmPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCriteriaUpper = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCriteriaLower = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCriteriaDigit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCriteriaLength = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPasswordMatch = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'lblNewPassword
        '
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Location = New System.Drawing.Point(186, 95)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(77, 15)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password:"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Location = New System.Drawing.Point(173, 206)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(90, 15)
        Me.lblConfirmPassword.TabIndex = 1
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(281, 73)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtNewPassword.TabIndex = 2
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(281, 196)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PlaceholderText = ""
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(467, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(281, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'lblCriteriaUpper
        '
        Me.lblCriteriaUpper.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaUpper.Location = New System.Drawing.Point(293, 133)
        Me.lblCriteriaUpper.Name = "lblCriteriaUpper"
        Me.lblCriteriaUpper.Size = New System.Drawing.Size(126, 15)
        Me.lblCriteriaUpper.TabIndex = 6
        Me.lblCriteriaUpper.Text = "At least 1 uppercase letter"
        '
        'lblCriteriaLower
        '
        Me.lblCriteriaLower.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaLower.Location = New System.Drawing.Point(293, 154)
        Me.lblCriteriaLower.Name = "lblCriteriaLower"
        Me.lblCriteriaLower.Size = New System.Drawing.Size(124, 15)
        Me.lblCriteriaLower.TabIndex = 7
        Me.lblCriteriaLower.Text = "At least 1 lowercase letter"
        '
        'lblCriteriaDigit
        '
        Me.lblCriteriaDigit.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaDigit.Location = New System.Drawing.Point(293, 175)
        Me.lblCriteriaDigit.Name = "lblCriteriaDigit"
        Me.lblCriteriaDigit.Size = New System.Drawing.Size(69, 15)
        Me.lblCriteriaDigit.TabIndex = 8
        Me.lblCriteriaDigit.Text = "At least 1 digit"
        '
        'lblCriteriaLength
        '
        Me.lblCriteriaLength.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaLength.Location = New System.Drawing.Point(293, 112)
        Me.lblCriteriaLength.Name = "lblCriteriaLength"
        Me.lblCriteriaLength.Size = New System.Drawing.Size(68, 15)
        Me.lblCriteriaLength.TabIndex = 9
        Me.lblCriteriaLength.Text = "8+ characters"
        '
        'lblPasswordMatch
        '
        Me.lblPasswordMatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordMatch.Location = New System.Drawing.Point(293, 238)
        Me.lblPasswordMatch.Name = "lblPasswordMatch"
        Me.lblPasswordMatch.Size = New System.Drawing.Size(186, 15)
        Me.lblPasswordMatch.TabIndex = 10
        Me.lblPasswordMatch.Text = "Displays whether the passwords match"
        Me.lblPasswordMatch.Visible = False
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPasswordMatch)
        Me.Controls.Add(Me.lblCriteriaLength)
        Me.Controls.Add(Me.lblCriteriaDigit)
        Me.Controls.Add(Me.lblCriteriaLower)
        Me.Controls.Add(Me.lblCriteriaUpper)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Name = "ChangePasswordForm"
        Me.Text = "ChangePasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblConfirmPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCriteriaUpper As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCriteriaLower As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCriteriaDigit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCriteriaLength As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPasswordMatch As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
