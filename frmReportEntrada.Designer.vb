<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEntrada
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
        Me.CRVEntrada = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FichaEntrada = New ARMAZEM.FichaEntrada()
        Me.SuspendLayout()
        '
        'CRVEntrada
        '
        Me.CRVEntrada.ActiveViewIndex = -1
        Me.CRVEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVEntrada.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVEntrada.Location = New System.Drawing.Point(0, 0)
        Me.CRVEntrada.Name = "CRVEntrada"
        Me.CRVEntrada.ShowGotoPageButton = False
        Me.CRVEntrada.ShowGroupTreeButton = False
        Me.CRVEntrada.ShowPageNavigateButtons = False
        Me.CRVEntrada.ShowParameterPanelButton = False
        Me.CRVEntrada.ShowRefreshButton = False
        Me.CRVEntrada.ShowTextSearchButton = False
        Me.CRVEntrada.Size = New System.Drawing.Size(885, 748)
        Me.CRVEntrada.TabIndex = 0
        Me.CRVEntrada.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 748)
        Me.Controls.Add(Me.CRVEntrada)
        Me.Name = "frmReportEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportEntrada"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVEntrada As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FichaEntrada As ARMAZEM.FichaEntrada
End Class
