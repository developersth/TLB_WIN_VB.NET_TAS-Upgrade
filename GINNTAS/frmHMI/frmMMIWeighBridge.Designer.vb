<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMIWeighBridge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMMIWeighBridge))
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTypeWeight = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeightOut = New System.Windows.Forms.TextBox()
        Me.txtWeightTuchCard = New System.Windows.Forms.TextBox()
        Me.txtTareWeight = New System.Windows.Forms.TextBox()
        Me.txtCarExp = New System.Windows.Forms.TextBox()
        Me.txtSeal = New System.Windows.Forms.TextBox()
        Me.txtCarrier = New System.Windows.Forms.TextBox()
        Me.txtTypeTruck = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.txtVechicle = New System.Windows.Forms.TextBox()
        Me.txtVechicleCardNo = New System.Windows.Forms.TextBox()
        Me.txtLoadNo = New System.Windows.Forms.TextBox()
        Me.lblWeightValue = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AniFire = New System.Windows.Forms.PictureBox()
        Me.aniWeightBridge = New System.Windows.Forms.PictureBox()
        Me.tTimeScan = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AniFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aniWeightBridge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1024, 106)
        Me.UcHeader1.TabIndex = 175
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(1022, 33)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 677)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 29)
        Me.pnlFooter.TabIndex = 173
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 706)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 35)
        Me.Panel3.TabIndex = 174
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcBack1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 35)
        Me.Panel1.TabIndex = 177
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(896, -1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.lblTypeWeight)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtWeightOut)
        Me.Panel5.Controls.Add(Me.txtWeightTuchCard)
        Me.Panel5.Controls.Add(Me.txtTareWeight)
        Me.Panel5.Controls.Add(Me.txtCarExp)
        Me.Panel5.Controls.Add(Me.txtSeal)
        Me.Panel5.Controls.Add(Me.txtCarrier)
        Me.Panel5.Controls.Add(Me.txtTypeTruck)
        Me.Panel5.Controls.Add(Me.txtDriver)
        Me.Panel5.Controls.Add(Me.txtVechicle)
        Me.Panel5.Controls.Add(Me.txtVechicleCardNo)
        Me.Panel5.Controls.Add(Me.txtLoadNo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 508)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1024, 169)
        Me.Panel5.TabIndex = 179
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(795, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 20)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "ชั่งเข้า / ชั่งออก"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(976, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Kg"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(955, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 20)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Kg"
        '
        'lblTypeWeight
        '
        Me.lblTypeWeight.AutoSize = True
        Me.lblTypeWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTypeWeight.ForeColor = System.Drawing.Color.Black
        Me.lblTypeWeight.Location = New System.Drawing.Point(824, 19)
        Me.lblTypeWeight.Name = "lblTypeWeight"
        Me.lblTypeWeight.Size = New System.Drawing.Size(81, 20)
        Me.lblTypeWeight.TabIndex = 46
        Me.lblTypeWeight.Text = "ลำดับการชั่ง"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(618, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "น้ำหนักแตะบัตร :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(677, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "น้ำหนักประวัติรถเปล่า :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(349, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "ปล 2 หมดอายุ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(341, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "จำนวนซีลที่ป้อน :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(392, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "ผู้ขนส่ง :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(370, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "ประเภทรถ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "พนักงานขับรถ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ทะเบียนรถ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "หมายเลขบัตรรถ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "LoadNo :"
        '
        'txtWeightOut
        '
        Me.txtWeightOut.Enabled = False
        Me.txtWeightOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWeightOut.ForeColor = System.Drawing.Color.Black
        Me.txtWeightOut.Location = New System.Drawing.Point(868, 124)
        Me.txtWeightOut.Name = "txtWeightOut"
        Me.txtWeightOut.Size = New System.Drawing.Size(100, 26)
        Me.txtWeightOut.TabIndex = 35
        '
        'txtWeightTuchCard
        '
        Me.txtWeightTuchCard.Enabled = False
        Me.txtWeightTuchCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWeightTuchCard.ForeColor = System.Drawing.Color.Black
        Me.txtWeightTuchCard.Location = New System.Drawing.Point(733, 124)
        Me.txtWeightTuchCard.Name = "txtWeightTuchCard"
        Me.txtWeightTuchCard.Size = New System.Drawing.Size(121, 26)
        Me.txtWeightTuchCard.TabIndex = 34
        '
        'txtTareWeight
        '
        Me.txtTareWeight.Enabled = False
        Me.txtTareWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTareWeight.ForeColor = System.Drawing.Color.Black
        Me.txtTareWeight.Location = New System.Drawing.Point(828, 42)
        Me.txtTareWeight.Name = "txtTareWeight"
        Me.txtTareWeight.Size = New System.Drawing.Size(121, 26)
        Me.txtTareWeight.TabIndex = 33
        '
        'txtCarExp
        '
        Me.txtCarExp.Enabled = False
        Me.txtCarExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCarExp.ForeColor = System.Drawing.Color.Black
        Me.txtCarExp.Location = New System.Drawing.Point(457, 127)
        Me.txtCarExp.Name = "txtCarExp"
        Me.txtCarExp.Size = New System.Drawing.Size(158, 26)
        Me.txtCarExp.TabIndex = 32
        '
        'txtSeal
        '
        Me.txtSeal.Enabled = False
        Me.txtSeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSeal.ForeColor = System.Drawing.Color.Black
        Me.txtSeal.Location = New System.Drawing.Point(457, 87)
        Me.txtSeal.Name = "txtSeal"
        Me.txtSeal.Size = New System.Drawing.Size(158, 26)
        Me.txtSeal.TabIndex = 31
        '
        'txtCarrier
        '
        Me.txtCarrier.Enabled = False
        Me.txtCarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCarrier.ForeColor = System.Drawing.Color.Black
        Me.txtCarrier.Location = New System.Drawing.Point(457, 52)
        Me.txtCarrier.Name = "txtCarrier"
        Me.txtCarrier.Size = New System.Drawing.Size(158, 26)
        Me.txtCarrier.TabIndex = 30
        '
        'txtTypeTruck
        '
        Me.txtTypeTruck.Enabled = False
        Me.txtTypeTruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTypeTruck.ForeColor = System.Drawing.Color.Black
        Me.txtTypeTruck.Location = New System.Drawing.Point(457, 21)
        Me.txtTypeTruck.Name = "txtTypeTruck"
        Me.txtTypeTruck.Size = New System.Drawing.Size(158, 26)
        Me.txtTypeTruck.TabIndex = 29
        '
        'txtDriver
        '
        Me.txtDriver.Enabled = False
        Me.txtDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriver.ForeColor = System.Drawing.Color.Black
        Me.txtDriver.Location = New System.Drawing.Point(140, 135)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(190, 26)
        Me.txtDriver.TabIndex = 28
        '
        'txtVechicle
        '
        Me.txtVechicle.Enabled = False
        Me.txtVechicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVechicle.ForeColor = System.Drawing.Color.Black
        Me.txtVechicle.Location = New System.Drawing.Point(140, 95)
        Me.txtVechicle.Name = "txtVechicle"
        Me.txtVechicle.Size = New System.Drawing.Size(190, 26)
        Me.txtVechicle.TabIndex = 27
        '
        'txtVechicleCardNo
        '
        Me.txtVechicleCardNo.Enabled = False
        Me.txtVechicleCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVechicleCardNo.ForeColor = System.Drawing.Color.Black
        Me.txtVechicleCardNo.Location = New System.Drawing.Point(140, 56)
        Me.txtVechicleCardNo.Name = "txtVechicleCardNo"
        Me.txtVechicleCardNo.Size = New System.Drawing.Size(190, 26)
        Me.txtVechicleCardNo.TabIndex = 26
        '
        'txtLoadNo
        '
        Me.txtLoadNo.Enabled = False
        Me.txtLoadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoadNo.ForeColor = System.Drawing.Color.Black
        Me.txtLoadNo.Location = New System.Drawing.Point(140, 19)
        Me.txtLoadNo.Name = "txtLoadNo"
        Me.txtLoadNo.Size = New System.Drawing.Size(190, 26)
        Me.txtLoadNo.TabIndex = 25
        '
        'lblWeightValue
        '
        Me.lblWeightValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblWeightValue.AutoSize = True
        Me.lblWeightValue.BackColor = System.Drawing.Color.Transparent
        Me.lblWeightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblWeightValue.ForeColor = System.Drawing.Color.Black
        Me.lblWeightValue.Location = New System.Drawing.Point(106, 292)
        Me.lblWeightValue.Name = "lblWeightValue"
        Me.lblWeightValue.Size = New System.Drawing.Size(840, 73)
        Me.lblWeightValue.TabIndex = 29
        Me.lblWeightValue.Text = "น้ำหนักเครื่องชั่ง :                Kg"
        Me.lblWeightValue.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblWeightValue)
        Me.Panel2.Controls.Add(Me.AniFire)
        Me.Panel2.Controls.Add(Me.aniWeightBridge)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 367)
        Me.Panel2.TabIndex = 180
        '
        'AniFire
        '
        Me.AniFire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AniFire.BackColor = System.Drawing.Color.Transparent
        Me.AniFire.Image = CType(resources.GetObject("AniFire.Image"), System.Drawing.Image)
        Me.AniFire.Location = New System.Drawing.Point(933, 5)
        Me.AniFire.Name = "AniFire"
        Me.AniFire.Size = New System.Drawing.Size(69, 122)
        Me.AniFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AniFire.TabIndex = 28
        Me.AniFire.TabStop = False
        '
        'aniWeightBridge
        '
        Me.aniWeightBridge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aniWeightBridge.BackColor = System.Drawing.Color.Transparent
        Me.aniWeightBridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aniWeightBridge.Image = Global.GINNTAS.My.Resources.Resources.WeightBridge_0
        Me.aniWeightBridge.Location = New System.Drawing.Point(56, -1)
        Me.aniWeightBridge.Name = "aniWeightBridge"
        Me.aniWeightBridge.Size = New System.Drawing.Size(871, 283)
        Me.aniWeightBridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.aniWeightBridge.TabIndex = 26
        Me.aniWeightBridge.TabStop = False
        '
        'tTimeScan
        '
        '
        'frmMMIWeighBridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 741)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UcHeader1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMMIWeighBridge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMMIWeighBridge"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AniFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aniWeightBridge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTypeWeight As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeightOut As System.Windows.Forms.TextBox
    Friend WithEvents txtWeightTuchCard As System.Windows.Forms.TextBox
    Friend WithEvents txtTareWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtCarExp As System.Windows.Forms.TextBox
    Friend WithEvents txtSeal As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrier As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeTruck As System.Windows.Forms.TextBox
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents txtVechicle As System.Windows.Forms.TextBox
    Friend WithEvents txtVechicleCardNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadNo As System.Windows.Forms.TextBox
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AniFire As System.Windows.Forms.PictureBox
    Friend WithEvents aniWeightBridge As System.Windows.Forms.PictureBox
    Friend WithEvents tTimeScan As System.Windows.Forms.Timer
    Friend WithEvents lblWeightValue As System.Windows.Forms.Label
    Friend WithEvents UcBack1 As GINNTAS.ucBack
End Class
