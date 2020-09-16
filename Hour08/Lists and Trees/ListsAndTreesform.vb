Public Class ListsAndTreesform

    Private Sub btnAddNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNode.Click
        tvwLanguages.Nodes.Add("James")
        tvwLanguages.Nodes.Add("Visual Basic")
    End Sub

    Private Sub btnCreateChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateChild.Click
        Dim objNode As TreeNode
        objNode = tvwLanguages.Nodes.Add("James")
        objNode.Nodes.Add("Visual Basic")

    End Sub
End Class
