Public Class CollectionsExampleform

    Private Sub btnShowNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowNames.Click
        Dim intIndex As Integer
        For intIndex = 0 To Me.Controls.Count - 1
            MessageBox.Show("Control #" & intIndex & " has the name " & _
                  Me.Controls(intIndex).Name)
        Next intIndex

    End Sub
End Class
