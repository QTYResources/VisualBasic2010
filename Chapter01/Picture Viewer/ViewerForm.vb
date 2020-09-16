Public Class ViewerForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelectPicture_Click(sender As Object, e As EventArgs) Handles btnSelectPicture.Click
        ' Show the open file dialog box.
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Close the window and exit the application
        Me.Close()
    End Sub
End Class
