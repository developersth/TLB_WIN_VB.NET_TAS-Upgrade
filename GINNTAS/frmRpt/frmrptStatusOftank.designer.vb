<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptStatusOftank
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optStatus2 = New System.Windows.Forms.RadioButton()
        Me.optStatus1 = New System.Windows.Forms.RadioButton()
        Me.MVDate = New System.Windows.Forms.MonthCalendar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(253, 183)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(154, 39)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(253, 143)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(154, 36)
        Me.cmdPready.TabIndex = 6
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optStatus2)
        Me.GroupBox1.Controls.Add(Me.optStatus1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(251, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สถาถัง"
        '
        'optStatus2
        '
        Me.optStatus2.AutoSize = True
        Me.optStatus2.Location = New System.Drawing.Point(29, 46)
        Me.optStatus2.Name = "optStatus2"
        Me.optStatus2.Size = New System.Drawing.Size(65, 24)
        Me.optStatus2.TabIndex = 1
        Me.optStatus2.Text = "ปิดถัง"
        Me.optStatus2.UseVisualStyleBackColor = True
        '
        'optStatus1
        '
        Me.optStatus1.AutoSize = True
        Me.optStatus1.Checked = True
        Me.optStatus1.Location = New System.Drawing.Point(29, 22)
        Me.optStatus1.Name = "optStatus1"
        Me.optStatus1.Size = New System.Drawing.Size(72, 24)
        Me.optStatus1.TabIndex = 0
        Me.optStatus1.TabStop = True
        Me.optStatus1.Text = "เปิดถัง"
        Me.optStatus1.UseVisualStyleBackColor = True
        '
        'MVDate
        '
        Me.MVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MVDate.Location = New System.Drawing.Point(13, 55)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 230)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox1.TabIndex = 8
        '
        'frmrptStatusOftank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 283)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MVDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptStatusOftank"
        Me.Text = "รายงานสถานะภาพของถังประจำวัน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optStatus2 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus1 As System.Windows.Forms.RadioButton
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
