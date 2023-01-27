Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class NyttPass
    Private Sub NyttPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas.accdb
        'c:\GIT\DagbokProjekt\Databas\Dagbok.accdb

        'Connection för ACCESS databas
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand("Select Ovning from Ovningar", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        cbOvning.Items.Clear()

        'Sålänge det finns rows att läsa, fyll ComboBox
        While myreader.Read
            cbOvning.Items.Add(myreader("Ovning"))
        End While
        conn.Close()

        'Auto select första item i ComboBox
        If cbOvning.Items.Count > 0 Then
            cbOvning.SelectedIndex = 0
        End If

        'Disable Edit
        btnTabort.Enabled = False
        btnRedigera.Enabled = False
        txtReplace.Enabled = False
    End Sub

    Private Sub NyttPass_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub btnLaggTill_Click(sender As Object, e As EventArgs) Handles btnLaggTill.Click

        'Lägger till info i "Aktivt pass"
        lstOvningar.Items.Add(cbOvning.Text)
        lstOvningar.Items.Add(cbRep.Text)
        lstOvningar.Items.Add(cbSet.Text)
        lstOvningar.Items.Add(cbVikt.Text)
        lstOvningar.Items.Add(" ")
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click

        'Lägger till info i "Aktivt pass" NÄR MAN SPARAR
        lstOvningar.Items.Add(dtpDatum.Text)
        lstOvningar.Items.Add(rtbAnteckningars.Text)
        lstOvningar.Items.Add(cbRpe.Text)
        lstOvningar.Items.Add(txtLangd.Text)

        'Databas koppling
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=c:\GIT\DagbokProjekt\Databas\Dagbok.accdb")
        'C:\Users\Danie\Documents\GitHub\DagbokProjekt\Databas\Dagbok.accdb
        'c:\GIT\DagbokProjekt\Databas\Dagbok.accdb
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String

        'Fyller databas med infon från applikationens fällt
        sql = "INSERT INTO Traning " _
        &"(Ovning,Sat,Rep,Vikt,Datum,Anteckning,Tid, rpe ) VALUES " _
        & "('" _
        & Me.cbOvning.Text & "'," _
        & Me.cbSet.Text & "," _
        & Me.cbRep.Text & "," _
        & Me.cbVikt.Text & ",'" _
        & Me.dtpDatum.ToString & "','" _
        & Me.rtbAnteckningars.Text & "','" _
        & Me.txtLangd.Text & "', '" _
        & Me.cbRpe.Text & "');"

        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Sparat!")
        conn.Close()
    End Sub

    Private Sub btnTabort_Click(sender As Object, e As EventArgs) Handles btnTabort.Click
        'Tar bort SelectedIndex från listan
        lstOvningar.Items.RemoveAt(lstOvningar.SelectedIndex)

        'Disable tabort knapp efter tryck
        btnTabort.Enabled = False

    End Sub

    Private Sub lstOvningar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOvningar.SelectedIndexChanged

        'Enable alla editeringsknappar/fält när SelectedIndexChanged
        btnTabort.Enabled = True
        btnRedigera.Enabled = True
        txtReplace.Enabled = True

    End Sub

    Private Sub btnRedigera_Click(sender As Object, e As EventArgs) Handles btnRedigera.Click

        'Replace funktion för items i "Aktivt pass" listan
        lstOvningar.Items(lstOvningar.SelectedIndex) = txtReplace.Text
        txtReplace.Text = " "
    End Sub

End Class