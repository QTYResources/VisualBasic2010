Public Class ViewerForm

    Const c_defPromptOnExit As Boolean = False

    Private m_strUserName As String
    Private m_blnPromptOnExit As Boolean
    Private m_objPictureBackColor As Color

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

    Private Sub ViewerForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If m_blnPromptOnExit Then
            If MessageBox.Show("Close the Picture Viewer program?", _
                             "Picture Viewer", MessageBoxButtons.YesNo, _
                             MessageBoxIcon.Question) = _
                             Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub ViewerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblX.Text = ""
        lblY.Text = ""

        m_blnPromptOnExit = c_defPromptOnExit
        m_objPictureBackColor = System.Drawing.SystemColors.Control

        picShowPicture.BackColor = m_objPictureBackColor

        m_blnPromptOnExit = c_defPromptOnExit
        m_objPictureBackColor = System.Drawing.SystemColors.Control

        picShowPicture.BackColor = m_objPictureBackColor

        mnuConfirmOnExit.Checked = m_blnPromptOnExit

    End Sub


    Private Sub mnuOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenPicture.Click
        OpenPicture()

    End Sub

    Private Sub mnuConfirmOnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfirmOnExit.Click
        mnuConfirmOnExit.Checked = Not (mnuConfirmOnExit.Checked)
        m_blnPromptOnExit = mnuConfirmOnExit.Checked

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

    Private Sub tbbGetFileAttributes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGetFileAttributes.Click
        Dim strProperties As String
        Dim lngAttributes As Long

        If ofdSelectPicture.FileName = "" Then Exit Sub

        ' Get the dates.
        strProperties = "Created: " & _
              System.IO.File.GetCreationTime(ofdSelectPicture.FileName)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Accessed: " & _
              System.IO.File.GetLastAccessTime(ofdSelectPicture.FileName)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Modified: " & _
              System.IO.File.GetLastWriteTime(ofdSelectPicture.FileName)

        ' Get the file attributes.
        lngAttributes = System.IO.File.GetAttributes(ofdSelectPicture.FileName)

        ' Use a binary AND to extract the specific attributes.
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Normal: " & _
              CBool(lngAttributes And IO.FileAttributes.Normal)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Hidden: " & _
              CBool(lngAttributes And IO.FileAttributes.Hidden)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "ReadOnly: " & _
              CBool(lngAttributes And IO.FileAttributes.ReadOnly)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "System: " & _
              CBool(lngAttributes And IO.FileAttributes.System)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Temporary File: " & _
              CBool(lngAttributes And IO.FileAttributes.Temporary)

        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Archive: " & _
              CBool(lngAttributes And IO.FileAttributes.Archive)

        MessageBox.Show(strProperties, "Picture Viewer")

    End Sub
End Class
