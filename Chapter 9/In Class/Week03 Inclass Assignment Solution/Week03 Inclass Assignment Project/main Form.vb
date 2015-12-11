' Chris Golpashin
' Character Creation

Public Class frmMain

    Structure Character
        Dim CharacterName As String
        Dim ClassName As String
        Dim Race As String
        Dim Gender As String
    End Structure
    Dim characterList As New List(Of Character)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim NewCharacter As Character
        With NewCharacter
            .CharacterName = txtCharacterName.Text
            .ClassName = txtClassName.Text
            .Race = txtRace.Text
            .Gender = txtGender.Text
        End With
        characterList.Add(NewCharacter)

        Dim item = lvwOutput.Items.Add(NewCharacter.CharacterName)
        For cnt As Integer = 0 To lvwOutput.Columns.Count
            item.SubItems.Add("")
        Next
        item.SubItems(1).Text = NewCharacter.ClassName
        item.SubItems(2).Text = NewCharacter.Race
        item.SubItems(3).Text = NewCharacter.Gender

    End Sub

    Private Sub CloseProgram() Handles btnExit.Click, mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub Clear() Handles btnClear.Click, mnuFileClear.Click, btnSave.Click
        txtCharacterName.Clear()
        txtClassName.Clear()
        txtRace.Clear()
        txtGender.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' This needs to remove the selected item from the lvwOutput and from the studentlist structure

        Dim currentRecord As String = lvwOutput.FocusedItem.Index
        lvwOutput.Items.RemoveAt(lvwOutput.FocusedItem.Index)
        characterList.RemoveAt(currentRecord)

    End Sub

    Private Function SaveToTxt() As String Handles btnSave.Click

        Dim fileText As String = ""
        For Each i As Character In characterList
            fileText += i.CharacterName & ", " & i.ClassName & ", " & i.Race & ", " & i.Gender ' & i.ConcatenatedInfo
            fileText += vbCrLf
        Next

        Dim outFile As IO.StreamWriter
        If IO.File.Exists("CharacterList.txt") Then
            outFile = IO.File.CreateText("CharacterList.txt")
        Else
            MessageBox.Show("The CharacterList.txt could not be located.", "Character Creator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        outFile.WriteLine(fileText)

        outFile.Close()

    End Function
End Class