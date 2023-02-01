<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTank
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
        Me.oil = New System.Windows.Forms.Label()
        Me.adviceBG = New System.Windows.Forms.Label()
        Me.adviceFrame = New System.Windows.Forms.Label()
        Me.capacityBG = New System.Windows.Forms.Label()
        Me.capacityFrame = New System.Windows.Forms.Label()
        Me.LineHH = New System.Windows.Forms.Label()
        Me.LineH = New System.Windows.Forms.Label()
        Me.LineL = New System.Windows.Forms.Label()
        Me.LineLL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'oil
        '
        Me.oil.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.oil.ForeColor = System.Drawing.Color.Red
        Me.oil.Location = New System.Drawing.Point(84, 101)
        Me.oil.Name = "oil"
        Me.oil.Size = New System.Drawing.Size(49, 66)
        Me.oil.TabIndex = 52
        '
        'adviceBG
        '
        Me.adviceBG.BackColor = System.Drawing.Color.White
        Me.adviceBG.ForeColor = System.Drawing.Color.Red
        Me.adviceBG.Location = New System.Drawing.Point(84, 56)
        Me.adviceBG.Name = "adviceBG"
        Me.adviceBG.Size = New System.Drawing.Size(49, 108)
        Me.adviceBG.TabIndex = 51
        '
        'adviceFrame
        '
        Me.adviceFrame.BackColor = System.Drawing.Color.Lime
        Me.adviceFrame.ForeColor = System.Drawing.Color.Lime
        Me.adviceFrame.Location = New System.Drawing.Point(81, 53)
        Me.adviceFrame.Name = "adviceFrame"
        Me.adviceFrame.Size = New System.Drawing.Size(55, 116)
        Me.adviceFrame.TabIndex = 50
        Me.adviceFrame.Text = "56.7"
        '
        'capacityBG
        '
        Me.capacityBG.BackColor = System.Drawing.Color.White
        Me.capacityBG.ForeColor = System.Drawing.Color.Red
        Me.capacityBG.Location = New System.Drawing.Point(81, 15)
        Me.capacityBG.Name = "capacityBG"
        Me.capacityBG.Size = New System.Drawing.Size(55, 154)
        Me.capacityBG.TabIndex = 49
        '
        'capacityFrame
        '
        Me.capacityFrame.BackColor = System.Drawing.Color.MediumBlue
        Me.capacityFrame.ForeColor = System.Drawing.Color.Lime
        Me.capacityFrame.Location = New System.Drawing.Point(78, 12)
        Me.capacityFrame.Name = "capacityFrame"
        Me.capacityFrame.Size = New System.Drawing.Size(61, 159)
        Me.capacityFrame.TabIndex = 48
        '
        'LineHH
        '
        Me.LineHH.BackColor = System.Drawing.Color.Red
        Me.LineHH.ForeColor = System.Drawing.Color.Red
        Me.LineHH.Location = New System.Drawing.Point(74, 15)
        Me.LineHH.Name = "LineHH"
        Me.LineHH.Size = New System.Drawing.Size(62, 1)
        Me.LineHH.TabIndex = 54
        '
        'LineH
        '
        Me.LineH.BackColor = System.Drawing.Color.Red
        Me.LineH.ForeColor = System.Drawing.Color.Red
        Me.LineH.Location = New System.Drawing.Point(62, 25)
        Me.LineH.Name = "LineH"
        Me.LineH.Size = New System.Drawing.Size(62, 1)
        Me.LineH.TabIndex = 55
        '
        'LineL
        '
        Me.LineL.BackColor = System.Drawing.Color.Red
        Me.LineL.ForeColor = System.Drawing.Color.Red
        Me.LineL.Location = New System.Drawing.Point(62, 140)
        Me.LineL.Name = "LineL"
        Me.LineL.Size = New System.Drawing.Size(62, 1)
        Me.LineL.TabIndex = 56
        '
        'LineLL
        '
        Me.LineLL.BackColor = System.Drawing.Color.Red
        Me.LineLL.ForeColor = System.Drawing.Color.Red
        Me.LineLL.Location = New System.Drawing.Point(81, 154)
        Me.LineLL.Name = "LineLL"
        Me.LineLL.Size = New System.Drawing.Size(62, 1)
        Me.LineLL.TabIndex = 57
        '
        'ucTank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.LineLL)
        Me.Controls.Add(Me.LineL)
        Me.Controls.Add(Me.LineH)
        Me.Controls.Add(Me.LineHH)
        Me.Controls.Add(Me.oil)
        Me.Controls.Add(Me.adviceBG)
        Me.Controls.Add(Me.adviceFrame)
        Me.Controls.Add(Me.capacityBG)
        Me.Controls.Add(Me.capacityFrame)
        Me.Name = "ucTank"
        Me.Size = New System.Drawing.Size(145, 176)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents oil As System.Windows.Forms.Label
    Friend WithEvents adviceBG As System.Windows.Forms.Label
    Friend WithEvents adviceFrame As System.Windows.Forms.Label
    Friend WithEvents capacityBG As System.Windows.Forms.Label
    Friend WithEvents capacityFrame As System.Windows.Forms.Label
    Friend WithEvents LineHH As System.Windows.Forms.Label
    Friend WithEvents LineH As System.Windows.Forms.Label
    Friend WithEvents LineL As System.Windows.Forms.Label
    Friend WithEvents LineLL As System.Windows.Forms.Label

End Class
