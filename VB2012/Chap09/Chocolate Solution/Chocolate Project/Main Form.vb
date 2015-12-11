' Name:         Chocolate Project
' Purpose:      Display the contents of an array
' Programmer:   Chris Golpashin on 09-14-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare class-level array
    Dim dblPounds() As Double = {35.6, 15, 67.9, 78.8, 2.5, 7}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' display the array's contents
        For intCounter As Integer = 0 To 5
            lstPounds.Items.Add(dblPounds(intCounter))
        Next intCounter
        ' lstPounds.Items.Clear()

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        ' display the array's contents
        For Each dblPoundsElement As Double In dblPounds
            lstPounds.Items.Add(dblPoundsElement)
        Next dblPoundsElement
        ' lstPounds.Items.Clear()

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' display the array's contents
        Dim intCounter As Integer
        Do While intCounter < 5
            lstPounds.Items.Add(dblPounds(intCounter))
            intCounter += 1
        Loop
        ' lstPounds.Items.Clear()

    End Sub

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click
        ' sort the array values in ascending order
        Array.Sort(dblPounds)
        For intCounter As Integer = 0 To 5
            lstPounds.Items.Add(dblPounds(intCounter))
        Next
        ' lstPounds.Items.Clear()

    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        ' sort the array values in descending order
        Array.Sort(dblPounds)
        Array.Reverse(dblPounds)
        For intCounter As Integer = 0 To 5
            lstPounds.Items.Add(dblPounds(intCounter))
        Next
        '  lstPounds.Items.Clear()

    End Sub
End Class
