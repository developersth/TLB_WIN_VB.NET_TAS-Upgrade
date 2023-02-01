<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMIProcessFlowTLB
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMMIProcessFlowTLB))
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdBack = New System.Windows.Forms.Button()
        Me.CmdNext = New System.Windows.Forms.Button()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.pnlShowData = New System.Windows.Forms.Panel()
        Me.UcFlowLoadingTLB1 = New GINNTAS.UcFlowLoadingTLB()
        Me.Time_Scan = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlShowData.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1365, 130)
        Me.UcHeader1.TabIndex = 170
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(1363, 41)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 902)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1365, 43)
        Me.Panel3.TabIndex = 169
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.CmdBack)
        Me.Panel4.Controls.Add(Me.CmdNext)
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 130)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1365, 49)
        Me.Panel4.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(524, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Gantry "
        '
        'CmdBack
        '
        Me.CmdBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdBack.Location = New System.Drawing.Point(614, 9)
        Me.CmdBack.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdBack.Name = "CmdBack"
        Me.CmdBack.Size = New System.Drawing.Size(63, 28)
        Me.CmdBack.TabIndex = 80
        Me.CmdBack.Text = "1"
        Me.CmdBack.UseVisualStyleBackColor = True
        '
        'CmdNext
        '
        Me.CmdNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdNext.Location = New System.Drawing.Point(686, 10)
        Me.CmdNext.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(63, 28)
        Me.CmdNext.TabIndex = 79
        Me.CmdNext.Text = "2"
        Me.CmdNext.UseVisualStyleBackColor = True
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(1191, 0)
        Me.UcBack1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(169, 43)
        Me.UcBack1.TabIndex = 2
        '
        'pnlShowData
        '
        Me.pnlShowData.AutoScroll = True
        Me.pnlShowData.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlShowData.Controls.Add(Me.UcFlowLoadingTLB1)
        Me.pnlShowData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlShowData.Location = New System.Drawing.Point(0, 179)
        Me.pnlShowData.Name = "pnlShowData"
        Me.pnlShowData.Size = New System.Drawing.Size(1365, 723)
        Me.pnlShowData.TabIndex = 172
        '
        'UcFlowLoadingTLB1
        '
        Me.UcFlowLoadingTLB1.Location = New System.Drawing.Point(12, 7)
        Me.UcFlowLoadingTLB1.Name = "UcFlowLoadingTLB1"
        Me.UcFlowLoadingTLB1.Size = New System.Drawing.Size(1871, 235)
        Me.UcFlowLoadingTLB1.TabIndex = 0
        Me.UcFlowLoadingTLB1.Visible = False
        '
        'Time_Scan
        '
        Me.Time_Scan.Interval = 1000
        '
        'frmMMIProcessFlowTLB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 945)
        Me.Controls.Add(Me.pnlShowData)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UcHeader1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMMIProcessFlowTLB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlShowData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcBack1 As GINNTAS.ucBack
    Friend WithEvents pnlShowData As Panel
    Friend WithEvents UcFlowLoadingTLB1 As UcFlowLoadingTLB
    Friend WithEvents CmdBack As Button
    Friend WithEvents CmdNext As Button
    Friend WithEvents Time_Scan As Timer
    Friend WithEvents Label1 As Label
End Class
