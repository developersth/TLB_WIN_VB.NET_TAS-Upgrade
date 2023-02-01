<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmType1))
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.gpMnuType2 = New System.Windows.Forms.GroupBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gpFillForm = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UcMinimize1 = New GINNTAS.ucMinimize()
        Me.UcClose1 = New GINNTAS.ucClose()
        Me.UcStatus1 = New GINNTAS.ucStatus()
        Me.gpMnuType1 = New System.Windows.Forms.GroupBox()
        Me.UcReflesh1 = New GINNTAS.ucReflesh()
        Me.UcSearch1 = New GINNTAS.ucSearch()
        Me.UcDelete1 = New GINNTAS.ucDelete()
        Me.UcEdit1 = New GINNTAS.ucEdit()
        Me.UcInsert1 = New GINNTAS.ucInsert()
        Me.gpMnuType2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpMnuType1.SuspendLayout()
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
        'gpMnuType2
        '
        Me.gpMnuType2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpMnuType2.BackColor = System.Drawing.Color.Transparent
        Me.gpMnuType2.Controls.Add(Me.UcCancel1)
        Me.gpMnuType2.Controls.Add(Me.UcSave1)
        Me.gpMnuType2.Location = New System.Drawing.Point(883, 137)
        Me.gpMnuType2.Name = "gpMnuType2"
        Me.gpMnuType2.Size = New System.Drawing.Size(116, 79)
        Me.gpMnuType2.TabIndex = 15
        Me.gpMnuType2.TabStop = False
        Me.gpMnuType2.Visible = False
        '
        'UcCancel1
        '
        Me.UcCancel1.BackColor = System.Drawing.Color.Transparent
        Me.UcCancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcCancel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcCancel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcCancel1.Location = New System.Drawing.Point(54, 16)
        Me.UcCancel1.Name = "UcCancel1"
        Me.UcCancel1.Size = New System.Drawing.Size(51, 60)
        Me.UcCancel1.TabIndex = 1
        '
        'UcSave1
        '
        Me.UcSave1.BackColor = System.Drawing.Color.Transparent
        Me.UcSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcSave1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcSave1.Location = New System.Drawing.Point(3, 16)
        Me.UcSave1.MenuAuthorizeID = Nothing
        Me.UcSave1.MenuScreenID = CType(0, Long)
        Me.UcSave1.Name = "UcSave1"
        Me.UcSave1.Size = New System.Drawing.Size(51, 60)
        Me.UcSave1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 205)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel1.Controls.Add(Me.gpFillForm)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 25, 15, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(998, 553)
        Me.SplitContainer1.SplitterDistance = 509
        Me.SplitContainer1.SplitterWidth = 20
        Me.SplitContainer1.TabIndex = 21
        '
        'gpFillForm
        '
        Me.gpFillForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gpFillForm.BackColor = System.Drawing.Color.Transparent
        Me.gpFillForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpFillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpFillForm.Location = New System.Drawing.Point(10, 20)
        Me.gpFillForm.Name = "gpFillForm"
        Me.gpFillForm.Padding = New System.Windows.Forms.Padding(10)
        Me.gpFillForm.Size = New System.Drawing.Size(489, 523)
        Me.gpFillForm.TabIndex = 20
        Me.gpFillForm.TabStop = False
        Me.gpFillForm.Text = "Fill Form"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(10, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 518)
        Me.DataGridView1.TabIndex = 21
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
        'gpMnuType1
        '
        Me.gpMnuType1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpMnuType1.BackColor = System.Drawing.Color.Transparent
        Me.gpMnuType1.Controls.Add(Me.UcReflesh1)
        Me.gpMnuType1.Controls.Add(Me.UcSearch1)
        Me.gpMnuType1.Controls.Add(Me.UcDelete1)
        Me.gpMnuType1.Controls.Add(Me.UcEdit1)
        Me.gpMnuType1.Controls.Add(Me.UcInsert1)
        Me.gpMnuType1.Location = New System.Drawing.Point(606, 137)
        Me.gpMnuType1.Name = "gpMnuType1"
        Me.gpMnuType1.Size = New System.Drawing.Size(267, 79)
        Me.gpMnuType1.TabIndex = 22
        Me.gpMnuType1.TabStop = False
        '
        'UcReflesh1
        '
        Me.UcReflesh1.BackColor = System.Drawing.Color.Transparent
        Me.UcReflesh1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcReflesh1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcReflesh1.Location = New System.Drawing.Point(207, 16)
        Me.UcReflesh1.Name = "UcReflesh1"
        Me.UcReflesh1.Size = New System.Drawing.Size(51, 60)
        Me.UcReflesh1.TabIndex = 16
        '
        'UcSearch1
        '
        Me.UcSearch1.BackColor = System.Drawing.Color.Transparent
        Me.UcSearch1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcSearch1.Location = New System.Drawing.Point(156, 16)
        Me.UcSearch1.Name = "UcSearch1"
        Me.UcSearch1.Size = New System.Drawing.Size(51, 60)
        Me.UcSearch1.TabIndex = 15
        '
        'UcDelete1
        '
        Me.UcDelete1.BackColor = System.Drawing.Color.Transparent
        Me.UcDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcDelete1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcDelete1.Location = New System.Drawing.Point(105, 16)
        Me.UcDelete1.MenuAuthorizeID = Nothing
        Me.UcDelete1.MenuScreenID = CType(0, Long)
        Me.UcDelete1.Name = "UcDelete1"
        Me.UcDelete1.Size = New System.Drawing.Size(51, 60)
        Me.UcDelete1.TabIndex = 2
        '
        'UcEdit1
        '
        Me.UcEdit1.BackColor = System.Drawing.Color.Transparent
        Me.UcEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcEdit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcEdit1.Location = New System.Drawing.Point(54, 16)
        Me.UcEdit1.MenuAuthorizeID = Nothing
        Me.UcEdit1.MenuScreenID = CType(0, Long)
        Me.UcEdit1.Name = "UcEdit1"
        Me.UcEdit1.Size = New System.Drawing.Size(51, 60)
        Me.UcEdit1.TabIndex = 1
        '
        'UcInsert1
        '
        Me.UcInsert1.BackColor = System.Drawing.Color.Transparent
        Me.UcInsert1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcInsert1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcInsert1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcInsert1.Location = New System.Drawing.Point(3, 16)
        Me.UcInsert1.MenuAuthorizeID = Nothing
        Me.UcInsert1.MenuScreenID = CType(0, Long)
        Me.UcInsert1.Name = "UcInsert1"
        Me.UcInsert1.Size = New System.Drawing.Size(51, 60)
        Me.UcInsert1.TabIndex = 0
        '
        'frmType1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.gpMnuType1)
        Me.Controls.Add(Me.gpMnuType2)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.UcMinimize1)
        Me.Controls.Add(Me.UcClose1)
        Me.Controls.Add(Me.UcStatus1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmType1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gpMnuType2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpMnuType1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcClose1 As GINNTAS.ucClose
    Friend WithEvents UcMinimize1 As GINNTAS.ucMinimize
    Friend WithEvents lblTitleName As System.Windows.Forms.Label
    Friend WithEvents UcStatus1 As GINNTAS.ucStatus
    Friend WithEvents gpMnuType2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcCancel1 As GINNTAS.ucCancel
    Friend WithEvents UcSave1 As GINNTAS.ucSave
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gpFillForm As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gpMnuType1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcReflesh1 As GINNTAS.ucReflesh
    Friend WithEvents UcSearch1 As GINNTAS.ucSearch
    Friend WithEvents UcDelete1 As GINNTAS.ucDelete
    Friend WithEvents UcEdit1 As GINNTAS.ucEdit
    Friend WithEvents UcInsert1 As GINNTAS.ucInsert

End Class
