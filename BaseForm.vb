Imports Guna.UI2.WinForms

Public Class BaseForm
    Inherits Form

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        AttachCtrlAHandler(Me)
        AttachDataGridViewReadOnly(Me)
    End Sub

    ' Recursively attach the KeyDown event to every Guna2TextBox within the control tree.
    Private Sub AttachCtrlAHandler(ctrl As Control)
        For Each c As Control In ctrl.Controls
            If TypeOf c Is Guna2TextBox Then
                Dim tb As Guna2TextBox = DirectCast(c, Guna2TextBox)
                ' Use the Tag property as a flag to ensure we attach only once.
                If tb.Tag Is Nothing OrElse Not CType(tb.Tag, Boolean) Then
                    AddHandler tb.KeyDown, AddressOf GunaTextBox_KeyDown
                    tb.Tag = True
                End If
            End If
            If c.HasChildren Then
                AttachCtrlAHandler(c)
            End If
        Next
    End Sub

    ' Recursively set all Guna2DataGridView controls to read-only and full row select.
    Private Sub AttachDataGridViewReadOnly(ctrl As Control)
        For Each c As Control In ctrl.Controls
            If TypeOf c Is Guna2DataGridView Then
                Dim dgv As Guna2DataGridView = DirectCast(c, Guna2DataGridView)
                dgv.ReadOnly = True
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End If
            If c.HasChildren Then
                AttachDataGridViewReadOnly(c)
            End If
        Next
    End Sub

    Private Sub GunaTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Dim tb As Guna2TextBox = CType(sender, Guna2TextBox)
            tb.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
