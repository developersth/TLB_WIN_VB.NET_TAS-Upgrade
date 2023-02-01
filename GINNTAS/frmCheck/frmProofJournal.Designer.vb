<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofJournal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProofJournal))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chAutoRefresh = New System.Windows.Forms.CheckBox()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenuRefresh = New GINNTAS.ucMenutxtSub()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.UcMenu_Clear = New GINNTAS.ucMenutxtSub()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcMenuExport = New GINNTAS.ucMenutxtSub()
        Me.cbSourceID = New System.Windows.Forms.ComboBox()
        Me.cbCategoryID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFromTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpToTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpTodate = New System.Windows.Forms.DateTimePicker()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.cbSource = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbComputer = New System.Windows.Forms.ComboBox()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlFooter.TabIndex = 173
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 733)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 35)
        Me.Panel3.TabIndex = 174
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(1022, 33)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.chAutoRefresh)
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 40)
        Me.Panel4.TabIndex = 178
        '
        'chAutoRefresh
        '
        Me.chAutoRefresh.AutoSize = True
        Me.chAutoRefresh.Checked = True
        Me.chAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chAutoRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chAutoRefresh.Location = New System.Drawing.Point(19, 9)
        Me.chAutoRefresh.Name = "chAutoRefresh"
        Me.chAutoRefresh.Size = New System.Drawing.Size(135, 24)
        Me.chAutoRefresh.TabIndex = 135
        Me.chAutoRefresh.Text = "Auto Refresh"
        Me.chAutoRefresh.UseVisualStyleBackColor = True
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Location = New System.Drawing.Point(893, 0)
        Me.UcBack1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.12109!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.87891!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1024, 552)
        Me.TableLayoutPanel1.TabIndex = 179
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMenuRefresh)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.UcMenu_Clear)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 546)
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
        Me.UcMenuRefresh.ForeColor = System.Drawing.Color.Teal
        Me.UcMenuRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuRefresh.Location = New System.Drawing.Point(59, 15)
        Me.UcMenuRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuRefresh.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuRefresh.MenuCorners = 6
        Me.UcMenuRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuRefresh.MenuIcon = Nothing
        Me.UcMenuRefresh.MenuIconSize = New System.Drawing.Size(13, 26)
        Me.UcMenuRefresh.MenuScreenID = CType(0, Long)
        Me.UcMenuRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuRefresh.MenuText = "Refresh"
        Me.UcMenuRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuRefresh.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenuRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuRefresh.MenuTextShadowShow = False
        Me.UcMenuRefresh.Name = "UcMenuRefresh"
        Me.UcMenuRefresh.Size = New System.Drawing.Size(97, 38)
        Me.UcMenuRefresh.TabIndex = 133
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(51, 103)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 24)
        Me.CheckBox1.TabIndex = 131
        Me.CheckBox1.Text = "ค้นหาเหตุการณ์"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'UcMenu_Clear
        '
        Me.UcMenu_Clear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenu_Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenu_Clear.BackColor = System.Drawing.Color.Transparent
        Me.UcMenu_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenu_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenu_Clear.ForeColor = System.Drawing.Color.Gray
        Me.UcMenu_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenu_Clear.Location = New System.Drawing.Point(59, 59)
        Me.UcMenu_Clear.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenu_Clear.MenuAuthorizeID = CType(0, Long)
        Me.UcMenu_Clear.MenuCorners = 6
        Me.UcMenu_Clear.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenu_Clear.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenu_Clear.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenu_Clear.MenuIcon = Nothing
        Me.UcMenu_Clear.MenuIconSize = New System.Drawing.Size(13, 26)
        Me.UcMenu_Clear.MenuScreenID = CType(0, Long)
        Me.UcMenu_Clear.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenu_Clear.MenuText = "Clear"
        Me.UcMenu_Clear.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenu_Clear.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenu_Clear.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenu_Clear.MenuTextShadowShow = False
        Me.UcMenu_Clear.Name = "UcMenu_Clear"
        Me.UcMenu_Clear.Size = New System.Drawing.Size(97, 38)
        Me.UcMenu_Clear.TabIndex = 134
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcMenuExport)
        Me.GroupBox1.Controls.Add(Me.cbSourceID)
        Me.GroupBox1.Controls.Add(Me.cbCategoryID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpFromTime)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.dtpToTime)
        Me.GroupBox1.Controls.Add(Me.dtpTodate)
        Me.GroupBox1.Controls.Add(Me.txtMsg)
        Me.GroupBox1.Controls.Add(Me.cbSource)
        Me.GroupBox1.Controls.Add(Me.cbCategory)
        Me.GroupBox1.Controls.Add(Me.cbComputer)
        Me.GroupBox1.Controls.Add(Me.cbUser)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 120)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(231, 422)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'UcMenuExport
        '
        Me.UcMenuExport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuExport.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuExport.ForeColor = System.Drawing.Color.Gray
        Me.UcMenuExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuExport.Location = New System.Drawing.Point(55, 376)
        Me.UcMenuExport.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuExport.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuExport.MenuCorners = 6
        Me.UcMenuExport.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuExport.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuExport.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenuExport.MenuIcon = Nothing
        Me.UcMenuExport.MenuIconSize = New System.Drawing.Size(13, 26)
        Me.UcMenuExport.MenuScreenID = CType(0, Long)
        Me.UcMenuExport.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuExport.MenuText = "Export Excel"
        Me.UcMenuExport.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuExport.MenuTextMargin = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.UcMenuExport.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuExport.MenuTextShadowShow = False
        Me.UcMenuExport.Name = "UcMenuExport"
        Me.UcMenuExport.Size = New System.Drawing.Size(97, 38)
        Me.UcMenuExport.TabIndex = 135
        '
        'cbSourceID
        '
        Me.cbSourceID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSourceID.FormattingEnabled = True
        Me.cbSourceID.Location = New System.Drawing.Point(24, 242)
        Me.cbSourceID.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSourceID.Name = "cbSourceID"
        Me.cbSourceID.Size = New System.Drawing.Size(137, 28)
        Me.cbSourceID.TabIndex = 56
        Me.cbSourceID.Visible = False
        '
        'cbCategoryID
        '
        Me.cbCategoryID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategoryID.FormattingEnabled = True
        Me.cbCategoryID.Location = New System.Drawing.Point(24, 218)
        Me.cbCategoryID.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCategoryID.Name = "cbCategoryID"
        Me.cbCategoryID.Size = New System.Drawing.Size(137, 28)
        Me.cbCategoryID.TabIndex = 55
        Me.cbCategoryID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 323)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "ถึงวันที่"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "จากวันที่"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ข้อความ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Source"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "คอมพิวเตอร์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ผู้ใช้"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "ประเภท"
        '
        'dtpFromTime
        '
        Me.dtpFromTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFromTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFromTime.Location = New System.Drawing.Point(134, 294)
        Me.dtpFromTime.Name = "dtpFromTime"
        Me.dtpFromTime.ShowUpDown = True
        Me.dtpFromTime.Size = New System.Drawing.Size(94, 26)
        Me.dtpFromTime.TabIndex = 43
        Me.dtpFromTime.Value = New Date(2015, 4, 10, 0, 0, 0, 0)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(6, 294)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(122, 26)
        Me.dtpFromDate.TabIndex = 42
        '
        'dtpToTime
        '
        Me.dtpToTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpToTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpToTime.Location = New System.Drawing.Point(134, 344)
        Me.dtpToTime.Name = "dtpToTime"
        Me.dtpToTime.ShowUpDown = True
        Me.dtpToTime.Size = New System.Drawing.Size(92, 26)
        Me.dtpToTime.TabIndex = 41
        Me.dtpToTime.Value = New Date(2015, 4, 10, 23, 59, 0, 0)
        '
        'dtpTodate
        '
        Me.dtpTodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTodate.Location = New System.Drawing.Point(7, 344)
        Me.dtpTodate.Name = "dtpTodate"
        Me.dtpTodate.Size = New System.Drawing.Size(120, 26)
        Me.dtpTodate.TabIndex = 40
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMsg.Location = New System.Drawing.Point(86, 193)
        Me.txtMsg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(137, 73)
        Me.txtMsg.TabIndex = 5
        '
        'cbSource
        '
        Me.cbSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSource.FormattingEnabled = True
        Me.cbSource.Location = New System.Drawing.Point(86, 152)
        Me.cbSource.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSource.Name = "cbSource"
        Me.cbSource.Size = New System.Drawing.Size(137, 28)
        Me.cbSource.TabIndex = 4
        '
        'cbCategory
        '
        Me.cbCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(86, 119)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(137, 28)
        Me.cbCategory.TabIndex = 3
        '
        'cbComputer
        '
        Me.cbComputer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbComputer.FormattingEnabled = True
        Me.cbComputer.Location = New System.Drawing.Point(87, 83)
        Me.cbComputer.Margin = New System.Windows.Forms.Padding(2)
        Me.cbComputer.Name = "cbComputer"
        Me.cbComputer.Size = New System.Drawing.Size(137, 28)
        Me.cbComputer.TabIndex = 2
        '
        'cbUser
        '
        Me.cbUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(87, 50)
        Me.cbUser.Margin = New System.Windows.Forms.Padding(2)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(137, 28)
        Me.cbUser.TabIndex = 1
        '
        'cbType
        '
        Me.cbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(87, 15)
        Me.cbType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(137, 28)
        Me.cbType.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(249, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 546)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView.ColumnHeadersHeight = 35
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(770, 544)
        Me.DataGridView.TabIndex = 1
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1024, 106)
        Me.UcHeader1.TabIndex = 175
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmProofJournal
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
        Me.Name = "frmProofJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcMenuRefresh As GINNTAS.ucMenutxtSub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents UcMenu_Clear As GINNTAS.ucMenutxtSub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSourceID As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFromTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents cbSource As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbComputer As System.Windows.Forms.ComboBox
    Friend WithEvents cbUser As System.Windows.Forms.ComboBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents UcMenuExport As ucMenutxtSub
    Friend WithEvents chAutoRefresh As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
