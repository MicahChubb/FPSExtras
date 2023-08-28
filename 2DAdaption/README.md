# 2D Adaption
This is to allow you to take the New Input system and to adapt it to a 2D style platformer. This allows you to map multiple inputs to the same actions, such as keyboard as well as a game controller. For this case we will use the [old tutorial found here](https://sites.google.com/ed.act.edu.au/digital-applications/unity/old-unity-stuff/movement) as the base. You should follow it and then adjust when you get up to making the PlayerMovement script.
First set up your CharacterInput by rightclicking in the assests section and going to Create > Input Actions. Name it CharacterInput, tick "Generate C# class" and hit apply.
## CharacterInput
- Double click on the blue⚡ named CharacterInput
- Add a new Action Map called Player
- Add a new Action called Move
  - Action Type: Pass Through
  - Control Type: Any
  - Add a 1D Axis Composite called Keys
    - Set Negative to the A key
    - Set Positive to the D key
- Add a new Action called Jump
  - Action type: Button
  - Add a new binding and set it to W
## PlayerMovement.cs
Edit your PlayerMovement.cs file to match my updated one. This update does:
- Connects the CharachterInput
- Reads through the new input system
- Applies the values it reads to the PlayerMovement as an equivalent to how the old input system did
## Adding a game controller
- Double click on the blue⚡ named CharacterInput
- Add a new Binding to the Move action
  - Set it to Left Stick/X (The X stands for X axis, so it should be only horizontal move)
- Add a new Binding to the Jump action
  - Set it to be the Button East (B button on an X-Box controller)
