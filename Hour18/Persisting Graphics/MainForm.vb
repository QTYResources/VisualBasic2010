Public Class MainForm

    Private m_objDrawingSurface As Bitmap

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        ' Create a drawing surface with the same dimensions as the client
        ' area of the form.
        m_objDrawingSurface = New Bitmap(Me.ClientRectangle.Width, _
                              Me.ClientRectangle.Height, _
                              Drawing.Imaging.PixelFormat.Format24bppRgb)
        InitializeSurface()

    End Sub

    Private Sub InitializeSurface()
        Dim objGraphics As Graphics
        Dim rectBounds As Rectangle

        ' Create a Graphics object that references the bitmap and clear it.
        objGraphics = Graphics.FromImage(m_objDrawingSurface)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        ' Create a rectangle the same size as the bitmap.
        rectBounds = New Rectangle(0, 0, m_objDrawingSurface.Width, _
                                   m_objDrawingSurface.Height)
        ' Reduce the rectangle slightly so the ellipse won't appear on the
        ' border.
        rectBounds.Inflate(-1, -1)

        ' Draw an ellipse that fills the form.
        objGraphics.DrawEllipse(System.Drawing.Pens.Orange, rectBounds)
    End Sub

    Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim objGraphics As Graphics
        ' You can't modify e.Graphics directly.
        objGraphics = e.Graphics
        ' Draw the contents of the bitmap on the form.
        objGraphics.DrawImage(m_objDrawingSurface, 0, 0, _
                              m_objDrawingSurface.Width, _
                              m_objDrawingSurface.Height)

    End Sub

    Private Sub btnDrawText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawText.Click
        Dim objGraphics As Graphics
        Dim objFont As Font
        Dim intFontSize As Integer
        Dim intTextX As Integer
        Dim intTextY As Integer
        Dim objRandom As System.Random

        ' If no text has been entered, get out.
        If txtInput.Text = "" Then Exit Sub

        ' Create a graphics object using the memory bitmap.
        objGraphics = Graphics.FromImage(m_objDrawingSurface)

        ' Initialize the Random object.
        objRandom = New Random(Now.Millisecond)

        ' Create a random number for the font size. Keep it between 8 and 48.
        intFontSize = objRandom.Next(8, 48)
        ' Create a random number for X coordinate of the text.
        intTextX = objRandom.Next(0, Me.ClientRectangle.Width - 20)
        ' Create a random number for Y coordinate of the text.
        intTextY = objRandom.Next(0, Me.ClientRectangle.Height - 20)
        ' Create a new font object.
        objFont = New System.Drawing.Font("Arial", intFontSize, _
                                          FontStyle.Bold Or FontStyle.Italic)
        ' Draw the user's text.
        objGraphics.DrawString(txtInput.Text, objFont, _
                               System.Drawing.Brushes.Red, intTextX, intTextY)
        ' Clean up.
        objGraphics.Dispose()
        ' Force the form to paint itself. This triggers the Paint event.
        Me.Invalidate()

    End Sub
End Class
