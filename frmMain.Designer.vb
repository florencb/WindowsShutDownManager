<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.pnlDisplayTime = New System.Windows.Forms.Panel()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.pnlSelectAction = New System.Windows.Forms.Panel()
        Me.rdbShutDown = New System.Windows.Forms.RadioButton()
        Me.rdbRestart = New System.Windows.Forms.RadioButton()
        Me.rdbLogOff = New System.Windows.Forms.RadioButton()
        Me.pnlSetTime = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMinutes = New System.Windows.Forms.ComboBox()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrDisplayTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCompareTime = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDisplayTime.SuspendLayout()
        Me.pnlSelectAction.SuspendLayout()
        Me.pnlSetTime.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDisplayTime
        '
        Me.pnlDisplayTime.BackColor = System.Drawing.Color.Teal
        Me.pnlDisplayTime.Controls.Add(Me.lblCurrentTime)
        Me.pnlDisplayTime.ForeColor = System.Drawing.Color.White
        Me.pnlDisplayTime.Location = New System.Drawing.Point(33, 23)
        Me.pnlDisplayTime.Name = "pnlDisplayTime"
        Me.pnlDisplayTime.Size = New System.Drawing.Size(339, 72)
        Me.pnlDisplayTime.TabIndex = 0
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(38, 17)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(301, 39)
        Me.lblCurrentTime.TabIndex = 0
        Me.lblCurrentTime.Text = "Current Time"
        '
        'pnlSelectAction
        '
        Me.pnlSelectAction.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnlSelectAction.Controls.Add(Me.rdbShutDown)
        Me.pnlSelectAction.Controls.Add(Me.rdbRestart)
        Me.pnlSelectAction.Controls.Add(Me.rdbLogOff)
        Me.pnlSelectAction.ForeColor = System.Drawing.Color.White
        Me.pnlSelectAction.Location = New System.Drawing.Point(33, 111)
        Me.pnlSelectAction.Name = "pnlSelectAction"
        Me.pnlSelectAction.Size = New System.Drawing.Size(339, 72)
        Me.pnlSelectAction.TabIndex = 1
        '
        'rdbShutDown
        '
        Me.rdbShutDown.AutoSize = True
        Me.rdbShutDown.Location = New System.Drawing.Point(245, 28)
        Me.rdbShutDown.Name = "rdbShutDown"
        Me.rdbShutDown.Size = New System.Drawing.Size(73, 17)
        Me.rdbShutDown.TabIndex = 2
        Me.rdbShutDown.TabStop = True
        Me.rdbShutDown.Text = "Shutdown"
        Me.rdbShutDown.UseVisualStyleBackColor = True
        '
        'rdbRestart
        '
        Me.rdbRestart.AutoSize = True
        Me.rdbRestart.Location = New System.Drawing.Point(135, 28)
        Me.rdbRestart.Name = "rdbRestart"
        Me.rdbRestart.Size = New System.Drawing.Size(59, 17)
        Me.rdbRestart.TabIndex = 1
        Me.rdbRestart.TabStop = True
        Me.rdbRestart.Text = "Restart"
        Me.rdbRestart.UseVisualStyleBackColor = True
        '
        'rdbLogOff
        '
        Me.rdbLogOff.AutoSize = True
        Me.rdbLogOff.Location = New System.Drawing.Point(20, 28)
        Me.rdbLogOff.Name = "rdbLogOff"
        Me.rdbLogOff.Size = New System.Drawing.Size(60, 17)
        Me.rdbLogOff.TabIndex = 0
        Me.rdbLogOff.TabStop = True
        Me.rdbLogOff.Text = "Log Off"
        Me.rdbLogOff.UseVisualStyleBackColor = True
        '
        'pnlSetTime
        '
        Me.pnlSetTime.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pnlSetTime.Controls.Add(Me.Label4)
        Me.pnlSetTime.Controls.Add(Me.Label3)
        Me.pnlSetTime.Controls.Add(Me.Label2)
        Me.pnlSetTime.Controls.Add(Me.cboMinutes)
        Me.pnlSetTime.Controls.Add(Me.cboHours)
        Me.pnlSetTime.ForeColor = System.Drawing.Color.White
        Me.pnlSetTime.Location = New System.Drawing.Point(33, 208)
        Me.pnlSetTime.Name = "pnlSetTime"
        Me.pnlSetTime.Size = New System.Drawing.Size(339, 72)
        Me.pnlSetTime.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Minutes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time Set For:"
        '
        'cboMinutes
        '
        Me.cboMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMinutes.FormattingEnabled = True
        Me.cboMinutes.Location = New System.Drawing.Point(277, 26)
        Me.cboMinutes.Name = "cboMinutes"
        Me.cboMinutes.Size = New System.Drawing.Size(51, 21)
        Me.cboMinutes.TabIndex = 1
        Me.cboMinutes.Text = "0"
        '
        'cboHours
        '
        Me.cboHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Location = New System.Drawing.Point(165, 25)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(45, 21)
        Me.cboHours.TabIndex = 0
        Me.cboHours.Text = "0"
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.ForeColor = System.Drawing.Color.White
        Me.pnlStatus.Location = New System.Drawing.Point(33, 297)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(339, 72)
        Me.pnlStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(27, 26)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(92, 16)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status: Ready"
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.DimGray
        Me.btnSet.FlatAppearance.BorderSize = 0
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Location = New System.Drawing.Point(54, 386)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 4
        Me.btnSet.Text = "&Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(169, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(287, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tmrDisplayTime
        '
        Me.tmrDisplayTime.Enabled = True
        '
        'tmrCompareTime
        '
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(402, 423)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlSetTime)
        Me.Controls.Add(Me.pnlSelectAction)
        Me.Controls.Add(Me.pnlDisplayTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Shutdown Manager"
        Me.pnlDisplayTime.ResumeLayout(False)
        Me.pnlDisplayTime.PerformLayout()
        Me.pnlSelectAction.ResumeLayout(False)
        Me.pnlSelectAction.PerformLayout()
        Me.pnlSetTime.ResumeLayout(False)
        Me.pnlSetTime.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDisplayTime As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents pnlSelectAction As System.Windows.Forms.Panel
    Friend WithEvents rdbShutDown As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRestart As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLogOff As System.Windows.Forms.RadioButton
    Friend WithEvents pnlSetTime As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents cboHours As System.Windows.Forms.ComboBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrDisplayTime As System.Windows.Forms.Timer
    Friend WithEvents tmrCompareTime As System.Windows.Forms.Timer

End Class
