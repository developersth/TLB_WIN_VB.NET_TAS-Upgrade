<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnloading_main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnloading_main))
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.UcMenuEdit = New GINNTAS.ucMenutxtSub()
        Me.UcMenuDelete = New GINNTAS.ucMenutxtSub()
        Me.UcMenuSacrch = New GINNTAS.ucMenutxtSub()
        Me.UcMenuAdd = New GINNTAS.ucMenutxtSub()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateShow = New System.Windows.Forms.DateTimePicker()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.pnlFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.txtTotalRecord)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 698)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 35)
        Me.pnlFooter.TabIndex = 197
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.Location = New System.Drawing.Point(911, 3)
        Me.txtTotalRecord.Name = "txtTotalRecord"
        Me.txtTotalRecord.ReadOnly = True
        Me.txtTotalRecord.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalRecord.TabIndex = 5
        Me.txtTotalRecord.Text = "0"
        Me.txtTotalRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(783, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Total Record :"
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
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 40)
        Me.Panel4.TabIndex = 200
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.82422!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17578!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1024, 552)
        Me.TableLayoutPanel1.TabIndex = 201
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMenuRefresh)
        Me.Panel1.Controls.Add(Me.UcMenuEdit)
        Me.Panel1.Controls.Add(Me.UcMenuDelete)
        Me.Panel1.Controls.Add(Me.UcMenuSacrch)
        Me.Panel1.Controls.Add(Me.UcMenuAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 546)
        Me.Panel1.TabIndex = 0
        '
        'UcMenuRefresh
        '
        Me.UcMenuRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuRefresh.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.ForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuRefresh.Location = New System.Drawing.Point(42, 27)
        Me.UcMenuRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuRefresh.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuRefresh.MenuCorners = 6
        Me.UcMenuRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.MenuIcon = Nothing
        Me.UcMenuRefresh.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuRefresh.MenuScreenID = CType(0, Long)
        Me.UcMenuRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuRefresh.MenuText = "Refresh"
        Me.UcMenuRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuRefresh.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuRefresh.MenuTextShadowShow = False
        Me.UcMenuRefresh.Name = "UcMenuRefresh"
        Me.UcMenuRefresh.Size = New System.Drawing.Size(111, 38)
        Me.UcMenuRefresh.TabIndex = 141
        Me.UcMenuRefresh.Tag = "1"
        '
        'UcMenuEdit
        '
        Me.UcMenuEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuEdit.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEdit.ForeColor = System.Drawing.Color.Black
        Me.UcMenuEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuEdit.Location = New System.Drawing.Point(42, 147)
        Me.UcMenuEdit.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuEdit.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuEdit.MenuCorners = 6
        Me.UcMenuEdit.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEdit.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuEdit.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuEdit.MenuIcon = Nothing
        Me.UcMenuEdit.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuEdit.MenuScreenID = CType(0, Long)
        Me.UcMenuEdit.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuEdit.MenuText = "Edit"
        Me.UcMenuEdit.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuEdit.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuEdit.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuEdit.MenuTextShadowShow = False
        Me.UcMenuEdit.Name = "UcMenuEdit"
        Me.UcMenuEdit.Size = New System.Drawing.Size(111, 38)
        Me.UcMenuEdit.TabIndex = 145
        Me.UcMenuEdit.Tag = "3"
        '
        'UcMenuDelete
        '
        Me.UcMenuDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuDelete.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDelete.ForeColor = System.Drawing.Color.Black
        Me.UcMenuDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuDelete.Location = New System.Drawing.Point(42, 207)
        Me.UcMenuDelete.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuDelete.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuDelete.MenuCorners = 6
        Me.UcMenuDelete.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDelete.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuDelete.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuDelete.MenuIcon = Nothing
        Me.UcMenuDelete.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuDelete.MenuScreenID = CType(0, Long)
        Me.UcMenuDelete.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuDelete.MenuText = "Delete"
        Me.UcMenuDelete.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuDelete.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuDelete.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuDelete.MenuTextShadowShow = False
        Me.UcMenuDelete.Name = "UcMenuDelete"
        Me.UcMenuDelete.Size = New System.Drawing.Size(111, 38)
        Me.UcMenuDelete.TabIndex = 143
        Me.UcMenuDelete.Tag = "4"
        '
        'UcMenuSacrch
        '
        Me.UcMenuSacrch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuSacrch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuSacrch.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuSacrch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuSacrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSacrch.ForeColor = System.Drawing.Color.Black
        Me.UcMenuSacrch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuSacrch.Location = New System.Drawing.Point(42, 267)
        Me.UcMenuSacrch.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuSacrch.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuSacrch.MenuCorners = 6
        Me.UcMenuSacrch.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSacrch.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuSacrch.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuSacrch.MenuIcon = Nothing
        Me.UcMenuSacrch.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuSacrch.MenuScreenID = CType(0, Long)
        Me.UcMenuSacrch.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuSacrch.MenuText = "Search"
        Me.UcMenuSacrch.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuSacrch.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuSacrch.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuSacrch.MenuTextShadowShow = False
        Me.UcMenuSacrch.Name = "UcMenuSacrch"
        Me.UcMenuSacrch.Size = New System.Drawing.Size(111, 38)
        Me.UcMenuSacrch.TabIndex = 144
        Me.UcMenuSacrch.Tag = "5"
        '
        'UcMenuAdd
        '
        Me.UcMenuAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuAdd.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuAdd.ForeColor = System.Drawing.Color.Black
        Me.UcMenuAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuAdd.Location = New System.Drawing.Point(42, 87)
        Me.UcMenuAdd.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuAdd.MenuAuthorizeID = CType(6, Long)
        Me.UcMenuAdd.MenuCorners = 6
        Me.UcMenuAdd.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuAdd.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuAdd.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuAdd.MenuIcon = Nothing
        Me.UcMenuAdd.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuAdd.MenuScreenID = CType(406, Long)
        Me.UcMenuAdd.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuAdd.MenuText = "Add"
        Me.UcMenuAdd.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuAdd.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenuAdd.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuAdd.MenuTextShadowShow = False
        Me.UcMenuAdd.Name = "UcMenuAdd"
        Me.UcMenuAdd.Size = New System.Drawing.Size(111, 38)
        Me.UcMenuAdd.TabIndex = 142
        Me.UcMenuAdd.Tag = "2"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(206, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 546)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.DataGridView1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(813, 504)
        Me.Panel6.TabIndex = 200
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8, Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column23, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(811, 502)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "หมายเลขตั๋วรับ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 134
        '
        'Column2
        '
        Me.Column2.HeaderText = "ประเภทการรับ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 132
        '
        'Column3
        '
        Me.Column3.HeaderText = "หมายเลขรถ "
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 121
        '
        'Column4
        '
        Me.Column4.HeaderText = "ผลิตภัณฑ์"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 99
        '
        'Column5
        '
        Me.Column5.HeaderText = "รับจากคลัง"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 106
        '
        'Column8
        '
        Me.Column8.HeaderText = "อุณหภูมิต้นทาง"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.Width = 134
        '
        'Column6
        '
        Me.Column6.HeaderText = "ค่า API ต้นทาง"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 138
        '
        'Column7
        '
        Me.Column7.HeaderText = "ปริมาณ GRS ต้นทาง"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 180
        '
        'Column9
        '
        Me.Column9.HeaderText = "ปริมาณ NET ต้นทาง"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 175
        '
        'Column10
        '
        Me.Column10.HeaderText = "อุณหภูมิปลายทาง"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 150
        '
        'Column11
        '
        Me.Column11.HeaderText = "ค่า API ปลายทาง"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 154
        '
        'Column12
        '
        Me.Column12.HeaderText = "ปริมาณ GRS ที่มาถึงคลัง"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 208
        '
        'Column13
        '
        Me.Column13.HeaderText = "ริมาณ NET ที่มาถึงคลัง"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 193
        '
        'Column14
        '
        Me.Column14.HeaderText = "ปริมาณ GRS ที่รับได้จริง"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 205
        '
        'Column15
        '
        Me.Column15.HeaderText = "ปริมาณ NET ที่รับได้จริง"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 200
        '
        'Column23
        '
        Me.Column23.HeaderText = "ถังรับ"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 70
        '
        'Column16
        '
        Me.Column16.HeaderText = "เวลาที่เริ่มรับ"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 121
        '
        'Column17
        '
        Me.Column17.HeaderText = "เวลาที่รับเสร็จ "
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 133
        '
        'Column18
        '
        Me.Column18.HeaderText = "หมายเหตุ  "
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 109
        '
        'Column19
        '
        Me.Column19.HeaderText = "EOD   "
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 87
        '
        'Column20
        '
        Me.Column20.HeaderText = "วันที่ EOD  "
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 116
        '
        'Column21
        '
        Me.Column21.HeaderText = "วันที่แก้ไขล่าสุด  "
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 147
        '
        'Column22
        '
        Me.Column22.HeaderText = "แก้ไขโดย"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 99
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.dtpDateShow)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(813, 40)
        Me.Panel5.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "ประจำวันที่"
        '
        'dtpDateShow
        '
        Me.dtpDateShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateShow.Location = New System.Drawing.Point(99, 5)
        Me.dtpDateShow.Name = "dtpDateShow"
        Me.dtpDateShow.Size = New System.Drawing.Size(191, 26)
        Me.dtpDateShow.TabIndex = 68
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(893, 2)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 5
        '
        'frmUnloading_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.UcHeader1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmUnloading_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcMenuRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuEdit As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuDelete As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuSacrch As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuAdd As GINNTAS.ucMenutxtSub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateShow As System.Windows.Forms.DateTimePicker
    Friend WithEvents UcBack1 As GINNTAS.ucBack
End Class
