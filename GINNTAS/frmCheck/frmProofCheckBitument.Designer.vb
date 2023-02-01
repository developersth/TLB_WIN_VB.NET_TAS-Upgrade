<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofCheckBitument
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btRefresh = New GINNTAS.ucMenutxtSub()
        Me.dtpDay = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btExport = New GINNTAS.ucMenutxtSub()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btRefresh)
        Me.Panel1.Controls.Add(Me.dtpDay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 51)
        Me.Panel1.TabIndex = 0
        '
        'btRefresh
        '
        Me.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btRefresh.ForeColor = System.Drawing.Color.Teal
        Me.btRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btRefresh.Location = New System.Drawing.Point(215, 12)
        Me.btRefresh.MaximumSize = New System.Drawing.Size(550, 91)
        Me.btRefresh.MenuAuthorizeID = CType(0, Long)
        Me.btRefresh.MenuCorners = 6
        Me.btRefresh.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.btRefresh.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.MenuForeColor = System.Drawing.Color.Black
        Me.btRefresh.MenuIcon = Nothing
        Me.btRefresh.MenuIconSize = New System.Drawing.Size(23, 26)
        Me.btRefresh.MenuScreenID = CType(0, Long)
        Me.btRefresh.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.btRefresh.MenuText = "Refresh"
        Me.btRefresh.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRefresh.MenuTextMargin = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btRefresh.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.btRefresh.MenuTextShadowShow = False
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(105, 27)
        Me.btRefresh.TabIndex = 150
        '
        'dtpDay
        '
        Me.dtpDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDay.Location = New System.Drawing.Point(99, 13)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Size = New System.Drawing.Size(110, 26)
        Me.dtpDay.TabIndex = 72
        Me.dtpDay.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประจำวันที่"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btExport)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 53)
        Me.Panel2.TabIndex = 1
        '
        'btExport
        '
        Me.btExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btExport.BackColor = System.Drawing.Color.Transparent
        Me.btExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btExport.ForeColor = System.Drawing.Color.Teal
        Me.btExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btExport.Location = New System.Drawing.Point(141, 9)
        Me.btExport.MaximumSize = New System.Drawing.Size(550, 91)
        Me.btExport.MenuAuthorizeID = CType(0, Long)
        Me.btExport.MenuCorners = 6
        Me.btExport.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.btExport.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExport.MenuForeColor = System.Drawing.Color.Black
        Me.btExport.MenuIcon = Nothing
        Me.btExport.MenuIconSize = New System.Drawing.Size(23, 26)
        Me.btExport.MenuScreenID = CType(0, Long)
        Me.btExport.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.btExport.MenuText = "Export To Excel"
        Me.btExport.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExport.MenuTextMargin = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btExport.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.btExport.MenuTextShadowShow = False
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(179, 32)
        Me.btExport.TabIndex = 149
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 337)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(503, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmProofCheckBitument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 441)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "frmProofCheckBitument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตรวจสอบเวลาเข้ารับผลิตภัณฑ์ Bitument"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btExport As GINNTAS.ucMenutxtSub
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btRefresh As GINNTAS.ucMenutxtSub
End Class
