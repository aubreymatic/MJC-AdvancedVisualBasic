' Name:         Sydney Project
' Purpose:      Displays the records from a dataset
' Programmer:   Chris Golpashin on 10-23-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProductsDataSet)
            MessageBox.Show("Changes Saved", "Sydney Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sydney Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.ProductsDataSet.tblProducts)

    End Sub
End Class