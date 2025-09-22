# Sprite Flight: Asteroids!

## Play the Game
**Unity Play Link**: https://play.unity.com/en/games/cdbeeeea-a20b-4235-ac0f-82f61f468755/sprite-flight-asteroids

## Game Overview
This is a 2D space game very similar to the classic arcade game "Asteroids". You are a small rocket-ship trying to survive the perils of incoming asteroids in space! Objective: Stay alive as long as possible. 

### Controls
- Left tap/mouse-click enables thrusters, propelling you forward.

### How to Play
Click/tap the screen in the area/direction you would like to propel the ship in. Avoid incoming asteroids; otherwise, your spacecraft will explode! If you crash, click the restart button at the top of the screen under the
score and the galaxy will be reset. 

## Base Game Implementation

### Completion Status
- [x] Player Movement & Controls
- [x] Obstacle Spawning System
- [x] Collision Detection
- [x] Score System
- [x] Game-Over State
There are no incomplete features at this time.

### Known Bugs
There are no known bugs at this time. 

### Limitations
- Because my sprites were custom-made, the rigidbodies had a difficult time mapping the boundaries of the sprites, and I wasn't exactly sure if there was a way I could free-form draw the borders of each sprite, so I
left it looking slightly wonky. Either way, it didn't seem to really impact interactions/collisions between the rocketship and the asteroids. 

## Extensions Implemented

### 1. Create a Cohesive Color Scheme (2)
**Implementation**: I went for a pastel color palette that complemented the galaxy background. 
**Game Impact**: Makes the overall gaming experience more enjoyable to look at.
**Technical Details**: I used the color match tool to apply the same colors across buttons and borders. I did this by selecting each game object, and then under the sprite renderer section, I selected the color option and went from there.
**Known Issues**: None that are known. 

### 2. Swap Out Your Sprites (3)
**Implementation**: I replaced Unity's default shapes with custom sprites that I hand-drew. I did this for the background, rocket ship, flame, and asteroids sprites. 
**Game Impact**: Adds personality to the overall game experience/narrative. Gives the feel of a classic 2D game. 
**Technical Details**: The sprites were hand-drawn on Notability, and then the background was deleted from the images through Canva's AI background removal feature. I then took the translucent sprite models and dragged them onto the appropriate sprite field under each object's sprite renderer section. 
**Known Issues**: Listed in "Limitations," but overall didn't affect the gameplay experience.

### 3. Destroy the Borders on Game Over (4)
**Implementation**: Disabled the border parent object when the player collides with an object, such as the asteroids or border.
**Game Impact**: Adds an extra element of aesthetic design and contributes to the feeling of game completion.
**Technical Details**: A call was added to the border parent within the OnCollisionEnter2D() method of the PlayerController's script. 
**Known Issues**: None that are known.

### 4. Add Ambient Background Particles (4)
**Implementation**: Added a particle system to simulate stars moving in the galactic background.
**Game Impact**: Creates a living atmosphere within the game. Creates more depth in the environment. 
**Technical Details**: Created a Unity particle system with a low emission rate that generates particles of small, yet random sizes and had them move in randomized directions to add atmospheric depth.
**Known Issues**: None that are known. 

### 5. Increase Difficulty Over Time (5)
**Implementation**: Gradually increases the speed of the asteroids as they collide with each other and with the borders. 
**Game Impact**: Makes gameplay more difficult as it progresses, which in turn adds an element of competitiveness that keeps gameplay engaging. 
**Technical Details**: I set the bounciness property to something slightly higher in my 2D physics material component.
**Known Issues**: None that are known. 

### 6. Add Sound Effects and Background Music (5)
**Implementation**: I imported audio files from the tutorial and attached them to audio sources within objects as sound effects. Background music is also looped throughout play.
**Game Impact**: Makes gameplay more engaging and creates a more immersive space experience that calls back to old arcade game sounds. 
**Technical Details**: Background music was set to loop. Added audio source components to each object with a sound effect, and assigned the sound clips to the audio resources respectively.
**Known Issues**: None that are known. 

### 7. Animate the Booster Graphic with Audio (6)
**Implementation**: I added an individual audio source to the booster flame underneath the rocket ship parent object. Then I uploaded the sound effect that the Unity tutorial provided me with as the audio resource.
**Game Impact**: Adds an extra level of immersion to gameplay, making it feel like player interaction has an actual effect on the environment.
**Technical Details**: Gave the booster flame an audio source component and then uploaded the provided sound clip to its audio resource section. When the booster flame is enabled (upon click/touch), the sound is also enabled.
**Known Issues**: None that are known. 

## Credits
- All external sources and assets were provided through the Unity tutorial. The background, rocketship, and asteroid sprites were all hand-drawn by me.

## Reflection
**Total Points Claimed**: 80% + 29% = 109%
**Challenges**: I think the most difficult part was navigating Unity's interface. There were a lot of times where the instructions were overwhelming because there was so much to handle in Unity, and so much about the 
specific customization options and features that I felt like I had never heard of or didn't understand the use of, which discouraged me from exploring how things like, for example, animating sprites worked. 
**Learning Outcomes**: I have never coded in C# before, so I feel like, through this experience, I was able to easily pick up the language because it was being applied in an engaging way. I have done game design on a smaller
scale before with block coding, so this was a whole new learning experience. I also think it was really valuable to learn class-platform development. I wasn't expecting the tutorial to cover it, but now I have a better
overall understanding of how these things are implemented in game design, which will be helpful when I apply to positions in the game industry. I'm hoping to apply my newfound skills in Unity and C# to my work at my school's
The Digital Learning Studio, so I can help others interested in game design with platforms that provide an easy foundation for learning. 

## Development Notes
There were some settings in the Unity tutorial that, I felt, didn't fit the speed of the game, so they were ultimately adjusted to match my preference. Examples of this were the size of the asteroid sprites (since they were
custom-made, I had to adjust them accordingly), the volume of the background music and sound effects, as well as the bounciness of the collision objects and the speed of the rocketship. 
