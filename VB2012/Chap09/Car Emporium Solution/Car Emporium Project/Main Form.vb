' Name:         Car Emporium Project
' Purpose:      Display the highest commission amount and the
'               number of salespeople who were paid that amount
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' displays the highest commission and the
        ' number who were paid that amount

        Dim intCommissions() As Integer = {2500, 3400, 1000,
                                           3400, 2500, 1000,
                                           2850, 3000, 2780, 1890}
        Dim intLastSub As Integer =
            intCommissions.GetUpperBound(0)
        Dim intHighest As Integer = intCommissions(0)
        Dim intSalesPeople As Integer = 1

        For intSub As Integer = 1 To intLastSub
            If intCommissions(intSub) = intHighest Then
                intSalesPeople += 1
            Else
                If intCommissions(intSub) > intHighest Then
                    intHighest = intCommissions(intSub)
                    intSalesPeople = 1
                End If
            End If
        Next intSub
        lblHighest.Text = intHighest.ToString("C0")
        lblSalespeople.Text = intSalespeople.ToString
    End Sub
End Class
