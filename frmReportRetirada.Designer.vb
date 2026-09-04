<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportRetirada
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
        Me.CRVRetirada = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Retirada = New ARMAZEM.Retirada()
        Me.SuspendLayout()
        '
        'CRVRetirada
        '
        Me.CRVRetirada.ActiveViewIndex = -1
        Me.CRVRetirada.AutoSize = True
        Me.CRVRetirada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVRetirada.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVRetirada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVRetirada.Location = New System.Drawing.Point(0, 0)
        Me.CRVRetirada.Name = "CRVRetirada"
        Me.CRVRetirada.ShowGroupTreeButton = False
        Me.CRVRetirada.ShowParameterPanelButton = False
        Me.CRVRetirada.ShowRefreshButton = False
        Me.CRVRetirada.ShowTextSearchButton = False
        Me.CRVRetirada.Size = New System.Drawing.Size(885, 748)
        Me.CRVRetirada.TabIndex = 0
        Me.CRVRetirada.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Retirada
        '
        Me.Retirada.FileName = "rassdk://C:\WINDOWS\TEMP\temp_72a6fc5e-1ad2-4e82-a541-33b56d985f69.rpt"
        '
        'frmReportRetirada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 748)
        Me.Controls.Add(Me.CRVRetirada)
        Me.Name = "frmReportRetirada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportRetirada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRVRetirada As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Retirada As ARMAZEM.Retirada
End Class
