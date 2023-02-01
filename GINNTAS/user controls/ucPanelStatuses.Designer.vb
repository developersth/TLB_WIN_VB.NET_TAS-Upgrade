<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPanelStatuses
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
        Me.txtAlarmMsg = New System.Windows.Forms.TextBox()
        Me.tScanTime = New System.Windows.Forms.Timer(Me.components)
        Me.UcBtnAlarm = New GINNTAS.ucMnuText()
        Me.SuspendLayout()
        '
        'txtAlarmMsg
        '
        Me.txtAlarmMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlarmMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAlarmMsg.Location = New System.Drawing.Point(135, 1)
        Me.txtAlarmMsg.Name = "txtAlarmMsg"
        Me.txtAlarmMsg.Size = New System.Drawing.Size(713, 26)
        Me.txtAlarmMsg.TabIndex = 0
        '
        'tScanTime
        '
        '
        'UcBtnAlarm
        '
        Me.UcBtnAlarm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcBtnAlarm.BackColor = System.Drawing.Color.Transparent
        Me.UcBtnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBtnAlarm.Location = New System.Drawing.Point(27, -9)
        Me.UcBtnAlarm.MaximumSize = New System.Drawing.Size(310, 80)
        Me.UcBtnAlarm.MenuAuthorizeID = "0"
        Me.UcBtnAlarm.MenuFont = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcBtnAlarm.MenuForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UcBtnAlarm.MenuImage = Nothing
        Me.UcBtnAlarm.MenuScreenID = CType(0, Long)
        Me.UcBtnAlarm.MenuText = "Alarm"
        Me.UcBtnAlarm.MenuTextAlign = GINNTAS.ucMnuText._TextAlign.Left
        Me.UcBtnAlarm.MenuTextLocation = New System.Drawing.Point(14, 12)
        Me.UcBtnAlarm.Name = "UcBtnAlarm"
        Me.UcBtnAlarm.Padding = New System.Windows.Forms.Padding(3)
        Me.UcBtnAlarm.Size = New System.Drawing.Size(96, 48)
        Me.UcBtnAlarm.TabIndex = 127
        '
        'ucPanelStatuses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.UcBtnAlarm)
        Me.Controls.Add(Me.txtAlarmMsg)
        Me.Name = "ucPanelStatuses"
        Me.Size = New System.Drawing.Size(839, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAlarmMsg As System.Windows.Forms.TextBox
    Friend WithEvents UcBtnAlarm As GINNTAS.ucMnuText
    Friend WithEvents tScanTime As System.Windows.Forms.Timer

End Class
