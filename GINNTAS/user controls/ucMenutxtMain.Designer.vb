<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenutxtMain
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMenutxtMain))
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.picMnuBorder = New System.Windows.Forms.PictureBox()
        Me.lblMenuText = New System.Windows.Forms.Label()
        Me.picIconMenu = New System.Windows.Forms.PictureBox()
        Me.CButton1 = New CButtonLib.CButton()
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMnuBorder
        '
        Me.picMnuBorder.BackColor = System.Drawing.Color.Transparent
        Me.picMnuBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMnuBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMnuBorder.Image = CType(resources.GetObject("picMnuBorder.Image"), System.Drawing.Image)
        Me.picMnuBorder.Location = New System.Drawing.Point(0, 0)
        Me.picMnuBorder.Name = "picMnuBorder"
        Me.picMnuBorder.Size = New System.Drawing.Size(344, 71)
        Me.picMnuBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMnuBorder.TabIndex = 4
        Me.picMnuBorder.TabStop = False
        '
        'lblMenuText
        '
        Me.lblMenuText.AutoEllipsis = True
        Me.lblMenuText.AutoSize = True
        Me.lblMenuText.BackColor = System.Drawing.Color.Black
        Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenuText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuText.ForeColor = System.Drawing.Color.Black
        Me.lblMenuText.Location = New System.Drawing.Point(82, 0)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(152, 25)
        Me.lblMenuText.TabIndex = 6
        Me.lblMenuText.Text = "Default Menu"
        Me.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMenuText.Visible = False
        '
        'picIconMenu
        '
        Me.picIconMenu.Location = New System.Drawing.Point(86, 0)
        Me.picIconMenu.Name = "picIconMenu"
        Me.picIconMenu.Size = New System.Drawing.Size(35, 32)
        Me.picIconMenu.TabIndex = 8
        Me.picIconMenu.TabStop = False
        Me.picIconMenu.Visible = False
        '
        'CButton1
        '
        Me.CButton1.BackColor = System.Drawing.SystemColors.Control
        Me.CButton1.BorderColor = System.Drawing.Color.Gray
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CButton1.ColorFillBlend = CBlendItems1
        Me.CButton1.ColorFillSolid = System.Drawing.Color.Gray
        Me.CButton1.DesignerSelected = False
        Me.CButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CButton1.ForeColor = System.Drawing.Color.Black
        Me.CButton1.ImageIndex = 0
        Me.CButton1.Location = New System.Drawing.Point(0, 0)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(344, 71)
        Me.CButton1.TabIndex = 10
        Me.CButton1.Text = "CButton1"
        Me.CButton1.TextShadow = System.Drawing.Color.Snow
        '
        'ucMenutxtMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.CButton1)
        Me.Controls.Add(Me.lblMenuText)
        Me.Controls.Add(Me.picMnuBorder)
        Me.Controls.Add(Me.picIconMenu)
        Me.MaximumSize = New System.Drawing.Size(550, 91)
        Me.Name = "ucMenutxtMain"
        Me.Size = New System.Drawing.Size(344, 71)
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMnuBorder As System.Windows.Forms.PictureBox
    Friend WithEvents lblMenuText As System.Windows.Forms.Label
    Friend WithEvents picIconMenu As System.Windows.Forms.PictureBox
    Friend WithEvents CButton1 As CButtonLib.CButton

End Class
