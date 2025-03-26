Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class EditUserForm
    ' Public property to receive the user ID of the account to edit.
    Public Property UserId As String

    ' Variable to store original values for logging.
    Private originalEmail As String

    ' On form load, populate the fields from the database.
    Private Sub EditUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate role dropdown
        cmbRole.Items.Clear()
        cmbRole.Items.AddRange(New String() {"admin", "staff", "student"})
        LoadUserDetails()
        ' If the current user is not admin, disable role change.
        If Common.CurrentUserRole.ToLower() = "staff" Then
            cmbRole.Enabled = False
        End If
    End Sub

    Private Sub LoadUserDetails()
        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT user_id, first_name, last_name, email, contact_number, role FROM users WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", UserId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtUserID.Text = reader("user_id").ToString()
                        txtFirstName.Text = reader("first_name").ToString()
                        txtLastName.Text = reader("last_name").ToString()
                        txtEmail.Text = reader("email").ToString()
                        txtContact.Text = reader("contact_number").ToString()
                        originalEmail = txtEmail.Text ' Store original email for logging

                        Dim roleValue As String = reader("role").ToString().ToLower()
                        If cmbRole.Items.Contains(roleValue) Then
                            cmbRole.SelectedItem = roleValue
                        Else
                            cmbRole.SelectedIndex = 0
                        End If
                    Else
                        MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' When the admin clicks Save, update the user's details in the database.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newFirstName As String = txtFirstName.Text.Trim()
        Dim newLastName As String = txtLastName.Text.Trim()
        Dim newEmail As String = txtEmail.Text.Trim()
        Dim newContact As String = txtContact.Text.Trim()
        Dim newRole As String = cmbRole.SelectedItem.ToString().ToLower()

        ' Basic validation
        If String.IsNullOrWhiteSpace(newFirstName) OrElse String.IsNullOrWhiteSpace(newLastName) OrElse String.IsNullOrWhiteSpace(newEmail) Then
            MessageBox.Show("First name, last name, and email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As MySqlConnection = Common.getDBConnection()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "UPDATE users SET first_name = @firstName, last_name = @lastName, email = @email, contact_number = @contact, role = @role WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstName", newFirstName)
                cmd.Parameters.AddWithValue("@lastName", newLastName)
                cmd.Parameters.AddWithValue("@email", newEmail)
                cmd.Parameters.AddWithValue("@contact", newContact)
                cmd.Parameters.AddWithValue("@role", newRole)
                cmd.Parameters.AddWithValue("@userId", UserId)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    ' Prepare JSON details for logging. You can include additional fields as needed.
                    Dim details As String = "{""old_email"":""" & originalEmail & """, ""new_email"":""" & newEmail & """}"
                    Common.LogAction("UPDATE_USER", UserId, "USER", details)
                    MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Update failed. No changes were made.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub
End Class
