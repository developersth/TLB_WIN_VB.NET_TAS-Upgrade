<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigPump_sub
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
        Me.txtLastUpdateDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLastUpdateBy = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptEnabled = New System.Windows.Forms.RadioButton()
        Me.OptUnEnbled = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OptPumType3 = New System.Windows.Forms.RadioButton()
        Me.OptPumType2 = New System.Windows.Forms.RadioButton()
        Me.OptPumType1 = New System.Windows.Forms.RadioButton()
        Me.txtPumpAlram = New System.Windows.Forms.TextBox()
        Me.cbPumpMapping = New System.Windows.Forms.ComboBox()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.txtPumpWoring = New System.Windows.Forms.TextBox()
        Me.textPumpName = New System.Windows.Forms.TextBox()
        Me.textPumpID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(149, 406)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(252, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 406)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 20)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "วัน-เวลาที่แก้ไขล่าสุด"
        '
        'txtLastUpdateBy
        '
        Me.txtLastUpdateBy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateBy.Enabled = False
        Me.txtLastUpdateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(149, 437)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(252, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 437)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptEnabled)
        Me.GroupBox1.Controls.Add(Me.OptUnEnbled)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(150, 334)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 66)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'OptEnabled
        '
        Me.OptEnabled.AutoSize = True
        Me.OptEnabled.BackColor = System.Drawing.Color.White
        Me.OptEnabled.Location = New System.Drawing.Point(3, 13)
        Me.OptEnabled.Name = "OptEnabled"
        Me.OptEnabled.Size = New System.Drawing.Size(130, 24)
        Me.OptEnabled.TabIndex = 110
        Me.OptEnabled.TabStop = True
        Me.OptEnabled.Text = "สามารถใช้งานได้"
        Me.OptEnabled.UseVisualStyleBackColor = False
        '
        'OptUnEnbled
        '
        Me.OptUnEnbled.AutoSize = True
        Me.OptUnEnbled.BackColor = System.Drawing.Color.White
        Me.OptUnEnbled.Location = New System.Drawing.Point(3, 36)
        Me.OptUnEnbled.Name = "OptUnEnbled"
        Me.OptUnEnbled.Size = New System.Drawing.Size(115, 24)
        Me.OptUnEnbled.TabIndex = 111
        Me.OptUnEnbled.TabStop = True
        Me.OptUnEnbled.Text = "หยุดการใช้งาน"
        Me.OptUnEnbled.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "สถานะการใช้งาน"
        '
        'OptPumType3
        '
        Me.OptPumType3.AutoSize = True
        Me.OptPumType3.BackColor = System.Drawing.Color.White
        Me.OptPumType3.Location = New System.Drawing.Point(6, 57)
        Me.OptPumType3.Name = "OptPumType3"
        Me.OptPumType3.Size = New System.Drawing.Size(115, 24)
        Me.OptPumType3.TabIndex = 179
        Me.OptPumType3.TabStop = True
        Me.OptPumType3.Text = "หยุดการใช้งาน"
        Me.OptPumType3.UseVisualStyleBackColor = False
        '
        'OptPumType2
        '
        Me.OptPumType2.AutoSize = True
        Me.OptPumType2.BackColor = System.Drawing.Color.White
        Me.OptPumType2.Location = New System.Drawing.Point(6, 34)
        Me.OptPumType2.Name = "OptPumType2"
        Me.OptPumType2.Size = New System.Drawing.Size(69, 24)
        Me.OptPumType2.TabIndex = 178
        Me.OptPumType2.TabStop = True
        Me.OptPumType2.Text = "ปั๊มจ่าย"
        Me.OptPumType2.UseVisualStyleBackColor = False
        '
        'OptPumType1
        '
        Me.OptPumType1.AutoSize = True
        Me.OptPumType1.BackColor = System.Drawing.Color.White
        Me.OptPumType1.Location = New System.Drawing.Point(6, 11)
        Me.OptPumType1.Name = "OptPumType1"
        Me.OptPumType1.Size = New System.Drawing.Size(62, 24)
        Me.OptPumType1.TabIndex = 177
        Me.OptPumType1.TabStop = True
        Me.OptPumType1.Text = "ปั๊มรับ"
        Me.OptPumType1.UseVisualStyleBackColor = False
        '
        'txtPumpAlram
        '
        Me.txtPumpAlram.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPumpAlram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPumpAlram.Location = New System.Drawing.Point(150, 311)
        Me.txtPumpAlram.Name = "txtPumpAlram"
        Me.txtPumpAlram.Size = New System.Drawing.Size(169, 26)
        Me.txtPumpAlram.TabIndex = 171
        Me.txtPumpAlram.Text = "txtPumpAlarm"
        '
        'cbPumpMapping
        '
        Me.cbPumpMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPumpMapping.FormattingEnabled = True
        Me.cbPumpMapping.Location = New System.Drawing.Point(150, 153)
        Me.cbPumpMapping.Name = "cbPumpMapping"
        Me.cbPumpMapping.Size = New System.Drawing.Size(169, 28)
        Me.cbPumpMapping.TabIndex = 170
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(150, 122)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(169, 28)
        Me.cbProduct.TabIndex = 169
        '
        'txtPumpWoring
        '
        Me.txtPumpWoring.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPumpWoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPumpWoring.Location = New System.Drawing.Point(150, 280)
        Me.txtPumpWoring.Name = "txtPumpWoring"
        Me.txtPumpWoring.Size = New System.Drawing.Size(169, 26)
        Me.txtPumpWoring.TabIndex = 168
        Me.txtPumpWoring.Text = "txtPumpWoring"
        '
        'textPumpName
        '
        Me.textPumpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textPumpName.Location = New System.Drawing.Point(150, 92)
        Me.textPumpName.Name = "textPumpName"
        Me.textPumpName.Size = New System.Drawing.Size(169, 26)
        Me.textPumpName.TabIndex = 167
        Me.textPumpName.Text = "txtPumpName"
        '
        'textPumpID
        '
        Me.textPumpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textPumpID.Location = New System.Drawing.Point(150, 64)
        Me.textPumpID.Name = "textPumpID"
        Me.textPumpID.Size = New System.Drawing.Size(169, 26)
        Me.textPumpID.TabIndex = 166
        Me.textPumpID.Text = "txtPumpl"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "สถานะปั๊มขัดข้อง"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "สถานะการทำงาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "ประเภทปั๊ม"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Pump Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "ผลิตภัณฑ์"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(95, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 20)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "ชื่อปั้ม"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(112, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 20)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "ปั๊ม"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptPumType2)
        Me.GroupBox2.Controls.Add(Me.OptPumType3)
        Me.GroupBox2.Controls.Add(Me.OptPumType1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(150, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 92)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(408, 150)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(71, 70)
        Me.UcCancel1.TabIndex = 123
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(408, 64)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'frmConfigPump_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 474)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPumpAlram)
        Me.Controls.Add(Me.cbPumpMapping)
        Me.Controls.Add(Me.cbProduct)
        Me.Controls.Add(Me.txtPumpWoring)
        Me.Controls.Add(Me.textPumpName)
        Me.Controls.Add(Me.textPumpID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigPump_sub"
        Me.Text = "frmConfigBay_sub"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents OptUnEnbled As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents OptPumType3 As System.Windows.Forms.RadioButton
    Friend WithEvents OptPumType2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptPumType1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtPumpAlram As System.Windows.Forms.TextBox
    Friend WithEvents cbPumpMapping As System.Windows.Forms.ComboBox
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtPumpWoring As System.Windows.Forms.TextBox
    Friend WithEvents textPumpName As System.Windows.Forms.TextBox
    Friend WithEvents textPumpID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
