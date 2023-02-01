<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigSaleProduct_sub
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OptUnCheckWeight = New System.Windows.Forms.RadioButton()
        Me.OptCheckWeight = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptDoNotLoadMeter = New System.Windows.Forms.RadioButton()
        Me.OptLoadMeter = New System.Windows.Forms.RadioButton()
        Me.cbBaseProduct = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptUnLoad = New System.Windows.Forms.RadioButton()
        Me.OptLoaded = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.OptUnWeight = New System.Windows.Forms.RadioButton()
        Me.OptWeight = New System.Windows.Forms.RadioButton()
        Me.cbSaleUnit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMapOilsys = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtGroupPro = New System.Windows.Forms.TextBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbProductType = New System.Windows.Forms.ComboBox()
        Me.OptUnEnbled = New System.Windows.Forms.RadioButton()
        Me.OptEnabled = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ตั้งค่าสี = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.สีผลิตภัณฑ์ = New System.Windows.Forms.Label()
        Me.txtAutoSort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.Txt_GOV_COQ_NO = New System.Windows.Forms.TextBox()
        Me.Label_GOV_COQ_NO = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGOV_COQ_DATE = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(146, 555)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 558)
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
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(146, 583)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 586)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "ประเภทผลิตภัณฑ์"
        Me.Label2.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OptUnCheckWeight)
        Me.GroupBox4.Controls.Add(Me.OptCheckWeight)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(413, 385)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(198, 48)
        Me.GroupBox4.TabIndex = 170
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ตรวจสอบน้ำหนักค้างรถ"
        '
        'OptUnCheckWeight
        '
        Me.OptUnCheckWeight.AutoSize = True
        Me.OptUnCheckWeight.Location = New System.Drawing.Point(92, 61)
        Me.OptUnCheckWeight.Name = "OptUnCheckWeight"
        Me.OptUnCheckWeight.Size = New System.Drawing.Size(100, 24)
        Me.OptUnCheckWeight.TabIndex = 3
        Me.OptUnCheckWeight.TabStop = True
        Me.OptUnCheckWeight.Text = "ไม่ตรวจสอบ"
        Me.OptUnCheckWeight.UseVisualStyleBackColor = True
        '
        'OptCheckWeight
        '
        Me.OptCheckWeight.AutoSize = True
        Me.OptCheckWeight.Location = New System.Drawing.Point(11, 60)
        Me.OptCheckWeight.Name = "OptCheckWeight"
        Me.OptCheckWeight.Size = New System.Drawing.Size(83, 24)
        Me.OptCheckWeight.TabIndex = 2
        Me.OptCheckWeight.TabStop = True
        Me.OptCheckWeight.Text = "ตรวจสอบ"
        Me.OptCheckWeight.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OptDoNotLoadMeter)
        Me.GroupBox3.Controls.Add(Me.OptLoadMeter)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(146, 385)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(240, 48)
        Me.GroupBox3.TabIndex = 169
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "มิเตอร์จ่าย"
        '
        'OptDoNotLoadMeter
        '
        Me.OptDoNotLoadMeter.AutoSize = True
        Me.OptDoNotLoadMeter.Location = New System.Drawing.Point(110, 62)
        Me.OptDoNotLoadMeter.Name = "OptDoNotLoadMeter"
        Me.OptDoNotLoadMeter.Size = New System.Drawing.Size(117, 24)
        Me.OptDoNotLoadMeter.TabIndex = 1
        Me.OptDoNotLoadMeter.TabStop = True
        Me.OptDoNotLoadMeter.Text = "ไม่มีมิเตอร์จ่าย"
        Me.OptDoNotLoadMeter.UseVisualStyleBackColor = True
        '
        'OptLoadMeter
        '
        Me.OptLoadMeter.AutoSize = True
        Me.OptLoadMeter.Location = New System.Drawing.Point(10, 60)
        Me.OptLoadMeter.Name = "OptLoadMeter"
        Me.OptLoadMeter.Size = New System.Drawing.Size(100, 24)
        Me.OptLoadMeter.TabIndex = 0
        Me.OptLoadMeter.TabStop = True
        Me.OptLoadMeter.Text = "มีมิเตอร์จ่าย"
        Me.OptLoadMeter.UseVisualStyleBackColor = True
        '
        'cbBaseProduct
        '
        Me.cbBaseProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbBaseProduct.FormattingEnabled = True
        Me.cbBaseProduct.Location = New System.Drawing.Point(146, 356)
        Me.cbBaseProduct.Name = "cbBaseProduct"
        Me.cbBaseProduct.Size = New System.Drawing.Size(163, 28)
        Me.cbBaseProduct.TabIndex = 168
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptUnLoad)
        Me.GroupBox2.Controls.Add(Me.OptLoaded)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(308, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 93)
        Me.GroupBox2.TabIndex = 167
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "กระบวนการจ่าย"
        '
        'OptUnLoad
        '
        Me.OptUnLoad.AutoSize = True
        Me.OptUnLoad.Location = New System.Drawing.Point(18, 48)
        Me.OptUnLoad.Name = "OptUnLoad"
        Me.OptUnLoad.Size = New System.Drawing.Size(148, 24)
        Me.OptUnLoad.TabIndex = 3
        Me.OptUnLoad.TabStop = True
        Me.OptUnLoad.Text = "ไม่มีกระบวนการจ่าย"
        Me.OptUnLoad.UseVisualStyleBackColor = True
        '
        'OptLoaded
        '
        Me.OptLoaded.AutoSize = True
        Me.OptLoaded.Location = New System.Drawing.Point(18, 25)
        Me.OptLoaded.Name = "OptLoaded"
        Me.OptLoaded.Size = New System.Drawing.Size(131, 24)
        Me.OptLoaded.TabIndex = 2
        Me.OptLoaded.TabStop = True
        Me.OptLoaded.Text = "มีกระบวนการจ่าย"
        Me.OptLoaded.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OptUnWeight)
        Me.GroupBox5.Controls.Add(Me.OptWeight)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(146, 243)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(158, 93)
        Me.GroupBox5.TabIndex = 166
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ชั่งน้ำหนัก"
        '
        'OptUnWeight
        '
        Me.OptUnWeight.AutoSize = True
        Me.OptUnWeight.Location = New System.Drawing.Point(16, 48)
        Me.OptUnWeight.Name = "OptUnWeight"
        Me.OptUnWeight.Size = New System.Drawing.Size(127, 24)
        Me.OptUnWeight.TabIndex = 1
        Me.OptUnWeight.TabStop = True
        Me.OptUnWeight.Text = "ไม่ต้องชั่งน้ำหนัก"
        Me.OptUnWeight.UseVisualStyleBackColor = True
        '
        'OptWeight
        '
        Me.OptWeight.AutoSize = True
        Me.OptWeight.Location = New System.Drawing.Point(16, 25)
        Me.OptWeight.Name = "OptWeight"
        Me.OptWeight.Size = New System.Drawing.Size(94, 24)
        Me.OptWeight.TabIndex = 0
        Me.OptWeight.TabStop = True
        Me.OptWeight.Text = "ต้องชั่งหนัก"
        Me.OptWeight.UseVisualStyleBackColor = True
        '
        'cbSaleUnit
        '
        Me.cbSaleUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSaleUnit.FormattingEnabled = True
        Me.cbSaleUnit.Location = New System.Drawing.Point(146, 180)
        Me.cbSaleUnit.Name = "cbSaleUnit"
        Me.cbSaleUnit.Size = New System.Drawing.Size(120, 28)
        Me.cbSaleUnit.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "ชื่อผลิตภัณฑ์"
        '
        'txtMapOilsys
        '
        Me.txtMapOilsys.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMapOilsys.Location = New System.Drawing.Point(368, 153)
        Me.txtMapOilsys.Name = "txtMapOilsys"
        Me.txtMapOilsys.Size = New System.Drawing.Size(126, 26)
        Me.txtMapOilsys.TabIndex = 163
        Me.txtMapOilsys.Text = "txtProductCode"
        '
        'txtProductCode
        '
        Me.txtProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(146, 150)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(120, 26)
        Me.txtProductCode.TabIndex = 162
        Me.txtProductCode.Text = "txtProductCode"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(146, 121)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(348, 26)
        Me.txtProductName.TabIndex = 161
        Me.txtProductName.Text = "txtProductName"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(143, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 20)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Map Base Product ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "สถานะผลิตภัณฑ์"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "การใช้งาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(266, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Map OILSYS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "หน่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "รหัสผลิตภัณฑ์"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "ผลิตภัณฑ์"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(146, 91)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(120, 26)
        Me.txtProductID.TabIndex = 153
        Me.txtProductID.Text = "txtProductID"
        '
        'txtGroupPro
        '
        Me.txtGroupPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGroupPro.Location = New System.Drawing.Point(146, 466)
        Me.txtGroupPro.Name = "txtGroupPro"
        Me.txtGroupPro.Size = New System.Drawing.Size(216, 26)
        Me.txtGroupPro.TabIndex = 179
        Me.txtGroupPro.Text = "txtGroupPre"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(146, 435)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(216, 26)
        Me.txtProductDescription.TabIndex = 178
        Me.txtProductDescription.Text = "txtProuductDescription"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "กลุ่มผลิตภัณฑ์"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "รายละเอียดผลิตภัณฑ์"
        '
        'cbProductType
        '
        Me.cbProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProductType.FormattingEnabled = True
        Me.cbProductType.Location = New System.Drawing.Point(146, 60)
        Me.cbProductType.Name = "cbProductType"
        Me.cbProductType.Size = New System.Drawing.Size(120, 28)
        Me.cbProductType.TabIndex = 175
        Me.cbProductType.Visible = False
        '
        'OptUnEnbled
        '
        Me.OptUnEnbled.AutoSize = True
        Me.OptUnEnbled.BackColor = System.Drawing.SystemColors.Control
        Me.OptUnEnbled.Location = New System.Drawing.Point(141, 52)
        Me.OptUnEnbled.Name = "OptUnEnbled"
        Me.OptUnEnbled.Size = New System.Drawing.Size(115, 24)
        Me.OptUnEnbled.TabIndex = 111
        Me.OptUnEnbled.TabStop = True
        Me.OptUnEnbled.Text = "หยุดการใช้งาน"
        Me.OptUnEnbled.UseVisualStyleBackColor = False
        '
        'OptEnabled
        '
        Me.OptEnabled.AutoSize = True
        Me.OptEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.OptEnabled.Location = New System.Drawing.Point(6, 51)
        Me.OptEnabled.Name = "OptEnabled"
        Me.OptEnabled.Size = New System.Drawing.Size(130, 24)
        Me.OptEnabled.TabIndex = 110
        Me.OptEnabled.TabStop = True
        Me.OptEnabled.Text = "สามารถใช้งานได้"
        Me.OptEnabled.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptEnabled)
        Me.GroupBox1.Controls.Add(Me.OptUnEnbled)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(146, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 38)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'ตั้งค่าสี
        '
        Me.ตั้งค่าสี.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ตั้งค่าสี.Location = New System.Drawing.Point(252, 636)
        Me.ตั้งค่าสี.Name = "ตั้งค่าสี"
        Me.ตั้งค่าสี.Size = New System.Drawing.Size(57, 28)
        Me.ตั้งค่าสี.TabIndex = 184
        Me.ตั้งค่าสี.Text = "ตั้งค่าสี"
        Me.ตั้งค่าสี.UseVisualStyleBackColor = True
        Me.ตั้งค่าสี.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(146, 640)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 24)
        Me.PictureBox2.TabIndex = 183
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'สีผลิตภัณฑ์
        '
        Me.สีผลิตภัณฑ์.AccessibleDescription = "Auto Sort"
        Me.สีผลิตภัณฑ์.AutoSize = True
        Me.สีผลิตภัณฑ์.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.สีผลิตภัณฑ์.Location = New System.Drawing.Point(57, 635)
        Me.สีผลิตภัณฑ์.Name = "สีผลิตภัณฑ์"
        Me.สีผลิตภัณฑ์.Size = New System.Drawing.Size(76, 20)
        Me.สีผลิตภัณฑ์.TabIndex = 182
        Me.สีผลิตภัณฑ์.Text = "สีผลิตภัณฑ์"
        Me.สีผลิตภัณฑ์.Visible = False
        '
        'txtAutoSort
        '
        Me.txtAutoSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAutoSort.Location = New System.Drawing.Point(146, 611)
        Me.txtAutoSort.Name = "txtAutoSort"
        Me.txtAutoSort.Size = New System.Drawing.Size(100, 26)
        Me.txtAutoSort.TabIndex = 181
        Me.txtAutoSort.Text = "txtAutoSort"
        Me.txtAutoSort.Visible = False
        '
        'Label13
        '
        Me.Label13.AccessibleDescription = "Auto Sort"
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(42, 611)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 20)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "Auto Source"
        Me.Label13.Visible = False
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(544, 157)
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
        Me.UcSave1.Location = New System.Drawing.Point(544, 71)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'Txt_GOV_COQ_NO
        '
        Me.Txt_GOV_COQ_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_GOV_COQ_NO.Location = New System.Drawing.Point(146, 497)
        Me.Txt_GOV_COQ_NO.Name = "Txt_GOV_COQ_NO"
        Me.Txt_GOV_COQ_NO.Size = New System.Drawing.Size(296, 26)
        Me.Txt_GOV_COQ_NO.TabIndex = 185
        '
        'Label_GOV_COQ_NO
        '
        Me.Label_GOV_COQ_NO.AutoSize = True
        Me.Label_GOV_COQ_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_GOV_COQ_NO.Location = New System.Drawing.Point(18, 501)
        Me.Label_GOV_COQ_NO.Name = "Label_GOV_COQ_NO"
        Me.Label_GOV_COQ_NO.Size = New System.Drawing.Size(121, 20)
        Me.Label_GOV_COQ_NO.TabIndex = 186
        Me.Label_GOV_COQ_NO.Text = "GOV_COQ_NO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 527)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 20)
        Me.Label15.TabIndex = 187
        Me.Label15.Text = "GOV_COQ_DATE"
        '
        'txtGOV_COQ_DATE
        '
        Me.txtGOV_COQ_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGOV_COQ_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtGOV_COQ_DATE.Location = New System.Drawing.Point(146, 526)
        Me.txtGOV_COQ_DATE.Name = "txtGOV_COQ_DATE"
        Me.txtGOV_COQ_DATE.Size = New System.Drawing.Size(296, 26)
        Me.txtGOV_COQ_DATE.TabIndex = 188
        Me.txtGOV_COQ_DATE.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'frmConfigSaleProduct_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 669)
        Me.Controls.Add(Me.txtGOV_COQ_DATE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label_GOV_COQ_NO)
        Me.Controls.Add(Me.Txt_GOV_COQ_NO)
        Me.Controls.Add(Me.ตั้งค่าสี)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.สีผลิตภัณฑ์)
        Me.Controls.Add(Me.txtAutoSort)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtGroupPro)
        Me.Controls.Add(Me.txtProductDescription)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbProductType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cbBaseProduct)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cbSaleUnit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMapOilsys)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigSaleProduct_sub"
        Me.Text = "frmConfigBay_sub"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OptUnCheckWeight As System.Windows.Forms.RadioButton
    Friend WithEvents OptCheckWeight As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptDoNotLoadMeter As System.Windows.Forms.RadioButton
    Friend WithEvents OptLoadMeter As System.Windows.Forms.RadioButton
    Friend WithEvents cbBaseProduct As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptUnLoad As System.Windows.Forms.RadioButton
    Friend WithEvents OptLoaded As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents OptUnWeight As System.Windows.Forms.RadioButton
    Friend WithEvents OptWeight As System.Windows.Forms.RadioButton
    Friend WithEvents cbSaleUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMapOilsys As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents txtGroupPro As System.Windows.Forms.TextBox
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbProductType As System.Windows.Forms.ComboBox
    Friend WithEvents OptUnEnbled As System.Windows.Forms.RadioButton
    Friend WithEvents OptEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ตั้งค่าสี As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents สีผลิตภัณฑ์ As System.Windows.Forms.Label
    Friend WithEvents txtAutoSort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_GOV_COQ_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label_GOV_COQ_NO As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGOV_COQ_DATE As System.Windows.Forms.DateTimePicker
End Class
