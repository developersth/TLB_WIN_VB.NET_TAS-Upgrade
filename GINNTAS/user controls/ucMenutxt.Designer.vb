<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenutxt
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
        Me.picIconMenu = New System.Windows.Forms.PictureBox()
        Me.picMnuBorder = New System.Windows.Forms.PictureBox()
        Me.lblMenuText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIconMenu
        '
        Me.picIconMenu.BackColor = System.Drawing.Color.Transparent
        Me.picIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picIconMenu.Location = New System.Drawing.Point(42, 9)
        Me.picIconMenu.Name = "picIconMenu"
        Me.picIconMenu.Size = New System.Drawing.Size(75, 75)
        Me.picIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIconMenu.TabIndex = 5
        Me.picIconMenu.TabStop = False
        '
        'picMnuBorder
        '
        Me.picMnuBorder.BackColor = System.Drawing.Color.Transparent
        Me.picMnuBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMnuBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMnuBorder.Image = Global.GINNTAS.My.Resources.Resources.BGMenu1
        Me.picMnuBorder.Location = New System.Drawing.Point(0, 0)
        Me.picMnuBorder.Name = "picMnuBorder"
        Me.picMnuBorder.Size = New System.Drawing.Size(550, 91)
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
        Me.lblMenuText.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMenuText.Location = New System.Drawing.Point(134, 38)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(119, 23)
        Me.lblMenuText.TabIndex = 6
        Me.lblMenuText.Text = "Default Menu"
        Me.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(294, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(368, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 13)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Test"
        '
        'ucMenutxt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenuText)
        Me.Controls.Add(Me.picIconMenu)
        Me.Controls.Add(Me.picMnuBorder)
        Me.MaximumSize = New System.Drawing.Size(550, 91)
        Me.Name = "ucMenutxt"
        Me.Size = New System.Drawing.Size(550, 91)
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMnuBorder As System.Windows.Forms.PictureBox
    Friend WithEvents picIconMenu As System.Windows.Forms.PictureBox
    Friend WithEvents lblMenuText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
