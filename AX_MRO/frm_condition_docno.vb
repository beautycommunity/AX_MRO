Imports k.libary
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_condition_docno

    Dim strconn As String
    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox


    Public Sub New(ByVal str_conn As String, ByVal txt_sql As TextBox, ByVal txt_bool As TextBox)
        InitializeComponent()

        strconn = str_conn
        frm_txt = txt_sql
        frm_bool = txt_bool
    End Sub

    Public Sub New()
        InitializeComponent()

        strconn = "Data Source=192.168.10.199;Initial Catalog=InterfaceBBPRD;User ID=sa;password=bea@#02"
        frm_txt.Text = ""

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        'MyBase.OnLoad(e)
        frm_txt.Text = ""
        frm_bool.Text = "false"
    End Sub

    Public Overrides Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MyBase.btnSubmit_Click(sender, e)

        Try
            Dim sdoc As String
            If txt_doc.Text = "" Then
                sdoc = " and a.SYSDOCREMARK is not null "
            Else
                sdoc = " and a.SYSDOCREMARK ='" & txt_doc.Text & "'  "
            End If


            Dim sql As String

            sql = "select ROW_NUMBER() over(order by sysdocremark) as rw,whcode,sysdocremark,convert(varchar(10),convert(date,a.sysdocdate),103) as sysdocdate,docno,convert(varchar(10),convert(date,a.sysdocdate),102) as ddate  " & _
                    " from (  " & _
                    " select whcode,a.sysdocremark,a.sysdocdate,b.docno  " & _
                    " from [InterfaceBBPRD]..INVENTMAXORDER a  " & _
                    " left join (select * from PF_SYS_DOC('" & dtps.getDateOnlyForSql & "','" & dtpf.getDateOnlyForSql & "')) b on a.sysdocremark = b.sysdoc  " & _
                    " where FLAG = 1  " & _
                    " and a.sysdocdate between '" & dtps.getDateOnlyForSql & "' and '" & dtpf.getDateOnlyForSql & "'  " & sdoc & _
                    " group by a.sysdocremark,b.DOCNO,whcode,a.sysdocdate  " & _
                    " union all  " & _
                    " select whcode,a.sysdocremark,a.sysdocdate,b.docno  " & _
                    " from [InterfaceBBPRD]..INVENTORDER a  " & _
                    " left join (select * from PF_SYS_DOC('" & dtps.getDateOnlyForSql & "','" & dtpf.getDateOnlyForSql & "')) b on a.sysdocremark = b.sysdoc  " & _
                    " where FLAG = 1  " & _
                    " and a.sysdocdate between '" & dtps.getDateOnlyForSql & "' and '" & dtpf.getDateOnlyForSql & "' " & sdoc & _
                    " group by a.sysdocremark,b.DOCNO,whcode,a.sysdocdate  " & _
                    " ) as a  " & _
                    " group by whcode,sysdocremark,sysdocdate,docno"

            frm_txt.Text = sql
            frm_bool.Text = "true"
            Me.Close()
        Catch ex As Exception
            frm_bool.Text = "false"
            MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
        End Try
    End Sub

End Class