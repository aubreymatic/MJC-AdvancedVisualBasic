' Name:         Color Project
' Purpose:      Displays an item's color 
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        lblColor.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strItemNumber As String = txtItem.Text.Trim.ToUpper ' stores item number in strItemNumber
        Dim strColorIdLetter As String ' store color ID letter

        ' checks to see if the format is corect and assigns the fourth character to the strColorIdLetter
        If strItemNumber Like "###[A-Za-z]###" Then
            strColorIdLetter = strItemNumber.Substring(3, 1)

            ' displays a color for the specifed letter
            Select Case strColorIdLetter
                Case "B"
                    lblColor.Text = "Blue"
                Case "G"
                    lblColor.Text = "Green"
                Case "R"
                    lblColor.Text = "Red"
                Case "W"
                    lblColor.Text = "White"
                Case Else
                    MessageBox.Show("We do not have that color.",
                            "Color Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Else
            ' gives a error if the format is not correct
            MessageBox.Show("Please make sure that there are 7 characters and that the fourth character is a letter corresponding to a color.",
                            "Color Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblColor.Text = "ERROR"
        End If
    End Sub
End Class
