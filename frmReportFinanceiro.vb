Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportFinanceiro
    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmReportFinanceiro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        sql(0) = "SELECT * FROM qTELA_PERMISSAO_USUARIO WHERE NOME_TELA = '" & Me.Name & "' AND NOME_USUARIO = '" & XLogonUser.User & "'"
        If cn.State = 0 Then cn.Open()
        Dim cm As New OleDbCommand(sql(0), cn)
        Dim dr_usuario As OleDbDataReader = cm.ExecuteReader
        If Not dr_usuario.HasRows Then
            MessageBox.Show("Você nao tem permissão para abrir esta tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dr_usuario.Close()
            cn.Close()
            Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
            Exit Sub
        End If
        dr_usuario.Close()
        cn.Close()
    End Sub
    Private Sub CloseIt()
        Me.Close()
    End Sub
    Private Sub frmReportFinanceiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        With frmFinanceiro
            If .rbDetalhado.Checked = True Then
                oReport.Load(caminhoreport & "financeiro.rpt")
            Else
                oReport.Load(caminhoreport & "financeiroresumido.rpt")
            End If
            If frmFinanceiro.strin_sit = "NÃO PAGO" And Not IsNothing(frmFinanceiro.codig_depo) And IsNothing(frmFinanceiro.codig_cob) And IsNothing(frmFinanceiro.codig_ope) Then

                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_DEPOSITANTE} = " & frmFinanceiro.codigo_depositante & " AND NOT {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & .dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"

            ElseIf frmFinanceiro.strin_sit = "NÃO PAGO" And Not IsNothing(frmFinanceiro.codig_depo) And IsNothing(frmFinanceiro.codig_cob) And Not IsNothing(frmFinanceiro.codig_ope) Then

                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_DEPOSITANTE} = " & frmFinanceiro.codigo_depositante & " AND NOT {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & .dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ") AND {qCOBRANCA.ID_OPERACAO} = " & frmFinanceiro.codig_ope & ""

            ElseIf frmFinanceiro.strin_sit = "PAGO" And Not IsNothing(frmFinanceiro.codig_depo) And IsNothing(frmFinanceiro.codig_cob) And IsNothing(frmFinanceiro.codig_ope) Then


                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_DEPOSITANTE} = " & frmFinanceiro.codigo_depositante & " AND {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"


            ElseIf frmFinanceiro.strin_sit = "PAGO" And Not IsNothing(frmFinanceiro.codig_depo) And IsNothing(frmFinanceiro.codig_cob) And Not IsNothing(frmFinanceiro.codig_ope) Then


                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_DEPOSITANTE} = " & frmFinanceiro.codigo_depositante & " AND {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ") AND {qCOBRANCA.ID_OPERACAO} = " & frmFinanceiro.codig_ope & ""

            ElseIf frmFinanceiro.strin_sit = "NÃO PAGO" And IsNothing(frmFinanceiro.codig_depo) And Not IsNothing(frmFinanceiro.codig_cob) And IsNothing(frmFinanceiro.codig_ope) Then


                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_COB} = " & frmFinanceiro.codig_cob & " AND NOT {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"

            ElseIf frmFinanceiro.strin_sit = "NÃO PAGO" And IsNothing(frmFinanceiro.codig_depo) And Not IsNothing(frmFinanceiro.codig_cob) And Not IsNothing(frmFinanceiro.codig_ope) Then


                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_COB} = " & frmFinanceiro.codig_cob & " AND NOT {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ") AND {qCOBRANCA.ID_OPERACAO} = " & frmFinanceiro.codig_ope & ""

            ElseIf frmFinanceiro.strin_sit = "PAGO" And IsNothing(frmFinanceiro.codig_depo) And Not IsNothing(frmFinanceiro.codig_cob) And Not IsNothing(frmFinanceiro.codig_ope) Then


                oReport.RecordSelectionFormula = "{qCOBRANCA.ID_COB} = " & frmFinanceiro.codig_cob & " AND {qCOBRANCA.PAGO} AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ") AND {qCOBRANCA.ID_OPERACAO} = " & frmFinanceiro.codig_ope & ""

            ElseIf frmFinanceiro.strin_sit = "PAGO" And IsNothing(frmFinanceiro.codig_depo) And Not IsNothing(frmFinanceiro.codig_cob) And IsNothing(frmFinanceiro.codig_ope) Then

                sql(0) = "SELECT * FROM qCOBRANCA WHERE ID_DEPOSITANTE = " & frmFinanceiro.codigo_depositante & " AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ")"

            Else
                sql(0) = "SELECT * FROM qCOBRANCA WHERE ID_DEPOSITANTE = " & frmFinanceiro.codig_depo & " AND {qCOBRANCA.DATA_SERVICO} IN DATETIME(" & frmFinanceiro.dtpDataInicial.Value.ToString("yyyy, M, d") & ") TO DATE(" & .dtpDataFinal.Value.ToString("yyyy, M, d") & ") AND {qCOBRANCA.ID_OPERACAO} = " & frmFinanceiro.codig_ope & ""

            End If

            'oReport.Load(caminhoreport & "financeiroresumido.rpt")
            'sql(0) = "SELECT DESCRI_OPERACAO, SUM(TOTAL) AS VALOR_TOTAL, SUM(SACAS) AS TOTAL_SACAS, ID_COB "

            'sql(0) = sql(0) & "FROM qCOBRANCA WHERE DATA_SERVICO >= #" & .dtpDataInicial.Value.ToString("M/d/yyyy") & "# AND DATA_SERVICO <= #" & .dtpDataFinal.Value.ToString("M/d/yyyy") & "# AND ID_COB = " & frmFinanceiro.codig_cob & " AND PAGO = FALSE "

            'sql(0) = sql(0) & "GROUP BY DESCRI_OPERACAO, ID_COB"


            'Dim cmi As New OleDbCommand(sql(0), cn)
            'da = New OleDbDataAdapter(cmi)
            'da.Fill(ds, "qCOBRANCA")
            'oReport.SetDataSource(ds)
            If Not IsNothing(frmFinanceiro.strin_cob) And IsNothing(frmFinanceiro.strin_depo) Then
                oReport.SetParameterValue(0, frmFinanceiro.strin_cob)
                oReport.SetParameterValue(1, "")
            ElseIf IsNothing(frmFinanceiro.strin_cob) And Not IsNothing(frmFinanceiro.strin_depo) Then
                oReport.SetParameterValue(0, frmFinanceiro.strin_depo)
                oReport.SetParameterValue(1, "")
            ElseIf Not IsNothing(frmFinanceiro.strin_cob) And Not IsNothing(frmFinanceiro.strin_depo) Then
                oReport.SetParameterValue(0, frmFinanceiro.strin_depo)
                oReport.SetParameterValue(1, frmFinanceiro.strin_cob)
            End If
            oReport.SetParameterValue(2, frmFinanceiro.dtpDataInicial.Text)
            oReport.SetParameterValue(3, frmFinanceiro.dtpDataFinal.Text)


            oReport.SetDatabaseLogon("admin", "321654")

            CRVFinanceiro.ReportSource = oReport

        End With
        Cursor.Current = Cursors.Default
    End Sub
End Class
