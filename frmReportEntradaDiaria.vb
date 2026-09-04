Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportEntradaDiaria
    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim id_depositante As Integer
    Dim nome_depositante As String
    Dim nota As String
    Dim lote As String
    Dim data1 As String = ""
    Dim data2 As String = ""
    Dim data1x As String
    Dim data2x As String
    Dim data_anterior As Date
    Public Sub New(ByVal id_depositante_ As Integer, nome_depositante_ As String, data1_ As String)
        InitializeComponent()
        id_depositante = id_depositante_
        nome_depositante = nome_depositante_

        If IsDate(data1_) Then
            data1 = CDate(data1_)
        End If

    End Sub
    Private Sub CloseIt()
        Me.Close()
    End Sub
    Private Sub frmReportEstoqueCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        oReport.Load(caminhoreport & "Entrada_diaria.rpt")
       
        If IsDate(data1) Then
            data1x = Mid(data1, 7, 4) & "," & Mid(data1, 4, 2) & "," & Mid(data1, 1, 2) & ", 00, 00, 00"


            'DateTime (2018, 04, 01, 00, 00, 00)

            oReport.RecordSelectionFormula = "{UNION_DIARIA.ID_DEPOSIT} = " & id_depositante & " AND {UNION_DIARIA.DATA} = DateTime(" & data1x & ")"
            data_anterior = CDate(data1)
            oReport.ParameterFields.Item(0).CurrentValues.AddValue(data1)
            oReport.ParameterFields.Item(1).CurrentValues.AddValue(data_anterior.AddDays(-1))
            CRVEstoque.ReportSource = oReport
            CRVEstoque.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If nota = False Then
            oReport.Load(caminhoreport & "EstoquePorCliente.rpt")
        Else
            oReport.Load(caminhoreport & "EstoquePorClienteNota.rpt")
        End If
        If IsDate(data1) And IsDate(data2) Then

            oReport.RecordSelectionFormula = "{qLOTES_SERVICO_RETIRADA.ID_DEPOSIT} = " & id_depositante & " AND {qLOTES_SERVICO_RETIRADA.DATA} IN #" & data1 & "# TO #" & data2 & "# AND {qLOTES_SERVICO_RETIRADA.LOTE} LIKE ""*" & txtLote.Text & "*"""

        Else

            oReport.RecordSelectionFormula = "{qLOTES_SERVICO_RETIRADA.ID_DEPOSIT} = " & id_depositante & " AND {qLOTES_SERVICO_RETIRADA.SALDO_SACAS} > 0 AND {qLOTES_SERVICO_RETIRADA.LOTE} LIKE ""*" & txtLote.Text & "*"""

        End If
        CRVEstoque.ReportSource = oReport
        CRVEstoque.Refresh()
    End Sub

    Private Sub CRVEstoque_Load(sender As System.Object, e As System.EventArgs) Handles CRVEstoque.Load

    End Sub
End Class