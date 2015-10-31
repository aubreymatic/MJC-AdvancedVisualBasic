' Name:         Months Project
' Purpose:      Display the number of days associated
'               with the item selected in a list box
' Programmer:   Chris Golpashin on 09-16-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private intDaysInTheMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with values and
        ' then selects the first item

        lstMonths.Items.Add("January")
        lstMonths.Items.Add("February")
        lstMonths.Items.Add("March")
        lstMonths.Items.Add("April")
        lstMonths.Items.Add("May")
        lstMonths.Items.Add("June")
        lstMonths.Items.Add("July")
        lstMonths.Items.Add("August")
        lstMonths.Items.Add("September")
        lstMonths.Items.Add("October")
        lstMonths.Items.Add("November")
        lstMonths.Items.Add("December")
        lstMonths.SelectedIndex = 0

    End Sub

    Private Sub lstMonths_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstMonths.SelectedValueChanged
        ' displays the amount of days in a month in the label control
        ' intSub stores the currently selected index number of lstMonths

        Dim intSub As Integer = lstMonths.SelectedIndex

        ' uses intSub to change the currently displayed amount of days
        lblDays.Text = intDaysInTheMonth(intSub).ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
