Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class LoginForm1
    Dim strconn As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim strsql As String
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand
    Dim dr As SqlDataReader
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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
        strsql = "select * from employee where empuser=@user and emppassword=@password"
        comm = New SqlCommand(strsql, conn)
        comm.Parameters.AddWithValue("@user", txtUser.Text)
        comm.Parameters.AddWithValue("@password", txtpassword.Text)
        dr = comm.ExecuteReader
        If Not dr.HasRows Then
            MessageBox.Show("UserID หรือ Password ของท่านผิด", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dr.Close()
            Exit Sub
        Else
            dr.Read()
            Empid = dr("empuser")
            Fullname = dr("empNAme") & "  " & dr("empLname")
            position = dr("po_id")
            Me.Close()
            dr.Close()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtpassword.Clear()
        txtUser.Focus()
    End Sub
End Class
