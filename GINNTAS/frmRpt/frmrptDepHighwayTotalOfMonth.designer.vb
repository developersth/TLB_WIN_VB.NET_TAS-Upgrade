<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptDepHighwayTotalOfMonth
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
        Me.rType1 = New System.Windows.Forms.RadioButton()
        Me.rType2 = New System.Windows.Forms.RadioButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MVDate = New System.Windows.Forms.DateTimePicker()
        Me.cbProductID = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rType1
        '
        Me.rType1.AutoSize = True
        Me.rType1.Checked = True
        Me.rType1.Location = New System.Drawing.Point(18, 26)
        Me.rType1.Name = "rType1"
        Me.rType1.Size = New System.Drawing.Size(153, 24)
        Me.rType1.TabIndex = 0
        Me.rType1.TabStop = True
        Me.rType1.Text = "ส่งให้กรมทางหลวง"
        Me.rType1.UseVisualStyleBackColor = True
        '
        'rType2
        '
        Me.rType2.AutoSize = True
        Me.rType2.Location = New System.Drawing.Point(18, 53)
        Me.rType2.Name = "rType2"
        Me.rType2.Size = New System.Drawing.Size(63, 24)
        Me.rType2.TabIndex = 1
        Me.rType2.Text = "ไม่ส่ง"
        Me.rType2.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(328, 158)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 33)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(236, 158)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(85, 33)
        Me.cmdPready.TabIndex = 18
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rType2)
        Me.GroupBox1.Controls.Add(Me.rType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(236, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 81)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Government"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ประจำเดือน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Product"
        '
        'MVDate
        '
        Me.MVDate.CustomFormat = "MM/yyyy"
        Me.MVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MVDate.Location = New System.Drawing.Point(29, 80)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.Size = New System.Drawing.Size(172, 26)
        Me.MVDate.TabIndex = 23
        Me.MVDate.Value = New Date(2015, 4, 1, 0, 0, 0, 0)
        '
        'cbProductID
        '
        Me.cbProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProductID.FormattingEnabled = True
        Me.cbProductID.Location = New System.Drawing.Point(29, 139)
        Me.cbProductID.Name = "cbProductID"
        Me.cbProductID.Size = New System.Drawing.Size(172, 28)
        Me.cbProductID.TabIndex = 24
        Me.cbProductID.Text = "cbProductID"
        '
        'frmrptDepHighwayTotalOfMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 209)
        Me.Controls.Add(Me.cbProductID)
        Me.Controls.Add(Me.MVDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptDepHighwayTotalOfMonth"
        Me.Text = "รายงานการจ่ายกับกรมทางหลวงทั้งหมด"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rType1 As System.Windows.Forms.RadioButton
    Friend WithEvents rType2 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MVDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbProductID As System.Windows.Forms.ComboBox
End Class
