Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportEstoqueRetroativo
    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim id_depositante As Integer
    Dim nome_depositante As String

    Public Sub New(ByVal id_depositante_ As Integer, nome_depositante_ As String)
        InitializeComponent()
        id_depositante = id_depositante_
        nome_depositante = nome_depositante_
    End Sub

    Private Sub frmReportEstoque_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmReportEstoque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        cn = GetConnection()

        sql(0) = "SELECT * FROM qLOTES_SERVICO_RETIRADA_TODOS WHERE ID_DEPOSIT = " & id_depositante & " ORDER BY LOTE ASC"
       
        Dim cmi As New OleDbCommand(sql(0), cn)
        da = New OleDbDataAdapter(cmi)
        da.Fill(ds, "qLOTES_SERVICO_RETIRADA_TODOS")
        oReport.Load(caminhoreport & "EstoqueRetroativo.rpt")
        oReport.SetDataSource(ds)
        '**************** BUSCA NOME DA EMPRASA ****************************
        sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
        If cn.State = 0 Then cn.Open()
        Dim cmu As New OleDbCommand(sql(1), cn)
        Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
        If dr_usuario.HasRows Then
            Do While dr_usuario.Read
                oReport.ParameterFields.Item(0).CurrentValues.AddValue(dr_usuario.GetString(0))
            Loop
            cn.Close()
        End If
        oReport.ParameterFields.Item(1).CurrentValues.AddValue(nome_depositante)
        '*********************************************************************
        oReport.SetDatabaseLogon("admin", "321654")
        CRVEstoque.ReportSource = oReport
        Cursor.Current = Cursors.Default
    End Sub

End Class