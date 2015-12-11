' Name:         Addison Playhouse Project
' Purpose:      Displays the records contained in a dataset
'               Also allows the user to add, delete, modify
'               and save records
' Programmer:   Chris Golpashin on 10/24/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub TblReservationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblReservationsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblReservationsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PlayDataSet)
            MessageBox.Show("Changes Saved", "Addison Playhouse",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Addison Playhouse",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlayDataSet.tblReservations' table. You can move, or remove it, as needed.
        Me.TblReservationsTableAdapter.Fill(Me.PlayDataSet.tblReservations)

    End Sub
End Class
