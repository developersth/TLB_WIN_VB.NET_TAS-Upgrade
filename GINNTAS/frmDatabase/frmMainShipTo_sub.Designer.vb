<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainShipTo_sub
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.OptUnEnabled = New System.Windows.Forms.RadioButton()
        Me.OptIsEnabled = New System.Windows.Forms.RadioButton()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtToProject = New System.Windows.Forms.RichTextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtIndDep = New System.Windows.Forms.TextBox()
        Me.txtContract = New System.Windows.Forms.TextBox()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.txtShiptoName = New System.Windows.Forms.TextBox()
        Me.txtShiptoID = New System.Windows.Forms.TextBox()
        Me.CmbDistribution = New System.Windows.Forms.ComboBox()
        Me.cmbCusShipTo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(185, 521)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 521)
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
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(185, 554)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(93, 554)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(448, 60)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(45, 29)
        Me.cmdSearch.TabIndex = 177
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'OptUnEnabled
        '
        Me.OptUnEnabled.AutoSize = True
        Me.OptUnEnabled.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OptUnEnabled.Location = New System.Drawing.Point(94, 15)
        Me.OptUnEnabled.Name = "OptUnEnabled"
        Me.OptUnEnabled.Size = New System.Drawing.Size(101, 24)
        Me.OptUnEnabled.TabIndex = 176
        Me.OptUnEnabled.TabStop = True
        Me.OptUnEnabled.Text = "หน่วนงานอื่น"
        Me.OptUnEnabled.UseVisualStyleBackColor = False
        '
        'OptIsEnabled
        '
        Me.OptIsEnabled.AutoSize = True
        Me.OptIsEnabled.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OptIsEnabled.Location = New System.Drawing.Point(11, 15)
        Me.OptIsEnabled.Name = "OptIsEnabled"
        Me.OptIsEnabled.Size = New System.Drawing.Size(77, 24)
        Me.OptIsEnabled.TabIndex = 175
        Me.OptIsEnabled.TabStop = True
        Me.OptIsEnabled.Text = "กรมทาง"
        Me.OptIsEnabled.UseVisualStyleBackColor = False
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(187, 400)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(154, 26)
        Me.txtTel.TabIndex = 173
        Me.txtTel.Text = "txtTel"
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(187, 368)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(154, 26)
        Me.txtPostCode.TabIndex = 172
        Me.txtPostCode.Text = "txtPo"
        '
        'txtToProject
        '
        Me.txtToProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtToProject.Location = New System.Drawing.Point(187, 254)
        Me.txtToProject.Name = "txtToProject"
        Me.txtToProject.Size = New System.Drawing.Size(255, 77)
        Me.txtToProject.TabIndex = 171
        Me.txtToProject.Text = "txtToProject"
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(188, 336)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(255, 26)
        Me.txtProvince.TabIndex = 170
        Me.txtProvince.Text = "txtProvince"
        '
        'txtIndDep
        '
        Me.txtIndDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIndDep.Location = New System.Drawing.Point(186, 220)
        Me.txtIndDep.Name = "txtIndDep"
        Me.txtIndDep.Size = New System.Drawing.Size(130, 26)
        Me.txtIndDep.TabIndex = 169
        Me.txtIndDep.Text = "txtlndDep"
        '
        'txtContract
        '
        Me.txtContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtContract.Location = New System.Drawing.Point(186, 192)
        Me.txtContract.Name = "txtContract"
        Me.txtContract.Size = New System.Drawing.Size(256, 26)
        Me.txtContract.TabIndex = 168
        Me.txtContract.Text = "txtContract"
        '
        'txtPoNo
        '
        Me.txtPoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPoNo.Location = New System.Drawing.Point(186, 159)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(256, 26)
        Me.txtPoNo.TabIndex = 167
        Me.txtPoNo.Text = "txtPoNo"
        '
        'txtShiptoName
        '
        Me.txtShiptoName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShiptoName.Location = New System.Drawing.Point(186, 127)
        Me.txtShiptoName.Name = "txtShiptoName"
        Me.txtShiptoName.Size = New System.Drawing.Size(256, 26)
        Me.txtShiptoName.TabIndex = 166
        Me.txtShiptoName.Text = "txtShiptoName"
        '
        'txtShiptoID
        '
        Me.txtShiptoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShiptoID.Location = New System.Drawing.Point(187, 95)
        Me.txtShiptoID.Name = "txtShiptoID"
        Me.txtShiptoID.Size = New System.Drawing.Size(130, 26)
        Me.txtShiptoID.TabIndex = 165
        Me.txtShiptoID.Text = "txtShiptol"
        '
        'CmbDistribution
        '
        Me.CmbDistribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmbDistribution.FormattingEnabled = True
        Me.CmbDistribution.Location = New System.Drawing.Point(185, 487)
        Me.CmbDistribution.Name = "CmbDistribution"
        Me.CmbDistribution.Size = New System.Drawing.Size(196, 28)
        Me.CmbDistribution.TabIndex = 164
        '
        'cmbCusShipTo
        '
        Me.cmbCusShipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCusShipTo.FormattingEnabled = True
        Me.cmbCusShipTo.Location = New System.Drawing.Point(186, 61)
        Me.cmbCusShipTo.Name = "cmbCusShipTo"
        Me.cmbCusShipTo.Size = New System.Drawing.Size(256, 28)
        Me.cmbCusShipTo.TabIndex = 163
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 162
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 20)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Distribution Chanel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(97, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "เบอร์โทร"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "รหัสไปรษณีย์"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "จังหวัด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "ส่งของให้ที่โครงการ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "สังกัดหน่วยงาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "ตามสัญญา/ใบสั่งซื้อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Purchase Order No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "ชื่อปลายทาง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "รหัสปลายทาง"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(94, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "รหัสลูกค้า"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptIsEnabled)
        Me.GroupBox1.Controls.Add(Me.OptUnEnabled)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(186, 432)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 47)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcCancel1.Location = New System.Drawing.Point(521, 135)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(85, 87)
        Me.UcCancel1.TabIndex = 123
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(521, 43)
        Me.UcSave1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(85, 86)
        Me.UcSave1.TabIndex = 122
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(166, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 179
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(166, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(166, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 181
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(166, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 182
        Me.Label18.Text = "*"
        '
        'frmMainShipTo_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 597)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtToProject)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtIndDep)
        Me.Controls.Add(Me.txtContract)
        Me.Controls.Add(Me.txtPoNo)
        Me.Controls.Add(Me.txtShiptoName)
        Me.Controls.Add(Me.txtShiptoID)
        Me.Controls.Add(Me.CmbDistribution)
        Me.Controls.Add(Me.cmbCusShipTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainShipTo_sub"
        Me.Text = "frmConfigBay_sub"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents OptUnEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents OptIsEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtToProject As System.Windows.Forms.RichTextBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtIndDep As System.Windows.Forms.TextBox
    Friend WithEvents txtContract As System.Windows.Forms.TextBox
    Friend WithEvents txtPoNo As System.Windows.Forms.TextBox
    Friend WithEvents txtShiptoName As System.Windows.Forms.TextBox
    Friend WithEvents txtShiptoID As System.Windows.Forms.TextBox
    Friend WithEvents CmbDistribution As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCusShipTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
