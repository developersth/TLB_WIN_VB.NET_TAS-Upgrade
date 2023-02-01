<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainVehicle_sub
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
        Me.OptUnEnbled = New System.Windows.Forms.RadioButton()
        Me.OptEnabled = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btTruckType = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSearchTruck = New System.Windows.Forms.Button()
        Me.cmdSearchTail = New System.Windows.Forms.Button()
        Me.cmbSearchCarrier = New System.Windows.Forms.Button()
        Me.DTPdateExprie = New System.Windows.Forms.DateTimePicker()
        Me.txtTareWeight = New System.Windows.Forms.TextBox()
        Me.txtSeal = New System.Windows.Forms.TextBox()
        Me.cbCarrier = New System.Windows.Forms.ComboBox()
        Me.cbTruck = New System.Windows.Forms.ComboBox()
        Me.cbVehicle = New System.Windows.Forms.ComboBox()
        Me.cbKind = New System.Windows.Forms.ComboBox()
        Me.txtTruckName = New System.Windows.Forms.TextBox()
        Me.cbTruckType = New System.Windows.Forms.ComboBox()
        Me.txtTruckID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.OptFind3 = New System.Windows.Forms.RadioButton()
        Me.OptFind2 = New System.Windows.Forms.RadioButton()
        Me.OptFind1 = New System.Windows.Forms.RadioButton()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.btCountWeight = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Enabled = False
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(176, 389)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 392)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 20)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "วัน-เวลาที่แก้ไขล่าสุด"
        '
        'txtLastUpdateBy
        '
        Me.txtLastUpdateBy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateBy.Enabled = False
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(176, 421)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(82, 422)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptUnEnbled)
        Me.GroupBox1.Controls.Add(Me.OptEnabled)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 63)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'OptUnEnbled
        '
        Me.OptUnEnbled.AutoSize = True
        Me.OptUnEnbled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OptUnEnbled.Location = New System.Drawing.Point(6, 34)
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
        Me.OptEnabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OptEnabled.Location = New System.Drawing.Point(6, 14)
        Me.OptEnabled.Name = "OptEnabled"
        Me.OptEnabled.Size = New System.Drawing.Size(130, 24)
        Me.OptEnabled.TabIndex = 112
        Me.OptEnabled.TabStop = True
        Me.OptEnabled.Text = "สามารถใช้งานได้"
        Me.OptEnabled.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "สถานะการใช้งาน"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(25, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(605, 528)
        Me.TabControl1.TabIndex = 153
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btCountWeight)
        Me.TabPage1.Controls.Add(Me.btTruckType)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmdSearchTruck)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cmdSearchTail)
        Me.TabPage1.Controls.Add(Me.txtLastUpdateBy)
        Me.TabPage1.Controls.Add(Me.cmbSearchCarrier)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DTPdateExprie)
        Me.TabPage1.Controls.Add(Me.txtLastUpdateDate)
        Me.TabPage1.Controls.Add(Me.txtTareWeight)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtSeal)
        Me.TabPage1.Controls.Add(Me.cbCarrier)
        Me.TabPage1.Controls.Add(Me.cbTruck)
        Me.TabPage1.Controls.Add(Me.cbVehicle)
        Me.TabPage1.Controls.Add(Me.cbKind)
        Me.TabPage1.Controls.Add(Me.txtTruckName)
        Me.TabPage1.Controls.Add(Me.cbTruckType)
        Me.TabPage1.Controls.Add(Me.txtTruckID)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(597, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehicle"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btTruckType
        '
        Me.btTruckType.Location = New System.Drawing.Point(335, 182)
        Me.btTruckType.Name = "btTruckType"
        Me.btTruckType.Size = New System.Drawing.Size(121, 32)
        Me.btTruckType.TabIndex = 182
        Me.btTruckType.Text = "เพิ่มประเภทรถ"
        Me.btTruckType.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(154, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(155, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(153, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "*"
        '
        'cmdSearchTruck
        '
        Me.cmdSearchTruck.Location = New System.Drawing.Point(335, 109)
        Me.cmdSearchTruck.Name = "cmdSearchTruck"
        Me.cmdSearchTruck.Size = New System.Drawing.Size(30, 29)
        Me.cmdSearchTruck.TabIndex = 142
        Me.cmdSearchTruck.Text = "..."
        Me.cmdSearchTruck.UseVisualStyleBackColor = True
        '
        'cmdSearchTail
        '
        Me.cmdSearchTail.Location = New System.Drawing.Point(335, 147)
        Me.cmdSearchTail.Name = "cmdSearchTail"
        Me.cmdSearchTail.Size = New System.Drawing.Size(30, 28)
        Me.cmdSearchTail.TabIndex = 141
        Me.cmdSearchTail.Text = "..."
        Me.cmdSearchTail.UseVisualStyleBackColor = True
        '
        'cmbSearchCarrier
        '
        Me.cmbSearchCarrier.Location = New System.Drawing.Point(435, 220)
        Me.cmbSearchCarrier.Name = "cmbSearchCarrier"
        Me.cmbSearchCarrier.Size = New System.Drawing.Size(30, 28)
        Me.cmbSearchCarrier.TabIndex = 73
        Me.cmbSearchCarrier.Text = "..."
        Me.cmbSearchCarrier.UseVisualStyleBackColor = True
        '
        'DTPdateExprie
        '
        Me.DTPdateExprie.Location = New System.Drawing.Point(176, 256)
        Me.DTPdateExprie.Name = "DTPdateExprie"
        Me.DTPdateExprie.Size = New System.Drawing.Size(170, 26)
        Me.DTPdateExprie.TabIndex = 20
        '
        'txtTareWeight
        '
        Me.txtTareWeight.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTareWeight.Location = New System.Drawing.Point(176, 357)
        Me.txtTareWeight.Name = "txtTareWeight"
        Me.txtTareWeight.Size = New System.Drawing.Size(121, 26)
        Me.txtTareWeight.TabIndex = 19
        '
        'txtSeal
        '
        Me.txtSeal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSeal.Enabled = False
        Me.txtSeal.Location = New System.Drawing.Point(175, 458)
        Me.txtSeal.Name = "txtSeal"
        Me.txtSeal.Size = New System.Drawing.Size(121, 26)
        Me.txtSeal.TabIndex = 18
        Me.txtSeal.Visible = False
        '
        'cbCarrier
        '
        Me.cbCarrier.FormattingEnabled = True
        Me.cbCarrier.Location = New System.Drawing.Point(176, 220)
        Me.cbCarrier.Name = "cbCarrier"
        Me.cbCarrier.Size = New System.Drawing.Size(251, 28)
        Me.cbCarrier.TabIndex = 17
        '
        'cbTruck
        '
        Me.cbTruck.FormattingEnabled = True
        Me.cbTruck.Location = New System.Drawing.Point(174, 110)
        Me.cbTruck.Name = "cbTruck"
        Me.cbTruck.Size = New System.Drawing.Size(155, 28)
        Me.cbTruck.TabIndex = 16
        '
        'cbVehicle
        '
        Me.cbVehicle.FormattingEnabled = True
        Me.cbVehicle.Location = New System.Drawing.Point(174, 147)
        Me.cbVehicle.Name = "cbVehicle"
        Me.cbVehicle.Size = New System.Drawing.Size(155, 28)
        Me.cbVehicle.TabIndex = 15
        '
        'cbKind
        '
        Me.cbKind.FormattingEnabled = True
        Me.cbKind.Location = New System.Drawing.Point(174, 73)
        Me.cbKind.Name = "cbKind"
        Me.cbKind.Size = New System.Drawing.Size(132, 28)
        Me.cbKind.TabIndex = 14
        '
        'txtTruckName
        '
        Me.txtTruckName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTruckName.Location = New System.Drawing.Point(175, 41)
        Me.txtTruckName.Name = "txtTruckName"
        Me.txtTruckName.Size = New System.Drawing.Size(154, 26)
        Me.txtTruckName.TabIndex = 13
        Me.txtTruckName.Text = "txtTruckNa"
        '
        'cbTruckType
        '
        Me.cbTruckType.FormattingEnabled = True
        Me.cbTruckType.Location = New System.Drawing.Point(175, 183)
        Me.cbTruckType.Name = "cbTruckType"
        Me.cbTruckType.Size = New System.Drawing.Size(154, 28)
        Me.cbTruckType.TabIndex = 12
        '
        'txtTruckID
        '
        Me.txtTruckID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTruckID.Location = New System.Drawing.Point(175, 8)
        Me.txtTruckID.Name = "txtTruckID"
        Me.txtTruckID.Size = New System.Drawing.Size(154, 26)
        Me.txtTruckID.TabIndex = 11
        Me.txtTruckID.Text = "txtTruck"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "KG"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "วันวัดน้ำหมดอายุ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "น้ำหนักรถรวม"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "จำนวน ซีล"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ผู้ขนส่ง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ชนิดรถ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "รถตัวพ่วง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รถตัวลาก"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "ประเภทรถ(SAP)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(78, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 20)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "ทะเบียนรถ"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(106, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "รหัสรถ"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdDelete)
        Me.TabPage2.Controls.Add(Me.cmdAdd)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "พนักงานขับรถ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(506, 269)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 30)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "ลบชื่อ พขร."
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(415, 268)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 31)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "เพิ่มชื่อ พขร."
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(588, 157)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายชื่อ พขร. ที่สามารถขับรถได้"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView2.Location = New System.Drawing.Point(7, 17)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(575, 134)
        Me.DataGridView2.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.HeaderText = "รหัส พขร"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "รหัสอ้างอิง"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "ชื่อ-นามสกุล"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายชื่อ พขร. ทั้งหมด"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(575, 117)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส พขร."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "รหัสอ้างอิง"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชื่อ-นามสกุล"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 180
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.OptFind3)
        Me.GroupBox4.Controls.Add(Me.OptFind2)
        Me.GroupBox4.Controls.Add(Me.OptFind1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 107)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ค้นหาจาก"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(133, 54)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 26)
        Me.txtSearch.TabIndex = 3
        '
        'OptFind3
        '
        Me.OptFind3.AutoSize = True
        Me.OptFind3.Location = New System.Drawing.Point(27, 77)
        Me.OptFind3.Name = "OptFind3"
        Me.OptFind3.Size = New System.Drawing.Size(105, 24)
        Me.OptFind3.TabIndex = 2
        Me.OptFind3.TabStop = True
        Me.OptFind3.Text = "แสดงทั้งหมด"
        Me.OptFind3.UseVisualStyleBackColor = True
        '
        'OptFind2
        '
        Me.OptFind2.AutoSize = True
        Me.OptFind2.Location = New System.Drawing.Point(27, 54)
        Me.OptFind2.Name = "OptFind2"
        Me.OptFind2.Size = New System.Drawing.Size(88, 24)
        Me.OptFind2.TabIndex = 1
        Me.OptFind2.TabStop = True
        Me.OptFind2.Text = "รหัสอ้างอิง"
        Me.OptFind2.UseVisualStyleBackColor = True
        '
        'OptFind1
        '
        Me.OptFind1.AutoSize = True
        Me.OptFind1.Location = New System.Drawing.Point(27, 31)
        Me.OptFind1.Name = "OptFind1"
        Me.OptFind1.Size = New System.Drawing.Size(74, 24)
        Me.OptFind1.TabIndex = 0
        Me.OptFind1.TabStop = True
        Me.OptFind1.Text = "ชื่อ-สกุล"
        Me.OptFind1.UseVisualStyleBackColor = True
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(653, 210)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(72, 90)
        Me.UcCancel1.TabIndex = 155
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(653, 104)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 95)
        Me.UcSave1.TabIndex = 154
        '
        'btCountWeight
        '
        Me.btCountWeight.BackColor = System.Drawing.Color.Lime
        Me.btCountWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCountWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCountWeight.Location = New System.Drawing.Point(349, 355)
        Me.btCountWeight.Name = "btCountWeight"
        Me.btCountWeight.Size = New System.Drawing.Size(141, 28)
        Me.btCountWeight.TabIndex = 183
        Me.btCountWeight.Text = "คำนวณน้ำหนักรถ"
        Me.btCountWeight.UseVisualStyleBackColor = False
        '
        'frmMainVehicle_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 641)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainVehicle_sub"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptUnEnbled As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdSearchTruck As System.Windows.Forms.Button
    Friend WithEvents cmdSearchTail As System.Windows.Forms.Button
    Friend WithEvents cmbSearchCarrier As System.Windows.Forms.Button
    Friend WithEvents DTPdateExprie As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSeal As System.Windows.Forms.TextBox
    Friend WithEvents cbCarrier As System.Windows.Forms.ComboBox
    Friend WithEvents cbTruck As System.Windows.Forms.ComboBox
    Friend WithEvents cbVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents cbKind As System.Windows.Forms.ComboBox
    Friend WithEvents txtTruckName As System.Windows.Forms.TextBox
    Friend WithEvents cbTruckType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTruckID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents OptFind3 As System.Windows.Forms.RadioButton
    Friend WithEvents OptFind2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptFind1 As System.Windows.Forms.RadioButton
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents OptEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btTruckType As System.Windows.Forms.Button
    Friend WithEvents txtTareWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btCountWeight As System.Windows.Forms.Button
End Class
