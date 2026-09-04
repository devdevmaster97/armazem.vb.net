Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal
Public Class frmReportEntradaDiariaEscolha
    Dim dsdepo As New DataSet
    Dim drdepo As DataRow
    Dim dadepo As New OleDbDataAdapter

    Dim ds As New DataSet
    Dim dr As DataRow
    Dim da As New OleDbDataAdapter

    Dim id_depositante As Integer
    Dim nome_depositante As String


    Private Sub frmReportEntradaDiariaEscolha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        mskData1.Text = Date.Now.ToString
    End Sub

    Private Sub btnExibir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibir.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmtemp As frmReportEntradaDiaria = New frmReportEntradaDiaria(id_depositante, nome_depositante, mskData1.Text)
        frmtemp.Show()
    End Sub

    Private Sub cboDepositante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepositante.SelectedIndexChanged

        If cboDepositante.SelectedIndex > 0 Then
            sql(0) = "SELECT * FROM DEPOSITANTE"

            Dim cm As New OleDbCommand(sql(0), cn)

            da = New OleDbDataAdapter(cm)

            da.Fill(ds, "DEPOSITANTE")

            dr = ds.Tables("DEPOSITANTE").Select("id = " & cboDepositante.SelectedValue & "")(0)

            id_depositante = dr("id")
            nome_depositante = dr("descri")


        End If
    End Sub

    Private Sub mskData1_GotFocus(sender As Object, e As System.EventArgs) Handles mskData1.GotFocus
        mskData1.SelectAll()
    End Sub

End Class