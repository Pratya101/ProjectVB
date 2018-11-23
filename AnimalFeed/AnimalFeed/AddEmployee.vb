Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class AddEmployee
    Dim mycon As New SqlConnection
    Dim myda As New SqlDataAdapter
    Dim myds As New DataSet
    Dim strcon As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim status, strdepid, strdepartment, strSQl, strempid As String
    Dim sex1 As String = "ชาย"
    Dim sex2 As String = "หญิง"
    Dim empid As Integer
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
        strSQl = "SELECT * FROM employee,position where employee.po_id = position.po_id and employee.po_id<>1"
        myda = New SqlDataAdapter(strSQl, mycon)
        myda.Fill(myds, "dtEmployee")
        DgvEmployee.DataSource = myds.Tables("dtEmployee")
        DgvEmployee.Columns(1).HeaderText = "Username"
        DgvEmployee.Columns(2).HeaderText = "Password"
        DgvEmployee.Columns(3).HeaderText = "ชื่อพนักงาน"
        DgvEmployee.Columns(4).HeaderText = "นามสกุล"
        DgvEmployee.Columns(5).HeaderText = "เพศ"
        DgvEmployee.Columns(6).HeaderText = "เบอร์โทร"
        'DgvEmployee.Columns(1).Width = 100
        'DgvEmployee.Columns(2).Width = 100
        'DgvEmployee.Columns(6).Width = 100
        DgvEmployee.Columns(0).Visible = False
        DgvEmployee.Columns(7).Visible = False
        DgvEmployee.Columns(8).Visible = False
        DgvEmployee.Columns(9).Visible = False
        DgvEmployee.Columns(10).Visible = False
        DgvEmployee.Columns(11).Visible = False
    End Sub

    Private Sub AddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loaddata()
        Call connectDB()
        txtUser.Enabled = False
        txtEmpLname.Enabled = False
        txtEmpName.Enabled = False
        txtPassword.Enabled = False
        txtAdd.Enabled = False
        txtIDthai.Enabled = False
        txtTel.Enabled = False
        radFemale.Enabled = False
        radMale.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Private Sub DgvEmployee_Cellenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEmployee.CellEnter
        Dim n As Integer = DgvEmployee.CurrentCell.RowIndex
        Dim sex As String
        empid = DgvEmployee.Item(0, n).Value
        txtUser.Text = DgvEmployee.Item(1, n).Value
        txtPassword.Text = DgvEmployee.Item(2, n).Value
        txtEmpName.Text = DgvEmployee.Item(3, n).Value
        txtEmpLname.Text = DgvEmployee.Item(4, n).Value
        sex = DgvEmployee.Item(5, n).Value
        If sex = "ชาย" Then
            radMale.Checked = True
        ElseIf sex = "หญิง" Then
            radFemale.Checked = True
        End If
        txtTel.Text = DgvEmployee.Item(6, n).Value
        txtAdd.Text = DgvEmployee.Item(7, n).Value
        txtIDthai.Text = DgvEmployee.Item(8, n).Value
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call loaddata()
        Call connectDB()
        txtUser.Enabled = False
        txtEmpLname.Enabled = False
        txtEmpName.Enabled = False
        txtPassword.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        status = "insert"
        Call connectDB()
        strSQl = "select max(empid)+1 as mEmpid from employee "
        mycomm = New SqlCommand(strSQl, mycon)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        empid = myDR("mEmpid")
        txtUser.Enabled = True
        txtEmpLname.Enabled = True
        txtEmpName.Enabled = True
        txtPassword.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtAdd.Enabled = True
        txtIDthai.Enabled = True
        txtTel.Enabled = True
        radFemale.Enabled = True
        radMale.Enabled = True
        txtUser.Clear()
        txtEmpLname.Clear()
        txtEmpName.Clear()
        txtPassword.Clear()
        txtAdd.Clear()
        txtIDthai.Clear()
        txtTel.Clear()
        radFemale.Checked = False
        radMale.Checked = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        status = "Update"
        txtUser.Enabled = True
        txtEmpLname.Enabled = True
        txtEmpName.Enabled = True
        txtPassword.Enabled = True
        txtAdd.Enabled = True
        txtIDthai.Enabled = True
        txtTel.Enabled = True
        radFemale.Enabled = True
        radMale.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtEmpName.Focus()
        strempid = txtUser.Text
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call connectDB()
        Dim sex As String
        txtUser.Text.Trim()
        txtPassword.Text.Trim()
        txtEmpLname.Text.Trim()
        txtEmpName.Text.Trim()
        Dim positions As Integer = 2
        If txtPassword.Text = "" Or txtUser.Text = "" Or txtEmpLname.Text = "" Or txtEmpName.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
        End If
        If status = "insert" Then
            strSQl = "select empuser from employee where empuser='" & txtUser.Text & "'"
            mycomm = New SqlCommand(strSQl, mycon)
            myDR = mycomm.ExecuteReader
            If myDR.HasRows Then
                MessageBox.Show("ไม่สามารถตั้ง User ซ้ำได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                myDR.Close()
                txtUser.Focus()
                Exit Sub
            Else
                myDR.Close()
            End If
            If radMale.Checked = True Then
                sex = "ชาย"
            ElseIf radFemale.Checked = True Then
                sex = "หญิง"
            End If
            strSQl = "insert into employee values(@id,@user,@password,@name,@lname,@sex,@tel,@add,@IDthai,@po_id)"
            mycomm = New SqlCommand(strSQl, mycon)
            mycomm.Parameters.AddWithValue("@id", empid)
            mycomm.Parameters.AddWithValue("@user", txtUser.Text)
            mycomm.Parameters.AddWithValue("@password", txtPassword.Text)
            mycomm.Parameters.AddWithValue("@name", txtEmpName.Text)
            mycomm.Parameters.AddWithValue("@lname", txtEmpLname.Text)
            mycomm.Parameters.AddWithValue("@sex", sex)
            mycomm.Parameters.AddWithValue("@tel", txtTel.Text)
            mycomm.Parameters.AddWithValue("@add", txtAdd.Text)
            mycomm.Parameters.AddWithValue("@IDthai", txtIDthai.Text)
            mycomm.Parameters.AddWithValue("@po_id", positions)
            mycomm.ExecuteNonQuery()

            Call btnCancel_Click(sender, e)
            Call loaddata()
            Call AddEmployee_Load(sender, e)
            MessageBox.Show("บันทึกข้อมูลเรียนร้อย", "succeessed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '****************************************************************************************************************************************************************************************************
            '****************************************************************************************************************************************************************************************************
            '****************************************************************************************************************************************************************************************************
        Else
            Dim ss As String
            If radFemale.Checked = True Then
                ss = "หญิง"
            ElseIf radMale.Checked = True Then
                ss = "ชาย"
            End If
            strSQl = "update employee set empid=@id,empuser=@user,emppassword=@password,empname=@name,emplname=@lname,empsex=@sex,emptel=@tel,empaddress=@add,empIDThai=@IDThai,Po_id=@po where empUser=@user"
            mycomm = New SqlCommand(strSQl, mycon)
            mycomm.Parameters.AddWithValue("@id", empid)
            mycomm.Parameters.AddWithValue("@user", txtUser.Text)
            mycomm.Parameters.AddWithValue("@password", txtPassword.Text)
            mycomm.Parameters.AddWithValue("@name", txtEmpName.Text)
            mycomm.Parameters.AddWithValue("@lname", txtEmpLname.Text)
            mycomm.Parameters.AddWithValue("@sex", ss)
            mycomm.Parameters.AddWithValue("@tel", txtTel.Text)
            mycomm.Parameters.AddWithValue("@add", txtAdd.Text)
            mycomm.Parameters.AddWithValue("@IDThai", txtIDthai.Text)
            mycomm.Parameters.AddWithValue("@po", positions)
            mycomm.ExecuteNonQuery()
            Call btnCancel_Click(sender, e)
            Call loaddata()
            Call AddEmployee_Load(sender, e)
            MessageBox.Show("บันทึกข้อมูลเรียนร้อย", "succeessed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim n As Integer = DgvEmployee.CurrentCell.RowIndex
        Dim employee As String = DgvEmployee.Item(0, n).Value & "" & DgvEmployee.Item(1, n).Value
        Dim dr As DialogResult
        dr = MessageBox.Show("คุณต้องการที่จะลบข้อมูลพนักงานคนนี้ใช่หรือไม่  " & employee, "comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If dr = Windows.Forms.DialogResult.Yes Then
            strSQl = "delete employee where empuser=@user"
            mycomm = New SqlCommand(strSQl, mycon)
            mycomm.Parameters.AddWithValue("@user", txtUser.Text)
            mycomm.ExecuteNonQuery()
            Call btnCancel_Click(sender, e)
            Call loaddata()
            MessageBox.Show("ลบข้อมูลเรียบร้อยเเล้ว", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call loaddata()
            Call connectDB()
            txtUser.Enabled = False
            txtEmpLname.Enabled = False
            txtEmpName.Enabled = False
            txtPassword.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class