Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization
Imports ARMAZEM.Principal

Public Class frmbusca
    Dim da As OleDbDataAdapter
    Dim daent As OleDbDataAdapter
    Dim dalot As OleDbDataAdapter

    Dim ds As New DataSet
    Dim dv As DataView

    Dim dalote As New OleDbDataAdapter
    Dim dslote As New DataSet
    Dim dvlote As DataView
    Dim drlote() As DataRow

    Dim dsmestre As New DataSet
    Dim dsdetalhe As New DataSet
    Dim relentradalote As DataRelation

    Protected filtro = "LIKE '{0}%'"

    Private Sub frmbusca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPalavraChave.Focus()
    End Sub

    Private Sub frmBusca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        txtPalavraChave.Visible = True
        txtSomenteNumeros.Visible = False
        msk.Visible = False
        txtPalavraChave.Clear()

        da = New OleDbDataAdapter("SELECT * FROM " & Arquivo & " ORDER BY " & Busca.Ordem & " " & Busca.OrdemAD, cn)

        Dim dt As New DataTable(Arquivo)

        da.Fill(dt)

        dv = New DataView(dt, Nothing, Nothing, DataViewRowState.CurrentRows)

        DGV.DataSource = dv

        'ds.Clear()

        formatagrid()

        lbltex.Text = DGV.Columns(Busca.Numcampoinicial).HeaderText & ":"
        filtro = DGV.Columns(Busca.Numcampoinicial).DataPropertyName & " LIKE '{0}%'"
        dv.RowFilter = ""
        txtPalavraChave.Visible = True
        DGV.RowHeadersWidth = 24


        chkConsultaLote.Checked = False

        Cursor.Current = Cursors.Default
    End Sub
    Private Sub txtPalavraChave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPalavraChave.KeyDown
        If e.KeyCode = Keys.Down Then
            DGV.Focus()
        End If
    End Sub
    Private Sub txtPalavraChave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPalavraChave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            DGV.Focus()
        End If
    End Sub
    Private Sub txtPalavraChave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPalavraChave.TextChanged
        dv.RowFilter = ""
        'filtro = ""
        If chkConsultaLote.Checked = False Then
            If txtPalavraChave.Text <> "" Then
                dv.RowFilter = String.Format(filtro, txtPalavraChave.Text)
                dv.Sort = Busca.Ordem & " " & Busca.OrdemAD
            Else
                dv.RowFilter = String.Format(filtro, "0")
                dv.Sort = Busca.Ordem & " " & Busca.OrdemAD
            End If
        Else
            If Arquivo = "qENTRADA1" Then
                sql(1) = "SELECT ID_ENTRADA, LOTE FROM ENTRADA_ITENS WHERE LOTE = '" & txtPalavraChave.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cm As New OleDbCommand(sql(1), cn)
                Dim dr_lote As OleDbDataReader = cm.ExecuteReader
                If dr_lote.HasRows Then
                    Do While dr_lote.Read
                        dv.RowFilter = "ID_ENTRADA = " & dr_lote.GetInt32(0)
                    Loop
                Else
                    dv.RowFilter = "ID_ENTRADA=0"
                End If
                dr_lote.Close()
            ElseIf Arquivo = "qSERVICO" Then


                sql(1) = "SELECT ID_SERVICO, LOTE FROM SERVICO_LOTES WHERE LOTE = '" & txtPalavraChave.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cm As New OleDbCommand(sql(1), cn)
                Dim dr_lote As OleDbDataReader = cm.ExecuteReader
                If dr_lote.HasRows Then
                    Do While dr_lote.Read
                        dv.RowFilter = "ID_SERVICO = " & dr_lote.GetInt32(0)
                    Loop
                Else
                    dv.RowFilter = "ID_SERVICO=0"
                End If
                dr_lote.Close()
            ElseIf Arquivo = "qRETIRADA" Then
                sql(1) = "SELECT ID_RETIRADA, LOTE FROM RETIRADA_LOTES WHERE LOTE = '" & txtPalavraChave.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cm As New OleDbCommand(sql(1), cn)
                Dim dr_lote As OleDbDataReader = cm.ExecuteReader
                If dr_lote.HasRows Then
                    Do While dr_lote.Read
                        dv.RowFilter = "ID_RETIRADA = " & dr_lote.GetInt32(0)
                    Loop
                Else
                    dv.RowFilter = "ID_RETIRADA=0"
                End If
                dr_lote.Close()
            End If
        End If
    End Sub
    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If DGV.Rows.Count > 0 And e.ColumnIndex <> -1 And e.RowIndex <> -1 Then
            lblTex.Text = DGV.Columns(e.ColumnIndex).HeaderText & ":"
            If IsDate(DGV.CurrentRow.Cells(e.ColumnIndex).Value) And Len(DGV.CurrentRow.Cells(e.ColumnIndex).Value) > 7 Then 'DATAS
                filtro = DGV.Columns(e.ColumnIndex).DataPropertyName & " = #{0}#"
                msk.Visible = True
                txtPalavraChave.Visible = False
                txtSomenteNumeros.Visible = False
                msk.Focus()
            ElseIf Not IsNumeric(DGV.CurrentRow.Cells(e.ColumnIndex).Value) Then 'STRINGS
                filtro = DGV.Columns(e.ColumnIndex).DataPropertyName & " LIKE '{0}%'"
                msk.Visible = False
                txtPalavraChave.Visible = True
                txtSomenteNumeros.Visible = False
                txtPalavraChave.Focus()
            Else 'NUMEROS
                msk.Visible = False
                txtPalavraChave.Visible = False
                txtSomenteNumeros.Visible = True
                filtro = DGV.Columns(e.ColumnIndex).DataPropertyName & " = {0}"
                txtSomenteNumeros.Focus()
            End If
        End If
    End Sub
    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        CriterioBusca = DGV.CurrentRow.Cells(Busca.NumCrite).Value.ToString.Trim
        Me.Close()
    End Sub
    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        If DGV.CurrentRow.Index > 0 Then
            DGV.Rows(DGV.CurrentRow.Index - 1).Cells(0).Selected = True 'volta o cursos um posição pq ela nao cai na posição certa
        End If
        CriterioBusca = DGV.CurrentRow.Cells(Busca.NumCrite).Value.ToString.Trim
        Me.Close()
    End Sub
    Private Sub msk_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles msk.TextChanged
        Dim dat As String = msk.Text
        Dim x As DateTime
        'If msk.Text <> "" Then
        If Mid(filtro, 1, 4) = "DATA" Then
            If Len(dat.Replace("/", "")) = 8 Then
                x = msk.Text
                dv.RowFilter = String.Format(filtro, x.ToString("MM/dd/yyyy"))
            ElseIf Val(dat.Replace("/", "")) = 0 Then
                dv.RowFilter = Busca.Criterio(0).Campo & " <> '0'" 'mostra todos os registros
            End If
        End If
        'End If
    End Sub
    Private Sub txtSomenteNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSomenteNumeros.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))
        'If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
        If KeyAscii = 0 And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." Then

            e.Handled = True

        End If
    End Sub
    Private Sub txtSomenteNumeros_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSomenteNumeros.TextChanged
        If txtSomenteNumeros.Text <> "" Then
            dv.RowFilter = String.Format(filtro, txtSomenteNumeros.Text)
        Else
            dv.RowFilter = Busca.Criterio(0).Campo & " <> '0'"
        End If
    End Sub
    Protected Sub formatagrid()
        Dim i As Short
        i = 0
        For i = 0 To Busca.Ncolunas
            DGV.Columns.Item(i).HeaderText = Busca.Criterio(i).Nome
            DGV.Columns.Item(i).Width = Busca.Criterio(i).LargCol
            DGV.Columns.Item(i).DefaultCellStyle.Format = Busca.Criterio(i).Formato
            DGV.Columns.Item(i).DefaultCellStyle.Alignment = Busca.Criterio(i).Alinha
            DGV.Columns.Item(i).Visible = True
        Next
        For i = i To DGV.Columns.Count - 1
            If i = DGV.Columns.Count Then Exit For
            DGV.Columns.Item(i).Visible = False
        Next
    End Sub
    Private Sub lblTex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTex.Text = "LOTE"
        txtPalavraChave.Visible = True
        msk.Visible = False
        txtPalavraChave.Focus()
    End Sub
    Private Sub chkConsultaLote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConsultaLote.CheckedChanged
        If chkConsultaLote.Checked Then

            da = New OleDbDataAdapter("SELECT * FROM " & Arquivo & " ORDER BY " & Busca.Ordem & " " & Busca.OrdemAD, cn)

            Dim dt As New DataTable(Arquivo)

            da.Fill(dt)

            dv = New DataView(dt, Nothing, Nothing, DataViewRowState.CurrentRows)

            DGV.DataSource = dv

            lbltex.Text = "LOTE"
            filtro = "LOTE LIKE '{0}%'"
            'dv.RowFilter = "LOTE LIKE '0%'"
            txtPalavraChave.Visible = True
            msk.Visible = False
            txtPalavraChave.Focus()
        Else
            If Arquivo = "qENTRADA1" Then
                lbltex.Text = "FE"
                filtro = "FE LIKE '{0}%'"
                msk.Visible = False
                txtPalavraChave.Visible = True
                txtSomenteNumeros.Visible = False
                txtPalavraChave.Focus()
            ElseIf Arquivo = "qSERVICO" Then
                lbltex.Text = "SE"
                filtro = "SE LIKE '{0}%'"
                msk.Visible = False
                txtPalavraChave.Visible = True
                txtSomenteNumeros.Visible = False
                txtPalavraChave.Focus()
            ElseIf Arquivo = "qRETIRADA" Then
                lbltex.Text = "OR"
                filtro = "RE LIKE '{0}%'"
                msk.Visible = False
                txtPalavraChave.Visible = True
                txtSomenteNumeros.Visible = False
                txtPalavraChave.Focus()
            End If
        End If
    End Sub

End Class