# Match3Practice
A practice to make a match 3 game using Unity.
This repository includes only Assets and ProjectSettings.
In Unity:
  1. Create an empty object called "BoardManager" and attach "BoardManager.cs" in Scripts folder into the object
  2. Create 7 prefabs using the 7 images in Art/character folder, each should be attached with "Character.cs" in Scripts and need a 2D Box collider
  3. Create a prefab using the image called "popup_base" in Art/ui_assets folder
  4. Select BoardManager, set character size to 7 and drag the 7 character prefabs into the character variables
  5. Drag the popup_base prefab into the tile variable of BoardManager
  6. Should be all set for now
