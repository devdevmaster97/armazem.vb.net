Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportFinanceiroPorMes
    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmReportFinanceiroPorMes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor

        With frmFinanceiroPorMes
            oReport.Load(caminhoreport & "financeirogerencia6.rpt")


            oReport.RecordSelectionFormula = "{qCOBRANCA.DATA_SERVICO} IN DATETIME(" & .dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"

            '**************** BUSCA NOME DA EMPRASA ****************************
            sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
            If cn.State = 0 Then cn.Open()
            Dim cmu As New OleDbCommand(sql(1), cn)
            Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
            If dr_usuario.HasRows Then
                Do While dr_usuario.Read
                    'oReport.ParameterFields.Item(0).CurrentValues.AddValue(dr_usuario.GetString(0))
                    oReport.ParameterFields.Item(0).CurrentValues.AddValue(frmFinanceiroPorMes.dtpDataInicial.Value) 'DATA_INICIAL
                    oReport.ParameterFields.Item(1).CurrentValues.AddValue(frmFinanceiroPorMes.dtpDataFinal.Value) 'DATA_FINAL
                Loop
                cn.Close()
            End If
            '*********************************************************************


            oReport.SetDatabaseLogon("admin", "321654")

            CRVFinanceiroGerenciaPorMes.ReportSource = oReport

        End With
        Cursor.Current = Cursors.Default
    End Sub

End Class
