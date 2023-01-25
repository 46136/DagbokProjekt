Imports System.Data.OleDb
Public Class Aktiviteter

    Private Sub Aktiviteter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("Select Aktivitet from Aktiviteter", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        lstAktiviteter.Items.Clear()
        While myreader.Read
            lstAktiviteter.Items.Add(myreader("Aktivitet"))
        End While
        conn.Close()
    End Sub

    Public Sub btnLaggTillAktivitet_Click(sender As Object, e As EventArgs) Handles btnLaggTillAktivitet.Click
        lstAktiviteter.Items.Add(txtAktivitet.Text)

    End Sub

    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

End Class