<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class totalProduct
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PRoduct = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblsaleid = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNAmeEmp = New System.Windows.Forms.Label()
        Me.lblNamecus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.btnDeletl = New System.Windows.Forms.Button()
        CType(Me.PRoduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRoduct
        '
        Me.PRoduct.AllowUserToAddRows = False
        Me.PRoduct.AllowUserToDeleteRows = False
        Me.PRoduct.AllowUserToResizeColumns = False
        Me.PRoduct.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PRoduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PRoduct.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PRoduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRoduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PRoduct.Location = New System.Drawing.Point(134, 205)
        Me.PRoduct.Name = "PRoduct"
        Me.PRoduct.Size = New System.Drawing.Size(989, 380)
        Me.PRoduct.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnadd.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnadd.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(1129, 276)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(125, 99)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "ซื้อสินค้าเพิ่ม"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblsaleid
        '
        Me.lblsaleid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblsaleid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsaleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblsaleid.Location = New System.Drawing.Point(567, 25)
        Me.lblsaleid.Name = "lblsaleid"
        Me.lblsaleid.Size = New System.Drawing.Size(267, 34)
        Me.lblsaleid.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(567, 67)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(267, 35)
        Me.lblDate.TabIndex = 2
        '
        'lblNAmeEmp
        '
        Me.lblNAmeEmp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNAmeEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNAmeEmp.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNAmeEmp.Location = New System.Drawing.Point(567, 111)
        Me.lblNAmeEmp.Name = "lblNAmeEmp"
        Me.lblNAmeEmp.Size = New System.Drawing.Size(267, 35)
        Me.lblNAmeEmp.TabIndex = 2
        '
        'lblNamecus
        '
        Me.lblNamecus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNamecus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamecus.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamecus.Location = New System.Drawing.Point(567, 155)
        Me.lblNamecus.Name = "lblNamecus"
        Me.lblNamecus.Size = New System.Drawing.Size(267, 40)
        Me.lblNamecus.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เลขที่ใบเสร็จ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 35)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "วันที่"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(467, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 35)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ชื่อพนักงาน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(467, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 40)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ชื่อลูกค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(134, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(282, 38)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "รายการสั่งซื้อทั้งหมด"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPrint.BackColor = System.Drawing.Color.Lime
        Me.btnPrint.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1129, 381)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 99)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "พิมพ์ใบเสร็จ"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1129, 486)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 99)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ออก"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(849, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ราคารวม"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSum
        '
        Me.lblSum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSum.BackColor = System.Drawing.Color.White
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSum.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(849, 93)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(133, 106)
        Me.lblSum.TabIndex = 4
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeletl
        '
        Me.btnDeletl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDeletl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletl.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletl.Location = New System.Drawing.Point(988, 55)
        Me.btnDeletl.Name = "btnDeletl"
        Me.btnDeletl.Size = New System.Drawing.Size(135, 144)
        Me.btnDeletl.TabIndex = 3
        Me.btnDeletl.Text = "ลบ"
        Me.btnDeletl.UseVisualStyleBackColor = False
        '
        'totalProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimalFeed.My.Resources.Resources._001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 627)
        Me.Controls.Add(Me.btnDeletl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNamecus)
        Me.Controls.Add(Me.lblNAmeEmp)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblsaleid)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.PRoduct)
        Me.Name = "totalProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "totalProduct"
        CType(Me.PRoduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PRoduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lblsaleid As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNAmeEmp As System.Windows.Forms.Label
    Friend WithEvents lblNamecus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents btnDeletl As System.Windows.Forms.Button
End Class
