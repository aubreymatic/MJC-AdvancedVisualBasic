' Name:         CourseGrade.vb
' Programmer:   Chris Golpashin on 10/15/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class CourseGrade
    Public Property Score1 As Integer
    Public Property Score2 As Integer
    Private _strGrade As String

    Public ReadOnly Property Grade As String
        Get
            Return _strGrade
        End Get
    End Property

    Public Sub New()
        _Score1 = 0
        _Score2 = 0
        _strGrade = String.Empty
    End Sub

    Public Sub DetermineGrade()
        Select Case _Score1 + _Score2
            Case Is >= 180
                _strGrade = "A"
            Case Is >= 160
                _strGrade = "B"
            Case Is >= 140
                _strGrade = "C"
            Case Is >= 120
                _strGrade = "D"
            Case Else
                _strGrade = "F"
        End Select
    End Sub
End Class