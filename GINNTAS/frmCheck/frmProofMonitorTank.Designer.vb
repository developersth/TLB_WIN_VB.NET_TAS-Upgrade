<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofMonitorTank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProofMonitorTank))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenutxtPrint = New GINNTAS.ucMenutxtSub()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_rec = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MSGridTank = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MSGridTank, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UcBack1.Location = New System.Drawing.Point(895, 1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMenutxtPrint)
        Me.Panel1.Controls.Add(Me.cbType)
        Me.Panel1.Controls.Add(Me.cbProduct)
        Me.Panel1.Controls.Add(Me.UcMenuRefresh)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 40)
        Me.Panel1.TabIndex = 212
        '
        'UcMenutxtPrint
        '
        Me.UcMenutxtPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtPrint.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtPrint.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtPrint.Location = New System.Drawing.Point(700, 3)
        Me.UcMenutxtPrint.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtPrint.MenuAuthorizeID = CType(0, Long)
        Me.UcMenutxtPrint.MenuCorners = 6
        Me.UcMenutxtPrint.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtPrint.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtPrint.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtPrint.MenuIcon = Nothing
        Me.UcMenutxtPrint.MenuIconSize = New System.Drawing.Size(12, 15)
        Me.UcMenutxtPrint.MenuScreenID = CType(0, Long)
        Me.UcMenutxtPrint.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtPrint.MenuText = "พิมพ์รายงาน"
        Me.UcMenutxtPrint.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtPrint.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenutxtPrint.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtPrint.MenuTextShadowShow = False
        Me.UcMenutxtPrint.Name = "UcMenutxtPrint"
        Me.UcMenutxtPrint.Size = New System.Drawing.Size(148, 30)
        Me.UcMenutxtPrint.TabIndex = 138
        '
        'cbType
        '
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(427, 5)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(132, 28)
        Me.cbType.TabIndex = 137
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(154, 6)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(130, 28)
        Me.cbProduct.TabIndex = 136
        '
        'UcMenuRefresh
        '
        Me.UcMenuRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuRefresh.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.ForeColor = System.Drawing.Color.Teal
        Me.UcMenuRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuRefresh.Location = New System.Drawing.Point(573, 4)
        Me.UcMenuRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuRefresh.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuRefresh.MenuCorners = 6
        Me.UcMenuRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.MenuIcon = Nothing
        Me.UcMenuRefresh.MenuIconSize = New System.Drawing.Size(12, 15)
        Me.UcMenuRefresh.MenuScreenID = CType(0, Long)
        Me.UcMenuRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuRefresh.MenuText = "Refresh"
        Me.UcMenuRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuRefresh.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuRefresh.MenuTextShadowShow = False
        Me.UcMenuRefresh.Name = "UcMenuRefresh"
        Me.UcMenuRefresh.Size = New System.Drawing.Size(111, 30)
        Me.UcMenuRefresh.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 134
        Me.Label4.Tag = ""
        Me.Label4.Text = "เลือกผลิตภัณฑ์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 133
        Me.Label3.Tag = ""
        Me.Label3.Text = "เลือกประเภทถัง"
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.Label6)
        Me.pnlFooter.Controls.Add(Me.lbl_rec)
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
        Me.Label6.Location = New System.Drawing.Point(980, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 20)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "ใบ"
        '
        'lbl_rec
        '
        Me.lbl_rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_rec.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_rec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_rec.Location = New System.Drawing.Point(908, 8)
        Me.lbl_rec.Name = "lbl_rec"
        Me.lbl_rec.Size = New System.Drawing.Size(67, 22)
        Me.lbl_rec.TabIndex = 140
        Me.lbl_rec.Text = "0"
        Me.lbl_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(813, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "จำนวนถัง :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MSGridTank)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 512)
        Me.Panel2.TabIndex = 215
        '
        'MSGridTank
        '
        Me.MSGridTank.AllowUserToAddRows = False
        Me.MSGridTank.AllowUserToDeleteRows = False
        Me.MSGridTank.AllowUserToResizeColumns = False
        Me.MSGridTank.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MSGridTank.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MSGridTank.ColumnHeadersHeight = 35
        Me.MSGridTank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MSGridTank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column110, Me.Column10, Me.Column11, Me.Column19, Me.Column12, Me.Column13, Me.Column20, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18})
        Me.MSGridTank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSGridTank.Location = New System.Drawing.Point(0, 0)
        Me.MSGridTank.Name = "MSGridTank"
        Me.MSGridTank.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MSGridTank.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MSGridTank.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSGridTank.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MSGridTank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MSGridTank.Size = New System.Drawing.Size(1022, 510)
        Me.MSGridTank.TabIndex = 68
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Tank  Name "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 134
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 96
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Color"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 76
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Tank Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 116
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Levels(mm.)"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Den15C(Kg/m3)"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 161
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Temp(°C) "
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 113
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "ค่า VCF30C "
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 129
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "COQ No. "
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 109
        '
        'Column110
        '
        Me.Column110.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column110.HeaderText = "HH Level"
        Me.Column110.Name = "Column110"
        Me.Column110.ReadOnly = True
        Me.Column110.Width = 107
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "L Level"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 91
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "H Level"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 94
        '
        'Column19
        '
        Me.Column19.HeaderText = "L LEVEL"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "Weight In Air(Kg)"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 171
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "ความจุของถัง"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 125
        '
        'Column20
        '
        Me.Column20.HeaderText = "FWL(mm) "
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "ปริมาณน้ำมันที่ OBS.(Litre)"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 231
        '
        'Column15
        '
        Me.Column15.HeaderText = "ปริมาณน้ำมันที่  30°C(Litre) "
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 231
        '
        'Column16
        '
        Me.Column16.HeaderText = "ปริมาณที่สามารถจ่ายได้(Litre) "
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 231
        '
        'Column17
        '
        Me.Column17.HeaderText = "ปริมาณที่สามารถรับได้(Litre)"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 231
        '
        'Column18
        '
        Me.Column18.HeaderText = "Status Alarm"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 140
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
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
        'frmProofMonitorTank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProofMonitorTank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProofLoadIncomplete"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MSGridTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents UcMenuRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_rec As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MSGridTank As System.Windows.Forms.DataGridView
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents UcMenutxtPrint As GINNTAS.ucMenutxtSub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column110 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
