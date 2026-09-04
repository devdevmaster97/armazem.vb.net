Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization
Imports ARMAZEM.Principal
'
Public Class frmBuscaLotes

    Private Sub frmBuscaLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intCol As Integer

        If ServicoX = True Then
            Me.Text = "Serviços do lote : " & LotesX
            sql(0) = "SELECT * FROM qSERVIÇO_LOTES WHERE LOTE = '" & LotesX & "'"
        Else
            Me.Text = "Retiradas do lote : " & LotesX
            sql(0) = "SELECT * FROM qRETIRADA_LOTES WHERE LOTE = '" & LotesX & "'"
        End If
        Dim cmlo As New OleDbCommand(sql(0), cn)
        If cn.State = 0 Then cn.Open()
        Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
        If dr_busca_id.HasRows Then
            DGV.Rows.Clear()
            DGV.Columns.Clear()
            For intCol = 0 To dr_busca_id.FieldCount - 1

                DGV.Columns.Add(dr_busca_id.GetName(intCol), dr_busca_id.GetName(intCol))

            Next

            'Define a largura da coluna com base na largura do cabeçalho

            'DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader

            'percorre o datareader enquanto houver dados
            While dr_busca_id.Read

                'Obtem os dados como em um objeto array

                Dim objCelulas(intCol) As Object

                dr_busca_id.GetValues(objCelulas)

                'Inclui uma linha de cada vez no datagridview

                DGV.Rows.Add(objCelulas)
            End While

            DGV.RowHeadersWidth = 24
            'fecha o datareader
            DGV.Columns(0).Width = 50
            DGV.Columns(1).Width = 80
            DGV.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy"
            DGV.Columns(2).Visible = False
            DGV.Columns(3).Width = 67
            DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(3).DefaultCellStyle.Format = "###,###0.0"

            DGV.Columns(4).Width = 67

            DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(4).DefaultCellStyle.Format = "###,###0.0"

            DGV.Columns(5).Visible = False

            dr_busca_id.Close()
        End If
    End Sub

    Private Sub DGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.DoubleClick
        CriterioBusca = DGV.CurrentRow.Cells(5).Value
        Me.Close()
    End Sub

    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        If DGV.CurrentRow.Index > 0 Then

            'If DGV.CurrentRow.Index <> DGV.Rows.Count - 1 Then
            DGV.Rows(DGV.CurrentRow.Index - 1).Cells(0).Selected = True 'volta o cursos um posição pq ela nao cai na posição certa
            'Else
            '    DGV.Rows(DGV.CurrentRow.Index).Cells(0).Selected = True 'volta o cursos um posição pq ela nao cai na posição certa
            'End If
        End If
        CriterioBusca = DGV.CurrentRow.Cells(5).Value
        Me.Close()

        'DGV_DoubleClick(DGV, e)
    End Sub
End Class