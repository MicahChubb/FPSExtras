# Gun Switching
If you have implemented the gun tutorial found on the [Class Website here ]([https://pages.github.com/](https://sites.google.com/ed.act.edu.au/digital-applications/unity/the-fps-series/fp-shooting)https://sites.google.com/ed.act.edu.au/digital-applications/unity/the-fps-series/fp-shooting) you can add some gun switching with a couple of changes.
## gun.cs
Edit your gun.cs file to match my updated one. This one will scan for a camera object if there is none dragged in, this will help speed up rolling out your amount of guns
## gunSwitcher.cs
You need to add a gunSwitcher script in, make it like mine. **Read the comments in it for understanding.** This will go onto your camera object
## CharacterInput
- Double click on the blue⚡ named CharacterInput
- Add a new action
- Call it "WeaponChange" and make it a "Pass Through"
- Add a binding, click path > Mouse > Scroll Y
## Fill your list of guns
- Add different gun objects to your player, all with the camera as a parent
- Click on the camera and add your gun objects from your hierarchy into your list for your script

**You may want to edit my script to only allow them to use weapons they have unlocked in the game. This will require multiple lists 😊**
