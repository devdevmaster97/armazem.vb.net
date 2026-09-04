<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoqueRetroativoRel
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
        Me.SuspendLayout()
        '
        'CRVEstoque
        '
        Me.CRVEstoque.ActiveViewIndex = -1
        Me.CRVEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVEstoque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVEstoque.Location = New System.Drawing.Point(0, 0)
        Me.CRVEstoque.Name = "CRVEstoque"
        Me.CRVEstoque.ShowGroupTreeButton = False
        Me.CRVEstoque.ShowParameterPanelButton = False
        Me.CRVEstoque.Size = New System.Drawing.Size(1104, 680)
        Me.CRVEstoque.TabIndex = 1
        Me.CRVEstoque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmEstoqueRetroativoRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 680)
        Me.Controls.Add(Me.CRVEstoque)
        Me.Name = "frmEstoqueRetroativoRel"
        Me.Text = "frmEstoqueRetroativoRel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVEstoque As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
