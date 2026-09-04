<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEntradaDiariaEscolha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportEntradaDiariaEscolha))
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.mskData1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboDepositante
        '
        Me.cboDepositante.Location = New System.Drawing.Point(15, 28)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(538, 21)
        Me.cboDepositante.TabIndex = 0
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
        Me.btnExibir.Location = New System.Drawing.Point(496, 64)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(57, 70)
        Me.btnExibir.TabIndex = 2
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'mskData1
        '
        Me.mskData1.Location = New System.Drawing.Point(227, 96)
        Me.mskData1.Mask = "##/##/####"
        Me.mskData1.Name = "mskData1"
        Me.mskData1.Size = New System.Drawing.Size(91, 20)
        Me.mskData1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(224, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Data:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReportEntradaDiariaEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 146)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskData1)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmReportEntradaDiariaEscolha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentação diária por cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents mskData1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
