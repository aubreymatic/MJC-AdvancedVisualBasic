' Name:         Pizzeria Project
' Purpose:      Display the number of square pizza slices 
'               that can be cut from a square pizza
' Programmer:   Chris Golpashin on 10/8/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the number of square pizza slices
        ' that can be cut from a square pizza

        Dim entirePizza As New Rectangle
        Dim pizzaSlice As New Rectangle
        Dim dblEntireArea As Double
        Dim dblSliceArea As Double
        Dim dblSlices As Double

        Double.TryParse(txtEntirePizza.Text, entirePizza.Length)
        Double.TryParse(txtEntirePizza.Text, entirePizza.Width)
        Double.TryParse(txtPizzaSlice.Text, pizzaSlice.Length)
        Double.TryParse(txtPizzaSlice.Text, pizzaSlice.Width)

        ' calculate areas
        dblEntireArea = entirePizza.GetArea
        dblSliceArea = pizzaSlice.GetArea
        ' calculate number of slices
        If dblSliceArea > 0 Then
            dblSlices = dblEntireArea / dblSliceArea
        Else
            dblSlices = 0
        End If
        ' display number of slices
        lblSlices.Text = dblSlices.ToString("N1")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtEntirePizza_Enter(sender As Object, e As EventArgs) Handles txtEntirePizza.Enter
        txtEntirePizza.SelectAll()
    End Sub

    Private Sub txtPizzaSlice_Enter(sender As Object, e As EventArgs) Handles txtPizzaSlice.Enter
        txtPizzaSlice.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtEntirePizza.KeyPress, txtPizzaSlice.KeyPress
        ' allows only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtEntirePizza.TextChanged, txtPizzaSlice.TextChanged
        lblSlices.Text = String.Empty
    End Sub
End Class
