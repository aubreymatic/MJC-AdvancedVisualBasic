' Name:         Rearrange Name Project
' Purpose:      Change a name from first, space, and last 
'               to last, comma, space, and first
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRearrange_Click(sender As Object, e As EventArgs) Handles btnRearrange.Click
        ' rearranges and then displays a name

        Dim strName As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim intIndex As Integer

        ' assign the input to a variable
        strName = txtName.Text.Trim

        ' search for the space in the name
        intIndex = strName.IndexOf(" ")

        ' if the input contains a space
        If intIndex <> -1 Then
            ' separate the first and last names
            strFirstName = strName.Substring(0, intIndex)
            strLastName = strName.Substring(intIndex + 1)

            ' display last name, comma, space, and first name
            lblRearrangedName.Text =
                strLastName & ", " & strFirstName

        Else    ' the name does not contain a space
            MessageBox.Show("Invalid name format",
                            "Rearrange Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
