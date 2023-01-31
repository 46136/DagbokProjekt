Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Ovningar

    Dim ID As Integer
    Public Sub Ovningar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection för ACCESS databas
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("Select ID, Ovning from Ovningar", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        cbOvning.Items.Clear()

        'Sålänge det finns rows att läsa, fyll lista
        While myreader.Read
            ID = myreader("ID")
            Dim Ovning As String = myreader("Ovning")
            cbOvning.Items.Add(ID.ToString & " " & Ovning)
        End While

        conn.Close()

        'Auto select första item i ComboBox
        If cbOvning.Items.Count > 0 Then
            cbOvning.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnLaggTillOvning_Click(sender As Object, e As EventArgs) Handles btnLaggTillOvning.Click
        cbOvning.Items.Add(txtOvning.Text)


    End Sub

    Private Sub Ovningar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Public Sub btnTabortOvningar_Click(sender As Object, e As EventArgs) Handles btnTabortOvningar.Click
        'Tar bort SelectedIndex från listan
        cbOvning.Items.RemoveAt(cbOvning.SelectedIndex)

        'Connection för ACCESS databas
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("DELETE FROM Ovningar WHERE ID =" & ID & " ", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader

        'Disable tabort knapp efter tryck
        btnTabortOvningar.Enabled = False
    End Sub

    Private Sub cbOvning_SelectedIndexChanged(sender As Object, e As EventArgs)

        'Enable Ta bort knapp om Selected Index
        btnTabortOvningar.Enabled = True
    End Sub
End Class