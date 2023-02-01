<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcProgressOil
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
        Me.lblOil = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.txtPrecentOil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'oil
        '
        Me.oil.BackColor = System.Drawing.Color.Yellow
        Me.oil.ForeColor = System.Drawing.Color.Red
        Me.oil.Location = New System.Drawing.Point(21, 117)
        Me.oil.Name = "oil"
        Me.oil.Size = New System.Drawing.Size(49, 72)
        Me.oil.TabIndex = 43
        '
        'adviceBG
        '
        Me.adviceBG.BackColor = System.Drawing.Color.White
        Me.adviceBG.ForeColor = System.Drawing.Color.Red
        Me.adviceBG.Location = New System.Drawing.Point(21, 72)
        Me.adviceBG.Name = "adviceBG"
        Me.adviceBG.Size = New System.Drawing.Size(49, 114)
        Me.adviceBG.TabIndex = 42
        '
        'adviceFrame
        '
        Me.adviceFrame.BackColor = System.Drawing.Color.Lime
        Me.adviceFrame.ForeColor = System.Drawing.Color.Lime
        Me.adviceFrame.Location = New System.Drawing.Point(18, 69)
        Me.adviceFrame.Name = "adviceFrame"
        Me.adviceFrame.Size = New System.Drawing.Size(55, 122)
        Me.adviceFrame.TabIndex = 41
        Me.adviceFrame.Text = "56.7"
        '
        'capacityBG
        '
        Me.capacityBG.BackColor = System.Drawing.Color.White
        Me.capacityBG.ForeColor = System.Drawing.Color.Red
        Me.capacityBG.Location = New System.Drawing.Point(18, 31)
        Me.capacityBG.Name = "capacityBG"
        Me.capacityBG.Size = New System.Drawing.Size(55, 160)
        Me.capacityBG.TabIndex = 40
        '
        'capacityFrame
        '
        Me.capacityFrame.BackColor = System.Drawing.Color.MediumBlue
        Me.capacityFrame.ForeColor = System.Drawing.Color.Lime
        Me.capacityFrame.Location = New System.Drawing.Point(15, 28)
        Me.capacityFrame.Name = "capacityFrame"
        Me.capacityFrame.Size = New System.Drawing.Size(61, 165)
        Me.capacityFrame.TabIndex = 39
        '
        'lblOil
        '
        Me.lblOil.AutoSize = True
        Me.lblOil.BackColor = System.Drawing.Color.Black
        Me.lblOil.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOil.ForeColor = System.Drawing.Color.Yellow
        Me.lblOil.Location = New System.Drawing.Point(86, 105)
        Me.lblOil.Name = "lblOil"
        Me.lblOil.Size = New System.Drawing.Size(62, 12)
        Me.lblOil.TabIndex = 46
        Me.lblOil.Text = "lblProgress"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.White
        Me.lblCapacity.Location = New System.Drawing.Point(83, 24)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(62, 12)
        Me.lblCapacity.TabIndex = 45
        Me.lblCapacity.Text = "lblCapacity"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.BackColor = System.Drawing.Color.Black
        Me.lblAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAdvice.ForeColor = System.Drawing.Color.Lime
        Me.lblAdvice.Location = New System.Drawing.Point(84, 56)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(74, 12)
        Me.lblAdvice.TabIndex = 44
        Me.lblAdvice.Text = "lblsumAdvice"
        '
        'txtPrecentOil
        '
        Me.txtPrecentOil.Enabled = False
        Me.txtPrecentOil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrecentOil.ForeColor = System.Drawing.Color.Red
        Me.txtPrecentOil.Location = New System.Drawing.Point(3, 3)
        Me.txtPrecentOil.Name = "txtPrecentOil"
        Me.txtPrecentOil.Size = New System.Drawing.Size(83, 20)
        Me.txtPrecentOil.TabIndex = 47
        Me.txtPrecentOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UcProgressOil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.txtPrecentOil)
        Me.Controls.Add(Me.lblOil)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.oil)
        Me.Controls.Add(Me.adviceBG)
        Me.Controls.Add(Me.adviceFrame)
        Me.Controls.Add(Me.capacityBG)
        Me.Controls.Add(Me.capacityFrame)
        Me.Name = "UcProgressOil"
        Me.Size = New System.Drawing.Size(148, 224)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oil As System.Windows.Forms.Label
    Friend WithEvents adviceBG As System.Windows.Forms.Label
    Friend WithEvents adviceFrame As System.Windows.Forms.Label
    Friend WithEvents capacityBG As System.Windows.Forms.Label
    Friend WithEvents capacityFrame As System.Windows.Forms.Label
    Friend WithEvents lblOil As System.Windows.Forms.Label
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents lblAdvice As System.Windows.Forms.Label
    Friend WithEvents txtPrecentOil As System.Windows.Forms.TextBox

End Class
