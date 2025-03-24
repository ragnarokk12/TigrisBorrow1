Imports Guna.UI2.WinForms

Public Class ChangePasswordForm
    Inherits Form

    ' This property will hold the new password entered by the user.
    Public Property NewPasswordText As String = ""

    Private Const NewPasswordPlaceholder As String = "Enter new password"
    Private Const ConfirmPasswordPlaceholder As String = "Confirm new password"

    ' Form Load event to initialize placeholders.
    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder text and initial color.
        SetPlaceholder(txtNewPassword, NewPasswordPlaceholder)
        SetPlaceholder(txtConfirmPassword, ConfirmPasswordPlaceholder)
    End Sub

    ' Helper to set placeholder on a Guna2TextBox.
    Private Sub SetPlaceholder(tb As Guna2TextBox, placeholder As String)
        tb.Text = placeholder
        tb.ForeColor = Color.Gray
    End Sub

    ' Remove placeholder when control gets focus.
    Private Sub txtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles txtNewPassword.GotFocus
        If txtNewPassword.Text = NewPasswordPlaceholder Then
            txtNewPassword.Text = ""
            txtNewPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        If txtConfirmPassword.Text = ConfirmPasswordPlaceholder Then
            txtConfirmPassword.Text = ""
            txtConfirmPassword.ForeColor = Color.Black
        End If
    End Sub

    ' Restore placeholder when control loses focus.
    Private Sub txtNewPassword_LostFocus(sender As Object, e As EventArgs) Handles txtNewPassword.LostFocus
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            SetPlaceholder(txtNewPassword, NewPasswordPlaceholder)
        End If
    End Sub

    Private Sub txtConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.LostFocus
        If String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            SetPlaceholder(txtConfirmPassword, ConfirmPasswordPlaceholder)
        End If
    End Sub

    ' btnSave and btnCancel event handlers.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newPwd As String = txtNewPassword.Text.Trim()
        Dim confirmPwd As String = txtConfirmPassword.Text.Trim()

        ' Ensure that placeholder text is not considered a valid password.
        If newPwd = NewPasswordPlaceholder OrElse String.IsNullOrEmpty(newPwd) Then
            MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate password strength.
        If newPwd.Length < 8 OrElse Not newPwd.Any(Function(c) Char.IsUpper(c)) OrElse
           Not newPwd.Any(Function(c) Char.IsLower(c)) OrElse Not newPwd.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Password must be 8+ characters with uppercase, lowercase, and a number.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure confirmation matches.
        If newPwd <> confirmPwd Then
            MessageBox.Show("The passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If validation passes, set the property and close the form.
        NewPasswordText = newPwd
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        ' Avoid updating criteria if placeholder is visible.
        If txtNewPassword.Text = NewPasswordPlaceholder Then Return

        UpdatePasswordCriteriaLabels()
        UpdatePasswordMatchLabel()
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        ' Avoid updating match label if placeholder is visible.
        If txtConfirmPassword.Text = ConfirmPasswordPlaceholder Then Return

        UpdatePasswordMatchLabel()
    End Sub

    Private Sub UpdatePasswordCriteriaLabels()
        Dim pwd As String = txtNewPassword.Text

        ' Check for 8+ characters.
        If pwd.Length >= 8 Then
            lblCriteriaLength.ForeColor = Color.Green
        Else
            lblCriteriaLength.ForeColor = Color.Red
        End If
        lblCriteriaLength.Text = "8+ characters"

        ' Check for at least one uppercase letter.
        If pwd.Any(Function(c) Char.IsUpper(c)) Then
            lblCriteriaUpper.ForeColor = Color.Green
        Else
            lblCriteriaUpper.ForeColor = Color.Red
        End If
        lblCriteriaUpper.Text = "At least 1 uppercase letter"

        ' Check for at least one lowercase letter.
        If pwd.Any(Function(c) Char.IsLower(c)) Then
            lblCriteriaLower.ForeColor = Color.Green
        Else
            lblCriteriaLower.ForeColor = Color.Red
        End If
        lblCriteriaLower.Text = "At least 1 lowercase letter"

        ' Check for at least one digit.
        If pwd.Any(Function(c) Char.IsDigit(c)) Then
            lblCriteriaDigit.ForeColor = Color.Green
        Else
            lblCriteriaDigit.ForeColor = Color.Red
        End If
        lblCriteriaDigit.Text = "At least 1 digit"
    End Sub

    Private Sub UpdatePasswordMatchLabel()
        Dim pwd As String = txtNewPassword.Text
        Dim confirmPwd As String = txtConfirmPassword.Text

        ' If placeholders are active, clear the match label.
        If pwd = NewPasswordPlaceholder OrElse confirmPwd = ConfirmPasswordPlaceholder Then
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
End Class
