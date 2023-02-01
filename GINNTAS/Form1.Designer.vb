<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UcClose = New GINNTAS.ucClose()
        Me.UcMinimize = New GINNTAS.ucMinimize()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenu1 = New GINNTAS.ucMenu()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(288, 100)
        Me.DataGridView1.TabIndex = 3
        '
        'UcClose
        '
        Me.UcClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcClose.BackColor = System.Drawing.Color.Transparent
        Me.UcClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcClose.Location = New System.Drawing.Point(1191, 1)
        Me.UcClose.Name = "UcClose"
        Me.UcClose.Size = New System.Drawing.Size(75, 67)
        Me.UcClose.TabIndex = 2
        '
        'UcMinimize
        '
        Me.UcMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMinimize.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMinimize.Location = New System.Drawing.Point(1111, 1)
        Me.UcMinimize.Name = "UcMinimize"
        Me.UcMinimize.Size = New System.Drawing.Size(74, 67)
        Me.UcMinimize.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(378, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 178)
        Me.Panel1.TabIndex = 4
        '
        'UcMenu1
        '
        Me.UcMenu1.BackColor = System.Drawing.Color.Transparent
        Me.UcMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenu1.Location = New System.Drawing.Point(28, 157)
        Me.UcMenu1.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UcMenu1.MenuForeColor = System.Drawing.Color.White
        Me.UcMenu1.MenuIcon = CType(resources.GetObject("UcMenu1.MenuIcon"), System.Drawing.Bitmap)
        Me.UcMenu1.MenuPicMouseHover = CType(resources.GetObject("UcMenu1.MenuPicMouseHover"), System.Drawing.Bitmap)
        Me.UcMenu1.MenuPicMouseLeave = CType(resources.GetObject("UcMenu1.MenuPicMouseLeave"), System.Drawing.Bitmap)
        Me.UcMenu1.MenuText = "CARD"
        Me.UcMenu1.Name = "UcMenu1"
        Me.UcMenu1.Size = New System.Drawing.Size(89, 86)
        Me.UcMenu1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1278, 620)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UcClose)
        Me.Controls.Add(Me.UcMenu1)
        Me.Controls.Add(Me.UcMinimize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMinimize As GINNTAS.ucMinimize
    Friend WithEvents UcMenu1 As GINNTAS.ucMenu
    Friend WithEvents UcClose As GINNTAS.ucClose
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
