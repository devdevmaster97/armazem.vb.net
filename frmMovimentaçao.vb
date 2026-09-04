Imports Microsoft.Reporting.WinForms
Public Class frmMovimentaçao
    Public Property NOME_DEPO As String
    Public Property DATA_INICIAL As String
    Public Property DATA_FINAL As String

    Public Sub New(ByVal XNOME_DEPO As String, ByVal XDATA_INICIAL As Date, ByVal XDATA_FINAL As Date)

        InitializeComponent()
        NOME_DEPO = XNOME_DEPO
        DATA_INICIAL = XDATA_INICIAL
        DATA_FINAL = XDATA_FINAL

    End Sub

    Private Sub frmMovimentaçao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.qINDUSTableAdapter.FillByDEPOSITANTE(Me.dbDataSet_INDUSTRIALIZAÇAO.qINDUS, NOME_DEPO, DATA_INICIAL, DATA_FINAL)


        'PARAMETROS ******************************************************************************************************

        Dim paramdatainicial As New ReportParameter("P_DT_INI", DATA_INICIAL)

        Dim paramdatafinal As New ReportParameter("P_DT_FIN", DATA_FINAL)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {paramdatainicial})

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {paramdatafinal})

        'PARAMETROS ******************************************************************************************************


        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.ZoomMode.Percent = 100)
        ' Me.ReportViewer1.SetPageSettings(



        Me.ReportViewer1.RefreshReport()

    End Sub
End Class