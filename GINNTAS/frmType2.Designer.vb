<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmType2))
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.UcMinimize1 = New GINNTAS.ucMinimize()
        Me.UcClose1 = New GINNTAS.ucClose()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcMenutxtSub1 = New GINNTAS.ucMenutxtSub()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcStatus1 = New GINNTAS.ucStatus()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'UcMinimize1
        '
        Me.UcMinimize1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMinimize1.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMinimize1.Location = New System.Drawing.Point(873, 4)
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
        Me.UcClose1.Name = "UcClose1"
        Me.UcClose1.Size = New System.Drawing.Size(65, 67)
        Me.UcClose1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 38)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 25, 15, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(998, 601)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Label1"
        '
        'UcMenutxtSub1
        '
        Me.UcMenutxtSub1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenutxtSub1.BackColor = System.Drawing.Color.Transparent
        Me.UcMenutxtSub1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenutxtSub1.Cursor = System.Windows.Forms.Cursors.Default
        Me.UcMenutxtSub1.Location = New System.Drawing.Point(278, 22)
        Me.UcMenutxtSub1.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenutxtSub1.MenuAuthorizeID = CType(0, Long)
        Me.UcMenutxtSub1.MenuCorners = 0
        Me.UcMenutxtSub1.MenuCursor = System.Windows.Forms.Cursors.Default
        Me.UcMenutxtSub1.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenutxtSub1.MenuForeColor = System.Drawing.Color.Black
        Me.UcMenutxtSub1.MenuIcon = CType(resources.GetObject("UcMenutxtSub1.MenuIcon"), System.Drawing.Bitmap)
        Me.UcMenutxtSub1.MenuIconSize = New System.Drawing.Size(35, 32)
        Me.UcMenutxtSub1.MenuScreenID = CType(0, Long)
        Me.UcMenutxtSub1.MenuShape = CButtonLib.CButton.eShape.Ellipse
        Me.UcMenutxtSub1.MenuText = "Default Menu"
        Me.UcMenutxtSub1.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenutxtSub1.MenuTextMargin = New System.Windows.Forms.Padding(0)
        Me.UcMenutxtSub1.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenutxtSub1.MenuTextShadowShow = False
        Me.UcMenutxtSub1.Name = "UcMenutxtSub1"
        Me.UcMenutxtSub1.Size = New System.Drawing.Size(249, 49)
        Me.UcMenutxtSub1.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(285, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UcStatus1
        '
        Me.UcStatus1.BackColor = System.Drawing.Color.Transparent
        Me.UcStatus1.BackgroundImage = Global.GINNTAS.My.Resources.Resources.Footer
        Me.UcStatus1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcStatus1.Location = New System.Drawing.Point(0, 0)
        Me.UcStatus1.Name = "UcStatus1"
        Me.UcStatus1.Size = New System.Drawing.Size(1024, 128)
        Me.UcStatus1.TabIndex = 10
        Me.UcStatus1.TabStop = False
        Me.UcStatus1.Tag = ""
        '
        'frmType2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.UcMenutxtSub1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.UcMinimize1)
        Me.Controls.Add(Me.UcClose1)
        Me.Controls.Add(Me.UcStatus1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmType2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcClose1 As GINNTAS.ucClose
    Friend WithEvents UcMinimize1 As GINNTAS.ucMinimize
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents UcStatus1 As GINNTAS.ucStatus
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcMenutxtSub1 As GINNTAS.ucMenutxtSub
    Friend WithEvents PictureBox1 As PictureBox
End Class
