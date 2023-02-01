<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptEndOfDay
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
        Me.optStatus6 = New System.Windows.Forms.RadioButton()
        Me.optStatus5 = New System.Windows.Forms.RadioButton()
        Me.optStatus4 = New System.Windows.Forms.RadioButton()
        Me.optStatus3 = New System.Windows.Forms.RadioButton()
        Me.optStatus2 = New System.Windows.Forms.RadioButton()
        Me.optStatus1 = New System.Windows.Forms.RadioButton()
        Me.MVDate = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(600, 124)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(154, 39)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(600, 82)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(154, 36)
        Me.cmdPready.TabIndex = 6
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optStatus6)
        Me.GroupBox1.Controls.Add(Me.optStatus5)
        Me.GroupBox1.Controls.Add(Me.optStatus4)
        Me.GroupBox1.Controls.Add(Me.optStatus3)
        Me.GroupBox1.Controls.Add(Me.optStatus2)
        Me.GroupBox1.Controls.Add(Me.optStatus1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(255, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 174)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "End of Day Report"
        '
        'optStatus6
        '
        Me.optStatus6.AutoSize = True
        Me.optStatus6.Location = New System.Drawing.Point(13, 139)
        Me.optStatus6.Name = "optStatus6"
        Me.optStatus6.Size = New System.Drawing.Size(312, 20)
        Me.optStatus6.TabIndex = 5
        Me.optStatus6.Text = "Summary Mass Load Report By Company"
        Me.optStatus6.UseVisualStyleBackColor = True
        '
        'optStatus5
        '
        Me.optStatus5.AutoSize = True
        Me.optStatus5.Location = New System.Drawing.Point(13, 116)
        Me.optStatus5.Name = "optStatus5"
        Me.optStatus5.Size = New System.Drawing.Size(271, 20)
        Me.optStatus5.TabIndex = 4
        Me.optStatus5.Text = "Summary Load Report By Company"
        Me.optStatus5.UseVisualStyleBackColor = True
        '
        'optStatus4
        '
        Me.optStatus4.AutoSize = True
        Me.optStatus4.Location = New System.Drawing.Point(13, 93)
        Me.optStatus4.Name = "optStatus4"
        Me.optStatus4.Size = New System.Drawing.Size(244, 20)
        Me.optStatus4.TabIndex = 3
        Me.optStatus4.Text = "Mass Load Report By Company"
        Me.optStatus4.UseVisualStyleBackColor = True
        '
        'optStatus3
        '
        Me.optStatus3.AutoSize = True
        Me.optStatus3.Location = New System.Drawing.Point(13, 70)
        Me.optStatus3.Name = "optStatus3"
        Me.optStatus3.Size = New System.Drawing.Size(259, 20)
        Me.optStatus3.TabIndex = 2
        Me.optStatus3.Text = "Volume Load Report By Company"
        Me.optStatus3.UseVisualStyleBackColor = True
        '
        'optStatus2
        '
        Me.optStatus2.AutoSize = True
        Me.optStatus2.Location = New System.Drawing.Point(13, 44)
        Me.optStatus2.Name = "optStatus2"
        Me.optStatus2.Size = New System.Drawing.Size(232, 20)
        Me.optStatus2.TabIndex = 1
        Me.optStatus2.Text = "Mass Load Report By Product"
        Me.optStatus2.UseVisualStyleBackColor = True
        '
        'optStatus1
        '
        Me.optStatus1.AutoSize = True
        Me.optStatus1.Checked = True
        Me.optStatus1.Location = New System.Drawing.Point(13, 20)
        Me.optStatus1.Name = "optStatus1"
        Me.optStatus1.Size = New System.Drawing.Size(251, 20)
        Me.optStatus1.TabIndex = 0
        Me.optStatus1.TabStop = True
        Me.optStatus1.Text = " Volume Load Report By Product"
        Me.optStatus1.UseVisualStyleBackColor = True
        '
        'MVDate
        '
        Me.MVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MVDate.Location = New System.Drawing.Point(17, 69)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 4
        '
        'frmrptEndOfDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 270)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MVDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptEndOfDay"
        Me.Text = "รายงาน End of Day"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optStatus6 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus5 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus4 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus3 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus2 As System.Windows.Forms.RadioButton
    Friend WithEvents optStatus1 As System.Windows.Forms.RadioButton
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
End Class
