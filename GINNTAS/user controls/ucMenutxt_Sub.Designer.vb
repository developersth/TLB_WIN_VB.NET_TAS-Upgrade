<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenutxt_Sub
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenuText
        '
        Me.lblMenuText.AutoEllipsis = True
        Me.lblMenuText.AutoSize = True
        Me.lblMenuText.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenuText.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenuText.ForeColor = System.Drawing.Color.Black
        Me.lblMenuText.Location = New System.Drawing.Point(18, 15)
        Me.lblMenuText.Name = "lblMenuText"
        Me.lblMenuText.Size = New System.Drawing.Size(151, 29)
        Me.lblMenuText.TabIndex = 8
        Me.lblMenuText.Text = "Default Menu"
        Me.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ucMenutxt_Sub
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMenuText)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximumSize = New System.Drawing.Size(460, 56)
        Me.Name = "ucMenutxt_Sub"
        Me.Size = New System.Drawing.Size(182, 56)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMenuText As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
