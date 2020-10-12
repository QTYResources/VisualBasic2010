Public Class CollectionsExampleForm
    Private Sub btnShowNames_Click(sender As Object, e As EventArgs) Handles btnShowNames.Click
        Dim intIndex As Integer
        For intIndex = 0 To Me.Controls.Count - 1
            MessageBox.Show("Control #" & intIndex & " has the name " &
                            Me.Controls(intIndex).Name)
        Next intIndex
    End Sub
End Class
