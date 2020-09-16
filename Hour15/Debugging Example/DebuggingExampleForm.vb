Public Class DebuggingExampleForm

    Private Sub btnPerformDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformDivision.Click
        ' This procedure divides 100 by the value entered in
        ' the text box txtInput.
        Dim lngAnswer As Long
        If txtInput.Text = "" Then
            Exit Sub
        End If

        If Not (IsNumeric(txtInput.Text)) Then Exit Sub

        lngAnswer = 100 / CLng(txtInput.Text)
        MessageBox.Show("100/" & txtInput.Text & " is " & lngAnswer)

    End Sub
End Class
