<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenutxt_Main
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
        Me.lblMenuText = New System.Windows.Forms.Label()
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblMenuText
        '
        Me.lblMenuText.AutoEllipsis = True
        Me.lblMenuText.AutoSize = True
        Me.lblMenuText.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMenuText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenuText.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMenuText.Location = New System.Drawing.Point(123, 25)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(183, 36)
        Me.lblMenuText.TabIndex = 8
        Me.lblMenuText.Text = "Default Menu"
        Me.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucMenutxt_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblMenuText)
        Me.Controls.Add(Me.picIconMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximumSize = New System.Drawing.Size(550, 91)
        Me.Name = "ucMenutxt_Main"
        Me.Size = New System.Drawing.Size(550, 91)
        CType(Me.picIconMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picIconMenu As System.Windows.Forms.PictureBox
    Friend WithEvents lblMenuText As System.Windows.Forms.Label

End Class
