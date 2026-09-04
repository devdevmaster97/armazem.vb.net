Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class AcessoBD

    Shared connectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\dados\db.mdb"

    Function listarEntradaTodos() As DataSet
        Dim con As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim sSQL As String
        sSQL = "EXECUTE SP_ENTRADA_TODOS"

        con = New OleDbConnection(connectionString)
        da = New OleDbDataAdapter(sSQL, con)
        ds = New DataSet
        da.Fill(ds, "ENTRADA")
        Return ds
    End Function

    Function listarEntradaCodigo(ByVal FE As String) As DataRow
        Dim sSQL As String = "SP_ENTRADA_FE"
        Dim DR As DataRow
        Dim TabelaEntrada As DataTable

        Dim CMD As OleDbCommand = New OleDbCommand(sSQL)

        CMD.Parameters.AddWithValue("@ID_FE", FE)

        TabelaEntrada = GetData(CMD)

        DR = TabelaEntrada.Rows(0)
        Return DR
    End Function
    Function listarLotes(ByVal ID As String) As DataTable
        Dim sSQL As String = "SP_LOTES"
        Dim TabelaEntrada As DataTable

        Dim CMD As OleDbCommand = New OleDbCommand(sSQL)

        CMD.Parameters.AddWithValue("@ID_ENTRADA", ID)

        TabelaEntrada = GetData(CMD)

        Return TabelaEntrada
    End Function

    Function GetData(ByVal cmd As OleDbCommand) As DataTable
        Dim dt As New DataTable
        Dim con As New OleDbConnection(connectionString)
        Dim sda As New OleDbDataAdapter
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        Try
            con.Open()
            sda.SelectCommand = cmd
            sda.Fill(dt)
            Return dt
        Catch ex As Exception
            Console.Write(ex.Message)
            Return Nothing
        Finally
            con.Close()
            sda.Dispose()
            con.Dispose()
        End Try
    End Function
End Class
