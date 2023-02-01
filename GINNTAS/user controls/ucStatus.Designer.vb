<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStatus))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.picDB = New System.Windows.Forms.PictureBox()
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoEllipsis = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(69, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(367, 35)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User Name :  User Group : "
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoEllipsis = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(154, 28)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(248, 19)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Date Time"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picDB
        '
        Me.picDB.BackgroundImage = CType(resources.GetObject("picDB.BackgroundImage"), System.Drawing.Image)
        Me.picDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDB.Location = New System.Drawing.Point(417, 19)
        Me.picDB.Name = "picDB"
        Me.picDB.Size = New System.Drawing.Size(41, 35)
        Me.picDB.TabIndex = 2
        Me.picDB.TabStop = False
        '
        'ucStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.picDB)
        Me.Controls.Add(Me.lblUser)
        Me.Name = "ucStatus"
        Me.Size = New System.Drawing.Size(460, 54)
        Me.Tag = ""
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents picDB As System.Windows.Forms.PictureBox

End Class
