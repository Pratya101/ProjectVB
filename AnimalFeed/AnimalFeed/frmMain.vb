Public Class frmMain
    Dim frmMylogin As New LoginForm1
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMylogin.ShowDialog()
        If Empid = "" Then
            End
        Else
            If position = 1 Then
                MessageBox.Show("ยินดีต้อบรับผู้จัดการ คุณ : " & Fullname & " เข้าสู่ระบบ", "Welcom", MessageBoxButtons.OK, MessageBoxIcon.Information)
                addemp.Enabled = True
            ElseIf position = 2 Then
                MessageBox.Show("ยินดีต้อบรับพนักงาน คุณ : " & Fullname & " เข้าสู่ระบบ", "Welcom", MessageBoxButtons.OK, MessageBoxIcon.Information)
                addemp.Visible = False
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub

    Private Sub เพมพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addemp.Click
        Dim AddEmp As New AddEmployee
        addemp.ShowDialog()
    End Sub
    Private Sub อาหารหมToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles อาหารหมToolStripMenuItem.Click
        addProduct.ShowDialog()
    End Sub

    Private Sub ขายToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขายToolStripMenuItem.Click
        sale.ShowDialog()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Empid = ""
        Fullname = ""
        position = ""
        Call frmMain_Load(sender, e)
    End Sub
End Class
