Public Class MainForm

    Private Sub btnShowCustomDialogBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCustomDialogBox.Click
        If CustomDialogBoxForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("You clicked OK.")
        Else
            MessageBox.Show("You clicked Cancel.")
        End If

    End Sub
End Class
