
Public Class form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim name As String = ""
        Dim password As String = ""
        Dim username As String = ""
        Dim pass As String = ""
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Plz Fill All the info")
        Else
            name = TextBox1.Text
            password = TextBox2.Text
            Dim querry As String = "Select password From Table1 where name= '" & name & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\login.accdb"
            Dim conn = New OleDb.OleDbConnection(dbsource)
            Dim cmd As New OleDb.OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exit")
            End Try
            If (password = pass) Then
                ProgressBar.Show()
                proc.Show()
                Timer1.Start()
                Form2.Show()
                If Form2.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("Sorry login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(3)
        proc.Text = ProgressBar.Value
        If ProgressBar.Value = ProgressBar.Maximum Then
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            'hide password
            TextBox2.UseSystemPasswordChar = False
        Else
            'show password
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Hide()
        proc.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar_Click(sender As Object, e As EventArgs) Handles ProgressBar.Click

    End Sub

End Class