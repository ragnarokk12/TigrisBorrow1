' Fix error label in password nd emoji in security questions.
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
    ' RemoveEmojis: Removes surrogate pairs (most emoji) from a given string.
    '----------------------------------
    Private Function RemoveEmojis(ByVal input As String) As String
        Dim emojiRegex As New Regex("([\uD800-\uDBFF][\uDC00-\uDFFF])")
        Return emojiRegex.Replace(input, "")
    End Function

    '----------------------------------
    ' Panel 1 Validation Helpers (Basic Information)
    '----------------------------------
    Private Function IsPanel1Valid() As Boolean
        Dim fieldsFilled As Boolean = Not String.IsNullOrEmpty(txtUserID.Text.Trim()) AndAlso
            Not String.IsNullOrEmpty(txtFirstName.Text.Trim()) AndAlso
            Not String.IsNullOrEmpty(txtLastName.Text.Trim()) AndAlso
            Not String.IsNullOrEmpty(txtEmail.Text.Trim()) AndAlso
            Not String.IsNullOrEmpty(txtContact.Text.Trim()) AndAlso
            Not String.IsNullOrEmpty(txtPassword.Text) AndAlso
            Not String.IsNullOrEmpty(txtConfirmPass.Text)
        Dim noErrors As Boolean = Not (lblUserIDError.Visible OrElse lblFirstNameError.Visible OrElse
                                        lblLastNameError.Visible OrElse lblEmailError.Visible OrElse
                                        lblContactError.Visible OrElse lblPasswordError.Visible OrElse
                                        lblConfirmPasswordError.Visible)
        Dim passwordMatch As Boolean = (txtPassword.Text = txtConfirmPass.Text)
        Return fieldsFilled AndAlso noErrors AndAlso passwordMatch
    End Function

    Private Sub CheckNextButton()
        btnNext.Enabled = IsPanel1Valid()
    End Sub

    '----------------------------------
    ' Panel 2 Validation Helpers (Security Questions & Answers)
    '----------------------------------
    Private Function IsPanel2Valid() As Boolean
        Dim questionsSelected As Boolean = (cmbSecQ1.SelectedItem IsNot Nothing) AndAlso
                                           (cmbSecQ2.SelectedItem IsNot Nothing) AndAlso
                                           (cmbSecQ3.SelectedItem IsNot Nothing)
        Dim answersFilled As Boolean = Not String.IsNullOrEmpty(txtSecQ1.Text.Trim()) AndAlso
                                       Not String.IsNullOrEmpty(txtSecQ2.Text.Trim()) AndAlso
                                       Not String.IsNullOrEmpty(txtSecQ3.Text.Trim()) AndAlso
                                       Not String.IsNullOrEmpty(txtConfirmSecQ1.Text.Trim()) AndAlso
                                       Not String.IsNullOrEmpty(txtConfirmSecQ2.Text.Trim()) AndAlso
                                       Not String.IsNullOrEmpty(txtConfirmSecQ3.Text.Trim())
        Dim noErrors As Boolean = Not (lblSecurityQuestionError.Visible OrElse
                                       lblConfirmSecQ1Error.Visible OrElse lblConfirmSecQ2Error.Visible OrElse
                                       lblConfirmSecQ3Error.Visible)
        Return questionsSelected AndAlso answersFilled AndAlso noErrors
    End Function

    Private Sub CheckSignUpButton()
        btnSignup.Enabled = IsPanel2Valid()
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
    ' txtFirstName_TextChanged: Validates First Name and removes emojis.
    '----------------------------------
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Dim originalText As String = txtFirstName.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtFirstName.Text = filteredText
            txtFirstName.SelectionStart = filteredText.Length
        End If

        Dim firstName As String = txtFirstName.Text.Trim()
        If String.IsNullOrEmpty(firstName) Then
            lblFirstNameError.Text = "First Name is required. *"
            lblFirstNameError.Visible = True
        ElseIf Not Regex.IsMatch(firstName, "^[\p{L}]+([\s'-][\p{L}]+)*$") Then
            lblFirstNameError.Text = "Only letters allowed. *"
            lblFirstNameError.Visible = True
        Else
            lblFirstNameError.Text = ""
            lblFirstNameError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtLastName_TextChanged: Validates Last Name and removes emojis.
    '----------------------------------
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim originalText As String = txtLastName.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtLastName.Text = filteredText
            txtLastName.SelectionStart = filteredText.Length
        End If

        Dim lastName As String = txtLastName.Text.Trim()
        If String.IsNullOrEmpty(lastName) Then
            lblLastNameError.Text = "Last Name is required. *"
            lblLastNameError.Visible = True
        ElseIf Not Regex.IsMatch(lastName, "^[\p{L}]+([\s'-][\p{L}]+)*$") Then
            lblLastNameError.Text = "Only letters allowed. *"
            lblLastNameError.Visible = True
        Else
            lblLastNameError.Text = ""
            lblLastNameError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtEmail_TextChanged: Validates Email, removes emojis, and ensures allowed domain.
    '----------------------------------
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim originalText As String = txtEmail.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtEmail.Text = filteredText
            txtEmail.SelectionStart = filteredText.Length
        End If

        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If String.IsNullOrEmpty(emailInput) Then
            lblEmailError.Text = "Email is required. *"
            lblEmailError.Visible = True
        ElseIf emailInput.Contains("@") AndAlso Not emailInput.EndsWith(allowedDomain, StringComparison.OrdinalIgnoreCase) Then
            lblEmailError.Text = "Only " & allowedDomain & " emails are allowed. *"
            lblEmailError.Visible = True
        Else
            lblEmailError.Text = ""
            lblEmailError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtPassword_TextChanged: Validates password strength.
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
    ' txtConfirmPass_TextChanged: Checks that password confirmation matches.
    '----------------------------------
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Text <> txtPassword.Text Then
            lblConfirmPasswordError.Text = "Passwords do not match. *"
            lblConfirmPasswordError.Visible = True
        Else
            lblConfirmPasswordError.Text = ""
            lblConfirmPasswordError.Visible = False
        End If
        CheckNextButton()
    End Sub

    '----------------------------------
    ' txtContact_TextChanged: Validates that contact number is exactly 11 digits.
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
    ' Security Answer Validation (with emoji filtering and error messages)
    '----------------------------------
    Private Sub ValidateSecurityAnswer(confirmTextBox As Guna.UI2.WinForms.Guna2TextBox,
                                         originalTextBox As Guna.UI2.WinForms.Guna2TextBox,
                                         errorLabel As Guna.UI2.WinForms.Guna2HtmlLabel, answerNumber As Integer)
        Dim originalFiltered As String = RemoveEmojis(originalTextBox.Text)
        Dim confirmFiltered As String = RemoveEmojis(confirmTextBox.Text)
        If originalTextBox.Text <> originalFiltered OrElse confirmTextBox.Text <> confirmFiltered Then
            errorLabel.Text = "Please refrain from using emoji characters in security answer " & answerNumber.ToString() & "."
            errorLabel.Visible = True
            Exit Sub
        End If
        If confirmTextBox.Text <> originalTextBox.Text Then
            errorLabel.Text = "Security answer " & answerNumber.ToString() & " does not match. *"
            errorLabel.Visible = True
        Else
            errorLabel.Text = ""
            errorLabel.Visible = False
        End If
    End Sub

    ' Security Answer 1 Events
    Private Sub txtSecQ1_TextChanged(sender As Object, e As EventArgs) Handles txtSecQ1.TextChanged
        Dim originalText As String = txtSecQ1.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtSecQ1.Text = filteredText
            txtSecQ1.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ1, txtSecQ1, lblConfirmSecQ1Error, 1)
        CheckSignUpButton()
    End Sub

    Private Sub txtConfirmSecQ1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ1.TextChanged
        Dim originalText As String = txtConfirmSecQ1.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtConfirmSecQ1.Text = filteredText
            txtConfirmSecQ1.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ1, txtSecQ1, lblConfirmSecQ1Error, 1)
        CheckSignUpButton()
    End Sub

    ' Security Answer 2 Events
    Private Sub txtSecQ2_TextChanged(sender As Object, e As EventArgs) Handles txtSecQ2.TextChanged
        Dim originalText As String = txtSecQ2.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtSecQ2.Text = filteredText
            txtSecQ2.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ2, txtSecQ2, lblConfirmSecQ2Error, 2)
        CheckSignUpButton()
    End Sub

    Private Sub txtConfirmSecQ2_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ2.TextChanged
        Dim originalText As String = txtConfirmSecQ2.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtConfirmSecQ2.Text = filteredText
            txtConfirmSecQ2.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ2, txtSecQ2, lblConfirmSecQ2Error, 2)
        CheckSignUpButton()
    End Sub

    ' Security Answer 3 Events
    Private Sub txtSecQ3_TextChanged(sender As Object, e As EventArgs) Handles txtSecQ3.TextChanged
        Dim originalText As String = txtSecQ3.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtSecQ3.Text = filteredText
            txtSecQ3.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ3, txtSecQ3, lblConfirmSecQ3Error, 3)
        CheckSignUpButton()
    End Sub

    Private Sub txtConfirmSecQ3_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmSecQ3.TextChanged
        Dim originalText As String = txtConfirmSecQ3.Text
        Dim filteredText As String = RemoveEmojis(originalText)
        If filteredText <> originalText Then
            txtConfirmSecQ3.Text = filteredText
            txtConfirmSecQ3.SelectionStart = filteredText.Length
        End If
        ValidateSecurityAnswer(txtConfirmSecQ3, txtSecQ3, lblConfirmSecQ3Error, 3)
        CheckSignUpButton()
    End Sub

    '----------------------------------
    ' ValidateSecurityQuestions: Ensures all three security questions are selected and unique.
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

    ' ComboBox events for security questions.
    Private Sub cmbSecQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ1.SelectedIndexChanged
        ValidateSecurityQuestions()
        CheckSignUpButton()
    End Sub

    Private Sub cmbSecQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ2.SelectedIndexChanged
        ValidateSecurityQuestions()
        CheckSignUpButton()
    End Sub

    Private Sub cmbSecQ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecQ3.SelectedIndexChanged
        ValidateSecurityQuestions()
        CheckSignUpButton()
    End Sub

    '----------------------------------
    ' DropDown events: Dynamically update combo box options.
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

    ' Helper: Update combo box options based on selected questions.
    Private Sub UpdateComboBoxOptions(targetComboBox As ComboBox, excludeFrom As List(Of ComboBox))
        Dim selectedQuestions As New List(Of String)
        For Each cb As ComboBox In excludeFrom
            If cb.SelectedItem IsNot Nothing Then
                selectedQuestions.Add(cb.SelectedItem.ToString())
            End If
        Next
        Dim availableQuestions = allQuestions.Where(Function(q) Not selectedQuestions.Contains(q)).ToList()
        Dim currentSelection As Object = targetComboBox.SelectedItem
        targetComboBox.Items.Clear()
        targetComboBox.Items.AddRange(availableQuestions.ToArray())
        If currentSelection IsNot Nothing AndAlso availableQuestions.Contains(currentSelection.ToString()) Then
            targetComboBox.SelectedItem = currentSelection
        End If
    End Sub

    '----------------------------------
    ' btnSignUp_Click: Final validation and database insertion.
    '----------------------------------
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If lblUserIDError.Visible OrElse lblFirstNameError.Visible OrElse lblLastNameError.Visible OrElse
           lblEmailError.Visible OrElse lblPasswordError.Visible OrElse lblConfirmPasswordError.Visible OrElse
           lblContactError.Visible OrElse lblSecurityQuestionError.Visible OrElse
           lblConfirmSecQ1Error.Visible OrElse lblConfirmSecQ2Error.Visible OrElse lblConfirmSecQ3Error.Visible Then
            MessageBox.Show("Please fix the errors before signing up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If Not emailInput.Contains("@") Then
            emailInput &= allowedDomain
            txtEmail.Text = emailInput
        End If

        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            conn.Open()
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE user_id = @user"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@user", txtUserID.Text)
            Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            If userExists > 0 Then
                MessageBox.Show("User ID already exists!", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

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

    '----------------------------------
    ' Form Load: Initializes the form, populates security questions, sets password masking, and disables buttons initially.
    '----------------------------------
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSecQ1.Items.AddRange(allQuestions.ToArray())
        cmbSecQ2.Items.AddRange(allQuestions.ToArray())
        cmbSecQ3.Items.AddRange(allQuestions.ToArray())
        cmbSecQ1.SelectedIndex = -1
        cmbSecQ2.SelectedIndex = -1
        cmbSecQ3.SelectedIndex = -1
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
        btnNext.Enabled = False
        btnSignup.Enabled = False
    End Sub

    '----------------------------------
    ' chkShowPassword_CheckedChanged: Toggles the visibility of the password fields.
    '----------------------------------
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPass.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    '----------------------------------
    ' txtEmail_Leave: Auto-completes the email field if only a username is provided.
    '----------------------------------
    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim emailInput As String = txtEmail.Text.Trim()
        Dim allowedDomain As String = "@lpulaguna.edu.ph"
        If Not String.IsNullOrEmpty(emailInput) AndAlso Not emailInput.Contains("@") Then
            txtEmail.Text = emailInput & allowedDomain
        End If
    End Sub

    '----------------------------------
    ' btnNext_Click: Hides pnlShadow1 and shows pnlShadow2.
    '----------------------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        pnlShadow1.Visible = False
        pnlShadow2.Visible = True
    End Sub

    '----------------------------------
    ' btnBack_Click: Shows pnlShadow1 and hides pnlShadow2.
    '----------------------------------
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlShadow1.Visible = True
        pnlShadow1.BringToFront()
        pnlShadow2.Visible = False
    End Sub

    '----------------------------------
    ' btnCancel_Click: Closes the form.
    '----------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '----------------------------------
    ' FormClosing: Ensures LoginForm is shown if account wasn't created.
    '----------------------------------
    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FromLogin AndAlso Not AccountCreated AndAlso Not LoginForm.Visible Then
            LoginForm.Show()
        End If
    End Sub
End Class
