Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class SignUpForm
    ' Properties to control form behavior.
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

    '----------------------------------
    ' HashPassword: Hashes a string using SHA256.
    '----------------------------------
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

    '----------------------------------
    ' CheckNextButton: Enables btnNext if no error labels (for UserID, First Name, Last Name, Email, Contact, Password) are visible.
    '----------------------------------
    Private Sub CheckNextButton()
        btnNext.Enabled = Not (lblUserIDError.Visible OrElse lblFirstNameError.Visible OrElse
                                lblLastNameError.Visible OrElse lblEmailError.Visible OrElse
                                lblContactError.Visible OrElse lblPasswordError.Visible)
    End Sub

    '----------------------------------
    ' txtUserID_TextChanged: Validates that the User ID is in the format 2XXX-XXXXX.
    '----------------------------------
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Dim userId As String = txtUserID.Text.Trim()
        If String.IsNullOrEmpty(userId) Then
            lblUserIDError.Text = "ID is required."
            lblUserIDError.Visible = True
        ElseIf Not Regex.IsMatch(userId, "^2\d{3}-\d{5}$") Then
            lblUserIDError.Text = "ID must be in format 2XXX-XXXXX. *"
            lblUserIDError.Visible = True
        Else
            lblUserIDError.Text = ""
            lblUserIDError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtFirstName_TextChanged: Validates that the First Name is not empty and contains only letters.
    '----------------------------------
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Dim firstName As String = txtFirstName.Text.Trim()
        If String.IsNullOrEmpty(firstName) Then
            lblFirstNameError.Text = "First Name is required. *"
            lblFirstNameError.Visible = True
        ElseIf Not Regex.IsMatch(firstName, "^[A-Za-z]+$") Then
            lblFirstNameError.Text = "Only letters allowed. *"
            lblFirstNameError.Visible = True
        Else
            lblFirstNameError.Text = ""
            lblFirstNameError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtLastName_TextChanged: Validates that the Last Name is not empty and contains only letters.
    '----------------------------------
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim lastName As String = txtLastName.Text.Trim()
        If String.IsNullOrEmpty(lastName) Then
            lblLastNameError.Text = "Last Name is required. *"
            lblLastNameError.Visible = True
        ElseIf Not Regex.IsMatch(lastName, "^[A-Za-z]+$") Then
            lblLastNameError.Text = "Only letters allowed. *"
            lblLastNameError.Visible = True
        Else
            lblLastNameError.Text = ""
            lblLastNameError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtEmail_TextChanged: Validates the email input.
    ' If only a username is provided, it’s allowed (will auto-complete on Leave event).
    ' If an "@" is present, checks that the domain is correct.
    '----------------------------------
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"

        If String.IsNullOrEmpty(emailInput) Then
            lblEmailError.Text = "Email is required. *"
            lblEmailError.Visible = True
            CheckNextButton()
            Return
        End If

        If emailInput.Contains("@") Then
            If Not emailInput.EndsWith(allowedDomain, StringComparison.OrdinalIgnoreCase) Then
                lblEmailError.Text = "Only " & allowedDomain & " emails are allowed. *"
                lblEmailError.Visible = True
                CheckNextButton()
                Return
            Else
                lblEmailError.Text = ""
                lblEmailError.Visible = False
            End If
        Else
            ' When only username is typed, no error (domain will be appended later).
            lblEmailError.Text = ""
            lblEmailError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtPassword_TextChanged: Validates the password strength.
    ' Must be at least 8 characters with uppercase, lowercase, and a number.
    '----------------------------------
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password As String = txtPassword.Text
        If password.Length < 8 OrElse Not password.Any(AddressOf Char.IsUpper) OrElse
           Not password.Any(AddressOf Char.IsLower) OrElse Not password.Any(AddressOf Char.IsDigit) Then
            lblPasswordError.Text = "Password must be 8+ characters with uppercase, lowercase, and a number. *"
            lblPasswordError.Visible = True
        Else
            lblPasswordError.Text = ""
            lblPasswordError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtConfirmPass_TextChanged: Checks that the Confirm Password matches the Password.
    '----------------------------------
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        Dim confirmPassword As String = txtConfirmPass.Text
        If confirmPassword <> txtPassword.Text Then
            lblConfirmPasswordError.Text = "Passwords does not match. *"
            lblConfirmPasswordError.Visible = True
        Else
            lblConfirmPasswordError.Text = ""
            lblConfirmPasswordError.Visible = False
        End If
    End Sub

    '----------------------------------
    ' txtContact_TextChanged: Validates the contact number to be exactly 11 digits.
    '----------------------------------
    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Dim contact As String = txtContact.Text.Trim()
        If Not IsNumeric(contact) OrElse contact.Length <> 11 Then
            lblContactError.Text = "Enter a valid 11-digit contact number. *"
            lblContactError.Visible = True
        Else
            lblContactError.Text = ""
            lblContactError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtConfirmSecQ1_TextChanged: Validates that Security Answer 1 confirmation matches the original answer.
    '----------------------------------
    Private Sub txtConfirmSecQ1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ1.TextChanged
        If txtConfirmSecQ1.Text <> txtSecQ1.Text Then
            lblConfirmSecQ1Error.Text = "Security answer 1 does not match. *"
            lblConfirmSecQ1Error.Visible = True
        Else
            lblConfirmSecQ1Error.Text = ""
            lblConfirmSecQ1Error.Visible = False
        End If
    End Sub

    '----------------------------------
    ' txtConfirmSecQ2_TextChanged: Validates that Security Answer 2 confirmation matches the original answer.
    '----------------------------------
    Private Sub txtConfirmSecQ2_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ2.TextChanged
        If txtConfirmSecQ2.Text <> txtSecQ2.Text Then
            lblConfirmSecQ2Error.Text = "Security answer 2 does not match. *"
            lblConfirmSecQ2Error.Visible = True
        Else
            lblConfirmSecQ2Error.Text = ""
            lblConfirmSecQ2Error.Visible = False
        End If
    End Sub

    '----------------------------------
    ' txtConfirmSecQ3_TextChanged: Validates that Security Answer 3 confirmation matches the original answer.
    '----------------------------------
    Private Sub txtConfirmSecQ3_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ3.TextChanged
        If txtConfirmSecQ3.Text <> txtSecQ3.Text Then
            lblConfirmSecQ3Error.Text = "Security answer 3 does not match. *"
            lblConfirmSecQ3Error.Visible = True
        Else
            lblConfirmSecQ3Error.Text = ""
            lblConfirmSecQ3Error.Visible = False
        End If
    End Sub

    '----------------------------------
    ' ValidateSecurityQuestions: Ensures that all three security questions are selected and are unique.
    '----------------------------------
    Private Sub ValidateSecurityQuestions()
        If cmbSecQ1.SelectedItem Is Nothing OrElse cmbSecQ2.SelectedItem Is Nothing OrElse cmbSecQ3.SelectedItem Is Nothing Then
            lblSecurityQuestionError.Text = "Select all three security questions. *"
            lblSecurityQuestionError.Visible = True
        ElseIf cmbSecQ1.SelectedItem = cmbSecQ2.SelectedItem OrElse
               cmbSecQ1.SelectedItem = cmbSecQ3.SelectedItem OrElse
               cmbSecQ2.SelectedItem = cmbSecQ3.SelectedItem Then
            lblSecurityQuestionError.Text = "Select unique security questions. *"
            lblSecurityQuestionError.Visible = True
        Else
            lblSecurityQuestionError.Text = ""
            lblSecurityQuestionError.Visible = False
        End If
    End Sub

    '----------------------------------
    ' ComboBox SelectedIndexChanged events: Call ValidateSecurityQuestions when selection changes.
    '----------------------------------
    Private Sub cmbSecQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ1.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    Private Sub cmbSecQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ2.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    Private Sub cmbSecQ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ3.SelectedIndexChanged
        ValidateSecurityQuestions()
    End Sub

    '----------------------------------
    ' DropDown events: Dynamically update the options for each security question combo box,
    ' excluding those already selected in the other combo boxes.
    '----------------------------------
    Private Sub cmbSecQ1_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ1.DropDown
        UpdateComboBoxOptions(cmbSecQ1, New List(Of ComboBox) From {cmbSecQ2, cmbSecQ3})
    End Sub

    Private Sub cmbSecQ2_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ2.DropDown
        UpdateComboBoxOptions(cmbSecQ2, New List(Of ComboBox) From {cmbSecQ1, cmbSecQ3})
    End Sub

    Private Sub cmbSecQ3_DropDown(sender As Object, e As EventArgs) Handles cmbSecQ3.DropDown
        UpdateComboBoxOptions(cmbSecQ3, New List(Of ComboBox) From {cmbSecQ1, cmbSecQ2})
    End Sub

    '----------------------------------
    ' UpdateComboBoxOptions: Helper method to refresh a combo box's items by filtering out
    ' any questions already selected in the provided list of combo boxes.
    '----------------------------------
    Private Sub UpdateComboBoxOptions(targetComboBox As ComboBox, excludeFrom As List(Of ComboBox))
        Dim selectedQuestions As New List(Of String)
        ' Collect selected items from other combo boxes.
        For Each cb As ComboBox In excludeFrom
            If cb.SelectedItem IsNot Nothing Then
                selectedQuestions.Add(cb.SelectedItem.ToString())
            End If
        Next

        ' Get the list of available questions by excluding the selected ones.
        Dim availableQuestions = allQuestions.Where(Function(q) Not selectedQuestions.Contains(q)).ToList()

        ' Preserve current selection if it still exists.
        Dim currentSelection As Object = targetComboBox.SelectedItem
        targetComboBox.Items.Clear()
        targetComboBox.Items.AddRange(availableQuestions.ToArray())

        If currentSelection IsNot Nothing AndAlso availableQuestions.Contains(currentSelection.ToString()) Then
            targetComboBox.SelectedItem = currentSelection
        End If
    End Sub

    '----------------------------------
    ' btnSignUp_Click: Final validation and database insertion when the Sign Up button is clicked.
    ' Checks that no error labels are visible and normalizes the email before inserting data.
    '----------------------------------
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        ' Final check: if any error labels are visible, stop and prompt user.
        If lblUserIDError.Visible OrElse lblFirstNameError.Visible OrElse lblLastNameError.Visible OrElse
           lblEmailError.Visible OrElse lblPasswordError.Visible OrElse lblConfirmPasswordError.Visible OrElse
           lblContactError.Visible OrElse lblSecurityQuestionError.Visible OrElse
           lblConfirmSecQ1Error.Visible OrElse lblConfirmSecQ2Error.Visible OrElse lblConfirmSecQ3Error.Visible Then
            MessageBox.Show("Please fix the errors before signing up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Normalize Email: If the user typed just the username, append the allowed domain.
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

            ' Check if the User ID already exists in the database.
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE user_id = @user"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@user", txtUserID.Text)
            Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If userExists > 0 Then
                MessageBox.Show("User ID already exists!", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL Insert Query to add the new user.
            Dim query As String = "INSERT INTO users (user_id, first_name, last_name, email, contact_number, password_hash, " &
                                  "security_question1, security_answer_hash1, " &
                                  "security_question2, security_answer_hash2, " &
                                  "security_question3, security_answer_hash3, role, created_at) " &
                                  "VALUES (@user, @first_name, @last_name, @email, @contact, @pass, @q1, @a1, @q2, @a2, @q3, @a3, 'student', NOW())"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters for the insert query.
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

            ' Execute the query.
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AccountCreated = True

            ' Show LoginForm if needed and close the current form.
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

    '----------------------------------
    ' SignUpForm_Load: Initializes the form, populating security questions and setting password masking.
    '----------------------------------
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate security questions using the global list.
        cmbSecQ1.Items.AddRange(allQuestions.ToArray())
        cmbSecQ2.Items.AddRange(allQuestions.ToArray())
        cmbSecQ3.Items.AddRange(allQuestions.ToArray())

        ' Set combo boxes to no selection initially.
        cmbSecQ1.SelectedIndex = -1
        cmbSecQ2.SelectedIndex = -1
        cmbSecQ3.SelectedIndex = -1

        ' Enable password masking.
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    '----------------------------------
    ' chkShowPassword_CheckedChanged: Toggles the visibility of the password fields.
    '----------------------------------
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPass.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    '----------------------------------
    ' btnCancel_Click: Closes the form when the Cancel button is pressed.
    '----------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '----------------------------------
    ' SignUpForm_FormClosing: Ensures the LoginForm is shown if the account wasn't created.
    '----------------------------------
    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FromLogin AndAlso Not AccountCreated AndAlso Not LoginForm.Visible Then
            LoginForm.Show()
        End If
    End Sub

    '----------------------------------
    ' txtEmail_Leave: Auto-completes the email field when the user leaves the textbox.
    ' If the user only typed the username, the allowed domain is appended.
    '----------------------------------
    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If Not String.IsNullOrEmpty(emailInput) AndAlso Not emailInput.Contains("@") Then
            txtEmail.Text = emailInput & allowedDomain
        End If
    End Sub

    '----------------------------------
    ' btnNext_Click: Hides pnlShadow1 and shows pnlShadow2 when Next is clicked.
    '----------------------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        pnlShadow1.Visible = False
        pnlShadow2.Visible = True
    End Sub

    '----------------------------------
    ' btnBack_Click: Shows pnlShadow1 and hides pnlShadow2 when Back is clicked.
    '----------------------------------
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlShadow1.Visible = True
        pnlShadow2.Visible = False
    End Sub

End Class
