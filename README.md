# An As-Yet Untitled Roguelike
Making a video about making a roguelike!
The master branch has the bleeding edge code. If you want to get the code for a specific video, clone a release branch. Each release branch contains the state of the code _at the end_ of a video.

# Video 1 - Player Movement
Implemented cell-by-cell movement. This took a little long (~1hr) because I wanted to implement a message queue system. This will help in the long run and was required for later on. Features implemented in this video:
- Player input using the cursor keys
- Animated movement of the player's sprite from one cell to another in the cardinal directions (North, South, East and West)
- Message queue to send messages, events and commands

# Video 2 
Features implemented in this video:
- Fix a problem with moving - you can move more than once which meant that the player could sometimes land between squares
- Fix sprites transparency
- Collision detection for impassable objects and treasure chests
- Step counter - Added a player manager to measure some metrics. Something to build upon. Like...
- Item chest - Kinda. The treasure chest manager is in, and as per the player manager is something to build on

# Video 3
Features implemented in this video:
- Fix collision detection (thanks to Mustafa and Micaiah for pointing out the issue)
- Fix for treasure chest multi-hit (thanks to Mustafa for pointing out the issue)
- Abstract the hit system out of Locomotion
- Static NPC for attacks
  - Some kind of basic hit point system

# Video 4
- Basic inventory system (melee and range weapons)
  - How many items can you carry? (SLOTS)
  - Player stats system
    - Melee attack strength
    - Range attack strength
    - Defensive strength (shields
    - Hit points (health) - 10
  - Weapons e.g. range, melee and shields i.e. Equipment uses items from your inventory
    - Equipped / unequipped
      - Equipped slots
      - Main hand, offhand, shield
  - Consumables e.g. food
    - When you use it applies a certain effect on your character
      - e.g. drink potion, gets +1 melee attack bonus for 1min
        - Buff and then a de-buff
      - e.g. Adds +1 to health
    - Is removed from inventory on use
- Buff / de-buff weapons & equipment (i.e. hit, shield etc.)
- Abstract input
- Status bar text e.g. You are overburdoned?
- Abstract movement - are we moving in 2d or 3d. Doesn't matter as far as the game is concerned

# Video 5
- Designing map in Tiled and bringing that data into the game
- Added serialization classes to pull in the data from Tiled's JSON format object
- Creating a tilemap object in Unity and addition collision detection for the player
- Having to offset the map generation because tiles are from top-left and not centred

# Video 6
- Mapping the layer data in Tiled to objects in Unity
- Moving the generate dungeon out of the tilemap render script

# Things to Implement
- Debug info?
- --Input & movement--
- --Commands for movement, save, etc.--
- --Events for well, events--
- Player stats
- Debug overlay
- Map structure / format / display
- Level generation
- Collisions
- Objects; treasure chests, keys
- Random encounters
- Monsters
- Data files vs. hard-coded lookup tables
- Magic
- Tuning
- Shop keepers
- Citizens