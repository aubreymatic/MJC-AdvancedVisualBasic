' Name:         Frankenstein Project
' Purpose:      A game that allows the user to guess a
'               word letter-by-letter
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strWord As String
    Private intIncorrect As Integer

    Private Sub DisplayPicture()
        ' display appropriate picture

        Select Case intIncorrect
            Case 1
                picHead.Visible = True
            Case 2
                picHeadTorso.Visible = True
            Case 3
                picHeadTorsoOneArm.Visible = True
            Case 4
                picHeadTorsoTwoArms.Visible = True
            Case 5
                picHeadTorsoArmsOneLeg.Visible = True
            Case 6
                picFullBody.Visible = True
        End Select
    End Sub

    Private Sub DetermineGameOver(ByVal blnADashWasReplaced As Boolean)
        ' determine whether the game is over and
        ' take the appropriate action

        If blnADashWasReplaced = True Then
            ' if the word does not contain any dashes, 
            ' the game is over because player 2 
            ' guessed the word
            If lblWord.Text.Contains("-") = False Then
                MessageBox.Show("Great guessing!",
                                "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
                intIncorrect = 0
            End If
        Else
            ' if the user made 6 incorrect guesses,
            ' the game is over
            If intIncorrect = 6 Then
                MessageBox.Show("Sorry, the word is " &
                                strWord & ".",
                                "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
                intIncorrect = 0
            End If
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' check if the letter appears in the word

        Dim strLetter As String
        Dim blnDashReplaced As Boolean

        strLetter = txtLetter.Text

        ' look at each letter in the word
        For intIndex As Integer = 0 To 4
            ' if the letter appears in the word,
            ' repalace the letter
            If strWord.Substring(intIndex, 1) = strLetter Then
                lblWord.Text =
                lblWord.Text.Remove(intIndex, 1)
                lblWord.Text =
                lblWord.Text.Insert(intIndex, strLetter)
                blnDashReplaced = True
            End If
        Next intIndex

        If blnDashReplaced = True Then
            Call DetermineGameOver(blnDashReplaced)
        Else  ' no dash was replaced
            lblIncorrect.Text =
                lblIncorrect.Text & " " & strLetter
            intIncorrect = intIncorrect + 1
            Call DisplayPicture()
            Call DetermineGameOver(blnDashReplaced)
        End If

        ' clear text box and set focus
        txtLetter.Text = String.Empty
        txtLetter.Focus()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub txtLetter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetter.KeyPress
        ' allows only letters and the backspace key

        If e.KeyChar Like "[!A-Za-z]" AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        ' start a new game

        ' get a 5-letter word from player 1
        ' and then trim and convert to uppercase
        strWord = InputBox("Enter a 5-letter word:", "Frankenstein Game").Trim.ToUpper

        ' determine whether the word contains 5 letters
        If strWord Like "[A-Z][A-Z][A-Z][A-Z][A-Z]" Then

            ' hide the picture boxes
            picHead.Visible = False
            picHeadTorso.Visible = False
            picHeadTorsoOneArm.Visible = False
            picHeadTorsoTwoArms.Visible = False
            picHeadTorsoArmsOneLeg.Visible = False
            picFullBody.Visible = False

            ' display 5 dashes in lblWord, clear
            ' lblIncorrect, and assign 0 to intIncorrect
            lblWord.Text = "-----"
            lblIncorrect.Text = String.Empty
            intIncorrect = 0

            ' clear the text box, enable the
            ' button, set the focus
            txtLetter.Text = String.Empty
            btnCheck.Enabled = True
            txtLetter.Focus()
        Else
            MessageBox.Show("5 letters are required", "Frankenstein Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
