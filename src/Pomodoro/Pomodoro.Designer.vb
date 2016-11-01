<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pomodoro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pomodoro))
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'mainTimer
        '
        Me.mainTimer.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 40.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(16, 9)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(202, 91)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "25:00"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Honeydew
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Green
        Me.btnPlay.Location = New System.Drawing.Point(228, 26)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(68, 64)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "▶"
        Me.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.MistyRose
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.Red
        Me.btnPause.Location = New System.Drawing.Point(313, 26)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(68, 64)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "| |"
        Me.btnPause.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Azure
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnReset.Location = New System.Drawing.Point(396, 26)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(68, 64)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "↻"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCount.Location = New System.Drawing.Point(426, 110)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(38, 45)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "0"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(32, 110)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(349, 45)
        Me.progressBar.TabIndex = 6
        '
        'Pomodoro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 181)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pomodoro"
        Me.Text = "Pomodoro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTimer As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents progressBar As ProgressBar
End Class
