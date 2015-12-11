' Name:         Shapes.vb
' Programmer:   Chris Golpashin on 10/15/15

Option Explicit On
Option Strict On
Option Infer Off

' base class
Public Class Square
    Public Property Side As Double

    Public Sub New()
        _Side = 0
    End Sub

    Public Sub New(ByVal dblS As Double)
        Side = dblS
    End Sub

    Public Overridable Function GetArea() As Double
        ' returns the area of a square
        Return _Side ^ 2
    End Function
End Class

' derived class
Public Class Cube
    Inherits Square
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal dblS As Double)
        MyBase.New(dblS)
    End Sub

    Public Overrides Function GetArea() As Double
        Return MyBase.GetArea * 6
    End Function
End Class