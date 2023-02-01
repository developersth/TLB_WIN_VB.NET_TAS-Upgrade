<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlWeighBridge_sub
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
        Me.cbCommPort = New System.Windows.Forms.ComboBox()
        Me.txtLastUpdateBy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWBName = New System.Windows.Forms.TextBox()
        Me.txtWBId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.txtWBAddress = New System.Windows.Forms.TextBox()
        Me.txtLastUpdateDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OptUnEnbled = New System.Windows.Forms.RadioButton()
        Me.OptEnabled = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txthistory = New System.Windows.Forms.TextBox()
        Me.cbCommPort2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCardReader = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbProtocal = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCommPort
        '
        Me.cbCommPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCommPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCommPort.FormattingEnabled = True
        Me.cbCommPort.Location = New System.Drawing.Point(192, 160)
        Me.cbCommPort.Name = "cbCommPort"
        Me.cbCommPort.Size = New System.Drawing.Size(196, 28)
        Me.cbCommPort.TabIndex = 112
        '
        'txtLastUpdateBy
        '
        Me.txtLastUpdateBy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateBy.Enabled = False
        Me.txtLastUpdateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(191, 543)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 105
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 543)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "แก้ไขโดย"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 514)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 20)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "วัน-เวลาที่แก้ไขล่าสุด"
        '
        'txtWBName
        '
        Me.txtWBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWBName.Location = New System.Drawing.Point(192, 82)
        Me.txtWBName.Name = "txtWBName"
        Me.txtWBName.Size = New System.Drawing.Size(196, 26)
        Me.txtWBName.TabIndex = 97
        '
        'txtWBId
        '
        Me.txtWBId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWBId.Location = New System.Drawing.Point(192, 46)
        Me.txtWBId.Name = "txtWBId"
        Me.txtWBId.Size = New System.Drawing.Size(196, 26)
        Me.txtWBId.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Comport1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "WB Address**"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "ชื่ออุปกรณ์"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "หมายเลขอุปกรณ์"
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcCancel1.Location = New System.Drawing.Point(505, 143)
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
        Me.UcSave1.Location = New System.Drawing.Point(505, 45)
        Me.UcSave1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'txtWBAddress
        '
        Me.txtWBAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWBAddress.Location = New System.Drawing.Point(192, 120)
        Me.txtWBAddress.Name = "txtWBAddress"
        Me.txtWBAddress.Size = New System.Drawing.Size(196, 26)
        Me.txtWBAddress.TabIndex = 124
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Enabled = False
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(191, 514)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 104
        Me.txtLastUpdateDate.Text = "txtLastUpdateDate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "หมายเหตุ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "สถานะการใช้งาน"
        '
        'OptUnEnbled
        '
        Me.OptUnEnbled.AutoSize = True
        Me.OptUnEnbled.BackColor = System.Drawing.SystemColors.Control
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
        Me.OptEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.OptEnabled.Location = New System.Drawing.Point(6, 11)
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
        Me.GroupBox1.Location = New System.Drawing.Point(193, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 62)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'txthistory
        '
        Me.txthistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txthistory.Location = New System.Drawing.Point(193, 392)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(283, 107)
        Me.txthistory.TabIndex = 126
        '
        'cbCommPort2
        '
        Me.cbCommPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCommPort2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCommPort2.FormattingEnabled = True
        Me.cbCommPort2.Location = New System.Drawing.Point(192, 200)
        Me.cbCommPort2.Name = "cbCommPort2"
        Me.cbCommPort2.Size = New System.Drawing.Size(196, 28)
        Me.cbCommPort2.TabIndex = 128
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Comport2"
        '
        'cbCardReader
        '
        Me.cbCardReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCardReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCardReader.FormattingEnabled = True
        Me.cbCardReader.Location = New System.Drawing.Point(192, 237)
        Me.cbCardReader.Name = "cbCardReader"
        Me.cbCardReader.Size = New System.Drawing.Size(196, 28)
        Me.cbCardReader.TabIndex = 130
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Card Reader"
        '
        'cbProtocal
        '
        Me.cbProtocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProtocal.FormattingEnabled = True
        Me.cbProtocal.Location = New System.Drawing.Point(192, 270)
        Me.cbProtocal.Name = "cbProtocal"
        Me.cbProtocal.Size = New System.Drawing.Size(196, 28)
        Me.cbProtocal.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(78, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Protocal Type"
        '
        'frmUtlWeighBridge_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 610)
        Me.Controls.Add(Me.cbProtocal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbCardReader)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbCommPort2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txthistory)
        Me.Controls.Add(Me.txtWBAddress)
        Me.Controls.Add(Me.UcCancel1)
        Me.Controls.Add(Me.UcSave1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbCommPort)
        Me.Controls.Add(Me.txtLastUpdateBy)
        Me.Controls.Add(Me.txtLastUpdateDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtWBName)
        Me.Controls.Add(Me.txtWBId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtlWeighBridge_sub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBay_sub"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCommPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtLastUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWBName As System.Windows.Forms.TextBox
    Friend WithEvents txtWBId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents txtWBAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OptUnEnbled As System.Windows.Forms.RadioButton
    Friend WithEvents OptEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txthistory As System.Windows.Forms.TextBox
    Friend WithEvents cbCommPort2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCardReader As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbProtocal As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
