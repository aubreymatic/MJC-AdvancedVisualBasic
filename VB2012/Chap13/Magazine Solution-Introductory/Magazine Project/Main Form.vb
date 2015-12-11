' Name:         Magazine Project
' Purpose:      Selects specific records
' Programmer:   Chris Golpashin on 10/24/15

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
        ' displays the record whose Code field contains EX33

        Dim display =
            From magazine In MagazinesDataSet.tblMagazine
            Where magazine.Code.ToUpper = "EX33"
            Select magazine

        TblMagazineBindingSource.DataSource = display.AsDataView
    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        ' displays the record whose MagName field contains Visual Basic

        Dim display =
            From magazine In MagazinesDataSet.tblMagazine
            Where magazine.MagName = "Visual Basic"
            Select magazine

        TblMagazineBindingSource.DataSource = display.AsDataView
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' displays all of the records

        Dim display =
            From magazine In MagazinesDataSet.tblMagazine
            Select magazine

        TblMagazineBindingSource.DataSource = display.AsDataView
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
