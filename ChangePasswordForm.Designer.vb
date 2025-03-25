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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordForm))
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
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNewPassword
        '
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.Location = New System.Drawing.Point(72, 81)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(96, 18)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password:"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(54, 263)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(114, 18)
        Me.lblConfirmPassword.TabIndex = 1
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderRadius = 10
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(174, 72)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(173, 36)
        Me.txtNewPassword.TabIndex = 2
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderRadius = 10
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(174, 254)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PlaceholderText = ""
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(173, 36)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.White
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(346, 668)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 10
        Me.btnSave.BorderThickness = 1
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(532, 668)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'lblCriteriaUpper
        '
        Me.lblCriteriaUpper.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteriaUpper.Location = New System.Drawing.Point(174, 135)
        Me.lblCriteriaUpper.Name = "lblCriteriaUpper"
        Me.lblCriteriaUpper.Size = New System.Drawing.Size(143, 17)
        Me.lblCriteriaUpper.TabIndex = 6
        Me.lblCriteriaUpper.Text = "At least 1 uppercase letter"
        '
        'lblCriteriaLower
        '
        Me.lblCriteriaLower.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteriaLower.Location = New System.Drawing.Point(174, 156)
        Me.lblCriteriaLower.Name = "lblCriteriaLower"
        Me.lblCriteriaLower.Size = New System.Drawing.Size(141, 17)
        Me.lblCriteriaLower.TabIndex = 7
        Me.lblCriteriaLower.Text = "At least 1 lowercase letter"
        '
        'lblCriteriaDigit
        '
        Me.lblCriteriaDigit.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaDigit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteriaDigit.Location = New System.Drawing.Point(174, 177)
        Me.lblCriteriaDigit.Name = "lblCriteriaDigit"
        Me.lblCriteriaDigit.Size = New System.Drawing.Size(78, 17)
        Me.lblCriteriaDigit.TabIndex = 8
        Me.lblCriteriaDigit.Text = "At least 1 digit"
        '
        'lblCriteriaLength
        '
        Me.lblCriteriaLength.BackColor = System.Drawing.Color.Transparent
        Me.lblCriteriaLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteriaLength.Location = New System.Drawing.Point(174, 114)
        Me.lblCriteriaLength.Name = "lblCriteriaLength"
        Me.lblCriteriaLength.Size = New System.Drawing.Size(77, 17)
        Me.lblCriteriaLength.TabIndex = 9
        Me.lblCriteriaLength.Text = "8+ characters"
        '
        'lblPasswordMatch
        '
        Me.lblPasswordMatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordMatch.Location = New System.Drawing.Point(174, 296)
        Me.lblPasswordMatch.Name = "lblPasswordMatch"
        Me.lblPasswordMatch.Size = New System.Drawing.Size(215, 17)
        Me.lblPasswordMatch.TabIndex = 10
        Me.lblPasswordMatch.Text = "Displays whether the passwords match"
        Me.lblPasswordMatch.Visible = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 0
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.Location = New System.Drawing.Point(178, 322)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 11
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 0
        Me.chkShowPassword.UncheckedState.BorderThickness = 0
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCriteriaUpper)
        Me.Guna2ShadowPanel1.Controls.Add(Me.chkShowPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblNewPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblPasswordMatch)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblConfirmPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCriteriaLength)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtNewPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCriteriaDigit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtConfirmPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCriteriaLower)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(167, 168)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(435, 392)
        Me.Guna2ShadowPanel1.TabIndex = 12
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 725)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "ChangePasswordForm"
        Me.Text = "ChangePasswordForm"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
