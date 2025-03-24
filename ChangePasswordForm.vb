Imports Guna.UI2.WinForms

Public Class ChangePasswordForm
    Inherits BaseForm

    ' This property will hold the new password entered by the user.
    Public Property NewPasswordText As String = ""

    Private Const NewPasswordPlaceholder As String = "Enter new password"
    Private Const ConfirmPasswordPlaceholder As String = "Confirm new password"

    ' Flags to indicate if the placeholder is currently active.
    Private _isNewPasswordPlaceholderActive As Boolean = True
    Private _isConfirmPasswordPlaceholderActive As Boolean = True

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(txtNewPassword, NewPasswordPlaceholder)
        _isNewPasswordPlaceholderActive = True
        SetPlaceholder(txtConfirmPassword, ConfirmPasswordPlaceholder)
        _isConfirmPasswordPlaceholderActive = True
    End Sub

    Private Sub SetPlaceholder(tb As Guna2TextBox, placeholder As String)
        tb.Text = placeholder
        tb.ForeColor = Color.Gray
        ' Turn off password masking so that the placeholder text is visible.
        tb.UseSystemPasswordChar = False
    End Sub

    Private Sub RemovePlaceholder(tb As Guna2TextBox)
        tb.Text = ""
        tb.ForeColor = Color.Black
    End Sub

    Private Sub txtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles txtNewPassword.GotFocus
        If _isNewPasswordPlaceholderActive Then
            RemovePlaceholder(txtNewPassword)
            _isNewPasswordPlaceholderActive = False
        End If
    End Sub

    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        If _isConfirmPasswordPlaceholderActive Then
            RemovePlaceholder(txtConfirmPassword)
            _isConfirmPasswordPlaceholderActive = False
        End If
    End Sub

    Private Sub txtNewPassword_LostFocus(sender As Object, e As EventArgs) Handles txtNewPassword.LostFocus
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            SetPlaceholder(txtNewPassword, NewPasswordPlaceholder)
            _isNewPasswordPlaceholderActive = True
        End If
    End Sub

    Private Sub txtConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.LostFocus
        If String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            SetPlaceholder(txtConfirmPassword, ConfirmPasswordPlaceholder)
            _isConfirmPasswordPlaceholderActive = True
        End If
    End Sub

    ' Remove masking code completely.
    ' Therefore, the chkShowPassword control will have no effect.
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Optionally, you can remove this event handler entirely if you no longer need the checkbox.
    End Sub

    ' Real-time validation events.
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        ' Only update criteria if user input is active.
        If _isNewPasswordPlaceholderActive Then Return
        UpdatePasswordCriteriaLabels()
        UpdatePasswordMatchLabel()
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If _isConfirmPasswordPlaceholderActive Then Return
        UpdatePasswordMatchLabel()
    End Sub

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

    Private Sub UpdatePasswordMatchLabel()
        Dim pwd As String = txtNewPassword.Text
        Dim confirmPwd As String = txtConfirmPassword.Text

        ' If either textbox is still showing the placeholder, clear the label.
        If _isNewPasswordPlaceholderActive OrElse _isConfirmPasswordPlaceholderActive Then
            lblPasswordMatch.Text = ""
            Return
        End If

        If pwd = confirmPwd Then
            lblPasswordMatch.Text = "Passwords match"
            lblPasswordMatch.ForeColor = Color.Green
        Else
            lblPasswordMatch.Text = "Passwords do not match"
            lblPasswordMatch.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Only proceed if the placeholders are not active.
        Dim newPwd As String = txtNewPassword.Text.Trim()
        Dim confirmPwd As String = txtConfirmPassword.Text.Trim()

        If _isNewPasswordPlaceholderActive OrElse String.IsNullOrEmpty(newPwd) Then
            MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPwd.Length < 8 OrElse Not newPwd.Any(Function(c) Char.IsUpper(c)) OrElse
           Not newPwd.Any(Function(c) Char.IsLower(c)) OrElse Not newPwd.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Password must be 8+ characters with uppercase, lowercase, and a number.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
