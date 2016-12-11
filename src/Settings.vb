Public Class Settings
    Dim INI_File As New IniFile(Application.StartupPath + "/config.ini")
    Dim SteamID As Integer = 0
    Dim Slot As Integer = 0
    Dim SteamDir As String = Nothing
    Dim CustomBackupDir As String = "Default"

    Private Sub Settings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not System.IO.File.Exists(Application.StartupPath & "/config.ini") Then
            System.IO.File.Create(Application.StartupPath & "/config.ini").Dispose()
            INI_File.WriteInteger("Steam3ID", "User", 0)
            INI_File.WriteInteger("Slot", "LatestSlot", 0)
            INI_File.WriteString("Steam", "Directory", Nothing)
            INI_File.WriteString("Backup", "Directory", "Default")
            INI_File.WriteString("AppSettings", "ShowPadder", "False")
            Me.Opacity = 100
        Else
            If INI_File.GetString("AppSettings", "ShowPadder", "False") = "True" Then
                Main.Show()
                Me.Close()
            Else
                initializer.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBrowseDir_Click(sender As Object, e As EventArgs) Handles btnBrowseDir.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Specify the Steam Installation directory."}
Retry:
        Select Case FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                If System.IO.File.Exists(FBD.SelectedPath & "/Steam.exe") Then
                    txtDir.Text = FBD.SelectedPath
                Else
                    Select Case MessageBox.Show("This does not seem to be a valid directory.", "Steam Directory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        Case Windows.Forms.DialogResult.Retry
                            GoTo retry
                    End Select
                End If

        End Select
    End Sub

    Private Sub btnBrowseBackup_Click(sender As Object, e As EventArgs) Handles btnBrowseBackup.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Specify a custom Backup directory."}
Retry:
        Select Case FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                txtBackup.Text = FBD.SelectedPath
        End Select
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If txtID.Text = Nothing Then
            MessageBox.Show("Please specify a Steam 3 ID.")
            Exit Sub
        Else
            SteamID = txtID.Text
        End If
        If txtDir.Text = Nothing Then
            MessageBox.Show("Please specify a Steam Installation Directory.")
            Exit Sub
        Else
            SteamDir = txtDir.Text
        End If
        If txtBackup.Text = Nothing Then
            CustomBackupDir = "Default"
        Else
            CustomBackupDir = txtBackup.Text
        End If

        Select Case MessageBox.Show("Are these settings correct? Rocksmith will start and the application will exit.", "Finished?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select

        INI_File.WriteInteger("Steam3ID", "User", SteamID)
        INI_File.WriteString("Steam", "Directory", SteamDir)
        INI_File.WriteString("Backup", "Directory", CustomBackupDir)

        If chkPadder.Checked Then
            INI_File.WriteString("AppSettings", "ShowPadder", "True")
            Main.Show()
            Me.Close()
        Else
            initializer.Show()
            Me.Close()
        End If

        
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.steamidfinder.com/")
    End Sub

    
End Class