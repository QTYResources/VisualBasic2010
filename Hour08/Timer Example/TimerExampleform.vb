Public Class TimerExampleform

    Private Sub tmrClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick
        lblClock.Text = TimeOfDay
    End Sub
End Class
