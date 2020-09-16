Public Class ExceptionHandlingExampleForm

    Private Sub btnCatchException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatchException.Click
        Dim lngNumerator As Long = 10
        Dim lngDenominator As Long = 0
        Dim lngResult As Long

        Try
            Debug.WriteLine("Try")
            lngResult = lngNumerator / lngDenominator

        Catch ex As Exception
            Debug.WriteLine("Catch")
            MessageBox.Show("An error has occurred: " & ex.Message)

        Finally
            Debug.WriteLine("Finally")
        End Try

        Debug.WriteLine("Done Trying")


    End Sub
End Class
