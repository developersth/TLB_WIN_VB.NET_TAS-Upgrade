<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.gpMnuType2 = New System.Windows.Forms.GroupBox()
        Me.UcCancel1 = New GINNTAS.ucCancel()
        Me.UcSave1 = New GINNTAS.ucSave()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gpFillForm = New System.Windows.Forms.GroupBox()
        Me.txt_Created_By = New System.Windows.Forms.TextBox()
        Me.txt_Created_Date = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Update_By = New System.Windows.Forms.TextBox()
        Me.txt_Update_Date = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Driver_Name = New System.Windows.Forms.TextBox()
        Me.txt_Customer_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_Ena_True = New System.Windows.Forms.RadioButton()
        Me.rb_Ena_False = New System.Windows.Forms.RadioButton()
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpMnuType2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gpFillForm.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.gpMnuType2.Location = New System.Drawing.Point(292, 154)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 219)
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
        Me.gpFillForm.Controls.Add(Me.txt_Created_By)
        Me.gpFillForm.Controls.Add(Me.txt_Created_Date)
        Me.gpFillForm.Controls.Add(Me.Label10)
        Me.gpFillForm.Controls.Add(Me.Label9)
        Me.gpFillForm.Controls.Add(Me.Label6)
        Me.gpFillForm.Controls.Add(Me.Label4)
        Me.gpFillForm.Controls.Add(Me.txt_Address)
        Me.gpFillForm.Controls.Add(Me.Label11)
        Me.gpFillForm.Controls.Add(Me.txt_Update_By)
        Me.gpFillForm.Controls.Add(Me.txt_Update_Date)
        Me.gpFillForm.Controls.Add(Me.Label12)
        Me.gpFillForm.Controls.Add(Me.txt_Driver_Name)
        Me.gpFillForm.Controls.Add(Me.txt_Customer_ID)
        Me.gpFillForm.Controls.Add(Me.Label3)
        Me.gpFillForm.Controls.Add(Me.Label1)
        Me.gpFillForm.Controls.Add(Me.GroupBox3)
        Me.gpFillForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpFillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpFillForm.Location = New System.Drawing.Point(10, 20)
        Me.gpFillForm.Name = "gpFillForm"
        Me.gpFillForm.Padding = New System.Windows.Forms.Padding(10)
        Me.gpFillForm.Size = New System.Drawing.Size(489, 523)
        Me.gpFillForm.TabIndex = 21
        Me.gpFillForm.TabStop = False
        Me.gpFillForm.Text = "Fill Form"
        '
        'txt_Created_By
        '
        Me.txt_Created_By.Enabled = False
        Me.txt_Created_By.Location = New System.Drawing.Point(120, 176)
        Me.txt_Created_By.Name = "txt_Created_By"
        Me.txt_Created_By.Size = New System.Drawing.Size(229, 20)
        Me.txt_Created_By.TabIndex = 151
        '
        'txt_Created_Date
        '
        Me.txt_Created_Date.Enabled = False
        Me.txt_Created_Date.Location = New System.Drawing.Point(120, 150)
        Me.txt_Created_Date.Name = "txt_Created_Date"
        Me.txt_Created_Date.Size = New System.Drawing.Size(229, 20)
        Me.txt_Created_Date.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 15)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Created By"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Created Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Enable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Address.Location = New System.Drawing.Point(120, 78)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(366, 20)
        Me.txt_Address.TabIndex = 138
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(15, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Update Date"
        '
        'txt_Update_By
        '
        Me.txt_Update_By.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Update_By.Enabled = False
        Me.txt_Update_By.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Update_By.Location = New System.Drawing.Point(120, 230)
        Me.txt_Update_By.Name = "txt_Update_By"
        Me.txt_Update_By.Size = New System.Drawing.Size(229, 20)
        Me.txt_Update_By.TabIndex = 136
        '
        'txt_Update_Date
        '
        Me.txt_Update_Date.Enabled = False
        Me.txt_Update_Date.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Update_Date.Location = New System.Drawing.Point(120, 204)
        Me.txt_Update_Date.Name = "txt_Update_Date"
        Me.txt_Update_Date.Size = New System.Drawing.Size(229, 20)
        Me.txt_Update_Date.TabIndex = 135
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "Update By"
        '
        'txt_Driver_Name
        '
        Me.txt_Driver_Name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Driver_Name.Location = New System.Drawing.Point(120, 52)
        Me.txt_Driver_Name.Name = "txt_Driver_Name"
        Me.txt_Driver_Name.Size = New System.Drawing.Size(366, 20)
        Me.txt_Driver_Name.TabIndex = 131
        '
        'txt_Customer_ID
        '
        Me.txt_Customer_ID.Location = New System.Drawing.Point(120, 26)
        Me.txt_Customer_ID.Name = "txt_Customer_ID"
        Me.txt_Customer_ID.Size = New System.Drawing.Size(229, 20)
        Me.txt_Customer_ID.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Customer ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_Ena_True)
        Me.GroupBox3.Controls.Add(Me.rb_Ena_False)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(120, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 40)
        Me.GroupBox3.TabIndex = 152
        Me.GroupBox3.TabStop = False
        '
        'rb_Ena_True
        '
        Me.rb_Ena_True.AutoSize = True
        Me.rb_Ena_True.Checked = True
        Me.rb_Ena_True.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rb_Ena_True.ForeColor = System.Drawing.Color.Black
        Me.rb_Ena_True.Location = New System.Drawing.Point(21, 15)
        Me.rb_Ena_True.Name = "rb_Ena_True"
        Me.rb_Ena_True.Size = New System.Drawing.Size(56, 19)
        Me.rb_Ena_True.TabIndex = 26
        Me.rb_Ena_True.TabStop = True
        Me.rb_Ena_True.Text = "ใช้งาน"
        Me.rb_Ena_True.UseVisualStyleBackColor = True
        '
        'rb_Ena_False
        '
        Me.rb_Ena_False.AutoSize = True
        Me.rb_Ena_False.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rb_Ena_False.ForeColor = System.Drawing.Color.Black
        Me.rb_Ena_False.Location = New System.Drawing.Point(128, 15)
        Me.rb_Ena_False.Name = "rb_Ena_False"
        Me.rb_Ena_False.Size = New System.Drawing.Size(69, 19)
        Me.rb_Ena_False.TabIndex = 25
        Me.rb_Ena_False.Text = "ไม่ใช้งาน"
        Me.rb_Ena_False.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column6, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(10, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 518)
        Me.DataGridView1.TabIndex = 22
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
        Me.gpMnuType1.Location = New System.Drawing.Point(18, 153)
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
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Customer ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Address"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "สถานะ"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 63
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Created Date"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 95
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Created By"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 84
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Update Date"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 93
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "Update By"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 82
        '
        'frmCustomer
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
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gpMnuType2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gpFillForm.ResumeLayout(False)
        Me.gpFillForm.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents gpMnuType1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcReflesh1 As GINNTAS.ucReflesh
    Friend WithEvents UcSearch1 As GINNTAS.ucSearch
    Friend WithEvents UcDelete1 As GINNTAS.ucDelete
    Friend WithEvents UcEdit1 As GINNTAS.ucEdit
    Friend WithEvents UcInsert1 As GINNTAS.ucInsert
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gpFillForm As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Created_By As System.Windows.Forms.TextBox
    Friend WithEvents txt_Created_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Update_By As System.Windows.Forms.TextBox
    Friend WithEvents txt_Update_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Driver_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Customer_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Ena_True As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Ena_False As System.Windows.Forms.RadioButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
