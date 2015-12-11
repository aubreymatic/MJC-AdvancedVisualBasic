' Name:         Morgan Industries Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   Chris Golpashin on 10/24/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub TblEmployBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblEmployBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblEmployBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
            MessageBox.Show("Changed saved", "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub mnuAverageAll_Click(sender As Object, e As EventArgs) Handles mnuAverageAll.Click
        ' displays the average pay rate for all employees

        Dim dblAverage As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for all employees: " &
                        dblAverage.ToString("C2"),
                        "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub mnuAverageFull_Click(sender As Object, e As EventArgs) Handles mnuAverageFull.Click
        ' displays the average pay rate for full-time employees

        Dim dblAverage As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Where employee.Status.ToUpper = "F"
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for full-time employees: " &
                        dblAverage.ToString("C2"),
                        "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub mnuAveragePart_Click(sender As Object, e As EventArgs) Handles mnuAveragePart.Click
        ' displays the average pay rate for part-time employees

        Dim dblAverage As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Where employee.Status.ToUpper = "P"
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for part-time employees: " &
                        dblAverage.ToString("C2"),
                        "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
