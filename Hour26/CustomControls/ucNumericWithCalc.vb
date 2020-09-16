Public Class ucNumericWithCalc
    Private m_blnCalcButtonVisible As Boolean = True

    Public Event OnCalcButtonClicked(ByRef handled As Boolean)

    Private Sub DrawControl()
        ' Keep a fixed height since the textbox won't go larger
        ' unless it is multi-line
        Me.Height = numTextbox.Height

        If m_blnCalcButtonVisible Then
            btnCalc.Visible = True
            ' Since the button has a fixed width, start
            ' by aligning it to the right edge of the user control
            btnCalc.Left = Me.Width - btnCalc.Width
        Else
            btnCalc.Visible = False
            ' Move the button so it is just off the right edge 
            ' of the control
            btnCalc.Left = Me.Width
        End If

        numTextBox.Width = btnCalc.Left - 1
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DrawControl()
    End Sub

    Private Sub ucNumericWithCalc_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DrawControl()
    End Sub

    Public Property CalcButtonVisible() As Boolean
        Get
            Return m_blnCalcButtonVisible
        End Get
        Set(ByVal value As Boolean)
            m_blnCalcButtonVisible = value
            DrawControl()
        End Set
    End Property


    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim blnHandled As Boolean = False

        RaiseEvent OnCalcButtonClicked(blnHandled)

        If Not blnHandled Then
            Shell("calc.exe")
        End If
    End Sub
End Class
