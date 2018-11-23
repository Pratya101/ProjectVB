<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(339, 78)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(48, 28)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(318, 149)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(78, 28)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(395, 82)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(292, 22)
        Me.txtUser.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(395, 153)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpassword.Size = New System.Drawing.Size(292, 22)
        Me.txtpassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OK.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(396, 233)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(125, 38)
        Me.OK.TabIndex = 4
        Me.OK.Text = "Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Red
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(534, 233)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(125, 38)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.AnimalFeed.My.Resources.Resources.logo_login
        Me.LogoPictureBox.Location = New System.Drawing.Point(23, 37)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(250, 251)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(720, 336)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
