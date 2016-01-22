Public Class frmclonecomputer

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        frmreportclone.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        subviewclonecomputerspec.ShowDialog()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        subviewclonestock.ShowDialog()
    End Sub

    Private Sub frmclonecomputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class