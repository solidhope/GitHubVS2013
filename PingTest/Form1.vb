Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' command for ping
        If My.Computer.Network.Ping("") Then

            ' colors
            Button7.BackColor = Color.Green

        Else

            Button9.BackColor = Color.Red

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If My.Computer.Network.Ping("") Then

            Button7.BackColor = Color.Green

        Else

            Button9.BackColor = Color.Red

        End If

    End Sub

End Class
