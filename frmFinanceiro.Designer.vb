<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanceiro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRelatorio = New System.Windows.Forms.Button()
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.lblTotalSacas = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCarrega = New System.Windows.Forms.Button()
        Me.rbDetalhado = New System.Windows.Forms.RadioButton()
        Me.rbResumido = New System.Windows.Forms.RadioButton()
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoCobrança = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkFe = New System.Windows.Forms.CheckBox()
        Me.chkSe = New System.Windows.Forms.CheckBox()
        Me.chkOr = New System.Windows.Forms.CheckBox()
        Me.cboOperacao = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Registros = New System.Windows.Forms.Label()
        Me.DGVServicos = New ARMAZEM.CustomDataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalDias = New System.Windows.Forms.Label()
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSituacao
        '
        Me.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Location = New System.Drawing.Point(1100, 24)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(76, 21)
        Me.cboSituacao.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(1097, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Situação:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(3, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Serviços"
        '
        'cmdRelatorio
        '
        Me.cmdRelatorio.Location = New System.Drawing.Point(1100, 512)
        Me.cmdRelatorio.Name = "cmdRelatorio"
        Me.cmdRelatorio.Size = New System.Drawing.Size(60, 30)
        Me.cmdRelatorio.TabIndex = 10
        Me.cmdRelatorio.Text = "Relatório"
        Me.cmdRelatorio.UseVisualStyleBackColor = True
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.Location = New System.Drawing.Point(63, 4)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 41)
        Me.cmdSalvar.TabIndex = 11
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalvar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.Enabled = False
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Image = CType(resources.GetObject("cmdAlterar.Image"), System.Drawing.Image)
        Me.cmdAlterar.Location = New System.Drawing.Point(6, 4)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 41)
        Me.cmdAlterar.TabIndex = 10
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'lblTotalSacas
        '
        Me.lblTotalSacas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalSacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSacas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSacas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSacas.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalSacas.Location = New System.Drawing.Point(544, 514)
        Me.lblTotalSacas.Name = "lblTotalSacas"
        Me.lblTotalSacas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSacas.Size = New System.Drawing.Size(87, 25)
        Me.lblTotalSacas.TabIndex = 110
        Me.lblTotalSacas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblTotal.Location = New System.Drawing.Point(699, 514)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(93, 25)
        Me.lblTotal.TabIndex = 111
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(120, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(915, 25)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataInicial.TabIndex = 3
        Me.dtpDataInicial.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(917, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "&Data Inicial:"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(1006, 25)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataFinal.TabIndex = 4
        Me.dtpDataFinal.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(1003, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "&Data Final:"
        '
        'cmdCarrega
        '
        Me.cmdCarrega.Location = New System.Drawing.Point(1181, 22)
        Me.cmdCarrega.Name = "cmdCarrega"
        Me.cmdCarrega.Size = New System.Drawing.Size(55, 24)
        Me.cmdCarrega.TabIndex = 6
        Me.cmdCarrega.Text = "OK"
        Me.cmdCarrega.UseVisualStyleBackColor = True
        '
        'rbDetalhado
        '
        Me.rbDetalhado.AutoSize = True
        Me.rbDetalhado.Location = New System.Drawing.Point(1166, 525)
        Me.rbDetalhado.Name = "rbDetalhado"
        Me.rbDetalhado.Size = New System.Drawing.Size(74, 17)
        Me.rbDetalhado.TabIndex = 9
        Me.rbDetalhado.Text = "Detalhado"
        Me.rbDetalhado.UseVisualStyleBackColor = True
        '
        'rbResumido
        '
        Me.rbResumido.AutoSize = True
        Me.rbResumido.Checked = True
        Me.rbResumido.Location = New System.Drawing.Point(1166, 509)
        Me.rbResumido.Name = "rbResumido"
        Me.rbResumido.Size = New System.Drawing.Size(72, 17)
        Me.rbResumido.TabIndex = 8
        Me.rbResumido.TabStop = True
        Me.rbResumido.Text = "Resumido"
        Me.rbResumido.UseVisualStyleBackColor = True
        '
        'cboDepositante
        '
        Me.cboDepositante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepositante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepositante.FormattingEnabled = True
        Me.cboDepositante.Location = New System.Drawing.Point(291, 24)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(311, 21)
        Me.cboDepositante.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(291, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Depositante:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTipoCobrança
        '
        Me.cboTipoCobrança.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoCobrança.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCobrança.FormattingEnabled = True
        Me.cboTipoCobrança.Location = New System.Drawing.Point(183, 24)
        Me.cboTipoCobrança.Name = "cboTipoCobrança"
        Me.cboTipoCobrança.Size = New System.Drawing.Size(102, 21)
        Me.cboTipoCobrança.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(180, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Tipo cobrança"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(470, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Total sacas:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(637, 526)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Total valor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFe
        '
        Me.chkFe.AutoSize = True
        Me.chkFe.Checked = True
        Me.chkFe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFe.Location = New System.Drawing.Point(868, 59)
        Me.chkFe.Name = "chkFe"
        Me.chkFe.Size = New System.Drawing.Size(39, 17)
        Me.chkFe.TabIndex = 126
        Me.chkFe.Text = "FE"
        Me.chkFe.UseVisualStyleBackColor = True
        '
        'chkSe
        '
        Me.chkSe.AutoSize = True
        Me.chkSe.Checked = True
        Me.chkSe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSe.Location = New System.Drawing.Point(918, 59)
        Me.chkSe.Name = "chkSe"
        Me.chkSe.Size = New System.Drawing.Size(40, 17)
        Me.chkSe.TabIndex = 127
        Me.chkSe.Text = "SE"
        Me.chkSe.UseVisualStyleBackColor = True
        '
        'chkOr
        '
        Me.chkOr.AutoSize = True
        Me.chkOr.Checked = True
        Me.chkOr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOr.Location = New System.Drawing.Point(968, 59)
        Me.chkOr.Name = "chkOr"
        Me.chkOr.Size = New System.Drawing.Size(42, 17)
        Me.chkOr.TabIndex = 128
        Me.chkOr.Text = "OR"
        Me.chkOr.UseVisualStyleBackColor = True
        '
        'cboOperacao
        '
        Me.cboOperacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOperacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperacao.FormattingEnabled = True
        Me.cboOperacao.Location = New System.Drawing.Point(608, 24)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(299, 21)
        Me.cboOperacao.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(605, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Operação"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRegistros
        '
        Me.lblRegistros.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegistros.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegistros.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Navy
        Me.lblRegistros.Location = New System.Drawing.Point(389, 514)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegistros.Size = New System.Drawing.Size(75, 25)
        Me.lblRegistros.TabIndex = 131
        Me.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Registros
        '
        Me.Registros.BackColor = System.Drawing.SystemColors.Control
        Me.Registros.Cursor = System.Windows.Forms.Cursors.Default
        Me.Registros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Registros.Location = New System.Drawing.Point(328, 525)
        Me.Registros.Name = "Registros"
        Me.Registros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Registros.Size = New System.Drawing.Size(55, 13)
        Me.Registros.TabIndex = 132
        Me.Registros.Text = "Registros:"
        Me.Registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGVServicos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVServicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVServicos.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGVServicos.Location = New System.Drawing.Point(5, 92)
        Me.DGVServicos.Name = "DGVServicos"
        Me.DGVServicos.Size = New System.Drawing.Size(1230, 397)
        Me.DGVServicos.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(803, 525)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(35, 12)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Dias:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalDias
        '
        Me.lblTotalDias.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotalDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDias.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalDias.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDias.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalDias.Location = New System.Drawing.Point(838, 514)
        Me.lblTotalDias.Name = "lblTotalDias"
        Me.lblTotalDias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalDias.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalDias.TabIndex = 134
        Me.lblTotalDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 544)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotalDias)
        Me.Controls.Add(Me.Registros)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.cboOperacao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkOr)
        Me.Controls.Add(Me.chkSe)
        Me.Controls.Add(Me.chkFe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVServicos)
        Me.Controls.Add(Me.cboTipoCobrança)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbResumido)
        Me.Controls.Add(Me.rbDetalhado)
        Me.Controls.Add(Me.cmdCarrega)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblTotalSacas)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdRelatorio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSituacao)
        Me.Name = "frmFinanceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FINANCEIRO"
        CType(Me.DGVServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdRelatorio As System.Windows.Forms.Button
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents lblTotalSacas As System.Windows.Forms.Label
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCarrega As System.Windows.Forms.Button
    Friend WithEvents rbDetalhado As System.Windows.Forms.RadioButton
    Friend WithEvents rbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCobrança As System.Windows.Forms.ComboBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGVServicos As ARMAZEM.CustomDataGridView
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkFe As System.Windows.Forms.CheckBox
    Friend WithEvents chkSe As System.Windows.Forms.CheckBox
    Friend WithEvents chkOr As System.Windows.Forms.CheckBox
    Friend WithEvents cboOperacao As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents cboSituacao As System.Windows.Forms.ComboBox
    Public WithEvents lblRegistros As System.Windows.Forms.Label
    Public WithEvents Registros As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents lblTotalDias As System.Windows.Forms.Label
End Class
