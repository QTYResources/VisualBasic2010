Public Class LogViewerForm

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub LogViewerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim objFile As New System.IO.StreamReader( _
                  System.AppDomain.CurrentDomain.BaseDirectory() & _
                  "\PictureLog.txt")
            txtLog.Text = objFile.ReadToEnd()
            objFile.Close()
            objFile.Dispose()
        Catch ex As Exception
            txtLog.Text = "The log file could not be found."
        End Try

    End Sub
End Class