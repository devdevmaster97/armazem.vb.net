Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal
Public Class frmEstoqueRetroativo
    Dim dsdepo As New DataSet
    Dim drdepo As DataRow
    Dim dadepo As New OleDbDataAdapter

    Dim ds As New DataSet
    Dim dr As DataRow
    Dim da As New OleDbDataAdapter

    Dim id_depositante As Integer
    Dim nome_depositante As String
    Dim ordemrel As Integer

    Private Sub frmReportEstoqueClienteEscolha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ordemrel = 1
    End Sub

    Private Sub btnExibir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibir.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmtemp As frmReportEstoqueRetroativo = New frmReportEstoqueRetroativo(cboDepositante.SelectedValue, cboDepositante.Text)
        frmtemp.Show()
    End Sub

    Private Sub cboDepositante_Leave(sender As Object, e As System.EventArgs) Handles cboDepositante.Leave
        Dim iFoundIndex As Integer
        iFoundIndex = cboDepositante.FindStringExact(cboDepositante.Text)
        If iFoundIndex = -1 Then
            MsgBox(cboDepositante.Text & " NÃO EXISTE, VERIFIQUE.", vbCritical, "Atenção")
            cboDepositante.Focus()
        End If
    End Sub

End Class
