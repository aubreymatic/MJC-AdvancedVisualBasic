' Name:         Academy Award Project
' Purpose:      Uses SQL to select records
' Programmer:   Chris Golpashin on 12/10/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MoviesDataSet.tblMovies)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
