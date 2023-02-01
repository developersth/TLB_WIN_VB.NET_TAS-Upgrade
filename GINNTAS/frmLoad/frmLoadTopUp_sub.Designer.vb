<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadTopUp_sub
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
        Me.b_clear = New System.Windows.Forms.Button()
        Me.PickerDate_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCardTu = New System.Windows.Forms.TextBox()
        Me.txtTuid = New System.Windows.Forms.TextBox()
        Me.txtPreset = New System.Windows.Forms.TextBox()
        Me.txtTuid1 = New System.Windows.Forms.TextBox()
        Me.txtDriverID = New System.Windows.Forms.TextBox()
        Me.txtvehicletype = New System.Windows.Forms.TextBox()
        Me.txtCarrierID = New System.Windows.Forms.TextBox()
        Me.txtCarrierName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtShipToID = New System.Windows.Forms.TextBox()
        Me.txtShipToName = New System.Windows.Forms.TextBox()
        Me.txtDriverName = New System.Windows.Forms.TextBox()
        Me.txtvehicle = New System.Windows.Forms.TextBox()
        Me.CmdFindTruck = New System.Windows.Forms.Button()
        Me.CmdFindShipto = New System.Windows.Forms.Button()
        Me.CmdFindCustomer = New System.Windows.Forms.Button()
        Me.CmdFindCarrier = New System.Windows.Forms.Button()
        Me.CmdFindVehicle = New System.Windows.Forms.Button()
        Me.CmdFindDriver = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.CbLoadNo = New System.Windows.Forms.ComboBox()
        Me.CbShipmentNo = New System.Windows.Forms.ComboBox()
        Me.CbDono = New System.Windows.Forms.ComboBox()
        Me.CbCompartment = New System.Windows.Forms.ComboBox()
        Me.CbSProductName = New System.Windows.Forms.ComboBox()
        Me.CbBayName = New System.Windows.Forms.ComboBox()
        Me.CbMeterName = New System.Windows.Forms.ComboBox()
        Me.SelProduct_Name = New System.Windows.Forms.ComboBox()
        Me.txtLoadTopUpNo = New System.Windows.Forms.TextBox()
        Me.btCancle = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'b_clear
        '
        Me.b_clear.BackColor = System.Drawing.Color.White
        Me.b_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_clear.Location = New System.Drawing.Point(868, 471)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(94, 40)
        Me.b_clear.TabIndex = 2
        Me.b_clear.Text = "CLEAR"
        Me.b_clear.UseVisualStyleBackColor = False
        '
        'PickerDate_Start
        '
        Me.PickerDate_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PickerDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PickerDate_Start.Location = New System.Drawing.Point(147, 68)
        Me.PickerDate_Start.Name = "PickerDate_Start"
        Me.PickerDate_Start.Size = New System.Drawing.Size(163, 22)
        Me.PickerDate_Start.TabIndex = 91
        Me.PickerDate_Start.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "วัน/เดือน/ปี : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Load Topup No : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "หมายเลข Load : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Shipment No : "
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "DO No : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "ช่องเติม : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "ชื่อผลิตภัณฑ์ : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "ช่องจ่าย : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "ชื่อมิเตอร์ : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Preset : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(61, 399)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 18)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "หมายเหตุ : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(487, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "เลขบัตร : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 18)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "เลขทะเบียน : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(449, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 18)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "รหัส/ชื่อ พขร. : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 159)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 18)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Vehicle Type : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(464, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Carrier ID : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(475, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 18)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "ชื่อผู้ขนส่ง : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(738, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 18)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Vehicle : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(442, 249)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 18)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Customer ID : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(485, 279)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 18)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "ชื่อลูกค้า : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(457, 309)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 18)
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "Ship To ID : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(475, 339)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 18)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "สถานที่ส่ง : "
        '
        'txtCardTu
        '
        Me.txtCardTu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCardTu.Location = New System.Drawing.Point(566, 70)
        Me.txtCardTu.Name = "txtCardTu"
        Me.txtCardTu.Size = New System.Drawing.Size(156, 22)
        Me.txtCardTu.TabIndex = 114
        '
        'txtTuid
        '
        Me.txtTuid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuid.Location = New System.Drawing.Point(566, 100)
        Me.txtTuid.Name = "txtTuid"
        Me.txtTuid.Size = New System.Drawing.Size(156, 22)
        Me.txtTuid.TabIndex = 115
        '
        'txtPreset
        '
        Me.txtPreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPreset.Location = New System.Drawing.Point(147, 338)
        Me.txtPreset.Name = "txtPreset"
        Me.txtPreset.Size = New System.Drawing.Size(279, 22)
        Me.txtPreset.TabIndex = 116
        '
        'txtTuid1
        '
        Me.txtTuid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuid1.Location = New System.Drawing.Point(741, 100)
        Me.txtTuid1.Name = "txtTuid1"
        Me.txtTuid1.Size = New System.Drawing.Size(156, 22)
        Me.txtTuid1.TabIndex = 117
        '
        'txtDriverID
        '
        Me.txtDriverID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriverID.Location = New System.Drawing.Point(566, 130)
        Me.txtDriverID.Name = "txtDriverID"
        Me.txtDriverID.Size = New System.Drawing.Size(125, 22)
        Me.txtDriverID.TabIndex = 118
        '
        'txtvehicletype
        '
        Me.txtvehicletype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtvehicletype.Location = New System.Drawing.Point(566, 160)
        Me.txtvehicletype.Name = "txtvehicletype"
        Me.txtvehicletype.Size = New System.Drawing.Size(125, 22)
        Me.txtvehicletype.TabIndex = 119
        '
        'txtCarrierID
        '
        Me.txtCarrierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCarrierID.Location = New System.Drawing.Point(566, 190)
        Me.txtCarrierID.Name = "txtCarrierID"
        Me.txtCarrierID.Size = New System.Drawing.Size(156, 22)
        Me.txtCarrierID.TabIndex = 120
        '
        'txtCarrierName
        '
        Me.txtCarrierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCarrierName.Location = New System.Drawing.Point(566, 220)
        Me.txtCarrierName.Name = "txtCarrierName"
        Me.txtCarrierName.Size = New System.Drawing.Size(382, 22)
        Me.txtCarrierName.TabIndex = 121
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(566, 250)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(156, 22)
        Me.txtCustomerID.TabIndex = 122
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(566, 280)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(382, 22)
        Me.txtCustomerName.TabIndex = 123
        '
        'txtShipToID
        '
        Me.txtShipToID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShipToID.Location = New System.Drawing.Point(566, 310)
        Me.txtShipToID.Name = "txtShipToID"
        Me.txtShipToID.Size = New System.Drawing.Size(156, 22)
        Me.txtShipToID.TabIndex = 124
        '
        'txtShipToName
        '
        Me.txtShipToName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShipToName.Location = New System.Drawing.Point(566, 340)
        Me.txtShipToName.Name = "txtShipToName"
        Me.txtShipToName.Size = New System.Drawing.Size(382, 22)
        Me.txtShipToName.TabIndex = 125
        '
        'txtDriverName
        '
        Me.txtDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(741, 132)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(186, 22)
        Me.txtDriverName.TabIndex = 126
        '
        'txtvehicle
        '
        Me.txtvehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtvehicle.Location = New System.Drawing.Point(811, 162)
        Me.txtvehicle.Name = "txtvehicle"
        Me.txtvehicle.Size = New System.Drawing.Size(137, 22)
        Me.txtvehicle.TabIndex = 127
        '
        'CmdFindTruck
        '
        Me.CmdFindTruck.Location = New System.Drawing.Point(728, 70)
        Me.CmdFindTruck.Name = "CmdFindTruck"
        Me.CmdFindTruck.Size = New System.Drawing.Size(34, 22)
        Me.CmdFindTruck.TabIndex = 128
        Me.CmdFindTruck.Text = ">>"
        Me.CmdFindTruck.UseVisualStyleBackColor = True
        '
        'CmdFindShipto
        '
        Me.CmdFindShipto.Location = New System.Drawing.Point(728, 309)
        Me.CmdFindShipto.Name = "CmdFindShipto"
        Me.CmdFindShipto.Size = New System.Drawing.Size(34, 21)
        Me.CmdFindShipto.TabIndex = 129
        Me.CmdFindShipto.Text = ">>"
        Me.CmdFindShipto.UseVisualStyleBackColor = True
        '
        'CmdFindCustomer
        '
        Me.CmdFindCustomer.Location = New System.Drawing.Point(728, 251)
        Me.CmdFindCustomer.Name = "CmdFindCustomer"
        Me.CmdFindCustomer.Size = New System.Drawing.Size(34, 21)
        Me.CmdFindCustomer.TabIndex = 130
        Me.CmdFindCustomer.Text = ">>"
        Me.CmdFindCustomer.UseVisualStyleBackColor = True
        '
        'CmdFindCarrier
        '
        Me.CmdFindCarrier.Location = New System.Drawing.Point(728, 191)
        Me.CmdFindCarrier.Name = "CmdFindCarrier"
        Me.CmdFindCarrier.Size = New System.Drawing.Size(34, 21)
        Me.CmdFindCarrier.TabIndex = 131
        Me.CmdFindCarrier.Text = ">>"
        Me.CmdFindCarrier.UseVisualStyleBackColor = True
        '
        'CmdFindVehicle
        '
        Me.CmdFindVehicle.Location = New System.Drawing.Point(697, 155)
        Me.CmdFindVehicle.Name = "CmdFindVehicle"
        Me.CmdFindVehicle.Size = New System.Drawing.Size(34, 24)
        Me.CmdFindVehicle.TabIndex = 132
        Me.CmdFindVehicle.Text = ">>"
        Me.CmdFindVehicle.UseVisualStyleBackColor = True
        '
        'CmdFindDriver
        '
        Me.CmdFindDriver.Location = New System.Drawing.Point(697, 130)
        Me.CmdFindDriver.Name = "CmdFindDriver"
        Me.CmdFindDriver.Size = New System.Drawing.Size(34, 22)
        Me.CmdFindDriver.TabIndex = 133
        Me.CmdFindDriver.Text = ">>"
        Me.CmdFindDriver.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(147, 398)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(279, 85)
        Me.txtDesc.TabIndex = 134
        '
        'CbLoadNo
        '
        Me.CbLoadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbLoadNo.FormattingEnabled = True
        Me.CbLoadNo.Location = New System.Drawing.Point(147, 128)
        Me.CbLoadNo.Name = "CbLoadNo"
        Me.CbLoadNo.Size = New System.Drawing.Size(279, 24)
        Me.CbLoadNo.TabIndex = 136
        '
        'CbShipmentNo
        '
        Me.CbShipmentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbShipmentNo.FormattingEnabled = True
        Me.CbShipmentNo.Location = New System.Drawing.Point(147, 158)
        Me.CbShipmentNo.Name = "CbShipmentNo"
        Me.CbShipmentNo.Size = New System.Drawing.Size(279, 24)
        Me.CbShipmentNo.TabIndex = 137
        Me.CbShipmentNo.Visible = False
        '
        'CbDono
        '
        Me.CbDono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbDono.FormattingEnabled = True
        Me.CbDono.Location = New System.Drawing.Point(147, 188)
        Me.CbDono.Name = "CbDono"
        Me.CbDono.Size = New System.Drawing.Size(279, 24)
        Me.CbDono.TabIndex = 138
        '
        'CbCompartment
        '
        Me.CbCompartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbCompartment.FormattingEnabled = True
        Me.CbCompartment.Location = New System.Drawing.Point(147, 218)
        Me.CbCompartment.Name = "CbCompartment"
        Me.CbCompartment.Size = New System.Drawing.Size(279, 24)
        Me.CbCompartment.TabIndex = 139
        '
        'CbSProductName
        '
        Me.CbSProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbSProductName.FormattingEnabled = True
        Me.CbSProductName.Location = New System.Drawing.Point(147, 248)
        Me.CbSProductName.Name = "CbSProductName"
        Me.CbSProductName.Size = New System.Drawing.Size(279, 24)
        Me.CbSProductName.TabIndex = 140
        '
        'CbBayName
        '
        Me.CbBayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbBayName.FormattingEnabled = True
        Me.CbBayName.Location = New System.Drawing.Point(147, 278)
        Me.CbBayName.Name = "CbBayName"
        Me.CbBayName.Size = New System.Drawing.Size(279, 24)
        Me.CbBayName.TabIndex = 141
        '
        'CbMeterName
        '
        Me.CbMeterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbMeterName.FormattingEnabled = True
        Me.CbMeterName.Location = New System.Drawing.Point(147, 308)
        Me.CbMeterName.Name = "CbMeterName"
        Me.CbMeterName.Size = New System.Drawing.Size(279, 24)
        Me.CbMeterName.TabIndex = 142
        '
        'SelProduct_Name
        '
        Me.SelProduct_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SelProduct_Name.FormattingEnabled = True
        Me.SelProduct_Name.Location = New System.Drawing.Point(147, 368)
        Me.SelProduct_Name.Name = "SelProduct_Name"
        Me.SelProduct_Name.Size = New System.Drawing.Size(279, 24)
        Me.SelProduct_Name.TabIndex = 143
        Me.SelProduct_Name.Visible = False
        '
        'txtLoadTopUpNo
        '
        Me.txtLoadTopUpNo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtLoadTopUpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoadTopUpNo.Location = New System.Drawing.Point(147, 98)
        Me.txtLoadTopUpNo.Name = "txtLoadTopUpNo"
        Me.txtLoadTopUpNo.Size = New System.Drawing.Size(163, 22)
        Me.txtLoadTopUpNo.TabIndex = 145
        '
        'btCancle
        '
        Me.btCancle.BackColor = System.Drawing.Color.White
        Me.btCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCancle.Location = New System.Drawing.Point(754, 471)
        Me.btCancle.Name = "btCancle"
        Me.btCancle.Size = New System.Drawing.Size(94, 40)
        Me.btCancle.TabIndex = 146
        Me.btCancle.Text = "CANCEL"
        Me.btCancle.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.White
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.Location = New System.Drawing.Point(641, 471)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(94, 40)
        Me.btSave.TabIndex = 147
        Me.btSave.Text = "SAVE"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'frmLoadTopUp_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 533)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btCancle)
        Me.Controls.Add(Me.txtLoadTopUpNo)
        Me.Controls.Add(Me.SelProduct_Name)
        Me.Controls.Add(Me.CbMeterName)
        Me.Controls.Add(Me.CbBayName)
        Me.Controls.Add(Me.CbSProductName)
        Me.Controls.Add(Me.CbCompartment)
        Me.Controls.Add(Me.CbDono)
        Me.Controls.Add(Me.CbShipmentNo)
        Me.Controls.Add(Me.CbLoadNo)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.CmdFindDriver)
        Me.Controls.Add(Me.CmdFindVehicle)
        Me.Controls.Add(Me.CmdFindCarrier)
        Me.Controls.Add(Me.CmdFindCustomer)
        Me.Controls.Add(Me.CmdFindShipto)
        Me.Controls.Add(Me.CmdFindTruck)
        Me.Controls.Add(Me.txtvehicle)
        Me.Controls.Add(Me.txtDriverName)
        Me.Controls.Add(Me.txtShipToName)
        Me.Controls.Add(Me.txtShipToID)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtCarrierName)
        Me.Controls.Add(Me.txtCarrierID)
        Me.Controls.Add(Me.txtvehicletype)
        Me.Controls.Add(Me.txtDriverID)
        Me.Controls.Add(Me.txtTuid1)
        Me.Controls.Add(Me.txtPreset)
        Me.Controls.Add(Me.txtTuid)
        Me.Controls.Add(Me.txtCardTu)
        Me.Controls.Add(Me.Label22)
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
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PickerDate_Start)
        Me.Controls.Add(Me.b_clear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadTopUp_sub"
        Me.Text = "# Top Up #"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_clear As System.Windows.Forms.Button
    Friend WithEvents PickerDate_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCardTu As System.Windows.Forms.TextBox
    Friend WithEvents txtTuid As System.Windows.Forms.TextBox
    Friend WithEvents txtPreset As System.Windows.Forms.TextBox
    Friend WithEvents txtTuid1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverID As System.Windows.Forms.TextBox
    Friend WithEvents txtvehicletype As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrierID As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrierName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtShipToID As System.Windows.Forms.TextBox
    Friend WithEvents txtShipToName As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents txtvehicle As System.Windows.Forms.TextBox
    Friend WithEvents CmdFindTruck As System.Windows.Forms.Button
    Friend WithEvents CmdFindShipto As System.Windows.Forms.Button
    Friend WithEvents CmdFindCustomer As System.Windows.Forms.Button
    Friend WithEvents CmdFindCarrier As System.Windows.Forms.Button
    Friend WithEvents CmdFindVehicle As System.Windows.Forms.Button
    Friend WithEvents CmdFindDriver As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents CbLoadNo As System.Windows.Forms.ComboBox
    Friend WithEvents CbShipmentNo As System.Windows.Forms.ComboBox
    Friend WithEvents CbDono As System.Windows.Forms.ComboBox
    Friend WithEvents CbCompartment As System.Windows.Forms.ComboBox
    Friend WithEvents CbSProductName As System.Windows.Forms.ComboBox
    Friend WithEvents CbBayName As System.Windows.Forms.ComboBox
    Friend WithEvents CbMeterName As System.Windows.Forms.ComboBox
    Friend WithEvents SelProduct_Name As System.Windows.Forms.ComboBox
    Friend WithEvents txtLoadTopUpNo As System.Windows.Forms.TextBox
    Friend WithEvents btCancle As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
End Class
