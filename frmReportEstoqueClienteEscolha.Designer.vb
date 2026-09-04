<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEstoqueClienteEscolha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportEstoqueClienteEscolha))
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.chkNota = New System.Windows.Forms.CheckBox()
        Me.mskData1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboDepositante
        '
        Me.cboDepositante.Location = New System.Drawing.Point(15, 28)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(538, 21)
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
        'btnExibir
        '
        Me.btnExibir.Image = CType(resources.GetObject("btnExibir.Image"), System.Drawing.Image)
        Me.btnExibir.Location = New System.Drawing.Point(484, 77)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(57, 70)
        Me.btnExibir.TabIndex = 73
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'chkNota
        '
        Me.chkNota.AutoSize = True
        Me.chkNota.Location = New System.Drawing.Point(32, 129)
        Me.chkNota.Name = "chkNota"
        Me.chkNota.Size = New System.Drawing.Size(165, 17)
        Me.chkNota.TabIndex = 74
        Me.chkNota.Text = "Mostrar número da nota fiscal"
        Me.chkNota.UseVisualStyleBackColor = True
        '
        'mskData1
        '
        Me.mskData1.Location = New System.Drawing.Point(75, 90)
        Me.mskData1.Mask = "##/##/####"
        Me.mskData1.Name = "mskData1"
        Me.mskData1.Size = New System.Drawing.Size(91, 20)
        Me.mskData1.TabIndex = 75
        '
        'mskData2
        '
        Me.mskData2.Location = New System.Drawing.Point(262, 90)
        Me.mskData2.Mask = "##/##/####"
        Me.mskData2.Name = "mskData2"
        Me.mskData2.Size = New System.Drawing.Size(91, 20)
        Me.mskData2.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(72, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Data inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(259, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Data final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReportEstoqueClienteEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 159)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskData2)
        Me.Controls.Add(Me.mskData1)
        Me.Controls.Add(Me.chkNota)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmReportEstoqueClienteEscolha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione o cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents chkNota As System.Windows.Forms.CheckBox
    Friend WithEvents mskData1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData2 As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
