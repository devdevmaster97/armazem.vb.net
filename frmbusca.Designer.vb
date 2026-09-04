<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbusca
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPalavraChave = New System.Windows.Forms.TextBox()
        Me.msk = New System.Windows.Forms.MaskedTextBox()
        Me.txtSomenteNumeros = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.chkConsultaLote = New System.Windows.Forms.CheckBox()
        Me.lbltex = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPalavraChave
        '
        Me.txtPalavraChave.Location = New System.Drawing.Point(3, 21)
        Me.txtPalavraChave.Name = "txtPalavraChave"
        Me.txtPalavraChave.Size = New System.Drawing.Size(885, 20)
        Me.txtPalavraChave.TabIndex = 0
        '
        'msk
        '
        Me.msk.Location = New System.Drawing.Point(3, 21)
        Me.msk.Mask = "##/##/####"
        Me.msk.Name = "msk"
        Me.msk.Size = New System.Drawing.Size(68, 20)
        Me.msk.TabIndex = 2
        Me.msk.Visible = False
        '
        'txtSomenteNumeros
        '
        Me.txtSomenteNumeros.Location = New System.Drawing.Point(3, 21)
        Me.txtSomenteNumeros.Name = "txtSomenteNumeros"
        Me.txtSomenteNumeros.Size = New System.Drawing.Size(885, 20)
        Me.txtSomenteNumeros.TabIndex = 1
        Me.txtSomenteNumeros.Visible = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.SystemColors.Highlight
        Me.DGV.Location = New System.Drawing.Point(3, 47)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(885, 560)
        Me.DGV.StandardTab = True
        Me.DGV.TabIndex = 4
        '
        'chkConsultaLote
        '
        Me.chkConsultaLote.AutoSize = True
        Me.chkConsultaLote.Location = New System.Drawing.Point(180, 3)
        Me.chkConsultaLote.Name = "chkConsultaLote"
        Me.chkConsultaLote.Size = New System.Drawing.Size(110, 17)
        Me.chkConsultaLote.TabIndex = 3
        Me.chkConsultaLote.Text = "Consulta Por Lote"
        Me.chkConsultaLote.UseVisualStyleBackColor = True
        '
        'lbltex
        '
        Me.lbltex.AutoSize = True
        Me.lbltex.Location = New System.Drawing.Point(0, 5)
        Me.lbltex.Name = "lbltex"
        Me.lbltex.Size = New System.Drawing.Size(0, 13)
        Me.lbltex.TabIndex = 5
        '
        'frmbusca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 610)
        Me.Controls.Add(Me.lbltex)
        Me.Controls.Add(Me.chkConsultaLote)
        Me.Controls.Add(Me.msk)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtPalavraChave)
        Me.Controls.Add(Me.txtSomenteNumeros)
        Me.Name = "frmbusca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPalavraChave As System.Windows.Forms.TextBox
    Friend WithEvents msk As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSomenteNumeros As System.Windows.Forms.TextBox
    Public WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents chkConsultaLote As System.Windows.Forms.CheckBox
    Friend WithEvents lbltex As System.Windows.Forms.Label

End Class
