<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporary))
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.UcMinimize1 = New GINNTAS.ucMinimize()
        Me.UcClose1 = New GINNTAS.ucClose()
        Me.UcStatus1 = New GINNTAS.ucStatus()
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
        'UcStatus1
        '
        Me.UcStatus1.BackColor = System.Drawing.Color.Transparent
        Me.UcStatus1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcStatus1.Location = New System.Drawing.Point(0, 0)
        Me.UcStatus1.Name = "UcStatus1"
        Me.UcStatus1.Size = New System.Drawing.Size(1024, 128)
        Me.UcStatus1.TabIndex = 10
        Me.UcStatus1.TabStop = False
        Me.UcStatus1.Tag = ""
        '
        'frmTemporary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.UcMinimize1)
        Me.Controls.Add(Me.UcClose1)
        Me.Controls.Add(Me.UcStatus1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmTemporary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcClose1 As GINNTAS.ucClose
    Friend WithEvents UcMinimize1 As GINNTAS.ucMinimize
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents UcStatus1 As GINNTAS.ucStatus

End Class
