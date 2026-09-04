Imports ARMAZEM.Principal
Imports System.Data.OleDb

Public Class frmIndustrializacaoRel

    Dim oReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmIndustrializacaoRel_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'sql(0) = "SELECT * FROM qTELA_PERMISSAO_USUARIO WHERE NOME_TELA = '" & Me.Name & "' AND NOME_USUARIO = '" & XLogonUser.User & "'"
        'If cn.State = 0 Then cn.Open()
        'Dim cm As New OleDbCommand(sql(0), cn)
        'Dim dr_usuario As OleDbDataReader = cm.ExecuteReader
        'If Not dr_usuario.HasRows Then
        ' MessageBox.Show("Você nao tem permissão para abrir esta tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' dr_usuario.Close()
        ' cn.Close()
        ' Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
        ' Exit Sub
        ' End If
        ' dr_usuario.Close()
        ' cn.Close()
    End Sub
    Private Sub CloseIt()
        Me.Close()
    End Sub
    Private Sub frmIndustrializacaoRel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        Dim datafiltroinicial As DateTime = frmIndustrializacao.dtpDataInicial.Text
        Dim datafiltrofinal As DateTime = frmIndustrializacao.dtpDataFinal.Text

        cn = GetConnection()
        sql(0) = "SELECT * FROM DEPOSITANTE WHERE DESCRI = '" & frmIndustrializacao.cboDepositante.Text & "'"
        Dim cmi As New OleDbCommand(sql(0), cn)
        da = New OleDbDataAdapter(cmi)
        da.Fill(ds, "DEPOSITANTE")

        oReport.Load(caminhoreport & "movimentacao.rpt")

        oReport.SetDataSource(ds)
        CRVEstoque.ReportSource = oReport
        oReport.SetDatabaseLogon("admin", "321654")

        oReport.ParameterFields.Item(0).CurrentValues.AddValue(frmIndustrializacao.dtpDataInicial.Text)
        oReport.ParameterFields.Item(1).CurrentValues.AddValue(frmIndustrializacao.dtpDataFinal.Text)


        oReport.RecordSelectionFormula = "{qINDUS.descri} = '" & frmIndustrializacao.cboDepositante.Text & "' AND {qINDUS.data_servico} in DateTime(" & Format(datafiltroinicial, "yyyy") & ", " & Format(datafiltroinicial, "MM") & ", " & Format(datafiltroinicial, "dd") & ", 0, 0, 0) to DateTime(" & Format(datafiltrofinal, "yyyy") & ", " & Format(datafiltrofinal, "MM") & ", " & Format(datafiltrofinal, "dd") & ", 0, 0, 0)"


        '  {qINDUS2.DATA} in DateTime (2011, 08, 01, 00, 00, 00) to DateTime (2011, 08, 30, 00, 00, 00)


        '**************** BUSCA NOME DA EMPRASA ****************************
        'sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
        'If cn.State = 0 Then cn.Open()
        'Dim cmu As New OleDbCommand(sql(1), cn)
        'Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
        'If dr_usuario.HasRows Then
        '    Do While dr_usuario.Read
        '        oReport.ParameterFields.Item(0).CurrentValues.AddValue(dr_usuario.GetString(0))
        '    Loop
        '    cn.Close()
        'End If
        '*********************************************************************


        Cursor.Current = Cursors.Default
    End Sub

    Private Sub frmIndustrializacaoRel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CRVEstoque.Top = 0
        CRVEstoque.Left = 0
        CRVEstoque.Height = Me.Height
        CRVEstoque.Width = Me.Width

    End Sub
End Class