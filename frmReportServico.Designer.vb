<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportServico
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
        Me.CRVServico = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Servico = New ARMAZEM.Servico()
        Me.SuspendLayout()
        '
        'CRVServico
        '
        Me.CRVServico.ActiveViewIndex = -1
        Me.CRVServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CRVServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVServico.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVServico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVServico.Location = New System.Drawing.Point(0, 0)
        Me.CRVServico.Name = "CRVServico"
        Me.CRVServico.ShowGroupTreeButton = False
        Me.CRVServico.ShowParameterPanelButton = False
        Me.CRVServico.ShowRefreshButton = False
        Me.CRVServico.Size = New System.Drawing.Size(885, 748)
        Me.CRVServico.TabIndex = 0
        Me.CRVServico.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 748)
        Me.Controls.Add(Me.CRVServico)
        Me.Name = "frmReportServico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportServico"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVServico As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Servico As ARMAZEM.Servico
End Class
