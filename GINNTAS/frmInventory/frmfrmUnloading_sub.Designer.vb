<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfrmUnloading_sub
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbUnloadType = New System.Windows.Forms.ComboBox()
        Me.txtLastUpdateBy = New System.Windows.Forms.TextBox()
        Me.txtLastUpdateDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransportUnit = New System.Windows.Forms.TextBox()
        Me.txtFromPlant = New System.Windows.Forms.TextBox()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.txtTempSch = New System.Windows.Forms.TextBox()
        Me.txtAPISch = New System.Windows.Forms.TextBox()
        Me.txtTempToPlant = New System.Windows.Forms.TextBox()
        Me.txtAPIToPlant = New System.Windows.Forms.TextBox()
        Me.txtSchGrsQty = New System.Windows.Forms.TextBox()
        Me.txtSchNetQty = New System.Windows.Forms.TextBox()
        Me.txtToPlantGrsQty = New System.Windows.Forms.TextBox()
        Me.txtToPlantNetQty = New System.Windows.Forms.TextBox()
        Me.txtUnloadGrsQty = New System.Windows.Forms.TextBox()
        Me.txtUnloadNetQty = New System.Windows.Forms.TextBox()
        Me.dtpStartUnload = New System.Windows.Forms.DateTimePicker()
        Me.dtpStopUnload = New System.Windows.Forms.DateTimePicker()
        Me.txtReferance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbTankReceive = New System.Windows.Forms.ComboBox()
        Me.DTPTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.DTPTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "ประเภทการรับ"
        '
        'cbUnloadType
        '
        Me.cbUnloadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnloadType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbUnloadType.FormattingEnabled = True
        Me.cbUnloadType.Location = New System.Drawing.Point(189, 94)
        Me.cbUnloadType.Name = "cbUnloadType"
        Me.cbUnloadType.Size = New System.Drawing.Size(172, 28)
        Me.cbUnloadType.TabIndex = 112
        '
        'txtLastUpdateBy
        '
        Me.txtLastUpdateBy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateBy.Enabled = False
        Me.txtLastUpdateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(188, 576)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 105
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Enabled = False
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(188, 547)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 104
        Me.txtLastUpdateDate.Text = "txtLastUpdateDate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 576)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "แก้ไขโดย"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 547)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 20)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "วัน-เวลาที่แก้ไขล่าสุด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "หมายเลขตั๋วรับ"
        '
        'txtTransportUnit
        '
        Me.txtTransportUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTransportUnit.Location = New System.Drawing.Point(189, 128)
        Me.txtTransportUnit.Name = "txtTransportUnit"
        Me.txtTransportUnit.Size = New System.Drawing.Size(172, 26)
        Me.txtTransportUnit.TabIndex = 124
        Me.txtTransportUnit.Text = "txtTransportUnit"
        '
        'txtFromPlant
        '
        Me.txtFromPlant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFromPlant.Location = New System.Drawing.Point(189, 199)
        Me.txtFromPlant.Name = "txtFromPlant"
        Me.txtFromPlant.Size = New System.Drawing.Size(172, 26)
        Me.txtFromPlant.TabIndex = 125
        Me.txtFromPlant.Text = "txtFromPlant"
        '
        'cbProduct
        '
        Me.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(189, 163)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(172, 28)
        Me.cbProduct.TabIndex = 127
        '
        'txtTempSch
        '
        Me.txtTempSch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTempSch.Location = New System.Drawing.Point(189, 272)
        Me.txtTempSch.Name = "txtTempSch"
        Me.txtTempSch.Size = New System.Drawing.Size(103, 26)
        Me.txtTempSch.TabIndex = 128
        Me.txtTempSch.Text = "txtTempSch"
        '
        'txtAPISch
        '
        Me.txtAPISch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAPISch.Location = New System.Drawing.Point(349, 272)
        Me.txtAPISch.Name = "txtAPISch"
        Me.txtAPISch.Size = New System.Drawing.Size(103, 26)
        Me.txtAPISch.TabIndex = 129
        Me.txtAPISch.Text = "txtAPISch"
        '
        'txtTempToPlant
        '
        Me.txtTempToPlant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTempToPlant.Location = New System.Drawing.Point(189, 304)
        Me.txtTempToPlant.Name = "txtTempToPlant"
        Me.txtTempToPlant.Size = New System.Drawing.Size(103, 26)
        Me.txtTempToPlant.TabIndex = 130
        Me.txtTempToPlant.Text = "txtTempToPlant"
        '
        'txtAPIToPlant
        '
        Me.txtAPIToPlant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAPIToPlant.Location = New System.Drawing.Point(349, 304)
        Me.txtAPIToPlant.Name = "txtAPIToPlant"
        Me.txtAPIToPlant.Size = New System.Drawing.Size(103, 26)
        Me.txtAPIToPlant.TabIndex = 131
        Me.txtAPIToPlant.Text = "txtAPIToPlant"
        '
        'txtSchGrsQty
        '
        Me.txtSchGrsQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSchGrsQty.Location = New System.Drawing.Point(189, 348)
        Me.txtSchGrsQty.Name = "txtSchGrsQty"
        Me.txtSchGrsQty.Size = New System.Drawing.Size(133, 26)
        Me.txtSchGrsQty.TabIndex = 132
        Me.txtSchGrsQty.Text = "txtSchGrsQty"
        '
        'txtSchNetQty
        '
        Me.txtSchNetQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSchNetQty.Location = New System.Drawing.Point(385, 348)
        Me.txtSchNetQty.Name = "txtSchNetQty"
        Me.txtSchNetQty.Size = New System.Drawing.Size(133, 26)
        Me.txtSchNetQty.TabIndex = 133
        Me.txtSchNetQty.Text = "txtSchNetQty"
        '
        'txtToPlantGrsQty
        '
        Me.txtToPlantGrsQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtToPlantGrsQty.Location = New System.Drawing.Point(189, 380)
        Me.txtToPlantGrsQty.Name = "txtToPlantGrsQty"
        Me.txtToPlantGrsQty.Size = New System.Drawing.Size(133, 26)
        Me.txtToPlantGrsQty.TabIndex = 134
        Me.txtToPlantGrsQty.Text = "txtToPlantGrsQty"
        '
        'txtToPlantNetQty
        '
        Me.txtToPlantNetQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtToPlantNetQty.Location = New System.Drawing.Point(385, 380)
        Me.txtToPlantNetQty.Name = "txtToPlantNetQty"
        Me.txtToPlantNetQty.Size = New System.Drawing.Size(133, 26)
        Me.txtToPlantNetQty.TabIndex = 135
        Me.txtToPlantNetQty.Text = "txtToPlantNetQty"
        '
        'txtUnloadGrsQty
        '
        Me.txtUnloadGrsQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnloadGrsQty.Location = New System.Drawing.Point(189, 413)
        Me.txtUnloadGrsQty.Name = "txtUnloadGrsQty"
        Me.txtUnloadGrsQty.Size = New System.Drawing.Size(133, 26)
        Me.txtUnloadGrsQty.TabIndex = 136
        Me.txtUnloadGrsQty.Text = "txtUnloadGrsQty"
        '
        'txtUnloadNetQty
        '
        Me.txtUnloadNetQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnloadNetQty.Location = New System.Drawing.Point(385, 413)
        Me.txtUnloadNetQty.Name = "txtUnloadNetQty"
        Me.txtUnloadNetQty.Size = New System.Drawing.Size(133, 26)
        Me.txtUnloadNetQty.TabIndex = 137
        Me.txtUnloadNetQty.Text = "txtUnloadNetQty"
        '
        'dtpStartUnload
        '
        Me.dtpStartUnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpStartUnload.Location = New System.Drawing.Point(189, 450)
        Me.dtpStartUnload.Name = "dtpStartUnload"
        Me.dtpStartUnload.Size = New System.Drawing.Size(199, 26)
        Me.dtpStartUnload.TabIndex = 138
        '
        'dtpStopUnload
        '
        Me.dtpStopUnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpStopUnload.Location = New System.Drawing.Point(188, 483)
        Me.dtpStopUnload.Name = "dtpStopUnload"
        Me.dtpStopUnload.Size = New System.Drawing.Size(200, 26)
        Me.dtpStopUnload.TabIndex = 139
        '
        'txtReferance
        '
        Me.txtReferance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReferance.Location = New System.Drawing.Point(188, 514)
        Me.txtReferance.Name = "txtReferance"
        Me.txtReferance.Size = New System.Drawing.Size(323, 26)
        Me.txtReferance.TabIndex = 140
        Me.txtReferance.Text = "txtReferance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "หมายเลขรถ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "ผลิตภัณฑ์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "รับจากคลัง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "ถังรับ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "อุณหภูมิต้นทาง"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "อุณหภูมิปลายทาง"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 20)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "ปริมาณต้นทาง(Gross)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 20)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "ปริมาณที่มาถึงคลัง(Gross)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 20)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "ปริมาณที่รับได้จริง(Gross)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(91, 455)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 20)
        Me.Label14.TabIndex = 150
        Me.Label14.Text = "เวลาที่เริ่มรับ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(88, 488)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 151
        Me.Label15.Text = "เวลาที่รับเสร็จ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(80, 517)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "ประเภทการรับ"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(292, 275)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 20)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "ค่า API"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(292, 307)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 20)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "ค่า API"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(325, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 20)
        Me.Label19.TabIndex = 155
        Me.Label19.Text = "ค่า Net"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(325, 380)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 20)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "ค่า Net"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(325, 413)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 20)
        Me.Label21.TabIndex = 157
        Me.Label21.Text = "ค่า Net"
        '
        'cbTankReceive
        '
        Me.cbTankReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTankReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTankReceive.FormattingEnabled = True
        Me.cbTankReceive.Location = New System.Drawing.Point(188, 234)
        Me.cbTankReceive.Name = "cbTankReceive"
        Me.cbTankReceive.Size = New System.Drawing.Size(172, 28)
        Me.cbTankReceive.TabIndex = 158
        '
        'DTPTimeStart
        '
        Me.DTPTimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeStart.Location = New System.Drawing.Point(394, 450)
        Me.DTPTimeStart.Name = "DTPTimeStart"
        Me.DTPTimeStart.ShowUpDown = True
        Me.DTPTimeStart.Size = New System.Drawing.Size(90, 26)
        Me.DTPTimeStart.TabIndex = 159
        Me.DTPTimeStart.Value = New Date(2014, 11, 16, 1, 0, 0, 0)
        '
        'DTPTimeEnd
        '
        Me.DTPTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeEnd.Location = New System.Drawing.Point(394, 483)
        Me.DTPTimeEnd.Name = "DTPTimeEnd"
        Me.DTPTimeEnd.ShowUpDown = True
        Me.DTPTimeEnd.Size = New System.Drawing.Size(90, 26)
        Me.DTPTimeEnd.TabIndex = 160
        Me.DTPTimeEnd.Value = New Date(2015, 4, 10, 22, 0, 0, 0)
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(188, 60)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(172, 26)
        Me.txtReceiptNo.TabIndex = 161
        Me.txtReceiptNo.Text = "txtReceiptNo"
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcCancel1.Location = New System.Drawing.Point(505, 160)
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
        Me.UcSave1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcSave1.Location = New System.Drawing.Point(505, 62)
        Me.UcSave1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'frmfrmUnloading_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 631)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.DTPTimeEnd)
        Me.Controls.Add(Me.DTPTimeStart)
        Me.Controls.Add(Me.cbTankReceive)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReferance)
        Me.Controls.Add(Me.dtpStopUnload)
        Me.Controls.Add(Me.dtpStartUnload)
        Me.Controls.Add(Me.txtUnloadNetQty)
        Me.Controls.Add(Me.txtUnloadGrsQty)
        Me.Controls.Add(Me.txtToPlantNetQty)
        Me.Controls.Add(Me.txtToPlantGrsQty)
        Me.Controls.Add(Me.txtSchNetQty)
        Me.Controls.Add(Me.txtSchGrsQty)
        Me.Controls.Add(Me.txtAPIToPlant)
        Me.Controls.Add(Me.txtTempToPlant)
        Me.Controls.Add(Me.txtAPISch)
        Me.Controls.Add(Me.txtTempSch)
        Me.Controls.Add(Me.cbProduct)
        Me.Controls.Add(Me.txtFromPlant)
        Me.Controls.Add(Me.txtTransportUnit)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbUnloadType)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmfrmUnloading_sub"
        Me.Text = "frmConfigBay_sub"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtTransportUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtFromPlant As System.Windows.Forms.TextBox
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtTempSch As System.Windows.Forms.TextBox
    Friend WithEvents txtAPISch As System.Windows.Forms.TextBox
    Friend WithEvents txtTempToPlant As System.Windows.Forms.TextBox
    Friend WithEvents txtAPIToPlant As System.Windows.Forms.TextBox
    Friend WithEvents txtSchGrsQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSchNetQty As System.Windows.Forms.TextBox
    Friend WithEvents txtToPlantGrsQty As System.Windows.Forms.TextBox
    Friend WithEvents txtToPlantNetQty As System.Windows.Forms.TextBox
    Friend WithEvents txtUnloadGrsQty As System.Windows.Forms.TextBox
    Friend WithEvents txtUnloadNetQty As System.Windows.Forms.TextBox
    Friend WithEvents dtpStartUnload As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStopUnload As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReferance As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbTankReceive As System.Windows.Forms.ComboBox
    Friend WithEvents DTPTimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReceiptNo As System.Windows.Forms.TextBox
End Class
