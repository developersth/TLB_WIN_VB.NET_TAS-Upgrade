<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptProductOfMeter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rType2 = New System.Windows.Forms.RadioButton()
        Me.rType1 = New System.Windows.Forms.RadioButton()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MVDate
        '
        Me.MVDate.Location = New System.Drawing.Point(16, 73)
        Me.MVDate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rType2)
        Me.GroupBox1.Controls.Add(Me.rType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(333, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(219, 95)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Loading"
        '
        'rType2
        '
        Me.rType2.AutoSize = True
        Me.rType2.Location = New System.Drawing.Point(16, 59)
        Me.rType2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rType2.Name = "rType2"
        Me.rType2.Size = New System.Drawing.Size(82, 29)
        Me.rType2.TabIndex = 1
        Me.rType2.Text = "Tank"
        Me.rType2.UseVisualStyleBackColor = True
        '
        'rType1
        '
        Me.rType1.AutoSize = True
        Me.rType1.Checked = True
        Me.rType1.Location = New System.Drawing.Point(16, 27)
        Me.rType1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rType1.Name = "rType1"
        Me.rType1.Size = New System.Drawing.Size(88, 29)
        Me.rType1.TabIndex = 0
        Me.rType1.TabStop = True
        Me.rType1.Text = "Meter"
        Me.rType1.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(336, 181)
        Me.cmdPready.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(216, 44)
        Me.cmdPready.TabIndex = 2
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(336, 230)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(216, 48)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmrptProductOfMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 309)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MVDate)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptProductOfMeter"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "รายงานกังารจ่ายตามมิเตอร์,ถัง"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rType2 As System.Windows.Forms.RadioButton
    Friend WithEvents rType1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
