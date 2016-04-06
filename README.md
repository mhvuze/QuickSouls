# QuickSouls
Simple quicksave utility for Dark Souls games (PC), written in C#. Press hotkey to do a quicksave, leave to main menu if you want to reload and press hotkey to restore quicksave. This will NOT save a 1:1 game state but killed enemies, found items etc. are preserved.

![alt tag](http://i.imgur.com/amdJlG3.png)

Important
--------
* While there shouldn't be any issues like accidental savedata loss, you use this tool at your very own responsibility.
* No idea if this causes issues with the online component of the game, I never used nor cared for it.
* Try installing .NET Framework 4.5 if some features do not work for you, that's the target framework I used.

Notes
--------
* Dark Souls: PTDE and Dark Souls III implementation have been tested by me somewhat throughly, Dark Souls II and SOTFS not however.
* Modifier hotkeys do not work properly for the time being, so be aware of that. Function keys work wonderfully for me and I haven't tested anything else really.
* If you compile yourself, place sound.wav into the executable directory.
* Deleting QuickSouls.ini should resolve any issues concerning the tool configuration.

Planned
--------
* Verify Dark Souls II functionality.
* Verify Dark Souls II: SOTFS functionality.

Special Thanks
--------
Icon by [shout4silence](http://www.nexusmods.com/darksouls/mods/293/), included notification sound by [opm](https://www.freesound.org/people/opm/sounds/2105/). Hotkey selection class by [Telrunya](http://www.codeproject.com/Articles/15085/A-simple-hotkey-selection-control-for-NET). Low level hook (so it works for fullscreen as well) by [StormySpike](http://www.codeproject.com/Articles/19004/A-Simple-C-Global-Low-Level-Keyboard-Hook).
