<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptMeterDay
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MVDate = New System.Windows.Forms.MonthCalendar()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MVDate
        '
        Me.MVDate.Location = New System.Drawing.Point(10, 52)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 0
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(249, 56)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(110, 33)
        Me.cmdPready.TabIndex = 1
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(249, 95)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(110, 34)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmrptMeterDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 243)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.MVDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptMeterDay"
        Me.Text = "รายงานค่ามิเตอร์ประจำวัน"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
