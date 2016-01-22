Public Class frmimportcomputer

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        frmaddcomputer.ShowDialog()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        subviewstock.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        subviewcomputerspec.ShowDialog()
    End Sub


    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles btnAddSerial.Click
        subaddserial.ShowDialog()
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        frmaddcomputer.ShowDialog()
    End Sub

    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        subaddsupplier.ShowDialog()
    End Sub
End Class