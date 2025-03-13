Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ForgotPasswordForm
    Private connectionString As String = "Server=your_actual_server;Database=your_actual_database;User Id=your_actual_user;Password=your_actual_password;"
    Private selectedQuestions As New HashSet(Of String)

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = "@lpulaguna.edu.ph"

        ' Add security questions to ComboBoxes
        Dim questions As String() = {
            "What is your favorite color?",
            "What is your pet's name?",
            "What is your mother's maiden name?",
            "What was the name of your first school?",
            "What is your favorite food?"
        }

        cboQuestion1.Items.AddRange(questions)
        cboQuestion2.Items.AddRange(questions)
        cboQuestion3.Items.AddRange(questions)
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "@lpulaguna.edu.ph" Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not txtEmail.Text.Contains("@lpulaguna.edu.ph") Then
            txtEmail.Text = txtEmail.Text.Trim() & "@lpulaguna.edu.ph"
        End If
    End Sub

    Private Sub btnConfirmEmail_Click(sender As Object, e As EventArgs) Handles btnConfirmEmail.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT security_question1, security_question2, security_question3 FROM Users WHERE email = @Email", conn)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                cboQuestion1.SelectedItem = reader("security_question1").ToString()
                cboQuestion2.SelectedItem = reader("security_question2").ToString()
                cboQuestion3.SelectedItem = reader("security_question3").ToString()
                PanelEmail.Visible = False
                PanelSecurityQuestions.Visible = True
            Else
                MessageBox.Show("Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            reader.Close()
        End Using
    End Sub

    Private Sub btnConfirmQuestion_Click(sender As Object, e As EventArgs) Handles btnConfirmQuestion.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM Users WHERE email = @Email AND security_answer_hash1 = @A1 AND security_answer_hash2 = @A2 AND security_answer_hash3 = @A3", conn)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@A1", HashPassword(txtAnswer1.Text.Trim()))
            cmd.Parameters.AddWithValue("@A2", HashPassword(txtAnswer2.Text.Trim()))
            cmd.Parameters.AddWithValue("@A3", HashPassword(txtAnswer3.Text.Trim()))
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                PanelSecurityQuestions.Visible = False
                PanelNewPassword.Visible = True
            Else
                MessageBox.Show("Incorrect security answers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            reader.Close()
        End Using
    End Sub

    Private Sub btnConfirmPassword_Click(sender As Object, e As EventArgs) Handles btnConfirmPassword.Click
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(txtNewPassword.Text.Trim())

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE Users SET password_hash = @Password WHERE email = @Email", conn)
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
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBackPassword_Click(sender As Object, e As EventArgs) Handles btnBackPassword.Click
        PanelNewPassword.Visible = False
        PanelSecurityQuestions.Visible = True
    End Sub

End Class
