# RocksmithBackup
Backup Rocksmith 2014 Steam saves with this tool.

It requires Steam & Rocksmith2014 for steam, but it does not run Rocksmith using Steam GameID, instead if runs Rocksmith2014 by the executable name. This application is made to be ran via steam.

# Setup
Setup requires the "Rocksmith2014.exe" name, so rename the original "Rocksmith2014.exe" to "Rocksmith.exe" or "Game.exe".

Put the "Rocksmith2014.exe" in the releases page into the Rocksmith 2014 game directory

If you're building yourself; build the application using VisualStudio or another compiler of your choice, rename "RocksmithBackup.exe" to "Rocksmith2014.exe" and put it into the game's directory.

When you run the program, it will require 2 more pieces of information from you:

Your Steam3 ID and the Steam installation directory.

You can get your Steam3 ID from the userdata folder, or using [this tool](http://www.steamidfinder.com/).

The Steam installation directory varies depending on where you installed Steam, generally, just select the folder that includes "Userdata" subfolder & "Steam.exe".

# FAQ

Q: Why Steam only?  
A: I only have the Steam version. If there exists other versions, send me a message on reddit (/u/ecaep42) and tell me where the save files are located for other versions.

Q: Any chances of it working for anything other than Steam?  
A: If you made an insane setup for Rocksmith 2014 that is identical to the way Steam saves the game's save files, it might. Otherwise, don't count on it. This tool requires the Steam3ID for a user for the folder that contains ext. game data, because Rocksmith 2014 does not save in My Documents or %AppData% locations.

Q: Will it work for (future update)?  
A: I don't know, if it stops working for me I'll update it.

# Annoying "The catch"

There's not catch to using this application, it just copys the save data to a folder, and saves 3 different versions (1 being oldest, 3 being latest.) If your game corrupts, it is a CDLC fault, not this program's. I cannot guarrantee a backup will be corrupt-free (if you try to restart the game 3 times because you got annoyed, this will overwrite all 3 backups with a corrupted backup.) but this program does try to prevent corruptions via backups.

Of course, if your save files break or get corrupted (either from this program or from a CLDC), it is **not my fault**, as the source does not overwrite the original save file.
