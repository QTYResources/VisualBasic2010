Public Class KeyboardExampleForm

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

End Class
