<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofCheckBitumen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenutxtSub2 = New GINNTAS.ucMenutxtSub()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpDay = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UcMenutxtSub2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 338)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 62)
        Me.Panel1.TabIndex = 0
        '
        'UcMenutxtSub2
        '
        Me.UcMenutxtSub2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenutxtSub2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub2.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcMenutxtSub2.ForeColor = System.Drawing.Color.Teal
        Me.UcMenutxtSub2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenutxtSub2.Location = New System.Drawing.Point(286, 18)
        Me.UcMenutxtSub2.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub2.MenuAuthorizeID = CType(0, Long)
        Me.UcMenutxtSub2.MenuCorners = 6
        Me.UcMenutxtSub2.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenutxtSub2.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub2.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub2.MenuIcon = Nothing
        Me.UcMenutxtSub2.MenuIconSize = New System.Drawing.Size(23, 26)
        Me.UcMenutxtSub2.MenuScreenID = CType(0, Long)
        Me.UcMenutxtSub2.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenutxtSub2.MenuText = "Export To Excel"
        Me.UcMenutxtSub2.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub2.MenuTextMargin = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.UcMenutxtSub2.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub2.MenuTextShadowShow = False
        Me.UcMenutxtSub2.Name = "UcMenutxtSub2"
        Me.UcMenutxtSub2.Size = New System.Drawing.Size(228, 32)
        Me.UcMenutxtSub2.TabIndex = 149
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpDay)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 42)
        Me.Panel2.TabIndex = 1
        '
        'dtpDay
        '
        Me.dtpDay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDay.Location = New System.Drawing.Point(116, 6)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Size = New System.Drawing.Size(144, 29)
        Me.dtpDay.TabIndex = 137
        Me.dtpDay.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประจำวันที่"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 296)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(848, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'frmProofCheckBitumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 400)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProofCheckBitumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตรวจสอบเวลาเข้ารับผลิตภัณฑ์ Bitument"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UcMenutxtSub2 As GINNTAS.ucMenutxtSub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
