Public Class frmmain

    Private Sub MetroTile12_Click(sender As Object, e As EventArgs) Handles MetroTile12.Click
        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbusername.Text = username
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        frmcomputer.ShowDialog()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        frmclonecomputer.ShowDialog()
    End Sub

    Private Sub MetroTile11_Click(sender As Object, e As EventArgs) Handles MetroTile11.Click

    End Sub

    Private Sub MetroTile13_Click(sender As Object, e As EventArgs) Handles MetroTile13.Click

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        frmimportcomputer.ShowDialog()
    End Sub
End Class