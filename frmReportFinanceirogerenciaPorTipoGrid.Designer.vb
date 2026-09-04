<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFinanceiroGerenciaPorTipoGrid
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
        Me.CRVFinanceiroGerencia = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.financeirogerencia = New ARMAZEM.financeirogerencia2()
        Me.SuspendLayout()
        '
        'CRVFinanceiroGerencia
        '
        Me.CRVFinanceiroGerencia.ActiveViewIndex = 0
        Me.CRVFinanceiroGerencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVFinanceiroGerencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVFinanceiroGerencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVFinanceiroGerencia.Location = New System.Drawing.Point(0, 0)
        Me.CRVFinanceiroGerencia.Name = "CRVFinanceiroGerencia"
        Me.CRVFinanceiroGerencia.ReportSource = Me.financeirogerencia
        Me.CRVFinanceiroGerencia.ShowGroupTreeButton = False
        Me.CRVFinanceiroGerencia.ShowParameterPanelButton = False
        Me.CRVFinanceiroGerencia.ShowTextSearchButton = False
        Me.CRVFinanceiroGerencia.Size = New System.Drawing.Size(1051, 742)
        Me.CRVFinanceiroGerencia.TabIndex = 0
        Me.CRVFinanceiroGerencia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'financeirogerencia
        '
        Me.financeirogerencia.FileName = "rassdk://C:\Users\EU\AppData\Local\Temp\temp_c508dc11-8c0e-4f85-af99-c597cfb32614" & _
    ".rpt"
        '
        'frmReportFinanceiroGerenciaPorTipoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 742)
        Me.Controls.Add(Me.CRVFinanceiroGerencia)
        Me.Name = "frmReportFinanceiroGerenciaPorTipoGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Financeiro Gerência"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVFinanceiroGerencia As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents financeirogerencia As ARMAZEM.financeirogerencia2
End Class
