Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports ARMAZEM.Principal
Imports System.Diagnostics
Friend Class Inicio
    Inherits System.Windows.Forms.Form
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dax As OleDbDataAdapter
    Dim dsx As DataSet

    Private Sub Inicio_Load(ByVal eventSender As System.Object, ByVal evetArgs As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        '**************** BUSCA NOME DA EMPRASA ****************************
        sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
        If cn.State = 0 Then cn.Open()
        Dim cmem As New OleDbCommand(sql(1), cn)
        Dim dr_empresa As OleDbDataReader = cmem.ExecuteReader
        If dr_empresa.HasRows Then
            Do While dr_empresa.Read
                Me.Text = "SISTEMA DE GESTÃO ESTOQUE E FINANCEIRO. Versão " & Application.ProductVersion & " - " & dr_empresa.GetString(0)
                If XLogonUser.User = "" And XLogonUser.Pass = "" Then
                    dr_empresa.Close()
                    cn.Close()
                    End
                End If
            Loop
            dr_empresa.Close()
            cn.Close()
        Else
            frmDadosEmpresa.ShowDialog()
        End If

        ToolStripStatusLabel1.Text = "Usuário logado : " & XLogonUser.User
        Cursor.Current = Cursors.Default
    End Sub

    '*************Pergunta se realmente deseja sair do Sistema*******************
    Private Sub Inicio_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean ' = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If UnloadMode <> 1 Then
            If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                Cancel = True
            End If
        End If
        eventArgs.Cancel = Cancel
        End
        'cn.Close()
    End Sub
    '****************************************************************************

    Private Sub DepositanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDepositante.Click
        frmDepositante.MdiParent = Me
        frmDepositante.Show()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEntrada.Click
        frmEntrada.MdiParent = Me
        frmEntrada.Show()
    End Sub

    Private Sub TSBSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBSair.Click
        End
    End Sub

    Private Sub TSBDepositante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBDepositante.Click
        frmDepositante.MdiParent = Me
        frmDepositante.Show()
    End Sub

    Private Sub TSBEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBEntrada.Click
        frmEntrada.MdiParent = Me
        frmEntrada.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        frmOrigem.MdiParent = Me
        frmOrigem.Show()
    End Sub

    Private Sub OPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPToolStripMenuItem.Click
        frmOperacao.MdiParent = Me
        frmOperacao.Show()
    End Sub

    Private Sub CobrançaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrançaToolStripMenuItem.Click
        frmCobranca.MdiParent = Me
        frmCobranca.Show()
    End Sub

    Private Sub OperaçãoCobrançaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçãoCobrançaToolStripMenuItem.Click
        frmOperacaoCobranca.MdiParent = Me
        frmOperacaoCobranca.Show()
    End Sub

    Private Sub SacariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SacariaToolStripMenuItem.Click
        frmSacaria.MdiParent = Me
        frmSacaria.Show()
    End Sub

    Private Sub TSBServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBServico.Click
        frmServico.MdiParent = Me
        frmServico.Show()
    End Sub

    Private Sub FinanceiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinanceiroToolStripMenuItem.Click
        frmFinanceiro.MdiParent = Me
        frmFinanceiro.Show()
    End Sub

    Private Sub TSBFinanceiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBFinanceiro.Click
        frmFinanceiro.MdiParent = Me
        frmFinanceiro.Show()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueToolStripMenuItem.Click
        frmReportEstoque.MdiParent = Me
        frmReportEstoque.Show()
    End Sub

    Private Sub MnuRetirada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuRetirada.Click
        frmRetirada.MdiParent = Me
        frmRetirada.Show()
    End Sub

    Private Sub TSBRetirada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBRetirada.Click
        frmRetirada.MdiParent = Me
        frmRetirada.Show()
    End Sub

    Private Sub SenhasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhasToolStripMenuItem.Click
        frmSenhas.MdiParent = Me
        frmSenhas.Show()
    End Sub

    Private Sub PermissãoesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissãoesToolStripMenuItem.Click
        frmPermissoes.MdiParent = Me
        frmPermissoes.Show()
    End Sub

    Private Sub FianceiroGerênciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FianceiroGerênciaToolStripMenuItem.Click
        frmFinanceiroGerencia.MdiParent = Me
        frmFinanceiroGerencia.Show()
    End Sub

    Private Sub FinanceiroPorColunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinanceiroPorColunaToolStripMenuItem.Click
        frmFinanceiroGerenciaPorTipo.MdiParent = Me
        frmFinanceiroGerenciaPorTipo.Show()
    End Sub

    Private Sub DadosDaEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DadosDaEmpresaToolStripMenuItem.Click
        frmDadosEmpresa.MdiParent = Me
        frmDadosEmpresa.Show()
    End Sub

    Private Sub IndustrializaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmIndustrializacao.MdiParent = Me
        frmIndustrializacao.Show()
    End Sub

    Private Sub EstoquePorOrdemDeFEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EstoquePorOrdemDeFEToolStripMenuItem.Click
        frmReportEstoqueOrdemFE.MdiParent = Me
        frmReportEstoqueOrdemFE.Show()
    End Sub

    Private Sub Industrialização2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Industrialização2ToolStripMenuItem.Click
        frmMovimentaçao_Depositante.MdiParent = Me
        frmMovimentaçao_Depositante.Show()
    End Sub

    Private Sub EstoquePorClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EstoquePorClienteToolStripMenuItem.Click
        frmReportEstoqueClienteEscolha.MdiParent = Me
        frmReportEstoqueClienteEscolha.Show()
    End Sub

    Private Sub EstoqueRetroativoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EstoqueRetroativoToolStripMenuItem.Click
        frmEstoqueRetroativo.MdiParent = Me
        frmEstoqueRetroativo.Show()
    End Sub

    Private Sub FinanceiroPorColunaGridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinanceiroPorColunaGridToolStripMenuItem.Click
        frmFinanceiroGerenciaPorTipoGrid.MdiParent = Me
        frmFinanceiroGerenciaPorTipoGrid.Show()
    End Sub

    Private Sub EntradaDiáriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EntradaDiáriaToolStripMenuItem.Click
        frmReportEntradaDiariaEscolha.MdiParent = Me
        frmReportEntradaDiariaEscolha.Show()
    End Sub

    Private Sub FinanceiroPorMêsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinanceiroPorMêsToolStripMenuItem.Click
        frmFinanceiroPorMes.MdiParent = Me
        frmFinanceiroPorMes.Show()
    End Sub

    Private Sub FinanceiroPorMês2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinanceiroPorMês2ToolStripMenuItem.Click
        frmFinanceiroGerenciaGrade.MdiParent = Me
        frmFinanceiroGerenciaGrade.Show()
    End Sub
End Class