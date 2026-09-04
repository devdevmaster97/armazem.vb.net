<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoqueRetroativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoqueRetroativo))
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.cboDepositante = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExibir
        '
        Me.btnExibir.Image = CType(resources.GetObject("btnExibir.Image"), System.Drawing.Image)
        Me.btnExibir.Location = New System.Drawing.Point(494, 99)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(57, 70)
        Me.btnExibir.TabIndex = 76
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'cboDepositante
        '
        Me.cboDepositante.Location = New System.Drawing.Point(13, 46)
        Me.cboDepositante.Name = "cboDepositante"
        Me.cboDepositante.Size = New System.Drawing.Size(538, 21)
        Me.cboDepositante.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(10, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Depositante:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEstoqueRetroativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 175)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.cboDepositante)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmEstoqueRetroativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque Retroativo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents cboDepositante As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
End Class
