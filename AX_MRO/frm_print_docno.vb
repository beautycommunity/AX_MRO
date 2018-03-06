Imports System.Data
Imports System.Data.SqlClient
Imports k.libary

Public Class frm_print_docno

    Dim strconn As String
    Dim sdocno As String
    Dim sdate As String
    Dim fdate As String
    Dim whcode As String
    Dim rodoc As String

    Public Sub New(ByVal str_conn As String, ByVal docno As String, ByVal s_date As String, ByVal e_date As String, ByVal wh_code As String, ByVal ro_doc As String)
        InitializeComponent()

        strconn = str_conn
        sdocno = docno
        sdate = s_date
        fdate = e_date
        whcode = wh_code
        rodoc = ro_doc

    End Sub

    Public Sub New()
        InitializeComponent()

        strconn = "Data Source=5cosmeda.homeunix.com,1434;Initial Catalog=mona110601;User ID=sa;password=0211"
        sdocno = ""
        sdate = "2014.06.26"
        fdate = "2014.06.26"
        whcode = ""

    End Sub

    Public Overrides Sub btnCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnCondition_Click(sender, e)
    End Sub


    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        'MyBase.OnLoad(e)

        Try
            Dim wsql As String
            Dim whname As String

            wsql = "select MYNAMETH as whname from cswarehouse where code = '" & whcode & "'"
            Dim wds As New DataSet

            wds = cData.getDataSetWithSqlCommand(strconn, wsql, 1000000, True)
            whname = wds.Tables(0).Rows(0)("whname").ToString


            Dim mlvitem As New ListViewItem

            lsvReport.Columns.Add("ลำดับ", 70, HorizontalAlignment.Left)
            lsvReport.Columns.Add("รหัสสินค้า", 110, HorizontalAlignment.Left)
            lsvReport.Columns.Add("เลขที่เอกสาร/สินค้า", 200, HorizontalAlignment.Left)
            lsvReport.Columns.Add("รหัสสาขา/location", 90, HorizontalAlignment.Left)
            lsvReport.Columns.Add("สาขา/lg stock", 60, HorizontalAlignment.Right)
            lsvReport.Columns.Add("wh stock", 60, HorizontalAlignment.Right)
            lsvReport.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)

            mlvitem = lsvReport.Items.Add("")
            Dim idx As Integer = lsvReport.Items.IndexOf(mlvitem)
            lsvReport.Items(idx).SubItems.Add("")
            lsvReport.Items(idx).SubItems.Add(rodoc)
            lsvReport.Items(idx).SubItems.Add(whcode)
            lsvReport.Items(idx).SubItems.Add(whname)
            lsvReport.Items(idx).SubItems.Add("")
            lsvReport.Items(idx).SubItems.Add("")
            
            Dim sql As String


            sql = " select b.productcode,b.productname, lg_location ,isnull(f.balqty,0) as lg_stock," & _
                    " isnull(g.qty,0) as 'wh_stock',convert(int,isnull(sum(quantity),0)) as qty,'' as 'จัดได้' " & _
                    " from csstkmovereq2 a  left join csstkmovereq2sub b on a.DOCNO = b.DOCNO " & _
                    " left join csproduct d on b.PRODUCTCODE = d.code " & _
                    " left join PF_BM_stk_all('" & sdate & "') f on b.PRODUCTCODE= f.mpcode" & _
                    " left join PF_BB_STK_DATE ('" & whcode & "','" & sdate & "') g on b.WAREHOUSE = g.whcode and b.PRODUCTCODE = g.whcode " & _
                    " where sysdocremark = '" & sdocno & "'" & _
                    " group by sysdocremark,b.productcode,b.productname,location,lg_location,f.balqty, g.qty"

            Dim ds As New DataSet

            ds = cData.getDataSetWithSqlCommand(strconn, sql, 1000000, True)

            ''lsvReport.addDataWithDataset(ds, True)

            For m As Integer = 0 To ds.Tables(0).Rows.Count - 1
                mlvitem = lsvReport.Items.Add(m + 1)
                Dim idx1 As Integer = lsvReport.Items.IndexOf(mlvitem)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("productcode").ToString)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("productname").ToString)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("lg_location").ToString)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("lg_stock").ToString)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("wh_stock").ToString)
                lsvReport.Items(idx1).SubItems.Add(ds.Tables(0).Rows(m)("qty").ToString)

            Next


            'lsvReport.Columns(0).Width = -2
            'lsvReport.Columns(2).Width = 250



        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try
    End Sub


End Class