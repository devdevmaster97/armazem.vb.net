<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEntrada
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntrada))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmdExcluir = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdCadastrar = New System.Windows.Forms.Button()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.mskFE = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMediaSaca = New System.Windows.Forms.TextBox()
        Me.txtPesoBalanca = New System.Windows.Forms.TextBox()
        Me.txtPesoObrigatorio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MskPlaca = New System.Windows.Forms.MaskedTextBox()
        Me.txtProcedencia = New System.Windows.Forms.TextBox()
        Me.txtSafra = New System.Windows.Forms.TextBox()
        Me.txtMotorista = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalSacas = New System.Windows.Forms.Label()
        Me.lblTotalPeso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDataEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalSacas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.cboRemetente = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalSacaria = New System.Windows.Forms.Label()
        Me.mskCodSerOrigem = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.mskCodRetOrigem = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsulRapida = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mskFEConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtConsulLote = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ckbConsulta = New System.Windows.Forms.CheckBox()
        Me.btnAbreDepositante = New System.Windows.Forms.Button()
        Me.btnAbreRemetente = New System.Windows.Forms.Button()
        Me.txtOrdemCompra = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DGVNotas = New ARMAZEM.CustomDataGridView()
        Me.DGVSacaria = New ARMAZEM.CustomDataGridView()
        Me.DGVServicos = New ARMAZEM.CustomDataGridView()
        Me.DGVLotes = New ARMAZEM.CustomDataGridView()
        Me.gridSaldos = New ARMAZEM.CustomDataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSacaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdExcluir
        '
        Me.CmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdExcluir.Enabled = False
        Me.CmdExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExcluir.Image = CType(resources.GetObject("CmdExcluir.Image"), System.Drawing.Image)
        Me.CmdExcluir.Location = New System.Drawing.Point(234, 5)
        Me.CmdExcluir.Name = "CmdExcluir"
        Me.CmdExcluir.Size = New System.Drawing.Size(57, 41)
        Me.CmdExcluir.TabIndex = 7
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
        Me.cmdCancelar.Location = New System.Drawing.Point(291, 5)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCancelar.TabIndex = 8
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
        Me.cmdSair.Location = New System.Drawing.Point(405, 5)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(57, 41)
        Me.cmdSair.TabIndex = 10
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
        Me.cmdSalvar.Location = New System.Drawing.Point(120, 5)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 41)
        Me.cmdSalvar.TabIndex = 5
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalvar.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Location = New System.Drawing.Point(177, 5)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(57, 41)
        Me.cmdConsultar.TabIndex = 6
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
        Me.cmdAlterar.Location = New System.Drawing.Point(63, 5)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 41)
        Me.cmdAlterar.TabIndex = 4
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdCadastrar
        '
        Me.cmdCadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCadastrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCadastrar.Image = CType(resources.GetObject("cmdCadastrar.Image"), System.Drawing.Image)
        Me.cmdCadastrar.Location = New System.Drawing.Point(6, 5)
        Me.cmdCadastrar.Name = "cmdCadastrar"
        Me.cmdCadastrar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCadastrar.TabIndex = 3
        Me.cmdCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCadastrar.UseVisualStyleBackColor = True
        '
        'btnImprime
        '
        Me.btnImprime.Enabled = False
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.Location = New System.Drawing.Point(348, 5)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(57, 41)
        Me.btnImprime.TabIndex = 9
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.UseVisualStyleBackColor = True
        '
        'mskFE
        '
        Me.mskFE.AllowPromptAsInput = False
        Me.mskFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFE.Location = New System.Drawing.Point(8, 101)
        Me.mskFE.Name = "mskFE"
        Me.mskFE.Size = New System.Drawing.Size(93, 20)
        Me.mskFE.TabIndex = 14
        Me.mskFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(5, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "F.E.:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(5, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "&Data:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(494, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Remetente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(104, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Depositante:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMediaSaca
        '
        Me.txtMediaSaca.AcceptsReturn = True
        Me.txtMediaSaca.BackColor = System.Drawing.SystemColors.Window
        Me.txtMediaSaca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMediaSaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMediaSaca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMediaSaca.Location = New System.Drawing.Point(383, 101)
        Me.txtMediaSaca.MaxLength = 10
        Me.txtMediaSaca.Name = "txtMediaSaca"
        Me.txtMediaSaca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMediaSaca.Size = New System.Drawing.Size(77, 20)
        Me.txtMediaSaca.TabIndex = 18
        '
        'txtPesoBalanca
        '
        Me.txtPesoBalanca.AcceptsReturn = True
        Me.txtPesoBalanca.BackColor = System.Drawing.SystemColors.Window
        Me.txtPesoBalanca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesoBalanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoBalanca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPesoBalanca.Location = New System.Drawing.Point(106, 101)
        Me.txtPesoBalanca.MaxLength = 10
        Me.txtPesoBalanca.Name = "txtPesoBalanca"
        Me.txtPesoBalanca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPesoBalanca.Size = New System.Drawing.Size(92, 20)
        Me.txtPesoBalanca.TabIndex = 15
        '
        'txtPesoObrigatorio
        '
        Me.txtPesoObrigatorio.AcceptsReturn = True
        Me.txtPesoObrigatorio.BackColor = System.Drawing.SystemColors.Window
        Me.txtPesoObrigatorio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesoObrigatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoObrigatorio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPesoObrigatorio.Location = New System.Drawing.Point(286, 101)
        Me.txtPesoObrigatorio.MaxLength = 10
        Me.txtPesoObrigatorio.Name = "txtPesoObrigatorio"
        Me.txtPesoObrigatorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPesoObrigatorio.Size = New System.Drawing.Size(91, 20)
        Me.txtPesoObrigatorio.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(521, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Sacaria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(380, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Media por saca"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(104, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Peso de balança"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(284, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Peso Obrigatório:"
        '
        'MskPlaca
        '
        Me.MskPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPlaca.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.MskPlaca.Location = New System.Drawing.Point(693, 101)
        Me.MskPlaca.Mask = ">AAA-####"
        Me.MskPlaca.Name = "MskPlaca"
        Me.MskPlaca.Size = New System.Drawing.Size(68, 20)
        Me.MskPlaca.TabIndex = 21
        '
        'txtProcedencia
        '
        Me.txtProcedencia.AcceptsReturn = True
        Me.txtProcedencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtProcedencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProcedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProcedencia.Location = New System.Drawing.Point(524, 101)
        Me.txtProcedencia.MaxLength = 0
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProcedencia.Size = New System.Drawing.Size(163, 20)
        Me.txtProcedencia.TabIndex = 20
        '
        'txtSafra
        '
        Me.txtSafra.AcceptsReturn = True
        Me.txtSafra.BackColor = System.Drawing.SystemColors.Window
        Me.txtSafra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSafra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSafra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSafra.Location = New System.Drawing.Point(466, 101)
        Me.txtSafra.MaxLength = 4
        Me.txtSafra.Name = "txtSafra"
        Me.txtSafra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSafra.Size = New System.Drawing.Size(52, 20)
        Me.txtSafra.TabIndex = 19
        '
        'txtMotorista
        '
        Me.txtMotorista.AcceptsReturn = True
        Me.txtMotorista.BackColor = System.Drawing.SystemColors.Window
        Me.txtMotorista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotorista.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMotorista.Location = New System.Drawing.Point(766, 101)
        Me.txtMotorista.MaxLength = 0
        Me.txtMotorista.Name = "txtMotorista"
        Me.txtMotorista.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMotorista.Size = New System.Drawing.Size(118, 20)
        Me.txtMotorista.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(690, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Placa"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(524, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Procedência:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(466, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Safra"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(763, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Motorista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Total Sacas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(147, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Total Peso:"
        '
        'lblTotalSacas
        '
        Me.lblTotalSacas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalSacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSacas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSacas.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSacas.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalSacas.Location = New System.Drawing.Point(6, 521)
        Me.lblTotalSacas.Name = "lblTotalSacas"
        Me.lblTotalSacas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSacas.Size = New System.Drawing.Size(87, 25)
        Me.lblTotalSacas.TabIndex = 95
        Me.lblTotalSacas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalPeso
        '
        Me.lblTotalPeso.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPeso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPeso.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPeso.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalPeso.Location = New System.Drawing.Point(150, 521)
        Me.lblTotalPeso.Name = "lblTotalPeso"
        Me.lblTotalPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPeso.Size = New System.Drawing.Size(105, 25)
        Me.lblTotalPeso.TabIndex = 96
        Me.lblTotalPeso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Lotes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(736, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Notas:"
        '
        'dtpDataEntrada
        '
        Me.dtpDataEntrada.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataEntrada.Location = New System.Drawing.Point(8, 64)
        Me.dtpDataEntrada.Name = "dtpDataEntrada"
        Me.dtpDataEntrada.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataEntrada.TabIndex = 11
        Me.dtpDataEntrada.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(523, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Serviços"
        '
        'txtTotalSacas
        '
        Me.txtTotalSacas.AcceptsReturn = True
        Me.txtTotalSacas.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalSacas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalSacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSacas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalSacas.Location = New System.Drawing.Point(204, 101)
        Me.txtTotalSacas.MaxLength = 10
        Me.txtTotalSacas.Name = "txtTotalSacas"
        Me.txtTotalSacas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalSacas.Size = New System.Drawing.Size(76, 20)
        Me.txtTotalSacas.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(201, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Total de sacas"
        '
        'cboDepositante
        '
        Me.cboDepositante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepositante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepositante.FormattingEnabled = True
        Me.cboDepositante.Location = New System.Drawing.Point(107, 64)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(355, 21)
        Me.cboDepositante.TabIndex = 12
        '
        'cboRemetente
        '
        Me.cboRemetente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRemetente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemetente.FormattingEnabled = True
        Me.cboRemetente.Location = New System.Drawing.Point(494, 64)
        Me.cboRemetente.Name = "cboRemetente"
        Me.cboRemetente.Size = New System.Drawing.Size(359, 21)
        Me.cboRemetente.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(403, 508)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(73, 13)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = "Total Sacaria:"
        '
        'lblTotalSacaria
        '
        Me.lblTotalSacaria.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalSacaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSacaria.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSacaria.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSacaria.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalSacaria.Location = New System.Drawing.Point(406, 521)
        Me.lblTotalSacaria.Name = "lblTotalSacaria"
        Me.lblTotalSacaria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSacaria.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalSacaria.TabIndex = 120
        Me.lblTotalSacaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mskCodSerOrigem
        '
        Me.mskCodSerOrigem.AllowPromptAsInput = False
        Me.mskCodSerOrigem.Enabled = False
        Me.mskCodSerOrigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCodSerOrigem.Location = New System.Drawing.Point(567, 525)
        Me.mskCodSerOrigem.Name = "mskCodSerOrigem"
        Me.mskCodSerOrigem.Size = New System.Drawing.Size(93, 20)
        Me.mskCodSerOrigem.TabIndex = 124
        Me.mskCodSerOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(564, 512)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "ORIGEM SERVIÇO"
        '
        'mskCodRetOrigem
        '
        Me.mskCodRetOrigem.AllowPromptAsInput = False
        Me.mskCodRetOrigem.Enabled = False
        Me.mskCodRetOrigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCodRetOrigem.Location = New System.Drawing.Point(720, 525)
        Me.mskCodRetOrigem.Name = "mskCodRetOrigem"
        Me.mskCodRetOrigem.Size = New System.Drawing.Size(93, 20)
        Me.mskCodRetOrigem.TabIndex = 126
        Me.mskCodRetOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(713, 512)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(108, 13)
        Me.Label22.TabIndex = 127
        Me.Label22.Text = "ORIGEM RETIRADA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConsulRapida)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.mskFEConsulta)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtConsulLote)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(618, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 53)
        Me.GroupBox1.TabIndex = 129
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
        'mskFEConsulta
        '
        Me.mskFEConsulta.AllowPromptAsInput = False
        Me.mskFEConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFEConsulta.Location = New System.Drawing.Point(9, 29)
        Me.mskFEConsulta.Name = "mskFEConsulta"
        Me.mskFEConsulta.Size = New System.Drawing.Size(93, 20)
        Me.mskFEConsulta.TabIndex = 0
        Me.mskFEConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Por F.E"
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
        'ckbConsulta
        '
        Me.ckbConsulta.AutoSize = True
        Me.ckbConsulta.Location = New System.Drawing.Point(602, 38)
        Me.ckbConsulta.Name = "ckbConsulta"
        Me.ckbConsulta.Size = New System.Drawing.Size(15, 14)
        Me.ckbConsulta.TabIndex = 130
        Me.ckbConsulta.UseVisualStyleBackColor = True
        '
        'btnAbreDepositante
        '
        Me.btnAbreDepositante.Location = New System.Drawing.Point(465, 63)
        Me.btnAbreDepositante.Name = "btnAbreDepositante"
        Me.btnAbreDepositante.Size = New System.Drawing.Size(24, 22)
        Me.btnAbreDepositante.TabIndex = 131
        Me.btnAbreDepositante.TabStop = False
        Me.btnAbreDepositante.Text = "..."
        Me.btnAbreDepositante.UseVisualStyleBackColor = True
        '
        'btnAbreRemetente
        '
        Me.btnAbreRemetente.Location = New System.Drawing.Point(859, 62)
        Me.btnAbreRemetente.Name = "btnAbreRemetente"
        Me.btnAbreRemetente.Size = New System.Drawing.Size(24, 23)
        Me.btnAbreRemetente.TabIndex = 132
        Me.btnAbreRemetente.TabStop = False
        Me.btnAbreRemetente.Text = "..."
        Me.btnAbreRemetente.UseVisualStyleBackColor = True
        '
        'txtOrdemCompra
        '
        Me.txtOrdemCompra.AcceptsReturn = True
        Me.txtOrdemCompra.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdemCompra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrdemCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdemCompra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrdemCompra.Location = New System.Drawing.Point(890, 101)
        Me.txtOrdemCompra.MaxLength = 0
        Me.txtOrdemCompra.Name = "txtOrdemCompra"
        Me.txtOrdemCompra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrdemCompra.Size = New System.Drawing.Size(118, 20)
        Me.txtOrdemCompra.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(887, 84)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(92, 13)
        Me.Label25.TabIndex = 134
        Me.Label25.Text = "Ordem de Compra"
        '
        'DGVNotas
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNotas.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVNotas.Location = New System.Drawing.Point(739, 370)
        Me.DGVNotas.Name = "DGVNotas"
        Me.DGVNotas.Size = New System.Drawing.Size(416, 138)
        Me.DGVNotas.TabIndex = 26
        '
        'DGVSacaria
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVSacaria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSacaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSacaria.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVSacaria.Location = New System.Drawing.Point(523, 370)
        Me.DGVSacaria.Name = "DGVSacaria"
        Me.DGVSacaria.Size = New System.Drawing.Size(210, 138)
        Me.DGVSacaria.TabIndex = 25
        '
        'DGVServicos
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVServicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVServicos.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVServicos.Location = New System.Drawing.Point(524, 142)
        Me.DGVServicos.Name = "DGVServicos"
        Me.DGVServicos.Size = New System.Drawing.Size(631, 211)
        Me.DGVServicos.TabIndex = 24
        '
        'DGVLotes
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVLotes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLotes.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVLotes.Location = New System.Drawing.Point(6, 142)
        Me.DGVLotes.Name = "DGVLotes"
        Me.DGVLotes.Size = New System.Drawing.Size(509, 366)
        Me.DGVLotes.TabIndex = 23
        '
        'gridSaldos
        '
        Me.gridSaldos.AllowUserToDeleteRows = False
        Me.gridSaldos.AllowUserToResizeColumns = False
        Me.gridSaldos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gridSaldos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gridSaldos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSaldos.Enabled = False
        Me.gridSaldos.GridColor = System.Drawing.SystemColors.Highlight
        Me.gridSaldos.Location = New System.Drawing.Point(444, 143)
        Me.gridSaldos.Name = "gridSaldos"
        Me.gridSaldos.ReadOnly = True
        Me.gridSaldos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridSaldos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.gridSaldos.Size = New System.Drawing.Size(57, 362)
        Me.gridSaldos.TabIndex = 135
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1161, 551)
        Me.Controls.Add(Me.gridSaldos)
        Me.Controls.Add(Me.txtOrdemCompra)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnAbreRemetente)
        Me.Controls.Add(Me.btnAbreDepositante)
        Me.Controls.Add(Me.ckbConsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mskCodRetOrigem)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.mskCodSerOrigem)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalSacaria)
        Me.Controls.Add(Me.DGVNotas)
        Me.Controls.Add(Me.DGVSacaria)
        Me.Controls.Add(Me.DGVServicos)
        Me.Controls.Add(Me.DGVLotes)
        Me.Controls.Add(Me.cboRemetente)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.txtTotalSacas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDataEntrada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalSacas)
        Me.Controls.Add(Me.lblTotalPeso)
        Me.Controls.Add(Me.MskPlaca)
        Me.Controls.Add(Me.txtProcedencia)
        Me.Controls.Add(Me.txtSafra)
        Me.Controls.Add(Me.txtMotorista)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtMediaSaca)
        Me.Controls.Add(Me.txtPesoBalanca)
        Me.Controls.Add(Me.txtPesoObrigatorio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.CmdExcluir)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdCadastrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mskFE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSacaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents mskFE As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Public WithEvents CmdExcluir As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdConsultar As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents cmdCadastrar As System.Windows.Forms.Button
    Public WithEvents txtMediaSaca As System.Windows.Forms.TextBox
    Public WithEvents txtPesoBalanca As System.Windows.Forms.TextBox
    Public WithEvents txtPesoObrigatorio As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MskPlaca As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtProcedencia As System.Windows.Forms.TextBox
    Public WithEvents txtSafra As System.Windows.Forms.TextBox
    Public WithEvents txtMotorista As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblTotalSacas As System.Windows.Forms.Label
    Public WithEvents lblTotalPeso As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMIDADEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPUREZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDENTRADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDENTRADAITENSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PILHADataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtTotalSacas As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Friend WithEvents cboRemetente As System.Windows.Forms.ComboBox
    Friend WithEvents DGVLotes As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVServicos As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVSacaria As ARMAZEM.CustomDataGridView
    Friend WithEvents DGVNotas As ARMAZEM.CustomDataGridView
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents lblTotalSacaria As System.Windows.Forms.Label
    Public WithEvents mskCodSerOrigem As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents mskCodRetOrigem As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtConsulLote As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents mskFEConsulta As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnConsulRapida As System.Windows.Forms.Button
    Friend WithEvents ckbConsulta As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbreDepositante As System.Windows.Forms.Button
    Friend WithEvents btnAbreRemetente As System.Windows.Forms.Button
    Public WithEvents txtOrdemCompra As System.Windows.Forms.TextBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gridSaldos As ARMAZEM.CustomDataGridView
#End Region
End Class