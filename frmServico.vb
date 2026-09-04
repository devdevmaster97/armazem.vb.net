Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization.CultureInfo
Imports System.String
Imports ARMAZEM.Principal
Imports System.Math

Friend Class frmServico
    Inherits System.Windows.Forms.Form
    <STAThreadAttribute()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New frmServico())
    End Sub
    Dim altera As Boolean
    Dim tabela_db As String = "SERVICO"
    Dim ds As New DataSet
    Dim dsdepo As New DataSet
    Dim dsi As New DataSet
    Dim dsn As New DataSet
    Dim dssc1 As New DataSet 'usado no gridsacaria com combobox
    Dim dssc2 As New DataSet 'usado no grid com combobox
    Dim ds_resul As New DataSet 'SERVICO_RESULTADO
    Dim cadastrando As Boolean
    Dim ds_s As New DataSet
    Dim ds_sxx As New DataSet
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
    Dim da_s As New OleDbDataAdapter
    Dim da_sxx As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim dadepo As New OleDbDataAdapter
    Dim dai As New OleDbDataAdapter
    Dim dan As New OleDbDataAdapter
    Dim dasc1 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim dasc2 As New OleDbDataAdapter 'usado no gridsacaria com combobox
    Dim da_resul As New OleDbDataAdapter 'SERVICO_RESULTADO
    Dim dt As New DataTable

    Dim dr_s As DataRow
    Dim dr_sxx As DataRow
    Dim drlo() As DataRow
    Dim dr As DataRow
    Dim dri() As DataRow
    Dim drn() As DataRow
    Dim drdepo As DataRow
    Dim dr_resul() As DataRow 'TABELA SERVICO_RESULTADO
    Dim drr() As DataRow

    Dim codigo_depositante As Integer
    Dim id_servico As Integer
    Dim controle_soma As Boolean
    Dim ui As Int32
    Dim strin_depo As String
    Dim codig_depo As String
    Dim mediasacaentrada As Double 'USADO NO CELLENDEDIT PARA ARMAZENAR A MEDIA DA ENTRADA
    Dim Yx As String
    Dim fe_aux As String
    Dim id_ent As Int32
    Dim codigo_depositante_aux As Integer
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Cursor.Current = Cursors.WaitCursor
        '*******************************PARAMETROS DA BUSCA***************************
        Busca.Criterio = New TCriterio(4) {}
        Busca.Ncolunas = 4
        Busca.NumCrite = 6
        Busca.Numcampoinicial = 0
        Busca.Ordem = "ID_SERVICO"
        Busca.OrdemAD = "DESC"

        Busca.Criterio(0).Nome = "SE"
        Busca.Criterio(0).Campo = "SE"
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
        '***************************************************************************
        cn = GetConnection()
        CriterioBusca = "XXX"
        Arquivo = "qSERVICO"
        col_ini_busca = 0
        frmbusca.ShowDialog()
        If CriterioBusca <> "XXX" Then
            '********* PREENCHE DATASET SERVICO **********************************************
            sql(0) = "SELECT * FROM " & tabela_db & " WHERE ID_SERVICO =" & CriterioBusca & ""
            Dim cm As New OleDbCommand(sql(0), cn)
            da = New OleDbDataAdapter(cm)
            'OTIMIZA PREENCHIMENTO DO DATASET************************************************
            ds.EnforceConstraints = False                                                  '*
            If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
            ds.Tables(tabela_db).BeginLoadData()                                           '*
            '********************************************************************************
            da.Fill(ds, tabela_db)
            'OTIMIZA PREENCHIMENTO DO DATASET************
            ds.Tables(tabela_db).EndLoadData() '*
            '********************************************
            dr = ds.Tables(tabela_db).Select("ID_SERVICO = " & CriterioBusca & "")(0) 'BUSCA A ENTRADA
            altera = True
            id_servico = dr("ID_SERVICO")
            limpa(Me)
            Visualizando()
            fe_aux = mskSE.Text
            estadobotao("exibido")
            '********* PREENCHE O DATASET SERVICO_LOTES ***************************************
            If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
            sql(0) = "SELECT * FROM SERVICO_LOTES WHERE ID_SERVICO =" & CriterioBusca & ""
            Dim cmi As New OleDbCommand(sql(0), cn)
            dai = New OleDbDataAdapter(cmi)
            dai.Fill(dsi, "SERVICO_LOTES")
            'dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
            If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
            If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
            If txtAmostra.Text = "" And txtPo.Text = "" And lblTotalPeso.Text <> "" And txtSacaria.Text <> "" Then
                lblTotalPeso2.Text = Convert.ToDouble(lblTotalPeso.Text).ToString("###,###,##0.0")
            Else
                If lblTotalPeso.Text <> "" Then lblTotalPeso2.Text = Convert.ToDouble(lblTotalPeso.Text - (Val(txtAmostra.Text) + Val(txtPo.Text) + Val(txtSacaria.Text))).ToString("###,###,##0.0")
            End If
            '********* PREENCHE O DATASET SERVICO_RESULTADO ***************************************
            If DGVResultado.Rows.Count > 0 Then ds_resul.Tables(0).Clear()
            sql(0) = "SELECT * FROM SERVICO_RESULTADO WHERE ID_SERVICO =" & CriterioBusca & ""
            Dim cmn As New OleDbCommand(sql(0), cn)
            da_resul = New OleDbDataAdapter(cmn)
            da_resul.Fill(ds_resul, "SERVICO_RESULTADO")

            If Not ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPesoResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")

            If Not ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacasResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")

            '********* PREENCHE O DATASET SACARIA_SERVICO *******************************************
            sql(0) = "SELECT * FROM SACARIA_SERVICO WHERE ID_SERVICO = " & CriterioBusca & " "
            Dim cmsc As New OleDbCommand(sql(0), cn)
            dasc1 = New OleDbDataAdapter(cmsc)
            dasc1.Fill(dssc1, "SACARIA_SERVICO")
            If Not dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty) Is DBNull.Value Then If Not dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty) Is DBNull.Value Then lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
            '********* PREENCHE O DATASET SERVICO_OPERACAO *******************************************
            If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
            sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE S_E = '" & mskSE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
            Dim cm_op As New OleDbCommand(sql(0), cn)
            da_ser_oper = New OleDbDataAdapter(cm_op)
            'OTIMIZA PREENCHIMENTO DO DATASET************************
            ds_ser_oper.EnforceConstraints = False                 '*
            If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
            ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData() '*
            '********************************************************
            da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
            'OTIMIZA PREENCHIMENTO DO DATASET************
            ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()   '*
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
            'BUSCA FE DO RESULTADO E EXIBE NO LABEL*****************************************************************
            sql(0) = "SELECT FE, COD_SERVICO_ORIGEM FROM ENTRADA WHERE COD_SERVICO_ORIGEM = '" & mskSE.Text & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmoen As New OleDbCommand(sql(0), cn)
            Dim dr_oen As OleDbDataReader = cmoen.ExecuteReader
            If dr_oen.HasRows Then
                Do While dr_oen.Read
                    lblFEResultado.Text = dr_oen.GetString(0)
                Loop
            Else
                lblFEResultado.Text = ""
            End If
            '*******************************************************************************************************
        Else
            id_servico = 0
        End If
        If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
        If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
        cadastrando = False
        ckbConsulta.Checked = False
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Visualizando()
        CriterioBusca = dr("ID_SERVICO")
        id_servico = dr("ID_SERVICO")
        mskSE.Text = dr("SE")
        If Not IsDBNull(dr("DATA")) Then dtpDataEntrada.Text = dr("DATA")
        '*****************************************************************************
        If Not dr("ID_DEPOSIT") Is DBNull.Value Then
            If dr("ID_DEPOSIT") <> 0 Then
                    If cboDepositante.SelectedValue <> dr("ID_DEPOSIT") Then
                        cboDepositante.SelectedValue = dr("ID_DEPOSIT")
                        strin_depo = cboDepositante.Text
                        codig_depo = cboDepositante.SelectedValue.ToString
                        cboDepositante.Text = strin_depo
                        codigo_depositante = dr("ID_DEPOSIT")
                        codigo_depositante_aux = dr("ID_DEPOSIT")
                    Else
                        cboDepositante.Text = strin_depo
                    End If
            End If
        Else
            cboDepositante.Text = ""
            codigo_depositante_aux = 0
            codigo_depositante = 0
        End If
        '*****************************************************************************
        If Not dr("AMOSTRAS") Is DBNull.Value Then
            txtAmostra.Text = dr("AMOSTRAS")
        Else
            txtAmostra.Text = ""
        End If

        If Not dr("PO") Is DBNull.Value Then
            txtPo.Text = dr("PO")
        Else
            txtPo.Text = ""
        End If

        If Not dr("PEDRA") Is DBNull.Value Then
            txtPedra.Text = dr("PEDRA")
        Else
            txtPedra.Text = ""
        End If

        If Not IsDBNull(dr("SACARIA")) Then
            txtSacaria.Text = dr("SACARIA")
        Else
            txtSacaria.Text = ""
        End If

        If Not IsDBNull(dr("QUEBRA_ACRESCIMO_SCS")) Then
            txtQASacas.Text = dr("QUEBRA_ACRESCIMO_SCS")
        Else
            txtQASacas.Text = ""
        End If
        If Not IsDBNull(dr("QUEBRA_ACRESCIMO_KLS")) Then
            txtQAQuilos.Text = dr("QUEBRA_ACRESCIMO_KLS")
        Else
            txtQAQuilos.Text = ""
        End If
        If Not IsDBNull(dr("DESTINO")) Then txtDestino.Text = dr("DESTINO")
        If Not IsDBNull(dr("DATA_TERMINO")) Then dtpDataTermino.Text = dr("DATA_TERMINO")
    End Sub
    Private Sub Alterando()
        dr.BeginEdit()
        If mskSE.Text <> "" Then dr("SE") = mskSE.Text
        If dtpDataEntrada.Text <> "" Then dr("DATA") = dtpDataEntrada.Text
        dr("ID_DEPOSIT") = codigo_depositante
        If txtAmostra.Text <> "" Then
            dr("AMOSTRAS") = txtAmostra.Text
        Else
            dr("AMOSTRAS") = DBNull.Value
        End If
        If txtPo.Text <> "" Then
            dr("PO") = txtPo.Text
        Else
            dr("PO") = DBNull.Value
        End If
        If txtPedra.Text <> "" Then
            dr("PEDRA") = txtPedra.Text
        Else
            dr("PEDRA") = DBNull.Value
        End If
        If txtQASacas.Text <> "" Then dr("QUEBRA_ACRESCIMO_SCS") = CInt(txtQASacas.Text)
        If txtQAQuilos.Text <> "" Then dr("QUEBRA_ACRESCIMO_KLS") = CInt(txtQAQuilos.Text)
        If txtSacaria.Text <> "" Then dr("SACARIA") = CInt(txtSacaria.Text)
        If txtDestino.Text <> "" Then dr("DESTINO") = txtDestino.Text
        If dtpDataTermino.Text <> "" Then dr("DATA_TERMINO") = dtpDataTermino.Text
        dr("OPERADOR") = XLogonUser.User
        dr.EndEdit()
    End Sub
    Private Sub Incluindo()
        dr = ds.Tables(tabela_db).NewRow
        dr("SE") = mskSE.Text
        dr("DATA") = dtpDataEntrada.Text
        If codigo_depositante <> 0 Then
            dr("ID_DEPOSIT") = codigo_depositante
        Else
            dr("ID_DEPOSIT") = DBNull.Value
        End If
        If txtAmostra.Text <> "" Then
            dr("AMOSTRAS") = txtAmostra.Text
        Else
            dr("AMOSTRAS") = DBNull.Value
        End If
        If txtPo.Text <> "" Then
            dr("PO") = txtPo.Text
        Else
            dr("PO") = DBNull.Value
        End If
        If txtPedra.Text <> "" Then
            dr("PEDRA") = txtPedra.Text
        Else
            dr("PEDRA") = DBNull.Value
        End If

        If txtQASacas.Text <> "" Then
            dr("QUEBRA_ACRESCIMO_SCS") = txtQASacas.Text
        Else
            dr("QUEBRA_ACRESCIMO_SCS") = DBNull.Value
        End If

        If txtQAQuilos.Text <> "" Then
            dr("QUEBRA_ACRESCIMO_KLS") = txtQAQuilos.Text
        Else
            dr("QUEBRA_ACRESCIMO_KLS") = DBNull.Value
        End If

        If txtDestino.Text <> "" Then
            dr("DESTINO") = txtDestino.Text
        Else
            dr("DESTINO") = DBNull.Value
        End If
        If txtSacaria.Text <> "" Then
            dr("SACARIA") = CInt(txtSacaria.Text)
        Else
            dr("SACARIA") = DBNull.Value
        End If
        dr("DATA_TERMINO") = dtpDataTermino.Text
        dr("OPERADOR") = XLogonUser.User
        ds.Tables(tabela_db).Rows.Add(dr)
    End Sub
    Private Sub frmServico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If (e.KeyChar = ChrW(13)) Then
        ' SendKeys.Send("{TAB}")
        ' 'e.Handled = True 'Para remover aquele som...
        ' End If
    End Sub
    Private Sub frmServico_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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
    Private Sub frmServico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Arquivo = tabela_db
        Me.Text = tabela_db

        '********************** POPULA DATASET ENTRADA ******************************************************************************************************
        sql(0) = "SELECT * FROM " & tabela_db & " ORDER BY ID_SERVICO ASC"
        Dim cm As New OleDbCommand(sql(0), cn)
        da = New OleDbDataAdapter(cm)

        'OTIMIZA PREENCHIMENTO DO DATASET*************************
        ds.EnforceConstraints = False                           '*
        If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
        ds.Tables(tabela_db).BeginLoadData()                    '*
        '*********************************************************
        da.Fill(ds, tabela_db)
        'OTIMIZA PREENCHIMENTO DO DATASET*************************
        ds.Tables(tabela_db).EndLoadData()                      '*
        '*********************************************************

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Nao existe nenhum " & tabela_db & " cadastrada, cadastre o primeiro.", MsgBoxStyle.Information, fabricante)
        End If
        '********************** PREENCHE 2º DATASET SERVICO_LOTES *******************************************************************************************
        'If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
        sql(0) = "SELECT * FROM SERVICO_LOTES WHERE ID_SERVICO_LOTES = 0"
        Dim cmi As New OleDbCommand(sql(0), cn)
        dai = New OleDbDataAdapter(cmi)

        'OTIMIZA PREENCHIMENTO DO DATASET*************************
        dsi.EnforceConstraints = False                          '*
        If dsi.Tables.Count = 0 Then dsi.Tables.Add("SERVICO_LOTES") '*
        dsi.Tables("SERVICO_LOTES").BeginLoadData()             '*
        '*********************************************************
        dai.Fill(dsi, "SERVICO_LOTES")
        'OTIMIZA PREENCHIMENTO DO DATASET*************************
        dsi.Tables("SERVICO_LOTES").EndLoadData()               '*
        '*********************************************************
        DGVLotes.DataSource = dsi.Tables(0)                 'POPULA GRID
        FormataGridLotes()

        '********************** PREENCHE DATASET SERVICO_RESULTADO *****************************************************************************
        If DGVResultado.Rows.Count > 0 Then ds_resul.Tables(0).Clear()
        sql(0) = "SELECT * FROM SERVICO_RESULTADO WHERE ID = 0"
        Dim cmn As New OleDbCommand(sql(0), cn)
        da_resul = New OleDbDataAdapter(cmn)

        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        ds_resul.EnforceConstraints = False                  '*
        If ds_resul.Tables.Count = 0 Then ds_resul.Tables.Add("SERVICO_RESULTADO") '*
        ds_resul.Tables("SERVICO_RESULTADO").BeginLoadData() '*
        '******************************************************
        da_resul.Fill(ds_resul, "SERVICO_RESULTADO")
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        ds_resul.Tables("SERVICO_RESULTADO").EndLoadData()   '*
        '******************************************************
        DGVResultado.DataSource = ds_resul.Tables(0)
        FormataGridResultado()

        '********************** PREENCHE DATASET SACARIA_SERVICO *******************************************************************************
        If DGVSacaria.Rows.Count > 0 Then dssc1.Tables(0).Clear()
        sql(0) = "SELECT * FROM SACARIA_SERVICO WHERE ID_SERVICO = 0"
        Dim cmsc As New OleDbCommand(sql(0), cn)
        dasc1 = New OleDbDataAdapter(cmsc)
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc1.EnforceConstraints = False                     '*
        If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_SERVICO") '*
        dssc1.Tables("SACARIA_SERVICO").BeginLoadData()      '*
        '******************************************************
        dasc1.Fill(dssc1, "SACARIA_SERVICO")
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc1.Tables("SACARIA_SERVICO").EndLoadData()        '*
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
        dssc2.EnforceConstraints = False                     '*
        If dssc2.Tables.Count = 0 Then dssc2.Tables.Add("SACARIA") '*
        dssc2.Tables("SACARIA").BeginLoadData()              '*
        '******************************************************
        dasc2.Fill(dssc2, "SACARIA")
        'OTIMIZA PREENCHIMENTO DO DATASET**********************
        dssc2.Tables("SACARIA").EndLoadData()                '*
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
        DGVSacaria.Columns(0).Visible = False 'ID_SACARIA
        DGVSacaria.Columns(1).Visible = False 'ID_ENTRADA
        '********************** PREENCHE DATASET SERVICO_OPERACAO *******************************************************************************
        If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
        sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE ID_SERVICO = 0"
        Dim cm_op As New OleDbCommand(sql(0), cn)
        da_ser_oper = New OleDbDataAdapter(cm_op)
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_ser_oper.EnforceConstraints = False                 '*
        If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
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
        If ds_oper.Tables.Count = 0 Then ds_oper.Tables.Add("OPERACAO") '*
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
        If ds_cob.Tables.Count = 0 Then ds_cob.Tables.Add("COBRANCA") '*
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
        'DGVServicos.Columns(8).ReadOnly = True
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
        '********************** PREENCHE O DATASET ENTRADA_ITENS PARA CONSULTA SE EXISTE O LOTE IGUAL O RESULTADO *******************************

        sql(0) = "SELECT * FROM ENTRADA_ITENS"
        Dim cmle As New OleDbCommand(sql(0), cn)
        da_le = New OleDbDataAdapter(cmle)
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_le.EnforceConstraints = False                       '*
        If ds_le.Tables.Count = 0 Then ds_le.Tables.Add("ENTRADA_ITENS") '*
        ds_le.Tables("ENTRADA_ITENS").BeginLoadData()          '*
        '********************************************************
        da_le.Fill(ds_le, "ENTRADA_ITENS")
        'OTIMIZA PREENCHIMENTO DO DATASET************************
        ds_le.Tables("ENTRADA_ITENS").EndLoadData()            '*
        '********************************************************

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
        With cboDepositante
            .AutoCompleteCustomSource.Add(dsdepo.Tables(0).ToString)
            .AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
            .DataSource = dsdepo.Tables(0)
            .DisplayMember = dsdepo.Tables(0).Columns(1).ToString
            .ValueMember = dsdepo.Tables(0).Columns(0).ToString
            .Text = ""
        End With
        '************************************************************************
        estadobotao("inicio")
        habilita(Me, False)
        altera = False
        cadastrando = False
        mskSE.Mask = "####/##"
        ckbConsulta.Checked = True
        mskSEConsulta.Mask = "####/##"
        mskSEConsulta.Focus()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        habilita(Me, True)
        estadobotao("incluir/Salvar")
        altera = True
        cadastrando = False
        ckbConsulta.Checked = False
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcluir.Click
        Dim resp As DialogResult
        resp = MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resp = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            'EXCLUI DA TAB SERVICO **************************************************************
            sql(0) = "DELETE FROM " & tabela_db & " WHERE ID_SERVICO = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmser As New OleDbCommand(sql(0), cn)
            cmser.ExecuteNonQuery()
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

            'BAIXA O ESTOQUE DO LOTE
            Dim row As DataRow
            Dim qtde_sacas As Integer
            Dim lote As String
            Dim data_cad As Date
            Dim Existe As Boolean = False
            Dim saldox As String
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
                                saldox = dr_sal("QTDE_SCS") + qtde_sacas
                                Dim cmdx = New OleDbCommand()
                                cmdx.CommandType = CommandType.Text
                                cmdx.CommandText = "INSERT INTO ESTOQUE_LOTE ([LOTE],[DATA],[QTDE]) values (@LOTE,@DATA,@QTDE);"
                                cmdx.Parameters.Add("@LOTE", OleDbType.VarChar).Value = lote
                                cmdx.Parameters.Add("@DATA", OleDbType.Date).Value = data_cad
                                cmdx.Parameters.Add("@QTDE", OleDbType.Integer).Value = saldox
                                cmdx.Connection = cn
                                cmdx.ExecuteNonQuery()
                            End If
                        Loop
                    End If
                Next
            End Using

            'EXCLUI DA TAB SERVICO_LOTES ********************************************************
            sql(0) = "DELETE FROM SERVICO_LOTES WHERE ID_SERVICO = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmselo As New OleDbCommand(sql(0), cn)
            cmselo.ExecuteNonQuery()
            'LIMPA E REPREENCHE O DATASET
            dsi.Clear()
            dsi.Dispose()
            sql(0) = "SELECT * FROM SERVICO_LOTES"
            Dim cmi As New OleDbCommand(sql(0), cn)
            dai = New OleDbDataAdapter(cmi)
            dsi.EnforceConstraints = False
            If dsi.Tables.Count = 0 Then dsi.Tables.Add("SERVICO_LOTES")
            dsi.Tables("SERVICO_LOTES").BeginLoadData()
            dai.Fill(dsi, "SERVICO_LOTES")
            dsi.Tables("SERVICO_LOTES").EndLoadData()

            'EXCLUI DA TAB SERVICO_RESULTADO ****************************************************
            sql(0) = "DELETE FROM SERVICO_RESULTADO WHERE ID_SERVICO = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmsere As New OleDbCommand(sql(0), cn)
            cmsere.ExecuteNonQuery()
            'LIMPA E REPREENCHE O DATASET
            ds_resul.Clear()
            ds_resul.Dispose()
            sql(0) = "SELECT * FROM SERVICO_RESULTADO"
            Dim cmn As New OleDbCommand(sql(0), cn)
            da_resul = New OleDbDataAdapter(cmn)
            ds_resul.EnforceConstraints = False                  '*
            If ds_resul.Tables.Count = 0 Then ds_resul.Tables.Add("SERVICO_RESULTADO") '*
            ds_resul.Tables("SERVICO_RESULTADO").BeginLoadData() '*
            da_resul.Fill(ds_resul, "SERVICO_RESULTADO")
            ds_resul.Tables("SERVICO_RESULTADO").EndLoadData()   '*

            'EXCLUI DA TAB SACARIA ****************************************************
            sql(0) = "DELETE FROM SACARIA_SERVICO WHERE ID_SERVICO = " & CriterioBusca & ""
            If cn.State = 0 Then cn.Open()
            Dim cmsac As New OleDbCommand(sql(0), cn)
            cmsac.ExecuteNonQuery()
            'LIMPA E REPREENCHE O DATASET
            dssc1.Clear()
            dssc1.Dispose()
            sql(0) = "SELECT * FROM SACARIA_SERVICO"
            Dim cmsc As New OleDbCommand(sql(0), cn)
            dasc1 = New OleDbDataAdapter(cmsc)
            dssc1.EnforceConstraints = False
            If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_SERVICO")
            dssc1.Tables("SACARIA_SERVICO").BeginLoadData()
            dasc1.Fill(dssc1, "SACARIA_SERVICO")
            dssc1.Tables("SACARIA_SERVICO").EndLoadData()

            'EXCLUI DA TAB SERVICO_OPERACAO *****************************************************
            sql(0) = "DELETE FROM SERVICO_OPERACAO WHERE S_E = '" & mskSE.Text & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmserop As New OleDbCommand(sql(0), cn)
            cmserop.ExecuteNonQuery()
            'LIMPA E REPREENCHE O DATASET
            ds_ser_oper.Clear()
            ds_ser_oper.Dispose()
            sql(0) = "SELECT * FROM SERVICO_OPERACAO"
            Dim cm_op As New OleDbCommand(sql(0), cn)
            da_ser_oper = New OleDbDataAdapter(cm_op)
            ds_ser_oper.EnforceConstraints = False
            If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO")
            ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()
            da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
            ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()

            limpa(Me)
            estadobotao("inicio")
            Cursor.Current = Cursors.Default
            MessageBox.Show("Excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        ds_ser_oper.Dispose()
        ds_oper.Dispose()
        ds_cob.Dispose()
        ds_oper_cob.Dispose()
        ds_operX.Dispose()
        ds_cobX.Dispose()
        ds.Dispose()
        dsdepo.Dispose()
        dsi.Dispose()
        dsn.Dispose()
        dssc1.Dispose()
        dssc2.Dispose()
        Me.Close()
    End Sub
    Private Sub limpa(ByVal form As Form)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DateTimePicker Or form.Controls(i).Name = "lblTotalSacas" Or form.Controls(i).Name = "lblTotalPeso" Or form.Controls(i).Name = "lblTotalPeso2" Or form.Controls(i).Name = "lblTotalPesoResultado" Or form.Controls(i).Name = "lblTotalSacaria" Or form.Controls(i).Name = "lblTotalSacasResultado" Or form.Controls(i).Name = "lblDepositante" Or form.Controls(i).Name = "lblFEResultado" Or form.Controls(i).Name = "lblTotalPeso2" Then
                form.Controls(i).Text = ""
            End If
        Next i
        If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
        If DGVResultado.Rows.Count > 0 Then ds_resul.Tables(0).Clear()
        If DGVSacaria.Rows.Count > 0 Then dssc1.Tables(0).Clear()
        If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        estadobotao("inicio")
        limpa(Me)
        habilita(Me, False)
        altera = False
        cadastrando = False
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim registro As Integer = 0
        id_servico = 0
        If cboDepositante.Text = "" Or IsNothing(cboDepositante.SelectedValue) Then
            MessageBox.Show("Informe o depositante", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDepositante.Focus()
        ElseIf DGVLotes.RowCount = 1 Then
            MessageBox.Show("Informe os lotes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DGVLotes.Focus()
        ElseIf DGVResultado.RowCount = 1 Then
            MessageBox.Show("Informe o resultado do serviço!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DGVResultado.Focus()
        Else
            If altera = True Then
                Alterando()
            Else
                'CONSULTA SE JÁ EXISTE UM SE*******************************************************************************
                sql(0) = "SELECT * FROM " & tabela_db & " WHERE SE = '" & mskSE.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cma As New OleDbCommand(sql(0), cn)
                Dim dr_busca_repitido As OleDbDataReader = cma.ExecuteReader
                If dr_busca_repitido.HasRows Then
                    MessageBox.Show("Já existe essa OS!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mskSE.Focus()
                    Exit Sub
                Else
                    Incluindo()
                End If
                '***********************************************************************************************************
            End If
retor:      '******************* ATUALIZA DATASET SERVICO ****************************************
            Dim cmb As New OleDbCommandBuilder(da)
            da.Update(ds, tabela_db)
            '******************* BUSCA O ID DA NOVA SE COM DUAS CONSULTAS ********************************************

            'sql(0) = "SELECT SE, ID_SERVICO FROM " & tabela_db & ""
            'Dim cm_ser As New OleDbCommand(sql(0), cn)
            'da_s = New OleDbDataAdapter(cm_ser)
            ''OTIMIZA PREENCHIMENTO DO DATASET**************************
            'ds_s.EnforceConstraints = False                          '*
            'If ds_s.Tables.Count = 0 Then ds_s.Tables.Add(tabela_db) '*
            'ds_s.Tables(tabela_db).BeginLoadData()                   '*
            ''**********************************************************
            'da_s.Fill(ds_s, tabela_db)
            ''OTIMIZA PREENCHIMENTO DO DATASET******
            'ds_s.Tables(tabela_db).EndLoadData() '*
            ''**************************************
            'If ds_s.Tables(tabela_db).Rows.Count > 0 Then
            '    dr_s = ds_s.Tables(tabela_db).Select("SE = '" & mskSE.Text & "'")(0)
            '    id_servico = dr_s("ID_SERVICO")
            'End If

            If cn.State = 0 Then cn.Open()
            sql(0) = "SELECT SE, ID_SERVICO FROM " & tabela_db & " WHERE SE= '" & mskSE.Text & "'"
            Dim cm_ser2 As New OleDbCommand(sql(0), cn)
            Dim dr_busca_id As OleDbDataReader = cm_ser2.ExecuteReader
            If dr_busca_id.HasRows Then
                Do While dr_busca_id.Read
                    id_servico = dr_busca_id.GetInt32(1)
                Loop
            End If

            If id_servico > 0 Then


                '***********************************     SERVICO_LOTES      *****************************************
                For registro = 0 To DGVLotes.Rows.Count - 2
                    DGVLotes.Rows(registro).Cells("ID_SERVICO").Value = id_servico
                Next

                'ATUALIZA DATASET SERVICO_LOTES
                dai.ContinueUpdateOnError = True
                Dim cbi As New OleDbCommandBuilder(dai)
                dai.Update(dsi, "SERVICO_LOTES")
                dsi.AcceptChanges()




                'ATUALIZA O CAMPO id_entrada que está igual a 0
                If cn.State = 0 Then cn.Open()
                sql(0) = "UPDATE SERVICO_LOTES SET ID_SERVICO = " & id_servico & " WHERE ID_SERVICO = 0"
                Dim cmlo As New OleDbCommand(sql(0), cn)
                cmlo.ExecuteNonQuery()

                '**********************************        RESULTADO        ******************************************
                For registro = 0 To DGVResultado.Rows.Count - 2
                    DGVResultado.Rows(registro).Cells("ID_SERVICO").Value = id_servico
                Next


                'ATUALIZA DATASET SERVICO_RESULTADO
                da_resul.ContinueUpdateOnError = True
                Dim cbn As New OleDbCommandBuilder(da_resul)
                da_resul.Update(ds_resul, "SERVICO_RESULTADO")
                ds_resul.AcceptChanges()

                sql(0) = "UPDATE SERVICO_RESULTADO SET ID_SERVICO = " & id_servico & " WHERE ID_SERVICO = 0"
                If cn.State = 0 Then cn.Open()
                Dim cmrs As New OleDbCommand(sql(0), cn)
                cmrs.ExecuteNonQuery()

                '*********************************           SACARIA         ******************************************
                For registro = 0 To DGVSacaria.Rows.Count - 2
                    DGVSacaria.Rows(registro).Cells("ID_SERVICO").Value = id_servico
                Next

                'ATUALIZA DATASET SACARIA_ENTRADA
                Dim cbsc As New OleDbCommandBuilder(dasc1)
                dasc1.Update(dssc1, "SACARIA_SERVICO")
                dssc1.AcceptChanges()

                sql(0) = "UPDATE SACARIA_SERVICO SET ID_SERVICO = " & id_servico & " WHERE ID_SERVICO = 0"
                If cn.State = 0 Then cn.Open()
                Dim cmsa As New OleDbCommand(sql(0), cn)
                cmsa.ExecuteNonQuery()


                '*********************************        SERVICO_OPERACAO        *************************************
                For registro = 0 To DGVServicos.Rows.Count - 2
                    DGVServicos.Rows(registro).Cells("S_E").Value = mskSE.Text 'INDICE 16 NO DATAGRIDVIEW COM A MUDANÇA DOS INDICES
                Next

                'ATUALIZA DATASET SERVICO_OPERACAO
                Dim cbop As New OleDbCommandBuilder(da_ser_oper)
                da_ser_oper.Update(ds_ser_oper, "SERVICO_OPERACAO")
                ds_ser_oper.AcceptChanges()

                'ATUALIZA O CAMPO id_entrada que está igual a 9999999
                sql(0) = "UPDATE SERVICO_OPERACAO SET S_E = '" & mskSE.Text & "' WHERE S_E = '9999999'"
                If cn.State = 0 Then cn.Open()
                Dim cmso As New OleDbCommand(sql(0), cn)
                cmso.ExecuteNonQuery()

                'ATUALIZA A FE NA TAB SERVICO_OPERACAO CASO HAJA MUDANÇAO NO Nº DA FE
                If altera = True Then
                    If mskSE.Text <> fe_aux Then
                        If fe_aux <> "" Then
                            sql(0) = "UPDATE SERVICO_OPERACAO SET S_E = '" & mskSE.Text & "' WHERE S_E = '" & fe_aux & "'"
                            If cn.State = 0 Then cn.Open()
                            Dim cmse As New OleDbCommand(sql(0), cn)
                            cmse.ExecuteNonQuery()

                            sql(0) = "UPDATE ENTRADA SET COD_SERVICO_ORIGEM = '" & mskSE.Text & "' WHERE COD_SERVICO_ORIGEM = '" & fe_aux & "'"
                            Dim cment As New OleDbCommand(sql(0), cn)
                            cment.ExecuteNonQuery()
                        End If
                    End If
                End If

                'REPREENCHE O DATASET DO GRID SERVICO_OPERACAO
                If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                Dim xx As Int32
                sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE S_E = '" & mskSE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                Dim cm_op As New OleDbCommand(sql(0), cn)
                da_ser_oper = New OleDbDataAdapter(cm_op)
                'OTIMIZA PREENCHIMENTO DO DATASET************************
                ds_ser_oper.EnforceConstraints = False                 '*
                If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
                ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData() '*
                '********************************************************
                da_ser_oper.Fill(ds_ser_oper, "SERVICO_OPERACAO")
                'OTIMIZA PREENCHIMENTO DO DATASET************
                ds_ser_oper.Tables("SERVICO_OPERACAO").EndLoadData()      '*
                '********************************************
                For xx = 0 To ds_ser_oper.Tables(0).Rows.Count - 1
                    sql(0) = "SELECT * FROM qOPERACAO_COBRANCA WHERE ID_OPER_COB =" & ds_ser_oper.Tables(0).Rows(xx).Item(2) & ""
                    If cn.State = 0 Then cn.Open()
                    Dim cm_qop As New OleDbCommand(sql(0), cn)
                    Dim dr_qser_ope As OleDbDataReader = cm_qop.ExecuteReader
                    If dr_qser_ope.HasRows Then
                        Do While dr_qser_ope.Read
                            sql(0) = "SELECT * FROM OPERACAO WHERE DESCRI = '" & dr_qser_ope("DESCRI_OPERACAO") & "'" 'BUSCA ID OPERACAO
                            Dim cmope As New OleDbCommand(sql(0), cn)
                            Dim dr_opeX As OleDbDataReader = cmope.ExecuteReader
                            If dr_opeX.HasRows Then
                                Do While dr_opeX.Read
                                    DGVServicos.Rows(xx).Cells(0).Value = dr_opeX.GetInt32(0)
                                Loop
                            End If
                            dr_opeX.Close()
                            sql(0) = "SELECT * FROM COBRANCA WHERE DESCRI = '" & dr_qser_ope("DESCRI_COBRANCA") & "'" 'BUSCA ID COBRANCA
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
                    sql(0) = "UPDATE SERVICO_OPERACAO SET ID_DEPOSITANTE = " & codigo_depositante & " WHERE S_E = '" & mskSE.Text & "'"
                    If cn.State = 0 Then cn.Open()
                    Dim cmdepos As New OleDbCommand(sql(0), cn)
                    cmdepos.ExecuteNonQuery()
                End If
            Else
                GoTo retor
            End If
            '******************************* CADATRANDO UMA NOVA ENTRADA A PARTIR DO GRID RESULTADO *****************************
            If cadastrando = True Then
                '****************CALCULA A PROXIMA FE****************************************************************************
                Dim FEX As String
                Dim U As Int32
                Dim x1 As Int32
                Dim cmdn As New OleDbCommand("SELECT COUNT(*) FROM ENTRADA", cn)
                Dim totalLinhas As Long = CInt(cmdn.ExecuteScalar())
                Dim cmentr As New OleDbCommand("SELECT ID_ENTRADA, FE FROM ENTRADA ORDER BY ID_ENTRADA DESC", cn)
                Dim dr_cobX As OleDbDataReader = cmentr.ExecuteReader
                If dr_cobX.HasRows Then
                    While dr_cobX.Read
                        x1 = Mid(dr_cobX("FE").ToString(), 1, 4)
                        Exit While
                    End While
                    FEX = (x1 + 1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                    '*******VARRE A TABELA ENTRADA PARA NÃO REPETIR A FE ********************************
                    For U = 0 To totalLinhas
                        Dim cmbu As New OleDbCommand("SELECT FE FROM ENTRADA WHERE FE = '" & FEX & "'", cn)
                        Dim dr_bu As OleDbDataReader = cmbu.ExecuteReader
                        x1 = x1 + 1
                        If dr_bu.HasRows Then
                            FEX = (x1 + 1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                        Else
                            Exit For
                        End If
                    Next
                Else
                    FEX = (1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                End If
                dr_cobX.Close()
                '**************************************************************************************************************************
                '********* PREENCHE O DATASET ENTRADA *******************************************
                sql(0) = "SELECT * FROM ENTRADA"
                Dim cm_en As New OleDbCommand(sql(0), cn)
                da_en = New OleDbDataAdapter(cm_en)
                'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                ds_en.EnforceConstraints = False                                                     '*
                If ds_en.Tables.Count = 0 Then ds_en.Tables.Add("ENTRADA") '*
                ds_en.Tables("ENTRADA").BeginLoadData()                                     '*
                '********************************************************************************************
                da_en.Fill(ds_en, "ENTRADA")
                'OTIMIZA PREENCHIMENTO DO DATASET************************************************************
                ds_en.Tables("ENTRADA").EndLoadData()                                       '*
                '********************************************************************************************

                MessageBox.Show("UMA ENTRADA SERÁ GERADA COM O RESULTADO DO SERVIÇO, SOB A FE Nº: " & FEX, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'INSERE OS DADOS TABELA ENTRADA
                dr_entrada = ds_en.Tables("ENTRADA").NewRow
                dr_entrada("FE") = FEX
                dr_entrada("DATA") = Date.Today
                If codigo_depositante <> 0 Then
                    dr_entrada("ID_DEPOSIT") = codigo_depositante
                Else
                    dr_entrada("ID_DEPOSIT") = DBNull.Value
                End If
                dr_entrada("COD_SERVICO_ORIGEM") = mskSE.Text
                dr_entrada("TOTAL_SACAS") = Convert.ToDecimal(lblTotalSacasResultado.Text)
                ds_en.Tables("ENTRADA").Rows.Add(dr_entrada)
                'GRAVA A TABELA ENTRADA
                Dim cmen As New OleDbCommandBuilder(da_en)
                'OTIMIZA PREENCHIMENTO DO DATASET************
                ds_en.EnforceConstraints = False         '*
                If ds_en.Tables.Count = 0 Then ds_en.Tables.Add("ENTRADA") '*
                ds_en.Tables("ENTRADA").BeginLoadData() '*
                '********************************************
                da_en.Update(ds_en, "ENTRADA")
                'OTIMIZA PREENCHIMENTO DO DATASET************
                ds_en.Tables("ENTRADA").EndLoadData()   '*
                '********************************************
                ds_en.AcceptChanges()
                ds_en.Dispose()
                ds_en.Clear()
                'BUSCA O ID DA NOVA FE****************************************************************
                sql(0) = "SELECT FE, ID_ENTRADA FROM ENTRADA WHERE FE = '" & FEX & "'"
                Dim id_ent As Int32
                If cn.State = 0 Then cn.Open()
                Dim cmentre As New OleDbCommand(sql(0), cn)
                Dim dr_busca_fe As OleDbDataReader = cmentre.ExecuteReader
                If dr_busca_fe.HasRows Then
                    Do While dr_busca_fe.Read
                        id_ent = dr_busca_fe("ID_ENTRADA")
                    Loop
                End If
                '***************************************************************************************
                'LOOP GRAVANDO OS LOTES DO RESULTADO EM ENTRADA_ITENS
                'Dim row As DataRow
                Dim qtde_sacas As Integer
                Dim lote As String
                Dim data_cad As Date
                If cn.State = 0 Then cn.Open()

                For registro = 0 To DGVResultado.Rows.Count - 2

                    dr_iten_entrada = ds_le.Tables("ENTRADA_ITENS").NewRow
                    If DGVResultado.Rows(registro).Cells(0).Value <> "" Then
                        dr_iten_entrada("LOTE") = DGVResultado.Rows(registro).Cells(0).Value
                    Else
                        dr_iten_entrada("LOTE") = ""
                    End If
                    If DGVResultado.Rows(registro).Cells(1).Value <> 0 Then
                        dr_iten_entrada("SACAS") = DGVResultado.Rows(registro).Cells(1).Value
                    Else
                        dr_iten_entrada("SACAS") = DBNull.Value
                    End If
                    If DGVResultado.Rows(registro).Cells(2).Value <> 0 Then
                        dr_iten_entrada("PESO") = DGVResultado.Rows(registro).Cells(2).Value
                    Else
                        dr_iten_entrada("PESO") = DBNull.Value
                    End If
                    dr_iten_entrada("MEDIA") = DGVResultado.Rows(registro).Cells(2).Value / DGVResultado.Rows(registro).Cells(1).Value 'PESO TOTAL / SACAS
                    If id_ent <> 0 Then
                        dr_iten_entrada("ID_ENTRADA") = id_ent
                    Else
                        dr_iten_entrada("ID_ENTRADA") = DBNull.Value
                    End If
                    If Not DGVResultado.Rows(registro).Cells(5).Value Is DBNull.Value Then
                        dr_iten_entrada("PENEIRA") = DGVResultado.Rows(registro).Cells(5).Value
                    Else
                        dr_iten_entrada("PENEIRA") = ""
                    End If

                    'CADASTRA O ESTOQUE DO LOTE
                    lote = DGVResultado.Rows(registro).Cells(0).Value
                    data_cad = Date.Now.ToString("dd/M/yyyy")
                    qtde_sacas = DGVResultado.Rows(registro).Cells(1).Value
                    Dim cmdx = New OleDbCommand()
                    cmdx.CommandType = CommandType.Text
                    cmdx.CommandText = "INSERT INTO ESTOQUE_LOTE ([LOTE],[DATA],[QTDE]) values (@LOTE,@DATA,@QTDE);"
                    cmdx.Parameters.Add("@LOTE", OleDbType.VarChar).Value = lote
                    cmdx.Parameters.Add("@DATA", OleDbType.Date).Value = data_cad
                    cmdx.Parameters.Add("@QTDE", OleDbType.Integer).Value = qtde_sacas
                    cmdx.Connection = cn
                    cmdx.ExecuteNonQuery()


                    ds_le.Tables("ENTRADA_ITENS").Rows.Add(dr_iten_entrada)

                   


                Next
                lblFEResultado.Text = FEX


            Else
                Dim resp As String
                For registro = 0 To DGVResultado.Rows.Count - 2
                    sql(0) = "SELECT LOTE, ID_ENTRADA FROM ENTRADA_ITENS WHERE LOTE = '" & DGVResultado.Rows(registro).Cells(0).Value & "'"
                    Dim cmentre As New OleDbCommand(sql(0), cn)
                    Dim dr_busca_fe As OleDbDataReader = cmentre.ExecuteReader
                    If dr_busca_fe.HasRows = False Then
                        resp = MessageBox.Show("O lote resultado [ " & DGVResultado.Rows(registro).Cells(0).Value & " ], não está cadastrado na entrada,Deseja cadastra-lo ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        If resp = vbYes Then
                            If lblFEResultado.Text <> "" Then 'JÁ EXISTE UMA FE CADASTRADA PARA ESTE RESULTADO MAS NAO TEM OS LOTES
                                sql(1) = "SELECT FE, ID_ENTRADA FROM ENTRADA WHERE FE = '" & lblFEResultado.Text & "'"
                                Dim cmentred As New OleDbCommand(sql(1), cn)
                                Dim dr_busc_fe As OleDbDataReader = cmentred.ExecuteReader
                                If dr_busc_fe.HasRows Then

                                    While dr_busc_fe.Read

                                        sql(2) = "INSERT INTO ENTRADA_ITENS (LOTE, SACAS, PESO, ID_ENTRADA, MEDIA, PENEIRA) VALUES ('" & DGVResultado.Rows(registro).Cells(0).Value & "', '" & DGVResultado.Rows(registro).Cells(1).Value & "', '" & DGVResultado.Rows(registro).Cells(2).Value & "', " & dr_busc_fe.GetInt32(1) & ", '" & DGVResultado.Rows(registro).Cells(2).Value / DGVResultado.Rows(registro).Cells(1).Value & "','" & DGVResultado.Rows(registro).Cells(5).Value & "')"
                                        Dim cment2 As New OleDbCommand(sql(2), cn)
                                        cment2.ExecuteNonQuery()

                                    End While

                                End If

                            Else 'NÃO EXISTE UMA FE CADASTRADA, ENTRA CADASTRA UMA NOVA
                                '****************CALCULA A PROXIMA FE**************************************************************************************
                                If registro = 0 Then 'ENTRA AQUI SO A PRIMEIRA VEZ PRA CADASTRAR A FE E PEGAR O NOVO ID_ENTRADA PARA GRAVAR O ITENS
                                    Dim FEX As String
                                    Dim U As Int32
                                    Dim x1 As Int32
                                    Dim cmdn As New OleDbCommand("SELECT COUNT(*) FROM ENTRADA", cn)
                                    Dim totalLinhas As Long = CInt(cmdn.ExecuteScalar())
                                    Dim cmentr As New OleDbCommand("SELECT ID_ENTRADA, FE FROM ENTRADA ORDER BY ID_ENTRADA DESC", cn)
                                    Dim dr_cobX As OleDbDataReader = cmentr.ExecuteReader
                                    If dr_cobX.HasRows Then
                                        While dr_cobX.Read
                                            x1 = Mid(dr_cobX("FE").ToString(), 1, 4)
                                            Exit While
                                        End While
                                        FEX = (x1 + 1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                                        '*******VARRE A TABELA ENTRADA PARA NÃO REPETIR A FE ********************************
                                        For U = 0 To totalLinhas
                                            Dim cmbu As New OleDbCommand("SELECT FE FROM ENTRADA WHERE FE = '" & FEX & "'", cn)
                                            Dim dr_bu As OleDbDataReader = cmbu.ExecuteReader
                                            x1 = x1 + 1
                                            If dr_bu.HasRows Then
                                                FEX = (x1 + 1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                                            Else
                                                Exit For
                                            End If
                                        Next
                                    Else
                                        FEX = (1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                                    End If
                                    dr_cobX.Close()
                                    '**************************************************************************************************************************

                                    sql(1) = "INSERT INTO ENTRADA (FE, DATA, ID_DEPOSIT, COD_SERVICO_ORIGEM) VALUES ('" & FEX & "', '" & Now.Date & "', " & codigo_depositante & ", '" & mskSE.Text & "')"
                                    Dim cminent As New OleDbCommand(sql(1), cn)
                                    cminent.ExecuteNonQuery()

                                    'BUSCA O ID DA NOVA FE****************************************************************
                                    sql(0) = "SELECT FE, ID_ENTRADA FROM ENTRADA WHERE FE = '" & FEX & "'"

                                    If cn.State = 0 Then cn.Open()
                                    Dim cmentre3 As New OleDbCommand(sql(0), cn)
                                    Dim dr_busca_fec As OleDbDataReader = cmentre3.ExecuteReader
                                    If dr_busca_fec.HasRows Then
                                        Do While dr_busca_fec.Read
                                            id_ent = dr_busca_fec("ID_ENTRADA")
                                        Loop
                                    End If
                                    '***************************************************************************************
                                End If

                                sql(2) = "INSERT INTO ENTRADA_ITENS (LOTE, SACAS, PESO, ID_ENTRADA, MEDIA, PENEIRA) VALUES ('" & DGVResultado.Rows(registro).Cells(0).Value & "', '" & DGVResultado.Rows(registro).Cells(1).Value & "', '" & DGVResultado.Rows(registro).Cells(2).Value & "', " & id_ent & ", '" & DGVResultado.Rows(registro).Cells(2).Value / DGVResultado.Rows(registro).Cells(1).Value & "','" & DGVResultado.Rows(registro).Cells(5).Value & "')"
                                Dim cment2 As New OleDbCommand(sql(2), cn)
                                cment2.ExecuteNonQuery()

                                'BUSCA FE DO RESULTADO E EXIBE NO LABEL*****************************************************************
                                sql(0) = "SELECT FE, COD_SERVICO_ORIGEM FROM ENTRADA WHERE COD_SERVICO_ORIGEM = '" & mskSE.Text & "'"
                                If cn.State = 0 Then cn.Open()
                                Dim cmoen As New OleDbCommand(sql(0), cn)
                                Dim dr_oen As OleDbDataReader = cmoen.ExecuteReader
                                If dr_oen.HasRows Then
                                    Do While dr_oen.Read
                                        lblFEResultado.Text = dr_oen.GetString(0)
                                    Loop
                                Else
                                    lblFEResultado.Text = ""
                                End If
                                '*******************************************************************************************************
                                MessageBox.Show("UMA ENTRADA SERÁ GERADA COM O RESULTADO DO SERVIÇO, SOB A FE Nº: " & lblFEResultado.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Else
                        sql(0) = "UPDATE ENTRADA_ITENS SET SACAS = '" & DGVResultado.Rows(registro).Cells(1).Value & "', PESO = '" & DGVResultado.Rows(registro).Cells(2).Value & "' WHERE LOTE = '" & DGVResultado.Rows(registro).Cells(0).Value & "' "
                        Dim cmatua As New OleDbCommand(sql(0), cn)
                        cmatua.ExecuteNonQuery()
                    End If
                Next
            End If
            'GRAVA A TABELA ENTRADA_ITENS
            Dim cmen_it As New OleDbCommandBuilder(da_le)
            da_le.Update(ds_le, "ENTRADA_ITENS")
            ds_le.AcceptChanges()
            '******************* RECALCULA TOTAIS ***************************************************
            If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
            If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
            habilita(Me, False)
            estadobotao("exibido")
            cadastrando = False
            Cursor.Current = Cursors.Default
            If altera = True Then
                MessageBox.Show("Alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            altera = False
        End If
    End Sub
    Private Sub habilita(ByVal form As Form, ByVal habil As Boolean)
        Dim i As Integer
        For i = 0 To (form.Controls.Count - 1)
            If TypeOf form.Controls(i) Is System.Windows.Forms.TextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.MaskedTextBox Or TypeOf form.Controls(i) Is System.Windows.Forms.ComboBox Or TypeOf form.Controls(i) Is System.Windows.Forms.DataGridView Or TypeOf form.Controls(i) Is System.Windows.Forms.DateTimePicker Then
                form.Controls(i).Enabled = habil
            End If
        Next i
        GroupBox2.Enabled = habil
    End Sub
    Private Sub DGVLotes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLotes.CellEndEdit
        If e.ColumnIndex = 0 Then 'LOTE
            If Not DGVLotes.Item(0, e.RowIndex).Value Is Nothing Then
                DGVLotes.CurrentCell.Value = DGVLotes.CurrentCell.Value.ToString.ToUpper()
                sql(0) = "SELECT * FROM qLOTES_SERVICO_RETIRADA WHERE LOTE='" & DGVLotes.Item(0, e.RowIndex).Value.ToString & "'"
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                If dr_busca_id.HasRows Then
                    While dr_busca_id.Read
                        If dr_busca_id("SALDO_SACAS") > 0 Then
                            DGVLotes.Item(1, e.RowIndex).Value = dr_busca_id("SALDO_SACAS")
                            DGVLotes.Item(2, e.RowIndex).Value = dr_busca_id("SALDO_PESO")
                            mediasacaentrada = dr_busca_id("PESO") / dr_busca_id("SACAS")
                            If Not IsNothing(DGVServicos.Rows(0).Cells(0).Value) Then
                                If DGVServicos.Rows(0).Cells(0).Value = 9 Then ' GANBIARRA (PILHA VENTILAR CATAR)COD 9
                                    DGVLotes.Item(5, e.RowIndex).Value = DGVLotes.Item(1, e.RowIndex).Value * 1.5 ' GANBIARRA VALOR SERVIÇO A PEDIDO DA ANDREA SO PRA IMPRIMIR PRA FACILITAR PRA ELA CONSULTAR SO PELO PAPEL (PILHA SIMPLES)COD 7 E (REENSAQUE)COD 8
                                ElseIf Not IsDBNull(DGVServicos.Rows(0).Cells(0).Value) And DGVServicos.Rows(0).Cells(0).Value = 7 Or DGVServicos.Rows(0).Cells(0).Value = 8 Then
                                    DGVLotes.Item(5, e.RowIndex).Value = DGVLotes.Item(1, e.RowIndex).Value
                                End If
                            End If
                        Else
                            MessageBox.Show("O lote :" & Chr(13) & " [ " & DGVLotes.Item(0, e.RowIndex).Value & " ] não possui saldo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SendKeys.Send("{HOME}") 'POSICIONA NA PRIMEIRA COLUNA
                            DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                            DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                            DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                            DGVLotes.Item(3, e.RowIndex).Value = DBNull.Value  'ID_SERVICO
                            DGVLotes.CancelEdit()
                        End If
                    End While
                Else
                    MessageBox.Show("O lote :" & Chr(13) & " [ " & DGVLotes.Item(0, e.RowIndex).Value & " ] não foi encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SendKeys.Send("{HOME}") 'POSICIONA NA PRIMEIRA COLUNA
                    DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                    DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                    DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                    DGVLotes.Item(3, e.RowIndex).Value = DBNull.Value  'ID_SERVICO
                    DGVLotes.CancelEdit()
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then 'SACAS
            If Not IsDBNull(DGVLotes.Rows(e.RowIndex).Cells(1).Value) Then
                If altera = False Then
                    DGVLotes.Rows(e.RowIndex).Cells(2).Value = Floor(mediasacaentrada * DGVLotes.Rows(e.RowIndex).Cells(1).Value)
                End If
            End If
            If Not IsNothing(DGVServicos.Rows(0).Cells(0).Value) Then
                If DGVServicos.Rows(0).Cells(0).Value = 9 Then ' GANBIARRA (PILHA VENTILAR CATAR)COD 9
                    DGVLotes.Item(5, e.RowIndex).Value = DGVLotes.Item(1, e.RowIndex).Value * 1.5 ' GANBIARRA VALOR SERVIÇO A PEDIDO DA ANDREA SO PRA IMPRIMIR PRA FACILITAR PRA ELA CONSULTAR SO PELO PAPEL (PILHA SIMPLES)COD 7 E (REENSAQUE)COD 8
                ElseIf Not IsDBNull(DGVServicos.Rows(0).Cells(0).Value) And DGVServicos.Rows(0).Cells(0).Value = 7 Or DGVServicos.Rows(0).Cells(0).Value = 8 Then
                    DGVLotes.Item(5, e.RowIndex).Value = DGVLotes.Item(1, e.RowIndex).Value
                End If
            End If

            If DGVLotes.Item(0, e.RowIndex).Value Is DBNull.Value Or DGVLotes.Item(0, e.RowIndex).Value Is Empty Then
                MessageBox.Show("Informe o [LOTE] primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SendKeys.Send("{HOME}")
                DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                DGVLotes.Item(3, e.RowIndex).Value = DBNull.Value  'ID_SERVICO
                DGVLotes.CancelEdit()
            End If
        ElseIf e.ColumnIndex = 2 Then 'PESO
            If DGVLotes.Item(0, e.RowIndex).Value Is DBNull.Value Or DGVLotes.Item(0, e.RowIndex).Value Is Empty Then
                MessageBox.Show("Informe o [LOTE] primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SendKeys.Send("{HOME}")
                DGVLotes.Item(0, e.RowIndex).Value = ""            'LOTE
                DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                DGVLotes.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                DGVLotes.Item(3, e.RowIndex).Value = DBNull.Value  'ID_SERVICO
                DGVLotes.CancelEdit()
            End If
        End If
        '******************* RECALCULA TOTAIS *******************************************
        SOMALOTES()
    End Sub
    Private Sub DGVLotes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVLotes.DataError
        ' Se a fonte de dados levanta uma exceção quando uma célula esta comitda exibe um erro.
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 1 Then 'SACA
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DGVLotes.Item(1, e.RowIndex).Value = DBNull.Value
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 2 Then 'PESO
            MessageBox.Show("A coluna [PESO] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("O código do cliente - CustomerID - não pode ser duplicado.")
        End If
    End Sub
    Private Sub DGVLotes_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVLotes.UserAddedRow
        DGVLotes.Rows(e.Row.Index - 1).Cells("ID_SERVICO").Value = id_servico
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
        DGVLotes.Columns(1).Width = 67
        DGVLotes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVLotes.Columns(1).DefaultCellStyle.Format = "###,###0.0"
        DGVLotes.Columns(2).Width = 61
        DGVLotes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVLotes.Columns(2).DefaultCellStyle.Format = "###,###0.0"
        DGVLotes.Columns(3).Visible = False
        DGVLotes.Columns(4).Visible = False
        DGVLotes.Columns(5).DefaultCellStyle.Format = "###,###0.00"
        DGVLotes.Columns(5).Width = 55
        DGVLotes.Columns(5).HeaderText = "VAL(R$)"
    End Sub
    Private Sub FormataGridResultado()
        DGVResultado.RowHeadersWidth = 24
        DGVResultado.Columns(0).Width = 60
        DGVResultado.Columns(1).Width = 67
        DGVResultado.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVResultado.Columns(1).DefaultCellStyle.Format = "###,###0.0"
        DGVResultado.Columns(2).Width = 61
        DGVResultado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVResultado.Columns(2).DefaultCellStyle.Format = "###,###0.0"
        DGVResultado.Columns(3).Visible = False
        DGVResultado.Columns(4).Visible = False
    End Sub
    Private Sub DGVResultado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVResultado.CellEndEdit
        If e.ColumnIndex = 0 Then 'LOTE
            If Not DGVResultado.Item(0, e.RowIndex).Value Is Nothing Then
                DGVResultado.CurrentCell.Value = DGVResultado.CurrentCell.Value.ToString.ToUpper()
                sql(0) = "SELECT * FROM ENTRADA_ITENS WHERE LOTE='" & DGVResultado.Item(0, e.RowIndex).Value.ToString & "'"
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                If dr_busca_id.HasRows Then
                    MessageBox.Show("O lote : [ " & DGVResultado.Item(0, e.RowIndex).Value & " ] já existe no estoque, informe outro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SendKeys.Send("{HOME}")
                    DGVResultado.Item(0, e.RowIndex).Value = ""            'LOTE
                    DGVResultado.Item(1, e.RowIndex).Value = DBNull.Value  'SACAS
                    DGVResultado.Item(2, e.RowIndex).Value = DBNull.Value  'PESO
                    DGVResultado.Item(3, e.RowIndex).Value = DBNull.Value  'ID_SERVICO
                    DGVResultado.CancelEdit()
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then 'SACAS
            If Not DGVResultado.Item(1, e.RowIndex).Value Is DBNull.Value And Not DGVResultado.Item(1, e.RowIndex).Value Is Empty Then
                DGVResultado.Rows(e.RowIndex).Cells(2).Value = DGVResultado.Rows(e.RowIndex).Cells(1).Value * 60.5
            End If
            SOMARESULTADO()
        ElseIf e.ColumnIndex = 2 Then 'SACAS
            SOMARESULTADO()
        End If
        '******************* RECALCULA TOTAIS *******************************************
    End Sub
    Private Sub DGVResultado_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVResultado.DataError
        ' Se a fonte de dados levanta uma exceção quando uma célula esta comitda exibe um erro.
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 1 Then 'SACA
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 2 Then 'PESO
            MessageBox.Show("A coluna [PESO] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Context = DataGridViewDataErrorContexts.Parsing Then
            MsgBox("Dado errado")
        End If
    End Sub
    Private Sub DGVResultado_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVResultado.UserAddedRow
        DGVResultado.Rows(e.Row.Index - 1).Cells("ID_SERVICO").Value = id_servico
    End Sub
    Private Sub DGVResultado_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVResultado.UserDeletedRow
        SOMARESULTADO()
    End Sub
    Private Sub DGVResultado_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGVResultado.UserDeletingRow
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
        frmReportServico.Show()
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
        If e.ColumnIndex = 3 Then 'LOTE
            SOMASACARIA()
        End If
    End Sub
    Private Sub DGVSacaria_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVSacaria.DataError
        'QUANDO BANCO DE DADOS ENCONTRA UMA VIOLAÇÃO OU ERRO DO BANCO DE DADOS ESSA ROTINA É DISPARADA
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 3 Then 'SACA
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Context = DataGridViewDataErrorContexts.Parsing Then
            MsgBox("Dado errado")
        End If
    End Sub
    Private Sub DGVSacaria_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVSacaria.UserAddedRow
        DGVSacaria.Rows(e.Row.Index - 1).Cells("ID_SERVICO").Value = id_servico
    End Sub
    Private Sub mskSE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskSE.GotFocus
        mskSE.SelectAll()
    End Sub
    Private Sub mskSE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskSE.KeyDown
        If e.KeyCode = Keys.Return Then cboDepositante.Focus()
    End Sub
    Private Sub mskSE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskSE.LostFocus
        Dim dview As DataView = ds.Tables(0).DefaultView
        If altera = False Then
            If mskSE.Text <> "____/__" Then
                dview.RowFilter = "SE ='" & mskSE.Text & "'"
                If dview.Count > 0 Then
                    MessageBox.Show("A OS : [ " & mskSE.Text & " ] já existe no banco de dados, informe outro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'mskSE.Focus()
                End If
                fe_aux = mskSE.Text
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
            mskSE.Text = (1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
        Else
            bm.Position = bm.Count
            Dim x1 As Int32 = Mid(ds.Tables(0).Rows(bm.Position).Item("SE").ToString(), 1, 4)

            sql(0) = "SELECT * FROM " & tabela_db & " ORDER BY ID_SERVICO"
            If cn.State = 0 Then cn.Open()
            Dim cma As New OleDbCommand(sql(0), cn)
            Dim dr_busca_repitido As OleDbDataReader = cma.ExecuteReader

            If dr_busca_repitido.HasRows Then

                Do While dr_busca_repitido.Read

                    sql(0) = "SELECT * FROM " & tabela_db & " WHERE SE = '" & (x1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2) & "'"
                    If cn.State = 0 Then cn.Open()
                    Dim cma2 As New OleDbCommand(sql(0), cn)
                    Dim dr_busca_repitido2 As OleDbDataReader = cma2.ExecuteReader

                    If Not dr_busca_repitido2.HasRows Then
                        mskSE.Text = (x1).ToString.PadLeft(4, "0"c) & "/" & Mid(Year(Today), 3, 2)
                        Exit Do

                    End If
                    x1 = x1 + 1

                Loop
            End If



        End If
        controle_soma = True
        cadastrando = True
        id_servico = 0
        cboDepositante.Text = ""
        cboDepositante.Focus()
        ckbConsulta.Checked = False
        fe_aux = mskSE.Text
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
                        DGVServicos.Rows(e.RowIndex).Cells(15).Value = ""         'F_E
                        DGVServicos.Rows(e.RowIndex).Cells(16).Value = mskSE.Text 'S_E
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

    Private Sub DGVServicos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVServicos.DataError
        If e.Exception IsNot Nothing AndAlso e.ColumnIndex = 9 Then 'SACAS
            MessageBox.Show("A coluna [SACAS] aceita somente números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.Context = DataGridViewDataErrorContexts.Parsing Then
            MsgBox("Dado errado")
        End If
    End Sub
    Private Sub DGVServicos_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVServicos.UserAddedRow
        If id_servico = 0 Then
            DGVServicos.Rows(e.Row.Index - 1).Cells("S_E").Value = 9999999
        Else
            DGVServicos.Rows(e.Row.Index - 1).Cells("S_E").Value = mskSE.Text
        End If
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
    Protected Sub SOMALOTES()
        Dim totalpeso As Double
        Dim totalsacas As Int32
        For ContadorLinhas As Integer = 0 To DGVLotes.Rows.Count - 2
            If Not IsDBNull(DGVLotes.Rows(ContadorLinhas).Cells(2).Value) And Not IsDBNull(DGVLotes.Rows(ContadorLinhas).Cells(1).Value) Then
                totalpeso += CDbl(DGVLotes.Rows(ContadorLinhas).Cells(2).Value)
                totalsacas += DGVLotes.Rows(ContadorLinhas).Cells(1).Value
            End If
        Next
        lblTotalPeso.Text = totalpeso.ToString("###,###,##0.0")
        lblTotalSacas.Text = totalsacas.ToString("###,###,##0.0")
        If txtAmostra.Text = "" And txtPo.Text = "" And txtSacaria.Text = "" Then
            lblTotalPeso2.Text = totalpeso.ToString("###,###,##0.0")
        ElseIf txtAmostra.Text <> "" And txtPo.Text = "" And txtSacaria.Text = "" Then
            lblTotalPeso2.Text = (totalpeso - txtAmostra.Text).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text <> "" And txtPo.Text <> "" And txtSacaria.Text = "" Then
            lblTotalPeso2.Text = (totalpeso - (Val(txtAmostra.Text) + Val(txtPo.Text))).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text <> "" And txtPo.Text <> "" And txtSacaria.Text <> "" Then
            lblTotalPeso2.Text = (totalpeso - (Val(txtAmostra.Text) + Val(txtPo.Text) + Val(txtSacaria.Text))).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text = "" And txtPo.Text <> "" And txtSacaria.Text = "" Then
            lblTotalPeso2.Text = (totalpeso - txtPo.Text).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text = "" And txtPo.Text = "" And txtSacaria.Text <> "" Then
            lblTotalPeso2.Text = (totalpeso - txtSacaria.Text).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text <> "" And txtPo.Text = "" And txtSacaria.Text <> "" Then
            lblTotalPeso2.Text = (totalpeso - (Val(txtAmostra.Text) + Val(txtSacaria.Text))).ToString("###,###,##0.0")
        ElseIf txtAmostra.Text = "" And txtPo.Text <> "" And txtSacaria.Text <> "" Then
            lblTotalPeso2.Text = (totalpeso - (Val(txtPo.Text) + Val(txtSacaria.Text))).ToString("###,###,##0.0")
        End If
    End Sub
    Protected Sub SOMASACARIA()
        Dim totalsacas As Int32
        For ContadorLinhas As Integer = 0 To DGVSacaria.Rows.Count - 2
            totalsacas += DGVSacaria.Rows(ContadorLinhas).Cells(3).Value
        Next
        lblTotalSacaria.Text = (totalsacas).ToString("###,###,##0.0")
        txtSacaria.Text = (totalsacas * 0.5).ToString("###,###,##0.0")
        SOMALOTES()
    End Sub
    Protected Sub SOMARESULTADO()
        Dim totalpeso As Double
        Dim totalsacas As Int32
        For ContadorLinhas As Integer = 0 To DGVResultado.Rows.Count - 2
            totalsacas += DGVResultado.Rows(ContadorLinhas).Cells(1).Value
            totalpeso += DGVResultado.Rows(ContadorLinhas).Cells(2).Value
        Next
        lblTotalSacasResultado.Text = totalsacas.ToString("###,###,##0.0")
        lblTotalPesoResultado.Text = totalpeso.ToString("###,###,##0.0")
    End Sub
    Private Sub DGVSacaria_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGVSacaria.UserDeletedRow
        SOMASACARIA()
    End Sub
    Private Sub txtAmostra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmostra.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtAmostra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmostra.KeyUp
        If e.KeyCode = Keys.Return Then txtPo.Focus()
    End Sub
    Private Sub txtAmostra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmostra.TextChanged
        SOMALOTES()
        If txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        End If
    End Sub
    Private Sub txtPo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPo.KeyDown
        If e.KeyCode = Keys.Return Then txtSacaria.Focus()
    End Sub
    Private Sub txtPo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtPo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPo.TextChanged
        SOMALOTES()
        If txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        End If

    End Sub
    Private Sub txtSacaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSacaria.KeyDown
        If e.KeyCode = Keys.Return Then cmdSalvar.Focus()
    End Sub
    Private Sub txtSacaria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSacaria.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
    End Sub
    Private Sub txtSacaria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSacaria.TextChanged
        SOMALOTES()
    End Sub
    Private Sub btnConsulRapida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulRapida.Click
        If txtConsulLote.Text <> "" Then
            If altera = False And cadastrando = False Then
                Cursor.Current = Cursors.WaitCursor
                Dim xy As Int32 = 0
                sql(0) = "SELECT * FROM SERVICO_LOTES WHERE LOTE = '" & txtConsulLote.Text & "'"
                If cn.State = 0 Then cn.Open()
                Dim cmlo As New OleDbCommand(sql(0), cn)
                Dim dr_busca_id As OleDbDataReader = cmlo.ExecuteReader
                If dr_busca_id.HasRows Then
                    While dr_busca_id.Read
                        CriterioBusca = dr_busca_id("ID_SERVICO")
                    End While
                    '***************** VERIFICA SE O LOTE SAIU EM VARIOS SERVIÇOS DIFERENTES ****************************
                    sql(0) = "SELECT * FROM qSERVIÇO_LOTES WHERE LOTE = '" & txtConsulLote.Text & "'"
                    Dim cmlox As New OleDbCommand(sql(0), cn)
                    Dim dr_busca_l As OleDbDataReader = cmlox.ExecuteReader
                    If dr_busca_l.HasRows Then

                        While dr_busca_l.Read
                            xy += +1
                        End While
                        If xy > 1 Then
                            ServicoX = True
                            LotesX = txtConsulLote.Text
                            frmBuscaLotes.ShowDialog()
                        End If
                    End If

                    '************************************ PREENCHE DATASET SERVIÇO ***********************************************
                    ds.Clear()
                    sql(0) = "SELECT * FROM " & tabela_db & " WHERE ID_SERVICO = " & CriterioBusca & ""
                    Dim cm As New OleDbCommand(sql(0), cn)
                    da = New OleDbDataAdapter(cm)
                    'OTIMIZA PREENCHIMENTO DO DATASET**********************
                    ds.EnforceConstraints = False                        '*
                    If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
                    ds.Tables(tabela_db).BeginLoadData()                 '*
                    '******************************************************
                    da.Fill(ds, tabela_db)
                    'OTIMIZA PREENCHIMENTO DO DATASET****
                    ds.Tables(tabela_db).EndLoadData() '*
                    '************************************
                    dr = ds.Tables(tabela_db).Select("ID_SERVICO = " & CriterioBusca & "")(0) 'BUSCA A ENTRADA
                    altera = True
                    limpa(Me)
                    Visualizando()
                    fe_aux = mskSE.Text
                    estadobotao("exibido")
                    '************************************** PREENCHE DATASET SERVICO_LOTES ****************************************
                    If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
                    sql(0) = "SELECT * FROM SERVICO_LOTES WHERE ID_SERVICO =" & CriterioBusca & ""
                    Dim cmi As New OleDbCommand(sql(0), cn)
                    dai = New OleDbDataAdapter(cmi)
                    'OTIMIZA PREENCHIMENTO DO DATASET******************************
                    dsi.EnforceConstraints = False                               '*
                    If dsi.Tables.Count = 0 Then dsi.Tables.Add("SERVICO_LOTES") '*
                    dsi.Tables("SERVICO_LOTES").BeginLoadData()                  '*
                    '**************************************************************
                    dai.Fill(dsi, "SERVICO_LOTES")
                    'OTIMIZA PREENCHIMENTO DO DATASET***********
                    dsi.Tables("SERVICO_LOTES").EndLoadData() '*
                    '*******************************************
                    dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
                    '*********************************** PREENCHE O DATASET SERVICO_RESULTADO ***************************************
                    If DGVResultado.Rows.Count > 0 Then ds_resul.Tables(0).Clear()
                    sql(0) = "SELECT * FROM SERVICO_RESULTADO WHERE ID_SERVICO =" & CriterioBusca & ""
                    Dim cmn As New OleDbCommand(sql(0), cn)
                    da_resul = New OleDbDataAdapter(cmn)
                    'OTIMIZA PREENCHIMENTO DO DATASET**********************************
                    dsi.EnforceConstraints = False                                   '*
                    If ds_resul.Tables.Count = 0 Then ds_resul.Tables.Add("SERVICO_RESULTADO") '*
                    ds_resul.Tables("SERVICO_RESULTADO").BeginLoadData()                  '*
                    '******************************************************************
                    da_resul.Fill(ds_resul, "SERVICO_RESULTADO")
                    'OTIMIZA PREENCHIMENTO DO DATASET***********
                    ds_resul.Tables("SERVICO_RESULTADO").EndLoadData() '*
                    '*******************************************
                    If Not ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPesoResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
                    If Not ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacasResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
                    '************************** PREENCHE O DATSET DO GRID SACARIA *************************************************
                    sql(0) = "SELECT * FROM SACARIA_SERVICO WHERE ID_SERVICO = " & CriterioBusca & ""
                    Dim cmsc As New OleDbCommand(sql(0), cn)
                    dasc1 = New OleDbDataAdapter(cmsc)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************
                    dssc1.EnforceConstraints = False                                   '*
                    If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_SERVICO") '*
                    dssc1.Tables("SACARIA_SERVICO").BeginLoadData()                    '*
                    '********************************************************************
                    dasc1.Fill(dssc1, "SACARIA_SERVICO")
                    'OTIMIZA PREENCHIMENTO DO DATASET************
                    dssc1.Tables("SACARIA_SERVICO").EndLoadData()      '*
                    '********************************************
                    If Not dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty) Is DBNull.Value Then lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
                    '************************ PREENCHE O DATASET DO GRID SERVICO_OPERACAO ***********************************************
                    If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                    Dim xx As Int32
                    sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE S_E = '" & mskSE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                    Dim cm_op As New OleDbCommand(sql(0), cn)
                    da_ser_oper = New OleDbDataAdapter(cm_op)
                    'OTIMIZA PREENCHIMENTO DO DATASET*************************************************
                    ds_ser_oper.EnforceConstraints = False                                          '*
                    If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
                    ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()                          '*
                    '*********************************************************************************
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
                id_servico = 0
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
        ElseIf mskSEConsulta.Text <> "    /" Then
            If altera = False Or cadastrando = False Then
                Cursor.Current = Cursors.WaitCursor
                '************************************** PREENCHE DATASET ENTRADA *********************************************
                ds.Clear()
                sql(0) = "SELECT * FROM " & tabela_db & " WHERE SE = '" & mskSEConsulta.Text & "'"
                Dim cm As New OleDbCommand(sql(0), cn)
                da = New OleDbDataAdapter(cm)
                'OTIMIZA PREENCHIMENTO DO DATASET**********************
                ds.EnforceConstraints = False                        '*
                If ds.Tables.Count = 0 Then ds.Tables.Add(tabela_db) '*
                ds.Tables(tabela_db).BeginLoadData()                 '*
                '******************************************************
                da.Fill(ds, tabela_db)
                'OTIMIZA PREENCHIMENTO DO DATASET****
                ds.Tables(tabela_db).EndLoadData() '*
                '************************************
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(tabela_db).Select("SE = '" & mskSEConsulta.Text & "'")(0) 'BUSCA A ENTRADA
                    altera = True
                    limpa(Me)
                    Visualizando()
                    fe_aux = mskSE.Text
                    estadobotao("exibido")
                    '**************************************** PREENCHE DATASET SERVICO_LOTES ***************************************
                    If DGVLotes.Rows.Count > 0 Then dsi.Tables(0).Clear()
                    sql(0) = "SELECT * FROM SERVICO_LOTES WHERE ID_SERVICO =" & CriterioBusca & ""
                    Dim cmi As New OleDbCommand(sql(0), cn)
                    dai = New OleDbDataAdapter(cmi)
                    'OTIMIZA PREENCHIMENTO DO DATASET******************************
                    dsi.EnforceConstraints = False                               '*
                    If dsi.Tables.Count = 0 Then dsi.Tables.Add("SERVICO_LOTES") '*
                    dsi.Tables("SERVICO_LOTES").BeginLoadData()                  '*
                    '**************************************************************
                    dai.Fill(dsi, "SERVICO_LOTES")
                    'OTIMIZA PREENCHIMENTO DO DATASET***********
                    dsi.Tables("SERVICO_LOTES").EndLoadData() '*
                    '*******************************************
                    dsi.Tables(0).PrimaryKey = New DataColumn() {dsi.Tables(0).Columns("LOTE")} 'DEFINA CHAVE PRIMARIA
                    '*********************************** PREENCHE O DATASET SERVICO_RESULTADO ***************************************
                    If DGVResultado.Rows.Count > 0 Then ds_resul.Tables(0).Clear()
                    sql(0) = "SELECT * FROM SERVICO_RESULTADO WHERE ID_SERVICO =" & CriterioBusca & ""
                    Dim cmn As New OleDbCommand(sql(0), cn)
                    da_resul = New OleDbDataAdapter(cmn)
                    'OTIMIZA PREENCHIMENTO DO DATASET**********************************
                    dsi.EnforceConstraints = False                                   '*
                    If ds_resul.Tables.Count = 0 Then ds_resul.Tables.Add("SERVICO_RESULTADO") '*
                    ds_resul.Tables("SERVICO_RESULTADO").BeginLoadData()                  '*
                    '******************************************************************
                    da_resul.Fill(ds_resul, "SERVICO_RESULTADO")
                    'OTIMIZA PREENCHIMENTO DO DATASET***************
                    ds_resul.Tables("SERVICO_RESULTADO").EndLoadData() '*
                    '***********************************************
                    If Not ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPesoResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")
                    If Not ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacasResultado.Text = Convert.ToDouble(ds_resul.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
                    '************************* PREENCHE O DATASOURCE DO GRID SACARIA******************************************************
                    sql(0) = "SELECT * FROM SACARIA_SERVICO WHERE ID_SERVICO = " & CriterioBusca & ""
                    Dim cmsc As New OleDbCommand(sql(0), cn)
                    dasc1 = New OleDbDataAdapter(cmsc)
                    'OTIMIZA PREENCHIMENTO DO DATASET************************************
                    dssc1.EnforceConstraints = False                                   '*
                    If dssc1.Tables.Count = 0 Then dssc1.Tables.Add("SACARIA_SERVICO") '*
                    dssc1.Tables("SACARIA_SERVICO").BeginLoadData()                    '*
                    '********************************************************************
                    dasc1.Fill(dssc1, "SACARIA_SERVICO")
                    'OTIMIZA PREENCHIMENTO DO DATASET***************
                    dssc1.Tables("SACARIA_SERVICO").EndLoadData() '*
                    '***********************************************
                    If Not dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty) Is DBNull.Value Then lblTotalSacaria.Text = dssc1.Tables(0).Compute("SUM(QTDE)", String.Empty).ToString
                    '************************* PREENCHE O DATASET DO GRID SERVICO_OPERACAO ***********************************************
                    If DGVServicos.Rows.Count > 0 Then ds_ser_oper.Tables(0).Clear()
                    Dim xx As Int32
                    sql(0) = "SELECT * FROM SERVICO_OPERACAO WHERE S_E = '" & mskSE.Text & "' ORDER BY ID_SERVICO_OPERACAO ASC"
                    Dim cm_op As New OleDbCommand(sql(0), cn)
                    da_ser_oper = New OleDbDataAdapter(cm_op)
                    'OTIMIZA PREENCHIMENTO DO DATASET*************************************************
                    ds_ser_oper.EnforceConstraints = False                                          '*
                    If ds_ser_oper.Tables.Count = 0 Then ds_ser_oper.Tables.Add("SERVICO_OPERACAO") '*
                    ds_ser_oper.Tables("SERVICO_OPERACAO").BeginLoadData()                          '*
                    '*********************************************************************************
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
                    mskSEConsulta.Enabled = True
                    mskSEConsulta.Mask = "####/##"
                    mskSEConsulta.Focus()
                End If
            End If
            cadastrando = False
            If Not dsi.Tables(0).Compute("SUM(SACAS)", String.Empty) Is DBNull.Value Then lblTotalSacas.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(SACAS)", String.Empty)).ToString("###,###,##0.0")
            If Not dsi.Tables(0).Compute("SUM(PESO)", String.Empty) Is DBNull.Value Then lblTotalPeso.Text = Convert.ToDouble(dsi.Tables(0).Compute("SUM(PESO)", String.Empty)).ToString("###,###,##0.0")

            altera = False
            'BUSCA FE DO RESULTADO E EXIBE NO LABEL*****************************************************************
            sql(0) = "SELECT FE, COD_SERVICO_ORIGEM FROM ENTRADA WHERE COD_SERVICO_ORIGEM = '" & mskSE.Text & "'"
            If cn.State = 0 Then cn.Open()
            Dim cmoen As New OleDbCommand(sql(0), cn)
            Dim dr_oen As OleDbDataReader = cmoen.ExecuteReader
            If dr_oen.HasRows Then
                Do While dr_oen.Read
                    lblFEResultado.Text = dr_oen.GetString(0)
                Loop
            Else
                lblFEResultado.Text = ""
            End If
            '*******************************************************************************************************
            If txtAmostra.Text = "" And txtPo.Text = "" And lblTotalPeso.Text <> "" And txtSacaria.Text <> "" Then
                lblTotalPeso2.Text = Convert.ToDouble(lblTotalPeso.Text).ToString("###,###,##0.0")
            Else
                If lblTotalPeso.Text <> "" Then lblTotalPeso2.Text = Convert.ToDouble(lblTotalPeso.Text - (Val(txtAmostra.Text) + Val(txtPo.Text) + Val(txtSacaria.Text))).ToString("###,###,##0.0")
            End If

            Cursor.Current = Cursors.Default
        Else
            id_servico = 0
            estadobotao("inicio")
            limpa(Me)
            habilita(Me, False)
            altera = False
            cadastrando = False
            mskSEConsulta.Enabled = True
        End If
    End Sub
    Private Sub mskSEConsulta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskSEConsulta.GotFocus
        txtConsulLote.Text = ""
    End Sub
    Private Sub mskSEConsulta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskSEConsulta.KeyDown
        If (e.KeyCode = Keys.Return) Then btnConsulRapida_Click(e, New System.EventArgs)
    End Sub
    Private Sub txtConsulLote_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsulLote.GotFocus
        mskSEConsulta.Text = ""
        mskSEConsulta.Mask = "####/##"
    End Sub
    Private Sub txtConsulLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConsulLote.KeyDown
        If (e.KeyCode = Keys.Return) Then btnConsulRapida_Click(e, New System.EventArgs)
    End Sub
    Private Sub ckbConsulta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbConsulta.CheckedChanged
        If ckbConsulta.Checked = True Then
            mskSEConsulta.Text = ""
            mskSEConsulta.Mask = "####/##"
            txtConsulLote.Text = ""
            GroupBox1.Enabled = True
            estadobotao("inicio")
            limpa(Me)
            habilita(Me, False)
            altera = False
            cadastrando = False
            txtConsulLote.Enabled = True
            mskSEConsulta.Focus()
        Else
            mskSEConsulta.Text = ""
            mskSEConsulta.Mask = "####/##"
            txtConsulLote.Text = ""
            GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub txtDestino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDestino.KeyDown
        If e.KeyCode = Keys.Return Then DGVLotes.Focus()
    End Sub
    Private Sub dtpDataTermino_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDataTermino.KeyUp
        If e.KeyCode = Keys.Return Then txtAmostra.Focus()
    End Sub

    Private Sub cboDepositante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepositante.GotFocus
        Yx = ""
    End Sub
    Private Sub cboDepositante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDepositante.KeyDown
        If e.KeyCode = Keys.Return Then txtDestino.Focus()
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

    Private Sub txtPedra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPedra.TextChanged
        If txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text <> "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPo.Text = "", "0", txtPo.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text)) + CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        ElseIf txtPedra.Text = "" And txtAmostra.Text <> "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtAmostra.Text = "", "0", txtAmostra.Text))).ToString
        ElseIf txtPedra.Text <> "" And txtAmostra.Text = "" And txtPo.Text = "" Then
            txtQAQuilos.Text = "-" & (CDec(IIf(txtPedra.Text = "", "0", txtPedra.Text))).ToString
        End If
    End Sub

    Private Sub mskSEConsulta_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskSEConsulta.MaskInputRejected

    End Sub

    Private Sub DGVLotes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLotes.CellContentClick

    End Sub

    Private Sub DGVLotes_DragLeave(sender As Object, e As System.EventArgs) Handles DGVLotes.DragLeave

    End Sub
End Class