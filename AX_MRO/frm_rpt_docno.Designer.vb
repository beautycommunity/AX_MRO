<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_docno
    Inherits k.libary.frmSubWithMenuButton

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
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.pb = New System.Windows.Forms.PictureBox()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ลำดับ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "เอกสารใบจัด"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "เอกสารสั่งสินค้า"
        Me.ColumnHeader3.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "วันที่เอกสาร"
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "รหัสสาขา"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "สาขา"
        Me.ColumnHeader6.Width = 137
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(0, 39)
        Me.lv.Margin = New System.Windows.Forms.Padding(4)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(1112, 427)
        Me.lv.TabIndex = 187
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ลำดับ"
        Me.ColumnHeader7.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "สาขา"
        Me.ColumnHeader8.Width = 76
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "เอกสาร"
        Me.ColumnHeader9.Width = 126
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "วันที่เอกสาร"
        Me.ColumnHeader10.Width = 103
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "เลขที่เอกสาร"
        Me.ColumnHeader11.Width = 472
        '
        'bw
        '
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.Color.White
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pb.Image = Global.AX_MRO.My.Resources.Resources.Spinner_1s_200px
        Me.pb.Location = New System.Drawing.Point(393, 90)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(304, 231)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb.TabIndex = 188
        Me.pb.TabStop = False
        Me.pb.Visible = False
        '
        'frm_rpt_docno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 466)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lv)
        Me.kBtnExportCsvVisible = False
        Me.kBtnExportExcelVisible = False
        Me.kBtnOkVisible = False
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_rpt_docno"
        Me.Text = "รายงานสรุปเอกสารที่ใช้ทำใบจัดไปแล้ว"
        Me.Controls.SetChildIndex(Me.lv, 0)
        Me.Controls.SetChildIndex(Me.pb, 0)
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents pb As PictureBox
End Class
