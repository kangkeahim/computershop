Public Class frmlogin

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Then
            MsgBox("Please input Username !")
            txtusername.Focus()
            Exit Sub
        End If
        If txtpassword.Text = "" Then
            MsgBox("Please input Password !")
            txtpassword.Focus()
            Exit Sub
        End If
        username = txtusername.Text
        frmmain.Show()
        Me.Close()
    End Sub
End Class
