Public Class Main
    Dim isReadOnly As Boolean = False

    Dim INI_File As New IniFile(Application.StartupPath + "/config.ini")

    Dim SteamID As Integer
    Dim SteamDir As String
    Dim BackupDir As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CheckFile As New System.IO.FileInfo(Application.StartupPath & "/config.ini")
        If CheckFile.IsReadOnly Then
            MessageBox.Show("The config file is set to read-only. This program won't be able to write to the file.")
            isReadOnly = True
        End If

        If isReadOnly = True Then
            btnChangeID.Enabled = False
            btnSteamDir.Enabled = False
            btnBackupDir.Enabled = False
            chkPadder.Enabled = False
            lblReadOnly.Visible = True
        End If

        SteamID = INI_File.GetInteger("Steam3ID", "User", 0)
        SteamDir = INI_File.GetString("Steam", "Directory", Nothing)
        BackupDir = INI_File.GetString("Backup", "Directory", "Default")

        If BackupDir = "Default" Then
            BackupDir = SteamDir & "/userdata/" & SteamID & "/221680/remote"
        End If

        txtID.Text = SteamID
        txtSteamDir.Text = SteamDir
        txtBackupDir.Text = BackupDir
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnChangeID_Click(sender As Object, e As EventArgs) Handles btnChangeID.Click
        Select Case MessageBox.Show("Is this correct?", "RocksmithBackup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                SteamID = txtID.Text
            Case Windows.Forms.DialogResult.No
                txtID.Clear()
        End Select
    End Sub

    Private Sub btnSteamDir_Click(sender As Object, e As EventArgs) Handles btnSteamDir.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Select the Steam installation directory."}
Retry:
        Select FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                If System.IO.File.Exists(FBD.SelectedPath & "/Steam.exe") Then
                    txtSteamDir.Text = FBD.SelectedPath
                Else
                    Select Case MessageBox.Show("This does not seem to be a valid directory.", "Steam Directory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        Case Windows.Forms.DialogResult.Retry
                            GoTo retry
                    End Select
                End If
        End Select
    End Sub

    Private Sub btnBackupDir_Click(sender As Object, e As EventArgs) Handles btnBackupDir.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Select a backup directory."}
        Select Case FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                BackupDir = FBD.SelectedPath
                txtBackupDir.Text = FBD.SelectedPath
        End Select
    End Sub
    Private Sub btnDefaultBackup_Click(sender As Object, e As EventArgs) Handles btnDefaultBackup.Click
        txtBackupDir.Text = "Default"
    End Sub

    Private Sub btnSaveLaunch_Click(sender As Object, e As EventArgs) Handles btnSaveLaunch.Click
        If Not txtID.Text = Nothing Then
            INI_File.WriteInteger("Steam3ID", "User", 0)
        End If
        If Not txtSteamDir.Text = Nothing Then
            INI_File.WriteString("Steam", "Directory", SteamDir)
        End If
        If Not txtBackupDir.Text = Nothing Then
            If Not txtBackupDir.Text = "Defualt" Then
                INI_File.WriteString("Backup", "Directory", BackupDir)
            Else

            End If

        End If
        If Not chkPadder.Checked Then
            INI_File.WriteString("AppSettings", "ShowPadder", "False")
        End If

        Me.Hide()
        initializer.Show()
    End Sub

    Private Sub btnLaunch_Click_1(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Me.Hide()
        initializer.Show()
    End Sub
End Class