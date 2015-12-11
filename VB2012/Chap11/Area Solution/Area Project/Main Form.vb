' Name:         Area Project
' Purpose:      Display the area of a square or 
'               the surface area of a cube
' Programmer:   Chris Golpashin on 10/15/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        ' displays the area of a square

        Dim mySquare As New Square
        Dim dblArea As Double

        Double.TryParse(txtSide.Text, mySquare.Side)

        ' calculate the area
        dblArea = mySquare.GetArea
        ' display the area
        lblArea.Text = "Square: " & dblArea.ToString("N1")
    End Sub

    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        ' displays the surface area of a cube

        Dim myCube As New Cube
        Dim dblArena As Double

        Double.TryParse(txtSide.Text, myCube.Side)

        ' calculate the area
        dblArena = myCube.GetArea
        ' display the area
        lblArea.Text = "Cube: " & dblArena.ToString("N1")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSide_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSide.KeyPress
        ' accepts only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSide_TextChanged(sender As Object, e As EventArgs) Handles txtSide.TextChanged
        lblArea.Text = String.Empty
    End Sub
End Class
