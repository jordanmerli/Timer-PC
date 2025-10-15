Imports System.IO
Public Class Form1
    Dim RemainTime As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbOperation.SelectedIndex = 0
    End Sub
    Private Sub bttnEnableDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEnableDisable.Click
        'If Val(Me.txtMin.Text) <= 0 Then Me.txtMin.Focus() : Exit Sub
        If cmbOperation.SelectedIndex = -1 Then MsgBox("Seleziona un'operazione", MsgBoxStyle.Exclamation, "Quindi?") : cmbOperation.Focus() : Exit Sub
        If Me.bttnEnableDisable.Text = "Abilita" Then
            Me.RemainTime = Val(Me.txtMin.Text) * 60
            Me.lblRemain.Visible = True
            Me.lblSec.Text = String.Format("in secondi: {0}", Val(Me.txtMin.Text) * 60)
            Me.timerOperate.Start()
            Me.bttnEnableDisable.Text = "Disabilita"
            Me.bttnClose.Enabled = False
            Me.txtMin.Enabled = False
            Me.cmbOperation.Enabled = False
        Else
            Me.timerOperate.Stop()
            Me.RemainTime = 0
            Me.lblRemain.Visible = False
            Me.lblRemain.Text = "Secondi Rimasti: 0"
            Me.lblRemain.ForeColor = Color.Black
            Me.txtMin.BackColor = Color.Chartreuse
            Me.bttnEnableDisable.Text = "Abilita"
            Me.bttnClose.Enabled = True
            Me.txtMin.Enabled = True
            Me.cmbOperation.Enabled = True
        End If
    End Sub
    Private Sub txtMin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMin.TextChanged
        Me.lblSec.Text = String.Format("in secondi: {0}", Val(Me.txtMin.Text) * 60)
        ' Me.lblRemain.Text = String.Format("Second(s) Remain : {0}", Val(Me.txtMin.Text) * 60)
        Me.RemainTime = Val(Me.txtMin.Text) * 60
    End Sub
    Private Sub timerOperate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerOperate.Tick
        If Not RemainTime <= 0 Then
            RemainTime -= 1
            Me.lblRemain.Text = String.Format("Secondi Rimasti: {0}", RemainTime)
            Exit Sub
        ElseIf RemainTime = 0 Then
            Me.Close()
            If Me.cmbOperation.SelectedIndex = 0 Then 'Shutdown Computer
                System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0")
            ElseIf Me.cmbOperation.SelectedIndex = 1 Then 'Restart Computer
                System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0")
            ElseIf Me.cmbOperation.SelectedIndex = 2 Then 'Logoff Computer
                System.Diagnostics.Process.Start("shutdown.exe", "/l /f")
            ElseIf Me.cmbOperation.SelectedIndex = 3 Then ' Lock Workstation
                'System.Diagnostics.Process.Start("")
                Shell("Rundll32.exe User32.dll,LockWorkStation")
            ElseIf Me.cmbOperation.SelectedIndex = 4 Then 'Hibernate Computer
                Shell("rundll32.exe PowrProf.dll,SetSuspendState")
            ElseIf Me.cmbOperation.SelectedIndex = 5 Then 'Sleep Computer
                Shell("rundll32.exe powrprof.dll,SetSuspendState 0,1,0")
            ElseIf Me.cmbOperation.SelectedIndex = 6 Then 'Start Process
            ElseIf Me.cmbOperation.SelectedIndex = 7 Then 'Kill Process
                'task kill elenco processi
            End If
                Me.bttnEnableDisable.Text = "Abilita"
                timerOperate.Stop()
                Exit Sub
            End If
    End Sub
    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub
    Private Sub lblRemain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRemain.TextChanged
        If Me.lblRemain.Text = "Secondi Rimasti: 20" Then
            Me.lblRemain.ForeColor = Color.Red
            Me.txtMin.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.InitialDirectory = "Desktop"
        OpenFileDialog1.Filter = "All Files (*.*)|"
        OpenFileDialog1.FilterIndex = 1
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub
End Class
