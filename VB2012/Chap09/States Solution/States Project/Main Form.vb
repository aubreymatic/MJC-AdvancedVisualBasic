' Name:         States Project
' Purpose:      Displays the selected list box item
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with array values and
        ' then selects the first item

        Dim strStates() As String = {"Alaska", "Colorado",
                                     "Ohio", "Florida"}

        Dim intHighSub As Integer = strStates.GetUpperBound(0)
        For intSub As Integer = 0 To intHighSub
            lstStates.Items.Add(strStates(intSub))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstMonths_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedValueChanged
        ' displays the selected item in a label control

        lblSelectedItem.Text = lstStates.SelectedItem.ToString
    End Sub
End Class
