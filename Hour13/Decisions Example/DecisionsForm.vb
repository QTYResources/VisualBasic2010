Public Class DecisionsForm

    Private Sub btnIsNumeric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIsNumeric.Click
        If IsNumeric(txtInput.Text) Then
            MessageBox.Show("The text is a number.")
        Else
            MessageBox.Show("The text is not a number.")
        End If

    End Sub
End Class
