Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class SignUpForm
    Public Property OpenLoginOnCancel As Boolean = True
    Public Property FromLogin As Boolean = True
    Public Property AccountCreated As Boolean = False

    ' Global list of security questions.
    Private allQuestions As List(Of String) = New List(Of String) From {
        "What is your favorite color?",
        "What is your pet's name?",
        "What is your mother's maiden name?",
        "What was the name of your first school?",
        "What is your favorite food?"
    }

    ' Hash the password using SHA256.
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Real-time validation for User ID (must be in format 2XXX-XXXXX).
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Dim userId As String = txtUserID.Text.Trim()
        If String.IsNullOrEmpty(userId) Then
            lblUserIDError.Text = "ID is required."
            lblUserIDError.Visible = True
        ElseIf Not Regex.IsMatch(userId, "^2\d{3}-\d{5}$") Then
            lblUserIDError.Text = "ID must be in format 2XXX-XXXXX."
            lblUserIDError.Visible = True
        Else
            lblUserIDError.Text = ""
            lblUserIDError.Visible = False
        End If
    End Sub

    ' Real-time validation for First Name.
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Dim firstName As String = txtFirstName.Text.Trim()
        If String.IsNullOrEmpty(firstName) Then
            lblFirstNameError.Text = "First Name is required."
            lblFirstNameError.Visible = True
        ElseIf Not Regex.IsMatch(firstName, "^[A-Za-z]+$") Then
            lblFirstNameError.Text = "Only letters allowed."
            lblFirstNameError.Visible = True
        Else
            lblFirstNameError.Text = ""
            lblFirstNameError.Visible = False
        End If
    End Sub

    ' Real-time validation for Last Name.
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim lastName As String = txtLastName.Text.Trim()
        If String.IsNullOrEmpty(lastName) Then
            lblLastNameError.Text = "Last Name is required."
            lblLastNameError.Visible = True
        ElseIf Not Regex.IsMatch(lastName, "^[A-Za-z]+$") Then
            lblLastNameError.Text = "Only letters allowed."
            lblLastNameError.Visible = True
        Else
            lblLastNameError.Text = ""
            lblLastNameError.Visible = False
        End If
    End Sub

    ' Real-time validation for Email.
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If String.IsNullOrEmpty(emailInput) Then
            lblEmailError.Text = "Email is required."
            lblEmailError.Visible = True
            Return
        End If

        ' If user typed a full email, check the domain.
        If emailInput.Contains("@") Then
            If Not emailInput.EndsWith(allowedDomain, StringComparison.OrdinalIgnoreCase) Then
                lblEmailError.Text = "Only " & allowedDomain & " emails are allowed."
                lblEmailError.Visible = True
                Return
            End If
        End If

        ' Basic check: must contain a period.
        If Not emailInput.Contains(".") Then
            lblEmailError.Text = "Enter a valid email address."
            lblEmailError.Visible = True
            Return
        End If

        lblEmailError.Text = ""
        lblEmailError.Visible = False
    End Sub

    ' Real-time validation for Password.
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password As String = txtPassword.Text
        If password.Length < 8 OrElse Not password.Any(AddressOf Char.IsUpper) OrElse
           Not password.Any(AddressOf Char.IsLower) OrElse Not password.Any(AddressOf Char.IsDigit) Then
            lblPasswordError.Text = "Password must be 8+ characters with uppercase, lowercase, and a number."
            lblPasswordError.Visible = True
        Else
            lblPasswordError.Text = ""
            lblPasswordError.Visible = False
        End If
    End Sub

    ' Real-time validation for Confirm Password.
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        Dim confirmPassword As String = txtConfirmPass.Text
        If confirmPassword <> txtPassword.Text Then
            lblConfirmPasswordError.Text = "Passwords do not match."
            lblConfirmPasswordError.Visible = True
        Else
            lblConfirmPasswordError.Text = ""
            lblConfirmPasswordError.Visible = False
        End If
    End Sub

    ' Real-time validation for Contact Number.
    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Dim contact As String = txtContact.Text.Trim()
        If Not IsNumeric(contact) OrElse contact.Length <> 11 Then
            lblContactError.Text = "Enter a valid 11-digit contact number."
            lblContactError.Visible = True
        Else
            lblContactError.Text = ""
            lblContactError.Visible = False
        End If
    End Sub

    ' Basic validation for Security Questions.
    Private Sub ValidateSecurityQuestions()
        If cmbSecQ1.SelectedItem Is Nothing OrElse cmbSecQ2.SelectedItem Is Nothing OrElse cmbSecQ3.SelectedItem Is Nothing Then
            lblSecurityQuestionError.Text = "Select all three security questions."
            lblSecurityQuestionError.Visible = True
        ElseIf cmbSecQ1.SelectedItem = cmbSecQ2.SelectedItem OrElse
               cmbSecQ1.SelectedItem = cmbSecQ3.SelectedItem OrElse
               cmbSecQ2.SelectedItem = cmbSecQ3.SelectedItem Then
            lblSecurityQuestionError.Text = "Select unique security questions."
            lblSecurityQuestionError.Visible = True
        Else
            lblSecurityQuestionError.Text = ""
            lblSecurityQuestionError.Visible = False
        End If
    End Sub

    ' When the selection changes, validate the security questions.
    Private Sub cmbSecQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ1.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    Private Sub cmbSecQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ2.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    Private Sub cmbSecQ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ3.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    ' DropDown event handlers for dynamic filtering of security questions.
    Private Sub cmbSecQ1_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ1.DropDown
        UpdateComboBoxOptions(cmbSecQ1, New List(Of ComboBox) From {cmbSecQ2, cmbSecQ3})
    End Sub

    Private Sub cmbSecQ2_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ2.DropDown
        UpdateComboBoxOptions(cmbSecQ2, New List(Of ComboBox) From {cmbSecQ1, cmbSecQ3})
    End Sub

    Private Sub cmbSecQ3_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ3.DropDown
        UpdateComboBoxOptions(cmbSecQ3, New List(Of ComboBox) From {cmbSecQ1, cmbSecQ2})
    End Sub

    ' Helper method to update a combo box's items by excluding selected questions from other combo boxes.
    Private Sub UpdateComboBoxOptions(targetComboBox As ComboBox, excludeFrom As List(Of ComboBox))
        Dim selectedQuestions As New List(Of String)
        For Each cb As ComboBox In excludeFrom
            If cb.SelectedItem IsNot Nothing Then
                selectedQuestions.Add(cb.SelectedItem.ToString())
            End If
        Next

        Dim availableQuestions = allQuestions.Where(Function(q) Not selectedQuestions.Contains(q)).ToList()

        ' Preserve current selection if it still exists.
        Dim currentSelection As Object = targetComboBox.SelectedItem
        targetComboBox.Items.Clear()
        targetComboBox.Items.AddRange(availableQuestions.ToArray())

        If currentSelection IsNot Nothing AndAlso availableQuestions.Contains(currentSelection.ToString()) Then
            targetComboBox.SelectedItem = currentSelection
        End If
    End Sub

    ' Sign Up button click event (final validation and database insertion).
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        ' Final check: if any error labels are visible, prompt user to fix issues.
        If lblUserIDError.Visible OrElse lblFirstNameError.Visible OrElse lblLastNameError.Visible OrElse
           lblEmailError.Visible OrElse lblPasswordError.Visible OrElse lblConfirmPasswordError.Visible OrElse
           lblContactError.Visible OrElse lblSecurityQuestionError.Visible Then
            MessageBox.Show("Please fix the errors before signing up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Normalize Email: Append allowed domain if user typed just the username.
        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If Not emailInput.Contains("@") Then
            emailInput &= allowedDomain
            txtEmail.Text = emailInput
        End If

        ' Proceed with database insertion.
        Dim conn As MySqlConnection = Common.getDBConnection()
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

            cmd.Parameters.AddWithValue("@user", txtUserID.Text)
            cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@email", emailInput)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
            cmd.Parameters.AddWithValue("@pass", HashPassword(txtPassword.Text))
            cmd.Parameters.AddWithValue("@q1", cmbSecQ1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a1", HashPassword(txtSecQ1.Text))
            cmd.Parameters.AddWithValue("@q2", cmbSecQ2.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a2", HashPassword(txtSecQ2.Text))
            cmd.Parameters.AddWithValue("@q3", cmbSecQ3.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@a3", HashPassword(txtSecQ3.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AccountCreated = True

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

    ' Form Load event to initialize security questions and password masking.
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate security questions using the global list.
        cmbSecQ1.Items.AddRange(allQuestions.ToArray())
        cmbSecQ2.Items.AddRange(allQuestions.ToArray())
        cmbSecQ3.Items.AddRange(allQuestions.ToArray())

        cmbSecQ1.SelectedIndex = -1
        cmbSecQ2.SelectedIndex = -1
        cmbSecQ3.SelectedIndex = -1

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    ' Toggle password visibility.
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPass.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' Cancel button behavior.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Ensure that the LoginForm is shown when closing, if needed.
    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FromLogin AndAlso Not AccountCreated AndAlso Not LoginForm.Visible Then
            LoginForm.Show()
        End If
    End Sub

End Class
