Public Class MainForm

    Private Sub btnAutomateWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutomateWord.Click
        Dim objWord As New Word.Application

        objWord.Visible = True

        objWord.Documents.Add()

        objWord.Selection.TypeText("This is text from a VB 2010 application.")

        objWord = Nothing

    End Sub
End Class
