

Public Class student
    ' Local variables or backer variables
    Dim _LName As String
    Dim _FName As String
    Dim _Id As Double
    Public _Birthday As Date

    Property LName As String
        Get
            Return _LName
        End Get
        Set(value As String)
            _LName = value
        End Set
    End Property

    Property FName As String
        Get
            Return _FName
        End Get
        Set(value As String)
            _FName = value
        End Set
    End Property

    Property Id As Double
        Get
            Return _Id
        End Get
        Set(value As Double)
            _Id = value
        End Set
    End Property

    Property Birthday As Date
        Get
            Return _Birthday
        End Get
        Set(value As Date)
            _Birthday = value
        End Set
    End Property

    Public Function ProperName() As String
        Return ProperName2()
    End Function


    Private Function ProperName2() As String
        Return _LName & ", " & _FName
    End Function
End Class
