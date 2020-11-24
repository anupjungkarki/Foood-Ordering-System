Public Class Form4

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        If pin_number.Text = "12345" Then
            Form5.Show()
            Me.Hide()

        Else
            MsgBox("Password is Incorrect", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pin_number.TextChanged

    End Sub

    Private Sub can_Click(sender As Object, e As EventArgs) Handles can.Click

    End Sub
End Class