Public Class ViewerForm


    Private Sub btnEnlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnlarge.Click
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20

    End Sub

    Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20

    End Sub


    Private Sub picShowPicture_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShowPicture.MouseLeave
        lblX.Text = ""
        lblY.Text = ""

    End Sub

    Private Sub picShowPicture_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picShowPicture.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y
    End Sub

    Private Sub ViewerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblX.Text = ""
        lblY.Text = ""
    End Sub


    Private Sub mnuOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenPicture.Click
        OpenPicture()

    End Sub

    Private Sub mnuConfirmOnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfirmOnExit.Click
        mnuConfirmOnExit.Checked = Not (mnuConfirmOnExit.Checked)
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub mnuDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrawBorder.Click
        DrawBorder(picShowPicture)

    End Sub

    Private Sub mnuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions.Click
        Optionsform.ShowDialog()
    End Sub

    Private Sub DrawBorderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawBorderToolStripMenuItem.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, _
                               picShowPicture.Left - 1, _
                               picShowPicture.Top - 1, _
                               picShowPicture.Width + 1, picShowPicture.Height + 1)

        objGraphics.Dispose()

    End Sub

    Private Sub tbbOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbOpenPicture.Click
        OpenPicture()

    End Sub

    Private Sub tbbDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbDrawBorder.Click
        DrawBorder(picShowPicture)

    End Sub

    Private Sub tbbOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbOptions.Click
        Optionsform.ShowDialog()
    End Sub
End Class
