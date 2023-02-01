<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlTasConfig_sub
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
        Me.txtLastUpdateDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLastUpdateBy = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptEnabled = New System.Windows.Forms.RadioButton()
        Me.OptUnEnbled = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.txtCfgID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastUpdateDate
        '
        Me.txtLastUpdateDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLastUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdateDate.Location = New System.Drawing.Point(200, 290)
        Me.txtLastUpdateDate.Name = "txtLastUpdateDate"
        Me.txtLastUpdateDate.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateDate.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(66, 292)
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
        Me.txtLastUpdateBy.Location = New System.Drawing.Point(200, 320)
        Me.txtLastUpdateBy.Name = "txtLastUpdateBy"
        Me.txtLastUpdateBy.Size = New System.Drawing.Size(296, 26)
        Me.txtLastUpdateBy.TabIndex = 150
        Me.txtLastUpdateBy.Text = "txtLastUpdateBy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(117, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "แก้ไขโดย"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptEnabled)
        Me.GroupBox1.Controls.Add(Me.OptUnEnbled)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(200, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 57)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
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
        'OptUnEnbled
        '
        Me.OptUnEnbled.AutoSize = True
        Me.OptUnEnbled.BackColor = System.Drawing.SystemColors.Control
        Me.OptUnEnbled.Location = New System.Drawing.Point(6, 38)
        Me.OptUnEnbled.Name = "OptUnEnbled"
        Me.OptUnEnbled.Size = New System.Drawing.Size(115, 24)
        Me.OptUnEnbled.TabIndex = 111
        Me.OptUnEnbled.TabStop = True
        Me.OptUnEnbled.Text = "หยุดการใช้งาน"
        Me.OptUnEnbled.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-72, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(135, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 20)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "Value"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(200, 66)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(297, 101)
        Me.txtDescription.TabIndex = 158
        Me.txtDescription.Text = ""
        '
        'txtCfgID
        '
        Me.txtCfgID.Enabled = False
        Me.txtCfgID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCfgID.Location = New System.Drawing.Point(200, 34)
        Me.txtCfgID.Name = "txtCfgID"
        Me.txtCfgID.Size = New System.Drawing.Size(100, 26)
        Me.txtCfgID.TabIndex = 156
        Me.txtCfgID.Text = "txtCfgID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "รายละเอียด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Cong ID"
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.Location = New System.Drawing.Point(562, 104)
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
        Me.UcSave1.Location = New System.Drawing.Point(562, 18)
        Me.UcSave1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(71, 69)
        Me.UcSave1.TabIndex = 122
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtType.Location = New System.Drawing.Point(200, 173)
        Me.txtType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(296, 26)
        Me.txtType.TabIndex = 159
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(200, 203)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(296, 26)
        Me.txtUnit.TabIndex = 161
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtValue.Location = New System.Drawing.Point(200, 233)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(296, 26)
        Me.txtValue.TabIndex = 163
        '
        'frmUtlTasConfig_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 359)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCfgID)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "frmUtlTasConfig_sub"
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents OptUnEnbled As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCfgID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
End Class
