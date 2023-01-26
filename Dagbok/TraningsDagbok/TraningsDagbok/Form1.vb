Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas\Dagbok.accdb")
        'C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas\Dagbok.accdb
        'c:\GIT\DagbokProjekt\Databas\Dagbok.accdb
        conn.Open()
        Dim cmd As New OleDbCommand("Select * from Traning", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        lstGammlaPass.Items.Clear()

        While myreader.Read
            lstGammlaPass.Items.Add(myreader("Datum"))
            lstGammlaPass.Items.Add(myreader("Aktivitet"))
            lstGammlaPass.Items.Add(myreader("Tid") & " min")
            lstGammlaPass.Items.Add(myreader("Ovning"))
            lstGammlaPass.Items.Add(myreader("Sat") & " Set")
            lstGammlaPass.Items.Add(myreader("Rep") & " Rep")
            lstGammlaPass.Items.Add(myreader("Vikt") & " Kg")
            lstGammlaPass.Items.Add(myreader("rpe") & " rpe")
            lstGammlaPass.Items.Add(myreader("Anteckning"))
            lstGammlaPass.Items.Add(" ")
        End While
        conn.Close()

    End Sub

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
