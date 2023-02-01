<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlOverrideCR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtlOverrideCR))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UcMenub_Gate_OUT = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_Save = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_Cancel = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_BAY = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_Billing = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_Gate_IN = New GINNTAS.ucMenutxtSub()
        Me.UcMenub_BAY_Cancel = New GINNTAS.ucMenutxtSub()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Group_Billing = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TxtDriverSurname = New System.Windows.Forms.TextBox()
        Me.TxtDriverName = New System.Windows.Forms.TextBox()
        Me.b_OldDetailVechicle = New System.Windows.Forms.Button()
        Me.b_refresh = New System.Windows.Forms.Button()
        Me.b_FindDriver = New System.Windows.Forms.Button()
        Me.b_FindVechcle2 = New System.Windows.Forms.Button()
        Me.b_FindVechicle = New System.Windows.Forms.Button()
        Me.b_FindVehicle = New System.Windows.Forms.Button()
        Me.b_cmdCalSeal = New System.Windows.Forms.Button()
        Me.b_AddDo = New System.Windows.Forms.Button()
        Me.cbDriverBil = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbTail = New System.Windows.Forms.ComboBox()
        Me.cbTUHead = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.DTPTime = New System.Windows.Forms.DateTimePicker()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.txtSealNumber = New System.Windows.Forms.TextBox()
        Me.txtDo = New System.Windows.Forms.TextBox()
        Me.cbCardBil = New System.Windows.Forms.ComboBox()
        Me.CbCrId = New System.Windows.Forms.ComboBox()
        Me.Group_BayCancel = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DTPTimeCancel = New System.Windows.Forms.DateTimePicker()
        Me.DTPDateCancel = New System.Windows.Forms.DateTimePicker()
        Me.CmbBayCancel = New System.Windows.Forms.ComboBox()
        Me.txtBayCancelName = New System.Windows.Forms.TextBox()
        Me.txtBayCancelDriverCard = New System.Windows.Forms.TextBox()
        Me.txtBayCancelVehicle = New System.Windows.Forms.TextBox()
        Me.txtBayCancelTu = New System.Windows.Forms.TextBox()
        Me.txtBayCancelLoad = New System.Windows.Forms.TextBox()
        Me.txtBayCancelShipment = New System.Windows.Forms.TextBox()
        Me.CbBayCancelVehicleId = New System.Windows.Forms.ComboBox()
        Me.CbBayCancelCrId = New System.Windows.Forms.ComboBox()
        Me.Group_Bay = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkBypass = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTPBayTime = New System.Windows.Forms.DateTimePicker()
        Me.DTPBayDate = New System.Windows.Forms.DateTimePicker()
        Me.cbBay = New System.Windows.Forms.ComboBox()
        Me.txtBayDriverName = New System.Windows.Forms.TextBox()
        Me.txtBayDriverCard = New System.Windows.Forms.TextBox()
        Me.txtBayTu = New System.Windows.Forms.TextBox()
        Me.txtBayVehicle = New System.Windows.Forms.TextBox()
        Me.txtBayLoadNo = New System.Windows.Forms.TextBox()
        Me.txtBayShipment = New System.Windows.Forms.TextBox()
        Me.CbBayVehicleId = New System.Windows.Forms.ComboBox()
        Me.CbBayCrId = New System.Windows.Forms.ComboBox()
        Me.Group_Gate = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DTPGateTime = New System.Windows.Forms.DateTimePicker()
        Me.DTPGateDate = New System.Windows.Forms.DateTimePicker()
        Me.txtGateDriverName = New System.Windows.Forms.TextBox()
        Me.txtTuName = New System.Windows.Forms.TextBox()
        Me.txtVehicleName = New System.Windows.Forms.TextBox()
        Me.txtGateLoad = New System.Windows.Forms.TextBox()
        Me.txtGateShipment = New System.Windows.Forms.TextBox()
        Me.CbVehicleCard = New System.Windows.Forms.ComboBox()
        Me.CbGateCR = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Group_Billing.SuspendLayout()
        Me.Group_BayCancel.SuspendLayout()
        Me.Group_Bay.SuspendLayout()
        Me.Group_Gate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 733)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 35)
        Me.Panel3.TabIndex = 195
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
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1024, 106)
        Me.UcHeader1.TabIndex = 196
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.UcBack1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFooter.Location = New System.Drawing.Point(0, 106)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 35)
        Me.pnlFooter.TabIndex = 199
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(894, -1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.82422!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17578!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1024, 592)
        Me.TableLayoutPanel1.TabIndex = 200
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.UcMenub_Gate_OUT)
        Me.Panel1.Controls.Add(Me.UcMenub_Save)
        Me.Panel1.Controls.Add(Me.UcMenub_Cancel)
        Me.Panel1.Controls.Add(Me.UcMenub_BAY)
        Me.Panel1.Controls.Add(Me.UcMenub_Billing)
        Me.Panel1.Controls.Add(Me.UcMenub_Gate_IN)
        Me.Panel1.Controls.Add(Me.UcMenub_BAY_Cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 586)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 34)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'UcMenub_Gate_OUT
        '
        Me.UcMenub_Gate_OUT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_Gate_OUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_Gate_OUT.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_Gate_OUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_Gate_OUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Gate_OUT.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_Gate_OUT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_Gate_OUT.Location = New System.Drawing.Point(19, 291)
        Me.UcMenub_Gate_OUT.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_Gate_OUT.MenuAuthorizeID = CType(5, Long)
        Me.UcMenub_Gate_OUT.MenuCorners = 6
        Me.UcMenub_Gate_OUT.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Gate_OUT.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_Gate_OUT.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_Gate_OUT.MenuIcon = Nothing
        Me.UcMenub_Gate_OUT.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_Gate_OUT.MenuScreenID = CType(803, Long)
        Me.UcMenub_Gate_OUT.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_Gate_OUT.MenuText = "แตะบัตรที่ทางออก"
        Me.UcMenub_Gate_OUT.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_Gate_OUT.MenuTextMargin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.UcMenub_Gate_OUT.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_Gate_OUT.MenuTextShadowShow = False
        Me.UcMenub_Gate_OUT.Name = "UcMenub_Gate_OUT"
        Me.UcMenub_Gate_OUT.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_Gate_OUT.TabIndex = 141
        '
        'UcMenub_Save
        '
        Me.UcMenub_Save.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_Save.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Save.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_Save.Location = New System.Drawing.Point(19, 470)
        Me.UcMenub_Save.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_Save.MenuAuthorizeID = CType(0, Long)
        Me.UcMenub_Save.MenuCorners = 6
        Me.UcMenub_Save.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Save.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_Save.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_Save.MenuIcon = Nothing
        Me.UcMenub_Save.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_Save.MenuScreenID = CType(0, Long)
        Me.UcMenub_Save.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_Save.MenuText = "SAVE"
        Me.UcMenub_Save.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_Save.MenuTextMargin = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.UcMenub_Save.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_Save.MenuTextShadowShow = False
        Me.UcMenub_Save.Name = "UcMenub_Save"
        Me.UcMenub_Save.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_Save.TabIndex = 139
        '
        'UcMenub_Cancel
        '
        Me.UcMenub_Cancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Cancel.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_Cancel.Location = New System.Drawing.Point(19, 522)
        Me.UcMenub_Cancel.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_Cancel.MenuAuthorizeID = CType(0, Long)
        Me.UcMenub_Cancel.MenuCorners = 6
        Me.UcMenub_Cancel.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Cancel.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_Cancel.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_Cancel.MenuIcon = Nothing
        Me.UcMenub_Cancel.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_Cancel.MenuScreenID = CType(0, Long)
        Me.UcMenub_Cancel.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_Cancel.MenuText = "CANCLE"
        Me.UcMenub_Cancel.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_Cancel.MenuTextMargin = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.UcMenub_Cancel.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_Cancel.MenuTextShadowShow = False
        Me.UcMenub_Cancel.Name = "UcMenub_Cancel"
        Me.UcMenub_Cancel.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_Cancel.TabIndex = 140
        '
        'UcMenub_BAY
        '
        Me.UcMenub_BAY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_BAY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_BAY.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_BAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_BAY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_BAY.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_BAY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_BAY.Location = New System.Drawing.Point(19, 165)
        Me.UcMenub_BAY.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_BAY.MenuAuthorizeID = CType(3, Long)
        Me.UcMenub_BAY.MenuCorners = 6
        Me.UcMenub_BAY.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_BAY.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_BAY.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_BAY.MenuIcon = Nothing
        Me.UcMenub_BAY.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_BAY.MenuScreenID = CType(803, Long)
        Me.UcMenub_BAY.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_BAY.MenuText = "แตะบัตรที่ Bay"
        Me.UcMenub_BAY.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_BAY.MenuTextMargin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.UcMenub_BAY.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_BAY.MenuTextShadowShow = False
        Me.UcMenub_BAY.Name = "UcMenub_BAY"
        Me.UcMenub_BAY.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_BAY.TabIndex = 138
        '
        'UcMenub_Billing
        '
        Me.UcMenub_Billing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_Billing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_Billing.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_Billing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_Billing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Billing.ForeColor = System.Drawing.Color.Teal
        Me.UcMenub_Billing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_Billing.Location = New System.Drawing.Point(19, 40)
        Me.UcMenub_Billing.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_Billing.MenuAuthorizeID = CType(1, Long)
        Me.UcMenub_Billing.MenuCorners = 6
        Me.UcMenub_Billing.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Billing.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_Billing.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_Billing.MenuIcon = Nothing
        Me.UcMenub_Billing.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_Billing.MenuScreenID = CType(803, Long)
        Me.UcMenub_Billing.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_Billing.MenuText = "แตะบัตรที่ห้องขาย"
        Me.UcMenub_Billing.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_Billing.MenuTextMargin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.UcMenub_Billing.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_Billing.MenuTextShadowShow = False
        Me.UcMenub_Billing.Name = "UcMenub_Billing"
        Me.UcMenub_Billing.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_Billing.TabIndex = 135
        '
        'UcMenub_Gate_IN
        '
        Me.UcMenub_Gate_IN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_Gate_IN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_Gate_IN.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_Gate_IN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_Gate_IN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Gate_IN.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_Gate_IN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_Gate_IN.Location = New System.Drawing.Point(19, 100)
        Me.UcMenub_Gate_IN.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_Gate_IN.MenuAuthorizeID = CType(2, Long)
        Me.UcMenub_Gate_IN.MenuCorners = 6
        Me.UcMenub_Gate_IN.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_Gate_IN.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_Gate_IN.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_Gate_IN.MenuIcon = Nothing
        Me.UcMenub_Gate_IN.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_Gate_IN.MenuScreenID = CType(803, Long)
        Me.UcMenub_Gate_IN.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_Gate_IN.MenuText = "แตะบัตรที่ทางเข้า"
        Me.UcMenub_Gate_IN.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_Gate_IN.MenuTextMargin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.UcMenub_Gate_IN.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_Gate_IN.MenuTextShadowShow = False
        Me.UcMenub_Gate_IN.Name = "UcMenub_Gate_IN"
        Me.UcMenub_Gate_IN.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_Gate_IN.TabIndex = 136
        '
        'UcMenub_BAY_Cancel
        '
        Me.UcMenub_BAY_Cancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenub_BAY_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenub_BAY_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.UcMenub_BAY_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenub_BAY_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_BAY_Cancel.ForeColor = System.Drawing.Color.Gray
        Me.UcMenub_BAY_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenub_BAY_Cancel.Location = New System.Drawing.Point(19, 224)
        Me.UcMenub_BAY_Cancel.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenub_BAY_Cancel.MenuAuthorizeID = CType(4, Long)
        Me.UcMenub_BAY_Cancel.MenuCorners = 6
        Me.UcMenub_BAY_Cancel.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenub_BAY_Cancel.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenub_BAY_Cancel.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenub_BAY_Cancel.MenuIcon = Nothing
        Me.UcMenub_BAY_Cancel.MenuIconSize = New System.Drawing.Size(16, 19)
        Me.UcMenub_BAY_Cancel.MenuScreenID = CType(803, Long)
        Me.UcMenub_BAY_Cancel.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenub_BAY_Cancel.MenuText = "แตะบัตรออกที่ Bay"
        Me.UcMenub_BAY_Cancel.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenub_BAY_Cancel.MenuTextMargin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.UcMenub_BAY_Cancel.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenub_BAY_Cancel.MenuTextShadowShow = False
        Me.UcMenub_BAY_Cancel.Name = "UcMenub_BAY_Cancel"
        Me.UcMenub_BAY_Cancel.Size = New System.Drawing.Size(157, 38)
        Me.UcMenub_BAY_Cancel.TabIndex = 137
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Group_Billing)
        Me.Panel2.Controls.Add(Me.Group_BayCancel)
        Me.Panel2.Controls.Add(Me.Group_Bay)
        Me.Panel2.Controls.Add(Me.Group_Gate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(206, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 586)
        Me.Panel2.TabIndex = 1
        '
        'Group_Billing
        '
        Me.Group_Billing.BackColor = System.Drawing.SystemColors.Control
        Me.Group_Billing.Controls.Add(Me.Label39)
        Me.Group_Billing.Controls.Add(Me.TxtDriverSurname)
        Me.Group_Billing.Controls.Add(Me.TxtDriverName)
        Me.Group_Billing.Controls.Add(Me.b_OldDetailVechicle)
        Me.Group_Billing.Controls.Add(Me.b_refresh)
        Me.Group_Billing.Controls.Add(Me.b_FindDriver)
        Me.Group_Billing.Controls.Add(Me.b_FindVechcle2)
        Me.Group_Billing.Controls.Add(Me.b_FindVechicle)
        Me.Group_Billing.Controls.Add(Me.b_FindVehicle)
        Me.Group_Billing.Controls.Add(Me.b_cmdCalSeal)
        Me.Group_Billing.Controls.Add(Me.b_AddDo)
        Me.Group_Billing.Controls.Add(Me.cbDriverBil)
        Me.Group_Billing.Controls.Add(Me.Label36)
        Me.Group_Billing.Controls.Add(Me.Label35)
        Me.Group_Billing.Controls.Add(Me.cbTail)
        Me.Group_Billing.Controls.Add(Me.cbTUHead)
        Me.Group_Billing.Controls.Add(Me.Label23)
        Me.Group_Billing.Controls.Add(Me.Label25)
        Me.Group_Billing.Controls.Add(Me.Label26)
        Me.Group_Billing.Controls.Add(Me.Label34)
        Me.Group_Billing.Controls.Add(Me.Label37)
        Me.Group_Billing.Controls.Add(Me.Label38)
        Me.Group_Billing.Controls.Add(Me.DTPTime)
        Me.Group_Billing.Controls.Add(Me.DTPdate)
        Me.Group_Billing.Controls.Add(Me.txtSealNumber)
        Me.Group_Billing.Controls.Add(Me.txtDo)
        Me.Group_Billing.Controls.Add(Me.cbCardBil)
        Me.Group_Billing.Controls.Add(Me.CbCrId)
        Me.Group_Billing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Group_Billing.ForeColor = System.Drawing.Color.Black
        Me.Group_Billing.Location = New System.Drawing.Point(644, 517)
        Me.Group_Billing.Name = "Group_Billing"
        Me.Group_Billing.Size = New System.Drawing.Size(657, 445)
        Me.Group_Billing.TabIndex = 40
        Me.Group_Billing.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(187, 341)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 20)
        Me.Label39.TabIndex = 78
        Me.Label39.Text = "ชื่อ - สกุล"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Visible = False
        '
        'TxtDriverSurname
        '
        Me.TxtDriverSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtDriverSurname.Location = New System.Drawing.Point(416, 341)
        Me.TxtDriverSurname.Name = "TxtDriverSurname"
        Me.TxtDriverSurname.Size = New System.Drawing.Size(126, 23)
        Me.TxtDriverSurname.TabIndex = 77
        Me.TxtDriverSurname.Visible = False
        '
        'TxtDriverName
        '
        Me.TxtDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtDriverName.Location = New System.Drawing.Point(263, 341)
        Me.TxtDriverName.Name = "TxtDriverName"
        Me.TxtDriverName.Size = New System.Drawing.Size(126, 23)
        Me.TxtDriverName.TabIndex = 76
        Me.TxtDriverName.Visible = False
        '
        'b_OldDetailVechicle
        '
        Me.b_OldDetailVechicle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_OldDetailVechicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_OldDetailVechicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_OldDetailVechicle.Location = New System.Drawing.Point(520, 68)
        Me.b_OldDetailVechicle.Name = "b_OldDetailVechicle"
        Me.b_OldDetailVechicle.Size = New System.Drawing.Size(113, 22)
        Me.b_OldDetailVechicle.TabIndex = 75
        Me.b_OldDetailVechicle.Text = "Old Detail Vechicle"
        Me.b_OldDetailVechicle.UseVisualStyleBackColor = True
        '
        'b_refresh
        '
        Me.b_refresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_refresh.Location = New System.Drawing.Point(520, 28)
        Me.b_refresh.Name = "b_refresh"
        Me.b_refresh.Size = New System.Drawing.Size(81, 22)
        Me.b_refresh.TabIndex = 74
        Me.b_refresh.Text = "Refresh"
        Me.b_refresh.UseVisualStyleBackColor = True
        '
        'b_FindDriver
        '
        Me.b_FindDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_FindDriver.Location = New System.Drawing.Point(563, 187)
        Me.b_FindDriver.Name = "b_FindDriver"
        Me.b_FindDriver.Size = New System.Drawing.Size(24, 22)
        Me.b_FindDriver.TabIndex = 73
        Me.b_FindDriver.Text = ".."
        Me.b_FindDriver.UseVisualStyleBackColor = True
        '
        'b_FindVechcle2
        '
        Me.b_FindVechcle2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_FindVechcle2.Location = New System.Drawing.Point(490, 147)
        Me.b_FindVechcle2.Name = "b_FindVechcle2"
        Me.b_FindVechcle2.Size = New System.Drawing.Size(24, 22)
        Me.b_FindVechcle2.TabIndex = 72
        Me.b_FindVechcle2.Text = ".."
        Me.b_FindVechcle2.UseVisualStyleBackColor = True
        '
        'b_FindVechicle
        '
        Me.b_FindVechicle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_FindVechicle.Location = New System.Drawing.Point(490, 107)
        Me.b_FindVechicle.Name = "b_FindVechicle"
        Me.b_FindVechicle.Size = New System.Drawing.Size(24, 22)
        Me.b_FindVechicle.TabIndex = 71
        Me.b_FindVechicle.Text = ".."
        Me.b_FindVechicle.UseVisualStyleBackColor = True
        '
        'b_FindVehicle
        '
        Me.b_FindVehicle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_FindVehicle.Location = New System.Drawing.Point(490, 67)
        Me.b_FindVehicle.Name = "b_FindVehicle"
        Me.b_FindVehicle.Size = New System.Drawing.Size(24, 22)
        Me.b_FindVehicle.TabIndex = 70
        Me.b_FindVehicle.Text = ".."
        Me.b_FindVehicle.UseVisualStyleBackColor = True
        '
        'b_cmdCalSeal
        '
        Me.b_cmdCalSeal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_cmdCalSeal.Location = New System.Drawing.Point(490, 302)
        Me.b_cmdCalSeal.Name = "b_cmdCalSeal"
        Me.b_cmdCalSeal.Size = New System.Drawing.Size(81, 22)
        Me.b_cmdCalSeal.TabIndex = 68
        Me.b_cmdCalSeal.Text = "คำนวน Seal"
        Me.b_cmdCalSeal.UseVisualStyleBackColor = True
        '
        'b_AddDo
        '
        Me.b_AddDo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.b_AddDo.Location = New System.Drawing.Point(490, 267)
        Me.b_AddDo.Name = "b_AddDo"
        Me.b_AddDo.Size = New System.Drawing.Size(81, 22)
        Me.b_AddDo.TabIndex = 67
        Me.b_AddDo.Text = "เลือก DO"
        Me.b_AddDo.UseVisualStyleBackColor = True
        '
        'cbDriverBil
        '
        Me.cbDriverBil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbDriverBil.FormattingEnabled = True
        Me.cbDriverBil.Location = New System.Drawing.Point(263, 187)
        Me.cbDriverBil.Name = "cbDriverBil"
        Me.cbDriverBil.Size = New System.Drawing.Size(294, 24)
        Me.cbDriverBil.TabIndex = 66
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(177, 305)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 20)
        Me.Label36.TabIndex = 65
        Me.Label36.Text = "ป้อน Seal"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(183, 270)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 20)
        Me.Label35.TabIndex = 64
        Me.Label35.Text = "เลือก DO"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTail
        '
        Me.cbTail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbTail.FormattingEnabled = True
        Me.cbTail.Location = New System.Drawing.Point(263, 147)
        Me.cbTail.Name = "cbTail"
        Me.cbTail.Size = New System.Drawing.Size(221, 24)
        Me.cbTail.TabIndex = 63
        '
        'cbTUHead
        '
        Me.cbTUHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbTUHead.FormattingEnabled = True
        Me.cbTUHead.Location = New System.Drawing.Point(263, 107)
        Me.cbTUHead.Name = "cbTUHead"
        Me.cbTUHead.Size = New System.Drawing.Size(221, 24)
        Me.cbTUHead.TabIndex = 62
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(185, 227)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 20)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "วัน - เวลา"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(139, 187)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(118, 20)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "รหัสพนักงานขับรถ"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(156, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 20)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "ทะเบียนตัวพ่วง"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(177, 110)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 20)
        Me.Label34.TabIndex = 56
        Me.Label34.Text = "ทะเบียนรถ"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(117, 69)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(131, 20)
        Me.Label37.TabIndex = 53
        Me.Label37.Text = "หมายเลขบัตรของรถ"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(96, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(152, 20)
        Me.Label38.TabIndex = 52
        Me.Label38.Text = "หมายเลขเครื่องอ่านบัตร"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPTime
        '
        Me.DTPTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTime.Location = New System.Drawing.Point(395, 225)
        Me.DTPTime.Name = "DTPTime"
        Me.DTPTime.Size = New System.Drawing.Size(98, 22)
        Me.DTPTime.TabIndex = 44
        Me.DTPTime.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'DTPdate
        '
        Me.DTPdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(263, 225)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(126, 22)
        Me.DTPdate.TabIndex = 43
        Me.DTPdate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'txtSealNumber
        '
        Me.txtSealNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSealNumber.Location = New System.Drawing.Point(263, 302)
        Me.txtSealNumber.Name = "txtSealNumber"
        Me.txtSealNumber.Size = New System.Drawing.Size(221, 23)
        Me.txtSealNumber.TabIndex = 6
        '
        'txtDo
        '
        Me.txtDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDo.Location = New System.Drawing.Point(263, 267)
        Me.txtDo.Name = "txtDo"
        Me.txtDo.Size = New System.Drawing.Size(221, 23)
        Me.txtDo.TabIndex = 5
        '
        'cbCardBil
        '
        Me.cbCardBil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbCardBil.FormattingEnabled = True
        Me.cbCardBil.Location = New System.Drawing.Point(263, 66)
        Me.cbCardBil.Name = "cbCardBil"
        Me.cbCardBil.Size = New System.Drawing.Size(221, 24)
        Me.cbCardBil.TabIndex = 1
        '
        'CbCrId
        '
        Me.CbCrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbCrId.FormattingEnabled = True
        Me.CbCrId.Location = New System.Drawing.Point(263, 26)
        Me.CbCrId.Name = "CbCrId"
        Me.CbCrId.Size = New System.Drawing.Size(221, 24)
        Me.CbCrId.TabIndex = 0
        '
        'Group_BayCancel
        '
        Me.Group_BayCancel.BackColor = System.Drawing.SystemColors.Control
        Me.Group_BayCancel.Controls.Add(Me.Label11)
        Me.Group_BayCancel.Controls.Add(Me.Label12)
        Me.Group_BayCancel.Controls.Add(Me.Label13)
        Me.Group_BayCancel.Controls.Add(Me.Label14)
        Me.Group_BayCancel.Controls.Add(Me.Label15)
        Me.Group_BayCancel.Controls.Add(Me.Label16)
        Me.Group_BayCancel.Controls.Add(Me.Label17)
        Me.Group_BayCancel.Controls.Add(Me.Label19)
        Me.Group_BayCancel.Controls.Add(Me.Label20)
        Me.Group_BayCancel.Controls.Add(Me.Label21)
        Me.Group_BayCancel.Controls.Add(Me.Label22)
        Me.Group_BayCancel.Controls.Add(Me.DTPTimeCancel)
        Me.Group_BayCancel.Controls.Add(Me.DTPDateCancel)
        Me.Group_BayCancel.Controls.Add(Me.CmbBayCancel)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelName)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelDriverCard)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelVehicle)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelTu)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelLoad)
        Me.Group_BayCancel.Controls.Add(Me.txtBayCancelShipment)
        Me.Group_BayCancel.Controls.Add(Me.CbBayCancelVehicleId)
        Me.Group_BayCancel.Controls.Add(Me.CbBayCancelCrId)
        Me.Group_BayCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Group_BayCancel.ForeColor = System.Drawing.Color.Black
        Me.Group_BayCancel.Location = New System.Drawing.Point(641, 40)
        Me.Group_BayCancel.Name = "Group_BayCancel"
        Me.Group_BayCancel.Size = New System.Drawing.Size(590, 463)
        Me.Group_BayCancel.TabIndex = 38
        Me.Group_BayCancel.TabStop = False
        Me.Group_BayCancel.Text = "รูดบัตรออกที่ Bay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(260, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "BayNo-IslandNo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(188, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "วัน - เวลา"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(167, 353)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "เลือกช่องจ่าย"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(190, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 20)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "ชื่อ - สกุล"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(136, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 20)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "รหัสพนักงานขับรถ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(153, 230)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 20)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "ทะเบียนตัวพ่วง"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(180, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 20)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "ทะเบียนรถ"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(185, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 20)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Load No"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(153, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 20)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Shipment No"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(123, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 20)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "หมายเลขบัตรของรถ"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(102, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(152, 20)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "หมายเลขเครื่องอ่านบัตร"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPTimeCancel
        '
        Me.DTPTimeCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeCancel.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeCancel.Location = New System.Drawing.Point(395, 386)
        Me.DTPTimeCancel.Name = "DTPTimeCancel"
        Me.DTPTimeCancel.Size = New System.Drawing.Size(98, 22)
        Me.DTPTimeCancel.TabIndex = 44
        Me.DTPTimeCancel.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'DTPDateCancel
        '
        Me.DTPDateCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPDateCancel.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDateCancel.Location = New System.Drawing.Point(263, 386)
        Me.DTPDateCancel.Name = "DTPDateCancel"
        Me.DTPDateCancel.Size = New System.Drawing.Size(126, 22)
        Me.DTPDateCancel.TabIndex = 43
        Me.DTPDateCancel.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'CmbBayCancel
        '
        Me.CmbBayCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbBayCancel.FormattingEnabled = True
        Me.CmbBayCancel.Location = New System.Drawing.Point(263, 350)
        Me.CmbBayCancel.Name = "CmbBayCancel"
        Me.CmbBayCancel.Size = New System.Drawing.Size(116, 24)
        Me.CmbBayCancel.TabIndex = 8
        '
        'txtBayCancelName
        '
        Me.txtBayCancelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelName.Location = New System.Drawing.Point(263, 306)
        Me.txtBayCancelName.Name = "txtBayCancelName"
        Me.txtBayCancelName.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelName.TabIndex = 7
        '
        'txtBayCancelDriverCard
        '
        Me.txtBayCancelDriverCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelDriverCard.Location = New System.Drawing.Point(263, 266)
        Me.txtBayCancelDriverCard.Name = "txtBayCancelDriverCard"
        Me.txtBayCancelDriverCard.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelDriverCard.TabIndex = 6
        '
        'txtBayCancelVehicle
        '
        Me.txtBayCancelVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelVehicle.Location = New System.Drawing.Point(263, 226)
        Me.txtBayCancelVehicle.Name = "txtBayCancelVehicle"
        Me.txtBayCancelVehicle.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelVehicle.TabIndex = 5
        '
        'txtBayCancelTu
        '
        Me.txtBayCancelTu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelTu.Location = New System.Drawing.Point(263, 186)
        Me.txtBayCancelTu.Name = "txtBayCancelTu"
        Me.txtBayCancelTu.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelTu.TabIndex = 4
        '
        'txtBayCancelLoad
        '
        Me.txtBayCancelLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelLoad.Location = New System.Drawing.Point(263, 146)
        Me.txtBayCancelLoad.Name = "txtBayCancelLoad"
        Me.txtBayCancelLoad.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelLoad.TabIndex = 3
        '
        'txtBayCancelShipment
        '
        Me.txtBayCancelShipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayCancelShipment.Location = New System.Drawing.Point(263, 106)
        Me.txtBayCancelShipment.Name = "txtBayCancelShipment"
        Me.txtBayCancelShipment.Size = New System.Drawing.Size(221, 23)
        Me.txtBayCancelShipment.TabIndex = 2
        '
        'CbBayCancelVehicleId
        '
        Me.CbBayCancelVehicleId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbBayCancelVehicleId.FormattingEnabled = True
        Me.CbBayCancelVehicleId.Location = New System.Drawing.Point(263, 66)
        Me.CbBayCancelVehicleId.Name = "CbBayCancelVehicleId"
        Me.CbBayCancelVehicleId.Size = New System.Drawing.Size(221, 24)
        Me.CbBayCancelVehicleId.TabIndex = 1
        '
        'CbBayCancelCrId
        '
        Me.CbBayCancelCrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbBayCancelCrId.FormattingEnabled = True
        Me.CbBayCancelCrId.Location = New System.Drawing.Point(263, 26)
        Me.CbBayCancelCrId.Name = "CbBayCancelCrId"
        Me.CbBayCancelCrId.Size = New System.Drawing.Size(221, 24)
        Me.CbBayCancelCrId.TabIndex = 0
        '
        'Group_Bay
        '
        Me.Group_Bay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Group_Bay.Controls.Add(Me.Label10)
        Me.Group_Bay.Controls.Add(Me.ChkBypass)
        Me.Group_Bay.Controls.Add(Me.Label9)
        Me.Group_Bay.Controls.Add(Me.Label8)
        Me.Group_Bay.Controls.Add(Me.Label7)
        Me.Group_Bay.Controls.Add(Me.Label6)
        Me.Group_Bay.Controls.Add(Me.Label5)
        Me.Group_Bay.Controls.Add(Me.Label4)
        Me.Group_Bay.Controls.Add(Me.Label3)
        Me.Group_Bay.Controls.Add(Me.Label2)
        Me.Group_Bay.Controls.Add(Me.Label1)
        Me.Group_Bay.Controls.Add(Me.Label18)
        Me.Group_Bay.Controls.Add(Me.DTPBayTime)
        Me.Group_Bay.Controls.Add(Me.DTPBayDate)
        Me.Group_Bay.Controls.Add(Me.cbBay)
        Me.Group_Bay.Controls.Add(Me.txtBayDriverName)
        Me.Group_Bay.Controls.Add(Me.txtBayDriverCard)
        Me.Group_Bay.Controls.Add(Me.txtBayTu)
        Me.Group_Bay.Controls.Add(Me.txtBayVehicle)
        Me.Group_Bay.Controls.Add(Me.txtBayLoadNo)
        Me.Group_Bay.Controls.Add(Me.txtBayShipment)
        Me.Group_Bay.Controls.Add(Me.CbBayVehicleId)
        Me.Group_Bay.Controls.Add(Me.CbBayCrId)
        Me.Group_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Group_Bay.ForeColor = System.Drawing.Color.Black
        Me.Group_Bay.Location = New System.Drawing.Point(31, 491)
        Me.Group_Bay.Name = "Group_Bay"
        Me.Group_Bay.Size = New System.Drawing.Size(590, 445)
        Me.Group_Bay.TabIndex = 37
        Me.Group_Bay.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(260, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "BayNo-IslandNo"
        '
        'ChkBypass
        '
        Me.ChkBypass.AutoSize = True
        Me.ChkBypass.Location = New System.Drawing.Point(386, 354)
        Me.ChkBypass.Name = "ChkBypass"
        Me.ChkBypass.Size = New System.Drawing.Size(77, 20)
        Me.ChkBypass.TabIndex = 62
        Me.ChkBypass.Text = "By Pass"
        Me.ChkBypass.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(185, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "วัน - เวลา"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(167, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "เลือกช่องจ่าย"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(190, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "ชื่อ - สกุล"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(136, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "รหัสพนักงานขับรถ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(153, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "ทะเบียนตัวพ่วง"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(180, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "ทะเบียนรถ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(185, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Load No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(153, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Shipment No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(123, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "หมายเลขบัตรของรถ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(102, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 20)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "หมายเลขเครื่องอ่านบัตร"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPBayTime
        '
        Me.DTPBayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPBayTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPBayTime.Location = New System.Drawing.Point(395, 390)
        Me.DTPBayTime.Name = "DTPBayTime"
        Me.DTPBayTime.Size = New System.Drawing.Size(98, 22)
        Me.DTPBayTime.TabIndex = 44
        Me.DTPBayTime.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'DTPBayDate
        '
        Me.DTPBayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPBayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBayDate.Location = New System.Drawing.Point(263, 390)
        Me.DTPBayDate.Name = "DTPBayDate"
        Me.DTPBayDate.Size = New System.Drawing.Size(126, 22)
        Me.DTPBayDate.TabIndex = 43
        Me.DTPBayDate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'cbBay
        '
        Me.cbBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbBay.FormattingEnabled = True
        Me.cbBay.Location = New System.Drawing.Point(260, 350)
        Me.cbBay.Name = "cbBay"
        Me.cbBay.Size = New System.Drawing.Size(116, 24)
        Me.cbBay.TabIndex = 8
        '
        'txtBayDriverName
        '
        Me.txtBayDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayDriverName.Location = New System.Drawing.Point(263, 306)
        Me.txtBayDriverName.Name = "txtBayDriverName"
        Me.txtBayDriverName.Size = New System.Drawing.Size(221, 23)
        Me.txtBayDriverName.TabIndex = 7
        '
        'txtBayDriverCard
        '
        Me.txtBayDriverCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayDriverCard.Location = New System.Drawing.Point(263, 266)
        Me.txtBayDriverCard.Name = "txtBayDriverCard"
        Me.txtBayDriverCard.Size = New System.Drawing.Size(221, 23)
        Me.txtBayDriverCard.TabIndex = 6
        '
        'txtBayTu
        '
        Me.txtBayTu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayTu.Location = New System.Drawing.Point(263, 226)
        Me.txtBayTu.Name = "txtBayTu"
        Me.txtBayTu.Size = New System.Drawing.Size(221, 23)
        Me.txtBayTu.TabIndex = 5
        '
        'txtBayVehicle
        '
        Me.txtBayVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayVehicle.Location = New System.Drawing.Point(263, 186)
        Me.txtBayVehicle.Name = "txtBayVehicle"
        Me.txtBayVehicle.Size = New System.Drawing.Size(221, 23)
        Me.txtBayVehicle.TabIndex = 4
        '
        'txtBayLoadNo
        '
        Me.txtBayLoadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayLoadNo.Location = New System.Drawing.Point(263, 146)
        Me.txtBayLoadNo.Name = "txtBayLoadNo"
        Me.txtBayLoadNo.Size = New System.Drawing.Size(221, 23)
        Me.txtBayLoadNo.TabIndex = 3
        '
        'txtBayShipment
        '
        Me.txtBayShipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBayShipment.Location = New System.Drawing.Point(263, 106)
        Me.txtBayShipment.Name = "txtBayShipment"
        Me.txtBayShipment.Size = New System.Drawing.Size(221, 23)
        Me.txtBayShipment.TabIndex = 2
        '
        'CbBayVehicleId
        '
        Me.CbBayVehicleId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbBayVehicleId.FormattingEnabled = True
        Me.CbBayVehicleId.Location = New System.Drawing.Point(263, 66)
        Me.CbBayVehicleId.Name = "CbBayVehicleId"
        Me.CbBayVehicleId.Size = New System.Drawing.Size(221, 24)
        Me.CbBayVehicleId.TabIndex = 1
        '
        'CbBayCrId
        '
        Me.CbBayCrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbBayCrId.FormattingEnabled = True
        Me.CbBayCrId.Location = New System.Drawing.Point(263, 26)
        Me.CbBayCrId.Name = "CbBayCrId"
        Me.CbBayCrId.Size = New System.Drawing.Size(221, 24)
        Me.CbBayCrId.TabIndex = 0
        '
        'Group_Gate
        '
        Me.Group_Gate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Group_Gate.Controls.Add(Me.Label24)
        Me.Group_Gate.Controls.Add(Me.Label27)
        Me.Group_Gate.Controls.Add(Me.Label28)
        Me.Group_Gate.Controls.Add(Me.Label29)
        Me.Group_Gate.Controls.Add(Me.Label30)
        Me.Group_Gate.Controls.Add(Me.Label31)
        Me.Group_Gate.Controls.Add(Me.Label32)
        Me.Group_Gate.Controls.Add(Me.Label33)
        Me.Group_Gate.Controls.Add(Me.DTPGateTime)
        Me.Group_Gate.Controls.Add(Me.DTPGateDate)
        Me.Group_Gate.Controls.Add(Me.txtGateDriverName)
        Me.Group_Gate.Controls.Add(Me.txtTuName)
        Me.Group_Gate.Controls.Add(Me.txtVehicleName)
        Me.Group_Gate.Controls.Add(Me.txtGateLoad)
        Me.Group_Gate.Controls.Add(Me.txtGateShipment)
        Me.Group_Gate.Controls.Add(Me.CbVehicleCard)
        Me.Group_Gate.Controls.Add(Me.CbGateCR)
        Me.Group_Gate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Group_Gate.ForeColor = System.Drawing.Color.Black
        Me.Group_Gate.Location = New System.Drawing.Point(12, 40)
        Me.Group_Gate.Name = "Group_Gate"
        Me.Group_Gate.Size = New System.Drawing.Size(590, 445)
        Me.Group_Gate.TabIndex = 39
        Me.Group_Gate.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(185, 311)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 20)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "วัน - เวลา"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(136, 270)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 20)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "รหัสพนักงานขับรถ"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(153, 230)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(98, 20)
        Me.Label28.TabIndex = 57
        Me.Label28.Text = "ทะเบียนตัวพ่วง"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(180, 190)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 20)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "ทะเบียนรถ"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(185, 150)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 20)
        Me.Label30.TabIndex = 55
        Me.Label30.Text = "Load No"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(153, 110)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 20)
        Me.Label31.TabIndex = 54
        Me.Label31.Text = "Shipment No"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(123, 70)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(131, 20)
        Me.Label32.TabIndex = 53
        Me.Label32.Text = "หมายเลขบัตรของรถ"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(102, 30)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(152, 20)
        Me.Label33.TabIndex = 52
        Me.Label33.Text = "หมายเลขเครื่องอ่านบัตร"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPGateTime
        '
        Me.DTPGateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPGateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPGateTime.Location = New System.Drawing.Point(395, 309)
        Me.DTPGateTime.Name = "DTPGateTime"
        Me.DTPGateTime.Size = New System.Drawing.Size(98, 22)
        Me.DTPGateTime.TabIndex = 44
        Me.DTPGateTime.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'DTPGateDate
        '
        Me.DTPGateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPGateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPGateDate.Location = New System.Drawing.Point(263, 309)
        Me.DTPGateDate.Name = "DTPGateDate"
        Me.DTPGateDate.Size = New System.Drawing.Size(126, 22)
        Me.DTPGateDate.TabIndex = 43
        Me.DTPGateDate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'txtGateDriverName
        '
        Me.txtGateDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGateDriverName.Location = New System.Drawing.Point(263, 266)
        Me.txtGateDriverName.Name = "txtGateDriverName"
        Me.txtGateDriverName.Size = New System.Drawing.Size(221, 23)
        Me.txtGateDriverName.TabIndex = 6
        '
        'txtTuName
        '
        Me.txtTuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTuName.Location = New System.Drawing.Point(263, 226)
        Me.txtTuName.Name = "txtTuName"
        Me.txtTuName.Size = New System.Drawing.Size(221, 23)
        Me.txtTuName.TabIndex = 5
        '
        'txtVehicleName
        '
        Me.txtVehicleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtVehicleName.Location = New System.Drawing.Point(263, 186)
        Me.txtVehicleName.Name = "txtVehicleName"
        Me.txtVehicleName.Size = New System.Drawing.Size(221, 23)
        Me.txtVehicleName.TabIndex = 4
        '
        'txtGateLoad
        '
        Me.txtGateLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGateLoad.Location = New System.Drawing.Point(263, 146)
        Me.txtGateLoad.Name = "txtGateLoad"
        Me.txtGateLoad.Size = New System.Drawing.Size(221, 23)
        Me.txtGateLoad.TabIndex = 3
        '
        'txtGateShipment
        '
        Me.txtGateShipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGateShipment.Location = New System.Drawing.Point(263, 106)
        Me.txtGateShipment.Name = "txtGateShipment"
        Me.txtGateShipment.Size = New System.Drawing.Size(221, 23)
        Me.txtGateShipment.TabIndex = 2
        '
        'CbVehicleCard
        '
        Me.CbVehicleCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbVehicleCard.FormattingEnabled = True
        Me.CbVehicleCard.Location = New System.Drawing.Point(263, 66)
        Me.CbVehicleCard.Name = "CbVehicleCard"
        Me.CbVehicleCard.Size = New System.Drawing.Size(221, 24)
        Me.CbVehicleCard.TabIndex = 1
        '
        'CbGateCR
        '
        Me.CbGateCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CbGateCR.FormattingEnabled = True
        Me.CbGateCR.Location = New System.Drawing.Point(263, 26)
        Me.CbGateCR.Name = "CbGateCR"
        Me.CbGateCR.Size = New System.Drawing.Size(221, 24)
        Me.CbGateCR.TabIndex = 0
        '
        'frmUtlOverrideCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UcHeader1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmUtlOverrideCR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUtlOverrideCR"
        Me.Panel3.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Group_Billing.ResumeLayout(False)
        Me.Group_Billing.PerformLayout()
        Me.Group_BayCancel.ResumeLayout(False)
        Me.Group_BayCancel.PerformLayout()
        Me.Group_Bay.ResumeLayout(False)
        Me.Group_Bay.PerformLayout()
        Me.Group_Gate.ResumeLayout(False)
        Me.Group_Gate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UcMenub_Gate_OUT As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_Save As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_Cancel As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_BAY As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_Billing As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_Gate_IN As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenub_BAY_Cancel As GINNTAS.ucMenutxtSub
    Friend WithEvents Group_Billing As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TxtDriverSurname As System.Windows.Forms.TextBox
    Friend WithEvents TxtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents b_OldDetailVechicle As System.Windows.Forms.Button
    Friend WithEvents b_refresh As System.Windows.Forms.Button
    Friend WithEvents b_FindDriver As System.Windows.Forms.Button
    Friend WithEvents b_FindVechcle2 As System.Windows.Forms.Button
    Friend WithEvents b_FindVechicle As System.Windows.Forms.Button
    Friend WithEvents b_FindVehicle As System.Windows.Forms.Button
    Friend WithEvents b_cmdCalSeal As System.Windows.Forms.Button
    Friend WithEvents b_AddDo As System.Windows.Forms.Button
    Friend WithEvents cbDriverBil As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbTail As System.Windows.Forms.ComboBox
    Friend WithEvents cbTUHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents DTPTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSealNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDo As System.Windows.Forms.TextBox
    Friend WithEvents cbCardBil As System.Windows.Forms.ComboBox
    Friend WithEvents CbCrId As System.Windows.Forms.ComboBox
    Friend WithEvents Group_Gate As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents DTPGateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPGateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGateDriverName As System.Windows.Forms.TextBox
    Friend WithEvents txtTuName As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleName As System.Windows.Forms.TextBox
    Friend WithEvents txtGateLoad As System.Windows.Forms.TextBox
    Friend WithEvents txtGateShipment As System.Windows.Forms.TextBox
    Friend WithEvents CbVehicleCard As System.Windows.Forms.ComboBox
    Friend WithEvents CbGateCR As System.Windows.Forms.ComboBox
    Friend WithEvents Group_Bay As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkBypass As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DTPBayTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPBayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbBay As System.Windows.Forms.ComboBox
    Friend WithEvents txtBayDriverName As System.Windows.Forms.TextBox
    Friend WithEvents txtBayDriverCard As System.Windows.Forms.TextBox
    Friend WithEvents txtBayTu As System.Windows.Forms.TextBox
    Friend WithEvents txtBayVehicle As System.Windows.Forms.TextBox
    Friend WithEvents txtBayLoadNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBayShipment As System.Windows.Forms.TextBox
    Friend WithEvents CbBayVehicleId As System.Windows.Forms.ComboBox
    Friend WithEvents CbBayCrId As System.Windows.Forms.ComboBox
    Friend WithEvents Group_BayCancel As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DTPTimeCancel As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDateCancel As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbBayCancel As System.Windows.Forms.ComboBox
    Friend WithEvents txtBayCancelName As System.Windows.Forms.TextBox
    Friend WithEvents txtBayCancelDriverCard As System.Windows.Forms.TextBox
    Friend WithEvents txtBayCancelVehicle As System.Windows.Forms.TextBox
    Friend WithEvents txtBayCancelTu As System.Windows.Forms.TextBox
    Friend WithEvents txtBayCancelLoad As System.Windows.Forms.TextBox
    Friend WithEvents txtBayCancelShipment As System.Windows.Forms.TextBox
    Friend WithEvents CbBayCancelVehicleId As System.Windows.Forms.ComboBox
    Friend WithEvents CbBayCancelCrId As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UcBack1 As GINNTAS.ucBack
End Class
