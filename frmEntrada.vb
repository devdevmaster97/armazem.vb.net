Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal
Imports System.Math

Friend Class frmEntrada
    Inherits System.Windows.Forms.Form
    <STAThreadAttribute()> _
    Public Shared Sub Main()
        Application.Run(New frmEntrada())
    End Sub

    '***********SERVICO_OPERACAO****************
    Dim da_ser_oper As New OleDbDataAdapter '*
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
    '***********qOPERACAO_COBRANCA**************
    Dim da_oper_cob As New OleDbDataAdapter   '*
    Dim ds_oper_cob As New DataSet            '*
    Dim dr_oper_cob() As DataRow              '*
    '*******************************************

    Dim altera As Boolean
    Dim tabela_db As String = "ENTRADA"
    Dim ds As New DataSet
    Dim dsdepo As New DataSet
    Dim dsori As New DataSet
    Dim dsi As New DataSet
    Dim dsis As New DataSet
    Dim dsn As New DataSet
    Dim dssc1 As New DataSet 'usado no gridsacaria com combobox
    Dim dssc2 As New DataSet 'usado no grid com combobox
    Dim dsh As New DataSet
    Dim ds_bus_fe As New DataSet
    Dim ds_s As New DataSet

    Dim da_s As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim dadepo As New OleDbDataAdapter
    Dim daori As New OleDbDataAdapter
    Dim dai As New OleDbDataAdapter
    Dim dais As New OleDbDataAdapter
    Dim dai2 As New OleDbDataAdapter
    Dim dan As New OleDbDataAdapter
    Dim dasc1 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim dasc2 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim dasc3 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim da_bus_fe As New OleDbDataAdapter

    Dim dt As New DataTable

    Dim dr_s As DataRow
    Dim dr As DataRow
    Dim drlo() As DataRow
    Dim dri() As DataRow 'SACARIA
    Dim drn() As DataRow 'NOTA_ENTRADA

    Dim codigo_depositante As Integer
    Dim codigo_origem As Integer
    Dim id_entrada As Integer
    Dim controle_soma As Boolean
    Dim ui As Int32
    Dim cadastrando As Boolean
    Dim strin_depo As String
    Dim codig_depo As String
    Dim codigo_depositante_aux As Integer
    Dim strin_ori As String
    Dim codig_ori As String
    Dim colunax As String
    Dim Yx As String 'acumula caracteres
    Private Const EmptySpace As String = " "
    Dim cod_oper_cob As Int32
    Dim xlinha As Int32
    Dim fe_aux As String

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Cursor.Current = Cursors.WaitCursor
        '*******************************PARAMETROS DA BUSCA********************************
        Busca.Criterio = New TCriterio(4) {}
        Busca.Ncolunas = 4
        Busca.NumCrite = 13
        Busca.Numcampoinicial = 0
        Busca.Ordem = "ID_ENTRADA"
        Busca.OrdemAD = "DESC"

        Busca.Criterio(0).Nome = "FE"
        Busca.Criterio(0).Campo = "FE"
        Busca.Criterio(0).Alinha = DataGridViewContentAlignment.MiddleCenter
        Busca.Criterio(0).Numerico = False
        Busca.Criterio(0).LargCol = 50
        Busca.Criterio(0).Data = False
        Busca.Criterio(0).Formato = ""

        Busca.Criterio(1).Nome = "DATA"
        Busca.Criterio(1).Campo = "DATA"
        Busca.Criterio(1).Alinha = DataGridViewContentAlignment.MiddleCenter
        Busca.Criterio(1).Numerico = False
        Busca.Criterio(1).LargCol = 70
        Busca.Criterio(1).Data = True
        Busca.Criterio(1).Formato = "dd/MM/yyyy"

        Busca.Criterio(2).Nome = "NOME DEPOSITANTE"
        Busca.Criterio(2).Campo = "NOME_DEPOSITANTE"
        Busca.Criterio(2).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(2).Numerico = False
        Busca.Criterio(2).LargCol = 300
        Busca.Criterio(2).Data = False
        Busca.Criterio(2).Formato = ""

        Busca.Criterio(3).Nome = "NOME ORIGEM"
        Busca.Criterio(3).Campo = "NOME_ORIGEM"
        Busca.Criterio(3).Alinha = DataGridViewContentAlignment.MiddleLeft
        Busca.Criterio(3).Numerico = False
        Busca.Criterio(3).LargCol = 300
        Busca.Criterio(3).Data = False
        Busca.Criterio(3).Formato = ""

        Busca.Criterio(4).Nome = "PESO OBRIGATORIO"
        Busca.Criterio(4).Campo = "PESO_OBRIGATORIO"
        Busca.Criterio(4).Alinha = DataGridViewContentAlignment.MiddleRight
        Busca.Criterio(4).Numerico = False
        Busca.Criterio(4).LargCol = 150
        Busca.Criterio(4).Data = False
        Busca.Criterio(4).Formato = "#,##0.00"
        '************************************************************************************
        'cn = GetConnection()
        CriterioBusca = "XXX"
        Arquivo = "qENTRADA1"
        col_ini_busca = 0
        frmbusca.ShowDialog()
        If CriterioBusca <> "XXX" Then
            '********* PREENCHE DATASET ENTRADA *********************************************
            sql(0) = "SELECT * FROM " & tabela_db & " WHERE ID_ENTRADA =" & CriterioBusca & ""
            Dim cm As New OleDbCommand(sql(0), cn)
            da = New OleDbDataAdapter(cm)
            'OTIMIZA PREENCHIMENTO DO DATASET
            ds.EnforceConstraints = False
            If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db)
            ds.Tables(tabela_db).BeginLoadData()
            '**********************************
            da.Fill(ds, tabela_db)
            'OTIMIZA PREENCHIMENTO DO DATASET
            ds.Tables(tabela_db).EndLoadData()
            '*********************************
            dr = ds.Tables(tabela_db).Select("ID_ENTRADA = " & CriterioBusca & "")(0) 'BUSCA A ENTRADA
            limpa(Me)
            Visualizando()
            fe_aux = mskFE.Text
            estadobotao("exibido")
            '********* PREENCHE DATASET ENTRADA_ITENS ************************************************************
            If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
            sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE ID_ENTRADA =" & CriterioBusca & ""
            Dim cmi As New OleDbCommand(sql(0), cn)
            dai = New OleDbDataAdapter(cmi)
            'OTIMIZA PREENCHIMENTO DO DATASET
            dsi.EnforceConstraints = False
            If dsi.Tables.Count = 0 Then dsi.Tables.Add("ENTRADA_ITENS")
            dsi.Tables("ENTRADA_ITENS").BeginLoadData()
            '*********************************
            dai.Fill(dsi, "ENTRADA_ITENS")
            'OTIMIZA PREENCHIMENTO DO DATASET
            dsi.Tables("ENTRADA_ITENS").EndLoadData()
            '****************************************
            'GRID SALDOS *****************************************************************************
            If gridSaldos.Rows.Count > 0 Then dsis.Tables(0).Clear()
            sql(0) = "SELECT * FROM qENTRADA_ITENS_ESTOQUE WHERE ID_ENTRADA = " & CriterioBusca & ""
            Dim cmis As New OleDbCommand(sql(0), cn)
            dais = New OleDbDataAdapter(cmis)
            dsis.EnforceConstraints = False
            dsis.Tables("qENTRADA_ITENS_ESTOQUE").BeginLoadData()
            dais.Fill(dsis, "qENTRADA_ITENS_ESTOQUE")
            dsis.Tables("qENTRADA_ITENS_ESTOQUE").EndLoadData()
            gridSaldos.DataSource = dsis.Tables(0)                 'POPULA GRID
            FormataGridLotesSaldo()


            'dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
            '********* PREENCHE DATASET NOTAS_ENTRADA ************************************************************
            If DGVNotas.Rows.Count > 0 Then dsn.Tables(0).Clear()
            sql(0) = "SELECT * FROM NOTA_ENTRADA WHERE ID_ENTRADA =" & CriterioBusca & ""
            Dim cmn As New OleDbCommand(sql(0), cn)
            dan = New OleDbDataAdapter(cmn)
            'OTIMIZA PREENCHIMENTO DO DATASET
            dsn.EnforceConstraints = False
            If dsn.Tables.Count = 0 Then dsn.Tables.Add("NOTA_ENTRADA")
            dsn.Tables("NOTA_ENTRADA").BeginLoadData()
            '********************************
            dan.Fill(dsn, "NOTA_ENTRADA")
            'OTIMIZA PREENCHIMENTO DO DATASET************
            dsn.Tables("NOTA_ENTRADA").EndLoadData()
            '********************************************
            '********* PREENCHE O DATASOURCE DO GRID SACARIA******************************************************
            sql(0) = "SELECT * FROM SACARIA_ENTRADA WHERE ID_ENTRADA = " & CriterioBusca & ""
            Dim cmsc As New OleDbCommand(sql(0), cn)
            dasc1 = New OleDbDataAdapter(cmsc)
            'OTIMIZA PREENCHIMENTO DO DATASET
            dssc1.EnforceConstraints = False
            If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_ENTRADA")
            dssc1.Tables("SACARIA_ENTRADA").BeginLoadData()
            '**********************************************
            dasc1.Fill(dssc1, "SACARIA_ENTRADA")
            'OTIMIZA PREENCHIMENTO DO DATASET************
            dssc1.Tables("SACARIA_ENTRADA").EndLoadData()
            '********************************************
            lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
            '********* PREENCHE O DATASET DO GRID SERVICO_OPERACAO ***********************************************
            If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
            Dim xx As Int32
            sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE F_E = '" & mskFE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
            Dim cm_op As New OleDbCommand(sql(0), cn)
            da_ser_oper = New OleDbDataAdapter(cm_op)
            'OTIMIZA PREENCHIMENTO DO DATASET
            ds_ser_oper.EnforceConstraints = False
            If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO")
            ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()
            '****************************************************
            da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
            'OTIMIZA PREENCHIMENTO DO DATASET*******************
            ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()
            '***************************************************


            For xx = 0 To ds_ser_oper.Tables(0).Rows.Count - 1
                If Not IsDBNull(ds_ser_oper.Tables(0).Rows(xx).Item(2)) Then
                    sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_ser_oper.Tables(0).Rows(xx).Item(2) & ""
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
                End If
            Next
            '****************************************************************************************************
        Else
            id_entrada = 0
        End If

        If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
        If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
        cadastrando = False
        altera = False
        cmdAlterar.Focus()
        ckbConsulta.Checked = False
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Visualizando()
        CriterioBusca = dr("ID_ENTRADA")
        id_entrada = dr("ID_ENTRADA")
        mskFE.Text = dr("FE")
        If Not IsDBNull(dr("DATA")) Then dtpDataEntrada.Text = dr("DATA")
        '*****************************************************************************
        If Not dr("ID_DEPOSIT") Is DBNull.Value Then
            If dr("ID_DEPOSIT") <> 0 Then
                If cboDepositante.SelectedValue <> dr("ID_DEPOSIT") Then
                    'If cboDepositante.Text <> "" Then
                    cboDepositante.SelectedValue = dr("ID_DEPOSIT")
                    strin_depo = cboDepositante.Text
                    codig_depo = cboDepositante.SelectedValue.ToString
                    cboDepositante.Text = strin_depo
                    codigo_depositante = dr("ID_DEPOSIT")
                    codigo_depositante_aux = dr("ID_DEPOSIT")
                    'End If
                Else


                    cboDepositante.SelectedValue = dr("ID_DEPOSIT")
                    strin_depo = cboDepositante.SelectedItem(1)
                    codig_depo = cboDepositante.SelectedValue.ToString
                    cboDepositante.Text = strin_depo
                End If
            End If
        Else
            cboDepositante.Text = ""
            codigo_depositante_aux = 0
            codigo_depositante = 0
        End If
        '*****************************************************************************
        If Not dr("ID_ORIGEM") Is DBNull.Value Then
            If dr("ID_ORIGEM") <> 0 Then
                If cboRemetente.SelectedValue <> dr("ID_ORIGEM") Then
                    cboRemetente.SelectedValue = dr("ID_ORIGEM")
                    strin_ori = cboRemetente.Text
                    codig_ori = cboRemetente.SelectedValue.ToString
                    cboRemetente.Text = strin_ori
                    codigo_origem = dr("ID_ORIGEM")
                Else
                    cboRemetente.Text = strin_ori
                End If
            End If
        Else
            cboRemetente.Text = ""
            codigo_origem = 0
        End If
        '*****************************************************************************
        If Not IsDBNull(dr("PESO_OBRIGATORIO")) Then txtPesoObrigatorio.Text = dr("PESO_OBRIGATORIO")
        If Not IsDBNull(dr("PESO_BALANCA")) Then txtPesoBalanca.Text = dr("PESO_BALANCA")
        If Not IsDBNull(dr("MEDIA_SACA")) Then txtMediaSaca.Text = dr("MEDIA_SACA")
        If Not IsDBNull(dr("SAFRA")) Then txtSafra.Text = dr("SAFRA")
        If Not IsDBNull(dr("MOTORISTA")) Then txtMotorista.Text = dr("MOTORISTA")
        If Not IsDBNull(dr("ORDEMCOMPRA")) Then txtOrdemCompra.Text = dr("ORDEMCOMPRA")
        If Not IsDBNull(dr("PLACA")) Then MskPlaca.Text = dr("PLACA")
        If Not IsDBNull(dr("PROCEDENCIA")) Then txtProcedencia.Text = dr("PROCEDENCIA")
        If Not IsDBNull(dr("COD_SERVICO_ORIGEM")) Then mskCodSerOrigem.Text = dr("COD_SERVICO_ORIGEM")
        If Not IsDBNull(dr("COD_RETIRADA_ORIGEM")) Then mskCodRetOrigem.Text = dr("COD_RETIRADA_ORIGEM")
        If Not IsDBNull(dr("TOTAL_SACAS")) Then txtTotalSacas.Text = dr("TOTAL_SACAS")
    End Sub
    Private Sub Alterando()
        dr.BeginEdit()
        If mskFE.Text <> "" Then dr("FE") = mskFE.Text
        If dtpDataEntrada.Text <> "" Then dr("DATA") = dtpDataEntrada.Text
        dr("ID_DEPOSIT") = codigo_depositante
        dr("ID_ORIGEM") = codigo_origem
        If txtPesoObrigatorio.Text <> "" Then dr("PESO_OBRIGATORIO") = Val(txtPesoObrigatorio.Text)
        If txtPesoBalanca.Text <> "" Then dr("PESO_BALANCA") = txtPesoBalanca.Text
        If txtMediaSaca.Text <> "" Then dr("MEDIA_SACA") = txtMediaSaca.Text
        If txtSafra.Text <> "" Then dr("SAFRA") = txtSafra.Text
        If txtMotorista.Text <> "" Then dr("MOTORISTA") = txtMotorista.Text
        If txtOrdemCompra.Text <> "" Then dr("ORDEMCOMPRA") = txtOrdemCompra.Text
        If MskPlaca.Text <> "" Then dr("PLACA") = MskPlaca.Text
        If txtProcedencia.Text <> "" Then dr("PROCEDENCIA") = txtProcedencia.Text
        If txtTotalSacas.Text <> "" Then dr("TOTAL_SACAS") = txtTotalSacas.Text
        dr("OPERADOR") = XLogonUser.User
        dr.EndEdit()
    End Sub
    Private Sub Incluindo()
        dr = ds.Tables(tabela_db).NewRow
        dr("FE") = mskFE.Text
        dr("DATA") = dtpDataEntrada.Text
        If codigo_depositante <> 0 Then
            dr("ID_DEPOSIT") = codigo_depositante
        Else
            dr("ID_DEPOSIT") = DBNull.Value
        End If
        If codigo_origem <> 0 Then
            dr("ID_ORIGEM") = codigo_origem
        Else
            dr("ID_ORIGEM") = DBNull.Value
        End If
        If txtPesoObrigatorio.Text <> "" Then
            dr("PESO_OBRIGATORIO") = txtPesoObrigatorio.Text
        Else
            dr("PESO_OBRIGATORIO") = DBNull.Value
        End If
        If txtPesoBalanca.Text <> "" Then
            dr("PESO_BALANCA") = txtPesoBalanca.Text
        Else
            dr("PESO_BALANCA") = DBNull.Value
        End If
        If txtMediaSaca.Text <> "" Then
            dr("MEDIA_SACA") = txtMediaSaca.Text
        Else
            dr("MEDIA_SACA") = DBNull.Value
        End If
        If txtSafra.Text <> "" Then
            dr("SAFRA") = txtSafra.Text
        Else
            dr("SAFRA") = DBNull.Value
        End If
        If txtTotalSacas.Text <> "" Then
            dr("TOTAL_SACAS") = txtTotalSacas.Text
        Else
            dr("TOTAL_SACAS") = DBNull.Value
        End If

        dr("MOTORISTA") = txtMotorista.Text
        dr("ORDEMCOMPRA") = txtOrdemCompra.Text
        dr("PLACA") = MskPlaca.Text
        dr("PROCEDENCIA") = txtProcedencia.Text
        dr("OPERADOR") = XLogonUser.User
        ds.Tables(tabela_db).Rows.Add(dr)
    End Sub
    Private Sub frmEntrada_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If (e.KeyChar = ChrW(13)) Then
        ' SendKeys.Send("{TAB}")
        ' e.Handled = True 'Para remover aquele som...
        ' End If
    End Sub
    Private Sub frmEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Arquivo = tabela_db
        Me.Text = tabela_db

        '********************** POPULA DATASET ENTRADA ******************************************
        sql(0) = "SELECT * FROM " & tabela_db & " ORDER BY ID_ENTRADA ASC"
        Dim cm As New OleDbCommand(sql(0), cn)
        da = New OleDbDataAdapter(cm)
        ds.EnforceConstraints = False
        ds.Tables.Add(tabela_db)
        ds.Tables(tabela_db).BeginLoadData()
        da.Fill(ds, tabela_db)
        ds.Tables(tabela_db).EndLoadData()
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Nao existe nenhuma " & tabela_db & " cadastrada, cadastre o primeiro.", MsgBoxStyle.Information, fabricante)
        End If
        '********************** PREENCHE 2º DATASET ENTRADA_ITENS *********************************************
        'If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
        sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE ID_ENTRADA_ITENS = 0"
        Dim cmi As New OleDbCommand(sql(0), cn)
        dai = New OleDbDataAdapter(cmi)
        dsi.EnforceConstraints = False
        dsi.Tables.Add("ENTRADA_ITENS")
        dsi.Tables("ENTRADA_ITENS").BeginLoadData()
        dai.Fill(dsi, "ENTRADA_ITENS")
        dsi.Tables("ENTRADA_ITENS").EndLoadData()
        DGVLotes.DataSource = dsi.Tables(0)                 'POPULA GRID
        FormataGridLotes()

        sql(0) = "SELECT * FROM qENTRADA_ITENS_ESTOQUE WHERE ID_ENTRADA_ITENS = 0"
        Dim cmis As New OleDbCommand(sql(0), cn)
        dais = New OleDbDataAdapter(cmi)
        dsis.EnforceConstraints = False
        dsis.Tables.Add("qENTRADA_ITENS_ESTOQUE")
        dsis.Tables("qENTRADA_ITENS_ESTOQUE").BeginLoadData()
        dais.Fill(dsi, "qENTRADA_ITENS_ESTOQUE")
        dsis.Tables("qENTRADA_ITENS_ESTOQUE").EndLoadData()
        gridSaldos.DataSource = dsis.Tables(0)                 'POPULA GRID
        If dsis.Tables(0).Rows.Count > 0 Then
            FormataGridLotesSaldo()
        End If
        '********************** PREENCHE DATASET NOTA_ENTRADA **************************************
        If DGVNotas.Rows.Count > 0 Then dsn.Tables(0).Clear()
        sql(0) = "SELECT * FROM NOTA_ENTRADA WHERE ID = 0"
        Dim cmn As New OleDbCommand(sql(0), cn)
        dan = New OleDbDataAdapter(cmn)
        dsn.EnforceConstraints = False
        dsn.Tables.Add("NOTA_ENTRADA")
        dsn.Tables("NOTA_ENTRADA").BeginLoadData()
        dan.Fill(dsn, "NOTA_ENTRADA")
        dsn.Tables("NOTA_ENTRADA").EndLoadData()
        DGVNotas.DataSource = dsn.Tables(0)                 'ASSOCIA O GRID AO DATASET
        DGVNotas.RowHeadersWidth = 24
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns.Remove("NF_DEPOSITO")                                      'NF_DEPOSITO
        Dim colnf As New DataGridViewTextBoxColumn
        colnf.MaxInputLength = 10
        colnf.DataPropertyName = "NF_DEPOSITO"
        colnf.HeaderText = "Nº NOTA"
        colnf.Width = 80
        DGVNotas.Columns.Add(colnf)
        DGVNotas.Columns(5).DisplayIndex = 0
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns.Remove("DATA")                                             'DATA
        Dim coldata As New CalendarColumn
        coldata.DataPropertyName = "DATA"
        coldata.HeaderText = "DATA"
        coldata.Width = 83
        DGVNotas.Columns.Add(coldata)
        DGVNotas.Columns(6).DisplayIndex = 1
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns(0).Width = 50                                             'SACAS
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns(1).Width = 60                                             'UNITARIO
        DGVNotas.Columns(1).DefaultCellStyle.Format = "c"
        DGVNotas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns(2).HeaderText = "TOTAL"                                    'VALOR
        DGVNotas.Columns(2).Width = 95
        DGVNotas.Columns(2).DefaultCellStyle.Format = "c"
        DGVNotas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVNotas.Columns(2).ReadOnly = True
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns(3).Visible = False                                         'ID_ENTRADA
        '--------------------------------------------------------------------------------------
        DGVNotas.Columns(4).Visible = False                                         'ID


        '********************** PREENCHE DATASET SACARIA_ENTRADA ***************************************************************************
        If DGVSacaria.Rows.Count > 0 Then dssc1.Tables(0).Clear()
        sql(0) = "SELECT * FROM SACARIA_ENTRADA WHERE ID_ENTRADA = 0"
        Dim cmsc As New OleDbCommand(sql(0), cn)
        dasc1 = New OleDbDataAdapter(cmsc)
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc1.EnforceConstraints = False
        dssc1.Tables.Add("SACARIA_ENTRADA")
        dssc1.Tables("SACARIA_ENTRADA").BeginLoadData()
        '******************************************************
        dasc1.Fill(dssc1, "SACARIA_ENTRADA")
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc1.Tables("SACARIA_ENTRADA").EndLoadData()
        '******************************************************
        DGVSacaria.DataSource = dssc1.Tables(0)             'PRIMEIRO PREENCHE O DATASOURCE DO GRID
        DGVSacaria.Columns.Remove("ID_SACARIA")             'SEGUNDO REMOVE A COLUNA ID_SACARIA Q FAZ O LINK
        Dim colsacaria As New DataGridViewComboBoxColumn    'TERCEIRO ADCIONE A COLUNA COMBOBOX DA TABELA EXTERNA
        colsacaria.DataPropertyName = "ID_SACARIA"          'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        colsacaria.HeaderText = "SACARIA"
        colsacaria.Width = 115
        DGVSacaria.Columns.Add(colsacaria)
        sql(0) = "SELECT * FROM SACARIA"                    'QUARTO PREENCHE A COMBOBOX COM OS DADOS DA TABELA EXTERNA
        Dim cmscent As New OleDbCommand(sql(0), cn)
        dasc2 = New OleDbDataAdapter(cmscent)
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc2.EnforceConstraints = False
        dssc2.Tables.Add("SACARIA")
        dssc2.Tables("SACARIA").BeginLoadData()
        '******************************************************
        dasc2.Fill(dssc2, "SACARIA")
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc2.Tables("SACARIA").EndLoadData()
        '******************************************************

        colsacaria.DataSource = dssc2.Tables(0)
        colsacaria.ValueMember = "ID_SACARIA"               'COMPO LINK COM O CAMPO DO GRID
        colsacaria.DisplayMember = "DESCRI"
        DGVSacaria.RowHeadersWidth = 24
        DGVSacaria.Columns(3).DisplayIndex = 0              'MOVE A COLUNA SACARIA PARA A PRIMEIRO POSIÇÃO DAS COLUNAS
        DGVSacaria.Columns(2).DisplayIndex = 1              'MOVE A COLUNA QTDE PARA A SEGUNDA POSIÇÃO DAS COLUNAS
        DGVSacaria.Columns(2).HeaderText = "QTDE"
        DGVSacaria.Columns(2).Width = 50
        DGVSacaria.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSacaria.Columns(2).DefaultCellStyle.Format = "###,###0.0"
        DGVSacaria.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSacaria.Columns(0).Visible = False
        DGVSacaria.Columns(1).Visible = False
        '********************** PREENCHE DATASET SERVICO_OPERACAO *******************************************************************************
        If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
        sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE ID_SERVICO = 0"
        Dim cm_op As New OleDbCommand(sql(0), cn)
        da_ser_oper = New OleDbDataAdapter(cm_op)
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_ser_oper.EnforceConstraints = False                 '*
        ds_ser_oper.Tables.Add("SERVICO_OPERACAO")             '*
        ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData() '*
        '********************************************************
        da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()   '*
        '********************************************************

        DGVServicos.DataSource = ds_ser_oper.Tables(0)       'PREENCHE O DATASOURCE DO GRID

        Dim coloperacao As New DataGridViewComboBoxColumn    'ADCIONE A COLUNA COMBOBOX DA TABELA EXTERNA
        coloperacao.DataPropertyName = "ID_OPERACAO"         'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        coloperacao.HeaderText = "OPERACAO"                  'NOME DA COLUNA(ROTULO) COMBO 
        coloperacao.Width = 150
        DGVServicos.Columns.Add(coloperacao)                 'ADCIONA O COMBO NO GRID
        sql(0) = "SELECT * FROM OPERACAO ORDER BY DESCRI ASC"                    'PREENCHE A COMBOBOX COM OS DADOS DA TABELA EXTERNA
        Dim cmop As New OleDbCommand(sql(0), cn)
        da_oper = New OleDbDataAdapter(cmop)

        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_oper.EnforceConstraints = False                     '*
        ds_oper.Tables.Add("OPERACAO")                         '*
        ds_oper.Tables("OPERACAO").BeginLoadData()             '*
        '********************************************************
        da_oper.Fill(ds_oper, "OPERACAO")
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_oper.Tables("OPERACAO").EndLoadData()               '*
        '********************************************************
        coloperacao.DataSource = ds_oper.Tables(0)
        coloperacao.ValueMember = "ID_OPERACAO"             'CAMPO INDICE DO CAMPO
        coloperacao.DisplayMember = "DESCRI"                'CAMPO DADO A SER EXIBIDO NO COMBO
        '******************** PREENCHE COMBO COBRANÇA ******************************************************************************************
        Dim col_cob As New DataGridViewComboBoxColumn       'ADCIONE A COLUNA COMBOBOX DA TABELA EXTERNA
        col_cob.DataPropertyName = "ID_COBRANCA"            'COLUNA Q FAZ O LINK COM A COLUNA DA TB DO GRID
        col_cob.HeaderText = "NOME"                         'NOME DA COLUNA(ROTULO) COMBO 
        col_cob.Width = 100
        DGVServicos.Columns.Add(col_cob)                    'ADCIONA O COMBO NO GRID
        sql(0) = "SELECT * FROM COBRANCA ORDER BY DESCRI ASC"                   'PREENCHE A COMBOBOX COM OS DADOS DA TABELA EXTERNA
        Dim cm_cob As New OleDbCommand(sql(0), cn)
        da_cob = New OleDbDataAdapter(cm_cob)

        'OTIMIZA PREENCHIMENTO DO DATASET***********************
        ds_cob.EnforceConstraints = False                     '*
        ds_cob.Tables.Add("COBRANCA")                         '*
        ds_cob.Tables("COBRANCA").BeginLoadData()             '*
        '*******************************************************
        da_cob.Fill(ds_cob, "COBRANCA")
        'OTIMIZA PREENCHIMENTO DO DATASET***********************
        ds_cob.Tables("COBRANCA").EndLoadData()               '*
        '*******************************************************

        col_cob.DataSource = ds_cob.Tables(0)
        col_cob.ValueMember = "ID_COBRANCA"                 'CAMPO INDICE DO CAMPO
        col_cob.DisplayMember = "DESCRI"                    'CAMPO DADO A SER EXIBIDO NO COMBO

        DGVServicos.RowHeadersWidth = 24
        DGVServicos.Columns(0).Visible = False              'ID_SERVICO_OPER
        DGVServicos.Columns(1).Visible = False              'ID_SERVICO
        DGVServicos.Columns(2).Visible = False              'ID_OPER_COB
        DGVServicos.Columns(3).Visible = False              'DATA_SERVICO
        DGVServicos.Columns(4).Visible = False              'HORA_SERVICO
        DGVServicos.Columns(5).Visible = False              'DATA_SAIDA
        DGVServicos.Columns(6).Visible = False              'HORA_SAIDA
        DGVServicos.Columns(7).Width = 50                   'SACAS
        DGVServicos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVServicos.Columns(8).HeaderText = "VALOR"         'VALOR_OP_SACA
        DGVServicos.Columns(8).DefaultCellStyle.Format = "c"
        DGVServicos.Columns(8).Width = 50
        DGVServicos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVServicos.Columns(8).ReadOnly = True
        DGVServicos.Columns(9).DefaultCellStyle.Format = "c" 'TOTAL
        DGVServicos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVServicos.Columns(9).ReadOnly = True
        DGVServicos.Columns(9).Width = 70
        DGVServicos.Columns(10).Visible = False             'DIAS
        DGVServicos.Columns(11).Visible = False             'PAGO
        DGVServicos.Columns(12).Visible = False             'ID_DEPOSITANTE
        DGVServicos.Columns(13).Visible = False             'FE
        DGVServicos.Columns(14).Visible = False             'SE
        DGVServicos.Columns(15).Visible = False             'OR

        DGVServicos.Columns(16).Visible = False             'OUTRAS COBRANÇAS

        DGVServicos.Columns(17).DisplayIndex = 0            'OPERACAO  'MOVE A COLUNA COMBO OPERACAO PARA A PRIMEIRA POSIÇÃO DAS COLUNAS
        DGVServicos.Columns(17).Width = 220
        DGVServicos.Columns(18).DisplayIndex = 1            'COBRANCA  'MOVE A COLUNA COMBO COBRANCA PARA A SEGUNDA POSIÇÃO DAS COLUNAS
        DGVServicos.Columns(18).Width = 220
        DGVServicos.Columns(17).Visible = False 'ID_COB

        estadobotao("inicio")
        habilita(Me, False)
        mskFE.Mask = "####/##"

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
        '****PREENCHE COMBO AUTO COMPLETAR ORIGEM**********************************
        sql(0) = "SELECT * FROM ORIGEM ORDER BY DESCRI"
        Dim cmor As New OleDbCommand(sql(0), cn)
        daori = New OleDbDataAdapter(cmor)
        dsori.EnforceConstraints = False
        dsori.Tables.Add("ORIGEM")
        dsori.Tables("ORIGEM").BeginLoadData()
        daori.Fill(dsori, "ORIGEM")
        dsori.Tables("ORIGEM").EndLoadData()
        With cboRemetente
            .AutoCompleteCustomSource.Add(dsori.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = dsori.Tables(0)
            .DisplayMember = dsori.Tables(0).Columns(1).ToString
            .ValueMember = dsori.Tables(0).Columns(0).ToString
            .Text = ""
        End With
        mskFEConsulta.Enabled = True
        txtConsulLote.Enabled = True
        altera = False
        cadastrando = False
        ckbConsulta.Checked = True
        mskFEConsulta.Mask = "####/##"
        mskFEConsulta.Focus()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        altera = True
        cadastrando = False
        mskCodSerOrigem.Enabled = False
        mskCodRetOrigem.Enabled = False
        ckbConsulta.Enabled = False
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcluir.Click
        Dim resp As String
        resp = MsgBox("Deseja realmente excluir esse registro?", MsgBoxStyle.YesNo)
        Cursor.Current = Cursors.WaitCursor
        If resp = vbYes Then
            'EXCLUI DA TAB ENTRADA ***********************************************************
            sql(0) = "DELETE FROM " & tabela_db & " WHERE ID_ENTRADA = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cment As New OleDbCommand(sql(0), cn)
            cment.ExecuteNonQuery()
            ds.Clear()
            ds.Dispose()
            'LIMPA E REPREENCHE O DATASET
            sql(0) = "SELECT * FROM " & tabela_db & ""
            Dim cm As New OleDbCommand(sql(0), cn)
            da = New OleDbDataAdapter(cm)
            ds.EnforceConstraints = False
            If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db)
            ds.Tables(tabela_db).BeginLoadData()
            da.Fill(ds, tabela_db)
            ds.Tables(tabela_db).EndLoadData()
            'EXCLUI DA TAB ENTRADA_ITENS *****************************************************
            sql(0) = "DELETE FROM ENTRADA_ITENS WHERE ID_ENTRADA = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmlo As New OleDbCommand(sql(0), cn)
            cmlo.ExecuteNonQuery()
            dsi.Clear()
            dsi.Dispose()
            'LIMPA E REPREENCHE O DATASET
            sql(0) = "SELECT * FROM ENTRADA_ITENS"
            Dim cmi As New OleDbCommand(sql(0), cn)
            dai = New OleDbDataAdapter(cmi)
            dsi.EnforceConstraints = False
            If dsi.Tables.Count = 0 Then dsi.Tables.Add("ENTRADA_ITENS")
            dsi.Tables("ENTRADA_ITENS").BeginLoadData()
            dai.Fill(dsi, "ENTRADA_ITENS")
            dsi.Tables("ENTRADA_ITENS").EndLoadData()

            'EXCLUI DA TAB NOTA_ENTRADA ******************************************************
            sql(0) = "DELETE FROM NOTA_ENTRADA WHERE ID_ENTRADA = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmno As New OleDbCommand(sql(0), cn)
            cmno.ExecuteNonQuery()
            dsn.Clear()
            dsn.Dispose()
            'LIMPA E REPREENCHE O DATASET
            sql(0) = "SELECT * FROM NOTA_ENTRADA"
            Dim cmn As New OleDbCommand(sql(0), cn)
            dan = New OleDbDataAdapter(cmn)
            dsn.EnforceConstraints = False
            If dsn.Tables.Count = 0 Then dsn.Tables.Add("NOTA_ENTRADA")
            dsn.Tables("NOTA_ENTRADA").BeginLoadData()
            dan.Fill(dsn, "NOTA_ENTRADA")
            dsn.Tables("NOTA_ENTRADA").EndLoadData()

            'EXCLUI DA TAB SACARIA_ENTRADA ***************************************************
            sql(0) = "DELETE FROM SACARIA_ENTRADA WHERE ID_ENTRADA = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmsa As New OleDbCommand(sql(0), cn)
            cmsa.ExecuteNonQuery()
            dssc1.Clear()
            dssc1.Dispose()
            'LIMPA E REPREENCHE O DATASET
            sql(0) = "SELECT * FROM SACARIA_ENTRADA"
            Dim cmsc As New OleDbCommand(sql(0), cn)
            dasc1 = New OleDbDataAdapter(cmsc)
            dssc1.EnforceConstraints = False
            If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_ENTRADA")
            dssc1.Tables("SACARIA_ENTRADA").BeginLoadData()
            dasc1.Fill(dssc1, "SACARIA_ENTRADA")
            dssc1.Tables("SACARIA_ENTRADA").EndLoadData()

            'EXCLUI DA TAB SERVICO_OPERACAO **************************************************
            sql(0) = "DELETE FROM SERVICO_OPERACAO WHERE F_E = '" & mskFE.Text & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmso As New OleDbCommand(sql(0), cn)
            cmso.ExecuteNonQuery()
            ds_ser_oper.Clear()
            ds_ser_oper.Dispose()
            'LIMPA E REPREENCHE O DATASET
            sql(0) = "SELECT * FROM SERVICO_OPERACAO"
            Dim cm_op As New OleDbCommand(sql(0), cn)
            da_ser_oper = New OleDbDataAdapter(cm_op)
            ds_ser_oper.EnforceConstraints = False                 '*
            If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
            ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData() '*
            da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
            ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()   '*

            limpa(Me)
            estadobotao("inicio")
            MsgBox(tabela_db & " Excluído com sucesso!", MsgBoxStyle.Information, fabricante)
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        ds_ser_oper.Dispose()
        ds_oper.Dispose()
        ds_cob.Dispose()
        ds_oper_cob.Dispose()
        ds.Dispose()
        dsdepo.Dispose()
        dsori.Dispose()
        dsi.Dispose()
        dsn.Dispose()
        dssc1.Dispose()
        dssc2.Dispose()
        Me.Close()
    End Sub
    Private Sub limpa(ByVal form As Form)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DateTimePicker Or form.Controls(i).Name = "lblTotalSacas" Or form.Controls(i).Name = "lblTotalPeso" Or form.Controls(i).Name = "lblTotalSacaria" Then
                form.Controls(i).Text = ""
            End If
        Next i
        If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
        If DGVNotas.Rows.Count > 0 Then dsn.Tables(0).Clear()
        If DGVSacaria.Rows.Count > 0 Then dssc1.Tables(0).Clear()
        If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
        If gridSaldos.Rows.Count > 0 Then dsis.Tables(0).Clear()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        estadobotao("inicio")
        limpa(Me)
        habilita(Me, False)
        altera = False
        cadastrando = False
        mskFEConsulta.Enabled = True
        txtConsulLote.Enabled = True
    End Sub
    Private Sub txtMotorista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMotorista.KeyDown
        If (e.KeyCode = Keys.Return) Then DGVLotes.Focus()
    End Sub
    Private Sub txtMotorista_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotorista.Leave
        txtMotorista.Text = UCase(txtMotorista.Text)
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim registro As Integer = 0
        id_entrada = 0
        If cboDepositante.Text = "" Or IsNothing(cboDepositante.SelectedValue) Then
            MessageBox.Show("Informe o depositante", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDepositante.Focus()
            Exit Sub
        ElseIf DGVLotes.RowCount = 1 Then
            MessageBox.Show("Informe os lotes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DGVLotes.Focus()
            Exit Sub
        Else
            If altera = True Then
                Alterando()
            Else
                'CONSULTA SE JÁ EXISTE UM FE************************************************************************
                sql(0) = "SELECT * FROM " & tabela_db & " WHERE FE = '" & mskFE.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cma As New OleDbCommand(sql(0), cn)
                Dim dr_busca_repitido As OleDbDataReader = cma.ExecuteReader
                If dr_busca_repitido.HasRows Then
                    MessageBox.Show("Já existe essa FE!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mskFE.Focus()
                    Exit Sub
                Else
                    Incluindo()
                End If
                '****************************************************************************************************
            End If
            '******************* ATUALIZA DATASET ENTRADA **************************************
            
            Dim cmb As New OleDbCommandBuilder(da)
            da.Update(ds, tabela_db)
            '******************* BUSCA O ID DA NOVA FE *****************************************
            sql(0) = "SELECT FE, ID_ENTRADA FROM " & tabela_db & ""
            Dim cm_ser As New OleDbCommand(sql(0), cn)
            da_s = New OleDbDataAdapter(cm_ser)
            'OTIMIZA PREENCHIMENTO DO DATASET**************************
            ds_s.EnforceConstraints = False                          '*
            If ds_s.Tables.Count = 0 Then ds_s.Tables.Add(tabela_db) '*
            ds_s.Tables(tabela_db).BeginLoadData()                   '*
            '**********************************************************
            da_s.Fill(ds_s, tabela_db)
            'OTIMIZA PREENCHIMENTO DO DATASET******
            ds_s.Tables(tabela_db).EndLoadData() '*
            '**************************************
            If ds_s.Tables(tabela_db).Rows.Count > 0 Then
                dr_s = ds_s.Tables(tabela_db).Select("FE = '" & mskFE.Text & "'")(0)
                id_entrada = dr_s("ID_ENTRADA")
            End If
            If cn.State = 0 Then cn.Open()
            sql(0) = "SELECT FE, ID_ENTRADA FROM " & tabela_db & " WHERE FE= '" & mskFE.Text & "'"
            Dim cm_ser2 As New OleDbCommand(sql(0), cn)
            Dim dr_busca_id As OleDbDataReader = cm_ser2.ExecuteReader
            If dr_busca_id.HasRows Then
                Do While dr_busca_id.Read
                    id_entrada = dr_busca_id.GetInt32(1)
                Loop
            End If

            If id_entrada > 0 Then

                'Dim con = GetConnection()



                '***********************************     ENTRADA_ITENS      *****************************************
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                cmlo.ExecuteNonQuery()

                For registro = 0 To DGVLotes.Rows.Count - 2
                    DGVLotes.Rows(registro).Cells("ID_ENTRADA").Value = id_entrada
                Next
                'ATUALIZA DATASET ENTRADA_ITENS
                dai.ContinueUpdateOnError = True
                Dim cb As New OleDbCommandBuilder(dai)
                Dim xxx As String
                xxx = cb.GetUpdateCommand.CommandText

                dai.Update(dsi, "ENTRADA_ITENS")
                dsi.AcceptChanges()

                'ATUALIZA O CAMPO id_entrada que está igual a 0
                sql(0) = "UPDATE ENTRADA_ITENS SET ID_ENTRADA = " & id_entrada & " WHERE ID_ENTRADA = 0"
                If cn.State = 0 Then cn.Open()
                Dim cmlo2 As New OleDbCommand(sql(0), cn)
                cmlo2.ExecuteNonQuery()

                'CADASTRA O ESTOQUE DO LOTE
                Dim row As DataRow
                Dim qtde_sacas As Integer
                Dim lote As String
                Dim data_cad As Date
                Dim Existe As Boolean = False
                If cn.State = 0 Then cn.Open()
                Using con = GetConnection()
                    For Each row In dsi.Tables(0).Rows
                        lote = row(0)
                        data_cad = Date.Now.ToString("dd/M/yyyy")
                        qtde_sacas = row(1)

                        'CONSULTA O SALDO DO LOTE
                        sql(0) = "SELECT MIN(QTDE) AS QTDE_SCS FROM ESTOQUE_LOTE WHERE LOTE ='" & lote & "'"
                        Dim cm_sal As New OleDbCommand(sql(0), cn)
                        Dim dr_sal As OleDbDataReader = cm_sal.ExecuteReader
                        If dr_sal.HasRows Then
                            Do While dr_sal.Read
                                If Not IsDBNull(dr_sal("QTDE_SCS")) Then
                                    Existe = True
                                End If
                            Loop
                        End If

                        If Existe = False Then
                            Dim cmdx = New OleDbCommand()
                            cmdx.CommandType = CommandType.Text
                            cmdx.CommandText = "INSERT INTO ESTOQUE_LOTE ([LOTE],[DATA],[QTDE]) values (@LOTE,@DATA,@QTDE);"
                            cmdx.Parameters.Add("@LOTE", OleDbType.VarChar).Value = lote
                            cmdx.Parameters.Add("@DATA", OleDbType.Date).Value = data_cad
                            cmdx.Parameters.Add("@QTDE", OleDbType.Integer).Value = qtde_sacas
                            cmdx.Connection = cn
                            cmdx.ExecuteNonQuery()
                        End If
                    Next
                End Using

                If cn.State = 0 Then cn.Open()
                '************************************     NOTA_ENTRADA     *******************************************
                For registro = 0 To DGVNotas.Rows.Count - 2
                    DGVNotas.Rows(registro).Cells("ID_ENTRADA").Value = id_entrada
                Next

                'ATUALIZA DATASET NOTA_ENTRADA
                Dim cbn As New OleDbCommandBuilder(dan)
                dan.Update(dsn, "NOTA_ENTRADA")
                dsn.AcceptChanges()

                'ATUALIZA O CAMPO id_entrada que está igual a 0
                sql(0) = "UPDATE NOTA_ENTRADA SET ID_ENTRADA = " & id_entrada & " WHERE ID_ENTRADA = 0"
                If cn.State = 0 Then cn.Open()
                Dim cmno As New OleDbCommand(sql(0), cn)
                cmno.ExecuteNonQuery()

                '**************************************      SACARIA        *******************************************
                For registro = 0 To DGVSacaria.Rows.Count - 2
                    DGVSacaria.Rows(registro).Cells("ID_ENTRADA").Value = id_entrada
                Next

                'ATUALIZA DATASET SACARIA_ENTRADA
                Dim cbsc As New OleDbCommandBuilder(dasc1)
                dasc1.Update(dssc1, "SACARIA_ENTRADA")
                dssc1.AcceptChanges()

                'ATUALIZA O CAMPO id_entrada que está igual a 0
                sql(0) = "UPDATE SACARIA_ENTRADA SET ID_ENTRADA = " & id_entrada & " WHERE ID_ENTRADA = 0"
                If cn.State = 0 Then cn.Open()
                Dim cmsc As New OleDbCommand(sql(0), cn)
                cmsc.ExecuteNonQuery()


                '*********************************        SERVICO_OPERACAO        *************************************
                For registro = 0 To DGVServicos.Rows.Count - 2
                    DGVServicos.Rows(registro).Cells("F_E").Value = mskFE.Text 'INDICE 16 NO DATAGRIDVIEW COM A MUDANÇA DOS INDICES
                Next

                'ATUALIZA DATASET SERVICO_OPERACAO
                Dim cbop As New OleDbCommandBuilder(da_ser_oper)
                da_ser_oper.Update(ds_ser_oper, "SERVICO_OPERACAO")
                ds_ser_oper.AcceptChanges()

                'ATUALIZA O CAMPO id_entrada que está igual a 9999999
                sql(0) = "UPDATE SERVICO_OPERACAO SET F_E = '" & mskFE.Text & "' WHERE F_E = '9999999'"
                If cn.State = 0 Then cn.Open()
                Dim cmop As New OleDbCommand(sql(0), cn)
                cmop.ExecuteNonQuery()

                'ATUALIZA A FE NA TAB SERVICO_OPERACAO CASO HAJA MUDANÇAO NO Nº DA FE
                If altera = True Then
                    If mskFE.Text <> fe_aux Then
                        If fe_aux <> "" Then
                            sql(0) = "UPDATE SERVICO_OPERACAO SET F_E = '" & mskFE.Text & "' WHERE F_E = '" & fe_aux & "'"
                            If cn.State = 0 Then cn.Open()
                            Dim cmse As New OleDbCommand(sql(0), cn)
                            cmse.ExecuteNonQuery()
                        End If
                    End If
                End If

                'REPREENCHE O DATASET DO GRID SERVICO_OPERACAO
                If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE F_E = '" & mskFE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                Dim cm_op As New OleDbCommand(sql(0), cn)
                da_ser_oper = New OleDbDataAdapter(cm_op)
                'OTIMIZA PREENCHIMENTO DO DATASET
                ds_ser_oper.EnforceConstraints = False
                If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO")
                ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()
                '*********************************
                da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
                'OTIMIZA PREENCHIMENTO DO DATASET************
                ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()
                '********************************************
                For xx = 0 To ds_ser_oper.Tables(0).Rows.Count - 1
                    sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_ser_oper.Tables(0).Rows(xx).Item(2) & ""
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
                '************ ATUALIZA O DEPOSITANTE NO FINANCEIRO QUANDO MUDA AQUI NA ENTRADA ************************
                If codigo_depositante <> codigo_depositante_aux Then
                    sql(0) = "UPDATE SERVICO_OPERACAO SET ID_DEPOSITANTE = " & codigo_depositante & " WHERE F_E = '" & mskFE.Text & "'"
                    If cn.State = 0 Then cn.Open()
                    Dim cmdepos As New OleDbCommand(sql(0), cn)
                    cmdepos.ExecuteNonQuery()
                End If

                sql(0) = "UPDATE SERVICO_OPERACAO SET DATA_SERVICO = '" & dtpDataEntrada.Text & "' WHERE F_E = '" & mskFE.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cmddata As New OleDbCommand(sql(0), cn)
                cmddata.ExecuteNonQuery()
            End If
        End If
        '******************* RECALCULA TOTAIS *******************************************
        If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
        If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
        habilita(Me, False)
        estadobotao("exibido")
        cadastrando = False
        cmdConsultar.Focus()
        Cursor.Current = Cursors.Default
        If altera = True Then
            MessageBox.Show("Alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        altera = False
    End Sub
    Private Sub habilita(ByVal form As Form, ByVal habil As Boolean)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DataGridView Or TypeOf form.Controls(i) Is System.Windows.Forms.DateTimePicker Then
                form.Controls(i).Enabled = habil
            End If
        Next i
    End Sub
    Private Sub DGVLotes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLotes.CellEndEdit
        If e.ColumnIndex = 0 Then 'LOTE

            sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE LOTE='" & DGVLotes.Item(0, e.RowIndex).Value.ToString & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmlo As New OleDbCommand(sql(0), cn)
            Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
            If dr_busca_id.HasRows Then
                MessageBox.Show("O lote : [ " & DGVLotes.Item(0, e.RowIndex).Value & " ] já existe no estoque, informe outro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SendKeys.Send("{HOME}")
                DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                DGVLotes.Item(3, e.RowIndex).Value = DBNull.Value  'ID_ENTRADA
                DGVLotes.CancelEdit()
            End If
            DGVLotes.CurrentCell.Value = DGVLotes.CurrentCell.Value.ToString.ToUpper()

        ElseIf e.ColumnIndex = 1 Then 'SACAS

            If Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(1).Value) And Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(2).Value) And Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(8).Value) Then

                DGVLotes.Rows(e.RowIndex).Cells(8).Value = DGVLotes.Item(2, e.RowIndex).Value / DGVLotes.Item(1, e.RowIndex).Value
                DGVLotes.Rows(e.RowIndex).Cells(2).Value = Round(DGVLotes.Rows(e.RowIndex).Cells(1).Value * DGVLotes.Rows(e.RowIndex).Cells(8).Value, 1)
            Else
                If txtMediaSaca.Text <> "" Then
                    DGVLotes.Rows(e.RowIndex).Cells(2).Value = DGVLotes.Rows(e.RowIndex).Cells(1).Value * txtMediaSaca.Text
                    DGVLotes.Rows(e.RowIndex).Cells(8).Value = Round(DGVLotes.Item(2, e.RowIndex).Value / DGVLotes.Item(1, e.RowIndex).Value, 2)
                End If
            End If
            If IsDBNull(DGVLotes.Item(0, e.RowIndex).Value) Then
                If IsDBNull(DGVLotes.Item(1, e.RowIndex).Value) Or IsDBNull(DGVLotes.Item(2, e.RowIndex).Value) Or IsDBNull(DGVLotes.Item(8, e.RowIndex).Value) Then
                    MessageBox.Show("Informe o [LOTE] primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SendKeys.Send("{HOME}")
                    DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                    DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                    DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                    DGVLotes.Item(8, e.RowIndex).Value = DBNull.Value  'MEDIA
                    DGVLotes.CancelEdit()
                End If
            End If

        ElseIf e.ColumnIndex = 2 Then 'PESO

            If Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(1).Value) And Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(2).Value) Then
                DGVLotes.Rows(e.RowIndex).Cells(8).Value = DGVLotes.Item(2, e.RowIndex).Value / DGVLotes.Item(1, e.RowIndex).Value
            End If

        End If
        '******************* RECALCULA TOTAIS *******************************************
        SOMALOTES()
    End Sub
    Private Sub DGVLotes_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles DGVLotes.CellToolTipTextNeeded
        If altera = True And cadastrando = False Then
            If e.ColumnIndex = DGVLotes.Columns("LOTE").Index Then
                If e.RowIndex <> -1 Then
                    sql(0) = "SELECT LOTE, SALDO_SACAS, SALDO_PESO FROM qLOTES_SERVICO_RETIRADA WHERE LOTE='" & DGVLotes.Item(0, e.RowIndex).Value & "'"
                    If cn.State = 0 Then cn.Open()
                    Dim cmlo As New OleDbCommand(sql(0), cn)
                    Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                    If dr_busca_id.HasRows Then
                        While dr_busca_id.Read
                            e.ToolTipText = "LOTE : " & dr_busca_id("LOTE") & ",  SALDO SACAS => " & FormatNumber(dr_busca_id("SALDO_SACAS"), 1) & "    e    SALDO PESO => " & FormatNumber(dr_busca_id("SALDO_PESO"), 3) & ""
                        End While
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub DGVLotes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVLotes.DataError
        'Se a fonte de dados levanta uma exceção quando uma célula esta comitda exibe um erro.
        'se digitou o lote repetido
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 1 Then 'SACA
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 2 Then 'PESO
            MessageBox.Show("A coluna [PESO] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 8 Then 'MEDIA
            MessageBox.Show("A coluna [MÉDIA] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("O lote nao pode repetir.")
        End If
    End Sub
    Private Sub DGVLotes_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVLotes.UserAddedRow
        DGVLotes.Rows(e.Row.Index - 1).Cells("ID_ENTRADA").Value = id_entrada
    End Sub
    Private Sub txtPesoObrigatorio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoObrigatorio.KeyDown
        If (e.KeyCode = Keys.Return) Then txtMediaSaca.Focus()
    End Sub
    Private Sub txtPesoObrigatorio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoObrigatorio.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtPesoBalanca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoBalanca.KeyDown
        If (e.KeyCode = Keys.Return) Then txtTotalSacas.Focus()
    End Sub
    Private Sub txtPesoBalanca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoBalanca.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtMediaSaca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMediaSaca.KeyDown
        If (e.KeyCode = Keys.Return) Then txtSafra.Focus()
    End Sub
    Private Sub txtMediaSaca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMediaSaca.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtSafra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSafra.KeyDown
        If (e.KeyCode = Keys.Return) Then txtProcedencia.Focus()
    End Sub
    Private Sub txtSafra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSafra.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub DGVLotes_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVLotes.UserDeletedRow
        SOMALOTES()
    End Sub
    Private Sub DGVLotes_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGVLotes.UserDeletingRow
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
    Private Sub FormataGridLotes()
        DGVLotes.RowHeadersWidth = 24
        DGVLotes.Columns(0).Width = 67
        DGVLotes.Columns(1).Width = 52
        DGVLotes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVLotes.Columns(1).DefaultCellStyle.Format = "###,###0.0"
        DGVLotes.Columns(2).Width = 61
        DGVLotes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVLotes.Columns(2).DefaultCellStyle.Format = "###,###0.0"
        DGVLotes.Columns(3).Visible = False
        DGVLotes.Columns(4).Visible = False
        DGVLotes.Columns(5).Visible = False
        DGVLotes.Columns(6).Visible = False
        DGVLotes.Columns(7).Visible = False
        DGVLotes.Columns(8).Width = 47
        DGVLotes.Columns(8).DefaultCellStyle.Format = "###,###0.00"
        DGVLotes.Columns(9).Width = 60
        DGVLotes.Columns(10).Width = 47
        DGVLotes.Columns(11).Width = 80

    End Sub
    Private Sub FormataGridLotesSaldo()

        gridSaldos.RowHeadersWidth = 4
        gridSaldos.Columns(0).Visible = False
        gridSaldos.Columns(1).Visible = False
        gridSaldos.Columns(2).Visible = False
        gridSaldos.Columns(3).Visible = False
        gridSaldos.Columns(4).Visible = False
        gridSaldos.Columns(5).Visible = False
        gridSaldos.Columns(6).Visible = False
        gridSaldos.Columns(7).Visible = False
        gridSaldos.Columns(8).Visible = False
        gridSaldos.Columns(9).Visible = False
        gridSaldos.Columns(10).Visible = False
        gridSaldos.Columns(11).Visible = False
        gridSaldos.Columns(12).Width = 55
        gridSaldos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        gridSaldos.Columns(12).DefaultCellStyle.Format = "###,###0.0"


    End Sub

    Private Sub DGVNotas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVNotas.CellEndEdit
        If e.ColumnIndex = 2 And Not IsDBNull(DGVNotas.Rows(e.RowIndex).Cells(2).Value) And Not IsDBNull(DGVNotas.Rows(e.RowIndex).Cells(3).Value) Then
            DGVNotas.Rows(e.RowIndex).Cells(4).Value = DGVNotas.Rows(e.RowIndex).Cells(2).Value * DGVNotas.Rows(e.RowIndex).Cells(3).Value ' QTDE SACAS * VALOR SACA = TOTAL
        ElseIf e.ColumnIndex = 3 And Not IsDBNull(DGVNotas.Rows(e.RowIndex).Cells(2).Value) And Not IsDBNull(DGVNotas.Rows(e.RowIndex).Cells(3).Value) Then
            DGVNotas.Rows(e.RowIndex).Cells(4).Value = DGVNotas.Rows(e.RowIndex).Cells(2).Value * DGVNotas.Rows(e.RowIndex).Cells(3).Value ' QTDE SACAS * VALOR SACA = TOTAL
        End If
    End Sub
    Private Sub DGVNotas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVNotas.DataError
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 2 Then 'SACAS
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 3 Then 'VALOR UNITARIO
            MessageBox.Show("A coluna [VALOR] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 1 Then 'SACAS
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub DGVNotas_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVNotas.UserAddedRow
        DGVNotas.Rows(e.Row.Index - 1).Cells("ID_ENTRADA").Value = id_entrada
    End Sub
    Private Sub DGVNotas_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGVNotas.UserDeletingRow
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
    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        Cursor.Current = Cursors.WaitCursor
        frmReportEntrada.Show()
    End Sub
    Private Sub estadobotao(ByRef valor As String)
        If valor = "inicio" Then
            cmdCadastrar.Enabled = True
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = False
            cmdConsultar.Enabled = True
            CmdExcluir.Enabled = False
            cmdCancelar.Enabled = False
            btnImprime.Enabled = False
            cmdSair.Enabled = True
        ElseIf valor = "incluir/Salvar" Then
            cmdCadastrar.Enabled = False
            cmdAlterar.Enabled = False
            cmdSalvar.Enabled = True
            cmdConsultar.Enabled = False
            CmdExcluir.Enabled = False
            cmdCancelar.Enabled = True
            btnImprime.Enabled = False
            cmdSair.Enabled = False
        Else
            cmdCadastrar.Enabled = True
            cmdAlterar.Enabled = True
            cmdSalvar.Enabled = False
            cmdConsultar.Enabled = True
            CmdExcluir.Enabled = True
            cmdCancelar.Enabled = False
            btnImprime.Enabled = True
            cmdSair.Enabled = True
        End If
    End Sub
    Private Sub DGVSacaria_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVSacaria.CellEndEdit
        If e.ColumnIndex = 3 Then
            SOMASACARIA()
        End If
    End Sub
    Private Sub DGVSacaria_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVSacaria.DataError
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 3 Then 'SACAS
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub DGVSacaria_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVSacaria.UserAddedRow
        DGVSacaria.Rows(e.Row.Index - 1).Cells("ID_ENTRADA").Value = id_entrada
    End Sub
    Private Sub txtProcedencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProcedencia.KeyDown
        If (e.KeyCode = Keys.Return) Then MskPlaca.Focus()
    End Sub
    Private Sub txtProcedencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProcedencia.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtProcedencia.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
    Private Sub txtMotorista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotorista.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtMotorista.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
    Private Sub mskFE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskFE.GotFocus
        mskFE.SelectAll()
    End Sub
    Private Sub mskFE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFE.KeyDown
        If (e.KeyCode = Keys.Return) Then txtPesoBalanca.Focus()
    End Sub
    Private Sub mskFE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskFE.LostFocus
        Dim dview As DataView = ds.Tables(0).DefaultView
        If altera = False Then
            If mskFE.Text <> "____/__" Then
                dview.RowFilter = "FE ='" & mskFE.Text & "'"
                If dview.Count > 0 Then
                    MessageBox.Show("A FE : [ " & mskFE.Text & " ] já existe no banco de dados, informe outro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'mskFE.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub cmdCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastrar.Click
        Dim datas As DateTime = DateTime.Now
        limpa(Me)
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        altera = False
        Dim bm As BindingManagerBase
        bm = BindingContext(ds, tabela_db)
        If bm.Count = 0 Then
            mskFE.Text = (1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
        Else
            bm.Position = bm.Count
            Dim x1 As Int32 = Mid(ds.Tables(0).Rows(bm.Position).Item("FE").ToString(), 1, 4)
            mskFE.Text = (x1 + 1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
        End If
        controle_soma = True
        cadastrando = True
        id_entrada = 0
        cboDepositante.Text = ""
        cboRemetente.Text = ""
        codigo_depositante_aux = 0
        cboDepositante.Focus()
        ckbConsulta.Enabled = False
        mskCodSerOrigem.Enabled = False
        mskCodRetOrigem.Enabled = False
    End Sub
    Private Sub DGVServicos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVServicos.CellEndEdit
        If Not DGVServicos.Rows(e.RowIndex).Cells(0).Value Is Nothing And Not DGVServicos.Rows(e.RowIndex).Cells(1).Value Is Nothing And Not DGVServicos.Rows(e.RowIndex).Cells(1).Value Is DBNull.Value Then
            Cursor.Current = Cursors.WaitCursor
            If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Then
                sql(0) = "SELECT * FROM OPERACAO_COBRANCA WHERE ID_OPERACAO= " & DGVServicos.Rows(e.RowIndex).Cells(0).Value & " AND ID_COBRANCA = " & DGVServicos.Rows(e.RowIndex).Cells(1).Value & ""
                Dim StrHora As DateTime = DateTime.Now.ToShortTimeString
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                If dr_busca_id.HasRows Then
                    While dr_busca_id.Read
                        DGVServicos.Rows(e.RowIndex).Cells(4).Value = dr_busca_id("ID_OPER_COB")
                        DGVServicos.Rows(e.RowIndex).Cells(5).Value = dtpDataEntrada.Text 'DATA SERVICO
                        DGVServicos.Rows(e.RowIndex).Cells(6).Value = StrHora 'HORA SERVICO
                        DGVServicos.Rows(e.RowIndex).Cells(7).Value = DBNull.Value 'DATA SERVICO
                        DGVServicos.Rows(e.RowIndex).Cells(8).Value = StrHora 'HORA SERVICO
                        DGVServicos.Rows(e.RowIndex).Cells(10).Value = dr_busca_id("VALOR") 'VALOR SERVIÇO
                        If Not DGVServicos.Rows(e.RowIndex).Cells(9).Value Is DBNull.Value And Not DGVServicos.Rows(e.RowIndex).Cells(10).Value Is DBNull.Value Then
                            DGVServicos.Rows(e.RowIndex).Cells(11).Value = DGVServicos.Rows(e.RowIndex).Cells(9).Value * DGVServicos.Rows(e.RowIndex).Cells(10).Value 'TOTAL = SACAS * VAL UNITARIO
                        End If
                        DGVServicos.Rows(e.RowIndex).Cells(13).Value = False
                        DGVServicos.Rows(e.RowIndex).Cells(14).Value = codigo_depositante
                        DGVServicos.Rows(e.RowIndex).Cells(15).Value = mskFE.Text 'F_E
                        DGVServicos.Rows(e.RowIndex).Cells(16).Value = ""         'S_E
                        DGVServicos.Rows(e.RowIndex).Cells(17).Value = ""         'O_R
                        DGVServicos.Rows(e.RowIndex).Cells(19).Value = DGVServicos.Rows(e.RowIndex).Cells(1).Value 'ID_COB
                    End While
                    Cursor.Current = Cursors.Default
                Else
                    DGVServicos.Rows(e.RowIndex).Cells(0).Value = DBNull.Value
                    DGVServicos.Rows(e.RowIndex).Cells(1).Value = DBNull.Value
                    DGVServicos.Rows(e.RowIndex).Cells(9).Value = DBNull.Value
                    DGVServicos.Rows(e.RowIndex).Cells(10).Value = DBNull.Value
                    Cursor.Current = Cursors.Default
                    MessageBox.Show("Este serviço não está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SendKeys.Send("{ESC}")
                End If
            ElseIf e.ColumnIndex = 4 Then
                DGVServicos.CurrentCell = DGVServicos.Rows(e.RowIndex).Cells(0)
            ElseIf e.ColumnIndex = 10 Or e.ColumnIndex = 9 Then
                If Not DGVServicos.Rows(e.RowIndex).Cells(9).Value Is DBNull.Value And Not DGVServicos.Rows(e.RowIndex).Cells(10).Value Is DBNull.Value Then
                    DGVServicos.Rows(e.RowIndex).Cells(11).Value = DGVServicos.Rows(e.RowIndex).Cells(9).Value * DGVServicos.Rows(e.RowIndex).Cells(10).Value 'TOTAL = SACAS * VAL UNITARIO
                End If
            End If
        End If
    End Sub

    Private Sub txtPesoBalanca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesoBalanca.TextChanged
        If IsNumeric(txtTotalSacas.Text) And IsNumeric(txtPesoBalanca.Text) Then
            txtMediaSaca.Text = Round(txtPesoBalanca.Text / txtTotalSacas.Text, 2)
        Else
            txtMediaSaca.Text = ""
        End If
    End Sub
    Private Sub txtTotalSacas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalSacas.KeyDown
        If (e.KeyCode = Keys.Return) Then txtPesoObrigatorio.Focus()
    End Sub
    Private Sub txtTotalSacas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalSacas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtTotalSacas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalSacas.TextChanged
        If IsNumeric(txtTotalSacas.Text) And IsNumeric(txtPesoBalanca.Text) Then
            txtMediaSaca.Text = Round(txtPesoBalanca.Text / txtTotalSacas.Text, 2)
            txtPesoObrigatorio.Text = Round(txtTotalSacas.Text * 60.5, 2)
        Else
            txtMediaSaca.Text = ""
        End If
    End Sub
    Private Sub DGVServicos_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVServicos.UserAddedRow
        If id_entrada = 0 Then
            DGVServicos.Rows(e.Row.Index - 1).Cells("F_E").Value = 9999999
        Else
            DGVServicos.Rows(e.Row.Index - 1).Cells("F_E").Value = mskFE.Text
        End If
    End Sub
    Private Sub cboDepositante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepositante.GotFocus
        Yx = ""
    End Sub
    Private Sub cboDepositante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDepositante.KeyDown
        If e.KeyCode = Keys.Return Then cboRemetente.Focus()
        If e.KeyCode = Keys.Delete Then Yx = ""
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
    Private Sub cboDepositante_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepositante.LostFocus
        If IsNothing(cboDepositante.SelectedValue) And cboDepositante.Text <> "" Then
            cboDepositante.Text = ""
            cboDepositante.Focus()
        End If
    End Sub
    Private Sub cboDepositante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepositante.SelectedIndexChanged
        If cboDepositante.ValueMember <> "" Then
            codigo_depositante = cboDepositante.SelectedValue
            strin_depo = cboDepositante.Text
        End If
    End Sub
    Private Sub cboRemetente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRemetente.GotFocus
        Yx = ""
    End Sub
    Private Sub cboRemetente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRemetente.KeyDown
        If e.KeyCode = Keys.Return Then mskFE.Focus()
        If e.KeyCode = Keys.Delete Then Yx = ""
    End Sub
    Private Sub cboRemetente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRemetente.KeyPress
        If Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            Yx += e.KeyChar
            Dim IndexX As Integer = cboRemetente.FindString(Yx)
            Dim CharsTyped As Integer = cboRemetente.Text.Length
            If IndexX = -1 Then
                e.Handled = True
                Yx = Yx.Remove(Yx.Length - 1, 1)
            End If
        Else
            If Yx.Length > 0 Then Yx = Yx.Remove(0, Yx.Length)
        End If
    End Sub
    Private Sub cboRemetente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRemetente.LostFocus
        If IsNothing(cboRemetente.SelectedValue) And cboRemetente.Text <> "" Then
            cboRemetente.Text = ""
            cboRemetente.Focus()
        End If
    End Sub
    Private Sub cboRemetente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemetente.SelectedIndexChanged
        If cboRemetente.ValueMember <> "" Then
            codigo_origem = cboRemetente.SelectedValue
            strin_ori = cboRemetente.Text
        End If
    End Sub
    Protected Sub SOMALOTES()
        Dim totalpeso As Double
        Dim totalsacas As Int32
        For ContadorLinhas As Integer = 0 To DGVLotes.Rows.Count - 2
            If Not IsDBNull(DGVLotes.Rows(ContadorLinhas).Cells(1).Value) Then totalsacas += DGVLotes.Rows(ContadorLinhas).Cells(1).Value
            If Not IsDBNull(DGVLotes.Rows(ContadorLinhas).Cells(2).Value) Then totalpeso += CDbl(DGVLotes.Rows(ContadorLinhas).Cells(2).Value)
        Next
        lblTotalPeso.Text = totalpeso.ToString("###,###,##0.0")
        lblTotalSacas.Text = totalsacas.ToString("###,###,##0.0")
    End Sub
    Protected Sub SOMASACARIA()
        Dim totalsacas As Int32
        For ContadorLinhas As Integer = 0 To DGVSacaria.Rows.Count - 2
            totalsacas += DGVSacaria.Rows(ContadorLinhas).Cells(3).Value
        Next
        lblTotalSacaria.Text = (totalsacas).ToString("###,###,##0.0")
    End Sub
    Private Sub DGVSacaria_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVSacaria.UserDeletedRow
        SOMASACARIA()
    End Sub
    Private Sub dtpDataEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataEntrada.ValueChanged
        ' Verifica se o texto é um espaço em branco

        If dtpDataEntrada.Text = EmptySpace Then

            ' Define o formato como Shot (formato DD-MM-YYYY) e dá um

            ' enter para fechar (CloseUp) da janela que está aberta

            dtpDataEntrada.Format = DateTimePickerFormat.Short

            SendKeys.Send("{ENTER}")


        End If
    End Sub
    Private Sub txtConsulLote_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsulLote.GotFocus
        mskFEConsulta.Text = ""
        mskFEConsulta.Mask = "####/##"
    End Sub
    Private Sub mskFEConsulta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskFEConsulta.GotFocus
        txtConsulLote.Text = ""
    End Sub
    Private Sub mskFEConsulta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFEConsulta.KeyDown
        If (e.KeyCode = Keys.Return) Then btnConsulRapida_Click(e, New System.EventArgs)
    End Sub
    Private Sub btnConsulRapida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulRapida.Click
        If txtConsulLote.Text <> "" Then
            If altera = False And cadastrando = False Then
                Cursor.Current = Cursors.WaitCursor
                sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE LOTE = '" & txtConsulLote.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                If dr_busca_id.HasRows Then
                    While dr_busca_id.Read
                        CriterioBusca = dr_busca_id("ID_ENTRADA")
                    End While
                    '********* PREENCHE DATASET ENTRADA *********************************************
                    If CriterioBusca > 0 Then
                        ds.Clear()
                        sql(0) = "SELECT * FROM " & tabela_db & " WHERE ID_ENTRADA = " & CriterioBusca & ""
                        Dim cm As New OleDbCommand(sql(0), cn)
                        da = New OleDbDataAdapter(cm)
                        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                        ds.EnforceConstraints = False                                                         '*
                        If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
                        ds.Tables(tabela_db).BeginLoadData()                                                 '*
                        '********************************************************************************************
                        da.Fill(ds, tabela_db)
                        'OTIMIZA PREENCHIMENTO DO DATASET************
                        ds.Tables(tabela_db).EndLoadData()      '*
                        '********************************************
                        dr = ds.Tables(tabela_db).Select("ID_ENTRADA = " & CriterioBusca & "")(0) 'BUSCA A ENTRADA
                        altera = True
                        'limpa(Me)
                        Visualizando()
                        fe_aux = mskFE.Text
                        estadobotao("exibido")
                        '********* PREENCHE DATASET ENTRADA_ITENS ***************************************
                        If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
                        sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE ID_ENTRADA =" & CriterioBusca & ""
                        Dim cmi As New OleDbCommand(sql(0), cn)
                        dai = New OleDbDataAdapter(cmi)
                        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                        dsi.EnforceConstraints = False                                                         '*
                        If dsi.Tables.Count = 0 Then dsi.Tables.Add("ENTRADA_ITENS") '*
                        dsi.Tables("ENTRADA_ITENS").BeginLoadData()                                                 '*
                        '********************************************************************************************
                        dai.Fill(dsi, "ENTRADA_ITENS")
                        'OTIMIZA PREENCHIMENTO DO DATASET************
                        dsi.Tables("ENTRADA_ITENS").EndLoadData()      '*
                        '********************************************
                        dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
                        'GRID SALDOS *****************************************************************************
                        If gridSaldos.Rows.Count > 0 Then dsis.Tables(0).Clear()
                        sql(0) = "SELECT * FROM qENTRADA_ITENS_ESTOQUE WHERE ID_ENTRADA = " & CriterioBusca & ""
                        Dim cmis As New OleDbCommand(sql(0), cn)
                        dais = New OleDbDataAdapter(cmis)
                        dsis.EnforceConstraints = False
                        dsis.Tables("qENTRADA_ITENS_ESTOQUE").BeginLoadData()
                        dais.Fill(dsis, "qENTRADA_ITENS_ESTOQUE")
                        dsis.Tables("qENTRADA_ITENS_ESTOQUE").EndLoadData()
                        gridSaldos.DataSource = dsis.Tables(0)                 'POPULA GRID
                        FormataGridLotesSaldo()
                        '********* PREENCHE DATASET NOTAS_ENTRADA ***************************************
                        If DGVNotas.Rows.Count > 0 Then dsn.Tables(0).Clear()
                        sql(0) = "SELECT * FROM NOTA_ENTRADA WHERE ID_ENTRADA =" & CriterioBusca & ""
                        Dim cmn As New OleDbCommand(sql(0), cn)
                        dan = New OleDbDataAdapter(cmn)
                        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                        dsn.EnforceConstraints = False                                                         '*
                        If dsn.Tables.Count = 0 Then dsn.Tables.Add("NOTA_ENTRADA") '*
                        dsn.Tables("NOTA_ENTRADA").BeginLoadData()                                                 '*
                        '********************************************************************************************
                        dan.Fill(dsn, "NOTA_ENTRADA")
                        'OTIMIZA PREENCHIMENTO DO DATASET************
                        dsn.Tables("NOTA_ENTRADA").EndLoadData()      '*
                        '********************************************
                        '********* PREENCHE O DATASOURCE DO GRID SACARIA******************************************************
                        sql(0) = "SELECT * FROM SACARIA_ENTRADA WHERE ID_ENTRADA = " & CriterioBusca & ""
                        Dim cmsc As New OleDbCommand(sql(0), cn)
                        dasc1 = New OleDbDataAdapter(cmsc)
                        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                        dssc1.EnforceConstraints = False                                                         '*
                        If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_ENTRADA") '*
                        dssc1.Tables("SACARIA_ENTRADA").BeginLoadData()                                                 '*
                        '********************************************************************************************
                        dasc1.Fill(dssc1, "SACARIA_ENTRADA")
                        'OTIMIZA PREENCHIMENTO DO DATASET************
                        dssc1.Tables("SACARIA_ENTRADA").EndLoadData()      '*
                        '********************************************
                        lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
                        '********* PREENCHE O DATASET DO GRID SERVICO_OPERACAO ***********************************************
                        If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                        Dim xx As Int32
                        sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE F_E = '" & mskFE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                        Dim cm_op As New OleDbCommand(sql(0), cn)
                        da_ser_oper = New OleDbDataAdapter(cm_op)
                        'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                        ds_ser_oper.EnforceConstraints = False                                                      '*
                        If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
                        ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()                                                 '*
                        '********************************************************************************************
                        da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
                        'OTIMIZA PREENCHIMENTO DO DATASET**********************
                        ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData() '*
                        '******************************************************
                        For xx = 0 To ds_ser_oper.Tables(0).Rows.Count - 1
                            sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_ser_oper.Tables(0).Rows(xx).Item(2) & ""
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
                        '****************************************************************************************************
                    Else
                        MessageBox.Show("Este Lote está com o id entrata igual a 0, avise o administrador do sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estadobotao("inicio")
                        limpa(Me)
                        habilita(Me, False)
                        altera = False
                        cadastrando = False
                        txtConsulLote.Enabled = True
                        txtConsulLote.Focus()
                        txtConsulLote.SelectAll()
                    End If
                Else
                    MessageBox.Show("Lote não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estadobotao("inicio")
                    limpa(Me)
                    habilita(Me, False)
                    altera = False
                    cadastrando = False
                    txtConsulLote.Enabled = True
                    txtConsulLote.Focus()
                    txtConsulLote.SelectAll()
                End If
            Else
                id_entrada = 0
                estadobotao("inicio")
                limpa(Me)
                habilita(Me, False)
                altera = False
                cadastrando = False
                txtConsulLote.Enabled = True
            End If
            cadastrando = False
            If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
            If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
            altera = False
            Cursor.Current = Cursors.Default
        ElseIf mskFEConsulta.Text <> "    /" Then
            If altera = False Or cadastrando = False Then
                Cursor.Current = Cursors.WaitCursor
                '********* PREENCHE DATASET ENTRADA *********************************************
                ds.Clear()
                sql(0) = "SELECT * FROM " & tabela_db & " WHERE FE = '" & mskFEConsulta.Text & "'"
                Dim cm As New OleDbCommand(sql(0), cn)
                da = New OleDbDataAdapter(cm)
                'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                ds.EnforceConstraints = False                                                         '*
                If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
                ds.Tables(tabela_db).BeginLoadData()                                                 '*
                '********************************************************************************************
                da.Fill(ds, tabela_db)
                'OTIMIZA PREENCHIMENTO DO DATASET************
                ds.Tables(tabela_db).EndLoadData()      '*
                '********************************************
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(tabela_db).Select("FE = '" & mskFEConsulta.Text & "'")(0) 'BUSCA A ENTRADA
                    altera = True
                    'limpa(Me)
                    Visualizando()
                    fe_aux = mskFE.Text
                    estadobotao("exibido")
                    '********* PREENCHE DATASET ENTRADA_ITENS ***************************************
                    If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
                    sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE ID_ENTRADA =" & CriterioBusca & ""
                    Dim cmi As New OleDbCommand(sql(0), cn)
                    dai = New OleDbDataAdapter(cmi)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                    dsi.EnforceConstraints = False                                                         '*
                    If dsi.Tables.Count = 0 Then dsi.Tables.Add("ENTRADA_ITENS") '*
                    dsi.Tables("ENTRADA_ITENS").BeginLoadData()                                                 '*
                    '********************************************************************************************
                    dai.Fill(dsi, "ENTRADA_ITENS")
                    'OTIMIZA PREENCHIMENTO DO DATASET************
                    dsi.Tables("ENTRADA_ITENS").EndLoadData()      '*
                    '********************************************
                    dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
                    'GRID SALDOS *****************************************************************************
                    If gridSaldos.Rows.Count > 0 Then dsis.Tables(0).Clear()
                    sql(0) = "SELECT * FROM qENTRADA_ITENS_ESTOQUE WHERE ID_ENTRADA = " & CriterioBusca & ""
                    Dim cmis As New OleDbCommand(sql(0), cn)
                    dais = New OleDbDataAdapter(cmis)
                    dsis.EnforceConstraints = False
                    dsis.Tables("qENTRADA_ITENS_ESTOQUE").BeginLoadData()
                    dais.Fill(dsis, "qENTRADA_ITENS_ESTOQUE")
                    dsis.Tables("qENTRADA_ITENS_ESTOQUE").EndLoadData()
                    gridSaldos.DataSource = dsis.Tables(0)                 'POPULA GRID
                    FormataGridLotesSaldo()
                    '********* PREENCHE DATASET NOTAS_ENTRADA ***************************************
                    If DGVNotas.Rows.Count > 0 Then dsn.Tables(0).Clear()
                    sql(0) = "SELECT * FROM NOTA_ENTRADA WHERE ID_ENTRADA =" & CriterioBusca & ""
                    Dim cmn As New OleDbCommand(sql(0), cn)
                    dan = New OleDbDataAdapter(cmn)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                    dsn.EnforceConstraints = False                                                         '*
                    If dsn.Tables.Count = 0 Then dsn.Tables.Add("NOTA_ENTRADA") '*
                    dsn.Tables("NOTA_ENTRADA").BeginLoadData()                                                 '*
                    '********************************************************************************************
                    dan.Fill(dsn, "NOTA_ENTRADA")
                    'OTIMIZA PREENCHIMENTO DO DATASET************
                    dsn.Tables("NOTA_ENTRADA").EndLoadData()      '*
                    '********************************************
                    '********* PREENCHE O DATASOURCE DO GRID SACARIA******************************************************
                    sql(0) = "SELECT * FROM SACARIA_ENTRADA WHERE ID_ENTRADA = " & CriterioBusca & ""
                    Dim cmsc As New OleDbCommand(sql(0), cn)
                    dasc1 = New OleDbDataAdapter(cmsc)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                    dssc1.EnforceConstraints = False                                                         '*
                    If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_ENTRADA") '*
                    dssc1.Tables("SACARIA_ENTRADA").BeginLoadData()                                                 '*
                    '********************************************************************************************
                    dasc1.Fill(dssc1, "SACARIA_ENTRADA")
                    'OTIMIZA PREENCHIMENTO DO DATASET************
                    dssc1.Tables("SACARIA_ENTRADA").EndLoadData()      '*
                    '********************************************
                    lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
                    '********* PREENCHE O DATASET DO GRID SERVICO_OPERACAO ***********************************************
                    If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                    Dim xx As Int32
                    sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE F_E = '" & mskFE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                    Dim cm_op As New OleDbCommand(sql(0), cn)
                    da_ser_oper = New OleDbDataAdapter(cm_op)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                    ds_ser_oper.EnforceConstraints = False                                                      '*
                    If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
                    ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()                                                 '*
                    '********************************************************************************************
                    da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
                    'OTIMIZA PREENCHIMENTO DO DATASET**********************
                    ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData() '*
                    '******************************************************
                    For xx = 0 To ds_ser_oper.Tables(0).Rows.Count - 1
                        sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_ser_oper.Tables(0).Rows(xx).Item(2) & ""
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
                    '****************************************************************************************************
                Else
                    MessageBox.Show("Entrada não encontrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estadobotao("inicio")
                    limpa(Me)
                    habilita(Me, False)
                    altera = False
                    cadastrando = False
                    mskFEConsulta.Enabled = True
                    mskFEConsulta.Mask = "####/##"
                    mskFEConsulta.Focus()
                    'mskFEConsulta.SelectAll()
                End If
            End If
            cadastrando = False
            If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
            If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")

            altera = False
            Cursor.Current = Cursors.Default
        Else
            id_entrada = 0
            estadobotao("inicio")
            limpa(Me)
            habilita(Me, False)
            altera = False
            cadastrando = False
            mskFEConsulta.Enabled = True
        End If
    End Sub
    Private Sub txtConsulLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConsulLote.KeyDown
        If (e.KeyCode = Keys.Return) Then btnConsulRapida_Click(e, New System.EventArgs)
    End Sub
    Private Sub ckbConsulta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbConsulta.CheckedChanged
        If ckbConsulta.Checked = True Then
            mskFEConsulta.Text = ""
            mskFEConsulta.Mask = "####/##"
            txtConsulLote.Text = ""
            GroupBox1.Enabled = True
            estadobotao("inicio")
            limpa(Me)
            habilita(Me, False)
            altera = False
            cadastrando = False
            txtConsulLote.Enabled = True
            mskFEConsulta.Focus()
        Else
            mskFEConsulta.Text = ""
            mskFEConsulta.Mask = "####/##"
            txtConsulLote.Text = ""
            GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub MskPlaca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPlaca.KeyDown
        If (e.KeyCode = Keys.Return) Then txtMotorista.Focus()
    End Sub
    Private Sub DGVSacaria_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGVSacaria.UserDeletingRow
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
    Private Sub btnAbreDepositante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbreDepositante.Click
        frmDepositante.ShowDialog()
        Cursor.Current = Cursors.WaitCursor
        '****PREENCHE COMBO AUTO COMPLETAR DEPOSITANTE****************************
        sql(0) = "SELECT * FROM DEPOSITANTE ORDER BY DESCRI"
        Dim cmde As New OleDbCommand(sql(0), cn)
        dadepo = New OleDbDataAdapter(cmde)
        dsdepo.EnforceConstraints = False
        If dsdepo.Tables.Count = 0 Then dsdepo.Tables.Add("DEPOSITANTE")
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
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnAbreRemetente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbreRemetente.Click
        frmOrigem.ShowDialog()
        Cursor.Current = Cursors.WaitCursor
        '****PREENCHE COMBO AUTO COMPLETAR ORIGEM**********************************
        sql(0) = "SELECT * FROM ORIGEM ORDER BY DESCRI"
        Dim cmor As New OleDbCommand(sql(0), cn)
        daori = New OleDbDataAdapter(cmor)
        dsori.EnforceConstraints = False
        If dsori.Tables.Count = 0 Then dsori.Tables.Add("ORIGEM")

        dsori.Tables("ORIGEM").BeginLoadData()
        daori.Fill(dsori, "ORIGEM")
        dsori.Tables("ORIGEM").EndLoadData()
        With cboRemetente
            .AutoCompleteCustomSource.Add(dsori.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = dsori.Tables(0)
            .DisplayMember = dsori.Tables(0).Columns(1).ToString
            .ValueMember = dsori.Tables(0).Columns(0).ToString
            .Text = ""
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub DGVLotes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLotes.CellContentClick

    End Sub

    Private Sub DGVServicos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVServicos.CellContentClick

    End Sub
End Class