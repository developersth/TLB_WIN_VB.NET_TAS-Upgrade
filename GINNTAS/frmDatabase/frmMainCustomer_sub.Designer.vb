<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainCustomer_sub
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OptPOByCustomer = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddr = New System.Windows.Forms.RichTextBox()
        Me.chkTareWeight = New System.Windows.Forms.CheckBox()
        Me.cbCustomerType = New System.Windows.Forms.ComboBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(181, 450)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(22, 453)
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
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(181, 480)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 480)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(191, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 20)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Purchase Order No."
        '
        'OptPOByCustomer
        '
        Me.OptPOByCustomer.AutoSize = True
        Me.OptPOByCustomer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.OptPOByCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OptPOByCustomer.ForeColor = System.Drawing.Color.Fuchsia
        Me.OptPOByCustomer.Location = New System.Drawing.Point(194, 368)
        Me.OptPOByCustomer.Name = "OptPOByCustomer"
        Me.OptPOByCustomer.Size = New System.Drawing.Size(145, 24)
        Me.OptPOByCustomer.TabIndex = 168
        Me.OptPOByCustomer.Text = "PO By Customer"
        Me.OptPOByCustomer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(181, 358)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 86)
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(181, 324)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(248, 26)
        Me.txtTel.TabIndex = 166
        Me.txtTel.Text = "txtTel"
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(182, 291)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(100, 26)
        Me.txtPostCode.TabIndex = 165
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(181, 252)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(248, 26)
        Me.txtProvince.TabIndex = 164
        Me.txtProvince.Text = "txtProvince"
        '
        'txtCustomerAddr
        '
        Me.txtCustomerAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerAddr.Location = New System.Drawing.Point(181, 181)
        Me.txtCustomerAddr.Name = "txtCustomerAddr"
        Me.txtCustomerAddr.Size = New System.Drawing.Size(248, 64)
        Me.txtCustomerAddr.TabIndex = 163
        Me.txtCustomerAddr.Text = "txtCustomerAddr"
        '
        'chkTareWeight
        '
        Me.chkTareWeight.AutoSize = True
        Me.chkTareWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkTareWeight.Location = New System.Drawing.Point(182, 159)
        Me.chkTareWeight.Name = "chkTareWeight"
        Me.chkTareWeight.Size = New System.Drawing.Size(15, 14)
        Me.chkTareWeight.TabIndex = 162
        Me.chkTareWeight.UseVisualStyleBackColor = True
        '
        'cbCustomerType
        '
        Me.cbCustomerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCustomerType.FormattingEnabled = True
        Me.cbCustomerType.Location = New System.Drawing.Point(181, 125)
        Me.cbCustomerType.Name = "cbCustomerType"
        Me.cbCustomerType.Size = New System.Drawing.Size(169, 28)
        Me.cbCustomerType.TabIndex = 161
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(181, 95)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(248, 26)
        Me.txtCustomerName.TabIndex = 160
        Me.txtCustomerName.Text = "txtCustomerName"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(181, 64)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 26)
        Me.txtCustomerID.TabIndex = 159
        Me.txtCustomerID.Text = "txtCustomerID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "เบอร์โทร."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "รหัสไปรษณีย์"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "จังหวัด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "ที่อยู่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "ตรวจสอบปริมาณค้างรถ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "ประเภทลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "ชื่อลูกค้า"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'txtPoNo
        '
        Me.txtPoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPoNo.Location = New System.Drawing.Point(194, 410)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(194, 26)
        Me.txtPoNo.TabIndex = 170
        Me.txtPoNo.Text = "txtPoNo"
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(482, 136)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(83, 77)
        Me.UcCancel1.TabIndex = 123
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(482, 50)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(83, 76)
        Me.UcSave1.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(287, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 20)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(435, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 20)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(356, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 20)
        Me.Label13.TabIndex = 178
        Me.Label13.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(434, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 20)
        Me.Label15.TabIndex = 179
        Me.Label15.Text = "*"
        '
        'frmMainCustomer_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 528)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPoNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.OptPOByCustomer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtCustomerAddr)
        Me.Controls.Add(Me.chkTareWeight)
        Me.Controls.Add(Me.cbCustomerType)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainCustomer_sub"
        Me.Text = "frmConfigBay_sub"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OptPOByCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerAddr As System.Windows.Forms.RichTextBox
    Friend WithEvents chkTareWeight As System.Windows.Forms.CheckBox
    Friend WithEvents cbCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
