Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
        Form2.Show()
    End Sub
End Class
