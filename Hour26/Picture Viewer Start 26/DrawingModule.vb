Module DrawingModule
    Public Sub OpenPicture()
        Try
            ' Show the open file dialog box.
            If ViewerForm.ofdSelectPicture.ShowDialog = DialogResult.OK Then
                ' Load the picture into the picture box.
                ViewerForm.picShowPicture.Image = _
                      Image.FromFile(ViewerForm.ofdSelectPicture.FileName)
                ' Show the name of the file in the statusbar.
                ViewerForm.sbrMyStatusStrip.Items(0).Text = _
                      ViewerForm.ofdSelectPicture.FileName

                UpdateLog(ViewerForm.ofdSelectPicture.FileName)
            End If

        Catch objException As System.OutOfMemoryException
            MessageBox.Show("The file you have chosen is not an image file.", _
                  "Invalid File", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub UpdateLog(ByVal strFileName As String)
        Dim objFile As New System.IO.StreamWriter( _
          System.AppDomain.CurrentDomain.BaseDirectory() & "\PictureLog.txt", _
                True)
        objFile.WriteLine(Today() & " " & strFileName)
        objFile.Close()
        objFile.Dispose()
    End Sub

    Public Sub DrawBorder(ByRef objPicturebox As PictureBox)
        Dim objGraphics As Graphics
        objGraphics = objPicturebox.Parent.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, objPicturebox.Left - 1, _
              objPicturebox.Top - 1, _
              objPicturebox.Width + 1, objPicturebox.Height + 1)

        objGraphics.Dispose()
    End Sub

End Module
