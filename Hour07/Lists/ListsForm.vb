Public Class ListsForm

    Private Sub btnAddSong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSong.Click
        lstChemicalEchoSongs.Items.Add("Orbit")

    End Sub

    Private Sub btnRemoveSong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSong.Click
        lstChemicalEchoSongs.Items.Remove("Orbit")
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        lstChemicalEchoSongs.Items.Clear()
    End Sub

    Private Sub btnShowItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowItem.Click
        MessageBox.Show("You selected " & lstChemicalEchoSongs.SelectedItem & _
            " which has an index of " & lstChemicalEchoSongs.SelectedIndex)

    End Sub
End Class
