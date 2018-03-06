Imports System.Data
Imports System.Data.SqlClient
Imports k.libary

Public Class frm_main_docno

    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox
    Dim frm_docno As New TextBox
    Dim frm_ro As New TextBox
    Dim strconn As String
    Dim sdocno As String
    Dim gwhcode As String


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
        'MyBase.OnLoad(e)

    End Sub

    Public Overrides Sub btnCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnCondition_Click(sender, e)

        Dim frm As New frm_condition(strconn, frm_txt, frm_bool, frm_docno, frm_ro)
        frm.ShowDialog()

        Try
            If frm_bool.Text = "true" Then
                Dim sql As String

                sql = frm_txt.Text

                Dim ds As New DataSet

                ds = cData.getDataSetWithSqlCommand(strconn, sql, 1000000, True)

                txt_ro.Text = frm_ro.Text
                Dim lvitm As New ListViewItem
                lv.Items.Clear()

                gwhcode = ds.Tables(0).Rows(0)("whcode").ToString

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    lvitm = lv.Items.Add(i + 1)
                    Dim idx As Integer = lv.Items.IndexOf(lvitm)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("whcode").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("whname").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("mpcode").ToString)
                    lv.Items(idx).SubItems.Add(ds.Tables(0).Rows(i)("mpname").ToString)
                    lv.Items(idx).SubItems.Add(CDec(ds.Tables(0).Rows(i)("qty")).ToString("#,##0"))
                    'Application.DoEvents()
                    If i Mod 2 = 0 Then
                    Else
                        lv.Items(i).BackColor = Color.FromName("ControlLight")
                    End If
                Next
            End If
            MessageBox.Show("ดึงข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Overrides Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnOK_Click(sender, e)

        Try
            Dim whcode As String
            If lv.Items.Count > 0 Then
                whcode = gwhcode
                fn_update(whcode)
                txt_docno.Text = sdocno


                MessageBox.Show("บันทึกสำเร็จ")
            Else
                MessageBox.Show("ไม่มีข้อมูล")
            End If


        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try
    End Sub

    Sub fn_update(ByVal whcode As String)

        Dim sql, docno, dsql As String
        Dim conn As New SqlConnection(strconn)
        dsql = "exec pp_or_docno"
        Dim da As New SqlDataAdapter(dsql, conn)
        Dim dds As New DataSet

        da.Fill(dds, "tbl")

        docno = dds.Tables("tbl").Rows(0)(0).ToString

        sdocno = docno

        sql = "update [InterfaceBBPRD]..INVENTMAXORDER  set sysdocremark='" & docno & "',sysdocdate =getdate(),FLAG = '1' where docno in (" & frm_docno.Text & "); "
        sql = sql & vbCrLf & " update [InterfaceBBPRD]..INVENTORDER  set sysdocremark='" & docno & "',sysdocdate =getdate(),FLAG = '1'  where docno in (" & frm_docno.Text & "); "

        Dim comm As New SqlCommand()
        comm.CommandText = sql
        comm.CommandTimeout = 1000000

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        comm.Connection = conn

        comm.ExecuteNonQuery()
    End Sub
End Class