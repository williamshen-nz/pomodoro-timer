Public Class Pomodoro
    ' Constants in seconds
    Private Const PomodoroLength = 25 * 60
    Private Const BreakLength = 5 * 60

    ' Class variables
    Private timeLeft
    Private isBreak As Boolean = False
    Private count = 0

    Private Sub Pomodoro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Force this form to top
        Me.TopMost = True
        ' Set timeLeft to our defined length
        timeLeft = PomodoroLength
        progressBar.Maximum = PomodoroLength

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Start timer
        mainTimer.Start()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        ' Stop timer
        mainTimer.Stop()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Stop timer, reset timeLeft, label and form name
        Me.Text = "Pomodoro"
        mainTimer.Stop()
        timeLeft = PomodoroLength
        ' Show reset time and reset progress bar
        Dim span = TimeSpan.FromSeconds(timeLeft)
        lblTime.Text = span.Minutes.ToString.PadLeft(2, "0"c) & ":" & span.Seconds.ToString.PadLeft(2, "0"c)
        progressBar.Value = 0
    End Sub

    Private Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles mainTimer.Tick
        ' Reduce time by one
        timeLeft -= 1

        ' Check if it is a break time or not
        If timeLeft = 0 And Not isBreak Then
            ' It is a break, change label and variables accordingly
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            isBreak = True
            timeLeft = BreakLength
            lblTime.ForeColor = Color.CadetBlue
        ElseIf timeLeft = 0 Then
            ' Break finished. Increase counter
            count += 1
            lblCount.Text = count
            ' Reset time left - i.e. start again
            timeLeft = PomodoroLength
            lblTime.ForeColor = Color.Black
        End If

        ' Display in label
        Dim span = TimeSpan.FromSeconds(timeLeft)
        Dim strTime = span.Minutes.ToString.PadLeft(2, "0"c) & ":" & span.Seconds.ToString.PadLeft(2, "0"c)
        lblTime.Text = strTime
        If Not isBreak Then
            Me.Text = "Pomodoro - " & strTime
            progressBar.Value = PomodoroLength - timeLeft
        Else
            Me.Text = "Pomodoro Break - " & strTime
        End If
    End Sub
End Class
