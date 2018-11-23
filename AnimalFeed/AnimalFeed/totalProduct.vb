Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class totalProduct
    Dim strconn As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim strsql As String
    Dim myda As New SqlDataAdapter
    Dim myds As New DataSet
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand
    Dim dr As SqlDataReader
    Dim tran As SqlTransaction
    Dim teet, strtype, proid As String
    Dim nbb As Integer = 0
    Dim total As Integer = 0
    Dim n As Integer
    Dim sumonhand As Integer
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
    Private Sub totalProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblsaleid.Text = sale.lblSalld.Text
        lblDate.Text = sale.lblSalDate.Text
        lblNAmeEmp.Text = sale.lblFullName.Text
        lblNamecus.Text = sale.txtCustomer.Text
        total = intamount * Val(sale.lblProPrice.Text)
        lblSum.Text = Val(lblSum.Text) + total
        sumonhand = sale.lblOnhand.Text - intamount

        '***********************************************************************************************************************************************************************
        '***********************************************************************************************************************************************************************
        '***********************************************************************************************************************************************************************
        Call conDB()
        strsql = "update product set proonhabd=@amount where proid=@ID"
        comm = New SqlCommand(strsql, conn)
        comm.Parameters.AddWithValue("@id", Pooid)
        comm.Parameters.AddWithValue("@amount", sumonhand)
        comm.ExecuteNonQuery()
        Call conDB()
        Call loadsale()
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sale.Show()
        sale.dgvSale.Refresh()
        sale.txtAmount.Text = ""
        sale.txtAmount.Focus()
        Me.Close()
    End Sub

    Private Sub btnDeletl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletl.Click
        Dim n As Integer = PRoduct.CurrentCell.RowIndex
        Dim allprice, allamount, del, sumonhandaa, allonhand As Integer
        Dim saleproduct As String = PRoduct.Item(0, n).Value & "" & PRoduct.Item(1, n).Value
        Dim dgr As DialogResult
        Dim dgr2 As DialogResult
        dgr = MessageBox.Show("คุณต้องการที่จะลบสิค้านี้ใช่หรือไม่  " & saleproduct, "comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If dgr = Windows.Forms.DialogResult.Yes Then
            strsql = "delete from detailsale where proid=@Pid"
            comm = New SqlCommand(strsql, conn)
            proid = PRoduct.Item(0, n).Value
            allamount = PRoduct.Item(3, n).Value
            allprice = PRoduct.Item(2, n).Value
            sumonhandaa = PRoduct.Item(4, n).Value
            allonhand = sumonhandaa + allamount
            del = allprice * allamount
            comm.Parameters.AddWithValue("@Pid", PRoduct.Item(0, n).Value)
            comm.ExecuteNonQuery()
            Call conDB()
            Call loadsale()
            lblSum.Text = Val(lblSum.Text) - del
            dgr2 = MessageBox.Show("ลบข้อมูลเรียบร้อยเเล้ว", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If dgr2 = Windows.Forms.DialogResult.OK Then
                Call conDB()
                strsql = "update product set proonhabd=@amount where proid=@ID"
                comm = New SqlCommand(strsql, conn)
                comm.Parameters.AddWithValue("@ID", proid)
                comm.Parameters.AddWithValue("@amount", allonhand)
                comm.ExecuteNonQuery()
            End If
            '***********************************************************************************************************************************************************************
            '***********************************************************************************************************************************************************************
            '***********************************************************************************************************************************************************************
        Else
            Call conDB()
            Call loadsale()
        End If
    End Sub

    Private Sub PRoduct_cellenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PRoduct.CellEnter
    End Sub
    Private Sub loadsale()
        Call conDB()
        myds.Clear()
        strsql = "Select detailsale.proid,namepro,proprice,amount,proonhabd from detailsale,product where product.proid=detailsale.proid and saleid='" & sale.lblSalld.Text & "'"
        myda = New SqlDataAdapter(strsql, conn)
        myda.Fill(myds, "1234")
        PRoduct.DataSource = myds.Tables("1234")
        PRoduct.Columns(0).Width = 150
        PRoduct.Columns(1).Width = 490
        PRoduct.Columns(2).Width = 150
        PRoduct.Columns(3).Width = 150
        PRoduct.Columns(4).Visible = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmMybill.ShowDialog()
    End Sub

    Private Sub PRoduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PRoduct.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class