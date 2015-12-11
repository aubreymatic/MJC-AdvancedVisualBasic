Public Class Character
    Dim _CharacterName As String
    Dim _Classname As String
    Dim _Race As String
    Dim _Gender As String

    Property CharacterName As String
        Get
            Return _CharacterName
        End Get
        Set(value As String)
            _CharacterName = value
        End Set
    End Property

    Property ClassName As String
        Get
            Return _Classname
        End Get
        Set(value As String)
            _Classname = value
        End Set
    End Property

    Property Race As String
        Get
            Return _Race
        End Get
        Set(value As String)
            _Race = value
        End Set
    End Property

    Property Gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property
End Class
