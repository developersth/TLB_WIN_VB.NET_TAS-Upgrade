<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMnuText
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
        Me.lblMenuText = New System.Windows.Forms.Label()
        Me.picMnuBorder = New System.Windows.Forms.PictureBox()
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenuText
        '
        Me.lblMenuText.AutoEllipsis = True
        Me.lblMenuText.AutoSize = True
        Me.lblMenuText.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenuText.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuText.ForeColor = System.Drawing.Color.White
        Me.lblMenuText.Location = New System.Drawing.Point(22, 30)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(119, 23)
        Me.lblMenuText.TabIndex = 2
        Me.lblMenuText.Text = "Default Menu"
        Me.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picMnuBorder
        '
        Me.picMnuBorder.BackColor = System.Drawing.Color.Transparent
        Me.picMnuBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMnuBorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMnuBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMnuBorder.Location = New System.Drawing.Point(3, 3)
        Me.picMnuBorder.Name = "picMnuBorder"
        Me.picMnuBorder.Padding = New System.Windows.Forms.Padding(3)
        Me.picMnuBorder.Size = New System.Drawing.Size(304, 74)
        Me.picMnuBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMnuBorder.TabIndex = 1
        Me.picMnuBorder.TabStop = False
        '
        'ucMnuText
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblMenuText)
        Me.Controls.Add(Me.picMnuBorder)
        Me.MaximumSize = New System.Drawing.Size(310, 80)
        Me.Name = "ucMnuText"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(310, 80)
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMnuBorder As System.Windows.Forms.PictureBox
    Friend WithEvents lblMenuText As System.Windows.Forms.Label

End Class
