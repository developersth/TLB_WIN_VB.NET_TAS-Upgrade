<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFooter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucFooter))
        Me.tScanTime = New System.Windows.Forms.Timer(Me.components)
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.txtAlarmMsg = New System.Windows.Forms.TextBox()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.picDB = New System.Windows.Forms.PictureBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tScanTime
        '
        Me.tScanTime.Interval = 3000
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackgroundImage = CType(resources.GetObject("tableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.tableLayoutPanel1.ColumnCount = 8
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel4, 4, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel5, 3, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel6, 6, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel7, 5, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.Panel8, 7, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(966, 40)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.lblServer)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(169, 34)
        Me.panel1.TabIndex = 0
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.Location = New System.Drawing.Point(0, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(82, 20)
        Me.lblServer.TabIndex = 0
        Me.lblServer.Text = "Computer"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.btnAlarm)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(178, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(73, 34)
        Me.panel2.TabIndex = 1
        '
        'btnAlarm
        '
        Me.btnAlarm.BackColor = System.Drawing.Color.Red
        Me.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlarm.ForeColor = System.Drawing.Color.White
        Me.btnAlarm.Location = New System.Drawing.Point(0, 0)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(73, 34)
        Me.btnAlarm.TabIndex = 0
        Me.btnAlarm.Text = "Alarm"
        Me.btnAlarm.UseVisualStyleBackColor = False
        '
        'panel3
        '
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(257, 3)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(3, 34)
        Me.panel3.TabIndex = 2
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.Transparent
        Me.panel4.Controls.Add(Me.lblDateTime)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(669, 3)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(162, 34)
        Me.panel4.TabIndex = 3
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(0, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(162, 20)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "20-12-2016 12:00:00"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.txtAlarmMsg)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel5.Location = New System.Drawing.Point(266, 3)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(397, 34)
        Me.panel5.TabIndex = 4
        '
        'txtAlarmMsg
        '
        Me.txtAlarmMsg.BackColor = System.Drawing.Color.White
        Me.txtAlarmMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlarmMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmMsg.Location = New System.Drawing.Point(0, 0)
        Me.txtAlarmMsg.Name = "txtAlarmMsg"
        Me.txtAlarmMsg.ReadOnly = True
        Me.txtAlarmMsg.Size = New System.Drawing.Size(397, 31)
        Me.txtAlarmMsg.TabIndex = 0
        '
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.Color.Transparent
        Me.panel6.Controls.Add(Me.lblUser)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel6.Location = New System.Drawing.Point(842, 3)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(71, 34)
        Me.panel6.TabIndex = 5
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(0, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(45, 20)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.Crimson
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel7.Location = New System.Drawing.Point(837, 3)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1, 34)
        Me.panel7.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.picDB)
        Me.Panel8.Location = New System.Drawing.Point(919, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(44, 24)
        Me.Panel8.TabIndex = 7
        '
        'picDB
        '
        Me.picDB.BackgroundImage = CType(resources.GetObject("picDB.BackgroundImage"), System.Drawing.Image)
        Me.picDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDB.Location = New System.Drawing.Point(0, 0)
        Me.picDB.Name = "picDB"
        Me.picDB.Size = New System.Drawing.Size(44, 24)
        Me.picDB.TabIndex = 3
        Me.picDB.TabStop = False
        '
        'ucFooter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "ucFooter"
        Me.Size = New System.Drawing.Size(966, 40)
        Me.Tag = ""
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents btnAlarm As System.Windows.Forms.Button
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents lblServer As System.Windows.Forms.Label
    Private WithEvents panel5 As System.Windows.Forms.Panel
    Private WithEvents txtAlarmMsg As System.Windows.Forms.TextBox
    Private WithEvents panel6 As System.Windows.Forms.Panel
    Private WithEvents panel7 As System.Windows.Forms.Panel
    Friend WithEvents tScanTime As System.Windows.Forms.Timer
    Private WithEvents lblUser As System.Windows.Forms.Label
    Private WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents picDB As System.Windows.Forms.PictureBox

End Class
