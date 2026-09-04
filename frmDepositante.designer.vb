<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDepositante
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepositante))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.CmdExcluir = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdCadastrar = New System.Windows.Forms.Button()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtInsc = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.lblcpfcnpj = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldoAnterior = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaidaTranferencia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSaidaDevolucao = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaidaExportacao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNNota = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaidaMercadoInterno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpDataFaturamento = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo = New System.Windows.Forms.ComboBox()
        Me.TableAdapterManager1 = New ARMAZEM.dbDataSet_INDUSTRIALIZAÇAOTableAdapters.TableAdapterManager()
        Me.SuspendLayout()
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.Location = New System.Drawing.Point(124, 12)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 41)
        Me.cmdSalvar.TabIndex = 46
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSalvar, "Salvar")
        Me.cmdSalvar.UseVisualStyleBackColor = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(352, 12)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(57, 41)
        Me.cmdSair.TabIndex = 45
        Me.cmdSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSair, "Fechar")
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(295, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCancelar.TabIndex = 44
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdExcluir
        '
        Me.CmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdExcluir.Enabled = False
        Me.CmdExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExcluir.Image = CType(resources.GetObject("CmdExcluir.Image"), System.Drawing.Image)
        Me.CmdExcluir.Location = New System.Drawing.Point(238, 12)
        Me.CmdExcluir.Name = "CmdExcluir"
        Me.CmdExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdExcluir.Size = New System.Drawing.Size(57, 41)
        Me.CmdExcluir.TabIndex = 43
        Me.CmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CmdExcluir, "Excluir")
        Me.CmdExcluir.UseVisualStyleBackColor = False
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Location = New System.Drawing.Point(181, 12)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultar.Size = New System.Drawing.Size(57, 41)
        Me.cmdConsultar.TabIndex = 40
        Me.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdConsultar, "Consultar")
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Image = CType(resources.GetObject("cmdAlterar.Image"), System.Drawing.Image)
        Me.cmdAlterar.Location = New System.Drawing.Point(67, 12)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 41)
        Me.cmdAlterar.TabIndex = 42
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdAlterar, "Alterar")
        Me.cmdAlterar.UseVisualStyleBackColor = False
        '
        'cmdCadastrar
        '
        Me.cmdCadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCadastrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCadastrar.Image = CType(resources.GetObject("cmdCadastrar.Image"), System.Drawing.Image)
        Me.cmdCadastrar.Location = New System.Drawing.Point(10, 12)
        Me.cmdCadastrar.Name = "cmdCadastrar"
        Me.cmdCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCadastrar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCadastrar.TabIndex = 41
        Me.cmdCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCadastrar, "Incluir")
        Me.cmdCadastrar.UseVisualStyleBackColor = False
        '
        'cboUf
        '
        Me.cboUf.BackColor = System.Drawing.SystemColors.Window
        Me.cboUf.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboUf.Location = New System.Drawing.Point(212, 172)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboUf.Size = New System.Drawing.Size(57, 24)
        Me.cboUf.TabIndex = 28
        '
        'txtInsc
        '
        Me.txtInsc.AcceptsReturn = True
        Me.txtInsc.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsc.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsc.Location = New System.Drawing.Point(444, 172)
        Me.txtInsc.MaxLength = 30
        Me.txtInsc.Name = "txtInsc"
        Me.txtInsc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsc.Size = New System.Drawing.Size(161, 22)
        Me.txtInsc.TabIndex = 30
        '
        'txtCidade
        '
        Me.txtCidade.AcceptsReturn = True
        Me.txtCidade.BackColor = System.Drawing.SystemColors.Window
        Me.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCidade.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCidade.Location = New System.Drawing.Point(12, 172)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCidade.Size = New System.Drawing.Size(193, 22)
        Me.txtCidade.TabIndex = 27
        '
        'txtNum
        '
        Me.txtNum.AcceptsReturn = True
        Me.txtNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum.Location = New System.Drawing.Point(556, 132)
        Me.txtNum.MaxLength = 20
        Me.txtNum.Name = "txtNum"
        Me.txtNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum.Size = New System.Drawing.Size(49, 22)
        Me.txtNum.TabIndex = 26
        '
        'txtEnd
        '
        Me.txtEnd.AcceptsReturn = True
        Me.txtEnd.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnd.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnd.Location = New System.Drawing.Point(12, 132)
        Me.txtEnd.MaxLength = 50
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnd.Size = New System.Drawing.Size(529, 22)
        Me.txtEnd.TabIndex = 25
        '
        'txtCodigo
        '
        Me.txtCodigo.AcceptsReturn = True
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.Location = New System.Drawing.Point(12, 84)
        Me.txtCodigo.MaxLength = 0
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo.Size = New System.Drawing.Size(97, 22)
        Me.txtCodigo.TabIndex = 31
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsReturn = True
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDesc.Location = New System.Drawing.Point(116, 84)
        Me.txtDesc.MaxLength = 50
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesc.Size = New System.Drawing.Size(489, 22)
        Me.txtDesc.TabIndex = 24
        '
        'mskCNPJ
        '
        Me.mskCNPJ.AllowPromptAsInput = False
        Me.mskCNPJ.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCNPJ.Location = New System.Drawing.Point(276, 172)
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(155, 22)
        Me.mskCNPJ.TabIndex = 29
        Me.mskCNPJ.Tag = ""
        Me.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblcpfcnpj
        '
        Me.lblcpfcnpj.AutoSize = True
        Me.lblcpfcnpj.BackColor = System.Drawing.SystemColors.Control
        Me.lblcpfcnpj.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcpfcnpj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcpfcnpj.Location = New System.Drawing.Point(276, 156)
        Me.lblcpfcnpj.Name = "lblcpfcnpj"
        Me.lblcpfcnpj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcpfcnpj.Size = New System.Drawing.Size(34, 13)
        Me.lblcpfcnpj.TabIndex = 39
        Me.lblcpfcnpj.Text = "&CNPJ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(212, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(18, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "&Uf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(444, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "&Inscrição Estadual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "&Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(556, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "&Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "&Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(116, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "&Razão Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "&Código"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.AcceptsReturn = True
        Me.txtSaldoAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaldoAnterior.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaldoAnterior.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAnterior.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(15, 239)
        Me.txtSaldoAnterior.MaxLength = 31
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(130, 22)
        Me.txtSaldoAnterior.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(15, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "&Saldo Anterior"
        '
        'txtSaidaTranferencia
        '
        Me.txtSaidaTranferencia.AcceptsReturn = True
        Me.txtSaidaTranferencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaidaTranferencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaidaTranferencia.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidaTranferencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaidaTranferencia.Location = New System.Drawing.Point(15, 285)
        Me.txtSaidaTranferencia.MaxLength = 35
        Me.txtSaidaTranferencia.Name = "txtSaidaTranferencia"
        Me.txtSaidaTranferencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaidaTranferencia.Size = New System.Drawing.Size(130, 22)
        Me.txtSaidaTranferencia.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(15, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "&Saida Transferência"
        '
        'txtEntrada
        '
        Me.txtEntrada.AcceptsReturn = True
        Me.txtEntrada.BackColor = System.Drawing.SystemColors.Window
        Me.txtEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEntrada.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEntrada.Location = New System.Drawing.Point(165, 239)
        Me.txtEntrada.MaxLength = 32
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEntrada.Size = New System.Drawing.Size(130, 22)
        Me.txtEntrada.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(165, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "&Entrada"
        '
        'txtSaidaDevolucao
        '
        Me.txtSaidaDevolucao.AcceptsReturn = True
        Me.txtSaidaDevolucao.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaidaDevolucao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaidaDevolucao.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidaDevolucao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaidaDevolucao.Location = New System.Drawing.Point(165, 285)
        Me.txtSaidaDevolucao.MaxLength = 36
        Me.txtSaidaDevolucao.Name = "txtSaidaDevolucao"
        Me.txtSaidaDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaidaDevolucao.Size = New System.Drawing.Size(130, 22)
        Me.txtSaidaDevolucao.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(165, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "&Saida Devolução"
        '
        'txtSaidaExportacao
        '
        Me.txtSaidaExportacao.AcceptsReturn = True
        Me.txtSaidaExportacao.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaidaExportacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaidaExportacao.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidaExportacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaidaExportacao.Location = New System.Drawing.Point(326, 239)
        Me.txtSaidaExportacao.MaxLength = 33
        Me.txtSaidaExportacao.Name = "txtSaidaExportacao"
        Me.txtSaidaExportacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaidaExportacao.Size = New System.Drawing.Size(130, 22)
        Me.txtSaidaExportacao.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(326, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "&Saída Exportação"
        '
        'txtNNota
        '
        Me.txtNNota.AcceptsReturn = True
        Me.txtNNota.BackColor = System.Drawing.SystemColors.Window
        Me.txtNNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNNota.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNNota.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNNota.Location = New System.Drawing.Point(326, 285)
        Me.txtNNota.MaxLength = 37
        Me.txtNNota.Name = "txtNNota"
        Me.txtNNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNNota.Size = New System.Drawing.Size(130, 22)
        Me.txtNNota.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(326, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "&Nº da nota"
        '
        'txtSaidaMercadoInterno
        '
        Me.txtSaidaMercadoInterno.AcceptsReturn = True
        Me.txtSaidaMercadoInterno.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaidaMercadoInterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaidaMercadoInterno.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidaMercadoInterno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaidaMercadoInterno.Location = New System.Drawing.Point(475, 239)
        Me.txtSaidaMercadoInterno.MaxLength = 34
        Me.txtSaidaMercadoInterno.Name = "txtSaidaMercadoInterno"
        Me.txtSaidaMercadoInterno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaidaMercadoInterno.Size = New System.Drawing.Size(130, 22)
        Me.txtSaidaMercadoInterno.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(475, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "&Saída Mercado Interno"
        '
        'dtpDataFaturamento
        '
        Me.dtpDataFaturamento.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataFaturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFaturamento.Location = New System.Drawing.Point(478, 287)
        Me.dtpDataFaturamento.Name = "dtpDataFaturamento"
        Me.dtpDataFaturamento.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataFaturamento.TabIndex = 38
        Me.dtpDataFaturamento.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(475, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(108, 18)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "&Data do faturamento"
        '
        'cbo
        '
        Me.cbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo.FormattingEnabled = True
        Me.cbo.Location = New System.Drawing.Point(478, 286)
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(93, 21)
        Me.cbo.TabIndex = 63
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = ARMAZEM.dbDataSet_INDUSTRIALIZAÇAOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDepositante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(617, 324)
        Me.Controls.Add(Me.cbo)
        Me.Controls.Add(Me.dtpDataFaturamento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSaidaMercadoInterno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNNota)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSaidaExportacao)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSaidaDevolucao)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSaidaTranferencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.CmdExcluir)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdCadastrar)
        Me.Controls.Add(Me.cboUf)
        Me.Controls.Add(Me.txtInsc)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.mskCNPJ)
        Me.Controls.Add(Me.lblcpfcnpj)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmDepositante"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cboUf As System.Windows.Forms.ComboBox
    Public WithEvents txtInsc As System.Windows.Forms.TextBox
    Public WithEvents txtCidade As System.Windows.Forms.TextBox
    Public WithEvents txtNum As System.Windows.Forms.TextBox
    Public WithEvents txtEnd As System.Windows.Forms.TextBox
    Public WithEvents txtCodigo As System.Windows.Forms.TextBox
    Public WithEvents txtDesc As System.Windows.Forms.TextBox
    Public WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblcpfcnpj As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents CmdExcluir As System.Windows.Forms.Button
    Public WithEvents cmdConsultar As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents cmdCadastrar As System.Windows.Forms.Button
    Public WithEvents txtSaldoAnterior As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtSaidaTranferencia As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtEntrada As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtSaidaDevolucao As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtSaidaExportacao As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtNNota As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtSaidaMercadoInterno As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFaturamento As System.Windows.Forms.DateTimePicker
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager1 As ARMAZEM.dbDataSet_INDUSTRIALIZAÇAOTableAdapters.TableAdapterManager
#End Region
End Class