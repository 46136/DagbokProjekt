Public Class Form1

    Private Sub btnNyttPass_Click(sender As Object, e As EventArgs) Handles btnNyttPass.Click
        NyttPass.Show()
        Me.Hide()
    End Sub

    Private Sub btnOvningar_Click(sender As Object, e As EventArgs) Handles btnOvningar.Click
        Ovningar.Show()
        Me.Hide()
    End Sub

    Private Sub btnAktiviteter_Click(sender As Object, e As EventArgs) Handles btnAktiviteter.Click
        Aktiviteter.Show()
        Me.Hide()
    End Sub
End Class
