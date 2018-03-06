Imports Microsoft.Reporting.WinForms

Public Class frm_rpt_mro

    Dim title As String
    Dim ds As New DataSet

    Sub New(ByVal _title As String, ByVal _ds As DataSet)

        InitializeComponent()

        title = _title
        ds = _ds


    End Sub
    Private Sub frm_rpt_mro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable

        dt = ds.Tables(0)

        Dim rds As New ReportDataSource()
        rds.Name = "MyDs"
        rds.Value = dt

        Dim newPageSettings As New System.Drawing.Printing.PageSettings()
        newPageSettings.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)


        Dim rp As New ReportParameter("parTitle", title)
        rv.LocalReport.DataSources.Clear()
        rv.LocalReport.DataSources.Add(rds)
        rv.LocalReport.SetParameters(rp)

        Me.rv.RefreshReport()

        rv.SetDisplayMode(DisplayMode.PrintLayout)
        rv.ZoomMode = ZoomMode.PageWidth
        rv.SetPageSettings(newPageSettings)

    End Sub
End Class