Public Class FadingFormForm

    Private Sub btnFadeForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFadeForm.Click
        Dim sngOpacity As Single

        For sngOpacity = 1 To 0 Step -0.05
            Me.Opacity = sngOpacity
            ' Let the form repaint itself.
            Me.Refresh()
            ' Create a delay.
            System.Threading.Thread.Sleep(200)
        Next

        ' Show the form again.
        Me.Opacity = 1

    End Sub
End Class
