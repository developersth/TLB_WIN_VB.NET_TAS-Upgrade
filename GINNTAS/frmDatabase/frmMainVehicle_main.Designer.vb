<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainVehicle_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainVehicle_main))
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.UcMenuEdit = New GINNTAS.ucMenutxtSub()
        Me.UcMenuDelete = New GINNTAS.ucMenutxtSub()
        Me.UcMenuSacrch = New GINNTAS.ucMenutxtSub()
        Me.UcMenuAdd = New GINNTAS.ucMenutxtSub()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTUHead = New System.Windows.Forms.ComboBox()
        Me.pnlFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UcHeader1.TabIndex = 189
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
        Me.pnlFooter.Controls.Add(Me.txtTotalRecord)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 698)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 35)
        Me.pnlFooter.TabIndex = 187
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.Location = New System.Drawing.Point(911, 4)
        Me.txtTotalRecord.Name = "txtTotalRecord"
        Me.txtTotalRecord.ReadOnly = True
        Me.txtTotalRecord.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalRecord.TabIndex = 7
        Me.txtTotalRecord.Text = "0"
        Me.txtTotalRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(783, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 20)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Total Record :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 733)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 35)
        Me.Panel3.TabIndex = 188
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 40)
        Me.Panel4.TabIndex = 192
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(893, 1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 2
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
        Me.TableLayoutPanel1.TabIndex = 193
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbTUHead)
        Me.Panel1.Controls.Add(Me.Label2)
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
        Me.UcMenuEdit.MenuAuthorizeID = CType(2, Long)
        Me.UcMenuEdit.MenuCorners = 6
        Me.UcMenuEdit.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEdit.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuEdit.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuEdit.MenuIcon = Nothing
        Me.UcMenuEdit.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuEdit.MenuScreenID = CType(404, Long)
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
        Me.UcMenuDelete.MenuAuthorizeID = CType(3, Long)
        Me.UcMenuDelete.MenuCorners = 6
        Me.UcMenuDelete.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDelete.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuDelete.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuDelete.MenuIcon = Nothing
        Me.UcMenuDelete.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuDelete.MenuScreenID = CType(404, Long)
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
        Me.UcMenuAdd.MenuAuthorizeID = CType(1, Long)
        Me.UcMenuAdd.MenuCorners = 6
        Me.UcMenuAdd.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuAdd.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuAdd.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuAdd.MenuIcon = Nothing
        Me.UcMenuAdd.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenuAdd.MenuScreenID = CType(404, Long)
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
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(206, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 546)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(813, 544)
        Me.DataGridView1.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "ค้นหารหัสรถ"
        '
        'cbTUHead
        '
        Me.cbTUHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTUHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTUHead.FormattingEnabled = True
        Me.cbTUHead.Location = New System.Drawing.Point(42, 452)
        Me.cbTUHead.MaxLength = 10
        Me.cbTUHead.Name = "cbTUHead"
        Me.cbTUHead.Size = New System.Drawing.Size(111, 28)
        Me.cbTUHead.TabIndex = 151
        '
        'frmMainVehicle_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMainVehicle_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcMenuRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuEdit As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuDelete As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuSacrch As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuAdd As GINNTAS.ucMenutxtSub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTUHead As System.Windows.Forms.ComboBox
End Class
