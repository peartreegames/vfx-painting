# VFX Painting

![](https://github.com/peartreegames/vfx-painting/blob/main/Docs/Painting_Editor_Trim.mp4)

![](https://github.com/peartreegames/vfx-painting/blob/main/Docs/Painting_Editor_Field_Trim.mp4)

More for an art project than a game, as the performance isn't that great (understandably).

## How it works

There are two cameras in the scene. The first sends the data to two Render Textures.
One, just a screenshot for the colors, the second a depth pass with the RBG values being the world positions.


![](https://github.com/peartreegames/vfx-painting/blob/main/Docs/rt-color.png)
![](https://github.com/peartreegames/vfx-painting/blob/main/Docs/rt-position.png)

Then a VFX graph uses those Render Textures to set colors and positions of individual paint brush strokes. 
With the size of the stroke being adjusted by the distance from the camera.

![](https://github.com/peartreegames/vfx-painting/blob/main/Docs/vfx-screenshot.png)

The second camera then only shows the VFX graphs outputs on the main display.
