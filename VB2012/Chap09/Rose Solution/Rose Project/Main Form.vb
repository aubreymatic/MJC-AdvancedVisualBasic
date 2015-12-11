' Name:         Rose Project
' Purpose:      Displays the price of a ticket
' Programmer:   Chris Golpashin on 09-14-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSection.SelectedIndexChanged
        lblPrice.Text = String.Empty
    End Sub

    Private dblPrices() As Double = {103, 95, 75.5, 32.5}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstSection.Items.Add("A")
        lstSection.Items.Add("B")
        lstSection.Items.Add("C")
        lstSection.Items.Add("D")
        lstSection.SelectedIndex = 0

        ' lstSection.Items.Add("E")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the array price corresponding
        ' to the selected list box item

        Dim intSub As Integer = lstSection.SelectedIndex
        If intSub <= dblPrices.GetUpperBound(0) Then
            lblPrice.Text = dblPrices(intSub).ToString("C2")
        Else
            lblPrice.Text = "N/A"
        End If

    End Sub
End Class
