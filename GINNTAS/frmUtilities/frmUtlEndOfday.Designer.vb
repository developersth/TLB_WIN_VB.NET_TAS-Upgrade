<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlEndOfday
    Inherits MetroFramework.Forms.MetroForm

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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.UcMenucmdForceEOD = New GINNTAS.ucMenutxtSub()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(173, 63)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(90, 26)
        Me.DateTimePicker2.TabIndex = 1
        '
        'UcMenucmdForceEOD
        '
        Me.UcMenucmdForceEOD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenucmdForceEOD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenucmdForceEOD.BackColor = System.Drawing.Color.Transparent
        Me.UcMenucmdForceEOD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenucmdForceEOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenucmdForceEOD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenucmdForceEOD.Location = New System.Drawing.Point(47, 109)
        Me.UcMenucmdForceEOD.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenucmdForceEOD.MenuAuthorizeID = CType(0, Long)
        Me.UcMenucmdForceEOD.MenuCorners = 6
        Me.UcMenucmdForceEOD.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenucmdForceEOD.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenucmdForceEOD.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenucmdForceEOD.MenuIcon = Nothing
        Me.UcMenucmdForceEOD.MenuIconSize = New System.Drawing.Size(12, 19)
        Me.UcMenucmdForceEOD.MenuScreenID = CType(0, Long)
        Me.UcMenucmdForceEOD.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenucmdForceEOD.MenuText = "End Of Day"
        Me.UcMenucmdForceEOD.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenucmdForceEOD.MenuTextMargin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.UcMenucmdForceEOD.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenucmdForceEOD.MenuTextShadowShow = False
        Me.UcMenucmdForceEOD.Name = "UcMenucmdForceEOD"
        Me.UcMenucmdForceEOD.Size = New System.Drawing.Size(179, 38)
        Me.UcMenucmdForceEOD.TabIndex = 41
        '
        'frmUtlEndOfday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 160)
        Me.Controls.Add(Me.UcMenucmdForceEOD)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtlEndOfday"
        Me.Text = "EndOfday"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents UcMenucmdForceEOD As GINNTAS.ucMenutxtSub
End Class
