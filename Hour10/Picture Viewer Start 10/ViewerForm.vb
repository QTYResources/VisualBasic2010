﻿Public Class ViewerForm

    Private Sub btnSelectPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPicture.Click
        ' Show the open file dialog box.
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"

        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        ' Close the window and exit the application
        Me.Close()

    End Sub

    Private Sub btnEnlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnlarge.Click
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20

    End Sub

    Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20

    End Sub

    Private Sub btnDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawBorder.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics

        objGraphics.Clear(SystemColors.Control)

        objGraphics.DrawRectangle(Pens.Blue, picShowPicture.Left - 1, picShowPicture.Top - 1, picShowPicture.Width + 1, picShowPicture.Height + 1)

        objGraphics.Dispose()

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

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Optionsform.ShowDialog()
    End Sub


    Private Sub mnuOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenPicture.Click
        ' Show the open file dialog box.
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer (" & ofdSelectPicture.FileName & ")"
        End If

    End Sub

    Private Sub mnuConfirmOnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfirmOnExit.Click
        mnuConfirmOnExit.Checked = Not (mnuConfirmOnExit.Checked)
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub mnuDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrawBorder.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, _
                               picShowPicture.Left - 1, _
                               picShowPicture.Top - 1, _
                               picShowPicture.Width + 1, picShowPicture.Height + 1)

        objGraphics.Dispose()

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
        ' Show the open file dialog box.
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"
        End If

    End Sub

    Private Sub tbbDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbDrawBorder.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, _
              picShowPicture.Left - 1, _
              picShowPicture.Top - 1, _
              picShowPicture.Width + 1, picShowPicture.Height + 1)

        objGraphics.Dispose()

    End Sub

    Private Sub tbbOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbOptions.Click
        Optionsform.ShowDialog()
    End Sub
End Class
