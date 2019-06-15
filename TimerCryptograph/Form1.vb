Public Class Form1
    Dim jump As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudJumper.Text = 0
        txtA.Text = 0
        txtB.Text = 0
        txtAB.Text = 0
        nudEstAB.Text = 0
        nudEstAB.Enabled = True
        nudJumper.Enabled = True
        btnStartCount.Enabled = True
        btnUnlock.Enabled = False
        TimerTimeNow.Start()
    End Sub

    Private Sub TimerTimeNow_Tick(sender As Object, e As EventArgs) Handles TimerTimeNow.Tick
        txtTimeNow.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("TimerCryptograph Under Construction" + vbCrLf +
               "The timer-based cipher" + vbCrLf +
               "Testing purpose only, not for illegal uses" + vbCrLf +
               "PS: This is not going to lock or harm your computer, or else" + vbCrLf +
               "Copyright 2019 (c) Martin C.", MsgBoxStyle.Information)
    End Sub

    Private Sub BtnStartCount_Click(sender As Object, e As EventArgs) Handles btnStartCount.Click
        If Not String.IsNullOrEmpty(nudEstAB.Text) And Not String.IsNullOrEmpty(nudJumper.Text) And Not nudEstAB.Text <= 0 And Not nudJumper.Text <= 0 And btnStartCount.Text = "Start Count" Then
            TimerAB.Start()
            btnStartCount.Text = "Count Next"
            nudEstAB.Enabled = False
            nudJumper.Enabled = False
        ElseIf btnStartCount.Text = "Count Next" Then
            btnStartCount.Text = "Finish"
        ElseIf btnStartCount.Text = "Finish" Then
            TimerAB.Stop()
            btnStartCount.Enabled = False
            If CInt(txtA.Text) >= CInt(txtB.Text) Then
                txtAB.Text = CInt(txtA.Text) - CInt(txtB.Text)
            Else
                txtAB.Text = CInt(txtB.Text) - CInt(txtA.Text)
            End If
            btnUnlock.Enabled = True
        Else
            If String.IsNullOrEmpty(nudEstAB.Text) Or nudEstAB.Text <= 0 Then
                MsgBox("Enter the estimated number, or the estimated number isn't right.")
            ElseIf String.IsNullOrEmpty(nudJumper.Text) Or nudJumper.Text <= 0 Then
                MsgBox("Enter the jumper number, or the jumper number isn't right.")
            Else
                MsgBox("Somgthing's not right...")
            End If
        End If

    End Sub

    Private Sub TimerAB_Tick(sender As Object, e As EventArgs) Handles TimerAB.Tick
        jump = CInt(nudJumper.Text)
        If btnStartCount.Text = "Count Next" Then
            txtA.Text += jump
        ElseIf btnStartCount.Text = "Finish" Then
            txtB.Text += jump
        End If

    End Sub

    Private Sub BtnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        If Not String.IsNullOrEmpty(txtAB.Text) And Not String.IsNullOrEmpty(nudEstAB.Text) And CInt(txtAB.Text) = CInt(nudEstAB.Text) Then
            ToolStripStatusLabel1.Text = "Unlocked successfully!"
        Else
            ToolStripStatusLabel1.Text = "Unlocked failed"
        End If
        btnUnlock.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TimerAB.Stop()
        nudJumper.Text = 0
        txtA.Text = 0
        txtB.Text = 0
        txtAB.Text = 0
        nudEstAB.Text = 0
        nudEstAB.Enabled = True
        nudJumper.Enabled = True
        btnStartCount.Enabled = True
        btnUnlock.Enabled = False
        btnStartCount.Text = "Start Count"
        ToolStripStatusLabel1.Text = "Welcome to TimerCryptograph!"
    End Sub
End Class
