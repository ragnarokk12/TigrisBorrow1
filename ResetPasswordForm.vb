Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ResetPasswordForm
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim currentPassword As String = txtCurrentPassword.Text.Trim()
        Dim newPassword As String = txtNewPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' Validate that all fields are filled.
        If String.IsNullOrEmpty(currentPassword) OrElse String.IsNullOrEmpty(newPassword) OrElse String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate new password confirmation.
        If newPassword <> confirmPassword Then
            MessageBox.Show("New passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = Common.getDBConnection()
                conn.Open()

                ' Retrieve the stored password hash for the current user.
                Dim storedHash As String = ""
                Dim query As String = "SELECT password_hash FROM users WHERE user_id = @userId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        storedHash = result.ToString()
                    Else
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Compare the hash of the entered current password with the stored hash.
                Dim currentPasswordHash As String = HashPassword(currentPassword)
                If Not storedHash.Equals(currentPasswordHash) Then
                    MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Update the password hash with the new password.
                Dim newPasswordHash As String = HashPassword(newPassword)
                Dim updateQuery As String = "UPDATE users SET password_hash = @pass WHERE user_id = @userId"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@pass", newPasswordHash)
                    cmd.Parameters.AddWithValue("@userId", Common.CurrentUserId)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message)
        End Try
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
