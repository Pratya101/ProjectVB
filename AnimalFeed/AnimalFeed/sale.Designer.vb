<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sale))
        Me.btnNewBill = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSalld = New System.Windows.Forms.Label()
        Me.lblSalDate = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblOnhand = New System.Windows.Forms.Label()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblproid = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewBill
        '
        Me.btnNewBill.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnNewBill.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBill.Location = New System.Drawing.Point(285, 24)
        Me.btnNewBill.Name = "btnNewBill"
        Me.btnNewBill.Size = New System.Drawing.Size(124, 41)
        Me.btnNewBill.TabIndex = 0
        Me.btnNewBill.Text = "เปิดปิดขายใหม่"
        Me.btnNewBill.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCoral
        Me.btnExit.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(285, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 41)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "หมายเลขใบเสร็จ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "พนักงานขาย"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ลูกค้า"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(776, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "วันที่ขาย"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalld
        '
        Me.lblSalld.BackColor = System.Drawing.Color.White
        Me.lblSalld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalld.Location = New System.Drawing.Point(572, 24)
        Me.lblSalld.Name = "lblSalld"
        Me.lblSalld.Size = New System.Drawing.Size(198, 35)
        Me.lblSalld.TabIndex = 0
        '
        'lblSalDate
        '
        Me.lblSalDate.BackColor = System.Drawing.Color.White
        Me.lblSalDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalDate.Location = New System.Drawing.Point(902, 23)
        Me.lblSalDate.Name = "lblSalDate"
        Me.lblSalDate.Size = New System.Drawing.Size(198, 35)
        Me.lblSalDate.TabIndex = 1
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.White
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Location = New System.Drawing.Point(572, 77)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(528, 35)
        Me.lblFullName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "รหัสสินค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(144, 387)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(420, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ชื่อสินค้า"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(570, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 29)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "ราคาต่อหน่วย"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(699, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "คงเหลือ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.Color.White
        Me.lblProName.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProName.Location = New System.Drawing.Point(144, 422)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(420, 26)
        Me.lblProName.TabIndex = 2
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.Color.White
        Me.lblProPrice.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProPrice.Location = New System.Drawing.Point(570, 422)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(123, 26)
        Me.lblProPrice.TabIndex = 3
        '
        'lblOnhand
        '
        Me.lblOnhand.BackColor = System.Drawing.Color.White
        Me.lblOnhand.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnhand.Location = New System.Drawing.Point(699, 422)
        Me.lblOnhand.Name = "lblOnhand"
        Me.lblOnhand.Size = New System.Drawing.Size(141, 26)
        Me.lblOnhand.TabIndex = 4
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        Me.dgvSale.AllowUserToResizeColumns = False
        Me.dgvSale.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSale.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSale.GridColor = System.Drawing.Color.Red
        Me.dgvSale.Location = New System.Drawing.Point(22, 76)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(815, 305)
        Me.dgvSale.TabIndex = 11
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(573, 127)
        Me.txtCustomer.Multiline = True
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(527, 33)
        Me.txtCustomer.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lime
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(498, 455)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 54)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cbotype
        '
        Me.cbotype.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(405, 26)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(180, 38)
        Me.cbotype.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ประเภทอาหาร :"
        '
        'lblproid
        '
        Me.lblproid.BackColor = System.Drawing.Color.White
        Me.lblproid.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproid.Location = New System.Drawing.Point(21, 422)
        Me.lblproid.Name = "lblproid"
        Me.lblproid.Size = New System.Drawing.Size(117, 26)
        Me.lblproid.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmount.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(330, 457)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(162, 45)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(260, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 30)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "จำนวน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbotype)
        Me.GroupBox1.Controls.Add(Me.dgvSale)
        Me.GroupBox1.Controls.Add(Me.lblOnhand)
        Me.GroupBox1.Controls.Add(Me.lblproid)
        Me.GroupBox1.Controls.Add(Me.lblProPrice)
        Me.GroupBox1.Controls.Add(Me.lblProName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(263, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(866, 524)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ตารางรายการสินค้า"
        '
        'sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 699)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lblSalDate)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblSalld)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewBill)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sale"
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewBill As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSalld As System.Windows.Forms.Label
    Friend WithEvents lblSalDate As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents lblOnhand As System.Windows.Forms.Label
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblproid As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
