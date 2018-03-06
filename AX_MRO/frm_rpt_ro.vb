Imports System.Data
Imports System.Data.SqlClient
Imports k.libary

Public Class frm_rpt_ro

    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox
    Dim frm_docno As New TextBox
    Dim frm_ro As New TextBox
    Dim strconn As String


    Public Sub New(ByVal str_conn As String)
        InitializeComponent()

        strconn = str_conn

    End Sub

    Public Sub New()
        InitializeComponent()

        strconn = "Data Source=.;Initial Catalog=mona110601;User ID=sa;password=0000"
        frm_txt.Text = ""

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        'MyBase.OnLoad(e)

    End Sub

    Public Overrides Sub btnCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnCondition_Click(sender, e)

        Dim frm As New frm_condition("Data Source=5cosmeda.homeunix.com,1434;Initial Catalog=mona110601;User ID=sa;password=0211", frm_txt, frm_bool, frm_docno, frm_ro)
        frm.ShowDialog()

        'MessageBox.Show(frm_txt.Text)

        Try
            If frm_bool.Text = "true" Then
                Dim sql As String

                sql = frm_txt.Text

                Dim ds As New DataSet

                ds = cData.getDataSetWithSqlCommand(strconn, sql, 1000000, True)


                lsvReport.addDataWithDataset(ds, True, True)

            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Overrides Sub btnPrintPaper_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnPrintPaper_Click(sender, e)

        'fn_update()
        
    End Sub

    Sub fn_update()

        Dim sql, docno, dsql As String
        Dim conn As New SqlConnection(strconn)
        dsql = "exec pp_or_docno"
        Dim da As New SqlDataAdapter(dsql, conn)
        Dim dds As New DataSet

        da.Fill(dds, "tbl")

        docno = dds.Tables("tbl").Rows(0)(0)

        sql = "update csstkmovereq2 set sysdocremark='" & docno & "' where docno in (" & frm_docno.Text & ")"

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
