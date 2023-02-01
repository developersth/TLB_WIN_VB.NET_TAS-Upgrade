<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlCreateLoad1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtlCreateLoad1))
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.UcMinimize1 = New GINNTAS.ucMinimize()
        Me.UcClose1 = New GINNTAS.ucClose()
        Me.UcStatus1 = New GINNTAS.ucStatus()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.cmdPaste = New System.Windows.Forms.Button()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.cmdOldDetailVechicle = New System.Windows.Forms.Button()
        Me.cmdrefresh = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.CmdAddDriver = New System.Windows.Forms.Button()
        Me.Cmdtruck1 = New System.Windows.Forms.Button()
        Me.CmdAdtruck = New System.Windows.Forms.Button()
        Me.CmdAddCard = New System.Windows.Forms.Button()
        Me.cmdCalSeal = New System.Windows.Forms.Button()
        Me.AddDo = New System.Windows.Forms.Button()
        Me.CmdFindDriver = New System.Windows.Forms.Button()
        Me.CmdFindVechcle2 = New System.Windows.Forms.Button()
        Me.cmdFindVechicle = New System.Windows.Forms.Button()
        Me.cmdFineCard = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.msGridComp = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSealCount = New System.Windows.Forms.TextBox()
        Me.txtSumCapComp = New System.Windows.Forms.TextBox()
        Me.txtTotalComp = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DTPTime = New System.Windows.Forms.DateTimePicker()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDriverBil = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTail = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTUHead = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCardBil = New System.Windows.Forms.ComboBox()
        Me.MenuStatusBar = New GINNTAS.ucPanelStatuses()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.msGridComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleName
        '
        Me.lblTitleName.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitleName.Location = New System.Drawing.Point(565, 12)
        Me.lblTitleName.Name = "lblTitleName"
        Me.lblTitleName.Size = New System.Drawing.Size(147, 31)
        Me.lblTitleName.TabIndex = 20
        Me.lblTitleName.Text = "TitleName"
        Me.lblTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UcMinimize1
        '
        Me.UcMinimize1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMinimize1.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMinimize1.Location = New System.Drawing.Point(876, 12)
        Me.UcMinimize1.Name = "UcMinimize1"
        Me.UcMinimize1.Size = New System.Drawing.Size(65, 67)
        Me.UcMinimize1.TabIndex = 12
        '
        'UcClose1
        '
        Me.UcClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcClose1.BackColor = System.Drawing.Color.Transparent
        Me.UcClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcClose1.Location = New System.Drawing.Point(947, 12)
        Me.UcClose1.Name = "UcClose1"
        Me.UcClose1.Size = New System.Drawing.Size(65, 67)
        Me.UcClose1.TabIndex = 11
        '
        'UcStatus1
        '
        Me.UcStatus1.BackColor = System.Drawing.Color.Transparent
        Me.UcStatus1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcStatus1.Location = New System.Drawing.Point(0, 640)
        Me.UcStatus1.Name = "UcStatus1"
        Me.UcStatus1.Size = New System.Drawing.Size(1024, 128)
        Me.UcStatus1.TabIndex = 13
        Me.UcStatus1.TabStop = False
        Me.UcStatus1.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ป้อน Seal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(242, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "เลือก DO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "วัน-เวลา"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdPaste)
        Me.GroupBox2.Controls.Add(Me.cmdCopy)
        Me.GroupBox2.Controls.Add(Me.cmdOldDetailVechicle)
        Me.GroupBox2.Controls.Add(Me.cmdrefresh)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(748, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 247)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลช่องเติม"
        '
        'CmdDelete
        '
        Me.CmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdDelete.Location = New System.Drawing.Point(16, 170)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(75, 28)
        Me.CmdDelete.TabIndex = 26
        Me.CmdDelete.Text = "CmdDelete"
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPaste
        '
        Me.cmdPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPaste.Location = New System.Drawing.Point(16, 136)
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(75, 28)
        Me.cmdPaste.TabIndex = 25
        Me.cmdPaste.Text = "cmdPaste"
        Me.cmdPaste.UseVisualStyleBackColor = True
        '
        'cmdCopy
        '
        Me.cmdCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdCopy.Location = New System.Drawing.Point(16, 102)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(75, 28)
        Me.cmdCopy.TabIndex = 24
        Me.cmdCopy.Text = "&Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'cmdOldDetailVechicle
        '
        Me.cmdOldDetailVechicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdOldDetailVechicle.Location = New System.Drawing.Point(16, 68)
        Me.cmdOldDetailVechicle.Name = "cmdOldDetailVechicle"
        Me.cmdOldDetailVechicle.Size = New System.Drawing.Size(75, 28)
        Me.cmdOldDetailVechicle.TabIndex = 23
        Me.cmdOldDetailVechicle.Text = "ดูข้อมูล Load เดิม"
        Me.cmdOldDetailVechicle.UseVisualStyleBackColor = True
        '
        'cmdrefresh
        '
        Me.cmdrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdrefresh.Location = New System.Drawing.Point(16, 34)
        Me.cmdrefresh.Name = "cmdrefresh"
        Me.cmdrefresh.Size = New System.Drawing.Size(75, 28)
        Me.cmdrefresh.TabIndex = 22
        Me.cmdrefresh.Text = "Refresh"
        Me.cmdrefresh.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button11.Location = New System.Drawing.Point(651, 311)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(90, 28)
        Me.Button11.TabIndex = 56
        Me.Button11.Text = "เพิ่ม/แก้ไข"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'CmdAddDriver
        '
        Me.CmdAddDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdAddDriver.Location = New System.Drawing.Point(651, 248)
        Me.CmdAddDriver.Name = "CmdAddDriver"
        Me.CmdAddDriver.Size = New System.Drawing.Size(90, 28)
        Me.CmdAddDriver.TabIndex = 55
        Me.CmdAddDriver.Text = "เพิ่ม/แก้ไข"
        Me.CmdAddDriver.UseVisualStyleBackColor = True
        '
        'Cmdtruck1
        '
        Me.Cmdtruck1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmdtruck1.Location = New System.Drawing.Point(651, 211)
        Me.Cmdtruck1.Name = "Cmdtruck1"
        Me.Cmdtruck1.Size = New System.Drawing.Size(90, 28)
        Me.Cmdtruck1.TabIndex = 54
        Me.Cmdtruck1.Text = "เพิ่ม/แก้ไข"
        Me.Cmdtruck1.UseVisualStyleBackColor = True
        '
        'CmdAdtruck
        '
        Me.CmdAdtruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdAdtruck.Location = New System.Drawing.Point(651, 177)
        Me.CmdAdtruck.Name = "CmdAdtruck"
        Me.CmdAdtruck.Size = New System.Drawing.Size(90, 28)
        Me.CmdAdtruck.TabIndex = 53
        Me.CmdAdtruck.Text = "เพิ่ม/แก้ไข"
        Me.CmdAdtruck.UseVisualStyleBackColor = True
        '
        'CmdAddCard
        '
        Me.CmdAddCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdAddCard.Location = New System.Drawing.Point(651, 142)
        Me.CmdAddCard.Name = "CmdAddCard"
        Me.CmdAddCard.Size = New System.Drawing.Size(90, 28)
        Me.CmdAddCard.TabIndex = 52
        Me.CmdAddCard.Text = "เพิ่ม/แก้ไข"
        Me.CmdAddCard.UseVisualStyleBackColor = True
        '
        'cmdCalSeal
        '
        Me.cmdCalSeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdCalSeal.Location = New System.Drawing.Point(570, 344)
        Me.cmdCalSeal.Name = "cmdCalSeal"
        Me.cmdCalSeal.Size = New System.Drawing.Size(75, 28)
        Me.cmdCalSeal.TabIndex = 51
        Me.cmdCalSeal.Text = "ค้นหา"
        Me.cmdCalSeal.UseVisualStyleBackColor = True
        '
        'AddDo
        '
        Me.AddDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddDo.Location = New System.Drawing.Point(570, 312)
        Me.AddDo.Name = "AddDo"
        Me.AddDo.Size = New System.Drawing.Size(75, 28)
        Me.AddDo.TabIndex = 50
        Me.AddDo.Text = "ค้นหา"
        Me.AddDo.UseVisualStyleBackColor = True
        '
        'CmdFindDriver
        '
        Me.CmdFindDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdFindDriver.Location = New System.Drawing.Point(570, 245)
        Me.CmdFindDriver.Name = "CmdFindDriver"
        Me.CmdFindDriver.Size = New System.Drawing.Size(75, 28)
        Me.CmdFindDriver.TabIndex = 49
        Me.CmdFindDriver.Text = "ค้นหา"
        Me.CmdFindDriver.UseVisualStyleBackColor = True
        '
        'CmdFindVechcle2
        '
        Me.CmdFindVechcle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdFindVechcle2.Location = New System.Drawing.Point(570, 211)
        Me.CmdFindVechcle2.Name = "CmdFindVechcle2"
        Me.CmdFindVechcle2.Size = New System.Drawing.Size(75, 28)
        Me.CmdFindVechcle2.TabIndex = 47
        Me.CmdFindVechcle2.Text = "ค้นหา"
        Me.CmdFindVechcle2.UseVisualStyleBackColor = True
        '
        'cmdFindVechicle
        '
        Me.cmdFindVechicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdFindVechicle.Location = New System.Drawing.Point(570, 177)
        Me.cmdFindVechicle.Name = "cmdFindVechicle"
        Me.cmdFindVechicle.Size = New System.Drawing.Size(75, 28)
        Me.cmdFindVechicle.TabIndex = 46
        Me.cmdFindVechicle.Text = "ค้นหา"
        Me.cmdFindVechicle.UseVisualStyleBackColor = True
        '
        'cmdFineCard
        '
        Me.cmdFineCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdFineCard.Location = New System.Drawing.Point(570, 143)
        Me.cmdFineCard.Name = "cmdFineCard"
        Me.cmdFineCard.Size = New System.Drawing.Size(75, 28)
        Me.cmdFineCard.TabIndex = 45
        Me.cmdFineCard.Text = "ค้นหา"
        Me.cmdFineCard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.msGridComp)
        Me.GroupBox1.Controls.Add(Me.txtSealCount)
        Me.GroupBox1.Controls.Add(Me.txtSumCapComp)
        Me.GroupBox1.Controls.Add(Me.txtTotalComp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(169, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 247)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลช่องเติม"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "จำนวนซีล"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "ความจุรวม"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(-3, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "จำนวนช่องรวม"
        '
        'msGridComp
        '
        Me.msGridComp.AllowUserToAddRows = False
        Me.msGridComp.AllowUserToDeleteRows = False
        Me.msGridComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msGridComp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.msGridComp.Location = New System.Drawing.Point(172, 15)
        Me.msGridComp.Name = "msGridComp"
        Me.msGridComp.ReadOnly = True
        Me.msGridComp.RowHeadersVisible = False
        Me.msGridComp.Size = New System.Drawing.Size(365, 216)
        Me.msGridComp.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "ช่องเติม"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ทะเบียนรถ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ความจุช่อง"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'txtSealCount
        '
        Me.txtSealCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSealCount.Location = New System.Drawing.Point(96, 109)
        Me.txtSealCount.Name = "txtSealCount"
        Me.txtSealCount.Size = New System.Drawing.Size(51, 26)
        Me.txtSealCount.TabIndex = 16
        '
        'txtSumCapComp
        '
        Me.txtSumCapComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSumCapComp.Location = New System.Drawing.Point(96, 73)
        Me.txtSumCapComp.Name = "txtSumCapComp"
        Me.txtSumCapComp.Size = New System.Drawing.Size(52, 26)
        Me.txtSumCapComp.TabIndex = 15
        '
        'txtTotalComp
        '
        Me.txtTotalComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalComp.Location = New System.Drawing.Point(97, 36)
        Me.txtTotalComp.Name = "txtTotalComp"
        Me.txtTotalComp.Size = New System.Drawing.Size(51, 26)
        Me.txtTotalComp.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(314, 344)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(241, 26)
        Me.TextBox2.TabIndex = 43
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(314, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 26)
        Me.TextBox1.TabIndex = 42
        '
        'DTPTime
        '
        Me.DTPTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTime.Location = New System.Drawing.Point(441, 279)
        Me.DTPTime.Name = "DTPTime"
        Me.DTPTime.ShowUpDown = True
        Me.DTPTime.Size = New System.Drawing.Size(114, 26)
        Me.DTPTime.TabIndex = 41
        '
        'DTPdate
        '
        Me.DTPdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdate.Location = New System.Drawing.Point(314, 279)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(114, 26)
        Me.DTPdate.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "รหัสพนักงานขับรถ"
        '
        'cbDriverBil
        '
        Me.cbDriverBil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbDriverBil.FormattingEnabled = True
        Me.cbDriverBil.Location = New System.Drawing.Point(314, 245)
        Me.cbDriverBil.Name = "cbDriverBil"
        Me.cbDriverBil.Size = New System.Drawing.Size(241, 28)
        Me.cbDriverBil.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ทะเบียนตัวพ่วง"
        '
        'cbTail
        '
        Me.cbTail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTail.FormattingEnabled = True
        Me.cbTail.Location = New System.Drawing.Point(314, 211)
        Me.cbTail.Name = "cbTail"
        Me.cbTail.Size = New System.Drawing.Size(241, 28)
        Me.cbTail.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ทะเบียนหัวลาก"
        '
        'cbTUHead
        '
        Me.cbTUHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTUHead.FormattingEnabled = True
        Me.cbTUHead.Location = New System.Drawing.Point(314, 177)
        Me.cbTUHead.Name = "cbTUHead"
        Me.cbTUHead.Size = New System.Drawing.Size(241, 28)
        Me.cbTUHead.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "หมายเลขบัตรรถ"
        '
        'cbCardBil
        '
        Me.cbCardBil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCardBil.FormattingEnabled = True
        Me.cbCardBil.Location = New System.Drawing.Point(314, 143)
        Me.cbCardBil.Name = "cbCardBil"
        Me.cbCardBil.Size = New System.Drawing.Size(241, 28)
        Me.cbCardBil.TabIndex = 32
        '
        'MenuStatusBar
        '
        Me.MenuStatusBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStatusBar.BackColor = System.Drawing.Color.Transparent
        Me.MenuStatusBar.Location = New System.Drawing.Point(6, 731)
        Me.MenuStatusBar.Name = "MenuStatusBar"
        Me.MenuStatusBar.Size = New System.Drawing.Size(839, 28)
        Me.MenuStatusBar.TabIndex = 136
        '
        'frmUtlCreateLoad1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.MenuStatusBar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.CmdAddDriver)
        Me.Controls.Add(Me.Cmdtruck1)
        Me.Controls.Add(Me.CmdAdtruck)
        Me.Controls.Add(Me.CmdAddCard)
        Me.Controls.Add(Me.cmdCalSeal)
        Me.Controls.Add(Me.AddDo)
        Me.Controls.Add(Me.CmdFindDriver)
        Me.Controls.Add(Me.CmdFindVechcle2)
        Me.Controls.Add(Me.cmdFindVechicle)
        Me.Controls.Add(Me.cmdFineCard)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DTPTime)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbDriverBil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTUHead)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCardBil)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.UcMinimize1)
        Me.Controls.Add(Me.UcClose1)
        Me.Controls.Add(Me.UcStatus1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmUtlCreateLoad1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.msGridComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcMinimize1 As GINNTAS.ucMinimize
    Friend WithEvents UcClose1 As GINNTAS.ucClose
    Friend WithEvents UcStatus1 As GINNTAS.ucStatus
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdPaste As System.Windows.Forms.Button
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents cmdOldDetailVechicle As System.Windows.Forms.Button
    Friend WithEvents cmdrefresh As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents CmdAddDriver As System.Windows.Forms.Button
    Friend WithEvents Cmdtruck1 As System.Windows.Forms.Button
    Friend WithEvents CmdAdtruck As System.Windows.Forms.Button
    Friend WithEvents CmdAddCard As System.Windows.Forms.Button
    Friend WithEvents cmdCalSeal As System.Windows.Forms.Button
    Friend WithEvents AddDo As System.Windows.Forms.Button
    Friend WithEvents CmdFindDriver As System.Windows.Forms.Button
    Friend WithEvents CmdFindVechcle2 As System.Windows.Forms.Button
    Friend WithEvents cmdFindVechicle As System.Windows.Forms.Button
    Friend WithEvents cmdFineCard As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents msGridComp As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSealCount As System.Windows.Forms.TextBox
    Friend WithEvents txtSumCapComp As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalComp As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DTPTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDriverBil As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTail As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTUHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCardBil As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStatusBar As GINNTAS.ucPanelStatuses
End Class
