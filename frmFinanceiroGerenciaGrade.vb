Imports ARMAZEM.Principal
Imports System.Data.OleDb

Public Class frmFinanceiroGerenciaGrade
    Private Sub frmFinanceiroGerenciaGrade_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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

    Private Sub cmdCarrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarrega.Click
        Cursor.Current = Cursors.WaitCursor
        frmReportFinanceirogerenciaGrade.Show()
    End Sub

    Private Sub frmFinanceiroGerenciaGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboSituacao.DataSource = {"NÃO PAGO", "PAGO", "TODOS"}
        dtpDataFinal.Value = Date.Now
        dtpDataInicial.Value = Date.Now

    End Sub
End Class