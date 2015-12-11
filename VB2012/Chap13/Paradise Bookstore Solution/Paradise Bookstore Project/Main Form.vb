' Name:         Paradise Bookstore Project
' Purpose:      Displays all records or only those
'               for a specific author. Also displays
'               the total value of the books.
' Programmer:   Chris Golpashin on 10/24/15

Option Explicit On
Option Strict On
Option Infer On  ' using LINQ

Public Class frmMain

    Private Sub TblBooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblBooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblBooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooksDataSet)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet.tblBooks' table. You can move, or remove it, as needed.
        Me.TblBooksTableAdapter.Fill(Me.BooksDataSet.tblBooks)

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' display records for a specific author

        Dim records = From book In BooksDataSet.tblBooks
                      Where book.Author.ToUpper Like
                          txtAuthor.Text.ToUpper & "*"
                      Select book

        TblBooksBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' display the total value of the inventory

        Dim dblTotal As Double =
            Aggregate book In BooksDataSet.tblBooks
                Select book.QuantityInStock * book.Price
                    Into Sum()

        MessageBox.Show("Total value: " &
                        dblTotal.ToString("C2"),
                        "Paradise Bookstore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
