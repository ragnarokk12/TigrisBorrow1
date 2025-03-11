Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm
    Private userEmail As String ' Store the user’s email

    ' Step 1: Check if email exists
    Private Sub btnCheckEmail_Click(sender As Object, e As EventArgs) Handles btnCheckEmail.Click
        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            conn.Open()
            Dim query As String = "SELECT security_q1, security_q2, security_q3 FROM users WHERE email=@Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Store email and load security questions
                userEmail = txtEmail.Text
                lblQuestion1.Text = reader("security_q1").ToString()
                lblQuestion2.Text = reader("security_q2").ToString()
                lblQuestion3.Text = reader("security_q3").ToString()

                ' Show the security questions
                grpSecurityQuestions.Visible = True
                btnVerifyAnswers.Enabled = True
            Else
                MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Step 2: Verify security answers
    Private Sub btnVerifyAnswers_Click(sender As Object, e As EventArgs) Handles btnVerifyAnswers.Click
        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            conn.Open()
            Dim query As String = "SELECT answer1, answer2, answer3 FROM users WHERE email=@Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", userEmail)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Check answers
                If txtAnswer1.Text = reader("answer1").ToString() AndAlso
                   txtAnswer2.Text = reader("answer2").ToString() AndAlso
                   txtAnswer3.Text = reader("answer3").ToString() Then

                    ' Correct answers → Show Reset Password section
                    grpResetPassword.Visible = True
                    btnResetPassword.Enabled = True
                Else
                    MessageBox.Show("Incorrect answers! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Step 3: Reset Password
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = HashPassword(txtNewPassword.Text)
        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            conn.Open()
            Dim query As String = "UPDATE users SET password_hash=@Password WHERE email=@Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)
            cmd.Parameters.AddWithValue("@Email", userEmail)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error updating password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Hash the Passwords using SHA256
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

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer3.TextChanged

    End Sub
End Class
