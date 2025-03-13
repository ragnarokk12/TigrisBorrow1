Imports Guna.UI2.WinForms

Public Class BaseForm
    Inherits Form

    ' Override OnLoad to attach Ctrl + A handler for all Guna2TextBoxes in the form.
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        AttachCtrlAHandler(Me)
    End Sub

    ' Recursively attach the KeyDown event to every Guna2TextBox within the control tree.
    Private Sub AttachCtrlAHandler(ctrl As Control)
        For Each c As Control In ctrl.Controls
            If TypeOf c Is Guna2TextBox Then
                AddHandler DirectCast(c, Guna2TextBox).KeyDown, AddressOf GunaTextBox_KeyDown
            End If

            ' Recursively check child controls
            If c.HasChildren Then
                AttachCtrlAHandler(c)
            End If
        Next
    End Sub

    ' KeyDown event handler for Guna2TextBox controls.
    Private Sub GunaTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Dim tb As Guna2TextBox = CType(sender, Guna2TextBox)
            tb.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
