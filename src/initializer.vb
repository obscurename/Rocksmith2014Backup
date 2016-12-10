Public Class initializer
    Dim INI_File As New IniFile(Application.StartupPath + "/config.ini")

    Dim LatestSlot As Integer = 0
    Dim Steam3ID As Integer = 0
    Dim SteamDir As String = Nothing

    Dim SaveDirectory As String
    Dim BackupDirectory As String

    Private Sub initializer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Starting initialization."
        lblStatus.Text = "Checking for Ini"

        If System.IO.File.Exists(Application.StartupPath & "/config.ini") Then
            lblStatus.Text = "Ini exists."
        Else
            lblStatus.Text = "Ini does not exist. Running First-time setup."
            Settings.Show()
            Me.Close()
        End If

        lblStatus.Text = "Getting Steam3ID"
        Steam3ID = INI_File.GetInteger("Steam3ID", "User", 0)
        lblStatus.Text = "Steam3ID found. " & Steam3ID.ToString

        lblStatus.Text = "Getting Steam installation directory."
        SteamDir = INI_File.GetString("Steam", "Directory", Nothing)
        lblStatus.Text = "Steam installation directory found. " & SteamDir

        lblStatus.Text = "Checking latest backup slot"
        LatestSlot = INI_File.GetInteger("Slot", "LatestSlot", 0)
        lblStatus.Text = "Latest slot is " & LatestSlot.ToString

        SaveDirectory = SteamDir & "/userdata/" & Steam3ID & "/221680/remote"
        BackupDirectory = SteamDir & "/userdata/" & Steam3ID & "/221680/SaveBackup"

        lblStatus.Text = "Checking for backup folder."
        If Not System.IO.Directory.Exists(BackupDirectory) Then
            lblStatus.Text = "Directory does not exist. Creating."
            System.IO.Directory.CreateDirectory(BackupDirectory)
            LatestSlot = 0
            lblStatus.Text = "Directory created. Slot reset back to 0."
        End If

        lblStatus.Text = "Checking latest slot."

        If LatestSlot = 3 Then
            lblStatus.Text = "3 is latest, moving contents from slot 2 to 1."
            System.IO.Directory.Delete(BackupDirectory & "/Slot1", True)
            My.Computer.FileSystem.RenameDirectory(BackupDirectory & "/Slot2", "Slot1")

            lblStatus.Text = "3 is latest, moving contents from slot 3 to 2."
            My.Computer.FileSystem.RenameDirectory(BackupDirectory & "/Slot3", "Slot2")
           
            lblStatus.Text = "3 is latest, backing up to slot 3."
            System.IO.Directory.CreateDirectory(BackupDirectory & "/Slot3")
            My.Computer.FileSystem.CopyDirectory(SaveDirectory, BackupDirectory & "/Slot3")

            LatestSlot = 3

        ElseIf LatestSlot = 2 Then
            lblStatus.Text = "2 is latest, backing up to slot 3."
            System.IO.Directory.CreateDirectory(BackupDirectory & "/Slot3")
            My.Computer.FileSystem.CopyDirectory(SaveDirectory, BackupDirectory & "/Slot3")
            LatestSlot = 3
        ElseIf LatestSlot = 1 Then
            lblStatus.Text = "1 is latest, backing up to slot 2."
            System.IO.Directory.CreateDirectory(BackupDirectory & "/Slot2")
            My.Computer.FileSystem.CopyDirectory(SaveDirectory, BackupDirectory & "/Slot2")
            LatestSlot = 2
        Else
            lblStatus.Text = "No latest, backing up to slot 3."
            System.IO.Directory.CreateDirectory(BackupDirectory & "/Slot1")
            My.Computer.FileSystem.CopyDirectory(SaveDirectory, BackupDirectory & "/Slot1")
            LatestSlot = 1
        End If

        lblStatus.Text = "Finished backup, launching rocksmith."
        If System.IO.File.Exists(Application.StartupPath & "/Rocksmith.exe") Then
            Process.Start(Application.StartupPath & " /Rocksmith.exe")
        ElseIf System.IO.File.Exists(Application.StartupPath & "/Game.exe") Then
            Process.Start(Application.StartupPath & "/Game.exe")
        End If

        lblStatus.Text = "Saving config."
        INI_File.WriteInteger("Slot", "LatestSlot", LatestSlot)

        lblStatus.Text = "Exiting."
        Application.Exit()
    End Sub
End Class
