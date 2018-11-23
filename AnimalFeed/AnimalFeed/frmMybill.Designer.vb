<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMybill
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
        Me.Crvmyreport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crvmyreport
        '
        Me.Crvmyreport.ActiveViewIndex = -1
        Me.Crvmyreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crvmyreport.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crvmyreport.DisplayBackgroundEdge = False
        Me.Crvmyreport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Crvmyreport.Location = New System.Drawing.Point(271, -3)
        Me.Crvmyreport.Name = "Crvmyreport"
        Me.Crvmyreport.Size = New System.Drawing.Size(900, 800)
        Me.Crvmyreport.TabIndex = 0
        Me.Crvmyreport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmMybill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1404, 903)
        Me.Controls.Add(Me.Crvmyreport)
        Me.Name = "frmMybill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ใบเสร็จ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crvmyreport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
