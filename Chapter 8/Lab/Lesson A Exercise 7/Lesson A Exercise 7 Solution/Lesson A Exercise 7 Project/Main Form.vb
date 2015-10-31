'Chris Golpashin
' 09-13-15
' Lesson A Exercise 7

' When I changed the name of the form to frmMain, I keep getting a error saying Form1 is not a part of Lesson A Exercise 7 Solution, but
' when I change the form back to Form1, it works perfectly.

Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' strAddress contains the street address
        Dim strAddress As String = "JeFfErSoN StReEt"

        ' Contains either false or truth
        Dim blnIsContained As Boolean

        ' The text in strAddress is set to all capitals, and checked to see if it contains "Jefferson street" in all capitals
        blnIsContained = strAddress.ToUpper.Contains("JEFFERSON STREET")

        ' Displays a messagebox for either true or false to identify if strAddress contains "Jefferson Street"
        If blnIsContained = True Then
            MessageBox.Show("strAddress does contain jefferson street", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("strAddress does not contain jefferson street", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
