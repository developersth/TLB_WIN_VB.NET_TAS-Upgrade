<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigReportSetting_sub
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
        Me.OptPrint = New System.Windows.Forms.RadioButton()
        Me.OptDoNotPrint = New System.Windows.Forms.RadioButton()
        Me.cmdOpenFile = New System.Windows.Forms.Button()
        Me.cbPrinter = New System.Windows.Forms.ComboBox()
        Me.txtRepotPath = New System.Windows.Forms.TextBox()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.cbReportType = New System.Windows.Forms.ComboBox()
        Me.txtReportID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbHeadderId = New System.Windows.Forms.ComboBox()
        Me.cbPrinterId = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTimePrint = New System.Windows.Forms.DateTimePicker()
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
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(149, 344)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 344)
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
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(149, 373)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(76, 376)
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
        Me.GroupBox1.Location = New System.Drawing.Point(149, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 65)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'OptEnabled
        '
        Me.OptEnabled.AutoSize = True
        Me.OptEnabled.BackColor = System.Drawing.Color.White
        Me.OptEnabled.Location = New System.Drawing.Point(6, 13)
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
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "สถานะการใช้งาน"
        '
        'OptPrint
        '
        Me.OptPrint.AutoSize = True
        Me.OptPrint.BackColor = System.Drawing.Color.White
        Me.OptPrint.Location = New System.Drawing.Point(6, 39)
        Me.OptPrint.Name = "OptPrint"
        Me.OptPrint.Size = New System.Drawing.Size(57, 24)
        Me.OptPrint.TabIndex = 167
        Me.OptPrint.TabStop = True
        Me.OptPrint.Text = "พิมพ์"
        Me.OptPrint.UseVisualStyleBackColor = False
        '
        'OptDoNotPrint
        '
        Me.OptDoNotPrint.AutoSize = True
        Me.OptDoNotPrint.BackColor = System.Drawing.Color.White
        Me.OptDoNotPrint.Location = New System.Drawing.Point(6, 14)
        Me.OptDoNotPrint.Name = "OptDoNotPrint"
        Me.OptDoNotPrint.Size = New System.Drawing.Size(74, 24)
        Me.OptDoNotPrint.TabIndex = 166
        Me.OptDoNotPrint.TabStop = True
        Me.OptDoNotPrint.Text = "ไม่พิมพ์"
        Me.OptDoNotPrint.UseVisualStyleBackColor = False
        '
        'cmdOpenFile
        '
        Me.cmdOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdOpenFile.Location = New System.Drawing.Point(367, 148)
        Me.cmdOpenFile.Name = "cmdOpenFile"
        Me.cmdOpenFile.Size = New System.Drawing.Size(32, 25)
        Me.cmdOpenFile.TabIndex = 164
        Me.cmdOpenFile.Text = "..."
        Me.cmdOpenFile.UseVisualStyleBackColor = True
        '
        'cbPrinter
        '
        Me.cbPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPrinter.FormattingEnabled = True
        Me.cbPrinter.Location = New System.Drawing.Point(149, 176)
        Me.cbPrinter.Name = "cbPrinter"
        Me.cbPrinter.Size = New System.Drawing.Size(212, 28)
        Me.cbPrinter.TabIndex = 163
        Me.cbPrinter.Text = "cbPrinter"
        '
        'txtRepotPath
        '
        Me.txtRepotPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRepotPath.Location = New System.Drawing.Point(149, 148)
        Me.txtRepotPath.Name = "txtRepotPath"
        Me.txtRepotPath.Size = New System.Drawing.Size(212, 26)
        Me.txtRepotPath.TabIndex = 162
        Me.txtRepotPath.Text = "txtReportPath"
        '
        'txtReportName
        '
        Me.txtReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReportName.Location = New System.Drawing.Point(149, 118)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(212, 26)
        Me.txtReportName.TabIndex = 161
        Me.txtReportName.Text = "txtReportName"
        '
        'cbReportType
        '
        Me.cbReportType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbReportType.FormattingEnabled = True
        Me.cbReportType.Location = New System.Drawing.Point(149, 87)
        Me.cbReportType.Name = "cbReportType"
        Me.cbReportType.Size = New System.Drawing.Size(212, 28)
        Me.cbReportType.TabIndex = 160
        Me.cbReportType.Text = "cbReportType"
        '
        'txtReportID
        '
        Me.txtReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReportID.Location = New System.Drawing.Point(149, 57)
        Me.txtReportID.Name = "txtReportID"
        Me.txtReportID.Size = New System.Drawing.Size(100, 26)
        Me.txtReportID.TabIndex = 159
        Me.txtReportID.Text = "txtRepor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 20)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "การพิมพ์ End of Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "พิมพ์ที่เครื่องพิมพ์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "ที่อยู่ของรายงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "ชื่อรายงาน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "เป็นรายงาน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "รหัสรายงาน"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptDoNotPrint)
        Me.GroupBox2.Controls.Add(Me.OptPrint)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(149, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 72)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        'cbHeadderId
        '
        Me.cbHeadderId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbHeadderId.FormattingEnabled = True
        Me.cbHeadderId.Location = New System.Drawing.Point(240, 402)
        Me.cbHeadderId.Name = "cbHeadderId"
        Me.cbHeadderId.Size = New System.Drawing.Size(121, 28)
        Me.cbHeadderId.TabIndex = 165
        Me.cbHeadderId.Visible = False
        '
        'cbPrinterId
        '
        Me.cbPrinterId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPrinterId.FormattingEnabled = True
        Me.cbPrinterId.Location = New System.Drawing.Point(240, 429)
        Me.cbPrinterId.Name = "cbPrinterId"
        Me.cbPrinterId.Size = New System.Drawing.Size(121, 28)
        Me.cbPrinterId.TabIndex = 166
        Me.cbPrinterId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "เวลาที่พิมพ์"
        '
        'dtpTimePrint
        '
        Me.dtpTimePrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpTimePrint.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimePrint.Location = New System.Drawing.Point(149, 402)
        Me.dtpTimePrint.Name = "dtpTimePrint"
        Me.dtpTimePrint.Size = New System.Drawing.Size(74, 26)
        Me.dtpTimePrint.TabIndex = 169
        Me.dtpTimePrint.Value = New Date(2015, 3, 5, 0, 0, 0, 0)
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(401, 144)
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
        Me.UcSave1.Location = New System.Drawing.Point(401, 58)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'frmConfigReportSetting_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 467)
        Me.Controls.Add(Me.dtpTimePrint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbPrinterId)
        Me.Controls.Add(Me.cbHeadderId)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdOpenFile)
        Me.Controls.Add(Me.cbPrinter)
        Me.Controls.Add(Me.txtRepotPath)
        Me.Controls.Add(Me.txtReportName)
        Me.Controls.Add(Me.cbReportType)
        Me.Controls.Add(Me.txtReportID)
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
        Me.Name = "frmConfigReportSetting_sub"
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
    Friend WithEvents OptPrint As System.Windows.Forms.RadioButton
    Friend WithEvents OptDoNotPrint As System.Windows.Forms.RadioButton
    Friend WithEvents cmdOpenFile As System.Windows.Forms.Button
    Friend WithEvents cbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents txtRepotPath As System.Windows.Forms.TextBox
    Friend WithEvents txtReportName As System.Windows.Forms.TextBox
    Friend WithEvents cbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents txtReportID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHeadderId As System.Windows.Forms.ComboBox
    Friend WithEvents cbPrinterId As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpTimePrint As System.Windows.Forms.DateTimePicker
End Class
