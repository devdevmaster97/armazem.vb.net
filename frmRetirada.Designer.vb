<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetirada))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotalPesoCaminhoes = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPesoBalanca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDataEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalSacas = New System.Windows.Forms.Label()
        Me.lblTotalPeso = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.CmdExcluir = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdCadastrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskRE = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalSacaria = New System.Windows.Forms.Label()
        Me.ckbConsulta = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsulRapida = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mskSEConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtConsulLote = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmostras = New System.Windows.Forms.TextBox()
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.DGVCaminhoes = New ARMAZEM.CustomDataGridView()
        Me.DGVSacaria = New ARMAZEM.CustomDataGridView()
        Me.DGVServicos = New ARMAZEM.CustomDataGridView()
        Me.DGVLotes = New ARMAZEM.CustomDataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSobra = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCaminhoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSacaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalPesoCaminhoes
        '
        Me.lblTotalPesoCaminhoes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalPesoCaminhoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPesoCaminhoes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPesoCaminhoes.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPesoCaminhoes.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalPesoCaminhoes.Location = New System.Drawing.Point(314, 504)
        Me.lblTotalPesoCaminhoes.Name = "lblTotalPesoCaminhoes"
        Me.lblTotalPesoCaminhoes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPesoCaminhoes.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalPesoCaminhoes.TabIndex = 148
        Me.lblTotalPesoCaminhoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(604, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "Destino:"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(607, 74)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(250, 20)
        Me.txtDestino.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(613, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Peso balança:"
        '
        'txtPesoBalanca
        '
        Me.txtPesoBalanca.Location = New System.Drawing.Point(616, 394)
        Me.txtPesoBalanca.Name = "txtPesoBalanca"
        Me.txtPesoBalanca.Size = New System.Drawing.Size(93, 20)
        Me.txtPesoBalanca.TabIndex = 16
        Me.txtPesoBalanca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(413, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Serviços"
        '
        'dtpDataEntrada
        '
        Me.dtpDataEntrada.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataEntrada.Location = New System.Drawing.Point(12, 74)
        Me.dtpDataEntrada.Name = "dtpDataEntrada"
        Me.dtpDataEntrada.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataEntrada.TabIndex = 8
        Me.dtpDataEntrada.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(237, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Caminhões"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Lotes:"
        '
        'lblTotalSacas
        '
        Me.lblTotalSacas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalSacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSacas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSacas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSacas.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalSacas.Location = New System.Drawing.Point(8, 504)
        Me.lblTotalSacas.Name = "lblTotalSacas"
        Me.lblTotalSacas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSacas.Size = New System.Drawing.Size(75, 25)
        Me.lblTotalSacas.TabIndex = 138
        Me.lblTotalSacas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPeso
        '
        Me.lblTotalPeso.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPeso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPeso.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPeso.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalPeso.Location = New System.Drawing.Point(141, 504)
        Me.lblTotalPeso.Name = "lblTotalPeso"
        Me.lblTotalPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPeso.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalPeso.TabIndex = 139
        Me.lblTotalPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(740, 340)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Sacaria"
        '
        'btnImprime
        '
        Me.btnImprime.Enabled = False
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.Location = New System.Drawing.Point(350, 12)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(57, 41)
        Me.btnImprime.TabIndex = 6
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.UseVisualStyleBackColor = True
        '
        'CmdExcluir
        '
        Me.CmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdExcluir.Enabled = False
        Me.CmdExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExcluir.Image = CType(resources.GetObject("CmdExcluir.Image"), System.Drawing.Image)
        Me.CmdExcluir.Location = New System.Drawing.Point(236, 12)
        Me.CmdExcluir.Name = "CmdExcluir"
        Me.CmdExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdExcluir.Size = New System.Drawing.Size(57, 41)
        Me.CmdExcluir.TabIndex = 4
        Me.CmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdExcluir.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(293, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(407, 12)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(57, 41)
        Me.cmdSair.TabIndex = 7
        Me.cmdSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.Location = New System.Drawing.Point(122, 12)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 41)
        Me.cmdSalvar.TabIndex = 2
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalvar.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Location = New System.Drawing.Point(179, 12)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultar.Size = New System.Drawing.Size(57, 41)
        Me.cmdConsultar.TabIndex = 3
        Me.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.Enabled = False
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Image = CType(resources.GetObject("cmdAlterar.Image"), System.Drawing.Image)
        Me.cmdAlterar.Location = New System.Drawing.Point(65, 12)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 41)
        Me.cmdAlterar.TabIndex = 1
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdCadastrar
        '
        Me.cmdCadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCadastrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCadastrar.Image = CType(resources.GetObject("cmdCadastrar.Image"), System.Drawing.Image)
        Me.cmdCadastrar.Location = New System.Drawing.Point(8, 12)
        Me.cmdCadastrar.Name = "cmdCadastrar"
        Me.cmdCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCadastrar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCadastrar.TabIndex = 0
        Me.cmdCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCadastrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(167, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Depositante:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskRE
        '
        Me.mskRE.AllowPromptAsInput = False
        Me.mskRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRE.Location = New System.Drawing.Point(108, 74)
        Me.mskRE.Name = "mskRE"
        Me.mskRE.Size = New System.Drawing.Size(57, 20)
        Me.mskRE.TabIndex = 9
        Me.mskRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(105, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "O.R.:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(9, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Data:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(777, 513)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(73, 13)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "Total Sacaria:"
        '
        'lblTotalSacaria
        '
        Me.lblTotalSacaria.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalSacaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSacaria.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSacaria.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSacaria.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalSacaria.Location = New System.Drawing.Point(856, 501)
        Me.lblTotalSacaria.Name = "lblTotalSacaria"
        Me.lblTotalSacaria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSacaria.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalSacaria.TabIndex = 154
        Me.lblTotalSacaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbConsulta
        '
        Me.ckbConsulta.AutoSize = True
        Me.ckbConsulta.Location = New System.Drawing.Point(673, 37)
        Me.ckbConsulta.Name = "ckbConsulta"
        Me.ckbConsulta.Size = New System.Drawing.Size(15, 14)
        Me.ckbConsulta.TabIndex = 157
        Me.ckbConsulta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConsulRapida)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.mskSEConsulta)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtConsulLote)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(689, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 53)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta Rápida"
        '
        'btnConsulRapida
        '
        Me.btnConsulRapida.Location = New System.Drawing.Point(228, 15)
        Me.btnConsulRapida.Name = "btnConsulRapida"
        Me.btnConsulRapida.Size = New System.Drawing.Size(33, 33)
        Me.btnConsulRapida.TabIndex = 1
        Me.btnConsulRapida.Text = "OK"
        Me.btnConsulRapida.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(104, 33)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 134
        Me.Label24.Text = "ou"
        '
        'mskSEConsulta
        '
        Me.mskSEConsulta.AllowPromptAsInput = False
        Me.mskSEConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSEConsulta.Location = New System.Drawing.Point(9, 29)
        Me.mskSEConsulta.Name = "mskSEConsulta"
        Me.mskSEConsulta.Size = New System.Drawing.Size(93, 20)
        Me.mskSEConsulta.TabIndex = 0
        Me.mskSEConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(6, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Por S.E"
        '
        'txtConsulLote
        '
        Me.txtConsulLote.AcceptsReturn = True
        Me.txtConsulLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtConsulLote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConsulLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsulLote.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConsulLote.Location = New System.Drawing.Point(128, 29)
        Me.txtConsulLote.MaxLength = 10
        Me.txtConsulLote.Name = "txtConsulLote"
        Me.txtConsulLote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConsulLote.Size = New System.Drawing.Size(92, 20)
        Me.txtConsulLote.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(125, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 130
        Me.Label20.Text = "Por lote"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(613, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Amostras:"
        '
        'txtAmostras
        '
        Me.txtAmostras.Location = New System.Drawing.Point(616, 457)
        Me.txtAmostras.Name = "txtAmostras"
        Me.txtAmostras.Size = New System.Drawing.Size(93, 20)
        Me.txtAmostras.TabIndex = 158
        Me.txtAmostras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboDepositante
        '
        Me.cboDepositante.FormattingEnabled = True
        Me.cboDepositante.Location = New System.Drawing.Point(170, 73)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(428, 21)
        Me.cboDepositante.TabIndex = 10
        '
        'DGVCaminhoes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVCaminhoes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCaminhoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCaminhoes.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVCaminhoes.Location = New System.Drawing.Point(240, 115)
        Me.DGVCaminhoes.Name = "DGVCaminhoes"
        Me.DGVCaminhoes.Size = New System.Drawing.Size(167, 386)
        Me.DGVCaminhoes.TabIndex = 13
        '
        'DGVSacaria
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVSacaria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSacaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSacaria.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVSacaria.Location = New System.Drawing.Point(740, 357)
        Me.DGVSacaria.Name = "DGVSacaria"
        Me.DGVSacaria.Size = New System.Drawing.Size(209, 141)
        Me.DGVSacaria.TabIndex = 15
        '
        'DGVServicos
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVServicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVServicos.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVServicos.Location = New System.Drawing.Point(413, 115)
        Me.DGVServicos.Name = "DGVServicos"
        Me.DGVServicos.Size = New System.Drawing.Size(540, 222)
        Me.DGVServicos.TabIndex = 14
        '
        'DGVLotes
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVLotes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLotes.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVLotes.Location = New System.Drawing.Point(8, 115)
        Me.DGVLotes.Name = "DGVLotes"
        Me.DGVLotes.Size = New System.Drawing.Size(226, 386)
        Me.DGVLotes.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(466, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Sobra da retirada em kg:"
        '
        'lblSobra
        '
        Me.lblSobra.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblSobra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSobra.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSobra.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobra.ForeColor = System.Drawing.Color.Navy
        Me.lblSobra.Location = New System.Drawing.Point(469, 504)
        Me.lblSobra.Name = "lblSobra"
        Me.lblSobra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSobra.Size = New System.Drawing.Size(93, 25)
        Me.lblSobra.TabIndex = 162
        Me.lblSobra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PESO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PESO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_RETIRADA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_RETIRADA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(237, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "kg"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(410, 516)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "kg"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(86, 516)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "Scs"
        '
        'frmRetirada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 538)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSobra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmostras)
        Me.Controls.Add(Me.ckbConsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalSacaria)
        Me.Controls.Add(Me.DGVCaminhoes)
        Me.Controls.Add(Me.DGVSacaria)
        Me.Controls.Add(Me.DGVServicos)
        Me.Controls.Add(Me.DGVLotes)
        Me.Controls.Add(Me.lblTotalPesoCaminhoes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPesoBalanca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDataEntrada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalSacas)
        Me.Controls.Add(Me.lblTotalPeso)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.CmdExcluir)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdCadastrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mskRE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Name = "frmRetirada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETIRADA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCaminhoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSacaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblTotalPesoCaminhoes As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPesoBalanca As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntrada As System.Windows.Forms.DateTimePicker
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblTotalSacas As System.Windows.Forms.Label
    Public WithEvents lblTotalPeso As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Public WithEvents CmdExcluir As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdConsultar As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents cmdCadastrar As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents mskRE As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGVSacaria As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVServicos As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVLotes As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVCaminhoes As ARMAZEM.CustomDataGridView
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents lblTotalSacaria As System.Windows.Forms.Label
    Friend WithEvents ckbConsulta As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsulRapida As System.Windows.Forms.Button
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents mskSEConsulta As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents txtConsulLote As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmostras As System.Windows.Forms.TextBox
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblSobra As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
End Class
