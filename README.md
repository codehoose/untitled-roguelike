# An As-Yet Untitled Roguelike
Making a video about making a roguelike!

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