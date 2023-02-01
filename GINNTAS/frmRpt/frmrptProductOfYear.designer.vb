<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptProductOfYear
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rType1 = New System.Windows.Forms.RadioButton()
        Me.MVYear = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ประจำปี"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(23, 152)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(130, 33)
        Me.cmdClose.TabIndex = 27
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(23, 113)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(130, 33)
        Me.cmdPready.TabIndex = 26
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.rType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(170, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 93)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Summary"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(166, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Summary Volume"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rType1
        '
        Me.rType1.AutoSize = True
        Me.rType1.Checked = True
        Me.rType1.Location = New System.Drawing.Point(18, 29)
        Me.rType1.Name = "rType1"
        Me.rType1.Size = New System.Drawing.Size(148, 24)
        Me.rType1.TabIndex = 0
        Me.rType1.TabStop = True
        Me.rType1.Text = "Summary Mass"
        Me.rType1.UseVisualStyleBackColor = True
        '
        'MVYear
        '
        Me.MVYear.CustomFormat = "yyyy"
        Me.MVYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MVYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MVYear.Location = New System.Drawing.Point(23, 81)
        Me.MVYear.Name = "MVYear"
        Me.MVYear.ShowUpDown = True
        Me.MVYear.Size = New System.Drawing.Size(130, 26)
        Me.MVYear.TabIndex = 33
        '
        'frmrptProductOfYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 201)
        Me.Controls.Add(Me.MVYear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptProductOfYear"
        Me.Text = "รายงานสรุปการจ่ายผลิตภัณฑ์ประจำปี"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rType1 As System.Windows.Forms.RadioButton
    Friend WithEvents MVYear As System.Windows.Forms.DateTimePicker
End Class
