Public Class ctlNumericTextbox
    Inherits Windows.Forms.TextBox
    Private m_strLastValue As String
    Private m_ttTooltip As New Windows.Forms.ToolTip

    Private Sub ctlNumericTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Not (IsNumeric(e.KeyChar)) Then
            Select Case Microsoft.VisualBasic.AscW(e.KeyChar)
                Case Keys.Enter, Keys.Back, Keys.Tab, Asc("$"), Asc("."), Asc(",")

                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub ctlNumericTextbox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        If Not (IsNumeric(Me.Text)) And Me.Text.Length > 0 Then
            MyBase.Text = m_strLastValue
        Else
            ' Not valid
            m_strLastValue = MyBase.Text

        End If

    End Sub

    Public Sub New()
        With m_ttTooltip
            .IsBalloon = True
            .ToolTipIcon = ToolTipIcon.Info
            .ToolTipTitle = "Numeric entry required"
            .InitialDelay = 0
            .ReshowDelay = 0
            .SetToolTip(Me, "Please enter a number.")
        End With
    End Sub
End Class
