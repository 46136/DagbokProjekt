Public Class Ovningar
    Private Sub btnLaggTillOvning_Click(sender As Object, e As EventArgs) Handles btnLaggTillOvning.Click
        lstOvningar.Items.Add(txtOvning.Text)
    End Sub

    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class