<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimentaçao
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.qINDUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbDataSet_INDUSTRIALIZAÇAO = New ARMAZEM.dbDataSet_INDUSTRIALIZAÇAO()
        Me.qINDUSTableAdapter = New ARMAZEM.dbDataSet_INDUSTRIALIZAÇAOTableAdapters.qINDUSTableAdapter()
        CType(Me.qINDUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbDataSet_INDUSTRIALIZAÇAO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_INDUS"
        ReportDataSource1.Value = Me.qINDUSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ARMAZEM.report_INDUSTRIALIZAÇAO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1094, 642)
        Me.ReportViewer1.TabIndex = 0
        '
        'qINDUSBindingSource
        '
        Me.qINDUSBindingSource.DataMember = "qINDUS"
        Me.qINDUSBindingSource.DataSource = Me.dbDataSet_INDUSTRIALIZAÇAO
        '
        'dbDataSet_INDUSTRIALIZAÇAO
        '
        Me.dbDataSet_INDUSTRIALIZAÇAO.DataSetName = "dbDataSet_INDUSTRIALIZAÇAO"
        Me.dbDataSet_INDUSTRIALIZAÇAO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'qINDUSTableAdapter
        '
        Me.qINDUSTableAdapter.ClearBeforeFill = True
        '
        'frmMovimentaçao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 642)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmMovimentaçao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimentaçao"
        CType(Me.qINDUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbDataSet_INDUSTRIALIZAÇAO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents qINDUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbDataSet_INDUSTRIALIZAÇAO As ARMAZEM.dbDataSet_INDUSTRIALIZAÇAO
    Friend WithEvents qINDUSTableAdapter As ARMAZEM.dbDataSet_INDUSTRIALIZAÇAOTableAdapters.qINDUSTableAdapter
End Class
