Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Linq ' For LINQ methods like Any()

Public Class ForgotPasswordForm
    Private connectionString As String = "Server=192.168.1.51;Database=tigris;User ID=eksi;Password=;Port=3306;"

    ' Load event: Set default email placeholder, hide tab headers, and center the form
    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = "@lpulaguna.edu.ph"

        ' Hide the tab headers
        HideTabHeaders()
    End Sub

    '----------------------------------
    ' Hide Tab Headers
    '----------------------------------
    Private Sub HideTabHeaders()
        ' Set the ItemSize to 0 to hide the tabs
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
    End Sub

    '----------------------------------
    ' txtNewPassword_TextChanged: Validates password strength.
    '----------------------------------
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        Dim password As String = txtNewPassword.Text
        If password.Length < 8 OrElse Not password.Any(AddressOf Char.IsUpper) OrElse
           Not password.Any(AddressOf Char.IsLower) OrElse Not password.Any(AddressOf Char.IsDigit) Then
            lblNewPasswordError.Text = "Password must be 8+ characters with uppercase, lowercase, and a number."
            lblNewPasswordError.Visible = True
        Else
            lblNewPasswordError.Text = ""
            lblNewPasswordError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtConfirmPassword_TextChanged: Checks that password confirmation matches.
    '----------------------------------
    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If txtConfirmPassword.Text <> txtNewPassword.Text Then
            lblConfirmNewPasswordError.Text = "Passwords do not match."
            lblConfirmNewPasswordError.Visible = True
        Else
            lblConfirmNewPasswordError.Text = ""
            lblConfirmNewPasswordError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' CheckNextButton: Enables or disables the Confirm button based on input validity.
    '----------------------------------
    Private Sub CheckNextButton()
        If lblNewPasswordError.Visible = False AndAlso lblConfirmNewPasswordError.Visible = False AndAlso
           txtNewPassword.Text.Length >= 8 AndAlso txtConfirmPassword.Text = txtNewPassword.Text Then
            btnConfirmPassword.Enabled = True
        Else
            btnConfirmPassword.Enabled = False
        End If
    End Sub

    ' Clear email placeholder when the user enters the field
    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "@lpulaguna.edu.ph" Then
            txtEmail.Text = ""
        End If
    End Sub

    ' Append domain if missing when the user leaves the field
    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not txtEmail.Text.Contains("@lpulaguna.edu.ph") Then
            txtEmail.Text = txtEmail.Text.Trim() & "@lpulaguna.edu.ph"
        End If
    End Sub

    ' Validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    ' Confirm Email button click event
    Private Sub btnConfirmEmail_Click(sender As Object, e As EventArgs) Handles btnConfirmEmail.Click
        If Not IsValidEmail(txtEmail.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT security_question1, security_question2, security_question3 FROM users WHERE email = @Email", conn)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Fetch questions from the database
                    txtsecuq1.Text = reader("security_question1").ToString()
                    txtsecuq2.Text = reader("security_question2").ToString()
                    txtsecuq3.Text = reader("security_question3").ToString()

                    ' Navigate to Security Questions page
                    TabControl1.SelectedTab = TabPage2
                Else
                    MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Confirm Security Questions button click event
    Private Sub btnConfirmQuestion_Click(sender As Object, e As EventArgs) Handles btnConfirmQuestion.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT security_answer_hash1, security_answer_hash2, security_answer_hash3 FROM users WHERE email = @Email", conn)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim storedHash1 As String = reader("security_answer_hash1").ToString()
                    Dim storedHash2 As String = reader("security_answer_hash2").ToString()
                    Dim storedHash3 As String = reader("security_answer_hash3").ToString()
                    reader.Close()

                    ' Hash the user's answers
                    Dim userHash1 As String = HashPassword(txtAnswer1.Text.Trim())
                    Dim userHash2 As String = HashPassword(txtAnswer2.Text.Trim())
                    Dim userHash3 As String = HashPassword(txtAnswer3.Text.Trim())

                    ' Verify the hashed answers
                    If userHash1 = storedHash1 AndAlso
                       userHash2 = storedHash2 AndAlso
                       userHash3 = storedHash3 Then
                        ' Navigate to TabPage3 (Create New Password)
                        TabControl1.SelectedTab = TabPage3
                    Else
                        MessageBox.Show("Incorrect security answers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Confirm New Password button click event
    Private Sub btnConfirmPassword_Click(sender As Object, e As EventArgs) Handles btnConfirmPassword.Click
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = HashPassword(txtNewPassword.Text.Trim())

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE users SET password_hash = @Password WHERE email = @Email", conn)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Password successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Error updating password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to hash passwords using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' Function to verify if the input password matches the stored hash
    Private Function VerifyHashedPassword(storedHash As String, inputPassword As String) As Boolean
        Return storedHash = HashPassword(inputPassword)
    End Function

    ' Cancel button click event
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' Back button click event (from Security Questions to Email Verification)
    Private Sub btnBackQuestion_Click(sender As Object, e As EventArgs) Handles btnBackQuestion.Click
        ' Navigate back to TabPage1 (Email Verification)
        TabControl1.SelectedTab = TabPage1

        ' Reset the email field to allow the user to enter a new email
        txtEmail.Text = "@lpulaguna.edu.ph"

        ' Clear the security answer fields
        txtAnswer1.Clear()
        txtAnswer2.Clear()
        txtAnswer3.Clear()
    End Sub

    ' Back button click event (from New Password to Security Questions)
    Private Sub btnBackPassword_Click(sender As Object, e As EventArgs) Handles btnBackPassword.Click
        ' Navigate back to TabPage2 (Security Questions)
        TabControl1.SelectedTab = TabPage2

        ' Clear the new password fields
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

    ' Show Password checkbox event
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtNewPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' Prevent emojis and enforce maximum character limit
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress, txtConfirmPassword.KeyPress
        ' Allow only printable ASCII characters (32 to 126), special characters like "ñ", and Backspace
        If Not (e.KeyChar >= " " AndAlso e.KeyChar <= "~" OrElse e.KeyChar = "ñ" OrElse e.KeyChar = "Ñ" OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If

        ' Enforce maximum character limit (e.g., 20 characters)
        If txtNewPassword.Text.Length >= 20 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' Allow Enter key to trigger the Confirm button
    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirmPassword_Click(sender, e)
        End If
    End Sub
End Class