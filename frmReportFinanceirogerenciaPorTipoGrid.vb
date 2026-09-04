Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportFinanceiroGerenciaPorTipoGrid

    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim data_inicial_date As DateTime
    Dim data_final_date As DateTime

    Dim data_inicial_string As String
    Dim data_final_string As String

    Private Sub frmReportFinanceiroGerenciaPorTipoGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor

        data_inicial_date = frmFinanceiroGerenciaPorTipoGrid.dtpDataInicial.Value
        data_final_date = frmFinanceiroGerenciaPorTipoGrid.dtpDataFinal.Value

        data_inicial_string = data_inicial_date.ToString("yyyy-MM-dd")
        data_final_string = data_final_date.ToString("yyyy-MM-dd")


        With frmFinanceiroGerenciaPorTipoGrid
            oReport.Load(caminhoreport & "financeirogerencia3.rpt")

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
                    oReport.ParameterFields.Item(1).CurrentValues.AddValue(data_inicial_string) 'DATA_INICIALao abri
                    oReport.ParameterFields.Item(2).CurrentValues.AddValue(data_final_string) 'DATA_FINAL

                Loop
                cn.Close()
            End If
            '*********************************************************************

            'oReport.SetDatabaseLogon("admin", "321654")

            CRVFinanceiroGerencia.ReportSource = oReport

        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub CRVFinanceiroGerencia_Load(sender As System.Object, e As System.EventArgs) Handles CRVFinanceiroGerencia.Load

    End Sub
End Class
