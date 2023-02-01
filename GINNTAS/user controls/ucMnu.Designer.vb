<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMnu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMnu))
        Me.lblMenuText = New System.Windows.Forms.Label()
        Me.picMnuBorder = New System.Windows.Forms.PictureBox()
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenuText
        '
        Me.lblMenuText.AutoSize = True
        Me.lblMenuText.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMenuText.Location = New System.Drawing.Point(26, 114)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(93, 15)
        Me.lblMenuText.TabIndex = 0
        Me.lblMenuText.Text = "Default Menu"
        '
        'picMnuBorder
        '
        Me.picMnuBorder.BackColor = System.Drawing.Color.Transparent
        Me.picMnuBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMnuBorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMnuBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMnuBorder.Image = CType(resources.GetObject("picMnuBorder.Image"), System.Drawing.Image)
        Me.picMnuBorder.Location = New System.Drawing.Point(0, 0)
        Me.picMnuBorder.Name = "picMnuBorder"
        Me.picMnuBorder.Padding = New System.Windows.Forms.Padding(15, 12, 15, 32)
        Me.picMnuBorder.Size = New System.Drawing.Size(136, 136)
        Me.picMnuBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMnuBorder.TabIndex = 1
        Me.picMnuBorder.TabStop = False
        '
        'ucMnu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblMenuText)
        Me.Controls.Add(Me.picMnuBorder)
        Me.Name = "ucMnu"
        Me.Size = New System.Drawing.Size(136, 136)
        CType(Me.picMnuBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMenuText As System.Windows.Forms.Label
    Friend WithEvents picMnuBorder As System.Windows.Forms.PictureBox
End Class
