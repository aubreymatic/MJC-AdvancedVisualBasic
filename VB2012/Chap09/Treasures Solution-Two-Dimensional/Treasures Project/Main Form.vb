' Name:         Treasures Project
' Purpose:      Display an item's price
' Programmer:   Chris Golpashin on 09-18-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare two-dimensional array
    Private strItems(,) As String = {{"BX35", "13"},
                                   {"CR20", "10"},
                                   {"FE15", "12"},
                                   {"KW10", "24"},
                                   {"MM67", "4"}}

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
        ' display the price associated with an ID

        Dim strSearchForId As String
        Dim intRow As Integer

        strSearchForId = txtId.Text

        ' search the first column for the ID
        ' continue searching until the end of
        ' the first column for the ID is found
        Do Until intRow > strItems.GetUpperBound(0) OrElse
                strSearchForId = strItems(intRow, 0)
            intRow += 1
        Loop

        If intRow <= strItems.GetUpperBound(0) Then
            Dim intPrice As Integer
            Integer.TryParse(strItems(intRow, 1), intPrice)
            lblPrice.Text = intPrice.ToString("C0")
        Else
            MessageBox.Show("Invalid ID", "Treasures",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
