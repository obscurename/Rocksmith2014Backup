<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnSaveLaunch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnChangeID = New System.Windows.Forms.Button()
        Me.btnSteamDir = New System.Windows.Forms.Button()
        Me.txtSteamDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBackupDir = New System.Windows.Forms.Button()
        Me.txtBackupDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPadder = New System.Windows.Forms.CheckBox()
        Me.lblReadOnly = New System.Windows.Forms.Label()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.btnDefaultBackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveLaunch
        '
        Me.btnSaveLaunch.Location = New System.Drawing.Point(39, 167)
        Me.btnSaveLaunch.Name = "btnSaveLaunch"
        Me.btnSaveLaunch.Size = New System.Drawing.Size(183, 42)
        Me.btnSaveLaunch.TabIndex = 0
        Me.btnSaveLaunch.Text = "Save config && Launch Rocksmith"
        Me.btnSaveLaunch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Steam3ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(26, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(114, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnChangeID
        '
        Me.btnChangeID.Location = New System.Drawing.Point(146, 23)
        Me.btnChangeID.Name = "btnChangeID"
        Me.btnChangeID.Size = New System.Drawing.Size(57, 23)
        Me.btnChangeID.TabIndex = 3
        Me.btnChangeID.Text = "Change"
        Me.btnChangeID.UseVisualStyleBackColor = True
        '
        'btnSteamDir
        '
        Me.btnSteamDir.Location = New System.Drawing.Point(314, 66)
        Me.btnSteamDir.Name = "btnSteamDir"
        Me.btnSteamDir.Size = New System.Drawing.Size(57, 23)
        Me.btnSteamDir.TabIndex = 6
        Me.btnSteamDir.Text = "Change"
        Me.btnSteamDir.UseVisualStyleBackColor = True
        '
        'txtSteamDir
        '
        Me.txtSteamDir.Location = New System.Drawing.Point(26, 68)
        Me.txtSteamDir.Name = "txtSteamDir"
        Me.txtSteamDir.ReadOnly = True
        Me.txtSteamDir.Size = New System.Drawing.Size(282, 20)
        Me.txtSteamDir.TabIndex = 5
        Me.txtSteamDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Steam Directory"
        '
        'btnBackupDir
        '
        Me.btnBackupDir.Location = New System.Drawing.Point(271, 109)
        Me.btnBackupDir.Name = "btnBackupDir"
        Me.btnBackupDir.Size = New System.Drawing.Size(56, 23)
        Me.btnBackupDir.TabIndex = 9
        Me.btnBackupDir.Text = "Change"
        Me.btnBackupDir.UseVisualStyleBackColor = True
        '
        'txtBackupDir
        '
        Me.txtBackupDir.Location = New System.Drawing.Point(26, 111)
        Me.txtBackupDir.Name = "txtBackupDir"
        Me.txtBackupDir.ReadOnly = True
        Me.txtBackupDir.Size = New System.Drawing.Size(242, 20)
        Me.txtBackupDir.TabIndex = 8
        Me.txtBackupDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Backup Directory"
        '
        'chkPadder
        '
        Me.chkPadder.AutoSize = True
        Me.chkPadder.Checked = True
        Me.chkPadder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPadder.Location = New System.Drawing.Point(103, 144)
        Me.chkPadder.Name = "chkPadder"
        Me.chkPadder.Size = New System.Drawing.Size(173, 17)
        Me.chkPadder.TabIndex = 10
        Me.chkPadder.Text = "Show this form on every launch"
        Me.chkPadder.UseVisualStyleBackColor = True
        '
        'lblReadOnly
        '
        Me.lblReadOnly.AutoSize = True
        Me.lblReadOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadOnly.ForeColor = System.Drawing.Color.Red
        Me.lblReadOnly.Location = New System.Drawing.Point(230, 9)
        Me.lblReadOnly.Name = "lblReadOnly"
        Me.lblReadOnly.Size = New System.Drawing.Size(141, 16)
        Me.lblReadOnly.TabIndex = 11
        Me.lblReadOnly.Text = "Config is read only."
        Me.lblReadOnly.Visible = False
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(228, 167)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(111, 42)
        Me.btnLaunch.TabIndex = 12
        Me.btnLaunch.Text = "Launch Rocksmith"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'btnDefaultBackup
        '
        Me.btnDefaultBackup.Location = New System.Drawing.Point(328, 109)
        Me.btnDefaultBackup.Name = "btnDefaultBackup"
        Me.btnDefaultBackup.Size = New System.Drawing.Size(49, 23)
        Me.btnDefaultBackup.TabIndex = 13
        Me.btnDefaultBackup.Text = "Default"
        Me.btnDefaultBackup.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(378, 221)
        Me.Controls.Add(Me.btnDefaultBackup)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.lblReadOnly)
        Me.Controls.Add(Me.chkPadder)
        Me.Controls.Add(Me.btnBackupDir)
        Me.Controls.Add(Me.txtBackupDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSteamDir)
        Me.Controls.Add(Me.txtSteamDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangeID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveLaunch)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rocksmith Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveLaunch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeID As System.Windows.Forms.Button
    Friend WithEvents btnSteamDir As System.Windows.Forms.Button
    Friend WithEvents txtSteamDir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBackupDir As System.Windows.Forms.Button
    Friend WithEvents txtBackupDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkPadder As System.Windows.Forms.CheckBox
    Friend WithEvents lblReadOnly As System.Windows.Forms.Label
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents btnDefaultBackup As System.Windows.Forms.Button
End Class
