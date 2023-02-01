<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMIProcessSlop
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMMIProcessSlop))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TimerAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.TimerScan = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.statusPump2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPN_temp = New System.Windows.Forms.TextBox()
        Me.anigifTemp = New System.Windows.Forms.PictureBox()
        Me.cmdSetTemp = New System.Windows.Forms.Button()
        Me.lblTempName = New System.Windows.Forms.TextBox()
        Me.lbltemp = New System.Windows.Forms.TextBox()
        Me.lblAlramTemp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBitumentSlop = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.statusPump1 = New System.Windows.Forms.PictureBox()
        Me.lblTempH = New System.Windows.Forms.TextBox()
        Me.lblTempHH = New System.Windows.Forms.TextBox()
        Me.lblTempL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTempLL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLevelH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLevelHH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLevelL = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.TextBox()
        Me.lblLevelLL = New System.Windows.Forms.TextBox()
        Me.anigifPump = New System.Windows.Forms.PictureBox()
        Me.lblLevelName = New System.Windows.Forms.TextBox()
        Me.lblPN_Level = New System.Windows.Forms.TextBox()
        Me.lblLevelAlram = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSetLevel = New System.Windows.Forms.Button()
        Me.picBaseOilSlop = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UcTank2 = New GINNTAS.ucTank()
        Me.UcTank3 = New GINNTAS.ucTank()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.pnBaseOilSlop = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.statusPump2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anigifTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBitumentSlop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.statusPump1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anigifPump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBaseOilSlop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnBaseOilSlop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 1059)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2555, 43)
        Me.Panel3.TabIndex = 216
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 130)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2555, 49)
        Me.Panel4.TabIndex = 218
        '
        'TimerAlarm
        '
        '
        'TimerScan
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.statusPump2)
        Me.GroupBox2.Controls.Add(Me.UcTank3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblPN_temp)
        Me.GroupBox2.Controls.Add(Me.anigifTemp)
        Me.GroupBox2.Controls.Add(Me.cmdSetTemp)
        Me.GroupBox2.Controls.Add(Me.lblTempName)
        Me.GroupBox2.Controls.Add(Me.lbltemp)
        Me.GroupBox2.Controls.Add(Me.lblAlramTemp)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.picBitumentSlop)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(2555, 436)
        Me.GroupBox2.TabIndex = 269
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bitument Slop"
        '
        'statusPump2
        '
        Me.statusPump2.BackColor = System.Drawing.Color.Transparent
        Me.statusPump2.BackgroundImage = Global.GINNTAS.My.Resources.Resources.green1
        Me.statusPump2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.statusPump2.Location = New System.Drawing.Point(681, 233)
        Me.statusPump2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.statusPump2.Name = "statusPump2"
        Me.statusPump2.Size = New System.Drawing.Size(45, 44)
        Me.statusPump2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.statusPump2.TabIndex = 118
        Me.statusPump2.TabStop = False
        Me.statusPump2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Name Slop :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 29)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Temp Slop :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 29)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Pump Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1335, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 25)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "PUMP STATUS"
        Me.Label11.Visible = False
        '
        'lblPN_temp
        '
        Me.lblPN_temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPN_temp.ForeColor = System.Drawing.Color.Black
        Me.lblPN_temp.Location = New System.Drawing.Point(193, 59)
        Me.lblPN_temp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPN_temp.Name = "lblPN_temp"
        Me.lblPN_temp.Size = New System.Drawing.Size(215, 34)
        Me.lblPN_temp.TabIndex = 98
        '
        'anigifTemp
        '
        Me.anigifTemp.BackColor = System.Drawing.Color.Transparent
        Me.anigifTemp.Image = CType(resources.GetObject("anigifTemp.Image"), System.Drawing.Image)
        Me.anigifTemp.Location = New System.Drawing.Point(904, 50)
        Me.anigifTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.anigifTemp.Name = "anigifTemp"
        Me.anigifTemp.Size = New System.Drawing.Size(30, 27)
        Me.anigifTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.anigifTemp.TabIndex = 104
        Me.anigifTemp.TabStop = False
        Me.anigifTemp.Visible = False
        '
        'cmdSetTemp
        '
        Me.cmdSetTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetTemp.Location = New System.Drawing.Point(784, 145)
        Me.cmdSetTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSetTemp.Name = "cmdSetTemp"
        Me.cmdSetTemp.Size = New System.Drawing.Size(129, 43)
        Me.cmdSetTemp.TabIndex = 106
        Me.cmdSetTemp.Text = "Set Temp"
        Me.cmdSetTemp.UseVisualStyleBackColor = True
        '
        'lblTempName
        '
        Me.lblTempName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTempName.ForeColor = System.Drawing.Color.Black
        Me.lblTempName.Location = New System.Drawing.Point(193, 144)
        Me.lblTempName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTempName.Name = "lblTempName"
        Me.lblTempName.Size = New System.Drawing.Size(215, 34)
        Me.lblTempName.TabIndex = 102
        '
        'lbltemp
        '
        Me.lbltemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbltemp.ForeColor = System.Drawing.Color.Black
        Me.lbltemp.Location = New System.Drawing.Point(193, 101)
        Me.lbltemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbltemp.Name = "lbltemp"
        Me.lbltemp.Size = New System.Drawing.Size(215, 34)
        Me.lbltemp.TabIndex = 101
        '
        'lblAlramTemp
        '
        Me.lblAlramTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAlramTemp.Location = New System.Drawing.Point(645, 53)
        Me.lblAlramTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblAlramTemp.Name = "lblAlramTemp"
        Me.lblAlramTemp.Size = New System.Drawing.Size(215, 34)
        Me.lblAlramTemp.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(433, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 29)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "TEMPERATURE"
        '
        'picBitumentSlop
        '
        Me.picBitumentSlop.BackgroundImage = Global.GINNTAS.My.Resources.Resources.Process_Slop1
        Me.picBitumentSlop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBitumentSlop.Location = New System.Drawing.Point(7, 31)
        Me.picBitumentSlop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBitumentSlop.Name = "picBitumentSlop"
        Me.picBitumentSlop.Size = New System.Drawing.Size(2523, 538)
        Me.picBitumentSlop.TabIndex = 121
        Me.picBitumentSlop.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.statusPump1)
        Me.GroupBox1.Controls.Add(Me.lblTempH)
        Me.GroupBox1.Controls.Add(Me.UcTank2)
        Me.GroupBox1.Controls.Add(Me.lblTempHH)
        Me.GroupBox1.Controls.Add(Me.lblTempL)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTempLL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblLevelH)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblLevelHH)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblLevelL)
        Me.GroupBox1.Controls.Add(Me.lblValue)
        Me.GroupBox1.Controls.Add(Me.lblLevelLL)
        Me.GroupBox1.Controls.Add(Me.anigifPump)
        Me.GroupBox1.Controls.Add(Me.lblLevelName)
        Me.GroupBox1.Controls.Add(Me.lblPN_Level)
        Me.GroupBox1.Controls.Add(Me.lblLevelAlram)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdSetLevel)
        Me.GroupBox1.Controls.Add(Me.picBaseOilSlop)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(2555, 440)
        Me.GroupBox1.TabIndex = 268
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Oil Slop"
        '
        'statusPump1
        '
        Me.statusPump1.BackColor = System.Drawing.Color.Transparent
        Me.statusPump1.BackgroundImage = Global.GINNTAS.My.Resources.Resources.green1
        Me.statusPump1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.statusPump1.Location = New System.Drawing.Point(684, 233)
        Me.statusPump1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.statusPump1.Name = "statusPump1"
        Me.statusPump1.Size = New System.Drawing.Size(45, 44)
        Me.statusPump1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.statusPump1.TabIndex = 118
        Me.statusPump1.TabStop = False
        Me.statusPump1.Visible = False
        '
        'lblTempH
        '
        Me.lblTempH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTempH.Location = New System.Drawing.Point(1495, 416)
        Me.lblTempH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTempH.Name = "lblTempH"
        Me.lblTempH.Size = New System.Drawing.Size(136, 30)
        Me.lblTempH.TabIndex = 276
        Me.lblTempH.Visible = False
        '
        'lblTempHH
        '
        Me.lblTempHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTempHH.Location = New System.Drawing.Point(1495, 450)
        Me.lblTempHH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTempHH.Name = "lblTempHH"
        Me.lblTempHH.Size = New System.Drawing.Size(136, 30)
        Me.lblTempHH.TabIndex = 277
        Me.lblTempHH.Visible = False
        '
        'lblTempL
        '
        Me.lblTempL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTempL.Location = New System.Drawing.Point(1495, 382)
        Me.lblTempL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTempL.Name = "lblTempL"
        Me.lblTempL.Size = New System.Drawing.Size(136, 30)
        Me.lblTempL.TabIndex = 275
        Me.lblTempL.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 25)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Name Slop :"
        '
        'lblTempLL
        '
        Me.lblTempLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTempLL.Location = New System.Drawing.Point(1495, 346)
        Me.lblTempLL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTempLL.Name = "lblTempLL"
        Me.lblTempLL.Size = New System.Drawing.Size(136, 30)
        Me.lblTempLL.TabIndex = 274
        Me.lblTempLL.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(37, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Level Slop :"
        '
        'lblLevelH
        '
        Me.lblLevelH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLevelH.Location = New System.Drawing.Point(1331, 417)
        Me.lblLevelH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelH.Name = "lblLevelH"
        Me.lblLevelH.Size = New System.Drawing.Size(136, 30)
        Me.lblLevelH.TabIndex = 272
        Me.lblLevelH.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Pump Name :"
        '
        'lblLevelHH
        '
        Me.lblLevelHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLevelHH.Location = New System.Drawing.Point(1331, 452)
        Me.lblLevelHH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelHH.Name = "lblLevelHH"
        Me.lblLevelHH.Size = New System.Drawing.Size(136, 30)
        Me.lblLevelHH.TabIndex = 273
        Me.lblLevelHH.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "PUMP STATUS"
        Me.Label5.Visible = False
        '
        'lblLevelL
        '
        Me.lblLevelL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLevelL.Location = New System.Drawing.Point(1331, 383)
        Me.lblLevelL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelL.Name = "lblLevelL"
        Me.lblLevelL.Size = New System.Drawing.Size(136, 30)
        Me.lblLevelL.TabIndex = 271
        Me.lblLevelL.Visible = False
        '
        'lblValue
        '
        Me.lblValue.ForeColor = System.Drawing.Color.Black
        Me.lblValue.Location = New System.Drawing.Point(168, 79)
        Me.lblValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(215, 30)
        Me.lblValue.TabIndex = 99
        '
        'lblLevelLL
        '
        Me.lblLevelLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLevelLL.Location = New System.Drawing.Point(1331, 346)
        Me.lblLevelLL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelLL.Name = "lblLevelLL"
        Me.lblLevelLL.Size = New System.Drawing.Size(136, 30)
        Me.lblLevelLL.TabIndex = 270
        Me.lblLevelLL.Visible = False
        '
        'anigifPump
        '
        Me.anigifPump.BackColor = System.Drawing.Color.Transparent
        Me.anigifPump.Image = CType(resources.GetObject("anigifPump.Image"), System.Drawing.Image)
        Me.anigifPump.Location = New System.Drawing.Point(771, 107)
        Me.anigifPump.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.anigifPump.Name = "anigifPump"
        Me.anigifPump.Size = New System.Drawing.Size(30, 27)
        Me.anigifPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.anigifPump.TabIndex = 103
        Me.anigifPump.TabStop = False
        Me.anigifPump.Visible = False
        '
        'lblLevelName
        '
        Me.lblLevelName.ForeColor = System.Drawing.Color.Black
        Me.lblLevelName.Location = New System.Drawing.Point(168, 113)
        Me.lblLevelName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelName.Name = "lblLevelName"
        Me.lblLevelName.Size = New System.Drawing.Size(215, 30)
        Me.lblLevelName.TabIndex = 100
        '
        'lblPN_Level
        '
        Me.lblPN_Level.ForeColor = System.Drawing.Color.Black
        Me.lblPN_Level.Location = New System.Drawing.Point(168, 44)
        Me.lblPN_Level.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPN_Level.Name = "lblPN_Level"
        Me.lblPN_Level.Size = New System.Drawing.Size(215, 30)
        Me.lblPN_Level.TabIndex = 96
        '
        'lblLevelAlram
        '
        Me.lblLevelAlram.Location = New System.Drawing.Point(647, 41)
        Me.lblLevelAlram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLevelAlram.Name = "lblLevelAlram"
        Me.lblLevelAlram.Size = New System.Drawing.Size(215, 30)
        Me.lblLevelAlram.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(552, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "LEVEL"
        '
        'cmdSetLevel
        '
        Me.cmdSetLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetLevel.Location = New System.Drawing.Point(785, 160)
        Me.cmdSetLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSetLevel.Name = "cmdSetLevel"
        Me.cmdSetLevel.Size = New System.Drawing.Size(129, 44)
        Me.cmdSetLevel.TabIndex = 87
        Me.cmdSetLevel.Text = "Set Level"
        Me.cmdSetLevel.UseVisualStyleBackColor = True
        '
        'picBaseOilSlop
        '
        Me.picBaseOilSlop.BackgroundImage = Global.GINNTAS.My.Resources.Resources.Process_Slop2
        Me.picBaseOilSlop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBaseOilSlop.Location = New System.Drawing.Point(9, 31)
        Me.picBaseOilSlop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBaseOilSlop.Name = "picBaseOilSlop"
        Me.picBaseOilSlop.Size = New System.Drawing.Size(2521, 533)
        Me.picBaseOilSlop.TabIndex = 120
        Me.picBaseOilSlop.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 179)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnBaseOilSlop)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(2555, 880)
        Me.SplitContainer1.SplitterDistance = 440
        Me.SplitContainer1.TabIndex = 270
        '
        'UcTank2
        '
        Me.UcTank2.BackColor = System.Drawing.Color.Transparent
        Me.UcTank2.Location = New System.Drawing.Point(204, 274)
        Me.UcTank2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UcTank2.Name = "UcTank2"
        Me.UcTank2.Size = New System.Drawing.Size(507, 223)
        Me.UcTank2.TabIndex = 113
        '
        'UcTank3
        '
        Me.UcTank3.BackColor = System.Drawing.Color.Transparent
        Me.UcTank3.Enabled = False
        Me.UcTank3.Location = New System.Drawing.Point(195, 257)
        Me.UcTank3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.UcTank3.Name = "UcTank3"
        Me.UcTank3.Size = New System.Drawing.Size(193, 206)
        Me.UcTank3.TabIndex = 113
        Me.UcTank3.Visible = False
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(2553, 41)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(2384, 0)
        Me.UcBack1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(169, 43)
        Me.UcBack1.TabIndex = 3
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(2555, 130)
        Me.UcHeader1.TabIndex = 217
        '
        'pnBaseOilSlop
        '
        Me.pnBaseOilSlop.AutoScroll = True
        Me.pnBaseOilSlop.Controls.Add(Me.GroupBox1)
        Me.pnBaseOilSlop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBaseOilSlop.Location = New System.Drawing.Point(0, 0)
        Me.pnBaseOilSlop.Name = "pnBaseOilSlop"
        Me.pnBaseOilSlop.Size = New System.Drawing.Size(2555, 440)
        Me.pnBaseOilSlop.TabIndex = 269
        '
        'frmMMIProcessSlop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2555, 1102)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMMIProcessSlop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMMITank"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.statusPump2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anigifTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBitumentSlop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.statusPump1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anigifPump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBaseOilSlop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnBaseOilSlop.ResumeLayout(False)
        Me.pnBaseOilSlop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents TimerAlarm As System.Windows.Forms.Timer
    Friend WithEvents TimerScan As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents statusPump2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPN_temp As System.Windows.Forms.TextBox
    Friend WithEvents anigifTemp As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSetTemp As System.Windows.Forms.Button
    Friend WithEvents lblTempName As System.Windows.Forms.TextBox
    Friend WithEvents UcTank3 As GINNTAS.ucTank
    Friend WithEvents lbltemp As System.Windows.Forms.TextBox
    Friend WithEvents lblAlramTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLevelH As System.Windows.Forms.TextBox
    Friend WithEvents lblLevelHH As System.Windows.Forms.TextBox
    Friend WithEvents lblLevelL As System.Windows.Forms.TextBox
    Friend WithEvents lblLevelLL As System.Windows.Forms.TextBox
    Friend WithEvents lblTempH As System.Windows.Forms.TextBox
    Friend WithEvents lblTempHH As System.Windows.Forms.TextBox
    Friend WithEvents lblTempL As System.Windows.Forms.TextBox
    Friend WithEvents lblTempLL As System.Windows.Forms.TextBox
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents statusPump1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.TextBox
    Friend WithEvents anigifPump As System.Windows.Forms.PictureBox
    Friend WithEvents lblLevelName As System.Windows.Forms.TextBox
    Friend WithEvents lblPN_Level As System.Windows.Forms.TextBox
    Friend WithEvents lblLevelAlram As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSetLevel As System.Windows.Forms.Button
    Friend WithEvents UcTank2 As GINNTAS.ucTank
    Friend WithEvents picBaseOilSlop As System.Windows.Forms.PictureBox
    Friend WithEvents picBitumentSlop As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnBaseOilSlop As Panel
End Class
