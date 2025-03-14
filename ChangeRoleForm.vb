Public Class ChangeRoleForm
    ' This property will hold the selected role when the form is closed
    Public Property SelectedRole As String

    Private Sub ChangeRoleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with valid roles
        cmbNewRole.Items.Clear()
        cmbNewRole.Items.AddRange(New String() {"admin", "staff", "student"})
        cmbNewRole.SelectedIndex = 0 ' Default selection
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Ensure a role is selected
        If cmbNewRole.SelectedItem IsNot Nothing Then
            SelectedRole = cmbNewRole.SelectedItem.ToString()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please select a role.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
