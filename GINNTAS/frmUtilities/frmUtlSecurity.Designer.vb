<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlSecurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtlSecurity))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblPriorityName = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.Cancle = New System.Windows.Forms.Button()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UcMenuProgrammer = New GINNTAS.ucMenutxtSub()
        Me.UcMenuEngineer = New GINNTAS.ucMenutxtSub()
        Me.UcMenuSSLTO = New GINNTAS.ucMenutxtSub()
        Me.UcMenuDepotOperator = New GINNTAS.ucMenutxtSub()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.SCREEN_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUB_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAIN_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUB_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERMISSION = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CONFIRM_PASSWORD = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel3.TabIndex = 180
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
        Me.Panel4.TabIndex = 182
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.cmdReport)
        Me.pnlFooter.Controls.Add(Me.lblPriority)
        Me.pnlFooter.Controls.Add(Me.lblPriorityName)
        Me.pnlFooter.Controls.Add(Me.SAVE)
        Me.pnlFooter.Controls.Add(Me.Cancle)
        Me.pnlFooter.Controls.Add(Me.txtTotalRecord)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 851)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1365, 51)
        Me.pnlFooter.TabIndex = 185
        '
        'cmdReport
        '
        Me.cmdReport.BackColor = System.Drawing.Color.Red
        Me.cmdReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdReport.Location = New System.Drawing.Point(28, 5)
        Me.cmdReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(175, 37)
        Me.cmdReport.TabIndex = 27
        Me.cmdReport.Text = "พิมพ์รายงาน"
        Me.cmdReport.UseVisualStyleBackColor = False
        '
        'lblPriority
        '
        Me.lblPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(457, 11)
        Me.lblPriority.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(26, 29)
        Me.lblPriority.TabIndex = 26
        Me.lblPriority.Text = "0"
        Me.lblPriority.Visible = False
        '
        'lblPriorityName
        '
        Me.lblPriorityName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriorityName.AutoSize = True
        Me.lblPriorityName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriorityName.Location = New System.Drawing.Point(275, 9)
        Me.lblPriorityName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriorityName.Name = "lblPriorityName"
        Me.lblPriorityName.Size = New System.Drawing.Size(179, 29)
        Me.lblPriorityName.TabIndex = 25
        Me.lblPriorityName.Text = "lblPriorityName"
        '
        'SAVE
        '
        Me.SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SAVE.BackColor = System.Drawing.Color.Lime
        Me.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SAVE.Location = New System.Drawing.Point(815, 5)
        Me.SAVE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(100, 36)
        Me.SAVE.TabIndex = 24
        Me.SAVE.Text = "บันทึก"
        Me.SAVE.UseVisualStyleBackColor = False
        Me.SAVE.Visible = False
        '
        'Cancle
        '
        Me.Cancle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cancle.Location = New System.Drawing.Point(931, 4)
        Me.Cancle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancle.Name = "Cancle"
        Me.Cancle.Size = New System.Drawing.Size(100, 36)
        Me.Cancle.TabIndex = 23
        Me.Cancle.Text = "ยกเลิก"
        Me.Cancle.UseVisualStyleBackColor = False
        Me.Cancle.Visible = False
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.Location = New System.Drawing.Point(1215, 4)
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
        Me.label1.Location = New System.Drawing.Point(1044, 7)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(148, 25)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Total Record :"
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 672.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1365, 672)
        Me.TableLayoutPanel1.TabIndex = 186
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMenuProgrammer)
        Me.Panel1.Controls.Add(Me.UcMenuEngineer)
        Me.Panel1.Controls.Add(Me.UcMenuSSLTO)
        Me.Panel1.Controls.Add(Me.UcMenuDepotOperator)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 664)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(274, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1087, 664)
        Me.Panel2.TabIndex = 1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCREEN_ID, Me.SUB_ID, Me.MAIN_MENU, Me.SUB_MENU, Me.PERMISSION, Me.CONFIRM_PASSWORD})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1085, 662)
        Me.DataGridView1.TabIndex = 1
        '
        'UcMenuProgrammer
        '
        Me.UcMenuProgrammer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuProgrammer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuProgrammer.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuProgrammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuProgrammer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuProgrammer.Enabled = False
        Me.UcMenuProgrammer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuProgrammer.Location = New System.Drawing.Point(25, 215)
        Me.UcMenuProgrammer.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuProgrammer.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuProgrammer.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuProgrammer.MenuCorners = 6
        Me.UcMenuProgrammer.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuProgrammer.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuProgrammer.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuProgrammer.MenuIcon = Nothing
        Me.UcMenuProgrammer.MenuIconSize = New System.Drawing.Size(20, 23)
        Me.UcMenuProgrammer.MenuScreenID = CType(0, Long)
        Me.UcMenuProgrammer.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuProgrammer.MenuText = "Programmer"
        Me.UcMenuProgrammer.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuProgrammer.MenuTextMargin = New System.Windows.Forms.Padding(36, 0, 0, 0)
        Me.UcMenuProgrammer.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuProgrammer.MenuTextShadowShow = False
        Me.UcMenuProgrammer.Name = "UcMenuProgrammer"
        Me.UcMenuProgrammer.Size = New System.Drawing.Size(192, 47)
        Me.UcMenuProgrammer.TabIndex = 53
        '
        'UcMenuEngineer
        '
        Me.UcMenuEngineer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuEngineer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuEngineer.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuEngineer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuEngineer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEngineer.Enabled = False
        Me.UcMenuEngineer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuEngineer.Location = New System.Drawing.Point(24, 153)
        Me.UcMenuEngineer.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuEngineer.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuEngineer.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuEngineer.MenuCorners = 6
        Me.UcMenuEngineer.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEngineer.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuEngineer.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuEngineer.MenuIcon = Nothing
        Me.UcMenuEngineer.MenuIconSize = New System.Drawing.Size(20, 23)
        Me.UcMenuEngineer.MenuScreenID = CType(0, Long)
        Me.UcMenuEngineer.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuEngineer.MenuText = "Engineer"
        Me.UcMenuEngineer.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuEngineer.MenuTextMargin = New System.Windows.Forms.Padding(36, 0, 0, 0)
        Me.UcMenuEngineer.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuEngineer.MenuTextShadowShow = False
        Me.UcMenuEngineer.Name = "UcMenuEngineer"
        Me.UcMenuEngineer.Size = New System.Drawing.Size(192, 47)
        Me.UcMenuEngineer.TabIndex = 52
        '
        'UcMenuSSLTO
        '
        Me.UcMenuSSLTO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuSSLTO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuSSLTO.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuSSLTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuSSLTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSSLTO.Enabled = False
        Me.UcMenuSSLTO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuSSLTO.Location = New System.Drawing.Point(25, 90)
        Me.UcMenuSSLTO.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuSSLTO.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuSSLTO.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuSSLTO.MenuCorners = 6
        Me.UcMenuSSLTO.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSSLTO.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuSSLTO.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuSSLTO.MenuIcon = Nothing
        Me.UcMenuSSLTO.MenuIconSize = New System.Drawing.Size(20, 23)
        Me.UcMenuSSLTO.MenuScreenID = CType(0, Long)
        Me.UcMenuSSLTO.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuSSLTO.MenuText = "SS/LTO"
        Me.UcMenuSSLTO.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuSSLTO.MenuTextMargin = New System.Windows.Forms.Padding(36, 0, 0, 0)
        Me.UcMenuSSLTO.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuSSLTO.MenuTextShadowShow = False
        Me.UcMenuSSLTO.Name = "UcMenuSSLTO"
        Me.UcMenuSSLTO.Size = New System.Drawing.Size(192, 47)
        Me.UcMenuSSLTO.TabIndex = 51
        '
        'UcMenuDepotOperator
        '
        Me.UcMenuDepotOperator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuDepotOperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuDepotOperator.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuDepotOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuDepotOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDepotOperator.Enabled = False
        Me.UcMenuDepotOperator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuDepotOperator.Location = New System.Drawing.Point(29, 26)
        Me.UcMenuDepotOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMenuDepotOperator.MaximumSize = New System.Drawing.Size(733, 112)
        Me.UcMenuDepotOperator.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuDepotOperator.MenuCorners = 6
        Me.UcMenuDepotOperator.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDepotOperator.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuDepotOperator.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuDepotOperator.MenuIcon = Nothing
        Me.UcMenuDepotOperator.MenuIconSize = New System.Drawing.Size(20, 23)
        Me.UcMenuDepotOperator.MenuScreenID = CType(0, Long)
        Me.UcMenuDepotOperator.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuDepotOperator.MenuText = "Depot Operator"
        Me.UcMenuDepotOperator.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuDepotOperator.MenuTextMargin = New System.Windows.Forms.Padding(36, 0, 0, 0)
        Me.UcMenuDepotOperator.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuDepotOperator.MenuTextShadowShow = False
        Me.UcMenuDepotOperator.Name = "UcMenuDepotOperator"
        Me.UcMenuDepotOperator.Size = New System.Drawing.Size(192, 47)
        Me.UcMenuDepotOperator.TabIndex = 49
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
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(1191, 1)
        Me.UcBack1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(169, 43)
        Me.UcBack1.TabIndex = 1
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
        Me.UcHeader1.TabIndex = 181
        '
        'SCREEN_ID
        '
        Me.SCREEN_ID.HeaderText = "Screen No."
        Me.SCREEN_ID.MinimumWidth = 6
        Me.SCREEN_ID.Name = "SCREEN_ID"
        Me.SCREEN_ID.Width = 149
        '
        'SUB_ID
        '
        Me.SUB_ID.HeaderText = "Sub"
        Me.SUB_ID.MinimumWidth = 6
        Me.SUB_ID.Name = "SUB_ID"
        Me.SUB_ID.Width = 80
        '
        'MAIN_MENU
        '
        Me.MAIN_MENU.HeaderText = "Main Menu "
        Me.MAIN_MENU.MinimumWidth = 6
        Me.MAIN_MENU.Name = "MAIN_MENU"
        Me.MAIN_MENU.Width = 154
        '
        'SUB_MENU
        '
        Me.SUB_MENU.HeaderText = "Description"
        Me.SUB_MENU.MinimumWidth = 6
        Me.SUB_MENU.Name = "SUB_MENU"
        Me.SUB_MENU.Width = 149
        '
        'PERMISSION
        '
        Me.PERMISSION.HeaderText = "Permit"
        Me.PERMISSION.MinimumWidth = 6
        Me.PERMISSION.Name = "PERMISSION"
        Me.PERMISSION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PERMISSION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PERMISSION.Width = 102
        '
        'CONFIRM_PASSWORD
        '
        Me.CONFIRM_PASSWORD.HeaderText = "Confirm PW"
        Me.CONFIRM_PASSWORD.MinimumWidth = 6
        Me.CONFIRM_PASSWORD.Name = "CONFIRM_PASSWORD"
        Me.CONFIRM_PASSWORD.Width = 134
        '
        'frmUtlSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 945)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUtlSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcMenuProgrammer As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuEngineer As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuSSLTO As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuDepotOperator As GINNTAS.ucMenutxtSub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblPriorityName As System.Windows.Forms.Label
    Friend WithEvents SAVE As System.Windows.Forms.Button
    Friend WithEvents Cancle As System.Windows.Forms.Button
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents SCREEN_ID As DataGridViewTextBoxColumn
    Friend WithEvents SUB_ID As DataGridViewTextBoxColumn
    Friend WithEvents MAIN_MENU As DataGridViewTextBoxColumn
    Friend WithEvents SUB_MENU As DataGridViewTextBoxColumn
    Friend WithEvents PERMISSION As DataGridViewCheckBoxColumn
    Friend WithEvents CONFIRM_PASSWORD As DataGridViewCheckBoxColumn
End Class
