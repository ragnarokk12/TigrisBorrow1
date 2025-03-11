Imports MySql.Data.MySqlClient

Public Class SignUpForm
    ' Button Click event for SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim conn As MySqlConnection = Common.getDBConnection()

        Try
            conn.Open()

            ' SQL Insert Query
            Dim query As String = "INSERT INTO users (user_id, full_name, email, contact_number, password_hash, " &
                                  "security_question1, security_answer_hash1, " &
                                  "security_question2, security_answer_hash2, " &
                                  "security_question3, security_answer_hash3, role, created_at) " &
                                  "VALUES (@user, @fullname, @email, @contact, @pass, @q1, @a1, @q2, @a2, @q3, @a3, 'student', NOW())"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@user", txtUserID.Text)
            cmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text) ' ⚠️ Consider hashing for security
            cmd.Parameters.AddWithValue("@q1", cmbSecQ1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a1", txtSecQ1.Text)
            cmd.Parameters.AddWithValue("@q2", cmbSecQ2.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a2", txtSecQ2.Text)
            cmd.Parameters.AddWithValue("@q3", cmbSecQ3.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a3", txtSecQ3.Text)

            ' Execute query
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            conn.Close()
        End Try
    End Sub

    ' Button Click event for Back to Login
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add security questions to ComboBoxes
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

        ' Optional: Set placeholder text if supported
        cmbSecQ1.SelectedIndex = -1
        cmbSecQ2.SelectedIndex = -1
        cmbSecQ3.SelectedIndex = -1
    End Sub

End Class