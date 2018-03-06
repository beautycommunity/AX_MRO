<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_condition
    Inherits k.libary.frmReportCondition

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
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.rad_date = New System.Windows.Forms.RadioButton
        Me.rad_no_date = New System.Windows.Forms.RadioButton
        Me.dtpf = New k.libary.kDateTimePicker(Me.components)
        Me.dtps = New k.libary.kDateTimePicker(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btn_wh = New System.Windows.Forms.Button
        Me.txt_wh = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txt_no = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(437, 269)
        Me.TabControl1.TabIndex = 192
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rad_date)
        Me.TabPage1.Controls.Add(Me.rad_no_date)
        Me.TabPage1.Controls.Add(Me.dtpf)
        Me.TabPage1.Controls.Add(Me.dtps)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(429, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "วันที่"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rad_date
        '
        Me.rad_date.AutoSize = True
        Me.rad_date.Checked = True
        Me.rad_date.Location = New System.Drawing.Point(37, 216)
        Me.rad_date.Name = "rad_date"
        Me.rad_date.Size = New System.Drawing.Size(97, 20)
        Me.rad_date.TabIndex = 5
        Me.rad_date.TabStop = True
        Me.rad_date.Text = "เลือกช่วงวันที่"
        Me.rad_date.UseVisualStyleBackColor = True
        Me.rad_date.Visible = False
        '
        'rad_no_date
        '
        Me.rad_no_date.AutoSize = True
        Me.rad_no_date.Location = New System.Drawing.Point(181, 214)
        Me.rad_no_date.Name = "rad_no_date"
        Me.rad_no_date.Size = New System.Drawing.Size(112, 20)
        Me.rad_no_date.TabIndex = 4
        Me.rad_no_date.Text = "ไม่เลือกช่วงวันที่"
        Me.rad_no_date.UseVisualStyleBackColor = True
        Me.rad_no_date.Visible = False
        '
        'dtpf
        '
        Me.dtpf.DisplayThai = True
        Me.dtpf.Location = New System.Drawing.Point(129, 71)
        Me.dtpf.Name = "dtpf"
        Me.dtpf.Size = New System.Drawing.Size(183, 23)
        Me.dtpf.TabIndex = 3
        '
        'dtps
        '
        Me.dtps.DisplayThai = True
        Me.dtps.Location = New System.Drawing.Point(129, 29)
        Me.dtps.Name = "dtps"
        Me.dtps.Size = New System.Drawing.Size(183, 23)
        Me.dtps.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ถึง วันที่"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "วันที่"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_wh)
        Me.TabPage2.Controls.Add(Me.txt_wh)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(429, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "สาขา"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_wh
        '
        Me.btn_wh.Location = New System.Drawing.Point(324, 27)
        Me.btn_wh.Name = "btn_wh"
        Me.btn_wh.Size = New System.Drawing.Size(56, 23)
        Me.btn_wh.TabIndex = 2
        Me.btn_wh.Text = "เลือก..."
        Me.btn_wh.UseVisualStyleBackColor = True
        '
        'txt_wh
        '
        Me.txt_wh.Location = New System.Drawing.Point(84, 27)
        Me.txt_wh.Name = "txt_wh"
        Me.txt_wh.Size = New System.Drawing.Size(239, 23)
        Me.txt_wh.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "สาขา"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_no)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(429, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "เอกสาร"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(84, 30)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(317, 23)
        Me.txt_no.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เอกสาร"
        '
        'frm_condition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 308)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_condition"
        Me.Text = "frm_condition"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpf As k.libary.kDateTimePicker
    Friend WithEvents dtps As k.libary.kDateTimePicker
    Friend WithEvents btn_wh As System.Windows.Forms.Button
    Friend WithEvents txt_wh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rad_date As System.Windows.Forms.RadioButton
    Friend WithEvents rad_no_date As System.Windows.Forms.RadioButton
End Class
