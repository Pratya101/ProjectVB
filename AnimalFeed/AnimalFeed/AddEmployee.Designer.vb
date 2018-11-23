<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee))
        Me.DgvEmployee = New System.Windows.Forms.DataGridView()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpLname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtIDthai = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.DgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmployee
        '
        Me.DgvEmployee.AllowUserToAddRows = False
        Me.DgvEmployee.AllowUserToDeleteRows = False
        Me.DgvEmployee.AllowUserToResizeColumns = False
        Me.DgvEmployee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEmployee.GridColor = System.Drawing.Color.Red
        Me.DgvEmployee.Location = New System.Drawing.Point(47, 65)
        Me.DgvEmployee.Name = "DgvEmployee"
        Me.DgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmployee.Size = New System.Drawing.Size(643, 521)
        Me.DgvEmployee.TabIndex = 0
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(169, 30)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(292, 37)
        Me.txtEmpName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ชื่อ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "นามสุกล :"
        '
        'txtEmpLname
        '
        Me.txtEmpLname.Location = New System.Drawing.Point(169, 71)
        Me.txtEmpLname.Name = "txtEmpLname"
        Me.txtEmpLname.Size = New System.Drawing.Size(292, 37)
        Me.txtEmpLname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "User :"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(188, 358)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(154, 37)
        Me.txtUser.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(188, 400)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(154, 37)
        Me.txtPassword.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "บันทึก"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 30)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ยกเลิก"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(717, 595)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "เพิ่ม"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(867, 595)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "แก้ไข"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1004, 595)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 22)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ลบ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1120, 595)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ออก"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(296, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(663, 40)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "จัดการข้อมูลพนักงาน"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtIDthai)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.txtEmpLname)
        Me.GroupBox1.Controls.Add(Me.txtEmpName)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(696, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 512)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(278, 124)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(71, 34)
        Me.radFemale.TabIndex = 3
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(192, 125)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(61, 34)
        Me.radMale.TabIndex = 2
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtIDthai
        '
        Me.txtIDthai.Location = New System.Drawing.Point(188, 317)
        Me.txtIDthai.Name = "txtIDthai"
        Me.txtIDthai.Size = New System.Drawing.Size(173, 37)
        Me.txtIDthai.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_icon_79_document_cancel_314761
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(312, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(57, 39)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(188, 273)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(173, 37)
        Me.txtTel.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_Save_85542
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(188, 453)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(47, 39)
        Me.btnSave.TabIndex = 9
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(184, 164)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(292, 94)
        Me.txtAdd.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(57, 397)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 30)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Pssword :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(58, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 30)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "เบอร์โทร :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 30)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "บัตรประชาชน :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(94, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 30)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "เพศ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ที่อยู่ :"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_exit_38999
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1165, 589)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 35)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_button_cancel_1939
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1040, 589)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 35)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_icon_136_document_edit_314724
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(908, 589)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(51, 38)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_sign_add_2990681
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(756, 586)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(53, 41)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DgvEmployee)
        Me.Controls.Add(Me.Label12)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการข้อมูลพนักงาน"
        CType(Me.DgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmpLname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtIDthai As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
