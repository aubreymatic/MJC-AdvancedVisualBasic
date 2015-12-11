' Name:         Academy Award Project
' Purpose:      Displays the records stored in a dataset
'               Also allows the user to display a specific record
' Programmer:   Chris Golpashin on 12/10/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MoviesDataSet.tblMovies)

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays a specific record

        If radAll.Checked Then
            TblMoviesTableAdapter.Fill(MoviesDataSet.tblMovies)
        Else
            If txtYear.Text.Trim = String.Empty Then
                MessageBox.Show("Please enter the year.", "Year Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Else
                Dim intYear As Integer
                Integer.TryParse(txtYear.Text, intYear)
                TblMoviesTableAdapter.FillByYear(MoviesDataSet.tblMovies,
                                                 intYear)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtYear_Enter(sender As Object, e As EventArgs) Handles txtYear.Enter
        txtYear.SelectAll()
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
