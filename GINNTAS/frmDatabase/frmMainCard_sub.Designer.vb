<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainCard_sub
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
        Me.cmdFindVehicle = New System.Windows.Forms.Button()
        Me.chkExprie = New System.Windows.Forms.CheckBox()
        Me.DTPDateEXP = New System.Windows.Forms.DateTimePicker()
        Me.DTPTimeEXP = New System.Windows.Forms.DateTimePicker()
        Me.cbTruck = New System.Windows.Forms.ComboBox()
        Me.txtCardID = New System.Windows.Forms.TextBox()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptUnUsed = New System.Windows.Forms.RadioButton()
        Me.OptIsUsed = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptTructType3 = New System.Windows.Forms.RadioButton()
        Me.OptTructType1 = New System.Windows.Forms.RadioButton()
        Me.OptTructType2 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Enabled = False
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(157, 401)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 404)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 20)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "วัน-เวลาที่แก้ไขล่าสุด"
        '
        'txtLastUpdateBy
        '
        Me.txtLastUpdateBy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateBy.Enabled = False
        Me.txtLastUpdateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(157, 432)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptEnabled)
        Me.GroupBox1.Controls.Add(Me.OptUnEnbled)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(157, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 57)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'OptEnabled
        '
        Me.OptEnabled.AutoSize = True
        Me.OptEnabled.BackColor = System.Drawing.Color.White
        Me.OptEnabled.Location = New System.Drawing.Point(6, 12)
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
        Me.OptUnEnbled.Location = New System.Drawing.Point(6, 35)
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
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 349)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "สถานะการใช้งาน"
        '
        'cmdFindVehicle
        '
        Me.cmdFindVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdFindVehicle.Location = New System.Drawing.Point(340, 121)
        Me.cmdFindVehicle.Name = "cmdFindVehicle"
        Me.cmdFindVehicle.Size = New System.Drawing.Size(35, 28)
        Me.cmdFindVehicle.TabIndex = 165
        Me.cmdFindVehicle.Text = "..."
        Me.cmdFindVehicle.UseVisualStyleBackColor = True
        '
        'chkExprie
        '
        Me.chkExprie.AutoSize = True
        Me.chkExprie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkExprie.Location = New System.Drawing.Point(440, 253)
        Me.chkExprie.Name = "chkExprie"
        Me.chkExprie.Size = New System.Drawing.Size(131, 24)
        Me.chkExprie.TabIndex = 164
        Me.chkExprie.Text = "Set Expired All"
        Me.chkExprie.UseVisualStyleBackColor = True
        '
        'DTPDateEXP
        '
        Me.DTPDateEXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPDateEXP.Location = New System.Drawing.Point(157, 252)
        Me.DTPDateEXP.Name = "DTPDateEXP"
        Me.DTPDateEXP.Size = New System.Drawing.Size(189, 26)
        Me.DTPDateEXP.TabIndex = 163
        '
        'DTPTimeEXP
        '
        Me.DTPTimeEXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeEXP.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeEXP.Location = New System.Drawing.Point(352, 252)
        Me.DTPTimeEXP.Name = "DTPTimeEXP"
        Me.DTPTimeEXP.Size = New System.Drawing.Size(82, 26)
        Me.DTPTimeEXP.TabIndex = 162
        '
        'cbTruck
        '
        Me.cbTruck.BackColor = System.Drawing.Color.White
        Me.cbTruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTruck.ForeColor = System.Drawing.Color.Black
        Me.cbTruck.FormattingEnabled = True
        Me.cbTruck.Location = New System.Drawing.Point(157, 121)
        Me.cbTruck.Name = "cbTruck"
        Me.cbTruck.Size = New System.Drawing.Size(176, 28)
        Me.cbTruck.TabIndex = 161
        '
        'txtCardID
        '
        Me.txtCardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCardID.Location = New System.Drawing.Point(157, 91)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Size = New System.Drawing.Size(100, 26)
        Me.txtCardID.TabIndex = 160
        Me.txtCardID.Text = "txtCardID"
        '
        'txtCard
        '
        Me.txtCard.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCard.Enabled = False
        Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCard.ForeColor = System.Drawing.Color.Black
        Me.txtCard.Location = New System.Drawing.Point(157, 63)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(100, 26)
        Me.txtCard.TabIndex = 159
        Me.txtCard.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "IS_USED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "EXPIRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "ประเภทรถ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "ทะเบียนรถ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "รหัสบัตร"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "หมายเลขบัตร"
        Me.Label1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptUnUsed)
        Me.GroupBox2.Controls.Add(Me.OptIsUsed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(158, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 68)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        'OptUnUsed
        '
        Me.OptUnUsed.AutoSize = True
        Me.OptUnUsed.BackColor = System.Drawing.Color.White
        Me.OptUnUsed.Location = New System.Drawing.Point(10, 34)
        Me.OptUnUsed.Name = "OptUnUsed"
        Me.OptUnUsed.Size = New System.Drawing.Size(47, 24)
        Me.OptUnUsed.TabIndex = 176
        Me.OptUnUsed.TabStop = True
        Me.OptUnUsed.Text = "No"
        Me.OptUnUsed.UseVisualStyleBackColor = False
        '
        'OptIsUsed
        '
        Me.OptIsUsed.AutoSize = True
        Me.OptIsUsed.BackColor = System.Drawing.Color.White
        Me.OptIsUsed.Location = New System.Drawing.Point(10, 11)
        Me.OptIsUsed.Name = "OptIsUsed"
        Me.OptIsUsed.Size = New System.Drawing.Size(55, 24)
        Me.OptIsUsed.TabIndex = 175
        Me.OptIsUsed.TabStop = True
        Me.OptIsUsed.Text = "Yes"
        Me.OptIsUsed.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OptTructType3)
        Me.GroupBox3.Controls.Add(Me.OptTructType1)
        Me.GroupBox3.Controls.Add(Me.OptTructType2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(158, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 96)
        Me.GroupBox3.TabIndex = 173
        Me.GroupBox3.TabStop = False
        '
        'OptTructType3
        '
        Me.OptTructType3.AutoSize = True
        Me.OptTructType3.Location = New System.Drawing.Point(10, 61)
        Me.OptTructType3.Name = "OptTructType3"
        Me.OptTructType3.Size = New System.Drawing.Size(113, 24)
        Me.OptTructType3.TabIndex = 176
        Me.OptTructType3.TabStop = True
        Me.OptTructType3.Text = "บัตร TOP UP"
        Me.OptTructType3.UseVisualStyleBackColor = True
        '
        'OptTructType1
        '
        Me.OptTructType1.AutoSize = True
        Me.OptTructType1.Location = New System.Drawing.Point(10, 15)
        Me.OptTructType1.Name = "OptTructType1"
        Me.OptTructType1.Size = New System.Drawing.Size(68, 24)
        Me.OptTructType1.TabIndex = 174
        Me.OptTructType1.TabStop = True
        Me.OptTructType1.Text = "บัตรรถ"
        Me.OptTructType1.UseVisualStyleBackColor = True
        '
        'OptTructType2
        '
        Me.OptTructType2.AutoSize = True
        Me.OptTructType2.Location = New System.Drawing.Point(10, 38)
        Me.OptTructType2.Name = "OptTructType2"
        Me.OptTructType2.Size = New System.Drawing.Size(92, 24)
        Me.OptTructType2.TabIndex = 175
        Me.OptTructType2.TabStop = True
        Me.OptTructType2.Text = "บัตรรถพ่วง"
        Me.OptTructType2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(266, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(381, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "*"
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcCancel1.Location = New System.Drawing.Point(500, 120)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(71, 78)
        Me.UcCancel1.TabIndex = 123
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(500, 40)
        Me.UcSave1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 76)
        Me.UcSave1.TabIndex = 122
        '
        'frmMainCard_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 499)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdFindVehicle)
        Me.Controls.Add(Me.chkExprie)
        Me.Controls.Add(Me.DTPDateEXP)
        Me.Controls.Add(Me.DTPTimeEXP)
        Me.Controls.Add(Me.cbTruck)
        Me.Controls.Add(Me.txtCardID)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "frmMainCard_sub"
        Me.Text = "frmConfigBay_sub"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents cmdFindVehicle As System.Windows.Forms.Button
    Friend WithEvents chkExprie As System.Windows.Forms.CheckBox
    Friend WithEvents DTPDateEXP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTimeEXP As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbTruck As System.Windows.Forms.ComboBox
    Friend WithEvents txtCardID As System.Windows.Forms.TextBox
    Friend WithEvents txtCard As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptUnUsed As System.Windows.Forms.RadioButton
    Friend WithEvents OptIsUsed As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptTructType3 As System.Windows.Forms.RadioButton
    Friend WithEvents OptTructType1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptTructType2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
