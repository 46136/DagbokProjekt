Imports System.Data.OleDb
Public Class Aktiviteter
    Private Sub Aktiviteter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub

    Public Sub btnLaggTillAktivitet_Click(sender As Object, e As EventArgs) Handles btnLaggTillAktivitet.Click
        lstAktiviteter.Items.Add(txtAktivitet.Text)

    End Sub

    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class