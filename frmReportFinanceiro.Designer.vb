<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFinanceiro
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
        Me.CRVFinanceiro = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.financeiro = New ARMAZEM.financeiro()
        Me.SuspendLayout()
        '
        'CRVFinanceiro
        '
        Me.CRVFinanceiro.ActiveViewIndex = 0
        Me.CRVFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVFinanceiro.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVFinanceiro.Location = New System.Drawing.Point(0, 0)
        Me.CRVFinanceiro.Name = "CRVFinanceiro"
        Me.CRVFinanceiro.ReportSource = Me.financeiro
        Me.CRVFinanceiro.ShowGroupTreeButton = False
        Me.CRVFinanceiro.ShowParameterPanelButton = False
        Me.CRVFinanceiro.Size = New System.Drawing.Size(885, 742)
        Me.CRVFinanceiro.TabIndex = 0
        Me.CRVFinanceiro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'financeiro
        '
        Me.financeiro.FileName = "rassdk://C:\WINDOWS\TEMP\temp_b533d3c1-8dd8-485a-b0b4-4b006d5b57e3.rpt"
        '
        'frmReportFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 742)
        Me.Controls.Add(Me.CRVFinanceiro)
        Me.Name = "frmReportFinanceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportFinanceiro"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVFinanceiro As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents financeiro As ARMAZEM.financeiro
End Class
