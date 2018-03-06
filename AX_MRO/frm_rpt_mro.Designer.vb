<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_mro
    Inherits System.Windows.Forms.Form

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
        Me.rv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rv
        '
        Me.rv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rv.LocalReport.ReportEmbeddedResource = "AX_MRO.rpt_MRO.rdlc"
        Me.rv.Location = New System.Drawing.Point(0, 0)
        Me.rv.Name = "rv"
        Me.rv.ServerReport.BearerToken = Nothing
        Me.rv.Size = New System.Drawing.Size(1230, 662)
        Me.rv.TabIndex = 0
        '
        'frm_rpt_mro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 662)
        Me.Controls.Add(Me.rv)
        Me.Name = "frm_rpt_mro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_rpt_mro"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv As Microsoft.Reporting.WinForms.ReportViewer
End Class
