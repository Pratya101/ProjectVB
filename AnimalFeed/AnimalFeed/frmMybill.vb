Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmMybill

    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DsMyproject
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim strCon As String = ConfigurationManager.ConnectionStrings("AnimalFeed.My.MySettings.Setting").ConnectionString
    Dim strSQL As String
    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Sub DetailReport()
        Dim myRpt As New CptSale
        strSQL = "Select * from DetailSale where saleid = '" & totalProduct.lblsaleid.Text & " '"
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtDetailSale")
        myRpt.SetDataSource(myDS.Tables("dtDetailSale"))
        myRpt.SetParameterValue("total", totalProduct.lblSum.Text)
        Crvmyreport.ReportSource = myRpt
        Crvmyreport.Show()
    End Sub

    Private Sub frmMybill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDB()
        Call DetailReport()
    End Sub

End Class