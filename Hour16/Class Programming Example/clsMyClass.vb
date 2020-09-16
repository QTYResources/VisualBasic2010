Public Class clsMyClass
    Private m_intHeight As Integer

    Public Property Height() As Integer
        Get
            Return m_intHeight
        End Get

        Set(ByVal value As Integer)
            If m_intHeight < 10 Then Exit Property
            m_intHeight = value

        End Set
    End Property

    Public Function AddTwoNumbers(ByVal intNumber1 As Integer, _
                              ByVal intNumber2 As Integer) As Long
        AddTwoNumbers = intNumber1 + intNumber2
    End Function

End Class
