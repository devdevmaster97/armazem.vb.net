Imports System.Data.OleDb
Imports ARMAZEM.Principal
Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    'Dim da_usuario As OleDb.OleDbDataAdapter
    'Dim ds_usuario As DataSet

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Cursor.Current = Cursors.WaitCursor
        cn = GetConnection()
        If txtUsuario.Text <> "" Then
                If Not chkAlterar.Checked Then
                    sql(0) = "SELECT * FROM USUARIOS WHERE NOME = '" & txtUsuario.Text & "' AND SENHA = '" & txtSenha.Text & "'"
                    If cn.State = 0 Then cn.Open()
                    Dim cmuser As New OleDbCommand(sql(0), cn)
                    Dim dr_usuario As OleDbDataReader = cmuser.ExecuteReader
                    If dr_usuario.HasRows Then
                        Do While dr_usuario.Read
                            XLogonUser.User = dr_usuario.GetString(1)
                            XLogonUser.Pass = dr_usuario.GetString(2)
                        Loop
                        dr_usuario.Close()
                        cn.Close()
                        Me.Hide()
                        Inicio.Show()
                    Else
                        MessageBox.Show("Dados incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsuario.Focus()
                        dr_usuario.Close()
                        cn.Close()
                    End If
                Else
                    If txtNovaSenha.Text = txtConfirmaNovaSenha.Text Then
                        If txtNovaSenha.Text <> txtSenha.Text Then
                            sql(0) = "SELECT * FROM USUARIOS WHERE NOME = '" & txtUsuario.Text & "' AND SENHA = '" & txtSenha.Text & "'"
                            If cn.State = 0 Then cn.Open()
                            Dim cm As New OleDbCommand(sql(0), cn)
                            Dim dr_usuario As OleDbDataReader = cm.ExecuteReader
                            If dr_usuario.HasRows Then
                                Do While dr_usuario.Read
                                    sql(0) = "UPDATE USUARIOS SET SENHA = '" & txtNovaSenha.Text & "' WHERE ID_USUARIO = " & dr_usuario.GetInt32(0) & ""
                                    If cn.State = 0 Then cn.Open()
                                    Dim cmg As New OleDbCommand(sql(0), cn)
                                    cmg.ExecuteNonQuery()
                                    XLogonUser.User = dr_usuario.GetString(1)
                                    XLogonUser.Pass = txtNovaSenha.Text
                                    MessageBox.Show("Senha alterada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Loop
                                dr_usuario.Close()
                                cn.Close()
                                Inicio.Show()
                            Else
                                MessageBox.Show("Dados incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtUsuario.Focus()
                                dr_usuario.Close()
                                cn.Close()
                            End If
                        Else
                            MessageBox.Show("A nova senha é igual a senha atual, informe uma senha diferente da atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtNovaSenha.Focus()
                        End If
                    Else
                        MessageBox.Show("A confirmação da senha está diferente da nova senha, corriga!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtNovaSenha.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Informe o usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Focus()
            End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuario.Top = 37
        txtUsuario.Top = 63
        lblSenha.Top = 90
        txtSenha.Top = 109
        lblNovaSenha.Visible = False
        txtNovaSenha.Visible = False
        lblConfirmaNovaSenha.Visible = False
        txtConfirmaNovaSenha.Visible = False
        cn = GetConnection()
        '**************** BUSCA NOME DA EMPRASA ****************************
        cn = GetConnection()
        sql(1) = "SELECT RAZAO FROM DADOSEMPRESA"
        If cn.State = 0 Then cn.Open()
        Dim cmu As New OleDbCommand(sql(1), cn)
        Dim dr_usuario As OleDbDataReader = cmu.ExecuteReader
        If Not dr_usuario.HasRows Then
            frmDadosEmpresa.ShowDialog()
        End If
        dr_usuario.Close()
        cn.Close()
    End Sub
    Private Sub chkAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlterar.CheckedChanged
        If chkAlterar.Checked Then
            lblUsuario.Top = 14
            txtUsuario.Top = 33
            lblSenha.Top = 54
            txtSenha.Top = 71
            lblNovaSenha.Visible = True
            txtNovaSenha.Visible = True
            lblConfirmaNovaSenha.Visible = True
            txtConfirmaNovaSenha.Visible = True
            txtUsuario.Focus()
        Else
            lblUsuario.Top = 37
            txtUsuario.Top = 63
            lblSenha.Top = 90
            txtSenha.Top = 109
            lblNovaSenha.Visible = False
            txtNovaSenha.Visible = False
            lblConfirmaNovaSenha.Visible = False
            txtConfirmaNovaSenha.Visible = False
            txtUsuario.Focus()
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub
    Private Sub txtSenha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSenha.GotFocus
        txtSenha.SelectAll()
    End Sub
    Private Sub txtNovaSenha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNovaSenha.GotFocus
        txtNovaSenha.SelectAll()
    End Sub
    Private Sub txtConfirmaNovaSenha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmaNovaSenha.GotFocus
        txtConfirmaNovaSenha.SelectAll()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
End Class
