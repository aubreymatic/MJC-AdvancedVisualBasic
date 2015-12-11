' Name:         Jenko Project
' Purpose:      Display the total of the sales
'               stored in a two-dimensional array
' Programmer:   Chris Golpashin on 09-18-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the total sales

        Dim dblSales(,) As Double = {{1200.33, 2350.75},
                                     {3677.8, 2456.05},
                                     {750.67, 1345.99}}
        Dim dblTotal As Double
        ' total the sales amounts stored in the array
        For Each dblElement As Double In dblSales
            dblTotal = dblTotal + dblElement
        Next dblElement
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub
End Class
