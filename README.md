# UnlockDelay

A plugin that locks certain doors at the start of the round for a specified amount of time.

# Installation

**[Smod2](https://github.com/Grover-c13/Smod2) must be installed for this to work.**

Grab the latest release [here.](https://github.com/Cyanox62/UnlockDelay/releases/latest)

Place the "UnlockDelay.dll" file in your sm_plugins folder.

# Config

| Config        | Value Type | Default | Description |
| :-------------: | :---------: | :---------: |:------ |
| dl_list| List | | The list of doors to be locked and for how long. Entries are in the format `doorname:delay` and are separated by commas. See [this page](https://github.com/Cyanox62/UnlockDelay/wiki/Door-Names) for a list of door names. Example: `CHECKPOINT_ENT:30` will lock the Entrence Zone Checkpoint for 30 seconds. |
