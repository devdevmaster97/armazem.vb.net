Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ARMAZEM.Principal

Friend Class frmCobranca
    Inherits System.Windows.Forms.Form
    Dim altera As Boolean
    Dim tabela_db As String = "COBRANCA"
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub frmCobranca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmCobranca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Arquivo = tabela_db
        Me.Text = tabela_db

        sql(0) = "SELECT * FROM " & tabela_db
        da = New OleDbDataAdapter(sql(0), GetConnection)
        da.Fill(ds, tabela_db)

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Nao existe nenhum(a) " & tabela_db & " cadastrado, cadastre o primeiro.", MsgBoxStyle.Information, fabricante)
        End If
        estadobotao("inicio")
        habilita(Me, False)
    End Sub
    Private Sub cmdCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastrar.Click
        limpa(Me)
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        txtDesc.Focus()
        altera = False
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
        Busca.Criterio = New TCriterio(1) {}
        Busca.Ncolunas = 1
        Busca.NumCrite = 0
        Busca.Numcampoinicial = 1
        Busca.Ordem = "DESCRI"
        Busca.OrdemAD = "ASC"

        Busca.Criterio(0).Nome = "ID"
        Busca.Criterio(0).Campo = "ID_COBRANCA"
        Busca.Criterio(0).Alinha = DataGridViewContentAlignment.MiddleRight
        Busca.Criterio(0).Numerico = False
        Busca.Criterio(0).LargCol = 40
        Busca.Criterio(0).Data = False
        Busca.Criterio(0).Formato = ""

        Busca.Criterio(1).Nome = "OPERACAO"
        Busca.Criterio(1).Campo = "DESCRI"
        Busca.Criterio(1).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(1).Numerico = False
        Busca.Criterio(1).LargCol = 350
        Busca.Criterio(1).Data = False
        Busca.Criterio(1).Formato = ""
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
            dr = ds.Tables(Arquivo).Select(Busca.Criterio(0).Campo & " = " & CriterioBusca)(0)

            dr.Delete()

            Dim cmb As New OleDbCommandBuilder(da)
            da.Update(ds, Arquivo)

            limpa(Me)
            estadobotao("inicio")
            MsgBox(tabela_db & " Excluído com sucesso!", MsgBoxStyle.Information, fabricante)
        End If
    End Sub
    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
    Private Sub txtDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDesc.Leave
        txtDesc.Text = UCase(txtDesc.Text)
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
        txtCodigo.Text = dr(Busca.Criterio(0).Campo)
        If Not IsDBNull(dr("descri")) Then txtDesc.Text = dr("descri")
    End Sub
    Private Sub Alterando()
        dr.BeginEdit()
        If txtDesc.Text <> "" Then dr("descri") = txtDesc.Text
        dr.EndEdit()
    End Sub
    Private Sub Incluindo()
        dr = ds.Tables(Arquivo).NewRow
        dr("descri") = txtDesc.Text
        ds.Tables(Arquivo).Rows.Add(dr)
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
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Then
                form.Controls(i).Text = ""
            End If
        Next i
    End Sub
End Class