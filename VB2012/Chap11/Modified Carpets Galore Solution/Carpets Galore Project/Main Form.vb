' Name:         Carpets Galore Project
' Purpose:      Displays the number of square yards of 
'               carpet and the cost of the carpet
' Programmer:   Chris Golpashin on 10/3/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays square yards and cost of carpet

        ' declare a variable for a Rectangle object
        Dim floor As Rectangle

        ' declare variables
        Dim dblPriceSqYd As Double
        Dim dblSqYards As Double
        Dim dblCost As Double
        Dim dblRoomLen As Double
        Dim dblRommWid As Double

        ' assign values to the object's Public properties
        Double.TryParse(lstLength.SelectedItem.ToString, dblRoomLen)
        Double.TryParse(lstWidth.SelectedItem.ToString, dblRommWid)
        Double.TryParse(lstPrice.SelectedItem.ToString, dblPriceSqYd)

        ' instantiate and initialize a Rectangle object
        floor = New Rectangle(dblRoomLen, dblRommWid)

        ' calculate the square yards
        dblSqYards = floor.GetArea / 9

        ' calculate the carpet cost
        dblCost = dblPriceSqYd * dblSqYards

        ' display output
        lblSquareYards.Text = dblSqYards.ToString("N1")
        lblCost.Text = dblCost.ToString("C2")
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs
        ) Handles lstLength.SelectedValueChanged,
        lstWidth.SelectedValueChanged, lstPrice.SelectedValueChanged
        lblSquareYards.Text = String.Empty
        lblCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with data
        ' and then selects a default item

        For dblNums As Double = 4 To 30 Step 0.5
            lstLength.Items.Add(dblNums.ToString("N1"))
            lstWidth.Items.Add(dblNums.ToString("N1"))
        Next dblNums

        For dblPrices As Double = 5 To 25 Step 0.5
            lstPrice.Items.Add(dblPrices.ToString("N2"))
        Next dblPrices

        lstLength.SelectedItem = "10.0"
        lstWidth.SelectedItem = "10.0"
        lstPrice.SelectedItem = "8.00"
    End Sub
End Class
