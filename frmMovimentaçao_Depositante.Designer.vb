<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimentaçao_Depositante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimentaçao_Depositante))
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.dtpDataFaturamento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtN_nota = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSaida_MInterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.txtSaidaExportacao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldoAnterior = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboDepositante
        '
        Me.cboDepositante.FormattingEnabled = True
        Me.cboDepositante.Location = New System.Drawing.Point(15, 28)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(430, 21)
        Me.cboDepositante.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Depositante:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(15, 83)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataInicial.TabIndex = 69
        Me.dtpDataInicial.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(15, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Data inicial:"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(188, 83)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataFinal.TabIndex = 71
        Me.dtpDataFinal.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(188, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Data final:"
        '
        'btnExibir
        '
        Me.btnExibir.Image = CType(resources.GetObject("btnExibir.Image"), System.Drawing.Image)
        Me.btnExibir.Location = New System.Drawing.Point(366, 66)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(57, 70)
        Me.btnExibir.TabIndex = 73
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'dtpDataFaturamento
        '
        Me.dtpDataFaturamento.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataFaturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFaturamento.Location = New System.Drawing.Point(297, 207)
        Me.dtpDataFaturamento.Name = "dtpDataFaturamento"
        Me.dtpDataFaturamento.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataFaturamento.TabIndex = 86
        Me.dtpDataFaturamento.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(297, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "&Data Faturamento"
        '
        'txtN_nota
        '
        Me.txtN_nota.AcceptsReturn = True
        Me.txtN_nota.BackColor = System.Drawing.SystemColors.Window
        Me.txtN_nota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtN_nota.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtN_nota.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN_nota.Location = New System.Drawing.Point(297, 165)
        Me.txtN_nota.MaxLength = 50
        Me.txtN_nota.Name = "txtN_nota"
        Me.txtN_nota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtN_nota.Size = New System.Drawing.Size(126, 22)
        Me.txtN_nota.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(297, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "&Nº Nota Faturamento"
        '
        'txtSaida_MInterno
        '
        Me.txtSaida_MInterno.AcceptsReturn = True
        Me.txtSaida_MInterno.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaida_MInterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaida_MInterno.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaida_MInterno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaida_MInterno.Location = New System.Drawing.Point(154, 207)
        Me.txtSaida_MInterno.MaxLength = 50
        Me.txtSaida_MInterno.Name = "txtSaida_MInterno"
        Me.txtSaida_MInterno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaida_MInterno.Size = New System.Drawing.Size(126, 22)
        Me.txtSaida_MInterno.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(154, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "&Saida Mercado Interno"
        '
        'txtEntrada
        '
        Me.txtEntrada.AcceptsReturn = True
        Me.txtEntrada.BackColor = System.Drawing.SystemColors.Window
        Me.txtEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEntrada.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEntrada.Location = New System.Drawing.Point(12, 207)
        Me.txtEntrada.MaxLength = 50
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(126, 22)
        Me.txtEntrada.TabIndex = 79
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.BackColor = System.Drawing.SystemColors.Control
        Me.lbl20.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl20.Location = New System.Drawing.Point(12, 191)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl20.Size = New System.Drawing.Size(44, 13)
        Me.lbl20.TabIndex = 80
        Me.lbl20.Text = "&Entrada"
        '
        'txtSaidaExportacao
        '
        Me.txtSaidaExportacao.AcceptsReturn = True
        Me.txtSaidaExportacao.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaidaExportacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaidaExportacao.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidaExportacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaidaExportacao.Location = New System.Drawing.Point(154, 166)
        Me.txtSaidaExportacao.MaxLength = 50
        Me.txtSaidaExportacao.Name = "txtSaidaExportacao"
        Me.txtSaidaExportacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaidaExportacao.Size = New System.Drawing.Size(127, 22)
        Me.txtSaidaExportacao.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(154, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "&Saida Exportação"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.AcceptsReturn = True
        Me.txtSaldoAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaldoAnterior.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaldoAnterior.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAnterior.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(12, 165)
        Me.txtSaldoAnterior.MaxLength = 50
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(127, 22)
        Me.txtSaldoAnterior.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "&Saldo anterior"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(350, 242)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(95, 21)
        Me.btnAtualizar.TabIndex = 88
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmIndustrializacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 275)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.dtpDataFaturamento)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtN_nota)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSaida_MInterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.txtSaidaExportacao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmIndustrializacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Industrializacao dos Serviços"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents dtpDataFaturamento As System.Windows.Forms.DateTimePicker
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtN_nota As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtSaida_MInterno As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtEntrada As System.Windows.Forms.TextBox
    Public WithEvents lbl20 As System.Windows.Forms.Label
    Public WithEvents txtSaidaExportacao As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtSaldoAnterior As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
