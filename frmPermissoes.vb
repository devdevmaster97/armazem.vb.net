Imports System.Data.OleDb
Imports ARMAZEM.Principal
Public Class frmPermissoes
    Dim habilitado As Int32
    Dim desabilitado As Int32
    Dim indicenode As Int32
    Private Sub frmPermissoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Cursor.Current = Cursors.WaitCursor
        'Dim nodo_usuario As TreeNode
        'TreeView1.ImageList = ImageList1
        sql(0) = "SELECT * FROM TELA"
        If cn.State = 0 Then cn.Open()
        Dim cmt As New OleDbCommand(sql(0), cn)
        Dim dr_tela As OleDbDataReader = cmt.ExecuteReader
        If dr_tela.HasRows Then
            Do While dr_tela.Read

                Dim nodo_tela As New TreeNode(dr_tela.GetString(1))
                'nodo_tela.ImageIndex = 0
                'nodo_tela.SelectedImageIndex = 1
                TreeView1.Nodes.Add(nodo_tela)
                nodo_tela.Tag = "TELAS"

                sql(0) = "SELECT * FROM USUARIOS"
                If cn.State = 0 Then cn.Open()
                Dim cmu As New OleDbCommand(sql(0), cn)
                Dim dr_usuariot As OleDbDataReader = cmu.ExecuteReader
                If dr_usuariot.HasRows Then

                    Do While dr_usuariot.Read


                        Dim node_usuario As New TreeNode(dr_usuariot.GetString(1))

                        sql(1) = "SELECT * FROM qTELA_PERMISSAO_USUARIO WHERE NOME_TELA = '" & dr_tela.GetString(1) & "' AND NOME_USUARIO = '" & dr_usuariot.GetString(1) & "'"
                        Dim cmup As New OleDbCommand(sql(1), cn)
                        Dim dr_usuario_permisao As OleDbDataReader = cmup.ExecuteReader
                        If dr_usuario_permisao.HasRows Then
                            Do While dr_usuario_permisao.Read
                                'node_usuario.ImageIndex = 4
                                node_usuario.Checked = True
                                'node_usuario.SelectedImageIndex = 2
                            Loop
                        Else
                            'node_usuario.ImageIndex = 2
                            'node_usuario.SelectedImageIndex = 4
                            node_usuario.Checked = False
                        End If

                        nodo_tela.Nodes.Add(node_usuario)

                        'dr_usuario.Close()


                    Loop
                End If
            Loop
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub CloseIt()
        Me.Close()
    End Sub

    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        If e.Node.Level = 1 Then
            If e.Node.Checked = True Then
                sql(1) = "SELECT * FROM TELA WHERE NOME = '" & e.Node.Parent.Text & "'"
                Dim cmte As New OleDbCommand(sql(1), cn)
                Dim dr_tela As OleDbDataReader = cmte.ExecuteReader
                If dr_tela.HasRows Then
                    Do While dr_tela.Read

                        sql(1) = "SELECT * FROM USUARIOS WHERE NOME = '" & e.Node.Text & "'"
                        Dim cmus As New OleDbCommand(sql(1), cn)
                        Dim dr_usuario As OleDbDataReader = cmus.ExecuteReader
                        If dr_usuario.HasRows Then
                            Do While dr_usuario.Read

                                sql(2) = "INSERT INTO TELA_PERMISSAO (ID_TELA, ID_USUARIO) VALUES (" & dr_tela.GetInt32(0) & ", " & dr_usuario.GetInt32(0) & ")"
                                Dim cment2 As New OleDbCommand(sql(2), cn)
                                cment2.ExecuteNonQuery()

                            Loop
                        End If


                    Loop
                End If
            Else
                sql(1) = "SELECT * FROM TELA WHERE NOME = '" & e.Node.Parent.Text & "'"
                Dim cmte As New OleDbCommand(sql(1), cn)
                Dim dr_tela As OleDbDataReader = cmte.ExecuteReader
                If dr_tela.HasRows Then
                    Do While dr_tela.Read

                        sql(1) = "SELECT * FROM USUARIOS WHERE NOME = '" & e.Node.Text & "'"
                        Dim cmus As New OleDbCommand(sql(1), cn)
                        Dim dr_usuario As OleDbDataReader = cmus.ExecuteReader
                        If dr_usuario.HasRows Then
                            Do While dr_usuario.Read




                                sql(2) = "DELETE FROM TELA_PERMISSAO WHERE ID_TELA = " & dr_tela.GetInt32(0) & " AND ID_USUARIO = " & dr_usuario.GetInt32(0)
                                Dim cment2 As New OleDbCommand(sql(2), cn)
                                cment2.ExecuteNonQuery()

                            Loop
                        End If
                    Loop
                End If
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        'TreeView1.SelectedNode.SelectedImageIndex = 0
        'If TreeView1.Nodes(0).Nodes().IsSelected Then
        'TreeView1.Nodes(1).SelectedImageIndex = 0
        ' End If
    End Sub

    Private Sub TreeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        'TreeView1.SelectedNode.SelectedImageIndex = 1
        'TreeView1.Nodes(0).SelectedImageIndex = 1
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'indicenode = 0
        'indicenode = e.Node.Index - 1
    End Sub

    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        'e.Node.ImageIndex = e.Node.ImageIndex
    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        'habilitado = e.Node.ImageIndex
        'e.Node.SelectedImageIndex = habilitado
        'indicenode = e.Node.Parent.Index
    End Sub

    Private Sub TreeView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.Click
        'If TreeView1.Nodes(1).Nodes(indicenode).SelectedImageIndex = 4 Then
        '    TreeView1.Nodes(1).Nodes(indicenode).SelectedImageIndex = 2
        'Else
        '    TreeView1.Nodes(1).Nodes(indicenode).SelectedImageIndex = 4
        'End If

        'If TreeNodeStates.Focused.Then Then
        ' TreeView1.Nodes(1).SelectedImageIndex = 2
        ' Else
        ' TreeView1.Nodes(1).SelectedImageIndex = 4
        'End If
    End Sub
End Class