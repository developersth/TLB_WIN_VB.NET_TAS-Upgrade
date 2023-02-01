<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofSAPTAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProofSAPTAS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotLine = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcbtRefresh = New GINNTAS.ucMenutxtSub()
        Me.btReupload = New GINNTAS.ucMenutxtSub()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblOilsys = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvSaptas = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chkAutoRefresh = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.b_Search = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTdate = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvSaptas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.Panel3.TabIndex = 209
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
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 40)
        Me.Panel4.TabIndex = 211
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(896, 1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 6
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.Label6)
        Me.pnlFooter.Controls.Add(Me.txtTotLine)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 698)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 35)
        Me.pnlFooter.TabIndex = 214
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(974, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "ข้อมูล"
        '
        'txtTotLine
        '
        Me.txtTotLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotLine.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotLine.Location = New System.Drawing.Point(902, 8)
        Me.txtTotLine.Name = "txtTotLine"
        Me.txtTotLine.Size = New System.Drawing.Size(67, 22)
        Me.txtTotLine.TabIndex = 140
        Me.txtTotLine.Text = "0"
        Me.txtTotLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(800, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(103, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "จำนวนข้อมูล :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32813!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67188!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1024, 552)
        Me.TableLayoutPanel1.TabIndex = 215
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcbtRefresh)
        Me.Panel1.Controls.Add(Me.btReupload)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 546)
        Me.Panel1.TabIndex = 0
        '
        'UcbtRefresh
        '
        Me.UcbtRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcbtRefresh.BackColor = System.Drawing.Color.Transparent
        Me.UcbtRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcbtRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcbtRefresh.ForeColor = System.Drawing.Color.Teal
        Me.UcbtRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcbtRefresh.Location = New System.Drawing.Point(12, 30)
        Me.UcbtRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcbtRefresh.MenuAuthorizeID = CType(0, Long)
        Me.UcbtRefresh.MenuCorners = 6
        Me.UcbtRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcbtRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcbtRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcbtRefresh.MenuIcon = Nothing
        Me.UcbtRefresh.MenuIconSize = New System.Drawing.Size(13, 26)
        Me.UcbtRefresh.MenuScreenID = CType(0, Long)
        Me.UcbtRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcbtRefresh.MenuText = "Refresh"
        Me.UcbtRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcbtRefresh.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcbtRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcbtRefresh.MenuTextShadowShow = False
        Me.UcbtRefresh.Name = "UcbtRefresh"
        Me.UcbtRefresh.Size = New System.Drawing.Size(107, 36)
        Me.UcbtRefresh.TabIndex = 142
        '
        'btReupload
        '
        Me.btReupload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btReupload.BackColor = System.Drawing.Color.Transparent
        Me.btReupload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btReupload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btReupload.ForeColor = System.Drawing.Color.Teal
        Me.btReupload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btReupload.Location = New System.Drawing.Point(11, 72)
        Me.btReupload.MaximumSize = New System.Drawing.Size(550, 91)
        Me.btReupload.MenuAuthorizeID = CType(0, Long)
        Me.btReupload.MenuCorners = 6
        Me.btReupload.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.btReupload.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReupload.MenuForeColor = System.Drawing.Color.Black
        Me.btReupload.MenuIcon = Nothing
        Me.btReupload.MenuIconSize = New System.Drawing.Size(13, 26)
        Me.btReupload.MenuScreenID = CType(0, Long)
        Me.btReupload.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.btReupload.MenuText = "Dowload"
        Me.btReupload.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReupload.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btReupload.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.btReupload.MenuTextShadowShow = False
        Me.btReupload.Name = "btReupload"
        Me.btReupload.Size = New System.Drawing.Size(108, 36)
        Me.btReupload.TabIndex = 141
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.lblDetail)
        Me.Panel7.Controls.Add(Me.lblHead)
        Me.Panel7.Location = New System.Drawing.Point(11, 164)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(94, 154)
        Me.Panel7.TabIndex = 140
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.BackColor = System.Drawing.Color.Transparent
        Me.lblDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(4, 130)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(152, 13)
        Me.lblDetail.TabIndex = 78
        Me.lblDetail.Tag = ""
        Me.lblDetail.Text = "DO_INTERFACE_DETAIL"
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.BackColor = System.Drawing.Color.Transparent
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHead.Location = New System.Drawing.Point(4, 60)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(142, 13)
        Me.lblHead.TabIndex = 77
        Me.lblHead.Tag = ""
        Me.lblHead.Text = "DO_INTERFACE_HEAD"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel8.Controls.Add(Me.PictureBox4)
        Me.Panel8.Controls.Add(Me.PictureBox3)
        Me.Panel8.Controls.Add(Me.lblOilsys)
        Me.Panel8.Controls.Add(Me.lblLoad)
        Me.Panel8.Location = New System.Drawing.Point(12, 360)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(93, 172)
        Me.Panel8.TabIndex = 139
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 82
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'lblOilsys
        '
        Me.lblOilsys.AutoSize = True
        Me.lblOilsys.BackColor = System.Drawing.Color.Transparent
        Me.lblOilsys.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOilsys.Location = New System.Drawing.Point(2, 148)
        Me.lblOilsys.Name = "lblOilsys"
        Me.lblOilsys.Size = New System.Drawing.Size(140, 13)
        Me.lblOilsys.TabIndex = 80
        Me.lblOilsys.Tag = ""
        Me.lblOilsys.Text = "OILSYS_LORRY_LOAD"
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.BackColor = System.Drawing.Color.Transparent
        Me.lblLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLoad.Location = New System.Drawing.Point(1, 69)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(120, 13)
        Me.lblLoad.TabIndex = 79
        Me.lblLoad.Tag = ""
        Me.lblLoad.Text = "TAS_LORRY_LOAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 24)
        Me.Label5.TabIndex = 138
        Me.Label5.Tag = ""
        Me.Label5.Text = "DotNet >> Oilsys"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 137
        Me.Label4.Tag = ""
        Me.Label4.Text = "DotNet >> TAS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(119, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 546)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvSaptas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(900, 504)
        Me.Panel6.TabIndex = 2
        '
        'dgvSaptas
        '
        Me.dgvSaptas.AllowUserToAddRows = False
        Me.dgvSaptas.AllowUserToDeleteRows = False
        Me.dgvSaptas.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSaptas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaptas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSaptas.ColumnHeadersHeight = 35
        Me.dgvSaptas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSaptas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSaptas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSaptas.Location = New System.Drawing.Point(0, 0)
        Me.dgvSaptas.Name = "dgvSaptas"
        Me.dgvSaptas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaptas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSaptas.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSaptas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSaptas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaptas.Size = New System.Drawing.Size(900, 504)
        Me.dgvSaptas.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.chkAutoRefresh)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.b_Search)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.DTdate)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(900, 40)
        Me.Panel5.TabIndex = 0
        '
        'chkAutoRefresh
        '
        Me.chkAutoRefresh.AutoSize = True
        Me.chkAutoRefresh.Checked = True
        Me.chkAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkAutoRefresh.Location = New System.Drawing.Point(493, 8)
        Me.chkAutoRefresh.Name = "chkAutoRefresh"
        Me.chkAutoRefresh.Size = New System.Drawing.Size(123, 24)
        Me.chkAutoRefresh.TabIndex = 86
        Me.chkAutoRefresh.Text = "Auto Refresh"
        Me.chkAutoRefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 85
        Me.Label3.Tag = ""
        Me.Label3.Text = "ประจำวันที่"
        '
        'b_Search
        '
        Me.b_Search.BackColor = System.Drawing.Color.White
        Me.b_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Search.Location = New System.Drawing.Point(361, 1)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(114, 35)
        Me.b_Search.TabIndex = 83
        Me.b_Search.Text = "ค้นหา"
        Me.b_Search.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(10, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 25)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Header"
        '
        'DTdate
        '
        Me.DTdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTdate.Location = New System.Drawing.Point(216, 3)
        Me.DTdate.Name = "DTdate"
        Me.DTdate.Size = New System.Drawing.Size(138, 31)
        Me.DTdate.TabIndex = 81
        Me.DTdate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1024, 106)
        Me.UcHeader1.TabIndex = 210
        '
        'frmProofSAPTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProofSAPTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProofLoadIncomplete"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvSaptas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotLine As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcbtRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents btReupload As GINNTAS.ucMenutxtSub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblOilsys As System.Windows.Forms.Label
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dgvSaptas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents b_Search As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkAutoRefresh As System.Windows.Forms.CheckBox
End Class
