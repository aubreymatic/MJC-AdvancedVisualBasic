' Name:         Formula Project
' Purpose:      Displays the area of either a parallelogram or a triangle
' Programmer:   Chris Golpashin on 10/08/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress, txtHeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles radParallelogram.CheckedChanged, radTriangle.CheckedChanged, txtBase.TextChanged, txtHeight.TextChanged
        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim entireArea As New Parallelogram
        Dim entireTriArea As New Triangle
        Dim dblNewArea As Double


        Double.TryParse(txtBase.Text, entireArea.Base)
        Double.TryParse(txtHeight.Text, entireArea.Height)

        Double.TryParse(txtBase.Text, entireTriArea.Base)
        Double.TryParse(txtHeight.Text, entireTriArea.Height)

        'Calculate Area
        If radParallelogram.Checked = True Then
            dblNewArea = entireArea.GetArea
        Else
            dblNewArea = entireTriArea.GetArea
        End If
        'Display Area for Parallelogram
        lblAnswer.Text = dblNewArea.ToString("N2")
    End Sub
End Class
