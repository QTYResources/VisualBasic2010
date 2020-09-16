Public Class NoRemaindersForm

    Private Sub btnFindNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNumbers.Click
        Dim intSeek As Integer = 1
        Dim intFound As Integer = 0

        Do Until intFound = 10
            If intSeek Mod 3 = 0 Then
                lstResults.Items.Add(CStr(intSeek))
                intFound = intFound + 1
            End If
            intSeek = intSeek + 1
        Loop

    End Sub
End Class
