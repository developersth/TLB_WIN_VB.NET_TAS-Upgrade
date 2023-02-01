<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSchedule
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
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UcSearch1 = New GINNTAS.ucSearch()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcEdit1 = New GINNTAS.ucEdit()
        Me.UcInsert1 = New GINNTAS.ucInsert()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.UcMinimize1 = New GINNTAS.ucMinimize()
        Me.UcClose1 = New GINNTAS.ucClose()
        Me.UcStatus1 = New GINNTAS.ucStatus()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtbToDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleName
        '
        Me.lblTitleName.AutoSize = True
        Me.lblTitleName.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTitleName.Location = New System.Drawing.Point(19, 91)
        Me.lblTitleName.Name = "lblTitleName"
        Me.lblTitleName.Size = New System.Drawing.Size(89, 20)
        Me.lblTitleName.TabIndex = 5
        Me.lblTitleName.Text = "TitleName"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 158)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcSearch1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcCancel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcInsert1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.SplitContainer1.Size = New System.Drawing.Size(998, 601)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBox1.Location = New System.Drawing.Point(191, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 5
        '
        'UcSearch1
        '
        Me.UcSearch1.BackColor = System.Drawing.Color.Transparent
        Me.UcSearch1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcSearch1.Location = New System.Drawing.Point(142, 20)
        Me.UcSearch1.Name = "UcSearch1"
        Me.UcSearch1.Size = New System.Drawing.Size(44, 57)
        Me.UcSearch1.TabIndex = 4
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcCancel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcCancel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcCancel1.Location = New System.Drawing.Point(98, 20)
        Me.UcCancel1.MenuAuthorizeID = Nothing
        Me.UcCancel1.MenuScreenID = CType(0, Long)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(44, 57)
        Me.UcCancel1.TabIndex = 3
        '
        'UcEdit1
        '
        Me.UcEdit1.BackColor = System.Drawing.Color.Transparent
        Me.UcEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcEdit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcEdit1.Location = New System.Drawing.Point(54, 20)
        Me.UcEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcEdit1.MenuAuthorizeID = Nothing
        Me.UcEdit1.MenuScreenID = CType(0, Long)
        Me.UcEdit1.Name = "UcEdit1"
        Me.UcEdit1.Size = New System.Drawing.Size(44, 57)
        Me.UcEdit1.TabIndex = 2
        '
        'UcInsert1
        '
        Me.UcInsert1.BackColor = System.Drawing.Color.Transparent
        Me.UcInsert1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcInsert1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcInsert1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcInsert1.Location = New System.Drawing.Point(10, 20)
        Me.UcInsert1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcInsert1.MenuAuthorizeID = Nothing
        Me.UcInsert1.MenuScreenID = CType(0, Long)
        Me.UcInsert1.Name = "UcInsert1"
        Me.UcInsert1.Size = New System.Drawing.Size(44, 57)
        Me.UcInsert1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TreeView1.Location = New System.Drawing.Point(10, 77)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(333, 512)
        Me.TreeView1.TabIndex = 0
        '
        'dgvMain
        '
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvMain.Location = New System.Drawing.Point(8, 8)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(615, 343)
        Me.dgvMain.TabIndex = 0
        '
        'UcMinimize1
        '
        Me.UcMinimize1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMinimize1.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMinimize1.Location = New System.Drawing.Point(873, 4)
        Me.UcMinimize1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcMinimize1.Name = "UcMinimize1"
        Me.UcMinimize1.Size = New System.Drawing.Size(65, 67)
        Me.UcMinimize1.TabIndex = 1
        '
        'UcClose1
        '
        Me.UcClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcClose1.BackColor = System.Drawing.Color.Transparent
        Me.UcClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcClose1.Location = New System.Drawing.Point(942, 4)
        Me.UcClose1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcClose1.Name = "UcClose1"
        Me.UcClose1.Size = New System.Drawing.Size(65, 67)
        Me.UcClose1.TabIndex = 0
        '
        'UcStatus1
        '
        Me.UcStatus1.BackColor = System.Drawing.Color.Transparent
        Me.UcStatus1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcStatus1.Location = New System.Drawing.Point(0, 0)
        Me.UcStatus1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcStatus1.Name = "UcStatus1"
        Me.UcStatus1.Size = New System.Drawing.Size(1024, 128)
        Me.UcStatus1.TabIndex = 10
        Me.UcStatus1.TabStop = False
        Me.UcStatus1.Tag = ""
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFromDate.Location = New System.Drawing.Point(712, 134)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(131, 20)
        Me.dtpFromDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(676, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(849, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "To"
        '
        'dtbToDate
        '
        Me.dtbToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbToDate.Location = New System.Drawing.Point(876, 134)
        Me.dtbToDate.Name = "dtbToDate"
        Me.dtbToDate.Size = New System.Drawing.Size(131, 20)
        Me.dtbToDate.TabIndex = 32
        '
        'frmOrderSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.dtbToDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.UcMinimize1)
        Me.Controls.Add(Me.UcClose1)
        Me.Controls.Add(Me.UcStatus1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmOrderSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcClose1 As GINNTAS.ucClose
    Friend WithEvents UcMinimize1 As GINNTAS.ucMinimize
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents UcStatus1 As GINNTAS.ucStatus
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtbToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UcInsert1 As GINNTAS.ucInsert
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UcSearch1 As GINNTAS.ucSearch
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents UcEdit1 As GINNTAS.ucEdit

End Class
