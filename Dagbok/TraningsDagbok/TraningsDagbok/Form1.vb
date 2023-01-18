Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNyttPass_Click(sender As Object, e As EventArgs) Handles btnNyttPass.Click
        NyttPass.Show()
        Me.Hide()
    End Sub
End Class
