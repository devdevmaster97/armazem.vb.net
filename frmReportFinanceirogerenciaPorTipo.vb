Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportFinanceiroGerenciaPorTipo

    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmReportFinanceiroGerenciaPorTipo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor

        With frmFinanceiroGerenciaPorTipo
            oReport.Load(caminhoreport & "financeirogerencia2.rpt")

            If .cboSituacao.Text = "PAGO" Then
                oReport.RecordSelectionFormula = "{qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & .dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"
            Else
                oReport.RecordSelectionFormula = "NOT {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & .dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"
            End If

            '**************** BUSCA NOME DA EMPRASA ****************************
            sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
            If cn.State = 0 Then cn.Open()
            Dim cmu As New OleDbCommand(sql(1), cn)
            Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
            If dr_usuario.HasRows Then
                Do While dr_usuario.Read
                    oReport.ParameterFields.Item(0).CurrentValues.AddValue(dr_usuario.GetString(0))
                    oReport.ParameterFields.Item(1).CurrentValues.AddValue(frmFinanceiroGerenciaPorTipo.dtpDataInicial.Value) 'DATA_INICIAL
                    oReport.ParameterFields.Item(2).CurrentValues.AddValue(frmFinanceiroGerenciaPorTipo.dtpDataFinal.Value) 'DATA_FINAL
                Loop
                cn.Close()
            End If
            '*********************************************************************

            oReport.SetDatabaseLogon("admin", "321654")

            CRVFinanceiroGerencia.ReportSource = oReport

        End With
        Cursor.Current = Cursors.Default
    End Sub
End Class
