<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblSec = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbOperation = New System.Windows.Forms.ComboBox()
        Me.bttnEnableDisable = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.lblRemain = New System.Windows.Forms.Label()
        Me.timerOperate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSec
        '
        Me.lblSec.Location = New System.Drawing.Point(9, 38)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(195, 19)
        Me.lblSec.TabIndex = 2
        Me.lblSec.Text = "in secondi: 300"
        Me.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cmbOperation)
        Me.GroupBox2.Controls.Add(Me.bttnEnableDisable)
        Me.GroupBox2.Controls.Add(Me.bttnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 101)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestione Operazioni"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(177, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(6, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 7
        '
        'cmbOperation
        '
        Me.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperation.FormattingEnabled = True
        Me.cmbOperation.Items.AddRange(New Object() {"Spegni", "Riavvia", "Disconnetti", "Blocca", "Iberna", "Sospendi", "FAULT *** Esegui -> ***", "FAULT *** Interrompi processo -> ***"})
        Me.cmbOperation.Location = New System.Drawing.Point(6, 19)
        Me.cmbOperation.Name = "cmbOperation"
        Me.cmbOperation.Size = New System.Drawing.Size(198, 21)
        Me.cmbOperation.TabIndex = 4
        '
        'bttnEnableDisable
        '
        Me.bttnEnableDisable.Location = New System.Drawing.Point(6, 74)
        Me.bttnEnableDisable.Name = "bttnEnableDisable"
        Me.bttnEnableDisable.Size = New System.Drawing.Size(90, 21)
        Me.bttnEnableDisable.TabIndex = 5
        Me.bttnEnableDisable.Text = "Abilita"
        Me.bttnEnableDisable.UseVisualStyleBackColor = True
        '
        'bttnClose
        '
        Me.bttnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnClose.Location = New System.Drawing.Point(114, 74)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(90, 21)
        Me.bttnClose.TabIndex = 6
        Me.bttnClose.Text = "Chiudi"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'lblRemain
        '
        Me.lblRemain.BackColor = System.Drawing.Color.Transparent
        Me.lblRemain.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain.Location = New System.Drawing.Point(7, 184)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(204, 25)
        Me.lblRemain.TabIndex = 7
        Me.lblRemain.Text = "Secondi Rimasti: 0"
        Me.lblRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRemain.Visible = False
        '
        'timerOperate
        '
        Me.timerOperate.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tempo in minuti"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.Chartreuse
        Me.txtMin.Location = New System.Drawing.Point(95, 17)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(105, 20)
        Me.txtMin.TabIndex = 1
        Me.txtMin.Text = "5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSec)
        Me.GroupBox1.Controls.Add(Me.txtMin)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 62)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestione Timer"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 215)
        Me.Controls.Add(Me.lblRemain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Gestisci il Timer del tuo PC"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOperation As System.Windows.Forms.ComboBox
    Friend WithEvents bttnEnableDisable As System.Windows.Forms.Button
    Friend WithEvents lblRemain As System.Windows.Forms.Label
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents timerOperate As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
