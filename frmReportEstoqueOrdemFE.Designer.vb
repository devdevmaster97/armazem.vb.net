<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEstoqueOrdemFE
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
        Me.CRVEstoque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Estoque = New ARMAZEM.Estoque()
        Me.SuspendLayout()
        '
        'CRVEstoque
        '
        Me.CRVEstoque.ActiveViewIndex = 0
        Me.CRVEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVEstoque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVEstoque.Location = New System.Drawing.Point(0, 1)
        Me.CRVEstoque.Name = "CRVEstoque"
        Me.CRVEstoque.ReportSource = Me.Estoque
        Me.CRVEstoque.ShowGroupTreeButton = False
        Me.CRVEstoque.ShowParameterPanelButton = False
        Me.CRVEstoque.Size = New System.Drawing.Size(1104, 680)
        Me.CRVEstoque.TabIndex = 0
        Me.CRVEstoque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Estoque
        '
        Me.Estoque.FileName = "rassdk://C:\WINDOWS\TEMP\temp_8a3188e2-6f0d-48c3-a1a2-18a2895fe8ca.rpt"
        '
        'frmReportEstoque
        '
        Me.ClientSize = New System.Drawing.Size(1104, 681)
        Me.Controls.Add(Me.CRVEstoque)
        Me.Name = "frmReportEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque por ordem de FE"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FichaEntrada1 As ARMAZEM.FichaEntrada
    Friend WithEvents financeiro1 As ARMAZEM.financeiro
    Friend WithEvents CRVEstoque As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Estoque As ARMAZEM.Estoque
End Class
