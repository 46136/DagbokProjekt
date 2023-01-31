Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Ovningar
    Private Sub Ovningar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection för ACCESS databas
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("Select ID, Ovning from Ovningar", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        lstOvningar.Items.Clear()

        'Sålänge det finns rows att läsa, fyll ComboBox
        While myreader.Read
            Dim ID As Integer = myreader("ID")
            Dim Ovning As String = myreader("Ovning")
            lstOvningar.Items.Add(ID.ToString & " " & Ovning)
        End While
        conn.Close()

    End Sub
    Private Sub btnLaggTillOvning_Click(sender As Object, e As EventArgs) Handles btnLaggTillOvning.Click
        lstOvningar.Items.Add(txtOvning.Text)
    End Sub

    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub btnTabortOvningar_Click(sender As Object, e As EventArgs) Handles btnTabortOvningar.Click
        'Tar bort SelectedIndex från listan
        lstOvningar.Items.RemoveAt(lstOvningar.SelectedIndex)

        'Connection för ACCESS databas
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("DELETE FROM Ovningar WHERE ID = " & lstOvningar.Items(lstOvningar.SelectedItem("ID")), conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        lstOvningar.Items.Clear()


        'Disable tabort knapp efter tryck
        btnTabortOvningar.Enabled = False
    End Sub

    Private Sub lstOvningar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOvningar.SelectedIndexChanged

        'Disable tabort knapp efter tryck
        btnTabortOvningar.Enabled = True
    End Sub
End Class