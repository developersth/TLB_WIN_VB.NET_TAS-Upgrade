<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptDepHighway
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
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optType2 = New System.Windows.Forms.RadioButton()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.MVDate = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(285, 76)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(197, 28)
        Me.cbProduct.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optType2)
        Me.GroupBox1.Controls.Add(Me.optType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 81)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Government"
        '
        'optType2
        '
        Me.optType2.AutoSize = True
        Me.optType2.Location = New System.Drawing.Point(18, 46)
        Me.optType2.Name = "optType2"
        Me.optType2.Size = New System.Drawing.Size(63, 24)
        Me.optType2.TabIndex = 1
        Me.optType2.Text = "ไม่ส่ง"
        Me.optType2.UseVisualStyleBackColor = True
        '
        'optType1
        '
        Me.optType1.AutoSize = True
        Me.optType1.Checked = True
        Me.optType1.Location = New System.Drawing.Point(18, 19)
        Me.optType1.Name = "optType1"
        Me.optType1.Size = New System.Drawing.Size(153, 24)
        Me.optType1.TabIndex = 0
        Me.optType1.TabStop = True
        Me.optType1.Text = "ส่งให้กรมทางหลวง"
        Me.optType1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product"
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(284, 208)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(85, 33)
        Me.cmdPready.TabIndex = 4
        Me.cmdPready.Text = "ดูก่อนพิมพ์"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(285, 247)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 30)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "พิมพ์"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(376, 208)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 33)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'MVDate
        '
        Me.MVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MVDate.Location = New System.Drawing.Point(19, 55)
        Me.MVDate.Name = "MVDate"
        Me.MVDate.TabIndex = 7
        '
        'frmrptDepHighway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 303)
        Me.Controls.Add(Me.MVDate)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdPready)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbProduct)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptDepHighway"
        Me.Text = "รายงานการจ่ายกับกรมทางหลวงเรียงตามบริษัท"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optType2 As System.Windows.Forms.RadioButton
    Friend WithEvents optType1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents MVDate As System.Windows.Forms.MonthCalendar
End Class
