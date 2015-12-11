Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim x As New student
        x.LName = "Golpashin"
        x.FName = "Chris"
        x.Id = "000000"
        MessageBox.Show(x.ProperName)
    End Sub
End Class
