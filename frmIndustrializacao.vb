Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal
Public Class frmIndustrializacao
    Dim dsdepo As New DataSet
    Dim drdepo As DataRow
    Dim dadepo As New OleDbDataAdapter

    Dim ds As New DataSet
    Dim dr As DataRow
    Dim da As New OleDbDataAdapter



    Private Sub frmIndustrializacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '****PREENCHE COMBO AUTO COMPLETAR DEPOSITANTE****************************
        sql(0) = "SELECT * FROM DEPOSITANTE ORDER BY DESCRI"
        Dim cmde As New OleDbCommand(sql(0), cn)
        dadepo = New OleDbDataAdapter(cmde)
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        dsdepo.EnforceConstraints = False                       '*
        If dsdepo.Tables.Count = 0 Then dsdepo.Tables.Add("DEPOSITANTE") '*
        dsdepo.Tables("DEPOSITANTE").BeginLoadData()          '*
        '********************************************************
        dadepo.Fill(dsdepo, "DEPOSITANTE")
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        dsdepo.Tables("DEPOSITANTE").EndLoadData()            '*

        '********************************************************
        With cboDepositante
            .AutoCompleteCustomSource.Add(dsdepo.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = dsdepo.Tables(0)
            .DisplayMember = dsdepo.Tables(0).Columns(1).ToString
            .ValueMember = dsdepo.Tables(0).Columns(0).ToString
            .Text = ""
        End With
        '*************************************************************************
        dtpDataInicial.Value = Date.Now
        dtpDataFinal.Value = Date.Now
        dtpDataFaturamento.Value = Date.Now
    End Sub

    Private Sub btnExibir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibir.Click
        Cursor.Current = Cursors.WaitCursor
        frmIndustrializacaoRel.Show()
    End Sub

    Private Sub cboDepositante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepositante.SelectedIndexChanged

        If cboDepositante.SelectedIndex > 0 Then
            sql(0) = "SELECT * FROM DEPOSITANTE"

            Dim cm As New OleDbCommand(sql(0), cn)

            da = New OleDbDataAdapter(cm)

            da.Fill(ds, "DEPOSITANTE")

            dr = ds.Tables("DEPOSITANTE").Select("id = " & cboDepositante.SelectedValue & "")(0)

            If Not IsDBNull(dr("saldo_anterior")) Then
                txtSaldoAnterior.Text = dr("saldo_anterior")
            Else
                txtSaldoAnterior.Text = ""
            End If
            If Not IsDBNull(dr("entrada")) Then
                txtEntrada.Text = dr("entrada")
            Else
                txtEntrada.Text = ""
            End If
            If Not IsDBNull(dr("saida_exportacao")) Then
                txtSaidaExportacao.Text = dr("saida_exportacao")
            Else
                txtSaidaExportacao.Text = ""
            End If
            If Not IsDBNull(dr("saida_minterno")) Then
                txtSaida_MInterno.Text = dr("saida_minterno")
            Else
                txtSaida_MInterno.Text = ""
            End If
            If Not IsDBNull(dr("n_nota")) Then
                txtN_nota.Text = dr("n_nota")
            Else
                txtN_nota.Text = ""
            End If
            If Not IsDBNull(dr("data_faturamento")) Then
                dtpDataFaturamento.Text = dr("data_faturamento")
            Else
                dtpDataFaturamento.Text = ""
            End If
        End If
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        dr.BeginEdit()
        If txtSaldoAnterior.Text <> "" Then dr("saldo_anterior") = txtSaldoAnterior.Text
        If txtEntrada.Text <> "" Then dr("entrada") = txtEntrada.Text
        If txtSaidaExportacao.Text <> "" Then dr("saida_exportacao") = txtSaidaExportacao.Text
        If txtSaida_MInterno.Text <> "" Then dr("saida_minterno") = txtSaida_MInterno.Text
        If txtN_nota.Text <> "" Then dr("n_nota") = txtN_nota.Text
        If dtpDataFaturamento.Text <> "" Then dr("data_faturamento") = dtpDataFaturamento.Value
        dr.EndEdit()
        Dim cmb As New OleDbCommandBuilder(da)
        da.Update(ds, "DEPOSITANTE")
        MsgBox("Atualizado com sucesso!", vbInformation, "Atenção")
    End Sub


End Class