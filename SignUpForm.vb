Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class SignUpForm
    ' When true, closing the SignUpForm reopens LoginForm.
    ' Set this to False when SignUpForm is launched from AdminStaffDashboardForm.
    Public Property OpenLoginOnCancel As Boolean = True

    ' Hash the password using SHA256.
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

    ' Button Click event for SignUp.
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim conn As MySqlConnection = Common.getDBConnection()

        ' Validate Password Strength.
        If txtPassword.Text.Length < 8 OrElse
           Not txtPassword.Text.Any(AddressOf Char.IsUpper) OrElse
           Not txtPassword.Text.Any(AddressOf Char.IsLower) OrElse
           Not txtPassword.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, and a number.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm Password.
        If txtPassword.Text.Trim() <> txtConfirmPass.Text.Trim() Then
            MessageBox.Show("Passwords do not match!", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Email Format Validation.
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Contact Number Validation.
        If Not IsNumeric(txtContact.Text) OrElse txtContact.Text.Length <> 11 Then
            MessageBox.Show("Please enter a valid 11-digit contact number.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Avoid Duplicate Security Questions.
        If cmbSecQ1.SelectedItem = cmbSecQ2.SelectedItem OrElse cmbSecQ1.SelectedItem = cmbSecQ3.SelectedItem OrElse cmbSecQ2.SelectedItem = cmbSecQ3.SelectedItem Then
            MessageBox.Show("Please select three unique security questions.", "Duplicate Questions", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            ' Check if User Already Exists.
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE user_id = @user"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@user", txtUserID.Text)
            Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If userExists > 0 Then
                MessageBox.Show("User ID already exists!", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL Insert Query.
            Dim query As String = "INSERT INTO users (user_id, first_name, last_name, email, contact_number, password_hash, " &
                                  "security_question1, security_answer_hash1, " &
                                  "security_question2, security_answer_hash2, " &
                                  "security_question3, security_answer_hash3, role, created_at) " &
                                  "VALUES (@user, @first_name, @last_name, @email, @contact, @pass, @q1, @a1, @q2, @a2, @q3, @a3, 'student', NOW())"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters.
            cmd.Parameters.AddWithValue("@user", txtUserID.Text)
            cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@last_name", txtLastName.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@pass", HashPassword(txtPassword.Text))
            cmd.Parameters.AddWithValue("@q1", cmbSecQ1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a1", HashPassword(txtSecQ1.Text))
            cmd.Parameters.AddWithValue("@q2", cmbSecQ2.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a2", HashPassword(txtSecQ2.Text))
            cmd.Parameters.AddWithValue("@q3", cmbSecQ3.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a3", HashPassword(txtSecQ3.Text))

            ' Execute query.
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' After successful sign-up, if launched from LoginForm, show it.
            If OpenLoginOnCancel Then
                LoginForm.Show()
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Form Load event.
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim questions As String() = {
            "What is your favorite color?",
            "What is your pet's name?",
            "What is your mother's maiden name?",
            "What was the name of your first school?",
            "What is your favorite food?"
        }

        cmbSecQ1.Items.AddRange(questions)
        cmbSecQ2.Items.AddRange(questions)
        cmbSecQ3.Items.AddRange(questions)

        cmbSecQ1.SelectedIndex = -1
        cmbSecQ2.SelectedIndex = -1
        cmbSecQ3.SelectedIndex = -1

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPass.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' Cancel button behavior based on the form's launch context.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' If OpenLoginOnCancel is true, then show the LoginForm; otherwise, simply close.
        If OpenLoginOnCancel Then
            LoginForm.Show()
        End If
        Me.Close()
    End Sub

    ' Ensure that the LoginForm is shown when closing, if needed.
    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If OpenLoginOnCancel AndAlso Not LoginForm.Visible Then
            LoginForm.Show()
        End If
    End Sub

End Class
