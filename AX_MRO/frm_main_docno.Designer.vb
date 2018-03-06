<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main_docno
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_ro = New System.Windows.Forms.TextBox()
        Me.lbl_ro = New System.Windows.Forms.Label()
        Me.txt_docno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lv)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 139)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1296, 578)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(4, 24)
        Me.lv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(1288, 550)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ลำดับ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัสสาขา"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "สาขา"
        Me.ColumnHeader3.Width = 151
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "รหัสสินค้า"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "สินค้า"
        Me.ColumnHeader5.Width = 597
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "จำนวน"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 131
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_ro)
        Me.GroupBox1.Controls.Add(Me.lbl_ro)
        Me.GroupBox1.Controls.Add(Me.txt_docno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1296, 100)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        '
        'txt_ro
        '
        Me.txt_ro.Location = New System.Drawing.Point(167, 62)
        Me.txt_ro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ro.Name = "txt_ro"
        Me.txt_ro.ReadOnly = True
        Me.txt_ro.Size = New System.Drawing.Size(1112, 27)
        Me.txt_ro.TabIndex = 3
        '
        'lbl_ro
        '
        Me.lbl_ro.AutoSize = True
        Me.lbl_ro.Location = New System.Drawing.Point(51, 65)
        Me.lbl_ro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ro.Name = "lbl_ro"
        Me.lbl_ro.Size = New System.Drawing.Size(108, 21)
        Me.lbl_ro.TabIndex = 2
        Me.lbl_ro.Text = "เอกสารที่ใช้ : "
        '
        'txt_docno
        '
        Me.txt_docno.Location = New System.Drawing.Point(167, 24)
        Me.txt_docno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_docno.Name = "txt_docno"
        Me.txt_docno.ReadOnly = True
        Me.txt_docno.Size = New System.Drawing.Size(292, 27)
        Me.txt_docno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขที่เอกสาร : "
        '
        'frm_main_docno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 717)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.kBtnExportCsvVisible = False
        Me.kBtnExportExcelVisible = False
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_main_docno"
        Me.Text = "รวมใบสั่งสินค้า"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_docno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_ro As System.Windows.Forms.Label
    Friend WithEvents txt_ro As System.Windows.Forms.TextBox
End Class
