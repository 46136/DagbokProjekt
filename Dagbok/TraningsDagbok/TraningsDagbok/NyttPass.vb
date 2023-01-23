Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Security

Public Class NyttPass
    Private Sub NyttPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTabort.Enabled = False
        btnRedigera.Enabled = False
        txtReplace.Enabled = False
    End Sub

    Private Sub NyttPass_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub btnLaggTill_Click(sender As Object, e As EventArgs) Handles btnLaggTill.Click
        lstOvningar.Items.Add(cbOvning.Text)
        lstOvningar.Items.Add(txtRep.Text)
        lstOvningar.Items.Add(txtSet.Text)
        lstOvningar.Items.Add(txtVikt.Text + " Kg")
        lstOvningar.Items.Add(" ")
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        lstOvningar.Items.Add(dtpDatum.Text)
        lstOvningar.Items.Add(rtbAnteckningars.Text)
        lstOvningar.Items.Add(txtRPE.Text)
        lstOvningar.Items.Add(txtLangd.Text + " Min")
    End Sub

    Private Sub btnTabort_Click(sender As Object, e As EventArgs) Handles btnTabort.Click
        lstOvningar.Items.RemoveAt(lstOvningar.SelectedIndex)
        btnTabort.Enabled = False
    End Sub

    Private Sub lstOvningar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOvningar.SelectedIndexChanged
        btnTabort.Enabled = True
        btnRedigera.Enabled = True
        txtReplace.Enabled = True
    End Sub

    Private Sub btnRedigera_Click(sender As Object, e As EventArgs) Handles btnRedigera.Click
        lstOvningar.SelectedItem = txtReplace.Text
    End Sub

End Class