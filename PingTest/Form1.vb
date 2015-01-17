Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' command for ping
        If My.Computer.Network.Ping("192.168.1.1") Then

            ' green = good
            Button11.BackColor = Color.Green

        Else

            ' red = bad
            Button11.BackColor = Color.Red

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If My.Computer.Network.Ping("192.168.1.2") Then

            Button12.BackColor = Color.Green

        Else

            Button12.BackColor = Color.Red

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If My.Computer.Network.Ping("192.168.1.3") Then

            Button13.BackColor = Color.Green

        Else

            Button13.BackColor = Color.Red

        End If

    End Sub

End Class
