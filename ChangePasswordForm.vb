Imports Guna.UI2.WinForms
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class ChangePasswordForm
    Inherits BaseForm

    ' This property will hold the new password entered by the user.
    Public Property NewPasswordText As String = ""

    Private Const NewPasswordPlaceholder As String = "Enter new password"
    Private Const ConfirmPasswordPlaceholder As String = "Confirm new password"

    ' Form Load: clear textboxes, set masking, and hide error label.
    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewPassword.Text = ""
        txtConfirmPassword.Text = ""
        txtNewPassword.ForeColor = Color.Black
        txtConfirmPassword.ForeColor = Color.Black

        ' Use custom masking without UseSystemPasswordChar.
        txtNewPassword.PasswordChar = "●"c
        txtConfirmPassword.PasswordChar = "●"c

        ' Hide the password match and emoji error labels initially.
        lblPasswordMatch.Visible = False
        lblEmojiError.Visible = False

        ' Enable Save button initially.
        btnSave.Enabled = True
    End Sub

    ' Show Password checkbox toggles the PasswordChar property.
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtNewPassword.PasswordChar = ControlChars.NullChar
            txtConfirmPassword.PasswordChar = ControlChars.NullChar
        Else
            txtNewPassword.PasswordChar = "●"c
            txtConfirmPassword.PasswordChar = "●"c
        End If
    End Sub

    ' Real-time validation on new password text change.
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        UpdatePasswordCriteriaLabels()
        UpdatePasswordMatchLabel()
        CheckForEmojisAndUpdate()
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        UpdatePasswordMatchLabel()
        CheckForEmojisAndUpdate()
    End Sub

    ' Updates the criteria labels.
    Private Sub UpdatePasswordCriteriaLabels()
        Dim pwd As String = txtNewPassword.Text

        lblCriteriaLength.Text = "8+ characters"
        lblCriteriaLength.ForeColor = If(pwd.Length >= 8, Color.Green, Color.Red)

        lblCriteriaUpper.Text = "At least 1 uppercase letter"
        lblCriteriaUpper.ForeColor = If(pwd.Any(Function(c) Char.IsUpper(c)), Color.Green, Color.Red)

        lblCriteriaLower.Text = "At least 1 lowercase letter"
        lblCriteriaLower.ForeColor = If(pwd.Any(Function(c) Char.IsLower(c)), Color.Green, Color.Red)

        lblCriteriaDigit.Text = "At least 1 digit"
        lblCriteriaDigit.ForeColor = If(pwd.Any(Function(c) Char.IsDigit(c)), Color.Green, Color.Red)
    End Sub

    ' Updates the password match label.
    Private Sub UpdatePasswordMatchLabel()
        Dim pwd As String = txtNewPassword.Text
        Dim confirmPwd As String = txtConfirmPassword.Text

        ' Hide the match label if both fields are empty.
        If String.IsNullOrEmpty(pwd) AndAlso String.IsNullOrEmpty(confirmPwd) Then
            lblPasswordMatch.Visible = False
            lblPasswordMatch.Text = ""
            Return
        End If

        lblPasswordMatch.Visible = True

        If pwd = confirmPwd Then
            lblPasswordMatch.Text = "Passwords match"
            lblPasswordMatch.ForeColor = Color.Green
        Else
            lblPasswordMatch.Text = "Passwords do not match"
            lblPasswordMatch.ForeColor = Color.Red
        End If
    End Sub

    ' Checks if the new password input contains emojis.
    ' If emojis are found, display an error label and disable Save button.
    Private Sub CheckForEmojisAndUpdate()
        Dim pwdOriginal As String = txtNewPassword.Text
        Dim pwdClean As String = RemoveEmojis(pwdOriginal)

        If pwdOriginal <> pwdClean Then
            lblEmojiError.Text = "Emojis are not allowed in the password."
            lblEmojiError.ForeColor = Color.Red
            lblEmojiError.Visible = True
            btnSave.Enabled = False
        Else
            lblEmojiError.Visible = False
            ' Optionally, re-enable the Save button if all other validations pass.
            btnSave.Enabled = True
        End If
    End Sub

    ' RemoveEmojis: Removes surrogate pairs (most emojis) using regex.
    Private Function RemoveEmojis(ByVal input As String) As String
        Dim emojiRegex As New Regex("([\uD800-\uDBFF][\uDC00-\uDFFF])")
        Return emojiRegex.Replace(input, "")
    End Function

    ' Save button: validate input and save the new password.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newPwd As String = RemoveEmojis(txtNewPassword.Text.Trim())
        Dim confirmPwd As String = RemoveEmojis(txtConfirmPassword.Text.Trim())

        If String.IsNullOrEmpty(newPwd) Then
            MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPwd.Length < 8 OrElse Not newPwd.Any(Function(c) Char.IsUpper(c)) OrElse
           Not newPwd.Any(Function(c) Char.IsLower(c)) OrElse Not newPwd.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Password must be 8+ characters with uppercase, lowercase, and a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPwd <> confirmPwd Then
            MessageBox.Show("The passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        NewPasswordText = newPwd
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
