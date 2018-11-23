Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class addProduct
    Dim mycon As New SqlConnection
    Dim myda As New SqlDataAdapter
    Dim myds As New DataSet
    Dim strcon As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim status, strdepid, strtype, strSQl, strempid As String
    Dim onhand, total As Integer
    Private Sub connectDB()
        If mycon.State = ConnectionState.Open Then
            mycon.Close()
        End If
        mycon.ConnectionString = strcon
        mycon.Open()
    End Sub
    Private Sub loaddata()
        Call connectDB()
        myds.Clear()
        strSQl = "SELECT  dbo.Type.t_id,dbo.Type.t_name,dbo.Product.proid,dbo.Product.proname,dbo.Product.proprice,dbo.Product.t_id,dbo.Product.proOnhabd FROM dbo.Type INNER JOIN dbo.Product ON dbo.Product.t_id = dbo.Type.t_id and t_name='" & strtype & "' "
        myda = New SqlDataAdapter(strSQl, mycon)
        myda.Fill(myds, "tbproduct")
        DgvProduct.DataSource = myds.Tables("tbproduct")
        DgvProduct.Columns(2).HeaderText = "รหัสสินค้า"
        DgvProduct.Columns(3).HeaderText = "ชื่อสินค้า"
        DgvProduct.Columns(4).HeaderText = "ราคา"
        DgvProduct.Columns(3).HeaderText = "ชื่อสินค้า"
        DgvProduct.Columns(4).HeaderText = "ราคาต่อหน่วย"
        DgvProduct.Columns(6).HeaderText = "คงเหลือ"
        DgvProduct.Columns(0).Width = 100
        DgvProduct.Columns(1).Width = 200
        DgvProduct.Columns(2).Width = 200
        DgvProduct.Columns(3).Width = 460
        DgvProduct.Columns(5).Width = 100
        DgvProduct.Columns(5).Visible = False
        DgvProduct.Columns(0).Visible = False
        DgvProduct.Columns(1).Visible = False
    End Sub

    Private Sub DgvProduct_Cellenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProduct.CellEnter
        Dim n As Integer = DgvProduct.CurrentCell.RowIndex
        txtId.Text = DgvProduct.Item(2, n).Value
        txtname.Text = DgvProduct.Item(3, n).Value
        txtonhand.Text = DgvProduct.Item(6, n).Value
        onhand = Val(txtonhand.Text)
    End Sub

    Private Sub cbotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotype.SelectedIndexChanged
        strtype = cbotype.SelectedItem
        Call loaddata()
    End Sub
    Private Sub loadtype()
        Call connectDB()
        strSQl = "select* from type"
        mycomm = New SqlCommand(strSQl, mycon)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        myDR = mycomm.ExecuteReader
        cbotype.Items.Clear()
        Do While myDR.Read()
            cbotype.Items.Add(myDR("t_name"))
        Loop
        myDR.Close()
        cbotype.SelectedIndex = 0
    End Sub

    Private Sub addProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadtype()
        Call connectDB()
        txtamount.Enabled = False
        txtId.Enabled = False
        txtonhand.Enabled = False
        txtname.Enabled = False
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        txtamount.Enabled = True
        txtamount.Focus()
        cbotype.Enabled = False
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Dim amount As Integer
        amount = Val(txtamount.Text)
        total = amount + onhand
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtamount.Text.Trim = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not IsNumeric(txtamount.Text) Then
            MessageBox.Show("กรุณาป้อนจำนวนเป็นตัวเลข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        strSQl = "update product set proOnhabd='" & total & "' where proid='" & txtId.Text & "'"
        mycomm = New SqlCommand(strSQl, mycon)
        mycomm.ExecuteNonQuery()
        MessageBox.Show("บันทึกข้อมูลเรียนร้อย", "succeessed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call loadtype()
        cbotype.Enabled = True
        txtamount.Enabled = False
        txtamount.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call loadtype()
        Call connectDB()
        txtamount.Enabled = False
        txtId.Enabled = False
        txtonhand.Enabled = False
        txtname.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class