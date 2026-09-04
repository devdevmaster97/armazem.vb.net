<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEstoqueRetroativo
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
        Me.EstoqueRetroativo1 = New ARMAZEM.EstoqueRetroativo()
        Me.SuspendLayout()
        '
        'CRVEstoque
        '
        Me.CRVEstoque.ActiveViewIndex = 0
        Me.CRVEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVEstoque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVEstoque.Location = New System.Drawing.Point(0, 1)
        Me.CRVEstoque.Name = "CRVEstoque"
        Me.CRVEstoque.ReportSource = Me.EstoqueRetroativo1
        Me.CRVEstoque.ShowGroupTreeButton = False
        Me.CRVEstoque.ShowParameterPanelButton = False
        Me.CRVEstoque.Size = New System.Drawing.Size(1104, 680)
        Me.CRVEstoque.TabIndex = 0
        Me.CRVEstoque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'EstoqueRetroativo1
        '
        Me.EstoqueRetroativo1.FileName = "rassdk://C:\Users\w\AppData\Local\Temp\temp_65e5ca44-f7bd-42a8-8b2c-f3bf74a56dab." & _
    "rpt"
        '
        'frmReportEstoqueRetroativo
        '
        Me.ClientSize = New System.Drawing.Size(1104, 681)
        Me.Controls.Add(Me.CRVEstoque)
        Me.Name = "frmReportEstoqueRetroativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque retroativo por ordem de Lote"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FichaEntrada1 As ARMAZEM.FichaEntrada
    Friend WithEvents financeiro1 As ARMAZEM.financeiro
    Friend WithEvents CRVEstoque As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EstoqueRetroativo1 As ARMAZEM.EstoqueRetroativo
End Class
