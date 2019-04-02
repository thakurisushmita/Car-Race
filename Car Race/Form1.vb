Public Class Form1
    Dim road(15) As PictureBox
    Dim s As Integer
    Dim Start As Integer = 5

    Private Sub TimerMoveRight_Tick(sender As Object, e As EventArgs) Handles TimerMoveRight.Tick
        PictureBox1.Left += 5

    End Sub
    Private Sub TimerMoveLeft_Tick(sender As Object, e As EventArgs) Handles TimerMoveLeft.Tick
        PictureBox1.Left -= 5
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            TimerMoveRight.Start()


        End If
        If e.KeyCode = Keys.Left Then
            TimerMoveLeft.Start()
        End If



    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        TimerMoveLeft.Stop()
        TimerMoveRight.Stop()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        road(0) = PictureBox6
        road(1) = PictureBox7
        road(2) = PictureBox12
        road(3) = PictureBox13
        road(4) = PictureBox14
        road(5) = PictureBox15
        road(6) = PictureBox16
        road(7) = PictureBox17
        road(8) = PictureBox18
        road(9) = PictureBox19
        road(10) = PictureBox20
        road(11) = PictureBox21
        road(12) = PictureBox22
        road(13) = PictureBox23
        road(14) = PictureBox24
        road(15) = PictureBox25

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For x = 0 To 15
            road(x).Top += 4
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height

            End If
        Next
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Timer_Time_Tick(sender As Object, e As EventArgs) Handles Timer_Time.Tick
        s += 1

        Label1.Text = 5

    End Sub

    Private Sub Timer_Start_Tick(sender As Object, e As EventArgs) Handles Timer_Start.Tick

        If Start > 0 Then
            Start -= 1
        End If

    End Sub
End Class
