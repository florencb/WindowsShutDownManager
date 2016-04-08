Imports System.Diagnostics
Public Class frmMain
    Dim actionTime As Date
    Private Sub tmrDisplayTime_Tick(sender As Object, e As EventArgs) Handles tmrDisplayTime.Tick
        lblCurrentTime.Text = TimeOfDay.ToLongTimeString
    End Sub

    Private Sub tmrCompareTime_Tick(sender As Object, e As EventArgs) Handles tmrCompareTime.Tick
        If Now > actionTime Then

            If rdbLogOff.Checked = True Then
                Process.Start("Shutdown", "-l -t 01")
            End If

            If rdbRestart.Checked = True Then
                Process.Start("Shutdown", "-r -t 01")
            End If

            If rdbShutDown.Checked = True Then
                Process.Start("Shutdown", "-s -t 01")
            End If

        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim j As Integer

        For i = 0 To 23
            cboHours.Items.Add(i)
        Next

        For j = 0 To 59
            cboMinutes.Items.Add(j)
        Next
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        If CDec(cboHours.Text) > 0 Or CDec(cboMinutes.Text) > 0 Then
            actionTime = Now.AddMinutes(CDbl(cboHours.Text) * 60 + CDbl(cboMinutes.Text))
            tmrCompareTime.Enabled = True
            lblStatus.Text = "Status: The action is initiated for " + actionTime.ToLongTimeString
        Else
            lblStatus.Text = "Status: Please set time"
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tmrCompareTime.Enabled = False
        lblStatus.Text = "Status: The action is cancelled"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
