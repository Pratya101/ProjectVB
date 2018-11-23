<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addProduct))
        Me.DgvProduct = New System.Windows.Forms.DataGridView()
        Me.GPADD = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtonhand = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.DgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPADD.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvProduct
        '
        Me.DgvProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.DgvProduct.AllowUserToAddRows = False
        Me.DgvProduct.AllowUserToDeleteRows = False
        Me.DgvProduct.AllowUserToResizeColumns = False
        Me.DgvProduct.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvProduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvProduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProduct.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DgvProduct.Location = New System.Drawing.Point(264, 12)
        Me.DgvProduct.Name = "DgvProduct"
        Me.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProduct.Size = New System.Drawing.Size(902, 368)
        Me.DgvProduct.TabIndex = 10
        '
        'GPADD
        '
        Me.GPADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GPADD.Controls.Add(Me.Label9)
        Me.GPADD.Controls.Add(Me.Label4)
        Me.GPADD.Controls.Add(Me.Label3)
        Me.GPADD.Controls.Add(Me.Label6)
        Me.GPADD.Controls.Add(Me.Label5)
        Me.GPADD.Controls.Add(Me.Label2)
        Me.GPADD.Controls.Add(Me.Label1)
        Me.GPADD.Controls.Add(Me.txtonhand)
        Me.GPADD.Controls.Add(Me.txtname)
        Me.GPADD.Controls.Add(Me.txtId)
        Me.GPADD.Controls.Add(Me.txtamount)
        Me.GPADD.Controls.Add(Me.cbotype)
        Me.GPADD.Controls.Add(Me.btnCancel)
        Me.GPADD.Controls.Add(Me.btnSave)
        Me.GPADD.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPADD.Location = New System.Drawing.Point(264, 386)
        Me.GPADD.Name = "GPADD"
        Me.GPADD.Size = New System.Drawing.Size(902, 199)
        Me.GPADD.TabIndex = 18
        Me.GPADD.TabStop = False
        Me.GPADD.Text = "เพิ่มอาหาร"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(709, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ยกเลิก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "บันทึก"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "คงเหลือ :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(436, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "ชื่ออาหาร"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "รหัสอาหาร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "จำนวน :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ประเภทอาหาร :"
        '
        'txtonhand
        '
        Me.txtonhand.Location = New System.Drawing.Point(460, 122)
        Me.txtonhand.Name = "txtonhand"
        Me.txtonhand.Size = New System.Drawing.Size(100, 29)
        Me.txtonhand.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(508, 63)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(301, 29)
        Me.txtname.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(329, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(104, 29)
        Me.txtId.TabIndex = 1
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(284, 122)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(100, 29)
        Me.txtamount.TabIndex = 3
        '
        'cbotype
        '
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(52, 63)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(177, 30)
        Me.cbotype.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_Cancel_34560
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(761, 113)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 45)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_Save_85542
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(657, 118)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 38)
        Me.btnSave.TabIndex = 5
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(637, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 22)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "เพิ่ม"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(727, 597)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ออก"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_exit_3226
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(766, 591)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 32)
        Me.btnClose.TabIndex = 15
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = Global.AnimalFeed.My.Resources.Resources.if_sign_add_2990682
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Location = New System.Drawing.Point(672, 591)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(48, 32)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'addProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 646)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GPADD)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DgvProduct)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มสินค้า"
        CType(Me.DgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPADD.ResumeLayout(False)
        Me.GPADD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents DgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents GPADD As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtonhand As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
