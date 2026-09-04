Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ARMAZEM.Principal

Friend Class frmDadosEmpresa
    Inherits System.Windows.Forms.Form
    Dim altera As Boolean
    Dim tabela_db As String = "DADOSEMPRESA"
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub CloseIt()
        Me.Close()
    End Sub

    Private Sub frmDadosEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            SendKeys.Send("{TAB}")
            e.Handled = True 'Para remover aquele som...
        End If
    End Sub
    Private Sub frmDadosEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        If Not IsNothing(XLogonUser.User) Then
            sql(0) = "SELECT * FROM qTELA_PERMISSAO_USUARIO WHERE NOME_TELA = '" & Me.Name & "' AND NOME_USUARIO = '" & XLogonUser.User & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmop As New OleDbCommand(sql(0), cn)
            Dim dr_usuario_permissao As OleDbDataReader = cmop.ExecuteReader
            If Not dr_usuario_permissao.HasRows Then
                MessageBox.Show("Você nao tem permissão para abrir esta tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr_usuario_permissao.Close()
                cn.Close()
                Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
                Exit Sub
            End If
            dr_usuario_permissao.Close()
            cn.Close()
        End If
        Arquivo = tabela_db


        Me.Text = "DADOS DA SUA EMPRESA"
        Dim meses() As String = {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"}
        cboUf.DataSource = meses
        cboUf.SelectedIndex = 11

        sql(0) = "SELECT * FROM " & tabela_db & " WHERE ID > 0"
        If cn.State = 0 Then cn.Open()
        Dim cm As New OleDbCommand(sql(0), cn)
        Dim dr_empresa As OleDbDataReader = cm.ExecuteReader

        If Not dr_empresa.HasRows Then
            sql(3) = "SELECT * FROM " & tabela_db
            da = New OleDbDataAdapter(sql(3), GetConnection)
            da.Fill(ds, tabela_db)

            limpa(Me)
            habilita(Me, True)
            estadobotao("incluir/Salvar")
            txtRazao.Focus()
            altera = False
            txtRazao.Focus()
        Else
            sql(2) = "SELECT * FROM " & tabela_db
            Dim cmx As New OleDbCommand(sql(2), cn)
            da = New OleDbDataAdapter(cmx)

            da.Fill(ds, tabela_db)
            Do While dr_empresa.Read
                dr = ds.Tables(tabela_db).Select("ID = " & dr_empresa.GetInt32(0))(0)
            Loop
            Visualizando()
            Label9.Text = "DADOS DA SUA EMPRESA"
            altera = True

            estadobotao("exibido")
            habilita(Me, False)
            estadobotao("inicio")
            altera = True
            txtRazao.Focus()
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        Cursor.Current = Cursors.WaitCursor
        If txtRazao.Text = "" Then
            MsgBox("Informe a razão social", MsgBoxStyle.Information)
            txtRazao.Focus()
        ElseIf txtFantasia.Text = "" Then
            MsgBox("Informe o nome fantasia", MsgBoxStyle.Information)
            txtFantasia.Focus()
        ElseIf txtEnd.Text = "" Then
            MsgBox("Informe o endereço", MsgBoxStyle.Information)
            txtEnd.Focus()
        ElseIf txtBairro.Text = "" Then
            MsgBox("Informe o bairro", MsgBoxStyle.Information)
            txtBairro.Focus()
        ElseIf mskCep.Text = "  .   -" Then
            MsgBox("Informe o cep", MsgBoxStyle.Information)
            mskCep.Focus()
        ElseIf txtCidade.Text = "" Then
            MsgBox("Informe a cidade", MsgBoxStyle.Information)
            txtCidade.Focus()
        ElseIf cboUf.Text = "" Then
            MsgBox("Informe o estado", MsgBoxStyle.Information)
            cboUf.Focus()
        ElseIf mskCNPJ.Text = "" Then
            MsgBox("Informe o cnpj", MsgBoxStyle.Information)
            mskCNPJ.Focus()
        ElseIf txtEmail.Text = "" Then
            MsgBox("Informe o e-mail", MsgBoxStyle.Information)
            txtEmail.Focus()
        ElseIf mskTel.Text = "" Then
            MsgBox("Informe o telefone", MsgBoxStyle.Information)
            mskTel.Focus()
        Else
            If altera = True Then
                Alterando()
                '******************* ATUALIZA DATASET ***********************************
                Dim cmb As New OleDbCommandBuilder(da)
                da.Update(ds, tabela_db)

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information, fabricante)
                altera = True
                Me.Close()
            Else
                Incluindo()
                '******************* ATUALIZA DATASET ***********************************
                Dim cmb As New OleDbCommandBuilder(da)
                da.Update(ds, tabela_db)
                MsgBox("Dados cadastrado com sucesso!", MsgBoxStyle.Information, fabricante)
                MsgBox("Usuário administrador : adm , Senha : 123", MsgBoxStyle.Information, fabricante)
                Me.Close()
                frmLogin.ShowDialog()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        If txtRazao.Text = "" Or txtFantasia.Text = "" Then
            End
        Else
            Me.Close()
        End If
    End Sub
    Private Sub mskCNPJ_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mskCNPJ.Enter
        mskCNPJ.Mask = "##,###,###/####-##"
    End Sub
    Private Sub mskCNPJ_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCNPJ.GotFocus
        mskCNPJ.SelectAll()
    End Sub
    Private Sub mskCNPJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskCNPJ.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtIe.Focus()
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
                txtIe.Focus()
            End If
        End If
    End Sub
    Private Sub txtRazao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazao.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtFantasia.Focus()
    End Sub
    Private Sub txtDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRazao.Leave
        txtRazao.Text = UCase(txtRazao.Text)
    End Sub
    Private Sub txtCidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCidade.KeyPress
        If (e.KeyChar = ChrW(13)) Then cboUf.Focus()
    End Sub
    Private Sub txtCidade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.Leave
        txtCidade.Text = UCase(txtCidade.Text)
    End Sub
    Private Sub txtEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnd.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtBairro.Focus()
    End Sub
    Private Sub txtEnd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnd.Leave
        txtEnd.Text = UCase(txtEnd.Text)
    End Sub
    Private Sub estadobotao(ByRef valor As String)
        If valor = "inicio" Then
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cmdSair.Enabled = True
        ElseIf valor = "incluir/Salvar" Then
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = True
            cmdSair.Enabled = True
        Else
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cmdSair.Enabled = True
        End If
    End Sub
    Private Sub Visualizando()
        If Not IsDBNull(dr("razao")) Then txtRazao.Text = dr("razao")
        If Not IsDBNull(dr("fantasia")) Then txtFantasia.Text = dr("fantasia")
        If Not IsDBNull(dr("endereco")) Then txtEnd.Text = dr("endereco")
        If Not IsDBNull(dr("cidade")) Then txtCidade.Text = dr("cidade")
        If Not IsDBNull(dr("bairro")) Then txtBairro.Text = dr("bairro")
        If Not IsDBNull(dr("cnpj")) Then mskCNPJ.Text = dr("cnpj")
        If Not IsDBNull(dr("CEP")) Then mskCep.Text = dr("CEP")
        If Not IsDBNull(dr("tel")) Then mskTel.Text = dr("tel")
        If Not IsDBNull(dr("EMAIL")) Then txtEmail.Text = dr("EMAIL")
        If Not IsDBNull(dr("inscricao")) Then txtIe.Text = dr("inscricao")
        If Not IsDBNull(dr("uf")) Then cboUf.SelectedIndex = cboUf.FindString(dr("uf"))
    End Sub
    Private Sub Alterando()
        dr.BeginEdit()
        If txtRazao.Text <> "" Then dr("razao") = txtRazao.Text
        If txtFantasia.Text <> "" Then dr("fantasia") = txtFantasia.Text
        If txtEnd.Text <> "" Then dr("endereco") = txtEnd.Text
        If txtBairro.Text <> "" Then dr("bairro") = txtBairro.Text
        If txtCidade.Text <> "" Then dr("cidade") = txtCidade.Text
        If cboUf.SelectedIndex <> 0 Then dr("uf") = cboUf.Text
        If mskCep.Text <> "" Then dr("CEP") = mskCep.Text
        If mskCNPJ.Text <> "" Then dr("cnpj") = mskCNPJ.Text
        If txtIe.Text <> "" Then dr("inscricao") = txtIe.Text
        If txtEmail.Text <> "" Then dr("email") = txtEmail.Text
        If mskTel.Text <> "" Then dr("tel") = mskTel.Text
        dr.EndEdit()
    End Sub
    Private Sub Incluindo()
        dr = ds.Tables(Arquivo).NewRow
        dr("razao") = txtRazao.Text
        dr("fantasia") = txtFantasia.Text
        dr("endereco") = txtEnd.Text
        dr("bairro") = txtBairro.Text
        dr("cidade") = txtCidade.Text
        dr("uf") = cboUf.Text
        dr("CEP") = mskCep.Text
        dr("cnpj") = mskCNPJ.Text
        dr("email") = txtEmail.Text
        dr("inscricao") = txtIe.Text
        dr("tel") = mskTel.Text
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
    Private Sub txtFantasia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFantasia.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtEnd.Focus()
    End Sub
    Private Sub mskCep_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCep.GotFocus
        mskCep.SelectAll()
    End Sub
    Private Sub mskCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskCep.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtCidade.Focus()
    End Sub
    Private Sub cboUf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUf.KeyPress
        If (e.KeyChar = ChrW(13)) Then mskCNPJ.Focus()
    End Sub
    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If (e.KeyChar = ChrW(13)) Then mskTel.Focus()
    End Sub
    Private Sub mskTel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTel.GotFocus
        mskTel.SelectAll()
    End Sub
    Private Sub mskTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskTel.KeyPress
        If (e.KeyChar = ChrW(13)) Then cmdSalvar.Focus()
    End Sub
    Private Sub txtFantasia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFantasia.Leave
        txtFantasia.Text = UCase(txtFantasia.Text)
    End Sub
    Private Sub txtBairro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.GotFocus
        txtBairro.SelectAll()
    End Sub
    Private Sub txtBairro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBairro.KeyPress
        If (e.KeyChar = ChrW(13)) Then mskCep.Focus()
    End Sub
    Private Sub txtBairro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.Leave
        txtBairro.Text = UCase(txtBairro.Text)
    End Sub

    Private Sub txtIe_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIe.GotFocus
        txtIe.SelectAll()
    End Sub

    Private Sub txtIe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIe.KeyPress
        If (e.KeyChar = ChrW(13)) Then txtEmail.Focus()
    End Sub
End Class