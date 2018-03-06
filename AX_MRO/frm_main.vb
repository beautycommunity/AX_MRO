Imports System.Data
Imports System.Data.SqlClient
Imports k.libary
Imports System.IO

Public Class frm_main

    Dim frm_txt As New TextBox
    Dim frm_bool As New TextBox
    Dim connstr As String

    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    'MyBase.OnLoad(e)

    'End Sub

    'Public Overrides Sub btnCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    'MyBase.btnCondition_Click(sender, e)

    '    Dim frm As New frm_condition("Data Source=.;Initial Catalog=mona110601;User ID=sa;password=0000", frm_txt, frm_bool)
    '    frm.ShowDialog()

    '    MessageBox.Show(frm_txt.Text)

    '    Try
    '        If frm_bool.Text = "true" Then
    '            Dim sql As String

    '            sql = frm_txt.Text


    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("เกิดข้อผิดพลาด" & vbCrLf & ex.Message)
    '    End Try
    'End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frm As New frm_main_docno(connstr)
        tc.TabPages.Add(frm)
    End Sub

 
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frm As New frm_rpt_docno(connstr)
        tc.TabPages.Add(frm)
    End Sub

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim streamRead As New System.IO.FileStream("connection.xml", System.IO.FileMode.Open)

        Dim Xds As New DataSet

        Xds.ReadXml(streamRead)
        connstr = "Data Source=" & Xds.Tables(0).Rows(0)("SERVER").ToString() & ";Initial Catalog=" & Xds.Tables(0).Rows(0)("DB").ToString() & ";User ID=" & Xds.Tables(0).Rows(0)("ID").ToString() & ";password=" & Xds.Tables(0).Rows(0)("PASS").ToString() & " "


    End Sub

End Class
