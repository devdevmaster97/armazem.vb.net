<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceiroGerenciaPorTipo
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
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdCarrega = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(143, 36)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataFinal.TabIndex = 118
        Me.dtpDataFinal.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(143, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "&Data Final:"
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.AccessibleDescription = "F:\armazem gs\financeiro vb.net\dados\db.mdb"
        Me.dtpDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(34, 36)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(103, 20)
        Me.dtpDataInicial.TabIndex = 117
        Me.dtpDataInicial.Value = New Date(2011, 4, 28, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(34, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "&Data Inicial:"
        '
        'cmdCarrega
        '
        Me.cmdCarrega.Location = New System.Drawing.Point(377, 30)
        Me.cmdCarrega.Name = "cmdCarrega"
        Me.cmdCarrega.Size = New System.Drawing.Size(39, 26)
        Me.cmdCarrega.TabIndex = 122
        Me.cmdCarrega.Text = "OK"
        Me.cmdCarrega.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(248, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Situação:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSituacao
        '
        Me.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSituacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Location = New System.Drawing.Point(251, 35)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(118, 21)
        Me.cboSituacao.TabIndex = 121
        '
        'frmFinanceiroGerenciaPorTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 95)
        Me.Controls.Add(Me.cmdCarrega)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSituacao)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.Label10)
        Me.Name = "frmFinanceiroGerenciaPorTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financeiro por Tipo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdCarrega As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSituacao As System.Windows.Forms.ComboBox
End Class
