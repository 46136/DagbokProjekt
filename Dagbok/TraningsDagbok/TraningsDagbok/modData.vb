Imports System.Data.OleDb

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsAktiviteter As New DataSet
    Public daAktiviteter As OleDbDataAdapter

    Public Sub DbConnect()
        ' Kombinera sökvägar, databasens namn till dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Dagbok.accdb"
        Dim dbPath As String = "C:\GIT\DagbokProjekt\Databas"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String

        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data
        sql = "SELECT * FROM Aktiviteter"

        ' Koppla in dataadaptern och fyll
        daAktiviteter = New OleDbDataAdapter(sql, con)
        daAktiviteter.Fill(dsAktiviteter, "Adressbok")

    End Sub
End Module