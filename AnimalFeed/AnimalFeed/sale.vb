Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class sale
    Dim strconn As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim strsql As String
    Dim myda As New SqlDataAdapter
    Dim myds As New DataSet
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand
    Dim tran As SqlTransaction
    Dim dr As SqlDataReader
    Dim teet, strtype As String
    Dim nbb As Integer = 0
    Dim n As Integer
    Private Sub btnNewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewBill.Click
        Call conDB()
        lblSalDate.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
        strsql = "select max(saleid)+1as msaleid from detailsale "
        comm = New SqlCommand(strsql, conn)
        dr = comm.ExecuteReader
        dr.Read()
        teet = dr("msaleid")
        lblSalld.Text = "000" & teet
        lblFullName.Text = Fullname
        Call conDB()
        Call loadtype()
        txtAmount.Text = 1
    End Sub
    Private Sub conDB()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            conn.ConnectionString = strconn
            conn.Open()
        Catch
            MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้")
            End
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim drg As DialogResult
        Pooid = lblproid.Text
        sSaleID = lblSalld.Text
        allprice = Val(lblProPrice.Text) * Val(txtAmount.Text)
        intamount = Val(txtAmount.Text)
        Call conDB()
        If txtCustomer.Text = "" Or lblProName.Text = "" Or txtAmount.Text = "" Then
            MessageBox.Show("ข้อมูลไม่ครบ")
        Else
            strsql = "insert into DetailSale values(@sid,@date,@nemp,@ncus,@Pid,@amount,@name)"
            comm = New SqlCommand(strsql, conn)
            comm.Parameters.AddWithValue("@sid", lblSalld.Text)
            comm.Parameters.AddWithValue("@date", lblSalDate.Text)
            comm.Parameters.AddWithValue("@nemp", lblFullName.Text)
            comm.Parameters.AddWithValue("@ncus", txtCustomer.Text)
            comm.Parameters.AddWithValue("@Pid", lblproid.Text)
            comm.Parameters.AddWithValue("@amount", intamount)
            saletotal = saletotal + (intamount * Val(lblProPrice.Text))
            comm.Parameters.AddWithValue("@name", lblProName.Text)
            comm.ExecuteNonQuery()
            totalProduct.ShowDialog()
        End If
    End Sub

    Private Sub loadSale()
        Call conDB()
        myds.Clear()
        strsql = "SELECT dbo.DetailSale.Proid,dbo.DetailSale.namePRo,dbo.DetailSale.amount   FROM dbo.DetailSale where saleid='" & lblSalld.Text & "' "
        myda = New SqlDataAdapter(strsql, conn)
        myda.Fill(myds, "tbSale")
        dgvSale.DataSource = myds.Tables("tbSale")
    End Sub
    Private Sub loaddata()
        Call conDB()
        myds.Clear()
        strSQl = "SELECT  dbo.Type.t_id,dbo.Type.t_name,dbo.Product.proid,dbo.Product.proname,dbo.Product.proprice,dbo.Product.t_id,dbo.Product.proOnhabd FROM dbo.Type INNER JOIN dbo.Product ON dbo.Product.t_id = dbo.Type.t_id and t_name='" & strtype & "' "
        myda = New SqlDataAdapter(strsql, conn)
        myda.Fill(myds, "tbproduct")
        dgvSale.DataSource = myds.Tables("tbproduct")
        dgvSale.Columns(2).HeaderText = "รหัสสินค้า"
        dgvSale.Columns(3).HeaderText = "ชื่อสินค้า"
        dgvSale.Columns(4).HeaderText = "ราคาต่อหน่วย"
        dgvSale.Columns(6).HeaderText = "คงเหลือ"
        dgvSale.Columns(2).Width = 150
        dgvSale.Columns(3).Width = 380
        dgvSale.Columns(4).Width = 160
        dgvSale.Columns(6).Width = 110
        dgvSale.Columns(5).Visible = False
        dgvSale.Columns(0).Visible = False
        dgvSale.Columns(1).Visible = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotype.SelectedIndexChanged
        strtype = cbotype.SelectedItem
        Call loaddata()
    End Sub
    Private Sub loadtype()
        Call conDB()
        strSQl = "select* from type"
        comm = New SqlCommand(strsql, conn)
        comm.CommandType = CommandType.Text
        comm.CommandTimeout = 15
        dr = comm.ExecuteReader
        cbotype.Items.Clear()
        Do While dr.Read()
            cbotype.Items.Add(dr("t_name"))
        Loop
        dr.Close()
        cbotype.SelectedIndex = 0
    End Sub
    Private Sub sale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub dgvSale_callenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellEnter
        Dim n As Integer = dgvSale.CurrentCell.RowIndex
        lblproid.Text = dgvSale.Item(2, n).Value
        lblProName.Text = dgvSale.Item(3, n).Value
        lblOnhand.Text = dgvSale.Item(6, n).Value
        lblProPrice.Text = dgvSale.Item(4, n).Value
    End Sub


    Private Sub dgvSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellContentClick

    End Sub
End Class