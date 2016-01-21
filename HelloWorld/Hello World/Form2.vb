Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Close()
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
    End Sub
End Class