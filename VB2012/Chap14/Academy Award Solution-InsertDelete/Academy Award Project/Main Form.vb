﻿' Name:         Academy Award Project
' Purpose:      Displays the records stored in a dataset
'               Allows the user to add records to and 
'               delete records from a dataset
' Programmer:   Chris Golpashin on 12/10/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MoviesDataSet.tblMovies)
        TblMoviesBindingSource.Sort = "YearWon"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add a record to the dataset

        If txtAddYear.Text.Trim = String.Empty OrElse
           txtLength.Text.Trim = String.Empty OrElse
           txtTitle.Text.Trim = String.Empty OrElse
           txtDirector.Text.Trim = String.Empty Then
            MessageBox.Show("Please enter all of the information.",
                            "Academy Award Winners",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            Dim intYear As Integer
            Dim intLength As Integer
            Integer.TryParse(txtAddYear.Text, intYear)
            Integer.TryParse(txtLength.Text, intLength)
            Try
                TblMoviesTableAdapter.InsertRecordQuery(intYear,
                                                        txtTitle.Text.Trim,
                                                        txtDirector.Text.Trim,
                                                        intLength)
                TblMoviesTableAdapter.Fill(MoviesDataSet.tblMovies)
            Catch ex As Exception
                MessageBox.Show("Duplicate record", "Add Record",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' delete a record from the dataset

        Dim dlgButton As DialogResult
        dlgButton =
            MessageBox.Show("Delete winner from year " &
            lstDeleteYear.Text & "?", "Confirm Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Dim intYear As Integer
            Integer.TryParse(lstDeleteYear.Text, intYear)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddYear_Enter(sender As Object, e As EventArgs) Handles txtAddYear.Enter
        txtAddYear.SelectAll()
    End Sub

    Private Sub txtDirector_Enter(sender As Object, e As EventArgs) Handles txtDirector.Enter
        txtDirector.SelectAll()
    End Sub

    Private Sub txtLength_Enter(sender As Object, e As EventArgs) Handles txtLength.Enter
        txtLength.SelectAll()
    End Sub

    Private Sub txtTitle_Enter(sender As Object, e As EventArgs) Handles txtTitle.Enter
        txtTitle.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) _
        Handles txtAddYear.KeyPress, txtLength.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
