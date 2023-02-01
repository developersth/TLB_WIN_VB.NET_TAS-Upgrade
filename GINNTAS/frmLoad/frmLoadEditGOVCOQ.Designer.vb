<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadEditGOVCOQ
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
        Me.txtloadNo = New System.Windows.Forms.TextBox()
        Me.Text_productName = New System.Windows.Forms.TextBox()
        Me.Text_COQ_NO = New System.Windows.Forms.TextBox()
        Me.Text_GOVCOQ_NO = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.COQ_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GOV_COQ_DATE = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Load No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "COQ_NO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "COQ_DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GOV_COQ_NO"
        '
        'txtloadNo
        '
        Me.txtloadNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtloadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtloadNo.Location = New System.Drawing.Point(164, 67)
        Me.txtloadNo.Name = "txtloadNo"
        Me.txtloadNo.Size = New System.Drawing.Size(214, 26)
        Me.txtloadNo.TabIndex = 11
        '
        'Text_productName
        '
        Me.Text_productName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Text_productName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Text_productName.Location = New System.Drawing.Point(164, 105)
        Me.Text_productName.Name = "Text_productName"
        Me.Text_productName.Size = New System.Drawing.Size(214, 26)
        Me.Text_productName.TabIndex = 12
        '
        'Text_COQ_NO
        '
        Me.Text_COQ_NO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Text_COQ_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Text_COQ_NO.Location = New System.Drawing.Point(164, 140)
        Me.Text_COQ_NO.Name = "Text_COQ_NO"
        Me.Text_COQ_NO.Size = New System.Drawing.Size(214, 26)
        Me.Text_COQ_NO.TabIndex = 13
        '
        'Text_GOVCOQ_NO
        '
        Me.Text_GOVCOQ_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Text_GOVCOQ_NO.Location = New System.Drawing.Point(164, 212)
        Me.Text_GOVCOQ_NO.Name = "Text_GOVCOQ_NO"
        Me.Text_GOVCOQ_NO.Size = New System.Drawing.Size(214, 26)
        Me.Text_GOVCOQ_NO.TabIndex = 16
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Red
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(289, 279)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(89, 36)
        Me.CmdCancel.TabIndex = 18
        Me.CmdCancel.Text = "ยกเลิก"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.LawnGreen
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdOk.Location = New System.Drawing.Point(183, 279)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(89, 36)
        Me.CmdOk.TabIndex = 17
        Me.CmdOk.Text = "ตกลง"
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'COQ_DATE
        '
        Me.COQ_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.COQ_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.COQ_DATE.Location = New System.Drawing.Point(164, 175)
        Me.COQ_DATE.Name = "COQ_DATE"
        Me.COQ_DATE.Size = New System.Drawing.Size(214, 26)
        Me.COQ_DATE.TabIndex = 180
        Me.COQ_DATE.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 24)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "GOV_COQ_DATE"
        '
        'GOV_COQ_DATE
        '
        Me.GOV_COQ_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GOV_COQ_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GOV_COQ_DATE.Location = New System.Drawing.Point(164, 247)
        Me.GOV_COQ_DATE.Name = "GOV_COQ_DATE"
        Me.GOV_COQ_DATE.Size = New System.Drawing.Size(214, 26)
        Me.GOV_COQ_DATE.TabIndex = 182
        Me.GOV_COQ_DATE.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'frmLoadEditGOVCOQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(396, 342)
        Me.Controls.Add(Me.GOV_COQ_DATE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.COQ_DATE)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Text_GOVCOQ_NO)
        Me.Controls.Add(Me.Text_COQ_NO)
        Me.Controls.Add(Me.Text_productName)
        Me.Controls.Add(Me.txtloadNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoadEditGOVCOQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "COQ"
        Me.Text = "แก้ไขข้อมูล COQ"
        Me.TransparencyKey = System.Drawing.Color.Lavender
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtloadNo As TextBox
    Friend WithEvents Text_productName As TextBox
    Friend WithEvents Text_COQ_NO As TextBox
    Friend WithEvents Text_GOVCOQ_NO As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOk As Button
    Friend WithEvents COQ_DATE As DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GOV_COQ_DATE As System.Windows.Forms.DateTimePicker
End Class
