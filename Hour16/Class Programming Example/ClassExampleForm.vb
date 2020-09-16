Public Class ClassExampleForm

    Private Sub btnCreateObject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateObject.Click
        Dim objMyObject As clsMyClass

        objMyObject = New clsMyClass()

        MessageBox.Show(objMyObject.AddTwoNumbers(1, 2))

        objMyObject = Nothing

    End Sub
End Class
