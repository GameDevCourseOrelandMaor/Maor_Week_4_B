# Maor_Week_4_B

Itch.io link:
[Click here to play](https://maor55.itch.io/week-4-question-b)

<br/>This game demo is inspired from Tetris Race - a car needs to drive forward while dodging incoming cars.<br/>
I mainly followed the instructions and principles from previous lecture to make this game.<br/>

I wrote 4 scripts, were mostly a modification of the lecture's scripts:  <br/>
 <br/> <br/>playerMovement: <br/>
Modified from original lecture script, to have only xAxis movement, and also two get functions
 <br/> <br/>Mover: <br/>
For setting the velocity for the prefab's car clones
 <br/> <br/>TimedSpawnedRandom: <br/>
Taken from the lecture, used for the spawning of the prefabs' car clones
 <br/> <br/>DestroyOnTrigger: <br/>
Because the interaction between the cars and the player's car is set to isTrigger, I also made the walls of the game to be isTrigger and tagged with "triggerWall",
this way, whenever the car hits the walls, a knockback vector is added to the car so that it will rebounce back to the course instead of breaking free.



Used the assets from the Unity Assests Store:
[ARCADE: FREE Racing Car](https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085)

