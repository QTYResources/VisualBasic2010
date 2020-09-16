Public Class MainForm
    Private m_objGraphics As Graphics

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_objGraphics.Dispose()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_objGraphics = Me.CreateGraphics
    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim rectEllipse As Rectangle

        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        With rectEllipse
            .X = e.X - 1
            .Y = e.Y - 1
            .Width = 2
            .Height = 2
        End With

        m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse)

    End Sub
End Class
