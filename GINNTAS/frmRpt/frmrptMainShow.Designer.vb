﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptMainShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrptMainShow))
        Me.CrysRPTViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrysRPTViewer
        '
        Me.CrysRPTViewer.ActiveViewIndex = -1
        Me.CrysRPTViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrysRPTViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrysRPTViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrysRPTViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrysRPTViewer.Name = "CrysRPTViewer"
        Me.CrysRPTViewer.Size = New System.Drawing.Size(800, 450)
        Me.CrysRPTViewer.TabIndex = 0
        Me.CrysRPTViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmrptMainShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrysRPTViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrptMainShow"
        Me.Text = "frmrptMainShow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrysRPTViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
