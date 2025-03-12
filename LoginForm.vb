Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Button Click event for Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As MySqlConnection = Common.getDBConnection() ' Get connection from Common.vb

        Try
            conn.Open()

            ' SQL query to check user credentials
            Dim query As String = "SELECT role FROM users WHERE user_id=@user AND password_hash=@pass"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", txtUserID.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text) ' ⚠️ Consider hashing for security

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

    ' Checkbox event to toggle password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
