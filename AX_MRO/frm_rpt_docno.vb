Imports System.Data
Imports System.Data.SqlClient
Imports k.libary

Public Class frm_rpt_docno

    Dim strconn As String
    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox
    Dim ds As New DataSet
    Dim ds1 As New DataSet

    Dim da As New SqlDataAdapter()
    Dim da1 As New SqlDataAdapter()

    Dim sql, sql1 As String

    Public Sub New(ByVal str_conn As String)
        InitializeComponent()

        strconn = str_conn

    End Sub

    Public Sub New()
        InitializeComponent()

        strconn = "Data Source=192.168.10.199;Initial Catalog=InterfaceBBPRD;User ID=sa;password=bea@#02"
        frm_txt.Text = ""

    End Sub
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

    End Sub

    Public Overrides Sub btnCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnCondition_Click(sender, e)
        Dim frm As New frm_condition_docno(strconn, frm_txt, frm_bool)
        frm.ShowDialog()

        Try
            If frm_bool.Text = "true" Then
                Dim sql As String

                sql = frm_txt.Text

                ds.Clear()

                ds = cData.getDataSetWithSqlCommand(strconn, sql, 1000000, True)

                Dim lvitm As New ListViewItem
                lv.Items.Clear()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    lvitm = lv.Items.Add(i + 1)
                    Dim idx As Integer = lv.Items.IndexOf(lvitm)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("whcode").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("SYSDOCREMARK").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("sysdocdate").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("docno").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("ddate").ToString)
                    'Application.DoEvents()
                    If i Mod 2 = 0 Then
                    Else
                        lv.Items(i).BackColor = Color.FromName("ControlLight")
                    End If
                Next


            End If

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub lv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.DoubleClick

        Try

            Dim wsql As String
            Dim whname As String
            Dim whcode As String
            Dim rodoc As String
            Dim sdocno As String
            Dim sdate As String
            Dim fdate As String

            whcode = lv.SelectedItems(0).SubItems(1).Text
            rodoc = lv.SelectedItems(0).SubItems(4).Text
            sdate = lv.SelectedItems(0).SubItems(5).Text
            fdate = lv.SelectedItems(0).SubItems(5).Text
            sdocno = lv.SelectedItems(0).SubItems(2).Text

            wsql = "select  name  as whname  " &
                    " from [AODPRD]..InventLocation  " &
                    "where InventLocationId = '" & whcode & "'"
            Dim wds As New DataSet

            wds = cData.getDataSetWithSqlCommand(strconn, wsql, 1000000, True)
            whname = wds.Tables(0).Rows(0)("whname").ToString



            Dim mlvitem As New ListViewItem


            sql = "select ROW_NUMBER()over(order by a.mpcode) as rw,a.mpcode,a.MPNAME,b.lgcode as location,b.lg_qty as lg_stock,b.wh_qty stock_wh,sum(a.qty) as qty, " &
                " '" & whcode & "' as whcode ,'" & whname & "' as whname, a.SYSDOCREMARK as docno,'pcs.'as packsize,sum(a.qty) as pack_qty " &
                " from (  " &
                " select SYSDOCREMARK,mpcode,MPNAME,whcode,qty  " &
                " from  [InterfaceBBPRD]..INVENTMAXORDER  " &
                " where SYSDOCREMARK ='" & sdocno & "'  " &
                " union all " &
                " select SYSDOCREMARK,mpcode,MPNAME,whcode,qty " &
                " from [InterfaceBBPRD]..INVENTORDER " &
                " where SYSDOCREMARK ='" & sdocno & "' " &
                " ) as a " &
                " left join (select a.whcode,b.whcode as lgcode,a.mpcode ,wh_qty,lg_qty from PF_STOCK_WH('" & sdocno & "') a  " &
                " left join  PF_STOCK_LG('" & sdocno & "') b on a.mpcode = b.mpcode) as b on a.MPCODE= b.mpcode " &
                " where b.lgcode = '9001'  " &
                " group by a.SYSDOCREMARK,a.mpcode,a.MPNAME,a.whcode,b.wh_qty ,b.lgcode,b.lg_qty"

            sql1 = "select ROW_NUMBER()over(order by a.mpcode) as rw,a.mpcode,a.MPNAME,b.lgcode as location,b.lg_qty as lg_stock,b.wh_qty stock_wh,sum(a.qty) as qty, " &
               " '" & whcode & "' as whcode ,'" & whname & "' as whname, a.SYSDOCREMARK as docno,'pcs.'as packsize,sum(a.qty) as pack_qty " &
               " from (  " &
               " select SYSDOCREMARK,mpcode,MPNAME,whcode,qty  " &
               " from  [InterfaceBBPRD]..INVENTMAXORDER  " &
               " where SYSDOCREMARK ='" & sdocno & "'  " &
               " union all " &
               " select SYSDOCREMARK,mpcode,MPNAME,whcode,qty " &
               " from [InterfaceBBPRD]..INVENTORDER " &
               " where SYSDOCREMARK ='" & sdocno & "' " &
               " ) as a " &
               " left join (select a.whcode,b.whcode as lgcode,a.mpcode ,wh_qty,lg_qty from PF_STOCK_WH('" & sdocno & "') a  " &
               " left join  PF_STOCK_LG('" & sdocno & "') b on a.mpcode = b.mpcode) as b on a.MPCODE= b.mpcode " &
               " where b.lgcode <> '9001'  " &
               " group by a.SYSDOCREMARK,a.mpcode,a.MPNAME,a.whcode,b.wh_qty ,b.lgcode,b.lg_qty"

            'Dim conn As New SqlConnection(strconn)

            'da.SelectCommand.CommandText = sql
            'da.SelectCommand.Connection = conn
            'da.SelectCommand.CommandTimeout = 1000000

            'da1.SelectCommand.CommandText = sql1
            'da1.SelectCommand.Connection = conn
            'da1.SelectCommand.CommandTimeout = 1000000

            pb.Location = New Point((Me.Width - pb.Width) \ 2, (Me.Height - pb.Height) \ 2)
            pb.Visible = True
            bw.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub bw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
        ds = cData.getDataSetWithSqlCommand(strconn, Sql, 1000000, True)
        ds1 = cData.getDataSetWithSqlCommand(strconn, Sql1, 1000000, True)

    End Sub

    Private Sub bw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bw.ProgressChanged

    End Sub

    Private Sub bw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        pb.Visible = False

        Dim frm As New frm_rpt_mro("ใบจัดสินค้าคลังสำนักงานใหญ่", ds)
        frm.ShowDialog()

        System.Threading.Thread.Sleep(200)

        Dim frm1 As New frm_rpt_mro("ใบจัดสินค้าคลังลาดกระบัง", ds1)
        frm1.ShowDialog()
    End Sub

    Private Sub frm_rpt_docno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bw.WorkerReportsProgress = True
        CheckForIllegalCrossThreadCalls = False
    End Sub
End Class