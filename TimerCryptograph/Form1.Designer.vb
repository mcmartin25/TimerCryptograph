<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtTimeNow = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.TimerTimeNow = New System.Windows.Forms.Timer(Me.components)
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblEstAB = New System.Windows.Forms.Label()
        Me.lblAB = New System.Windows.Forms.Label()
        Me.txtAB = New System.Windows.Forms.TextBox()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.btnStartCount = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerAB = New System.Windows.Forms.Timer(Me.components)
        Me.lblJumper = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.nudJumper = New System.Windows.Forms.NumericUpDown()
        Me.nudEstAB = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.nudJumper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEstAB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTimeNow
        '
        Me.txtTimeNow.Enabled = False
        Me.txtTimeNow.Location = New System.Drawing.Point(108, 38)
        Me.txtTimeNow.Name = "txtTimeNow"
        Me.txtTimeNow.Size = New System.Drawing.Size(120, 22)
        Me.txtTimeNow.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LicenseToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Enabled = False
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Location = New System.Drawing.Point(48, 41)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(54, 12)
        Me.lblTimeNow.TabIndex = 2
        Me.lblTimeNow.Text = "Time Now"
        '
        'TimerTimeNow
        '
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(89, 99)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(13, 12)
        Me.lblA.TabIndex = 4
        Me.lblA.Text = "A"
        '
        'txtA
        '
        Me.txtA.Enabled = False
        Me.txtA.Location = New System.Drawing.Point(108, 96)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(120, 22)
        Me.txtA.TabIndex = 3
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(89, 131)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(13, 12)
        Me.lblB.TabIndex = 6
        Me.lblB.Text = "B"
        '
        'txtB
        '
        Me.txtB.Enabled = False
        Me.txtB.Location = New System.Drawing.Point(108, 128)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(120, 22)
        Me.txtB.TabIndex = 5
        '
        'lblEstAB
        '
        Me.lblEstAB.AutoSize = True
        Me.lblEstAB.Location = New System.Drawing.Point(51, 195)
        Me.lblEstAB.Name = "lblEstAB"
        Me.lblEstAB.Size = New System.Drawing.Size(51, 12)
        Me.lblEstAB.TabIndex = 10
        Me.lblEstAB.Text = "Est. A - B"
        '
        'lblAB
        '
        Me.lblAB.AutoSize = True
        Me.lblAB.Location = New System.Drawing.Point(71, 163)
        Me.lblAB.Name = "lblAB"
        Me.lblAB.Size = New System.Drawing.Size(31, 12)
        Me.lblAB.TabIndex = 8
        Me.lblAB.Text = "A - B"
        '
        'txtAB
        '
        Me.txtAB.Enabled = False
        Me.txtAB.Location = New System.Drawing.Point(108, 160)
        Me.txtAB.Name = "txtAB"
        Me.txtAB.Size = New System.Drawing.Size(120, 22)
        Me.txtAB.TabIndex = 7
        '
        'btnUnlock
        '
        Me.btnUnlock.Enabled = False
        Me.btnUnlock.Location = New System.Drawing.Point(108, 238)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(75, 23)
        Me.btnUnlock.TabIndex = 11
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'btnStartCount
        '
        Me.btnStartCount.Location = New System.Drawing.Point(27, 238)
        Me.btnStartCount.Name = "btnStartCount"
        Me.btnStartCount.Size = New System.Drawing.Size(75, 23)
        Me.btnStartCount.TabIndex = 12
        Me.btnStartCount.Text = "Start Count"
        Me.btnStartCount.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 289)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(187, 17)
        Me.ToolStripStatusLabel1.Text = "Welcome to TimerCryptograph!"
        '
        'TimerAB
        '
        Me.TimerAB.Interval = 1000
        '
        'lblJumper
        '
        Me.lblJumper.AutoSize = True
        Me.lblJumper.Location = New System.Drawing.Point(63, 70)
        Me.lblJumper.Name = "lblJumper"
        Me.lblJumper.Size = New System.Drawing.Size(39, 12)
        Me.lblJumper.TabIndex = 15
        Me.lblJumper.Text = "Jumper"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(189, 238)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'nudJumper
        '
        Me.nudJumper.Location = New System.Drawing.Point(108, 68)
        Me.nudJumper.Name = "nudJumper"
        Me.nudJumper.Size = New System.Drawing.Size(120, 22)
        Me.nudJumper.TabIndex = 17
        '
        'nudEstAB
        '
        Me.nudEstAB.Location = New System.Drawing.Point(108, 192)
        Me.nudEstAB.Name = "nudEstAB"
        Me.nudEstAB.Size = New System.Drawing.Size(120, 22)
        Me.nudEstAB.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.nudEstAB)
        Me.Controls.Add(Me.nudJumper)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblJumper)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStartCount)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.lblEstAB)
        Me.Controls.Add(Me.lblAB)
        Me.Controls.Add(Me.txtAB)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.txtTimeNow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TimerCryptograph"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.nudJumper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEstAB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTimeNow As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents TimerTimeNow As Timer
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblA As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblB As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblEstAB As Label
    Friend WithEvents lblAB As Label
    Friend WithEvents txtAB As TextBox
    Friend WithEvents btnUnlock As Button
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStartCount As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TimerAB As Timer
    Friend WithEvents lblJumper As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents nudJumper As NumericUpDown
    Friend WithEvents nudEstAB As NumericUpDown
End Class
