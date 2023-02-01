<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadMixEdit
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
        Me.txtCardBilNew = New System.Windows.Forms.TextBox()
        Me.txtCardBilOle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLoad_No = New System.Windows.Forms.TextBox()
        Me.btCardCancel = New System.Windows.Forms.Button()
        Me.btCardSave = New System.Windows.Forms.Button()
        Me.cbCardBil = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btDriverCancel = New System.Windows.Forms.Button()
        Me.btDriverSave = New System.Windows.Forms.Button()
        Me.cbDrive = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDriveOld = New System.Windows.Forms.TextBox()
        Me.txtDriveNew = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTuTailNew = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTuHeadNew = New System.Windows.Forms.TextBox()
        Me.btTuCancel = New System.Windows.Forms.Button()
        Me.btTuSave = New System.Windows.Forms.Button()
        Me.cbTuTail = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTuTailOld = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTuHead = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTuHeadOld = New System.Windows.Forms.TextBox()
        Me.UcMenutxtSub3 = New GINNTAS.ucMenutxtSub()
        Me.UcMenutxtSub2 = New GINNTAS.ucMenutxtSub()
        Me.UcMenutxtSub1 = New GINNTAS.ucMenutxtSub()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.UcMenutxtSub4 = New GINNTAS.ucMenutxtSub()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbStatusNew = New System.Windows.Forms.ComboBox()
        Me.txtStatusOld = New System.Windows.Forms.TextBox()
        Me.btLoadCancel = New System.Windows.Forms.Button()
        Me.btLoadSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCardBilNew
        '
        Me.txtCardBilNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCardBilNew.Location = New System.Drawing.Point(176, 92)
        Me.txtCardBilNew.Name = "txtCardBilNew"
        Me.txtCardBilNew.ReadOnly = True
        Me.txtCardBilNew.Size = New System.Drawing.Size(274, 26)
        Me.txtCardBilNew.TabIndex = 15
        '
        'txtCardBilOle
        '
        Me.txtCardBilOle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCardBilOle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCardBilOle.Location = New System.Drawing.Point(176, 25)
        Me.txtCardBilOle.Name = "txtCardBilOle"
        Me.txtCardBilOle.ReadOnly = True
        Me.txtCardBilOle.Size = New System.Drawing.Size(102, 26)
        Me.txtCardBilOle.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLoad_No)
        Me.GroupBox1.Controls.Add(Me.btCardCancel)
        Me.GroupBox1.Controls.Add(Me.btCardSave)
        Me.GroupBox1.Controls.Add(Me.cbCardBil)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCardBilOle)
        Me.GroupBox1.Controls.Add(Me.txtCardBilNew)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(230, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 153)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เปลี่ยนหมายเลขบัตร"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(288, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "ของ Load No"
        '
        'txtLoad_No
        '
        Me.txtLoad_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLoad_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoad_No.Location = New System.Drawing.Point(391, 23)
        Me.txtLoad_No.Name = "txtLoad_No"
        Me.txtLoad_No.ReadOnly = True
        Me.txtLoad_No.Size = New System.Drawing.Size(159, 26)
        Me.txtLoad_No.TabIndex = 22
        '
        'btCardCancel
        '
        Me.btCardCancel.Location = New System.Drawing.Point(475, 93)
        Me.btCardCancel.Name = "btCardCancel"
        Me.btCardCancel.Size = New System.Drawing.Size(75, 30)
        Me.btCardCancel.TabIndex = 21
        Me.btCardCancel.Text = "ยกเลิก"
        Me.btCardCancel.UseVisualStyleBackColor = True
        '
        'btCardSave
        '
        Me.btCardSave.Location = New System.Drawing.Point(475, 55)
        Me.btCardSave.Name = "btCardSave"
        Me.btCardSave.Size = New System.Drawing.Size(75, 30)
        Me.btCardSave.TabIndex = 20
        Me.btCardSave.Text = "บักทึก"
        Me.btCardSave.UseVisualStyleBackColor = True
        '
        'cbCardBil
        '
        Me.cbCardBil.FormattingEnabled = True
        Me.cbCardBil.Location = New System.Drawing.Point(176, 57)
        Me.cbCardBil.Name = "cbCardBil"
        Me.cbCardBil.Size = New System.Drawing.Size(274, 28)
        Me.cbCardBil.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(43, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "หมายเลขบัตรใหม่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "เลือกหมายเลขบัตรใหม่"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(79, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "เลขบัตรเดิม"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btDriverCancel)
        Me.GroupBox2.Controls.Add(Me.btDriverSave)
        Me.GroupBox2.Controls.Add(Me.cbDrive)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDriveOld)
        Me.GroupBox2.Controls.Add(Me.txtDriveNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(230, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 153)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เปลี่ยนพนักงานขับรถ"
        '
        'btDriverCancel
        '
        Me.btDriverCancel.Location = New System.Drawing.Point(475, 92)
        Me.btDriverCancel.Name = "btDriverCancel"
        Me.btDriverCancel.Size = New System.Drawing.Size(75, 30)
        Me.btDriverCancel.TabIndex = 23
        Me.btDriverCancel.Text = "ยกเลิก"
        Me.btDriverCancel.UseVisualStyleBackColor = True
        '
        'btDriverSave
        '
        Me.btDriverSave.Location = New System.Drawing.Point(475, 54)
        Me.btDriverSave.Name = "btDriverSave"
        Me.btDriverSave.Size = New System.Drawing.Size(75, 30)
        Me.btDriverSave.TabIndex = 22
        Me.btDriverSave.Text = "บักทึก"
        Me.btDriverSave.UseVisualStyleBackColor = True
        '
        'cbDrive
        '
        Me.cbDrive.FormattingEnabled = True
        Me.cbDrive.Location = New System.Drawing.Point(176, 56)
        Me.cbDrive.Name = "cbDrive"
        Me.cbDrive.Size = New System.Drawing.Size(274, 28)
        Me.cbDrive.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(69, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ชื่อ พขร .ใหม่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(47, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "เลือกชื่อ พขร. ใหม่"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(79, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ชื่อ พขร. เดิม"
        '
        'txtDriveOld
        '
        Me.txtDriveOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDriveOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriveOld.Location = New System.Drawing.Point(176, 24)
        Me.txtDriveOld.Name = "txtDriveOld"
        Me.txtDriveOld.ReadOnly = True
        Me.txtDriveOld.Size = New System.Drawing.Size(274, 26)
        Me.txtDriveOld.TabIndex = 13
        '
        'txtDriveNew
        '
        Me.txtDriveNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriveNew.Location = New System.Drawing.Point(176, 91)
        Me.txtDriveNew.Name = "txtDriveNew"
        Me.txtDriveNew.ReadOnly = True
        Me.txtDriveNew.Size = New System.Drawing.Size(274, 26)
        Me.txtDriveNew.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTuTailNew)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtTuHeadNew)
        Me.GroupBox3.Controls.Add(Me.btTuCancel)
        Me.GroupBox3.Controls.Add(Me.btTuSave)
        Me.GroupBox3.Controls.Add(Me.cbTuTail)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtTuTailOld)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cbTuHead)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtTuHeadOld)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(230, 420)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 280)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เปลี่ยนทะเบียนรถ"
        '
        'txtTuTailNew
        '
        Me.txtTuTailNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTuTailNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuTailNew.Location = New System.Drawing.Point(176, 215)
        Me.txtTuTailNew.Name = "txtTuTailNew"
        Me.txtTuTailNew.ReadOnly = True
        Me.txtTuTailNew.Size = New System.Drawing.Size(274, 26)
        Me.txtTuTailNew.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(82, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "ตัวพ่วงใหม่"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(55, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "เลือกหัวลากใหม่"
        '
        'txtTuHeadNew
        '
        Me.txtTuHeadNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTuHeadNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuHeadNew.Location = New System.Drawing.Point(176, 92)
        Me.txtTuHeadNew.Name = "txtTuHeadNew"
        Me.txtTuHeadNew.ReadOnly = True
        Me.txtTuHeadNew.Size = New System.Drawing.Size(274, 26)
        Me.txtTuHeadNew.TabIndex = 28
        '
        'btTuCancel
        '
        Me.btTuCancel.Location = New System.Drawing.Point(475, 209)
        Me.btTuCancel.Name = "btTuCancel"
        Me.btTuCancel.Size = New System.Drawing.Size(75, 30)
        Me.btTuCancel.TabIndex = 27
        Me.btTuCancel.Text = "ยกเลิก"
        Me.btTuCancel.UseVisualStyleBackColor = True
        '
        'btTuSave
        '
        Me.btTuSave.Location = New System.Drawing.Point(475, 172)
        Me.btTuSave.Name = "btTuSave"
        Me.btTuSave.Size = New System.Drawing.Size(75, 30)
        Me.btTuSave.TabIndex = 26
        Me.btTuSave.Text = "บักทึก"
        Me.btTuSave.UseVisualStyleBackColor = True
        '
        'cbTuTail
        '
        Me.cbTuTail.FormattingEnabled = True
        Me.cbTuTail.Location = New System.Drawing.Point(176, 174)
        Me.cbTuTail.Name = "cbTuTail"
        Me.cbTuTail.Size = New System.Drawing.Size(274, 28)
        Me.cbTuTail.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(54, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "เลือกตัวพ่วงใหม่"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(86, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "หัวลากเดิม"
        '
        'txtTuTailOld
        '
        Me.txtTuTailOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTuTailOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuTailOld.Location = New System.Drawing.Point(176, 138)
        Me.txtTuTailOld.Name = "txtTuTailOld"
        Me.txtTuTailOld.ReadOnly = True
        Me.txtTuTailOld.Size = New System.Drawing.Size(274, 26)
        Me.txtTuTailOld.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(87, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ตัวพ่วงเดิม"
        '
        'cbTuHead
        '
        Me.cbTuHead.FormattingEnabled = True
        Me.cbTuHead.Location = New System.Drawing.Point(176, 57)
        Me.cbTuHead.Name = "cbTuHead"
        Me.cbTuHead.Size = New System.Drawing.Size(274, 28)
        Me.cbTuHead.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(85, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "หัวลากใหม่"
        '
        'txtTuHeadOld
        '
        Me.txtTuHeadOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTuHeadOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuHeadOld.Location = New System.Drawing.Point(176, 25)
        Me.txtTuHeadOld.Name = "txtTuHeadOld"
        Me.txtTuHeadOld.ReadOnly = True
        Me.txtTuHeadOld.Size = New System.Drawing.Size(274, 26)
        Me.txtTuHeadOld.TabIndex = 13
        '
        'UcMenutxtSub3
        '
        Me.UcMenutxtSub3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenutxtSub3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub3.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub3.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtSub3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtSub3.Location = New System.Drawing.Point(14, 273)
        Me.UcMenutxtSub3.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub3.MenuAuthorizeID = CType(11, Long)
        Me.UcMenutxtSub3.MenuCorners = 6
        Me.UcMenutxtSub3.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub3.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub3.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub3.MenuIcon = Nothing
        Me.UcMenutxtSub3.MenuIconSize = New System.Drawing.Size(13, 19)
        Me.UcMenutxtSub3.MenuScreenID = CType(502, Long)
        Me.UcMenutxtSub3.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtSub3.MenuText = "Force Base Oil Complete"
        Me.UcMenutxtSub3.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub3.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenutxtSub3.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub3.MenuTextShadowShow = False
        Me.UcMenutxtSub3.Name = "UcMenutxtSub3"
        Me.UcMenutxtSub3.Size = New System.Drawing.Size(198, 55)
        Me.UcMenutxtSub3.TabIndex = 96
        '
        'UcMenutxtSub2
        '
        Me.UcMenutxtSub2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenutxtSub2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub2.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub2.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtSub2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtSub2.Location = New System.Drawing.Point(14, 219)
        Me.UcMenutxtSub2.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub2.MenuAuthorizeID = CType(15, Long)
        Me.UcMenutxtSub2.MenuCorners = 6
        Me.UcMenutxtSub2.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub2.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub2.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub2.MenuIcon = Nothing
        Me.UcMenutxtSub2.MenuIconSize = New System.Drawing.Size(13, 19)
        Me.UcMenutxtSub2.MenuScreenID = CType(502, Long)
        Me.UcMenutxtSub2.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtSub2.MenuText = "เปลี่ยนหมายเลขทะเบียน"
        Me.UcMenutxtSub2.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub2.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenutxtSub2.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub2.MenuTextShadowShow = False
        Me.UcMenutxtSub2.Name = "UcMenutxtSub2"
        Me.UcMenutxtSub2.Size = New System.Drawing.Size(198, 38)
        Me.UcMenutxtSub2.TabIndex = 95
        '
        'UcMenutxtSub1
        '
        Me.UcMenutxtSub1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenutxtSub1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub1.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub1.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtSub1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtSub1.Location = New System.Drawing.Point(14, 159)
        Me.UcMenutxtSub1.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub1.MenuAuthorizeID = CType(13, Long)
        Me.UcMenutxtSub1.MenuCorners = 6
        Me.UcMenutxtSub1.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub1.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub1.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub1.MenuIcon = Nothing
        Me.UcMenutxtSub1.MenuIconSize = New System.Drawing.Size(13, 19)
        Me.UcMenutxtSub1.MenuScreenID = CType(502, Long)
        Me.UcMenutxtSub1.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtSub1.MenuText = "เปลี่ยนพนักงานขับรถ"
        Me.UcMenutxtSub1.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub1.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenutxtSub1.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub1.MenuTextShadowShow = False
        Me.UcMenutxtSub1.Name = "UcMenutxtSub1"
        Me.UcMenutxtSub1.Size = New System.Drawing.Size(198, 38)
        Me.UcMenutxtSub1.TabIndex = 94
        '
        'UcMenuRefresh
        '
        Me.UcMenuRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuRefresh.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.ForeColor = System.Drawing.Color.Teal
        Me.UcMenuRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuRefresh.Location = New System.Drawing.Point(14, 95)
        Me.UcMenuRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuRefresh.MenuAuthorizeID = CType(12, Long)
        Me.UcMenuRefresh.MenuCorners = 6
        Me.UcMenuRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.MenuIcon = Nothing
        Me.UcMenuRefresh.MenuIconSize = New System.Drawing.Size(1, 1)
        Me.UcMenuRefresh.MenuScreenID = CType(502, Long)
        Me.UcMenuRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuRefresh.MenuText = "เปลี่ยนหมายเลขบัตร"
        Me.UcMenuRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuRefresh.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenuRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuRefresh.MenuTextShadowShow = False
        Me.UcMenuRefresh.Name = "UcMenuRefresh"
        Me.UcMenuRefresh.Size = New System.Drawing.Size(198, 38)
        Me.UcMenuRefresh.TabIndex = 93
        '
        'UcMenutxtSub4
        '
        Me.UcMenutxtSub4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenutxtSub4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub4.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub4.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtSub4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtSub4.Location = New System.Drawing.Point(14, 341)
        Me.UcMenutxtSub4.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub4.MenuAuthorizeID = CType(11, Long)
        Me.UcMenutxtSub4.MenuCorners = 6
        Me.UcMenutxtSub4.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub4.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub4.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub4.MenuIcon = Nothing
        Me.UcMenutxtSub4.MenuIconSize = New System.Drawing.Size(13, 19)
        Me.UcMenutxtSub4.MenuScreenID = CType(502, Long)
        Me.UcMenutxtSub4.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtSub4.MenuText = "Force Load Status"
        Me.UcMenutxtSub4.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub4.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenutxtSub4.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub4.MenuTextShadowShow = False
        Me.UcMenutxtSub4.Name = "UcMenutxtSub4"
        Me.UcMenutxtSub4.Size = New System.Drawing.Size(198, 55)
        Me.UcMenutxtSub4.TabIndex = 97
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btLoadCancel)
        Me.GroupBox4.Controls.Add(Me.btLoadSave)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmbStatusNew)
        Me.GroupBox4.Controls.Add(Me.txtStatusOld)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 409)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(210, 291)
        Me.GroupBox4.TabIndex = 98
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "เปลี่ยนสถานะ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(6, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "สถานะใหม่"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(9, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 20)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "สถานะเดิม"
        '
        'cmbStatusNew
        '
        Me.cmbStatusNew.FormattingEnabled = True
        Me.cmbStatusNew.Location = New System.Drawing.Point(6, 110)
        Me.cmbStatusNew.Name = "cmbStatusNew"
        Me.cmbStatusNew.Size = New System.Drawing.Size(181, 28)
        Me.cmbStatusNew.TabIndex = 20
        '
        'txtStatusOld
        '
        Me.txtStatusOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStatusOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStatusOld.Location = New System.Drawing.Point(9, 48)
        Me.txtStatusOld.Name = "txtStatusOld"
        Me.txtStatusOld.ReadOnly = True
        Me.txtStatusOld.Size = New System.Drawing.Size(178, 26)
        Me.txtStatusOld.TabIndex = 13
        '
        'btLoadCancel
        '
        Me.btLoadCancel.Location = New System.Drawing.Point(94, 149)
        Me.btLoadCancel.Name = "btLoadCancel"
        Me.btLoadCancel.Size = New System.Drawing.Size(75, 30)
        Me.btLoadCancel.TabIndex = 31
        Me.btLoadCancel.Text = "ยกเลิก"
        Me.btLoadCancel.UseVisualStyleBackColor = True
        '
        'btLoadSave
        '
        Me.btLoadSave.Location = New System.Drawing.Point(13, 149)
        Me.btLoadSave.Name = "btLoadSave"
        Me.btLoadSave.Size = New System.Drawing.Size(75, 30)
        Me.btLoadSave.TabIndex = 30
        Me.btLoadSave.Text = "บักทึก"
        Me.btLoadSave.UseVisualStyleBackColor = True
        '
        'frmLoadMixEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 746)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.UcMenutxtSub4)
        Me.Controls.Add(Me.UcMenutxtSub3)
        Me.Controls.Add(Me.UcMenutxtSub2)
        Me.Controls.Add(Me.UcMenutxtSub1)
        Me.Controls.Add(Me.UcMenuRefresh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadMixEdit"
        Me.Text = " frmLoadMixEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCardBilNew As System.Windows.Forms.TextBox
    Friend WithEvents txtCardBilOle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCardBil As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbDrive As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDriveOld As System.Windows.Forms.TextBox
    Friend WithEvents txtDriveNew As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTuTail As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTuTailOld As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTuHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTuHeadOld As System.Windows.Forms.TextBox
    Friend WithEvents btCardCancel As System.Windows.Forms.Button
    Friend WithEvents btCardSave As System.Windows.Forms.Button
    Friend WithEvents btDriverCancel As System.Windows.Forms.Button
    Friend WithEvents btDriverSave As System.Windows.Forms.Button
    Friend WithEvents btTuCancel As System.Windows.Forms.Button
    Friend WithEvents btTuSave As System.Windows.Forms.Button
    Friend WithEvents UcMenuRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenutxtSub1 As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenutxtSub2 As GINNTAS.ucMenutxtSub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLoad_No As System.Windows.Forms.TextBox
    Friend WithEvents UcMenutxtSub3 As GINNTAS.ucMenutxtSub
    Friend WithEvents txtTuTailNew As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTuHeadNew As System.Windows.Forms.TextBox
    Friend WithEvents UcMenutxtSub4 As ucMenutxtSub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btLoadCancel As Button
    Friend WithEvents btLoadSave As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbStatusNew As ComboBox
    Friend WithEvents txtStatusOld As TextBox
End Class
