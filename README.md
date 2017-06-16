Warning: Avast & Norton detect v2 as a false virus, it's almost 99% because of the registry lookup. If you don't believe me, view the source & build it yourself.

# RocksmithBackup
Backup Rocksmith 2014 Steam saves with this tool.

Manage backups, restore from within the application, and the setup is about 98% more easier than before, instincively suggesting that the previous time setting it up was 1% easy which it was.

# Setup
Setup uses the "Rocksmith2014.exe" name for startup backup, so; rename the original "Rocksmith2014.exe" to "Rocksmith.exe" or "Game.exe". The former being the better idea.

On initial startup, it will attempt to figure out the save file location (using Registry). If you ues multiple profiles, it'll ask for you to intervene with the correct Steam3 ID, otherwise it should run properly.

If you want to skip the Autoboot Delay, create a new text file in the same directory named "skipdelay.txt".

# FAQ

Q: Why Steam only?  
A: I only have the Steam version. 

Q: Any chances of it working for anything other than Steam?  
A: If you made an insane setup for Rocksmith 2014 that is identical to the way Steam saves the game's save files, it might. Otherwise, don't count on it. If you want to help, open an issue and tell me where the save files are located for other versions. However, if they are located at the root of the game, I know they are there. I have not found a good method for detecting them automatically.

Q: Will it work for <future update>?  
A: If they change how the save is managed, it will need to be patched, otherwise it should work without updating, as it bases itself on directory-based backups, meaning it copies the directory the save is located in to the directory where you store the backups at.

# Annoying "The catch"

There's no catch to using this application, it just backs up your save data. If your save becomes corrupt, it is most likely a CDLC fault, not this program's. I cannot guarrantee a backup will be corrupt-free, if you try to restore from a backup that has been corrupted. This program does not edit save files in any way and does not overwrite them unless being restored.

Of course, if your save files break or get corrupted (either from this program or from a CLDC), it is **not my fault**, as the source is not intended to do such a thing.
