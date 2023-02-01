<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcFlowLoading
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcFlowLoading))
        Me.tScan = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.cmdESD = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.cmdSetLevel = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtMeter = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.lblSideC = New System.Windows.Forms.Label()
        Me.AniBllVale = New System.Windows.Forms.PictureBox()
        Me.AniPump = New System.Windows.Forms.PictureBox()
        Me.UcProgress = New GINNTAS.UcProgressOil()
        Me.AniGiflow = New System.Windows.Forms.PictureBox()
        Me.UcProgressLevelTank = New GINNTAS.UcProgressOil()
        Me.AniGifFlowGreen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AniBllVale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AniPump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AniGiflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AniGifFlowGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tScan
        '
        Me.tScan.Interval = 300
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox22.Enabled = False
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox22.Location = New System.Drawing.Point(2297, 126)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(91, 23)
        Me.TextBox22.TabIndex = 21
        Me.TextBox22.Text = "EarthA"
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox23.Enabled = False
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox23.Location = New System.Drawing.Point(2297, 153)
        Me.TextBox23.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(91, 23)
        Me.TextBox23.TabIndex = 22
        Me.TextBox23.Text = "Over SpillA"
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox21.Enabled = False
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox21.Location = New System.Drawing.Point(2297, 99)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(91, 23)
        Me.TextBox21.TabIndex = 20
        Me.TextBox21.Text = "ArmDownA"
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox24.Enabled = False
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox24.Location = New System.Drawing.Point(2297, 180)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(91, 23)
        Me.TextBox24.TabIndex = 23
        Me.TextBox24.Text = "Permissive"
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox20.Enabled = False
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox20.Location = New System.Drawing.Point(2297, 71)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(91, 23)
        Me.TextBox20.TabIndex = 19
        Me.TextBox20.Text = "BallValveA"
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox25.Enabled = False
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox25.Location = New System.Drawing.Point(2397, 43)
        Me.TextBox25.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(91, 23)
        Me.TextBox25.TabIndex = 24
        Me.TextBox25.Text = "ArmSideB"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox19.Enabled = False
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox19.Location = New System.Drawing.Point(2297, 43)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(91, 23)
        Me.TextBox19.TabIndex = 18
        Me.TextBox19.Text = "ArmSideA"
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox26.Enabled = False
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox26.Location = New System.Drawing.Point(2396, 71)
        Me.TextBox26.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(91, 23)
        Me.TextBox26.TabIndex = 25
        Me.TextBox26.Text = "BallValveB"
        '
        'TextBox18
        '
        Me.TextBox18.Enabled = False
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(824, 11)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(200, 26)
        Me.TextBox18.TabIndex = 17
        Me.TextBox18.Text = "txtLoadNo"
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox27.Enabled = False
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox27.Location = New System.Drawing.Point(2397, 98)
        Me.TextBox27.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(91, 23)
        Me.TextBox27.TabIndex = 26
        Me.TextBox27.Text = "ArmDownB"
        '
        'TextBox17
        '
        Me.TextBox17.Enabled = False
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(2045, 37)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(188, 26)
        Me.TextBox17.TabIndex = 16
        Me.TextBox17.Text = "txtCompNo"
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox28.Enabled = False
        Me.TextBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox28.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox28.Location = New System.Drawing.Point(2397, 125)
        Me.TextBox28.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(91, 23)
        Me.TextBox28.TabIndex = 27
        Me.TextBox28.Text = "EarthB"
        '
        'TextBox16
        '
        Me.TextBox16.Enabled = False
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(1423, 214)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(241, 26)
        Me.TextBox16.TabIndex = 15
        Me.TextBox16.Text = "txtDriverName"
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox29.Enabled = False
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox29.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox29.Location = New System.Drawing.Point(2397, 153)
        Me.TextBox29.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(91, 23)
        Me.TextBox29.TabIndex = 28
        Me.TextBox29.Text = "Over SpillB"
        '
        'TextBox15
        '
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(1423, 186)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(241, 26)
        Me.TextBox15.TabIndex = 14
        Me.TextBox15.Text = "txtVechicle"
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox30.Enabled = False
        Me.TextBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox30.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox30.Location = New System.Drawing.Point(2397, 180)
        Me.TextBox30.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(91, 23)
        Me.TextBox30.TabIndex = 29
        Me.TextBox30.Text = "Permissive"
        '
        'TextBox14
        '
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(1264, 188)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(151, 26)
        Me.TextBox14.TabIndex = 13
        Me.TextBox14.Text = "txtCardNo"
        '
        'TextBox31
        '
        Me.TextBox31.Enabled = False
        Me.TextBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox31.ForeColor = System.Drawing.Color.White
        Me.TextBox31.Location = New System.Drawing.Point(625, 66)
        Me.TextBox31.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(191, 26)
        Me.TextBox31.TabIndex = 30
        Me.TextBox31.Text = "-"
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(1659, 43)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(164, 26)
        Me.TextBox13.TabIndex = 12
        Me.TextBox13.Text = "txtArmSide"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(2296, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Side A"
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1124, 215)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(132, 26)
        Me.TextBox12.TabIndex = 11
        Me.TextBox12.Text = "txtFcvName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(2392, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Side B"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(625, 38)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(191, 26)
        Me.TextBox11.TabIndex = 10
        Me.TextBox11.Text = "txtPressure"
        '
        'cmdESD
        '
        Me.cmdESD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdESD.Location = New System.Drawing.Point(1432, 20)
        Me.cmdESD.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdESD.Name = "cmdESD"
        Me.cmdESD.Size = New System.Drawing.Size(111, 41)
        Me.cmdESD.TabIndex = 34
        Me.cmdESD.Text = "ESD"
        Me.cmdESD.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(625, 10)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(191, 26)
        Me.TextBox10.TabIndex = 9
        Me.TextBox10.Text = "txtPressurName"
        '
        'cmdSetLevel
        '
        Me.cmdSetLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdSetLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSetLevel.Location = New System.Drawing.Point(489, 46)
        Me.cmdSetLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSetLevel.Name = "cmdSetLevel"
        Me.cmdSetLevel.Size = New System.Drawing.Size(119, 37)
        Me.cmdSetLevel.TabIndex = 35
        Me.cmdSetLevel.Text = "ESD"
        Me.cmdSetLevel.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(824, 65)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(200, 26)
        Me.TextBox9.TabIndex = 8
        Me.TextBox9.Text = "txtTemp"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(824, 38)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(200, 26)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Text = "txtTempName"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(985, 188)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 26)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "txtFlow"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(489, 12)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(117, 26)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "txtProduct"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1124, 189)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 26)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Text = "txtFCpercent"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(2045, 10)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 26)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "txtStatus"
        '
        'txtMeter
        '
        Me.txtMeter.Enabled = False
        Me.txtMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMeter.Location = New System.Drawing.Point(985, 215)
        Me.txtMeter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMeter.Name = "txtMeter"
        Me.txtMeter.Size = New System.Drawing.Size(132, 26)
        Me.txtMeter.TabIndex = 39
        Me.txtMeter.Text = "txtMeter"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(523, 214)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(152, 26)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "txtPumpNameTxt"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(63, 212)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 26)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "txtDensity"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(64, 11)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "txtTankName"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.TextBox32)
        Me.GroupBox1.Controls.Add(Me.TextBox33)
        Me.GroupBox1.Controls.Add(Me.TextBox35)
        Me.GroupBox1.Controls.Add(Me.lblSideC)
        Me.GroupBox1.Controls.Add(Me.AniBllVale)
        Me.GroupBox1.Controls.Add(Me.AniPump)
        Me.GroupBox1.Controls.Add(Me.UcProgress)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.txtMeter)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.cmdSetLevel)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.cmdESD)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox31)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.TextBox30)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.TextBox29)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.TextBox28)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.TextBox27)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.TextBox26)
        Me.GroupBox1.Controls.Add(Me.TextBox19)
        Me.GroupBox1.Controls.Add(Me.TextBox25)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.TextBox24)
        Me.GroupBox1.Controls.Add(Me.TextBox21)
        Me.GroupBox1.Controls.Add(Me.TextBox23)
        Me.GroupBox1.Controls.Add(Me.TextBox22)
        Me.GroupBox1.Controls.Add(Me.AniGiflow)
        Me.GroupBox1.Controls.Add(Me.UcProgressLevelTank)
        Me.GroupBox1.Controls.Add(Me.AniGifFlowGreen)
        Me.GroupBox1.Location = New System.Drawing.Point(-37, -2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(2722, 245)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox32.Enabled = False
        Me.TextBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox32.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox32.Location = New System.Drawing.Point(2495, 180)
        Me.TextBox32.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(91, 23)
        Me.TextBox32.TabIndex = 49
        Me.TextBox32.Text = "Permissive"
        '
        'TextBox33
        '
        Me.TextBox33.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox33.Enabled = False
        Me.TextBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox33.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox33.Location = New System.Drawing.Point(2496, 124)
        Me.TextBox33.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(91, 23)
        Me.TextBox33.TabIndex = 48
        Me.TextBox33.Text = "EarthC"
        '
        'TextBox35
        '
        Me.TextBox35.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox35.Enabled = False
        Me.TextBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox35.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox35.Location = New System.Drawing.Point(2495, 71)
        Me.TextBox35.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(91, 23)
        Me.TextBox35.TabIndex = 46
        Me.TextBox35.Text = "BallValveC"
        '
        'lblSideC
        '
        Me.lblSideC.AutoSize = True
        Me.lblSideC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSideC.Location = New System.Drawing.Point(2502, 12)
        Me.lblSideC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSideC.Name = "lblSideC"
        Me.lblSideC.Size = New System.Drawing.Size(78, 25)
        Me.lblSideC.TabIndex = 44
        Me.lblSideC.Text = "Side C"
        '
        'AniBllVale
        '
        Me.AniBllVale.BackColor = System.Drawing.Color.Transparent
        Me.AniBllVale.Image = CType(resources.GetObject("AniBllVale.Image"), System.Drawing.Image)
        Me.AniBllVale.Location = New System.Drawing.Point(1925, 11)
        Me.AniBllVale.Margin = New System.Windows.Forms.Padding(4)
        Me.AniBllVale.Name = "AniBllVale"
        Me.AniBllVale.Size = New System.Drawing.Size(48, 48)
        Me.AniBllVale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AniBllVale.TabIndex = 41
        Me.AniBllVale.TabStop = False
        '
        'AniPump
        '
        Me.AniPump.BackColor = System.Drawing.Color.Transparent
        Me.AniPump.Image = CType(resources.GetObject("AniPump.Image"), System.Drawing.Image)
        Me.AniPump.Location = New System.Drawing.Point(412, 145)
        Me.AniPump.Margin = New System.Windows.Forms.Padding(4)
        Me.AniPump.Name = "AniPump"
        Me.AniPump.Size = New System.Drawing.Size(73, 59)
        Me.AniPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AniPump.TabIndex = 42
        Me.AniPump.TabStop = False
        '
        'UcProgress
        '
        Me.UcProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcProgress.BackColor = System.Drawing.Color.Transparent
        Me.UcProgress.Location = New System.Drawing.Point(2192, 66)
        Me.UcProgress.Margin = New System.Windows.Forms.Padding(5)
        Me.UcProgress.Name = "UcProgress"
        Me.UcProgress.Size = New System.Drawing.Size(85, 158)
        Me.UcProgress.TabIndex = 38
        '
        'AniGiflow
        '
        Me.AniGiflow.BackColor = System.Drawing.Color.Teal
        Me.AniGiflow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AniGiflow.Location = New System.Drawing.Point(37, 5)
        Me.AniGiflow.Margin = New System.Windows.Forms.Padding(4)
        Me.AniGiflow.Name = "AniGiflow"
        Me.AniGiflow.Size = New System.Drawing.Size(2243, 232)
        Me.AniGiflow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AniGiflow.TabIndex = 36
        Me.AniGiflow.TabStop = False
        '
        'UcProgressLevelTank
        '
        Me.UcProgressLevelTank.BackColor = System.Drawing.Color.Transparent
        Me.UcProgressLevelTank.Location = New System.Drawing.Point(89, 46)
        Me.UcProgressLevelTank.Margin = New System.Windows.Forms.Padding(5)
        Me.UcProgressLevelTank.Name = "UcProgressLevelTank"
        Me.UcProgressLevelTank.Size = New System.Drawing.Size(131, 135)
        Me.UcProgressLevelTank.TabIndex = 37
        '
        'AniGifFlowGreen
        '
        Me.AniGifFlowGreen.BackColor = System.Drawing.Color.Transparent
        Me.AniGifFlowGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AniGifFlowGreen.Image = CType(resources.GetObject("AniGifFlowGreen.Image"), System.Drawing.Image)
        Me.AniGifFlowGreen.Location = New System.Drawing.Point(37, 7)
        Me.AniGifFlowGreen.Margin = New System.Windows.Forms.Padding(4)
        Me.AniGifFlowGreen.Name = "AniGifFlowGreen"
        Me.AniGifFlowGreen.Size = New System.Drawing.Size(2243, 230)
        Me.AniGifFlowGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AniGifFlowGreen.TabIndex = 43
        Me.AniGifFlowGreen.TabStop = False
        '
        'UcFlowLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcFlowLoading"
        Me.Size = New System.Drawing.Size(2559, 241)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AniBllVale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AniPump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AniGiflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AniGifFlowGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tScan As System.Windows.Forms.Timer
    Friend WithEvents AniGiflow As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents cmdESD As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents cmdSetLevel As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents UcProgressLevelTank As GINNTAS.UcProgressOil
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents UcProgress As GINNTAS.UcProgressOil
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtMeter As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents AniBllVale As System.Windows.Forms.PictureBox
    Friend WithEvents AniPump As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AniGifFlowGreen As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents lblSideC As Label
End Class
