Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Button Click event for Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As MySqlConnection = Common.getDBConnection() ' Get connection from Common.vb

        Try
            conn.Open()

            ' Hash the input password before checking it against the database
            Dim hashedPassword As String = HashPassword(txtPassword.Text)

            ' SQL query to check user credentials
            Dim query As String = "SELECT role FROM users WHERE user_id=@user AND password_hash=@pass"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", txtUserID.Text)
            cmd.Parameters.AddWithValue("@pass", hashedPassword) ' ✅ Compare hashed password

            Dim role As Object = cmd.ExecuteScalar() ' Get user role from DB

            If role IsNot Nothing Then
                MessageBox.Show("Login Successful! Welcome, " & role.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Redirect based on role
                If role.ToString() = "Admin" Then
                    AdminStaffDashboardForm.Show()
                Else
                    UserDashboardForm.Show()
                End If

                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Close connection after use
        End Try
    End Sub

    ' Button Click event for SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub

    ' Label Click event for Forgot Password
    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        ForgotPasswordForm.Show()
    End Sub

    ' Hash the Passwords using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create() ' ✅ Correct instantiation
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Checkbox event to toggle password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword2.Checked ' ✅ Simplified toggle logic
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
