Public Class SelectCaseExampleForm

    Private Sub btnShowLegs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowLegs.Click
        Select Case cboAnimals.Text
            Case "Bird"
                MessageBox.Show("This animal has 2 legs.")
            Case "Horse", "Dog", "Cat"
                MessageBox.Show("This animal has 4 legs.")
            Case "Snake"
                MessageBox.Show("This animal has no legs.")
            Case "Centipede"
                MessageBox.Show("This animal has 100 legs.")
            Case Else
                MessageBox.Show("You did not select from the list!")
        End Select

    End Sub
End Class
