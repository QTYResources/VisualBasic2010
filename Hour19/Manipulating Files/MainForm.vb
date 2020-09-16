Public Class MainForm

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Select a File"
        OpenFileDialog1.FileName = ""

        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"

        OpenFileDialog1.FilterIndex = 1

        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            txtSource.Text = OpenFileDialog1.FileName
        Else
            txtSource.Text = ""
        End If

    End Sub

    Private Sub btnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click
        SaveFileDialog1.Title = "Specify Destination Filename"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 1

        SaveFileDialog1.OverwritePrompt = True

        If SaveFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            txtDestination.Text = SaveFileDialog1.FileName
        End If

    End Sub

    Private Function SourceFileExists() As Boolean
        If Not (System.IO.File.Exists(txtSource.Text)) Then
            MessageBox.Show("The source file does not exist!")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCopyFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyFile.Click
        If Not (SourceFileExists()) Then Exit Sub

        System.IO.File.Copy(txtSource.Text, txtDestination.Text)
        MessageBox.Show("The file has been successfully copied.")

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If Not (SourceFileExists()) Then Exit Sub

        System.IO.File.Move(txtSource.Text, txtDestination.Text)
        MessageBox.Show("The file has been successfully moved.")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not (SourceFileExists()) Then Exit Sub

        If MessageBox.Show("Are you sure you want to delete the source file?", _
              "MyApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
              Windows.Forms.DialogResult.Yes Then
            System.IO.File.Delete(txtSource.Text)
            MessageBox.Show("The file has been successfully deleted.")
        End If

    End Sub
End Class
