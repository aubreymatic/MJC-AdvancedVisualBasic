' Name:         Treasures Project
' Purpose:      Display an item's price
' Programmer:   Chris Golpashin on 09/30/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Structure ProductInfo
        Public strId As String
        Public intPrice As Integer
    End Structure

    ' declare array of structure variables
    Private priceList(4) As ProductInfo

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblPrice.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the price associated with an ID

        Dim strSearchForId As String
        Dim intSub As Integer

        strSearchForId = txtId.Text

        ' search the strIds array for the ID
        ' continue searching until the end of
        ' the array or the ID is found
        Do Until intSub = priceList.Length OrElse
            strSearchForId = priceList(intSub).strId
            intSub += 1
        Loop

        If intSub < priceList.Length Then
            lblPrice.Text = priceList(intSub).intPrice.ToString("C0")
        Else
            MessageBox.Show("Invalid ID", "Treasures",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill array with IDs and prices

        priceList(0).strId = "BX35"
        priceList(0).intPrice = 13
        priceList(1).strId = "CR20"
        priceList(1).intPrice = 10
        priceList(2).strId = "FE15"
        priceList(2).intPrice = 12
        priceList(3).strId = "KW10"
        priceList(3).intPrice = 24
        priceList(4).strId = "MM67"
        priceList(4).intPrice = 4
    End Sub
End Class
