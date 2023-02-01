<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainTransportUnit_main
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainTransportUnit_main))
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTUHead = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.UcMenuEdit = New GINNTAS.ucMenutxtSub()
        Me.UcMenuDelete = New GINNTAS.ucMenutxtSub()
        Me.UcMenuSacrch = New GINNTAS.ucMenutxtSub()
        Me.UcMenuAdd = New GINNTAS.ucMenutxtSub()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.pnlFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.txtTotalRecord)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 859)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1365, 43)
        Me.pnlFooter.TabIndex = 173
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.Location = New System.Drawing.Point(1213, 5)
        Me.txtTotalRecord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalRecord.Name = "txtTotalRecord"
        Me.txtTotalRecord.ReadOnly = True
        Me.txtTotalRecord.Size = New System.Drawing.Size(132, 30)
        Me.txtTotalRecord.TabIndex = 5
        Me.txtTotalRecord.Text = "0"
        Me.txtTotalRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(1043, 9)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(148, 25)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Total Record :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 902)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1365, 43)
        Me.Panel3.TabIndex = 174
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 130)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1365, 49)
        Me.Panel4.TabIndex = 178
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.82422!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17578!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 179)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 680.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1365, 680)
        Me.TableLayoutPanel1.TabIndex = 179
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbTUHead)
        Me.Panel1.Controls.Add(Me.UcMenuRefresh)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UcMenuEdit)
        Me.Panel1.Controls.Add(Me.UcMenuDelete)
        Me.Panel1.Controls.Add(Me.UcMenuSacrch)
        Me.Panel1.Controls.Add(Me.UcMenuAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 672)
        Me.Panel1.TabIndex = 0
        '
        'cbTUHead
        '
        Me.cbTUHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTUHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTUHead.FormattingEnabled = True
        Me.cbTUHead.Location = New System.Drawing.Point(56, 594)
        Me.cbTUHead.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTUHead.MaxLength = 10
        Me.cbTUHead.Name = "cbTUHead"
        Me.cbTUHead.Size = New System.Drawing.Size(147, 33)
        Me.cbTUHead.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 561)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ค้นหาทะเบียนรถ"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(274, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1087, 672)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1085, 670)
        Me.DataGridView1.TabIndex = 140
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
        Me.UcMenuRefresh.Location = New System.Drawing.Point(56, 25)
        Me.UcMenuRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuRefresh.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuRefresh.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuRefresh.MenuCorners = 6
        Me.UcMenuRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.MenuIcon = Nothing
        Me.UcMenuRefresh.MenuIconSize = New System.Drawing.Size(16, 23)
        Me.UcMenuRefresh.MenuScreenID = CType(0, Long)
        Me.UcMenuRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuRefresh.MenuText = "Refresh"
        Me.UcMenuRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuRefresh.MenuTextMargin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UcMenuRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuRefresh.MenuTextShadowShow = False
        Me.UcMenuRefresh.Name = "UcMenuRefresh"
        Me.UcMenuRefresh.Size = New System.Drawing.Size(148, 47)
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
        Me.UcMenuEdit.Location = New System.Drawing.Point(56, 172)
        Me.UcMenuEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuEdit.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuEdit.MenuAuthorizeID = CType(2, Long)
        Me.UcMenuEdit.MenuCorners = 6
        Me.UcMenuEdit.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEdit.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuEdit.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuEdit.MenuIcon = Nothing
        Me.UcMenuEdit.MenuIconSize = New System.Drawing.Size(16, 23)
        Me.UcMenuEdit.MenuScreenID = CType(403, Long)
        Me.UcMenuEdit.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuEdit.MenuText = "Edit"
        Me.UcMenuEdit.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuEdit.MenuTextMargin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UcMenuEdit.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuEdit.MenuTextShadowShow = False
        Me.UcMenuEdit.Name = "UcMenuEdit"
        Me.UcMenuEdit.Size = New System.Drawing.Size(148, 47)
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
        Me.UcMenuDelete.Location = New System.Drawing.Point(56, 246)
        Me.UcMenuDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuDelete.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuDelete.MenuAuthorizeID = CType(3, Long)
        Me.UcMenuDelete.MenuCorners = 6
        Me.UcMenuDelete.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDelete.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuDelete.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuDelete.MenuIcon = Nothing
        Me.UcMenuDelete.MenuIconSize = New System.Drawing.Size(16, 23)
        Me.UcMenuDelete.MenuScreenID = CType(403, Long)
        Me.UcMenuDelete.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuDelete.MenuText = "Delete"
        Me.UcMenuDelete.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuDelete.MenuTextMargin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UcMenuDelete.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuDelete.MenuTextShadowShow = False
        Me.UcMenuDelete.Name = "UcMenuDelete"
        Me.UcMenuDelete.Size = New System.Drawing.Size(148, 47)
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
        Me.UcMenuSacrch.Location = New System.Drawing.Point(56, 320)
        Me.UcMenuSacrch.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuSacrch.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuSacrch.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuSacrch.MenuCorners = 6
        Me.UcMenuSacrch.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSacrch.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuSacrch.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuSacrch.MenuIcon = Nothing
        Me.UcMenuSacrch.MenuIconSize = New System.Drawing.Size(16, 23)
        Me.UcMenuSacrch.MenuScreenID = CType(0, Long)
        Me.UcMenuSacrch.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuSacrch.MenuText = "Search"
        Me.UcMenuSacrch.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuSacrch.MenuTextMargin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UcMenuSacrch.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuSacrch.MenuTextShadowShow = False
        Me.UcMenuSacrch.Name = "UcMenuSacrch"
        Me.UcMenuSacrch.Size = New System.Drawing.Size(148, 47)
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
        Me.UcMenuAdd.Location = New System.Drawing.Point(56, 98)
        Me.UcMenuAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuAdd.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuAdd.MenuAuthorizeID = CType(1, Long)
        Me.UcMenuAdd.MenuCorners = 6
        Me.UcMenuAdd.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuAdd.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuAdd.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuAdd.MenuIcon = Nothing
        Me.UcMenuAdd.MenuIconSize = New System.Drawing.Size(16, 23)
        Me.UcMenuAdd.MenuScreenID = CType(403, Long)
        Me.UcMenuAdd.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuAdd.MenuText = "Add"
        Me.UcMenuAdd.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuAdd.MenuTextMargin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UcMenuAdd.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuAdd.MenuTextShadowShow = False
        Me.UcMenuAdd.Name = "UcMenuAdd"
        Me.UcMenuAdd.Size = New System.Drawing.Size(148, 47)
        Me.UcMenuAdd.TabIndex = 142
        Me.UcMenuAdd.Tag = "2"
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(1191, 2)
        Me.UcBack1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(169, 43)
        Me.UcBack1.TabIndex = 2
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1365, 130)
        Me.UcHeader1.TabIndex = 175
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(1363, 41)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'frmMainTransportUnit_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 945)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMainTransportUnit_main"
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
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTUHead As System.Windows.Forms.ComboBox
End Class
