Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportEstoqueCliente
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
    Public Sub New(ByVal id_depositante_ As Integer, nome_depositante_ As String, nota_ As Boolean, data1_ As String, data2_ As String)
        InitializeComponent()
        id_depositante = id_depositante_
        nome_depositante = nome_depositante_
        nota = nota_
        If IsDate(data1_) Then
            data1 = CDate(data1_)
        End If
        If IsDate(data2_) Then
            data2 = CDate(data2_)
        End If
    End Sub
    Private Sub frmReportEstoqueCliente_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmReportEstoqueCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If nota = False Then
            oReport.Load(caminhoreport & "EstoquePorCliente.rpt")
        Else
            oReport.Load(caminhoreport & "EstoquePorClienteNota.rpt")
        End If
        If IsDate(data1) And IsDate(data2) Then
            data1x = Mid(data1, 7, 4) & "," & Mid(data1, 4, 2) & "," & Mid(data1, 1, 2) & ", 00, 00, 00"
            data2x = Mid(data2, 7, 4) & "," & Mid(data2, 4, 2) & "," & Mid(data2, 1, 2) & ", 00, 00, 00"

            'DateTime (2018, 04, 01, 00, 00, 00)

            oReport.RecordSelectionFormula = "{qLOTES_SERVICO_RETIRADA.ID_DEPOSIT} = " & id_depositante & " AND {qLOTES_SERVICO_RETIRADA.DATA} IN DateTime(" & data1x & ") TO DateTime(" & data2x & ")"

        Else

            oReport.RecordSelectionFormula = "{qLOTES_SERVICO_RETIRADA.ID_DEPOSIT} = " & id_depositante & " AND {qLOTES_SERVICO_RETIRADA.SALDO_SACAS} > 0"

        End If
        CRVEstoque.ReportSource = oReport
        CRVEstoque.Refresh()
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
End Class