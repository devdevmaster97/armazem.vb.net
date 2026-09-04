<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFinanceiroPorMes
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
        Me.CRVFinanceiroGerenciaPorMes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.financeirogerencia = New ARMAZEM.financeirogerencia()
        Me.SuspendLayout()
        '
        'CRVFinanceiroGerenciaPorMes
        '
        Me.CRVFinanceiroGerenciaPorMes.ActiveViewIndex = 0
        Me.CRVFinanceiroGerenciaPorMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVFinanceiroGerenciaPorMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVFinanceiroGerenciaPorMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVFinanceiroGerenciaPorMes.Location = New System.Drawing.Point(0, 0)
        Me.CRVFinanceiroGerenciaPorMes.Name = "CRVFinanceiroGerenciaPorMes"
        Me.CRVFinanceiroGerenciaPorMes.ReportSource = Me.financeirogerencia
        Me.CRVFinanceiroGerenciaPorMes.ShowGotoPageButton = False
        Me.CRVFinanceiroGerenciaPorMes.ShowGroupTreeButton = False
        Me.CRVFinanceiroGerenciaPorMes.ShowRefreshButton = False
        Me.CRVFinanceiroGerenciaPorMes.ShowTextSearchButton = False
        Me.CRVFinanceiroGerenciaPorMes.Size = New System.Drawing.Size(1051, 742)
        Me.CRVFinanceiroGerenciaPorMes.TabIndex = 0
        Me.CRVFinanceiroGerenciaPorMes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'financeirogerencia
        '
        Me.financeirogerencia.FileName = "rassdk://C:\WINDOWS\TEMP\temp_c17472f8-dd2e-4722-bc7f-bb42dca41e23.rpt"
        '
        'frmReportFinanceiroPorMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 742)
        Me.Controls.Add(Me.CRVFinanceiroGerenciaPorMes)
        Me.Name = "frmReportFinanceiroPorMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Financeiro Gerência"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVFinanceiroGerenciaPorMes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents financeirogerencia As ARMAZEM.financeirogerencia
End Class
