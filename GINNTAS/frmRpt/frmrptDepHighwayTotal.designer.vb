<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptDepHighwayTotal
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rType2 = New System.Windows.Forms.RadioButton()
        Me.rType1 = New System.Windows.Forms.RadioButton()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MVDate
        '
        Me.MVDate.Location = New System.Drawing.Point(12, 69)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 14
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(362, 212)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(84, 33)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(268, 250)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 30)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "พิมพ์"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(268, 211)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(85, 33)
        Me.cmdPready.TabIndex = 11
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rType2)
        Me.GroupBox1.Controls.Add(Me.rType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(267, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 81)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Government"
        '
        'rType2
        '
        Me.rType2.AutoSize = True
        Me.rType2.Location = New System.Drawing.Point(18, 47)
        Me.rType2.Name = "rType2"
        Me.rType2.Size = New System.Drawing.Size(63, 24)
        Me.rType2.TabIndex = 1
        Me.rType2.Text = "ไม่ส่ง"
        Me.rType2.UseVisualStyleBackColor = True
        '
        'rType1
        '
        Me.rType1.AutoSize = True
        Me.rType1.Checked = True
        Me.rType1.Location = New System.Drawing.Point(18, 21)
        Me.rType1.Name = "rType1"
        Me.rType1.Size = New System.Drawing.Size(153, 24)
        Me.rType1.TabIndex = 0
        Me.rType1.TabStop = True
        Me.rType1.Text = "ส่งให้กรมทางหลวง"
        Me.rType1.UseVisualStyleBackColor = True
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(267, 83)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(197, 28)
        Me.cbProduct.TabIndex = 8
        '
        'frmrptDepHighwayTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 300)
        Me.Controls.Add(Me.MVDate)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbProduct)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptDepHighwayTotal"
        Me.Text = "รายงานการจ่ายกับกรมทางหลวงทั้งหมด"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rType2 As System.Windows.Forms.RadioButton
    Friend WithEvents rType1 As System.Windows.Forms.RadioButton
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
End Class
