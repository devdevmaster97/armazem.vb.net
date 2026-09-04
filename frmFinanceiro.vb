Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal

Public Class frmFinanceiro
    Inherits System.Windows.Forms.Form
    <STAThreadAttribute()> _
    Public Shared Sub Main()
        Application.Run(New frmFinanceiro())
    End Sub
    Dim altera As Boolean
    Dim tabela_db As String = "FINANCEIRO"
    Dim ds As New DataSet
    Dim dsdepo As New DataSet
    Dim dsi As New DataSet
    Dim dsi2 As New DataSet
    Dim dsn As New DataSet
    Dim dssc1 As New DataSet 'usado no gridsacaria com combobox
    Dim dssc2 As New DataSet 'usado no grid com combobox
    Dim ds_resul As New DataSet 'SERVICO_RESULTADO
    Dim ds_opera As New DataSet
    Dim cadastrando As Boolean
    Dim qtde_registros As Integer
    '***********SERVICO_OPERACAO************************
    Dim da_servico_operacao As New OleDbDataAdapter   '*
    Dim ds_servico_operacao As New DataSet            '*
    Dim dr_servico_operacao() As DataRow              '*
    '***************************************************
    '***********SERVICO_OPERACAO****************
    Dim da_ser_oper As New OleDbDataAdapter   '*
    Dim ds_ser_oper As New DataSet            '*
    Dim dr_ser_oper() As DataRow              '*
    '*******************************************
    '****************OPERACAO*******************
    Dim da_oper As New OleDbDataAdapter       '*
    Dim ds_oper As New DataSet                '*
    Dim dr_oper() As DataRow                  '*
    '*******************************************
    '****************COBRANCA*******************
    Dim da_cob As New OleDbDataAdapter        '*
    Dim ds_cob As New DataSet                 '*
    Dim dr_cob() As DataRow                   '*
    '*******************************************
    '***COBRANCA2 DO COMBO ALTO SELEÇÃO*********
    Dim da_cob2 As New OleDbDataAdapter        '*
    Dim ds_cob2 As New DataSet                 '*
    Dim dr_cob2() As DataRow                   '*
    '*******************************************

    '**********BUSCA RETIRADA OPERACAO***********
    Dim da_bso As New OleDbDataAdapter        '*
    Dim ds_bso As New DataSet                 '*
    Dim dr_bso() As DataRow                   '*
    '*******************************************
    '***********qOPERACAO_COBRANCA**************
    Dim da_oper_cob As New OleDbDataAdapter   '*
    Dim ds_oper_cob As New DataSet            '*
    Dim dr_oper_cob() As DataRow              '*
    '*******************************************
    '***********BUSCA OS IDS OPERACAO***********
    Dim da_operX As New OleDbDataAdapter      '*
    Dim ds_operX As New DataSet               '*
    Dim dr_operX() As DataRow                 '*
    '*******************************************
    '***********BUSCA OS IDS OPERADOR***********
    Dim da_cobX As New OleDbDataAdapter       '*
    Dim ds_cobX As New DataSet                '*
    Dim dr_cobX() As DataRow                  '*
    '*******************************************
    '**************LOTES ENTRADA****************
    Dim da_le As New OleDbDataAdapter         '*
    Dim ds_le As New DataSet                  '*
    Dim dr_le() As DataRow                    '*
    Dim dr_iten_entrada As DataRow            '*
    '*******************************************
    '**************** ENTRADA*******************
    Dim da_en As New OleDbDataAdapter         '*
    Dim ds_en As New DataSet                  '*
    Dim dr_en() As DataRow                    '*
    Dim dr_entrada As DataRow                 '*
    '*******************************************

    Dim da As New OleDbDataAdapter
    Dim dadepo As New OleDbDataAdapter
    Dim dai As New OleDbDataAdapter
    Dim dai2 As New OleDbDataAdapter
    Dim dan As New OleDbDataAdapter
    Dim dasc1 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim dasc2 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim da_resul As New OleDbDataAdapter 'SERVICO_RESULTADO
    Dim da_opera As New OleDbDataAdapter
    Dim da_opera2 As New OleDbDataAdapter

    Dim dt As New DataTable

    Dim dr As DataRow
    Dim dri() As DataRow
    Dim drn() As DataRow
    Dim drdepo As DataRow
    Dim dr_resul() As DataRow 'TABELA SERVICO_RESULTADO

    Public Shared codigo_depositante As Integer
    Dim id_servico As Integer
    Dim controle_soma As Boolean
    Dim ui As Int32
    Public Shared strin_depo As String
    Public Shared codig_depo As String
    Public Shared strin_cob As String
    Public Shared codig_cob As String
    Public Shared codig_ope As String
    Public Shared operador_indice As Int32
    Public Shared codig_sit As String
    Public Shared strin_sit As String
    Public Shared strin_ope As String
    Dim Yx As String
    Dim sql_aux As String

    Dim xsql As String
    Dim xdepositante As String
    Dim xcobranca As String
    Dim xsituacao As String
    Dim xdatainicial As String
    Dim xdatafinal As String
    Dim xfe As String
    Dim xse As String
    Dim xre As String
    Dim xOrdem As String = " ORDER BY DATA_SERVICO ASC, F_E ASC, S_E ASC, O_R ASC"
    Dim xOpera As String

    Private Sub frmFinanceiro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmFinanceiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboSituacao.DataSource = {"NÃO PAGO", "PAGO", "TODOS"}
        cboSituacao.SelectedIndex = 0
        strin_sit = cboSituacao.SelectedItem
        estadobotao("inicio")
        habilita(Me, False)
        ds_servico_operacao.Clear()
        carrega()
        dtpDataFinal.Value = Date.Now
        dtpDataInicial.Value = Date.Now
        DGVServicos.Enabled = True
        '****PREENCHE COMBO AUTO COMPLETAR DEPOSITANTE****************************
        sql(0) = "SELECT * FROM DEPOSITANTE ORDER BY DESCRI"
        Dim cmde As New OleDbCommand(sql(0), cn)
        dadepo = New OleDbDataAdapter(cmde)
        dsdepo.EnforceConstraints = False
        dsdepo.Tables.Add("DEPOSITANTE")
        dsdepo.Tables("DEPOSITANTE").BeginLoadData()
        dadepo.Fill(dsdepo, "DEPOSITANTE")
        dsdepo.Tables("DEPOSITANTE").EndLoadData()
        With cboDepositante
            .AutoCompleteCustomSource.Add(dsdepo.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = dsdepo.Tables(0)
            .DisplayMember = dsdepo.Tables(0).Columns(1).ToString
            .ValueMember = dsdepo.Tables(0).Columns(0).ToString
            .Text = ""
        End With
        '****PREENCHE COMBO AUTO COMPLETAR COBRANÇA****************************
        sql(0) = "SELECT * FROM COBRANCA ORDER BY DESCRI"
        Dim cmdx As New OleDbCommand(sql(0), cn)
        da_cob2 = New OleDbDataAdapter(cmdx)
        ds_cob2.EnforceConstraints = False
        ds_cob2.Tables.Add("COBRANCA")
        ds_cob2.Tables("COBRANCA").BeginLoadData()
        da_cob2.Fill(ds_cob2, "COBRANCA")
        ds_cob2.Tables("COBRANCA").EndLoadData()
        With cboTipoCobrança
            .AutoCompleteCustomSource.Add(ds_cob2.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = ds_cob2.Tables(0)
            .DisplayMember = ds_cob2.Tables(0).Columns(1).ToString
            .ValueMember = ds_cob2.Tables(0).Columns(0).ToString
            .Text = ""
        End With

        '****PREENCHE COMBO AUTO COMPLETAR OPERACAO****************************
        sql(0) = "SELECT OPERACAO.ID_OPERACAO, OPERACAO.DESCRI "
        sql(0) = sql(0) & "FROM DEPOSITANTE RIGHT JOIN (OPERACAO RIGHT JOIN (OPERACAO_COBRANCA RIGHT JOIN SERVICO_OPERACAO ON OPERACAO_COBRANCA.ID_OPER_COB = SERVICO_OPERACAO.ID_OPER_COB) "
        sql(0) = sql(0) & "ON OPERACAO.ID_OPERACAO = OPERACAO_COBRANCA.ID_OPERACAO) ON DEPOSITANTE.id = SERVICO_OPERACAO.ID_DEPOSITANTE "
        sql(0) = sql(0) & "WHERE (((SERVICO_OPERACAO.DATA_SERVICO) BETWEEN #" & dtpDataInicial.Text & "# AND #" & dtpDataFinal.Text & "#) AND DEPOSITANTE.ID = " & cboDepositante.SelectedValue & ") GROUP BY OPERACAO.ID_OPERACAO, OPERACAO.DESCRI"

        Dim cmdo As New OleDbCommand(sql(0), cn)
        da_opera = New OleDbDataAdapter(cmdo)
        ds_opera.EnforceConstraints = False
        ds_opera.Tables.Add(sql(0))
        ds_opera.Tables(sql(0)).BeginLoadData()
        da_opera.Fill(ds_opera, sql(0))
        ds_opera.Tables(sql(0)).EndLoadData()
        With cboOperacao
            .AutoCompleteCustomSource.Add(ds_opera.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = ds_opera.Tables(0)
            .DisplayMember = ds_opera.Tables(0).Columns(1).ToString
            .ValueMember = ds_opera.Tables(0).Columns(0).ToString
            .Text = ""
        End With

        cmdAlterar.Enabled = False
    End Sub
    Private Sub carrega()
        '********************** PREENCHE DATASET SERVICO_OPERACAO *******************************************************************************
        cn = GetConnection()
        If DGVServicos.Rows.Count > 0 Then ds_servico_operacao.Tables(0).Clear()
        sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE ID_SERVICO_OPERACAO = 0"
        Dim cm_so As New OleDbCommand(sql(0), cn)
        da_servico_operacao = New OleDbDataAdapter(cm_so)
        da_servico_operacao.Fill(ds_servico_operacao, "SERVICO_OPERACAO")
        DGVServicos.DataSource = ds_servico_operacao.Tables(0)             'PRIMEIRO PREENCHE O DATASOURCE DO GRID
        'PREENCHE COMBO OPERAÇÃO
        Dim coloperacao As New DataGridViewComboBoxColumn    'ADCIONE A COLUNA COMBOBOX DA TABELA EXTERNA
        coloperacao.DataPropertyName = "ID_OPERACAO"         'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        coloperacao.HeaderText = "OPERACAO"                  'NOME DA COLUNA(ROTULO) COMBO 
        coloperacao.Width = 150
        DGVServicos.Columns.Add(coloperacao)                 'ADCIONA O COMBO NO GRID
        sql(0) = "SELECT * FROM OPERACAO ORDER BY DESCRI ASC"                    'PREENCHE A COMBOBOX COM OS DADOS DA TABELA EXTERNA
        Dim cmop As New OleDbCommand(sql(0), cn)
        da_oper = New OleDbDataAdapter(cmop)
        da_oper.Fill(ds_oper, "OPERACAO")
        coloperacao.DataSource = ds_oper.Tables(0)
        coloperacao.ValueMember = "ID_OPERACAO"             'CAMPO INDICE DO CAMPO
        coloperacao.DisplayMember = "DESCRI"                'CAMPO DADO A SER EXIBIDO NO COMBO
        'PREENCHE COMBO COBRANÇA
        Dim col_cob As New DataGridViewComboBoxColumn       'ADCIONE A COLUNA COMBOBOX DA TABELA EXTERNA
        col_cob.DataPropertyName = "ID_COBRANCA"            'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        col_cob.HeaderText = "NOME"                         'NOME DA COLUNA(ROTULO) COMBO 
        col_cob.Width = 100
        DGVServicos.Columns.Add(col_cob)                    'ADCIONA O COMBO NO GRID
        sql(0) = "SELECT * FROM COBRANCA ORDER BY DESCRI ASC"                   'PREENCHE A COMBOBOX COM OS DADOS DA TABELA EXTERNA
        Dim cm_cob As New OleDbCommand(sql(0), cn)
        da_cob = New OleDbDataAdapter(cm_cob)
        da_cob.Fill(ds_cob, "COBRANCA")
        col_cob.DataSource = ds_cob.Tables(0)
        col_cob.ValueMember = "ID_COBRANCA"                 'CAMPO INDICE DO CAMPO
        col_cob.DisplayMember = "DESCRI"                    'CAMPO DADO A SER EXIBIDO NO COMBO
        'DEFINA O CALENDARIO PARA A COLUNA DATA_SERVICO
        DGVServicos.Columns.Remove("DATA_SERVICO")          'SEGUNDO REMOVE A COLUNA DATA
        Dim colcalendar As New CalendarColumn               'CRIA E FORMATA A 2ª COLUNA DATA CalendarColumn
        colcalendar.DataPropertyName = "DATA_SERVICO"       'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        colcalendar.HeaderText = "DATA SERVIÇO"             'NOME DA COLUNA(ROTULO) COMBO 
        colcalendar.Width = 83
        colcalendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        colcalendar.DefaultCellStyle.NullValue = "0"


        DGVServicos.Columns.Add(colcalendar)                'ADCIONA A NOVA COLUNA DATA CALENDARIO NO GRID

        '******************* DEFINA O CALENDARIO PARA A COLUNA DATA_SAIDA ********************************
        DGVServicos.Columns.Remove("DATA_SAIDA")            'SEGUNDO REMOVE A COLUNA DATA
        Dim colcalendarsaida As New CalendarColumn          'CRIA E FORMATA A 2ª COLUNA DATA CalendarColumn
        colcalendarsaida.DataPropertyName = "DATA_SAIDA"    'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        colcalendarsaida.HeaderText = "DATA SAIDA"          'NOME DA COLUNA(ROTULO) COMBO 
        colcalendarsaida.Width = 83
        colcalendarsaida.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGVServicos.Columns.Add(colcalendarsaida)           'ADCIONA A NOVA COLUNA DATA CALENDARIO NO GRID
        DGVServicos.RowHeadersWidth = 24
        DGVServicos.Columns(0).Visible = False              'ID_SERVICO_OPER
        DGVServicos.Columns(1).Visible = False              'ID_SERVICO
        DGVServicos.Columns(2).Visible = False              'ID_OPER_COB

        DGVServicos.Columns(3).Visible = False              'HORA_SERVICO

        DGVServicos.Columns(4).Visible = False              'HORA_SAIDA

        DGVServicos.Columns(5).Width = 60                   'SACAS
        DGVServicos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGVServicos.Columns(6).HeaderText = "VALOR"
        DGVServicos.Columns(6).Width = 80
        DGVServicos.Columns(6).DefaultCellStyle.Format = "c" 'VALOR_OP_SACA
        DGVServicos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGVServicos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVServicos.Columns(7).DefaultCellStyle.Format = "c" 'TOTAL
        DGVServicos.Columns(7).Width = 80

        DGVServicos.Columns(8).Width = 40                   'DIAS

        DGVServicos.Columns(9).Width = 40                   'PAGO

        DGVServicos.Columns(10).Visible = False             'VALOR
        DGVServicos.Columns(11).Width = 50
        DGVServicos.Columns(11).HeaderText = "FE"

        DGVServicos.Columns(12).Width = 50
        DGVServicos.Columns(12).HeaderText = "SE"

        DGVServicos.Columns(13).Width = 50
        DGVServicos.Columns(13).HeaderText = "OR"

        DGVServicos.Columns(14).HeaderText = "OUTRAS COBRANÇAS"
        DGVServicos.Columns(14).Width = 190                 'OUTROS COBRANÇAS

        DGVServicos.Columns(15).DisplayIndex = 1            'OPERACAO  'MOVE A COLUNA COMBO OPERACAO PARA A PRIMEIRA POSIÇÃO DAS COLUNAS
        DGVServicos.Columns(15).Width = 100
        DGVServicos.Columns(16).DisplayIndex = 2            'COBRANCA  'MOVE A COLUNA COMBO COBRANCA PARA A SEGUNDA POSIÇÃO DAS COLUNAS
        DGVServicos.Columns(16).Width = 250                 'OPERAÇÃO
        DGVServicos.Columns(17).DisplayIndex = 3           'DATA SAIDA
        DGVServicos.Columns(17).Width = 100                'DATA SAIDA
        DGVServicos.Columns(18).DisplayIndex = 0           'DATA
        DGVServicos.Columns(18).Width = 100                'DATA
        DGVServicos.Columns(15).Visible = False            'ID_COB 

    End Sub
    Private Sub DGVServicos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVServicos.CellEndEdit
        Dim t_inicio As DateTime
        Dim t_fim As DateTime
        Dim t_difer As TimeSpan
        Dim StrHora As DateTime = DateTime.Now.ToShortTimeString
        Dim SQLstr As String
        'Dim str_fe_aux As VariantType
        If e.ColumnIndex = 7 Or e.ColumnIndex = 5 Then 'DATA INICIAL DATA FINAL
            If Not DGVServicos.Rows(e.RowIndex).Cells(7).Value Is DBNull.Value And Not DGVServicos.Rows(e.RowIndex).Cells(5).Value Is DBNull.Value Then
                For i = 0 To qtde_registros - 1
                    If DGVServicos.Rows(i).Cells(3).Value Is DBNull.Value Then
                        If DGVServicos.Rows(i).Cells(15).Value <> "" Then

                            t_inicio = DGVServicos.Rows(i).Cells(5).Value
                            t_fim = DGVServicos.Rows(e.RowIndex).Cells(7).Value
                            t_difer = t_fim.Subtract(t_inicio)

                            DGVServicos.Rows(i).Cells(12).Value = t_difer.Days 'DIAS

                            DGVServicos.Rows(i).Cells(7).Value = DGVServicos.Rows(e.RowIndex).Cells(7).Value

                            DGVServicos.Rows(i).Cells(6).Value = StrHora 'HORA RETIRADA
                            If Not IsDBNull(DGVServicos.Rows(i).Cells(12).Value) And Not IsDBNull(DGVServicos.Rows(i).Cells(9).Value) Then
                                DGVServicos.Rows(i).Cells(8).Value = StrHora
                                'DGVServicos.Rows(i).Cells(11).Value = DGVServicos.Rows(i).Cells(9).Value * DGVServicos.Rows(i).Cells(10).Value * DGVServicos.Rows(i).Cells(12).Value
                            End If

                        End If
                    End If
                Next

                If Not ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35") Is DBNull.Value Then lblTotalDias.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35")).ToString("###,###,##0.0")

                SQLstr = "INSERT INTO SERVICO_OPERACAO(ID_OPER_COB,DATA_SERVICO,HORA_SERVICO,DATA_SAIDA,HORA_SAIDA,SACAS,VALOR_OP_SACA,TOTAL,DIAS,ID_DEPOSITANTE,ID_COB) "
                SQLstr = SQLstr & " VALUES(35,'" & t_fim & "','" & StrHora & "','" & t_fim & "','" & StrHora & "','" & lblTotalSacas.Text & "','" & 0.02 & "','" & lblTotalSacas.Text * 0.02 * lblTotalDias.Text & "','" & lblTotalDias.Text & "'," & codigo_depositante & "," & DGVServicos.Rows(e.RowIndex).Cells(19).Value & ")"
                Dim cm_op As New OleDbCommand(SQLstr, cn)

                cm_op.ExecuteNonQuery()

            End If
        ElseIf e.ColumnIndex = 0 Or e.ColumnIndex = 1 Then
            If Not DGVServicos.Rows(e.RowIndex).Cells(0).Value Is Nothing And Not DGVServicos.Rows(e.RowIndex).Cells(1).Value Is Nothing Then
                sql(0) = "SELECT * FROM OPERACAO_COBRANCA"
                Dim cmi As New OleDbCommand(sql(0), cn)
                da_bso = New OleDbDataAdapter(cmi)
                da_bso.Fill(ds_bso, "OPERACAO_COBRANCA")
                dr_bso = ds_bso.Tables("OPERACAO_COBRANCA").Select("ID_OPERACAO = " & DGVServicos.Rows(e.RowIndex).Cells(0).Value & " AND ID_COBRANCA = " & DGVServicos.Rows(e.RowIndex).Cells(1).Value & "") 'BUSCA A ENTRADA
                If dr_bso.Length > 0 Then
                    DGVServicos.Rows(e.RowIndex).Cells(4).Value = dr_bso(0)("ID_OPER_COB")
                    DGVServicos.Rows(e.RowIndex).Cells(10).Value = dr_bso(0)("VALOR")
                    DGVServicos.Rows(e.RowIndex).Cells(19).Value = dr_bso(0)("ID_COBRANCA")
                    'If cboDepositante.Text = "" Then MessageBox.Show("Escolha o depositante!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboDepositante.Focus()
                Else
                    If DGVServicos.Rows(e.RowIndex).Cells(0).Value <> 17 Then MsgBox("ESTE SERVIÇO NÃO ESTA DEFINICO")
                End If
            End If
        ElseIf e.ColumnIndex = 9 Then
            If Not DGVServicos.Rows(e.RowIndex).Cells(9).Value Is DBNull.Value And Not DGVServicos.Rows(e.RowIndex).Cells(10).Value Is DBNull.Value Then
                DGVServicos.Rows(e.RowIndex).Cells(11).Value = DGVServicos.Rows(e.RowIndex).Cells(9).Value * DGVServicos.Rows(e.RowIndex).Cells(10).Value 'TOTAL
                If Not DGVServicos.Rows(e.RowIndex).Cells(12).Value Is DBNull.Value Then
                    DGVServicos.Rows(e.RowIndex).Cells(11).Value = DGVServicos.Rows(e.RowIndex).Cells(9).Value * DGVServicos.Rows(e.RowIndex).Cells(10).Value * DGVServicos.Rows(e.RowIndex).Cells(12).Value
                End If
            End If
        End If
        DGVServicos.Rows(e.RowIndex).Cells(14).Value = codigo_depositante

        If Not ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35 AND F_E <> ''") Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35 AND F_E <> ''")).ToString("###,###,##0.0")
        If Not ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty) Is DBNull.Value Then lblTotal.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty)).ToString("###,###,##0.0")

        If Not ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35 AND F_E <> ''") Is DBNull.Value Then lblTotalDias.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35 AND F_E <> ''")).ToString("###,###,##0.0")

    End Sub
    Private Sub habilita(ByVal form As Form, ByVal habil As Boolean)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DataGridView Or TypeOf form.Controls(i) Is System.Windows.Forms.RadioButton Or form.Controls(i).Name = "cmdRelatorio" Then
                form.Controls(i).Enabled = habil
            End If
        Next i
    End Sub
    Private Sub limpa(ByVal form As Form)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or form.Controls(i).Name = "lblTotalSacas" Or form.Controls(i).Name = "lblTotal" Then
                form.Controls(i).Text = ""
            End If
        Next i
        'If DGVServicos.Rows.Count > 0 Then ds_servico_operacao.Tables(0).Clear()
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        altera = True
        cadastrando = False
        cboSituacao.Enabled = False
        cboDepositante.Enabled = False
        cboTipoCobrança.Enabled = False
        cboOperacao.Enabled = False
        dtpDataInicial.Enabled = False
        dtpDataFinal.Enabled = False
        cmdCarrega.Enabled = False
        cmdRelatorio.Enabled = False
        rbDetalhado.Enabled = False
        rbResumido.Enabled = False
    End Sub
    Private Sub estadobotao(ByRef valor As String)
        If valor = "inicio" Then
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cboDepositante.Enabled = True
            cmdCancelar.Enabled = False
            DGVServicos.Enabled = True
            cboSituacao.Enabled = True
            cboDepositante.Enabled = True
            cboTipoCobrança.Enabled = True
            cmdCarrega.Enabled = True
            dtpDataInicial.Enabled = True
            dtpDataFinal.Enabled = True
            rbDetalhado.Enabled = True
            rbResumido.Enabled = True
            cmdRelatorio.Enabled = True
        ElseIf valor = "incluir/Salvar" Then
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = True
            cboDepositante.Enabled = False
            cmdCancelar.Enabled = True
        ElseIf valor = "cancelar" Then
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cboDepositante.Enabled = True
            cmdCancelar.Enabled = False
        Else
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = True
            cboDepositante.Enabled = True
            cboTipoCobrança.Enabled = True
            cboSituacao.Enabled = True
            dtpDataInicial.Enabled = True
            dtpDataFinal.Enabled = True
            cmdRelatorio.Enabled = True
            rbDetalhado.Enabled = True
            rbResumido.Enabled = True
            cmdCancelar.Enabled = False
            DGVServicos.Enabled = True
        End If
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim registro As Integer = 0
        'ATUALIZA DATASET SERVICO_OPERACAO
        Dim cbop As New OleDbCommandBuilder(da_servico_operacao)
        da_servico_operacao.Update(ds_servico_operacao, "SERVICO_OPERACAO")
        ds_servico_operacao.AcceptChanges()
        If DGVServicos.Rows.Count > 0 Then ds_servico_operacao.Tables(0).Clear()
        '********* PREENCHE O DATASET DO GRID SERVICO_OPERACAO *******************************************
        xsql = "SELECT * FROM SERVICO_OPERACAO WHERE "
        'PRIMEIRO PARAMETRO DO WHERE SQL
        'If cboDepositante.Text <> "" Then
        'If cboTipoCobrança.Text = "" And cboDepositante.Text <> "" Or cboTipoCobrança.Text <> "" And cboDepositante.Text <> "" Then
        xdepositante = " ID_DEPOSITANTE=" & codigo_depositante & " AND "
        'ElseIf cboTipoCobrança.Text <> "" And cboDepositante.Text = "" Then
        'xdepositante = " "
        'End If
        'Else
        'xdepositante = ""
        'End If
        'SEGUNDO PARAMETRO DO WHERE SQL
        If cboDepositante.Text = "" Then
            MsgBox("Depositante não pode ficar vazio para alteração", vbInformation, "Atenção")
            cmdCancelar_Click(sender, e)
            cboDepositante.Focus()
            Exit Sub
        End If

        If cboTipoCobrança.Text = "" Then
            MsgBox("Tipo cobrança não pode ficar vazio para alteração", vbInformation, "Atenção")
            cmdCancelar_Click(sender, e)
            cboTipoCobrança.Focus()
            Exit Sub
        End If
        If cboTipoCobrança.Text <> "" Then
            If cboDepositante.Text = "" And cboTipoCobrança.Text <> "" Then
                xcobranca = " ID_COB=" & cboTipoCobrança.SelectedValue
            ElseIf cboDepositante.Text <> "" And cboTipoCobrança.Text <> "" Then
                xcobranca = " ID_COB=" & cboTipoCobrança.SelectedValue
            ElseIf cboDepositante.Text <> "" And cboTipoCobrança.Text = "" Then
                xcobranca = " "
            End If
        Else
            xcobranca = ""
        End If

        'QUARTO PARAMETRO DO WHERE SQL
        'If chkFe.Checked = True Then
        '    xfe = " AND (F_E <> '' OR NOT F_E IS NULL)"
        'Else
        '    xfe = " AND (F_E = '' OR F_E IS NULL)"
        'End If

        ''QUINTO PARAMETRO DO WHERE SQL
        'If chkSe.Checked = True Then
        '    xse = " AND (S_E <> '' OR NOT S_E IS NULL)"
        'Else
        '    xse = " AND (S_E = '' OR S_E IS NULL)"
        'End If

        ''SEXTO PARAMETRO DO WHERE SQL
        'If chkOr.Checked = True Then
        '    xre = " AND (O_R <> '' OR NOT O_R IS NULL)"
        'Else
        '    xre = " AND (O_R = '' OR O_R IS NULL)"
        'End If

        ''SEXTO PARAMETRO DO WHERE SQL
        'If chkOr.Checked = True Then
        '    xre = " AND O_R <> NULL"
        'Else
        '    xre = " AND O_R = """""
        'End If

        'SETIMO PARAMETRO DO WHERE SQL
        xdatainicial = " AND DATA_SERVICO >= #" & dtpDataInicial.Value.ToString("M/d/yyyy") & "#"

        'OITAVO PARAMETRO DO WHERE SQL
        xdatafinal = " AND DATA_SERVICO <= #" & dtpDataFinal.Value.ToString("M/d/yyyy") & "#"

        If chkFe.Checked = True And chkSe.Checked = True And chkOr.Checked = True Then
            xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xOrdem
        ElseIf chkFe.Checked = True And chkSe.Checked = False And chkOr.Checked = True Then
            xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xse & xOrdem

        ElseIf chkFe.Checked = True And chkSe.Checked = True And chkOr.Checked = False Then
            xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xre & xOrdem

        ElseIf chkFe.Checked = False And chkSe.Checked = True And chkOr.Checked = True Then
            xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xfe & xOrdem
        Else

            xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xfe & xse & xre & xOrdem
        End If

        sql(0) = xsql
        Dim cm_op As New OleDbCommand(sql(0), cn)
        da_servico_operacao = New OleDbDataAdapter(cm_op)
        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
        ds_servico_operacao.EnforceConstraints = False
        If ds_servico_operacao.Tables.Count = 0 Then ds_servico_operacao.Tables.Add("SERVICO_OPERACAO")
        ds_servico_operacao.Tables("SERVICO_OPERACAO").BeginLoadData()
        '********************************************************************************************
        da_servico_operacao.Fill(ds_servico_operacao, "SERVICO_OPERACAO")
        'OTIMIZA PREENCHIMENTO DO DATASET********************
        ds_servico_operacao.Tables("SERVICO_OPERACAO").EndLoadData()      '*
        '********************************************
        If ds_servico_operacao.Tables(0).Rows.Count > 1 Then
            For xx = 0 To ds_servico_operacao.Tables(0).Rows.Count - 1
                sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_servico_operacao.Tables(0).Rows(xx).Item(2) & ""
                If cn.State = 0 Then cn.Open()
                Dim cm_qop As New OleDbCommand(sql(0), cn)
                Dim dr_qser_ope As OleDbDataReader = cm_qop.ExecuteReader
                If dr_qser_ope.HasRows Then
                    Do While dr_qser_ope.Read
                        sql(0) = "SELECT * FROM OPERACAO WHERE DESCRI = '" & dr_qser_ope.GetString(1) & "'" 'BUSCA ID OPERACAO
                        Dim cmope As New OleDbCommand(sql(0), cn)
                        Dim dr_opeX As OleDbDataReader = cmope.ExecuteReader
                        If dr_opeX.HasRows Then
                            Do While dr_opeX.Read
                                DGVServicos.Rows(xx).Cells(0).Value = dr_opeX.GetInt32(0)
                            Loop
                        End If
                        dr_opeX.Close()
                        sql(0) = "SELECT * FROM COBRANCA WHERE DESCRI = '" & dr_qser_ope.GetString(2) & "'" 'BUSCA ID COBRANCA
                        Dim cmco As New OleDbCommand(sql(0), cn)
                        Dim dr_cobX As OleDbDataReader = cmco.ExecuteReader
                        If dr_cobX.HasRows Then
                            Do While dr_cobX.Read
                                DGVServicos.Rows(xx).Cells(1).Value = dr_cobX.GetInt32(0)
                            Loop
                        End If
                        dr_cobX.Close()
                    Loop 'qOPERACAO_COBRANCA
                End If
                dr_qser_ope.Close()
            Next
        End If
        '******************* RECALCULA TOTAIS ***************************************************
        If Not ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35 AND F_E <> ''") Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35 AND F_E <> ''")).ToString("###,###,##0.0")
        If Not ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty) Is DBNull.Value Then lblTotal.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty)).ToString("###,###,##0.0")
        If Not ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35 AND F_E <> ''") Is DBNull.Value Then lblTotalDias.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35 AND F_E <> ''")).ToString("###,###,##0.0")

        MessageBox.Show(tabela_db & " atulizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)

        altera = True
        limpa(Me)
        habilita(Me, False)
        estadobotao("inicio")
        cadastrando = False
        cboSituacao.Enabled = True
        cboDepositante.Enabled = True
        cboTipoCobrança.Enabled = True
        cboOperacao.Enabled = True
        cmdCarrega.Enabled = True
        dtpDataInicial.Enabled = True
        dtpDataFinal.Enabled = True
        rbDetalhado.Enabled = True
        rbResumido.Enabled = True
        cmdRelatorio.Enabled = True
        DGVServicos.Enabled = False
        Cursor.Current = Cursors.Default

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        estadobotao("cancelar")
        limpa(Me)
        habilita(Me, False)
        altera = False
        cadastrando = False
        cboSituacao.Enabled = True
        cboDepositante.Enabled = True
        cboTipoCobrança.Enabled = True
        cboOperacao.Enabled = True
        cmdCarrega.Enabled = True
        dtpDataInicial.Enabled = True
        dtpDataFinal.Enabled = True
        rbDetalhado.Enabled = True
        rbResumido.Enabled = True
        cmdRelatorio.Enabled = True
        If DGVServicos.Rows.Count > 0 Then ds_servico_operacao.Tables(0).Clear()
    End Sub
    Private Sub DGVServicos_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVServicos.Sorted
        Cursor.Current = Cursors.WaitCursor
        For xx = 0 To ds_servico_operacao.Tables(0).Rows.Count - 1
            If xx = ds_servico_operacao.Tables(0).Rows.Count - 1 Then Exit For
            sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_servico_operacao.Tables(0).Rows(xx).Item(2) & ""
            If cn.State = 0 Then cn.Open()
            Dim cm_qop As New OleDbCommand(sql(0), cn)
            Dim dr_qser_ope As OleDbDataReader = cm_qop.ExecuteReader
            If dr_qser_ope.HasRows Then
                Do While dr_qser_ope.Read
                    sql(0) = "SELECT * FROM OPERACAO WHERE DESCRI = '" & dr_qser_ope.GetString(1) & "'" 'BUSCA ID OPERACAO
                    Dim cmope As New OleDbCommand(sql(0), cn)
                    Dim dr_opeX As OleDbDataReader = cmope.ExecuteReader
                    If dr_opeX.HasRows Then
                        Do While dr_opeX.Read
                            DGVServicos.Rows(xx).Cells(0).Value = dr_opeX.GetInt32(0)
                        Loop
                    End If
                    dr_opeX.Close()
                    sql(0) = "SELECT * FROM COBRANCA WHERE DESCRI = '" & dr_qser_ope.GetString(2) & "'" 'BUSCA ID COBRANCA
                    Dim cmco As New OleDbCommand(sql(0), cn)
                    Dim dr_cobX As OleDbDataReader = cmco.ExecuteReader
                    If dr_cobX.HasRows Then
                        Do While dr_cobX.Read
                            DGVServicos.Rows(xx).Cells(1).Value = dr_cobX.GetInt32(0)
                        Loop
                    End If
                    dr_cobX.Close()
                Loop 'qOPERACAO_COBRANCA
            End If
            dr_qser_ope.Close()
        Next
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub DGVServicos_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGVServicos.UserDeletingRow
        'Verifica se a linha é uma nova linha
        If Not e.Row.IsNewRow Then
            Dim resposta As DialogResult
            'Exibe caixa de diálogo solicitando confirmação ao usuário
            resposta = MessageBox.Show("Confirma exclusão deste registro?", "Excluir linha?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'Se o usuário não confirmar cancela o processo
            If resposta = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub cmdRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelatorio.Click
        Cursor.Current = Cursors.WaitCursor
        frmReportFinanceiro.Show()
    End Sub
    Private Sub cmdCarrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarrega.Click
        'If Not IsNothing(operador_indice) Then
        '****PREENCHE COMBO AUTO COMPLETAR OPERACAO****************************
        sql(0) = "SELECT OPERACAO.ID_OPERACAO, OPERACAO.DESCRI "
        sql(0) = sql(0) & "FROM DEPOSITANTE RIGHT JOIN (OPERACAO RIGHT JOIN (OPERACAO_COBRANCA RIGHT JOIN SERVICO_OPERACAO ON OPERACAO_COBRANCA.ID_OPER_COB = SERVICO_OPERACAO.ID_OPER_COB) "
        sql(0) = sql(0) & "ON OPERACAO.ID_OPERACAO = OPERACAO_COBRANCA.ID_OPERACAO) ON DEPOSITANTE.id = SERVICO_OPERACAO.ID_DEPOSITANTE "
        sql(0) = sql(0) & "WHERE (((SERVICO_OPERACAO.DATA_SERVICO) BETWEEN #" & dtpDataInicial.Text & "# AND #" & dtpDataFinal.Text & "#) AND DEPOSITANTE.ID = " & cboDepositante.SelectedValue & ") GROUP BY OPERACAO.ID_OPERACAO, OPERACAO.DESCRI"
        ds_opera.Clear()
        Dim cmdo As New OleDbCommand(sql(0), cn)
        da_opera = New OleDbDataAdapter(cmdo)
        'ds_opera.EnforceConstraints = False
        If ds_opera.Tables.Count = 0 Then ds_opera.Tables.Add(sql(0))
        'ds_opera.Tables(sql(0)).BeginLoadData()
        da_opera.Fill(ds_opera, sql(0))
        'ds_opera.Tables(sql(0)).EndLoadData()
        With cboOperacao

            .AutoCompleteCustomSource.Add(ds_opera.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = ds_opera.Tables(0)
            .DisplayMember = ds_opera.Tables(0).Columns(1).ToString
            .ValueMember = ds_opera.Tables(0).Columns(0).ToString
            If Not IsNothing(operador_indice) Then .SelectedItem = operador_indice
        End With
        'End If
        xsql = ""
        If cboDepositante.Text <> "" Or cboTipoCobrança.Text <> "" Then
            '********* PREENCHE O DATASET DO GRID SERVICO_OPERACAO *******************************************
            Cursor.Current = Cursors.WaitCursor
            If DGVServicos.Rows.Count > 0 Then ds_servico_operacao.Tables(0).Clear()
            xsql = "SELECT * FROM SERVICO_OPERACAO WHERE "
            'PRIMEIRO PARAMETRO DO WHERE SQL
            If cboDepositante.Text <> "" Then
                If cboTipoCobrança.Text = "" And cboDepositante.Text <> "" Or cboTipoCobrança.Text <> "" And cboDepositante.Text <> "" Then
                    xdepositante = " ID_DEPOSITANTE=" & codigo_depositante
                ElseIf cboTipoCobrança.Text <> "" And cboDepositante.Text = "" Then
                    xdepositante = " "
                End If
            Else
                xdepositante = ""
            End If

            'SEGUNDO PARAMETRO DO WHERE SQL
            If cboTipoCobrança.Text <> "" Then
                If cboDepositante.Text = "" And cboTipoCobrança.Text <> "" Then
                    xcobranca = " ID_COB=" & cboTipoCobrança.SelectedValue
                ElseIf cboDepositante.Text <> "" And cboTipoCobrança.Text <> "" Then
                    xcobranca = " AND ID_COB=" & cboTipoCobrança.SelectedValue
                ElseIf cboDepositante.Text <> "" And cboTipoCobrança.Text = "" Then
                    xcobranca = " "
                End If
            Else
                xcobranca = ""
            End If

            ''TERCEIRO PARAMETRO DO WHERE SQL
            If cboSituacao.Text <> "NÃO PAGO" Then
                xsituacao = " AND PAGO=TRUE"
            Else
                xsituacao = " AND PAGO=FALSE"
            End If

            ''QUARTO PARAMETRO DO WHERE SQL
            'If chkFe.Checked = True Then
            '    xfe = " AND (F_E <> '' OR NOT F_E IS NULL)"
            'Else
            '    xfe = " AND (F_E = '' OR F_E IS NULL)"
            'End If

            ''QUINTO PARAMETRO DO WHERE SQL
            'If chkSe.Checked = True Then
            '    xse = " AND (S_E <> '' OR NOT S_E IS NULL)"
            'Else
            '    xse = " AND (S_E = '' OR S_E IS NULL)"
            'End If

            ''SEXTO PARAMETRO DO WHERE SQL
            'If chkOr.Checked = True Then
            '    xre = " AND (O_R <> '' OR NOT O_R IS NULL)"
            'Else
            '    xre = " AND (O_R = '' OR O_R IS NULL)"
            'End If

            'SETIMO PARAMETRO DO WHERE SQL
            xdatainicial = " AND DATA_SERVICO >= #" & dtpDataInicial.Value.ToString("M/d/yyyy") & "#"

            'OITAVO PARAMETRO DO WHERE SQL
            xdatafinal = " AND DATA_SERVICO <= #" & dtpDataFinal.Value.ToString("M/d/yyyy") & "#"


            'NONO PARAMETRO DO WHERE SQL
            If cboOperacao.Text <> "" Then
                sql(0) = "SELECT * FROM OPERACAO_COBRANCA WHERE ID_OPERACAO = " & cboOperacao.SelectedValue & " AND ID_COBRANCA = " & cboTipoCobrança.SelectedValue & "" 'BUSCA ID COBRANCA
                If cn.State = 0 Then cn.Open()
                Dim cmopcob As New OleDbCommand(sql(0), cn)
                Dim dr_opcob As OleDbDataReader = cmopcob.ExecuteReader
                If dr_opcob.HasRows Then
                    Do While dr_opcob.Read
                        xOpera = " AND ID_OPER_COB=" & dr_opcob.GetInt32(0)
                    Loop
                End If
                'dr_opcob.Close()
            Else
                xOpera = ""
            End If
            If chkFe.Checked = True And chkSe.Checked = True And chkOr.Checked = True And cboOperacao.SelectedValue > 0 Then
                xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xOrdem
            ElseIf chkFe.Checked = True And chkSe.Checked = False And chkOr.Checked = True Then
                xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xse & xOrdem

            ElseIf chkFe.Checked = True And chkSe.Checked = True And chkOr.Checked = False Then
                xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xre & xOrdem

            ElseIf chkFe.Checked = False And chkSe.Checked = True And chkOr.Checked = True Then
                xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xfe & xOrdem
            Else

                xsql = xsql & xdepositante & xcobranca & xsituacao & xdatainicial & xdatafinal & xOpera & xfe & xse & xre & xOrdem
            End If
            sql(0) = xsql
            Dim cm_op As New OleDbCommand(sql(0), cn)
            da_servico_operacao = New OleDbDataAdapter(cm_op)
            'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
            ds_servico_operacao.EnforceConstraints = False                                                         '*
            If ds_servico_operacao.Tables.Count = 0 Then ds_servico_operacao.Tables.Add("SERVICO_OPERACAO") '*
            ds_servico_operacao.Tables("SERVICO_OPERACAO").BeginLoadData()                                                 '*
            '********************************************************************************************
            da_servico_operacao.Fill(ds_servico_operacao, "SERVICO_OPERACAO")
            'OTIMIZA PREENCHIMENTO DO DATASET************
            ds_servico_operacao.Tables("SERVICO_OPERACAO").EndLoadData()      '*
            '********************************************
            If ds_servico_operacao.Tables(0).Rows.Count > 0 Then
                qtde_registros = ds_servico_operacao.Tables(0).Rows.Count
                For xx = 0 To ds_servico_operacao.Tables(0).Rows.Count - 1
                    sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_servico_operacao.Tables(0).Rows(xx).Item(2) & ""
                    If cn.State = 0 Then cn.Open()
                    Dim cm_qop As New OleDbCommand(sql(0), cn)
                    Dim dr_qser_ope As OleDbDataReader = cm_qop.ExecuteReader
                    If dr_qser_ope.HasRows Then
                        Do While dr_qser_ope.Read
                            sql(0) = "SELECT * FROM OPERACAO WHERE DESCRI = '" & dr_qser_ope.GetString(1) & "'" 'BUSCA ID OPERACAO
                            Dim cmope As New OleDbCommand(sql(0), cn)
                            Dim dr_opeX As OleDbDataReader = cmope.ExecuteReader
                            If dr_opeX.HasRows Then
                                Do While dr_opeX.Read
                                    DGVServicos.Rows(xx).Cells(0).Value = dr_opeX.GetInt32(0)
                                Loop
                            End If
                            dr_opeX.Close()
                            sql(0) = "SELECT * FROM COBRANCA WHERE DESCRI = '" & dr_qser_ope.GetString(2) & "'" 'BUSCA ID COBRANCA
                            Dim cmco As New OleDbCommand(sql(0), cn)
                            Dim dr_cobX As OleDbDataReader = cmco.ExecuteReader
                            If dr_cobX.HasRows Then
                                Do While dr_cobX.Read
                                    DGVServicos.Rows(xx).Cells(1).Value = dr_cobX.GetInt32(0)
                                Loop
                            End If
                            dr_cobX.Close()
                        Loop 'qOPERACAO_COBRANCA
                    End If
                    dr_qser_ope.Close()
                Next
            Else
                MsgBox("Sem registros", vbInformation, "Atenção")
            End If
        Else
            MessageBox.Show("Escolha o depositante ou o tipo combraça!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDepositante.Focus()
        End If
        cboSituacao.Enabled = True
        estadobotao("inicio")
        habilita(Me, False)
        cmdRelatorio.Enabled = True
        rbDetalhado.Enabled = True
        rbResumido.Enabled = True

        If Not ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35") Is DBNull.Value Then lblTotalSacas.Text = ds_servico_operacao.Tables(0).Compute("SUM(SACAS)", "ID_OPER_COB <> 35")
        If Not ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty) Is DBNull.Value Then lblTotal.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(TOTAL)", String.Empty)).ToString("###,###,##0.0")
        If Not ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35") Is DBNull.Value Then lblTotalDias.Text = Convert.ToDouble(ds_servico_operacao.Tables(0).Compute("SUM(DIAS)", "ID_OPER_COB <> 35")).ToString("###,###,##0.0")
        lblRegistros.Text = ds_servico_operacao.Tables(0).Rows.Count
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cboDepositante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepositante.GotFocus
        Yx = ""
    End Sub
    Private Sub cboDepositante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDepositante.KeyPress
        If Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            Yx += e.KeyChar
            Dim IndexX As Integer = cboDepositante.FindString(Yx)
            Dim CharsTyped As Integer = cboDepositante.Text.Length
            If IndexX = -1 Then
                e.Handled = True
                Yx = Yx.Remove(Yx.Length - 1, 1)
            End If
        Else
            If Yx.Length > 0 Then Yx = Yx.Remove(0, Yx.Length)
        End If
    End Sub
    Private Sub cboDepositante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepositante.SelectedIndexChanged
        If cboDepositante.ValueMember <> "" Then
            codigo_depositante = cboDepositante.SelectedValue
            strin_depo = cboDepositante.Text
            'cboTipoCobrança.Text = ""
            'codig_cob = 0
            'strin_cob = ""
            cmdAlterar.Enabled = True
        End If
    End Sub
    Private Sub cboDepositante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDepositante.KeyDown
        If e.KeyCode = Keys.Return Then dtpDataInicial.Focus()
        If e.KeyCode = Keys.Delete Then
            Yx = ""
            codigo_depositante = Nothing
            strin_depo = ""
        End If
    End Sub
    Private Sub cboTipoCobrança_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoCobrança.GotFocus
        Yx = ""
    End Sub
    Private Sub cboTipoCobrança_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoCobrança.KeyDown
        If e.KeyCode = Keys.Return Then cboDepositante.Focus()
        If e.KeyCode = Keys.Delete Then
            Yx = ""
            codig_cob = Nothing
            strin_cob = ""
        End If

    End Sub
    Private Sub cboTipoCobrança_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoCobrança.KeyPress
        If Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            Yx += e.KeyChar
            Dim IndexX As Integer = cboTipoCobrança.FindString(Yx)
            Dim CharsTyped As Integer = cboTipoCobrança.Text.Length
            If IndexX = -1 Then
                e.Handled = True
                Yx = Yx.Remove(Yx.Length - 1, 1)
            End If
        Else
            If Yx.Length > 0 Then Yx = Yx.Remove(0, Yx.Length)
        End If
    End Sub
    Private Sub cboTipoCobrança_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCobrança.SelectedIndexChanged
        If cboTipoCobrança.ValueMember <> "" Then
            codig_cob = cboTipoCobrança.SelectedValue
            strin_cob = cboTipoCobrança.Text
            'cboDepositante.Text = ""
            'codig_depo = 0
            'strin_depo = ""
            cmdAlterar.Enabled = True
        End If
    End Sub
    Private Sub dtpDataInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDataInicial.KeyDown
        If e.KeyCode = Keys.Return Then
            dtpDataFinal.Focus()
        End If
    End Sub
    Private Sub dtpDataFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDataFinal.KeyDown
        If e.KeyCode = Keys.Return Then
            cboSituacao.Focus()
        End If
    End Sub
    Private Sub cboSituacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSituacao.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdCarrega.Focus()
        End If
    End Sub

    Private Sub DGVServicos_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVServicos.UserAddedRow
        If cboDepositante.Text = "" Then
            MsgBox("Escolha o depositante antes de prosseguir", vbInformation, "Atenção")
            cboDepositante.Enabled = True
            cboDepositante.Focus()
        End If
        If cboTipoCobrança.Text = "" Then
            MsgBox("Escolha o tipo de cobrança", vbInformation, "Atenção")
            cboTipoCobrança.Enabled = True
            cboTipoCobrança.Focus()
        End If
        DGVServicos.Rows(e.Row.Index - 1).Cells("HORA_SERVICO").Value = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub cboOperacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOperacao.GotFocus
        'If cboOperacao.Items.Count = 0 Then
        '    Cursor.Current = Cursors.WaitCursor
        '    If Not IsNothing(codig_cob) Then
        '        '****PREENCHE COMBO AUTO COMPLETAR OPERACAO****************************
        '        sql(0) = "SELECT DISTINCT ID_OPERACAO, DESCRI_OPERACAO, ID_COB FROM qCOBRANCA WHERE ID_COB = " & codig_cob & " GROUP BY DESCRI_OPERACAO, ID_OPERACAO, ID_COB ORDER BY DESCRI_OPERACAO"
        '        Dim cmdo As New OleDbCommand(sql(0), cn)
        '        da_opera = New OleDbDataAdapter(cmdo)
        '        'ds_opera.Clear()
        '        'ds_opera.EnforceConstraints = False
        '        'If ds_opera.Tables.Count = 0 Then ds_opera.Tables.Add("qCOBRANCA")
        '        'ds_opera.Tables("qCOBRANCA").BeginLoadData()
        '        da_opera.Fill(ds_opera, "qCOBRANCA")
        '        'ds_opera.Tables("qCOBRANCA").EndLoadData()
        '        With cboOperacao
        '            .AutoCompleteCustomSource.Add(ds_opera.Tables(0).ToString)
        '            '.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        '            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        '            .DataSource = ds_opera.Tables(0)
        '            .DisplayMember = ds_opera.Tables(0).Columns(1).ToString
        '            .ValueMember = ds_opera.Tables(0).Columns(0).ToString
        '            .Text = ""
        '        End With
        '    End If
        '    Cursor.Current = Cursors.Default
        'End If
    End Sub

    Private Sub cboOperacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOperacao.KeyDown
        If e.KeyCode = Keys.Return Then DGVServicos.Focus()
        If e.KeyCode = Keys.Delete Then
            codig_ope = 0
            strin_depo = Nothing
            operador_indice = 0
            cboOperacao.Text = ""
            Yx = ""
        End If
    End Sub

    Private Sub cboOperacao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOperacao.KeyPress
        If Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            Yx += e.KeyChar
            Dim IndexX As Integer = cboOperacao.FindString(Yx)
            Dim CharsTyped As Integer = cboOperacao.Text.Length
            If IndexX = -1 Then
                e.Handled = True
                Yx = Yx.Remove(Yx.Length - 1, 1)
            End If
        Else
            If Yx.Length > 0 Then Yx = Yx.Remove(0, Yx.Length)
        End If
    End Sub

    Public Sub cboOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOperacao.SelectedIndexChanged
        If cboOperacao.ValueMember <> "" And Not IsDBNull(cboOperacao.SelectedValue) Then
            codig_ope = cboOperacao.SelectedValue
            strin_ope = cboOperacao.Text
            operador_indice = cboOperacao.SelectedIndex
            cmdAlterar.Enabled = True
        End If
    End Sub

    Private Sub cboSituacao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSituacao.SelectedIndexChanged
        If cboSituacao.ValueMember <> "" Then
            codig_sit = cboSituacao.SelectedValue
            strin_sit = cboSituacao.Text
            cmdAlterar.Enabled = True
        End If
    End Sub

    Private Sub DGVServicos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVServicos.CellContentClick

    End Sub

End Class