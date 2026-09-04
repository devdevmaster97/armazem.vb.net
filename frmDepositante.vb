Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ARMAZEM.Principal

Friend Class frmDepositante
    Inherits System.Windows.Forms.Form
    Dim altera As Boolean
    Dim tabela_db As String = "DEPOSITANTE"
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub frmDepositante_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmDepositante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Arquivo = tabela_db
        Me.Text = tabela_db


        sql(0) = "SELECT * FROM " & tabela_db
        da = New OleDbDataAdapter(sql(0), GetConnection)
        da.Fill(ds, tabela_db)

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Nao existe nenhum(a) " & tabela_db & " cadastrado, cadastre o primeiro.", MsgBoxStyle.Information, fabricante)
        End If
        Dim meses() As String = {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"}
        cboUf.DataSource = meses
        cboUf.SelectedIndex = 11
        mskCNPJ.Mask = "##,###,###/####-##"
        estadobotao("inicio")
        habilita(Me, False)
    End Sub
    Private Sub cmdCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastrar.Click
        limpa(Me)
        Dim bm As BindingManagerBase
        bm = BindingContext(ds, tabela_db)
        If bm.Count = 0 Then
            txtCodigo.Text = (1).ToString.PadLeft(4, "0"c)
        Else
            bm.Position = bm.Count
            Dim x1 As Int32 = Mid(ds.Tables(0).Rows(bm.Position).Item("ID").ToString(), 1, 4)


            
            sql(0) = "SELECT MAX(ID) as total FROM DEPOSITANTE"
            If cn.State = 0 Then cn.Open()
            Dim cm As New OleDbCommand(sql(0), cn)
            Dim dr_usuario As OleDbDataReader = cm.ExecuteReader
            'If Not dr_usuario.HasRows Then
            While dr_usuario.Read
                txtCodigo.Text = (dr_usuario("total") + 1)
            End While
            'End If


        End If

        habilita(Me, True)
        estadobotao("incluir/Salvar")
        txtDesc.Focus()
        altera = False
        cbo.Visible = True
        txtSaldoAnterior.Text = 0
        txtEntrada.Text = 0
        txtSaidaExportacao.Text = 0
        txtSaidaMercadoInterno.Text = 0
        txtSaidaTranferencia.Text = 0
        txtSaidaDevolucao.Text = 0

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If txtDesc.Text = "" Then
            MsgBox("Informe a razão social", MsgBoxStyle.Information)
            txtDesc.Focus()
        Else
            If altera = True Then
                Alterando()
                '******************* ATUALIZA DATASET ***********************************
                Dim cmb As New OleDbCommandBuilder(da)
                da.Update(ds, tabela_db)

                MsgBox(tabela_db & " alterado com sucesso!", MsgBoxStyle.Information, fabricante)
                altera = True
            Else
                Incluindo()
                '******************* ATUALIZA DATASET ***********************************
                Dim cmb As New OleDbCommandBuilder(da)
                da.Update(ds, tabela_db)

                MsgBox(tabela_db & " cadastrado com sucesso!", MsgBoxStyle.Information, fabricante)
                altera = True
            End If
            estadobotao("exibido")
            habilita(Me, False)
        End If
    End Sub
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        '*******************************PARAMETROS DA BUSCA***************************
        Busca.Criterio = New TCriterio(4) {}
        Busca.Ncolunas = 4
        Busca.NumCrite = 0
        Busca.Numcampoinicial = 1
        Busca.Ordem = "descri"
        Busca.OrdemAD = "ASC"

        Busca.Criterio(0).Nome = "ID"
        Busca.Criterio(0).Campo = "id"
        Busca.Criterio(0).Alinha = DataGridViewContentAlignment.MiddleRight
        Busca.Criterio(0).Numerico = False
        Busca.Criterio(0).LargCol = 40
        Busca.Criterio(0).Data = False
        Busca.Criterio(0).Formato = ""

        Busca.Criterio(1).Nome = "NOME DEPOSITANTE"
        Busca.Criterio(1).Campo = "descri"
        Busca.Criterio(1).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(1).Numerico = False
        Busca.Criterio(1).LargCol = 200
        Busca.Criterio(1).Data = False
        Busca.Criterio(1).Formato = "dd/MM/yyyy"

        Busca.Criterio(2).Nome = "ENDEREÇO"
        Busca.Criterio(2).Campo = "endereco"
        Busca.Criterio(2).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(2).Numerico = False
        Busca.Criterio(2).LargCol = 250
        Busca.Criterio(2).Data = False
        Busca.Criterio(2).Formato = ""

        Busca.Criterio(3).Nome = "NÚMERO"
        Busca.Criterio(3).Campo = "num"
        Busca.Criterio(3).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(3).Numerico = False
        Busca.Criterio(3).LargCol = 70
        Busca.Criterio(3).Data = False
        Busca.Criterio(3).Formato = ""

        Busca.Criterio(4).Nome = "CIDADE"
        Busca.Criterio(4).Campo = "cidade"
        Busca.Criterio(4).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(4).Numerico = False
        Busca.Criterio(4).LargCol = 200
        Busca.Criterio(4).Data = False
        Busca.Criterio(4).Formato = ""
        '***************************************************************************
        cn = GetConnection()
        CriterioBusca = "XXX"
        Arquivo = tabela_db
        frmbusca.ShowDialog()
        If CriterioBusca <> "XXX" Then
            sql(0) = "SELECT * FROM " & tabela_db & ""

            Dim cm As New OleDbCommand(sql(0), cn)

            da = New OleDbDataAdapter(cm)

            da.Fill(ds, tabela_db)

            dr = ds.Tables(tabela_db).Select(Busca.Criterio(0).Campo & " = " & CriterioBusca)(0)

            limpa(Me)

            Visualizando()

            altera = True

            estadobotao("exibido")
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
        altera = False
        estadobotao("inicio")
        limpa(Me)
        habilita(Me, False)
        cbo.Visible = True
    End Sub
    Private Sub cmdExcluir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdExcluir.Click
        Dim resp As String
        resp = MsgBox("Deseja realmente excluir esse registro?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            dr = ds.Tables(Arquivo).Select(Busca.Criterio(0).Campo & " = " & CriterioBusca)(0)

            dr.Delete()

            Dim cmb As New OleDbCommandBuilder(da)
            da.Update(ds, Arquivo)

            limpa(Me)
            estadobotao("inicio")
            MsgBox(tabela_db & " Excluído com sucesso!", MsgBoxStyle.Information, fabricante)
        End If
        cbo.Visible = True
    End Sub
    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
    Private Sub mskCNPJ_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mskCNPJ.Enter
        mskCNPJ.Mask = "##,###,###/####-##"
    End Sub
    Private Sub mskCNPJ_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCNPJ.Leave
        If mskCNPJ.Text <> "" Then
            If CheckCNPJ(mskCNPJ.Text) = False Then
                MsgBox("CNPJ inválido")
                mskCNPJ.Mask = ""
                mskCNPJ.Text = ""
                mskCNPJ.Mask = "##,###,###/####-##"
                mskCNPJ.Focus()
            Else
                txtInsc.Focus()
            End If
        End If
    End Sub
    Private Sub txtDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDesc.Leave
        txtDesc.Text = UCase(txtDesc.Text)
    End Sub
    Private Sub txtCidade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.Leave
        txtCidade.Text = UCase(txtCidade.Text)
    End Sub
    Private Sub txtEnd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnd.Leave
        txtEnd.Text = UCase(txtEnd.Text)
    End Sub
    Private Sub txtNum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNum.Leave
        txtNum.Text = UCase(txtNum.Text)
    End Sub
    Private Sub estadobotao(ByRef valor As String)
        If valor = "inicio" Then
            cmdCadastrar.Enabled = True
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = False
            cmdConsultar.Enabled = True
            CmdExcluir.Enabled = False
            cmdCancelar.Enabled = False
            cmdSair.Enabled = True
        ElseIf valor = "incluir/Salvar" Then
            cmdCadastrar.Enabled = False
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = True
            cmdConsultar.Enabled = False
            CmdExcluir.Enabled = False
            cmdCancelar.Enabled = True
            cmdSair.Enabled = False
        Else
            cmdCadastrar.Enabled = True
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cmdConsultar.Enabled = True
            CmdExcluir.Enabled = True
            cmdCancelar.Enabled = False
            cmdSair.Enabled = True
        End If
    End Sub
    Private Sub Visualizando()
        txtCodigo.Text = dr("id")
        If Not IsDBNull(dr("descri")) Then txtDesc.Text = dr("descri")
        If Not IsDBNull(dr("endereco")) Then txtEnd.Text = dr("endereco")
        If Not IsDBNull(dr("cidade")) Then txtCidade.Text = dr("cidade")
        If Not IsDBNull(dr("num")) Then txtNum.Text = dr("num")
        If Not IsDBNull(dr("cnpj")) Then mskCNPJ.Text = dr("cnpj")
        If Not IsDBNull(dr("ie")) Then txtInsc.Text = dr("ie")
        If Not IsDBNull(dr("uf")) Then cboUf.SelectedIndex = cboUf.FindString(dr("uf"))


        If Not IsDBNull(dr("saldo_anterior")) Then txtSaldoAnterior.Text = dr("saldo_anterior")
        If Not IsDBNull(dr("entrada")) Then txtEntrada.Text = dr("entrada")
        If Not IsDBNull(dr("saida_exportacao")) Then txtSaidaExportacao.Text = dr("saida_exportacao")
        If Not IsDBNull(dr("saida_minterno")) Then txtSaidaMercadoInterno.Text = dr("saida_minterno")
        If Not IsDBNull(dr("n_nota")) Then txtNNota.Text = dr("n_nota")
        If Not IsDBNull(dr("saida_devol")) Then txtSaidaDevolucao.Text = dr("saida_devol")
        If Not IsDBNull(dr("saida_tranfer")) Then txtSaidaTranferencia.Text = dr("saida_tranfer")
        If Not IsDBNull(dr("data_faturamento")) Then
            dtpDataFaturamento.Value = dr("data_faturamento")
        Else
            cbo.Visible = True
        End If
    End Sub
    Private Sub Alterando()
        dr.BeginEdit()
        If txtDesc.Text <> "" Then dr("descri") = txtDesc.Text
        If txtEnd.Text <> "" Then dr("endereco") = txtEnd.Text
        If txtNum.Text <> "" Then dr("num") = txtNum.Text
        If txtCidade.Text <> "" Then dr("cidade") = txtCidade.Text
        If cboUf.SelectedIndex <> 0 Then dr("uf") = cboUf.Text
        If mskCNPJ.Text <> "" Then dr("cnpj") = mskCNPJ.Text
        If txtInsc.Text <> "" Then dr("ie") = txtInsc.Text


        If txtSaldoAnterior.Text <> "" Then dr("saldo_anterior") = txtSaldoAnterior.Text
        If txtEntrada.Text <> "" Then dr("entrada") = txtEntrada.Text
        If txtSaidaExportacao.Text <> "" Then dr("saida_exportacao") = txtSaidaExportacao.Text
        If txtSaidaMercadoInterno.Text <> "" Then dr("saida_minterno") = txtSaidaMercadoInterno.Text
        If txtNNota.Text <> "" Then dr("n_nota") = txtNNota.Text
        If txtSaidaDevolucao.Text <> "" Then dr("saida_devol") = txtSaidaDevolucao.Text
        If txtSaidaTranferencia.Text <> "" Then dr("saida_tranfer") = txtSaidaTranferencia.Text
        If cbo.Visible = False Then
            dr("data_faturamento") = dtpDataFaturamento.Text
        Else
            dr("data_faturamento") = DBNull.Value
        End If
        dr.EndEdit()
    End Sub
    Private Sub Incluindo()
        dr = ds.Tables(Arquivo).NewRow

        dr("id") = txtCodigo.Text
        dr("descri") = txtDesc.Text
        dr("endereco") = txtEnd.Text
        dr("num") = txtNum.Text
        dr("cidade") = txtCidade.Text
        dr("uf") = cboUf.Text
        dr("cnpj") = mskCNPJ.Text
        dr("ie") = txtInsc.Text

        dr("saldo_anterior") = txtSaldoAnterior.Text
        dr("entrada") = txtEntrada.Text
        dr("saida_exportacao") = txtSaidaExportacao.Text
        dr("saida_minterno") = txtSaidaMercadoInterno.Text
        dr("n_nota") = txtNNota.Text
        dr("saida_devol") = txtSaidaDevolucao.Text
        dr("saida_tranfer") = txtSaidaTranferencia.Text
        If cbo.Visible = False Then
            dr("data_faturamento") = dtpDataFaturamento.Text
        Else
            dr("data_faturamento") = DBNull.Value
        End If
        ds.Tables(Arquivo).Rows.Add(dr)

    End Sub
    Private Sub habilita(ByVal form As Form, ByVal habil As Boolean)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DataGridView Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DateTimePicker Then
                form.Controls(i).Enabled = habil
            End If
        Next i
    End Sub
    Private Sub limpa(ByVal form As Form)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Then
                form.Controls(i).Text = ""
            End If
        Next i
        dtpDataFaturamento.Value = Date.Now
        cbo.Visible = False
    End Sub

    Private Sub cbo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo.Click
        cbo.Visible = False
    End Sub

    Private Sub cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.SelectedIndexChanged

    End Sub

    Private Sub dtpDataFaturamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDataFaturamento.KeyDown
        If e.KeyCode = 46 Then
            cbo.Visible = True
        End If
    End Sub
End Class