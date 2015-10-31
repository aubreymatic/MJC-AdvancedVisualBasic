' Chris Golpashin
' Due on 10/08/15 @ 11:59 PM

Public Class frmMain
    Private Sub btnCalcTotalCost_Click(sender As Object, e As EventArgs) Handles btnCalcTotalCost.Click

        Dim amountofFence As New Rectangle
        Dim TotalPermimeterofFence As Double
        Dim Price As Double
        Dim TotalCost As Double

        Double.TryParse(txtLength.Text, amountofFence.Length)
        Double.TryParse(txtWidth.Text, amountofFence.Width)
        Double.TryParse(txtCost.Text, Price)

        TotalPermimeterofFence = amountofFence.GetPerimeter
        TotalCost = TotalPermimeterofFence * Price

        lblTotalCost.Text = TotalCost.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
