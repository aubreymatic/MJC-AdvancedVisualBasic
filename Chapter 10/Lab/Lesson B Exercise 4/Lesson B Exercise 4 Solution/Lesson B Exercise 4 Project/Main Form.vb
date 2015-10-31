' Chris Golpashin
' Lesson B Exercise 4
' Due on 10/1/15 @ 11:59 PM

Public Class frmMain

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If IO.File.Exists("sales.txt") Then
            ' if file can be found
            MessageBox.Show("File was found",
                            "Lesson B Exercise 4",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' if file can't be found
            MessageBox.Show("Can't find the file",
                            "Lesson B Exercise 4",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
