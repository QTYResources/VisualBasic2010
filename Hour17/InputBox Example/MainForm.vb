Public Class MainForm

    Private Sub btnGetAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAge.Click
        Dim strResult As String
        Dim intAge As Integer

        strResult = InputBox("Please enter your age.", "Enter Age")

        If strResult = "" Then
            MessageBox.Show("You clicked cancel!")
        ElseIf IsNumeric(strResult) Then
            ' The user entered a number, store the age as a number.
            intAge = CInt(strResult)
            MessageBox.Show("You entered " & intAge & ".")
        Else
            MessageBox.Show("You did not enter a number.")
        End If

    End Sub
End Class
