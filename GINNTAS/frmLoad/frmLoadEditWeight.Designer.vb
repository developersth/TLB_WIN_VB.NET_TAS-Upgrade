<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadEditWeight
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtloadNo = New System.Windows.Forms.TextBox()
        Me.txtShipmentNo = New System.Windows.Forms.TextBox()
        Me.txtTruckNo = New System.Windows.Forms.TextBox()
        Me.txtTuNo = New System.Windows.Forms.TextBox()
        Me.txtWeightIn = New System.Windows.Forms.TextBox()
        Me.txtWeightOut = New System.Windows.Forms.TextBox()
        Me.CmbCard_Reader = New System.Windows.Forms.ComboBox()
        Me.b_Save = New System.Windows.Forms.Button()
        Me.b_Cancel = New System.Windows.Forms.Button()
        Me.b_Refresh_weight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Load No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shipment No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ทะเบียนรถ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ทะเบียนรถตัวพ่วง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เครื่องอ่านบัตร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "น้ำหนักชั่งเข้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "น้ำหนักชั่งออก"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(308, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kg."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kg."
        '
        'txtloadNo
        '
        Me.txtloadNo.BackColor = System.Drawing.Color.LightGreen
        Me.txtloadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtloadNo.Location = New System.Drawing.Point(186, 37)
        Me.txtloadNo.Name = "txtloadNo"
        Me.txtloadNo.ReadOnly = True
        Me.txtloadNo.Size = New System.Drawing.Size(194, 31)
        Me.txtloadNo.TabIndex = 9
        '
        'txtShipmentNo
        '
        Me.txtShipmentNo.BackColor = System.Drawing.Color.LightGreen
        Me.txtShipmentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShipmentNo.Location = New System.Drawing.Point(186, 93)
        Me.txtShipmentNo.Name = "txtShipmentNo"
        Me.txtShipmentNo.ReadOnly = True
        Me.txtShipmentNo.Size = New System.Drawing.Size(194, 31)
        Me.txtShipmentNo.TabIndex = 10
        '
        'txtTruckNo
        '
        Me.txtTruckNo.BackColor = System.Drawing.Color.LightGreen
        Me.txtTruckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTruckNo.Location = New System.Drawing.Point(186, 147)
        Me.txtTruckNo.Name = "txtTruckNo"
        Me.txtTruckNo.ReadOnly = True
        Me.txtTruckNo.Size = New System.Drawing.Size(194, 31)
        Me.txtTruckNo.TabIndex = 11
        '
        'txtTuNo
        '
        Me.txtTuNo.BackColor = System.Drawing.Color.LightGreen
        Me.txtTuNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuNo.Location = New System.Drawing.Point(186, 204)
        Me.txtTuNo.Name = "txtTuNo"
        Me.txtTuNo.ReadOnly = True
        Me.txtTuNo.Size = New System.Drawing.Size(194, 31)
        Me.txtTuNo.TabIndex = 12
        '
        'txtWeightIn
        '
        Me.txtWeightIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWeightIn.Location = New System.Drawing.Point(186, 311)
        Me.txtWeightIn.Name = "txtWeightIn"
        Me.txtWeightIn.Size = New System.Drawing.Size(118, 31)
        Me.txtWeightIn.TabIndex = 13
        '
        'txtWeightOut
        '
        Me.txtWeightOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWeightOut.Location = New System.Drawing.Point(186, 365)
        Me.txtWeightOut.Name = "txtWeightOut"
        Me.txtWeightOut.Size = New System.Drawing.Size(118, 31)
        Me.txtWeightOut.TabIndex = 14
        '
        'CmbCard_Reader
        '
        Me.CmbCard_Reader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmbCard_Reader.FormattingEnabled = True
        Me.CmbCard_Reader.Location = New System.Drawing.Point(186, 257)
        Me.CmbCard_Reader.Name = "CmbCard_Reader"
        Me.CmbCard_Reader.Size = New System.Drawing.Size(121, 32)
        Me.CmbCard_Reader.TabIndex = 15
        '
        'b_Save
        '
        Me.b_Save.BackColor = System.Drawing.Color.Yellow
        Me.b_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Save.Location = New System.Drawing.Point(84, 438)
        Me.b_Save.Name = "b_Save"
        Me.b_Save.Size = New System.Drawing.Size(120, 40)
        Me.b_Save.TabIndex = 16
        Me.b_Save.Text = "ตกลง"
        Me.b_Save.UseVisualStyleBackColor = False
        '
        'b_Cancel
        '
        Me.b_Cancel.BackColor = System.Drawing.Color.Pink
        Me.b_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Cancel.Location = New System.Drawing.Point(231, 438)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(120, 40)
        Me.b_Cancel.TabIndex = 17
        Me.b_Cancel.Text = "ยกเลิก"
        Me.b_Cancel.UseVisualStyleBackColor = False
        '
        'b_Refresh_weight
        '
        Me.b_Refresh_weight.BackColor = System.Drawing.Color.NavajoWhite
        Me.b_Refresh_weight.Location = New System.Drawing.Point(313, 257)
        Me.b_Refresh_weight.Name = "b_Refresh_weight"
        Me.b_Refresh_weight.Size = New System.Drawing.Size(87, 32)
        Me.b_Refresh_weight.TabIndex = 19
        Me.b_Refresh_weight.Text = "Get Weight"
        Me.b_Refresh_weight.UseVisualStyleBackColor = False
        '
        'frmLoadEditWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 504)
        Me.Controls.Add(Me.b_Refresh_weight)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Save)
        Me.Controls.Add(Me.CmbCard_Reader)
        Me.Controls.Add(Me.txtWeightOut)
        Me.Controls.Add(Me.txtWeightIn)
        Me.Controls.Add(Me.txtTuNo)
        Me.Controls.Add(Me.txtTruckNo)
        Me.Controls.Add(Me.txtShipmentNo)
        Me.Controls.Add(Me.txtloadNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadEditWeight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "# ป้อนน้ำหนัก #"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtloadNo As System.Windows.Forms.TextBox
    Friend WithEvents txtShipmentNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTruckNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTuNo As System.Windows.Forms.TextBox
    Friend WithEvents txtWeightIn As System.Windows.Forms.TextBox
    Friend WithEvents txtWeightOut As System.Windows.Forms.TextBox
    Friend WithEvents CmbCard_Reader As System.Windows.Forms.ComboBox
    Friend WithEvents b_Save As System.Windows.Forms.Button
    Friend WithEvents b_Cancel As System.Windows.Forms.Button
    Friend WithEvents b_Refresh_weight As System.Windows.Forms.Button
End Class
