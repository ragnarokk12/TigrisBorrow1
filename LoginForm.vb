Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Handles Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both User ID and Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As MySqlConnection = Common.getDBConnection() ' Get database connection

        Try
            conn.Open()

            ' Hash the password before checking in the database
            Dim hashedPassword As String = HashPassword(txtPassword.Text)

            ' SQL query to verify user credentials
            Dim query As String = "SELECT role FROM users WHERE user_id=@user AND password_hash=@pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", txtUserID.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", hashedPassword)

                Dim roleObj As Object = cmd.ExecuteScalar() ' Retrieve user role

                If roleObj IsNot Nothing Then
                    Dim roleStr As String = roleObj.ToString()

                    ' Set global user properties so that other forms can use them.
                    Common.CurrentUserId = txtUserID.Text.Trim()
                    Common.CurrentUserRole = roleStr.ToLower()

                    MessageBox.Show("Login Successful! Welcome, " & roleStr, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open dashboard based on user role:
                    ' If user is Admin or Staff, show the AdminStaffDashboardForm.
                    ' Otherwise, if they are a student (or any other role), show the UserDashboardForm.
                    If roleStr.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse roleStr.Equals("staff", StringComparison.OrdinalIgnoreCase) Then
                        AddHandler AdminStaffDashboardForm.FormClosed, AddressOf DashboardFormClosed
                        AdminStaffDashboardForm.Show()
                    Else
                        AddHandler UserDashboardForm.FormClosed, AddressOf DashboardFormClosed
                        UserDashboardForm.Show()
                    End If

                    Me.Hide() ' Hide login form
                Else
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Close database connection
        End Try
    End Sub

    ' Handles form close from dashboard to return to login form
    Private Sub DashboardFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Clear global properties if needed
        Common.CurrentUserId = String.Empty
        Common.CurrentUserRole = String.Empty

        Me.Show()
    End Sub

    ' Handles SignUp button click event
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub

    ' Handles Forgot Password label click event
    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        ForgotPasswordForm.Show()
    End Sub

    ' Hashes password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2")) ' Convert byte to hex string
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Toggles password visibility when checkbox is checked
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ChrW(0) ' Show actual text
        Else
            txtPassword.PasswordChar = ChrW(9679) ' Show dots (•)
        End If
    End Sub

    ' Handles form load event
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = False  ' Disable system default password char
        txtPassword.PasswordChar = ChrW(9679) ' Set custom password mask
        lblInstruction.Visible = False ' Hide instruction label initially
        txtUserID.Focus()
    End Sub

    ' Handles when a textbox loses focus
    Private Sub txtUserID_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        ValidateInputFields()
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        ValidateInputFields()
    End Sub

    ' Checks if input fields are empty and displays label
    Private Sub ValidateInputFields()
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblInstruction.Text = "Please fill in all fields!"
            lblInstruction.Visible = True
        Else
            lblInstruction.Visible = False
        End If
    End Sub

    ' Allows user to press Enter to trigger login
    Private Sub txtUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick() ' Simulate login button click
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            txtUserID.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

End Class
