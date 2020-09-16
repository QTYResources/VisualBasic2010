'Imports System.Drawing.Printing

Public Class ViewerForm

    Const c_defPromptOnExit As Boolean = False

    Private m_strUserName As String
    Private m_blnPromptOnExit As Boolean
    Private m_objPictureBackColor As Color

    Private Enum printDesination
        Printer = 0
        PrintPreview = 1
    End Enum

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

        LoadDefaults()

    End Sub

    Public Sub LoadDefaults()
        Const c_strKeyName As String = _
        "HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\"

        ' Initialize the options variables
        m_blnPromptOnExit = CBool(My.Computer.Registry.GetValue _
                (c_strKeyName, "PromptOnExit", "0"))

        If CStr(My.Computer.Registry.GetValue _
                (c_strKeyName, "BackColor", "Gray")) = "Gray" Then
            m_objPictureBackColor = System.Drawing.SystemColors.Control
        Else
            m_objPictureBackColor = System.Drawing.Color.White
        End If

        ' Set the backcolor of the picture box to the default
        picShowPicture.BackColor = m_objPictureBackColor

        ' Set the prompt on exit according to the default
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

    Private Sub tbbShowLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbShowLog.Click
        LogViewerForm.ShowDialog()
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Create a rectangle the size of the printable area of the page
        Dim recPrintable As New Rectangle( _
          e.MarginBounds.Left, e.MarginBounds.Top, _
          e.MarginBounds.Width, e.MarginBounds.Height)
        '         e.Graphics.VisibleClipBounds)

        ' Create a rectangle used for the actual drawing dimensions of the image.
        ' Default it to the printable area.
        Dim recDraw As Rectangle = recPrintable

        ' Load the image in a bitmap object we can use.
        Dim img As New Bitmap(ofdSelectPicture.FileName)

        ResizeToPrintableArea(img, recDraw, recPrintable)

        e.Graphics.DrawImage(img, recDraw)

        ' Specify that this is the last page to print
        e.HasMorePages = False

        ' Free up resources used.
        img.Dispose()

    End Sub

    Private Sub ResizeToPrintableArea(ByRef img As Bitmap, _
        ByRef recDraw As Rectangle, ByRef recPrintable As Rectangle)

        ' Which is longer in the source image, the height or width?
        If img.Width > img.Height Then

            ' Which is bigger on destination, width or height?
            If recPrintable.Width > recPrintable.Height Then
                ' Height is constraint.
                recDraw.Width = CInt(recDraw.Height * (img.Width / img.Height))
            Else
                ' Width is constraint.
                recDraw.Height = CInt(recDraw.Width * (img.Height / img.Width))
            End If

        Else        ' The height is greater than or equal to the width.
            ' Which is bigger on destination, width or height?
            If recPrintable.Height > recPrintable.Width Then
                ' width is constraint.
                recDraw.Height = CInt(recDraw.Width * (img.Height / img.Width))
            Else
                ' height is constraint.
                recDraw.Width = CInt(recDraw.Height * (img.Width / img.Height))
            End If
        End If

    End Sub

    Private Sub PrintImage(ByVal Destination As printDesination)

        If ofdSelectPicture.FileName = "" Then
            MessageBox.Show("There is no image to print.", "Picture Viewer", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Call ChangePageSettings()

        If Destination = printDesination.PrintPreview Then
            'Specify document for print preview dialog box and show       
            PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.ShowDialog()
        Else
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub ChangePageSettings()
        ' Let the user change the printer settings
        Dim PrintPageSettings As New PageSettings

        PageSetupDialog1.PageSettings = PrintPageSettings
        PageSetupDialog1.ShowDialog()

        'Specify current page settings
        PrintDocument1.DefaultPageSettings = PrintPageSettings
    End Sub

    Private Sub tbbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbPrint.Click

        PrintImage(printDesination.Printer)
    End Sub

    Private Sub tbbPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbPrintPreview.Click
        PrintImage(printDesination.PrintPreview)
    End Sub
End Class
