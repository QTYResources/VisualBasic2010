Public Class MainForm

    Private Sub btnAutomateExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutomateExcel.Click
        Dim objExcel As New Excel.Application
        objExcel.Visible = True

        objExcel.Workbooks.Add()

        objExcel.Range("A1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "75"
        objExcel.Range("B1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "125"
        objExcel.Range("C1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "255"
        objExcel.Range("D1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "295"

        objExcel.Range("A1:D1").Select()
        objExcel.Range("E1").Activate()
        objExcel.ActiveCell.FormulaR1C1 = "=SUM(RC[-4]:RC[-1])"

        objExcel.Range("A1:E1").Select()
        objExcel.Selection.Font.Bold = True

        objExcel = Nothing
    End Sub
End Class
