' Chris Golpashin
' Lesson A Exercise 4
' 10/1/15

Public Class frmMain

    Structure MyFriend
        Public strLast As String
        Public strFirst As String
    End Structure

    Dim school As MyFriend

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        school.strFirst = txtFirst.Text
        school.strLast = txtLast.Text

        lblLast.Text = school.strLast.ToString
        lblFirst.Text = school.strFirst.ToString
    End Sub
End Class
