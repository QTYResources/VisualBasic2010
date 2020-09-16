Public Class MDIParentForm

    Private Sub MDIParentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Child1Form.MdiParent = Me
        Child1Form.Show()
    End Sub
End Class
