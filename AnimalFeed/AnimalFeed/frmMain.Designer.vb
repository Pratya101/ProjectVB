<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.สนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.อาหารหมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขายToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addemp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกจากระบบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.สนคาToolStripMenuItem, Me.ขายToolStripMenuItem, Me.addemp, Me.ออกจากระบบToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'สนคาToolStripMenuItem
        '
        Me.สนคาToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.อาหารหมToolStripMenuItem})
        Me.สนคาToolStripMenuItem.Name = "สนคาToolStripMenuItem"
        Me.สนคาToolStripMenuItem.Size = New System.Drawing.Size(67, 34)
        Me.สนคาToolStripMenuItem.Text = "สินค้า"
        '
        'อาหารหมToolStripMenuItem
        '
        Me.อาหารหมToolStripMenuItem.Name = "อาหารหมToolStripMenuItem"
        Me.อาหารหมToolStripMenuItem.Size = New System.Drawing.Size(115, 34)
        Me.อาหารหมToolStripMenuItem.Text = "เพิ่ม"
        '
        'ขายToolStripMenuItem
        '
        Me.ขายToolStripMenuItem.Name = "ขายToolStripMenuItem"
        Me.ขายToolStripMenuItem.Size = New System.Drawing.Size(55, 34)
        Me.ขายToolStripMenuItem.Text = "ขาย"
        '
        'addemp
        '
        Me.addemp.Name = "addemp"
        Me.addemp.Size = New System.Drawing.Size(119, 34)
        Me.addemp.Text = "เพิ่มพนักงาน"
        '
        'ออกจากระบบToolStripMenuItem
        '
        Me.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem"
        Me.ออกจากระบบToolStripMenuItem.Size = New System.Drawing.Size(130, 34)
        Me.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 487)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เมนูหลัก"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents สนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents อาหารหมToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ขายToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ออกจากระบบToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
