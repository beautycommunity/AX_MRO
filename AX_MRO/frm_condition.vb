Imports System.Data
Imports System.Data.SqlClient
Imports k.libary

Public Class frm_condition

    Dim strconn As String
    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox
    Dim frm_dsql As New TextBox
    Dim frm_ro As New TextBox

    Public Sub New(ByVal str_conn As String, ByVal txt_sql As TextBox, ByVal txt_bool As TextBox, ByVal txt_dsql As TextBox, ByVal txt_ro As TextBox)
        InitializeComponent()

        strconn = str_conn
        frm_txt = txt_sql
        frm_bool = txt_bool
        frm_dsql = txt_dsql
        frm_ro = txt_ro

    End Sub

    Public Sub New()
        InitializeComponent()

        strconn = "Data Source=192.168.10.199;Initial Catalog=InterfaceBBPRD;User ID=sa;password=bea@#02"
        frm_txt.Text = ""
        
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        'MyBase.OnLoad(e)

    End Sub

    Private Sub rad_no_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_no_date.CheckedChanged
        If rad_no_date.Checked Then
            dtps.Enabled = False
            dtpf.Enabled = False
        Else
            dtps.Enabled = True
            dtpf.Enabled = True
        End If
    End Sub

    Private Sub btn_wh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wh.Click
        Dim frm As New mas_wh.frm_wh(strconn, txt_wh, "BB")

        frm.ShowDialog()
        frm.Close()
    End Sub

    Public Overrides Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnSubmit_Click(sender, e)

        Try
            Dim chk_bl As Boolean = False
            frm_bool.Text = "false"
            Dim whstr, docstr, dtstr, sql, dsql, docno, rdocno, rsql As String

            If rad_date.Checked Then
                dtstr = "and docdate between '" & dtps.getDateOnlyForSql & "' and '" & dtpf.getDateOnlyForSql & "'"
            Else
                dtstr = ""
            End If

            If txt_wh.Text = "" Then
                whstr = ""
                chk_bl = False
            Else

                whstr = " and whcode in (" & txt_wh.Text & ")"

                chk_bl = True

            End If

            If txt_no.Text = "" Then
                docstr = ""
            Else

                Dim docarr() As String
                Dim dcn As String = ""

                docarr = txt_no.Text.Split(",")

                For i As Integer = 0 To docarr.Length - 1
                    If i = 0 Then
                        dcn = "'" & docarr(i) & "'"
                    Else
                        dcn = dcn & ",'" & docarr(i) & "'"
                    End If
                Next

                docstr = "and docno in (" & dcn & ")"
            End If

            If chk_bl Then


                'sql = "select ROW_NUMBER() over(order by mpcode),WHCODE,WHNAME,MPCODE,MPNAME,sum(QTY) as qty " &
                '            " from [InterfaceBBPRD]..INVENTMAXORDER   " &
                '            " where flag = 0 " & dtstr & whstr & docstr &
                '            " group by WHCODE,WHNAME,MPCODE,MPNAME " &
                '            " union all  " &
                '            " select ROW_NUMBER() over(order by a.mpcode),WHCODE,WHNAME,a.MPCODE,MPNAME,sum(QTY) as qty  " &
                '            " from [InterfaceBBPRD]..INVENTORDER  a" &
                '            " left join [InterfaceBBPRD]..INVENTORDER_APP b on a.docno =b.docno and a.mpcode = b.mpcode " &
                '            " where flag = 0  and b.DOCFLAG = 1 " & dtstr & whstr & docstr &
                '            " group by WHCODE,WHNAME,a.MPCODE,MPNAME "

                sql = "Select Case ROW_NUMBER() over(order by mpcode),WHCODE,WHNAME,MPCODE,MPNAME,sum(QTY) As qty " &
                        " From [InterfaceBBPRD]..INVENTMAXORDER   " &
                        " Where flag = 0 " & dtstr & whstr & docstr &
                        " group by WHCODE,WHNAME,MPCODE,MPNAME " &
                        " union all  " &
                        " Select Case* from( " &
                        " select ROW_NUMBER() over(order by a.mpcode) rw,WHCODE,WHNAME,a.MPCODE,MPNAME,sum(QTY) As qty  " &
                        " From [InterfaceBBuat]..INVENTORDER a " &
                        " Left Join [InterfaceBBuat]..INVENTORDER_APP b on a.docno =b.docno And a.mpcode = b.mpcode " &
                        " where flag = 0 and b.DOCFLAG = 1 " &
                        " group by WHCODE, WHNAME, a.MPCODE, MPNAME) a  " &
                        " where MPCODE is not null  " & dtstr & whstr & docstr

                'dsql = "Select docno  " &
                '            " from [InterfaceBBPRD]..INVENTMAXORDER  " &
                '            " where flag = 0 " & dtstr & whstr & docstr &
                '            " group by docno  " &
                '            " union all  " &
                '            " Select docno  " &
                '            " from [InterfaceBBPRD]..INVENTORDER   " &
                '            " where flag = 0 " & dtstr & whstr & docstr &
                '            " group by docno"

                dsql = "Select docno
                         from [InterfaceBBPRD]..INVENTMAXORDER
                         where flag = 0 " & dtstr & whstr & docstr &
                         " group by docno
                         union all
                         select * from (
                         Select a.docno
                         from [InterfaceBBPRD]..INVENTORDER a
                         left join [InterfaceBBPRD]..INVENTORDER_APP b on a.DOCNO = b.DOCNO 
                         where flag = 0 and b.DOCFLAG = 1
                         group by a.docno ) as a
                         where a.docno is not null " & dtstr & whstr & docstr

                'rsql = "Select docno  " & _
                '            " from [InterfaceBBPRD]..INVENTMAXORDER  " & _
                '            " where flag = 0 " & dtstr & whstr & docstr &
                '            " group by docno  " & _
                '            " union all  " & _
                '            " Select docno  " & _
                '            " from [InterfaceBBPRD]..INVENTORDER   " & _
                '            " where flag = 0 " & dtstr & whstr & docstr &
                '            " group by docno"

                rsql = "Select docno
                         from [InterfaceBBPRD]..INVENTMAXORDER
                         where flag = 0 " & dtstr & whstr & docstr &
                         " group by docno
                         union all
                         select * from (
                         Select a.docno
                         from [InterfaceBBPRD]..INVENTORDER a
                         left join [InterfaceBBPRD]..INVENTORDER_APP b on a.DOCNO = b.DOCNO 
                         where flag = 0 and b.DOCFLAG = 1
                         group by a.docno ) as a
                         where a.docno is not null " & dtstr & whstr & docstr


                Dim ds As New DataSet
                ds = cData.getDataSetWithSqlCommand(strconn, dsql, 1000000, True)
                docno = ""
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    If i = 0 Then
                        docno = "'" & ds.Tables(0).Rows(i)("docno").ToString & "'"
                    Else
                        docno = docno & ",'" & ds.Tables(0).Rows(i)("docno").ToString & "'"
                        End If
                Next

                Dim rds As New DataSet
                rds = cData.getDataSetWithSqlCommand(strconn, rsql, 1000000, True)
                rdocno = ""
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    If i = 0 Then
                        rdocno = ds.Tables(0).Rows(i)("docno").ToString
                    Else
                        rdocno = rdocno & "," & ds.Tables(0).Rows(i)("docno").ToString
                        End If
                Next

                frm_txt.Text = sql
                frm_dsql.Text = docno
                frm_ro.Text = rdocno
                frm_bool.Text = "true"
                Me.Close()
            Else
                MessageBox.Show("ต้องทำการเลือกสาขาก่อนครับ")
                frm_bool.Text = "false"
            End If


        Catch ex As Exception
            frm_txt.Text = ""
            frm_bool.Text = "false"
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try

    End Sub


End Class