Public Class frmreportclone

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub


    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        subaddclonecategory.ShowDialog()
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        subaddclonespec.ShowDialog()
    End Sub
End Class