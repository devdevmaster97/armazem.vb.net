Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ARMAZEM.Principal

Friend Class frmOperacaoCobranca
    Inherits System.Windows.Forms.Form
    Dim altera As Boolean
    Dim tabela_opcob As String = "OPERACAO_COBRANCA"
    Dim tabela_op As String = "OPERACAO"
    Dim tabela_cob As String = "COBRANCA"
    Dim tabela_consulta As String = "qOPERACAO_COBRANCA"

    Dim dsopcob As New DataSet
    Dim daopcob As New OleDbDataAdapter
    Dim dropcob As DataRow

    Dim dsop As New DataSet
    Dim daop As New OleDbDataAdapter

    Dim dscob As New DataSet
    Dim dacob As New OleDbDataAdapter
    Private Sub frmOperacaoCobranca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmOperacao_Cobranca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = tabela_opcob

        sql(0) = "SELECT * FROM " & tabela_opcob
        daopcob = New OleDbDataAdapter(sql(0), GetConnection)
        daopcob.Fill(dsopcob, tabela_opcob)

        sql(0) = "SELECT * FROM " & tabela_op & " ORDER BY DESCRI"
        daop = New OleDbDataAdapter(sql(0), GetConnection)
        daop.Fill(dsop, tabela_op)

        sql(0) = "SELECT * FROM " & tabela_cob & " ORDER BY DESCRI"
        dacob = New OleDbDataAdapter(sql(0), GetConnection)
        dacob.Fill(dscob, tabela_cob)
        '******************PREENCHE COMBO OPERACAO***************************
        cboOperacao.DataSource = dsop.Tables(tabela_op)
        cboOperacao.DisplayMember = "DESCRI"
        cboOperacao.ValueMember = "ID_OPERACAO"
        '******************PREENCHE COMBO COBRANCA***************************
        cboCobranca.DataSource = dscob.Tables(tabela_cob)
        cboCobranca.DisplayMember = "DESCRI"
        cboCobranca.ValueMember = "ID_COBRANCA"

        cboTipo.Items.Clear()
        cboTipo.Items.Add("")
        cboTipo.Items.Add("LIGA")
        cboTipo.Items.Add("REBENEFICIO")

        If dsopcob.Tables(0).Rows.Count = 0 Then MsgBox("Nao existe nenhum(a) " & tabela_opcob & " cadastrado, cadastre o primeiro.", MsgBoxStyle.Information, fabricante)
        limpa(Me)
        estadobotao("inicio")
        habilita(Me, False)
    End Sub
    Private Sub cmdCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastrar.Click
        limpa(Me)
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        cboOperacao.Focus()
        altera = False
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If altera = True Then Alterando() Else Incluindo()
        '******************* ATUALIZA DATASET OPERACAO_COBRANCA***********************************
        Dim cmbopcob As New OleDbCommandBuilder(daopcob)
        daopcob.Update(dsopcob, tabela_opcob)

        '******************* ATUALIZA DATASET OPERACAO********************************************
        Dim cmbop As New OleDbCommandBuilder(daop)
        daop.Update(dsop, tabela_op)

        '******************* ATUALIZA DATASET COBRANCA********************************************
        Dim cmbcob As New OleDbCommandBuilder(dacob)
        dacob.Update(dscob, tabela_cob)
        '...
        '*****************************************************************************************
        MsgBox(tabela_opcob & " atualizado com sucesso!", MsgBoxStyle.Information, fabricante)
        altera = True

        estadobotao("exibido")
        habilita(Me, False)
    End Sub
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        '*******************************PARAMETROS DA BUSCA***************************
        Busca.Criterio = New TCriterio(4) {}
        Busca.Ncolunas = 3
        Busca.NumCrite = 0
        Busca.Numcampoinicial = 1
        Busca.Ordem = "DESCRI_OPERACAO"
        Busca.OrdemAD = "ASC"

        Busca.Criterio(0).Nome = "ID"
        Busca.Criterio(0).Campo = "ID_OPER_COB"
        Busca.Criterio(0).Alinha = DataGridViewContentAlignment.MiddleRight
        Busca.Criterio(0).Numerico = False
        Busca.Criterio(0).LargCol = 40
        Busca.Criterio(0).Data = False
        Busca.Criterio(0).Formato = ""

        Busca.Criterio(1).Nome = "OPERACAO"
        Busca.Criterio(1).Campo = "DESCRI_OPERACAO"
        Busca.Criterio(1).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(1).Numerico = False
        Busca.Criterio(1).LargCol = 200
        Busca.Criterio(1).Data = False
        Busca.Criterio(1).Formato = "dd/MM/yyyy"

        Busca.Criterio(2).Nome = "COBRANCA"
        Busca.Criterio(2).Campo = "DESCRI_COBRANCA"
        Busca.Criterio(2).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(2).Numerico = False
        Busca.Criterio(2).LargCol = 250
        Busca.Criterio(2).Data = False
        Busca.Criterio(2).Formato = ""

        Busca.Criterio(3).Nome = "VALOR"
        Busca.Criterio(3).Campo = "VALOR"
        Busca.Criterio(3).Alinha = DataGridViewContentAlignment.MiddleRight
        Busca.Criterio(3).Numerico = True
        Busca.Criterio(3).LargCol = 100
        Busca.Criterio(3).Data = False
        Busca.Criterio(3).Formato = "#,##0.00"
        '***************************************************************************
        cn = GetConnection()
        CriterioBusca = "XXX"
        Arquivo = tabela_consulta
        frmbusca.ShowDialog()
        If CriterioBusca <> "XXX" Then
            sql(0) = "SELECT * FROM " & tabela_opcob & ""
            Dim cmopcob As New OleDbCommand(sql(0), cn)
            daopcob = New OleDbDataAdapter(cmopcob)
            daopcob.Fill(dsopcob, tabela_opcob)

            dropcob = dsopcob.Tables(tabela_opcob).Select(Busca.Criterio(0).Campo & " = " & CriterioBusca)(0)

            '***********************preenche o combo operacao**********************************
            cboOperacao.DataSource = dsop.Tables(tabela_op)
            cboOperacao.DisplayMember = "DESCRI"
            cboOperacao.ValueMember = "ID_OPERACAO"
            cboOperacao.SelectedValue = dropcob("ID_OPERACAO")
            '***********************preenche o combo cobranca**********************************
            cboCobranca.DataSource = dscob.Tables(tabela_cob)
            cboCobranca.DisplayMember = "DESCRI"
            cboCobranca.ValueMember = "ID_COBRANCA"
            cboCobranca.SelectedValue = dropcob("ID_COBRANCA")

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
    End Sub
    Private Sub cmdExcluir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdExcluir.Click
        Dim resp As String
        resp = MsgBox("Deseja realmente excluir esse registro?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            '********************EXCLUI DA TABELA OPERACAO_COBRANCA****************************************
            dropcob = dsopcob.Tables(tabela_opcob).Select(Busca.Criterio(0).Campo & " = " & CriterioBusca)(0)
            dropcob.Delete()
            Dim cmb As New OleDbCommandBuilder(daopcob)
            daopcob.Update(dsopcob, tabela_opcob)

            limpa(Me)
            estadobotao("inicio")
            MsgBox(tabela_opcob & " Excluído com sucesso!", MsgBoxStyle.Information, fabricante)
        End If
    End Sub
    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        Dim strtexto As String
        Dim strtexto1 As String
        Dim strtexto2 As String
        'AO PRESCIONAR ENTER MUDA O FOCO PARA cmdSalvar
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            cmdSalvar.Focus()
        End If
        'formata virgula
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And e.KeyChar = "," Then
            e.Handled = True
        Else

            If e.KeyChar = vbBack Then
                e.Handled = False
            Else

                If txtValor.TextLength >= 3 And txtValor.Text.Contains(",") Then

                    If txtValor.Text.Length = 4 And txtValor.Text.IndexOf("0") = 0 Then

                        strtexto1 = txtValor.Text.Remove(0, 1)
                        txtValor.Text = strtexto1

                    End If
                    e.Handled = True
                    strtexto = txtValor.Text.Trim
                    strtexto1 = strtexto.Remove(strtexto.IndexOf(","), 1)
                    strtexto2 = strtexto1 + e.KeyChar

                    txtValor.Text = strtexto2.Insert(strtexto.Length - 2, ",")

                ElseIf txtValor.TextLength = 2 Then

                    e.Handled = True
                    If Not txtValor.Text.Contains(",") Then
                        strtexto = txtValor.Text.Trim
                        strtexto = txtValor.Text.Insert(strtexto.Length - 2, ",")
                        strtexto1 = strtexto.Remove(strtexto.IndexOf(","), 1)
                        strtexto2 = strtexto1 + e.KeyChar
                        txtValor.Text = strtexto2.Insert(strtexto.Length - 2, ",")
                    End If

                Else
                    e.Handled = False
                End If
                txtValor.SelectionStart = txtValor.TextLength
            End If
        End If
    End Sub
    Private Sub txtDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtValor.Leave
        txtValor.Text = UCase(txtValor.Text)
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
        txtCodigo.Text = dropcob("ID_OPER_COB")
        If Not IsDBNull(dropcob("ID_OPERACAO")) Then cboOperacao.SelectedValue = dropcob("ID_OPERACAO")
        If Not IsDBNull(dropcob("ID_COBRANCA")) Then cboCobranca.SelectedValue = dropcob("ID_COBRANCA")
        If Not IsDBNull(dropcob("VALOR")) Then txtValor.Text = dropcob("VALOR") Else txtValor.Text = ""
        If Not IsDBNull(dropcob("VALOR_INDUS")) Then txtValorIndus.Text = dropcob("VALOR_INDUS") Else txtValorIndus.Text = ""
        If dropcob("TIPO") Is DBNull.Value Then
            cboTipo.SelectedIndex = 0
        ElseIf dropcob("TIPO") = "L" Then
            cboTipo.SelectedIndex = cboTipo.Items.IndexOf("LIGA")
        ElseIf dropcob("TIPO") = "R" Then
            cboTipo.SelectedIndex = cboTipo.Items.IndexOf("REBENEFICIO")
        End If
    End Sub
    Private Sub Alterando()
        dropcob.BeginEdit()
        If cboOperacao.SelectedValue <> 0 Then dropcob("ID_OPERACAO") = cboOperacao.SelectedValue
        If cboCobranca.SelectedValue <> 0 Then dropcob("ID_COBRANCA") = cboCobranca.SelectedValue
        If txtValor.Text <> "" Then dropcob("VALOR") = txtValor.Text Else txtValor.Text = ""
        If txtValorIndus.Text <> "" Then dropcob("VALOR_INDUS") = txtValorIndus.Text Else txtValorIndus.Text = ""
        If cboTipo.Text = "" Then
            dropcob("TIPO") = DBNull.Value
        ElseIf cboTipo.Text = "LIGA" Then
            dropcob("TIPO") = "L"
        ElseIf cboTipo.Text = "REBENEFICIO" Then
            dropcob("TIPO") = "R"
        End If
        dropcob.EndEdit()
    End Sub
    Private Sub Incluindo()
        dropcob = dsopcob.Tables(tabela_opcob).NewRow
        dropcob("ID_OPERACAO") = cboOperacao.SelectedValue
        dropcob("ID_COBRANCA") = cboCobranca.SelectedValue
        If txtValor.Text <> "" Then
            dropcob("VALOR") = txtValor.Text
        Else
            dropcob("VALOR") = DBNull.Value
        End If
        If txtValorIndus.Text <> "" Then
            dropcob("VALOR_INDUS") = txtValorIndus.Text
        Else
            dropcob("VALOR_INDUS") = DBNull.Value
        End If
        If cboTipo.Text = "" Then
            dropcob("TIPO") = DBNull.Value
        ElseIf cboTipo.Text = "LIGA" Then
            dropcob("TIPO") = "L"
        ElseIf cboTipo.Text = "REBENEFICIO" Then
            dropcob("TIPO") = "R"
        End If
        dsopcob.Tables(tabela_opcob).Rows.Add(dropcob)
    End Sub
    Private Sub habilita(ByVal form As Form, ByVal habil As Boolean)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DataGridView Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Then
                form.Controls(i).Enabled = habil
            End If
        Next i
    End Sub
    Private Sub limpa(ByVal form As Form)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Then
                form.Controls(i).Text = ""
            End If
        Next i
    End Sub
    Private Sub cboOperacao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOperacao.KeyUp
        AutoCompleteCombo_KeyUp(cboOperacao, e)
    End Sub
    Private Sub cboCobranca_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCobranca.KeyUp
        AutoCompleteCombo_KeyUp(cboCobranca, e)
    End Sub

    Private Sub cboOperacao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOperacao.Leave
        AutoCompleteCombo_Leave(cboOperacao)
    End Sub

End Class