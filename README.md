# Final Fantasy 1 Pixel Remaster Randomizer
This is a proof-of-concept key item randomizer for [Final Fantasy I (PR)](https://store.steampowered.com/app/1173770/FINAL_FANTASY/).

## Installation:
1. Install Final Fantasy Pixel Remaster from Steam.
2. Install [Memoria](https://github.com/Albeoris/Memoria.FFPR/) and export the game data by following [these instructions](https://github.com/Albeoris/Memoria.FFPR/#export).
3. Download and unpack the [FF1PRR archive](https://github.com/gameboy9/Memoria.FFPR/releases/download/0.1/FF1.PRR.zip) in the directory of your choice.
4. Run the .exe and set the `FF1 PR Folder` to the location of your game installation (usually `C:\Program Files (x86)\Steam\steamapps\common\FINAL FANTASY PR`)

## Usage:

![ff1prr](https://user-images.githubusercontent.com/42707378/146085575-6bc19bd1-0d48-4ed8-a3f5-c3a802993011.png)

Select the flags you like and press the `Randomize!` button. You do not need to restore the game to its base ("vanilla") configuration before randomizing, but if you want to turn off the randomizer and return your game to its original state, press the `Restore vanilla` button.

The bottom left corner of the program window will give you status information about the state of the randomizer. On slower computers, the program may take a second or two to complete randomization.

The `Seed` value controls the randomization. If you want to play the same game again, or wish to race against a friend, simply ensure the same flags are selected and use the same seed value as before. You may ignore the `Gameplay Flags` and `Cosmetic Flags` fields, as they are not currently used, but in the future you will be able to copy and paste a flagstring to ensure both copies of the game have the same flags set.

### Key Item randomization
The `Randomize Key Items` flag is the heart of the randomizer. This will change the locations of the key items and events necessary to progress in the game. For example, you normally obtain the Mystic Key from waking the Elf Prince, but you might instead obtain it from Dr. Unne in Melmond after trading him the Rosetta Stone. Like in the HMS Jayne randomizer (and unlike the NES FFR), the four Crystals are also included in this randomization; you could restore the power of Earth by talking with the Sage Sadda in his cave, or the power of Fire by defeating the Kraken.

As a guarantee, every Key Item is always obtainable in every seed. You may not need the nitro powder or even the Airship to complete the game (for example), but it will always be *possible* to obtain every item.

You begin your quest with the ship (the HMS Jayne) and with the bridge between Coneria and Pravoka already built. Accordingly, two potential Key Item locations will award you only a single Potion for completing their requirements.

To complete the game, you must find the Lute and the Mystic Key, and restore the powers of the four elemental Crystals. Then, proceed to the Temple of Chaos and complete the final dungeon.

### Shop and Treasure shuffle
At present, these flags do as they say: shuffle all possible chest contents or shop contents among their peers. There are a few quirks, though: the Masamune chest is excluded from the shuffle, and will always be found on the Tiamat floor of the Temple of Chaos (past); and a shop will not stock two of the same item.

If you want a greater challenge, you may optionally exclude the "new" items from shops, making things like Ether and Phoenix Down only obtainable from chests.

### Randomize Magic
This will shuffle the White and Black Magic spellbooks so any spell can appear at any level. Coneria will still stock all level 1 spells, but they could be Scourge, Blind, Firaga, and Stun just as easily as anything else.

If the `Keep Permissions` flag is checked, the spells will retain their casting restrictions (for example, only a Black Wizard may cast Flare). If unchecked, the same number of spells each level will be restricted, but they could be any spells (so a Red Mage could only learn two of the four 1st level White Magic spells, for example).

### Other flags
|Flag|Effect|
|----|------|
|Reduce Chaos HP|Chaos will have 9,600 HP instead of 20,000.|
|Harder bosses|Increase the HP of most bosses, excluding Chaos.|
|Fiends drop Ribbons|Defeating one of the four elemental Fiends will award a Ribbon in addition to a Key Item, but Ribbons will not appear in chests.|
|XP/Gil Boost|For faster games, inceases the amount of XP and Gil awarded in combat.|
|Rebalance item prices|Increases the price of the "new" items such as Ether and Phoenix Down to make them harder to access during the early game.|
|Restore crit rating|Sets the weapon critical hit rate to the originally intended value, which results in most endgame weapons aside from the Vorpal Sword and Sasuke's Katana having much lower chances to crit.|
|Wands add INT|To increase the value of weapons for caster classes, they provide a small INT bonus.|
|Reduce encounter rate|This restores the correct Ocean encounter rate of 1/3 that of land, and slightly decreases encounter chance on the overworld and dungeons, resulting in about 20% fewer encounters.|
|Cute Hats|You're cute.|

### Known Issues
This is a preview build of the randomizer, so there are presently several non-critical bugs or oddities.

- The canoe, bottled faerie, and airship can only be obtained from their vanilla locations.
- Certain locked doors are stubborn. If you obtain the mystic key from either of the dwarves, you must leave and re-enter Mt. Druegar to open the dwarven vault. The Northwest Castle treasury and Elfheim treasury can be opened only after defeating Astos or waking the Elf Prince.
- When you restore a Crystal, it will not light up on the menu, and when you defeat a Fiend, that Fiend's Crystal will light. For now, you'll have to write down which Crystals you have restored, as merely lighting them up in the menu will not grant access to Temple of Chaos (past).
- Some cutscenes have incorrect or misleading dialogue or have strange behavior.
- Currently, only the English language is supported. A future release will allow you to play in any language.

### More information
If you'd like to discuss the randomizer or follow its continued development, you're welcome to join the [official HMS Jayne and FF1PRR discord](https://discord.gg/kPxkH5W)!
