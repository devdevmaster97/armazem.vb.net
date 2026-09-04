Imports ARMAZEM.Principal
Imports System.Data.OleDb
Public Class frmReportRetirada
    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmReportRetirada_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmReportRetirada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        cn = GetConnection()
        sql(0) = "SELECT * FROM qRETIRADA WHERE RE = '" & frmRetirada.mskRE.Text & "'"
        Dim cmi As New OleDbCommand(sql(0), cn)
        da = New OleDbDataAdapter(cmi)
        da.Fill(ds, "qRETIRADA")
        oReport.Load(caminhoreport & "Retirada.rpt")
        oReport.SetDataSource(ds)
        '**************** BUSCA NOME DA EMPRASA ****************************
        sql(1) = "SELECT RAZAO, CNPJ, ENDERECO, BAIRRO, CIDADE, UF, INSCRICAO FROM DADOSEMPRESA"
        If cn.State = 0 Then cn.Open()
        Dim cmu As New OleDbCommand(sql(1), cn)
        Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
        If dr_usuario.HasRows Then
            Do While dr_usuario.Read
                oReport.ParameterFields.Item(0).CurrentValues.AddValue(dr_usuario.GetString(0))
                oReport.ParameterFields.Item(1).CurrentValues.AddValue(dr_usuario.GetString(1))
                oReport.ParameterFields.Item(2).CurrentValues.AddValue(dr_usuario.GetString(2))
                oReport.ParameterFields.Item(3).CurrentValues.AddValue(dr_usuario.GetString(3))
                oReport.ParameterFields.Item(4).CurrentValues.AddValue(dr_usuario.GetString(4))
                oReport.ParameterFields.Item(5).CurrentValues.AddValue(dr_usuario.GetString(5))
                oReport.ParameterFields.Item(6).CurrentValues.AddValue(dr_usuario.GetString(6))
            Loop
            cn.Close()
        End If
        '*********************************************************************
        oReport.SetDatabaseLogon("admin", "321654")
        CRVRetirada.ReportSource = oReport
        Cursor.Current = Cursors.Default
    End Sub
End Class
