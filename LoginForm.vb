Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class LoginForm
    ' Handles Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate input fields before attempting login
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            ValidateInputFields()
            MessageBox.Show("Please enter both User ID and Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As MySqlConnection = Common.getDBConnection()

        Try
            conn.Open()
            Dim hashedPassword As String = HashPassword(txtPassword.Text)
            Dim query As String = "SELECT role FROM users WHERE user_id=@user AND password_hash=@pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", txtUserID.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", hashedPassword)
                Dim roleObj As Object = cmd.ExecuteScalar()

                If roleObj IsNot Nothing Then
                    Dim roleStr As String = roleObj.ToString()
                    Common.CurrentUserId = txtUserID.Text.Trim()
                    Common.CurrentUserRole = roleStr.ToLower()
                    MessageBox.Show("Login Successful! Welcome, " & roleStr, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If roleStr.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse roleStr.Equals("staff", StringComparison.OrdinalIgnoreCase) Then
                        AddHandler AdminStaffDashboardForm.FormClosed, AddressOf DashboardFormClosed
                        AdminStaffDashboardForm.Show()
                    Else
                        AddHandler UserDashboardForm.FormClosed, AddressOf DashboardFormClosed
                        UserDashboardForm.Show()
                    End If

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    ' Place this event handler in your LoginForm code.
    Private Sub txtUserID_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        ' Remove any dashes and trim spaces.
        Dim input As String = txtUserID.Text.Replace("-", "").Trim()

        ' Proceed only if there's input.
        If input.Length > 0 Then
            Dim prefix As String = ""
            Dim suffix As String = ""

            ' Ensure we have at least 4 digits for the prefix.
            If input.Length >= 4 Then
                prefix = input.Substring(0, 4)
            Else
                ' If less than 4, pad to 4 digits.
                prefix = input.PadRight(4, "0"c)
            End If

            ' Get the remaining characters for the suffix.
            If input.Length > 4 Then
                suffix = input.Substring(4)
            End If

            ' Ensure the suffix is exactly 5 digits.
            If suffix.Length < 5 Then
                suffix = suffix.PadRight(5, "0"c)
            ElseIf suffix.Length > 5 Then
                suffix = suffix.Substring(0, 5)
            End If

            ' Combine prefix and suffix with a dash.
            txtUserID.Text = prefix & "-" & suffix
        End If
    End Sub

    Private Sub DashboardFormClosed(sender As Object, e As FormClosedEventArgs)
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty
        Me.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim signUpForm As New SignUpForm()
        signUpForm.FromLogin = True
        signUpForm.ShowDialog()
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        Dim forgotForm As New ForgotPasswordForm()
        forgotForm.Show()
    End Sub


    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Updated checkbox event for Guna2CustomCheckBox
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ChrW(0)
        Else
            txtPassword.PasswordChar = ChrW(9679)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default MaxLength values for textboxes
        txtUserID.MaxLength = 10     ' Format: "####-#####"
        txtPassword.MaxLength = 50   ' Adjust as needed

        txtPassword.UseSystemPasswordChar = False
        txtPassword.PasswordChar = ChrW(9679)
        lblInstruction.Visible = False
        txtUserID.Focus()
    End Sub

    ' This function validates the input fields and updates lblInstruction accordingly.
    Private Sub ValidateInputFields()
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblInstruction.Text = "Please fill in all fields!"
            lblInstruction.Visible = True
        Else
            lblInstruction.Visible = False
        End If
    End Sub

    ' Call ValidateInputFields when user types in either field.
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        ValidateInputFields()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ValidateInputFields()
    End Sub

    Private Sub txtUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            txtUserID.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        ' Additional logic can be added here if needed.
    End Sub

End Class
