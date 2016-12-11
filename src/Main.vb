﻿Public Class Main
    Dim isReadOnly As Boolean = False
    Dim ConfigModified As Boolean = False

    Dim Steam3ID As Integer
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
                If Not ConfigModified = True Then
                    ConfigModified = True
                    btnLaunch.Text = "Save config & Launch Rocksmith"
                End If
                Steam3ID = txtID.Text
            Case Windows.Forms.DialogResult.No
                txtID.Clear()
        End Select
    End Sub

    Private Sub btnSteamDir_Click(sender As Object, e As EventArgs) Handles btnSteamDir.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Select the Steam installation directory."}
        Select Case FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                If Not ConfigModified = True Then
                    ConfigModified = True
                    btnLaunch.Text = "Save config & Launch Rocksmith"
                End If
                SteamDir = FBD.SelectedPath
                txtSteamDir.Text = FBD.SelectedPath
        End Select
    End Sub

    Private Sub btnBackupDir_Click(sender As Object, e As EventArgs) Handles btnBackupDir.Click
        Dim FBD As New FolderBrowserDialog With {.Description = "Select a backup directory."}
        Select Case FBD.ShowDialog
            Case Windows.Forms.DialogResult.OK
                If Not ConfigModified = True Then
                    ConfigModified = True
                    btnLaunch.Text = "Save config & Launch Rocksmith"
                End If
                BackupDir = FBD.SelectedPath
                txtBackupDir.Text = FBD.SelectedPath
        End Select
    End Sub
End Class