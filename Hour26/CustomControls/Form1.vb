Public Class Form1

    Private Sub numInput_OnCalcButtonClicked(ByRef handled As Boolean) Handles numInput.OnCalcButtonClicked
        If MessageBox.Show("Show the calculator", "", _
            MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            handled = True
        End If
    End Sub
End Class
