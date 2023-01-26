Imports System.Data.OleDb
Public Class Aktiviteter

    Public Sub Aktiviteter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Databaskoppling
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas\Dagbok.accdb")
        'C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas.accdb
        'c:\GIT\DagbokProjekt\Databas\Dagbok.accdb
        conn.Open()
        Dim cmd As New OleDbCommand("Select Aktivitet from Aktiviteter", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        lstAktiviteter.Items.Clear()

        While myreader.Read
            lstAktiviteter.Items.Add(myreader("Aktivitet"))
        End While
        conn.Close()

        'Auto select första item i ComboBox
        If lstAktiviteter.Items.Count > 0 Then
            lstAktiviteter.SelectedIndex = 0
        End If
    End Sub


    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Public Sub btnLaggTillAktivitet_Click(sender As Object, e As EventArgs) Handles btnLaggTillAktivitet.Click
        'Lägger till nya aktiviteten i listan
        lstAktiviteter.Items.Add(txtAktivitet.Text)

        'Databas koppling
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas\Dagbok.accdb")
        'C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas.accdb
        'c:\GIT\DagbokProjekt\Databas\Dagbok.accdb
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String

        'Fyller databas fälten med infon från applikationens fällt
        sql = "INSERT INTO Aktiviteter(Aktivitet) VALUES('" & Me.txtAktivitet.Text & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        conn.Close()

    End Sub
End Class