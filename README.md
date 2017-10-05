# KernMGameDev
Kernmodule Game Development HKU, By Ronald van Egdom, studentnummer 3018119.

The Rocketeer Man Project (Retro Game Assignment) can be found [here](https://github.com/Cheezegami/HKU-KernMGameDev/tree/master/Rocketeer%20Man%20Files).

# Idea
The idea is to make a bomberman game using rocket launchers instead of dropping bombs. The most important feature is to get working characters in the level which are able to walk and shoot rockets. These rockets are able to hit other characters as well as bricks. Bricks may drop pick-ups upon exploding and will give the player more exposure to the terrain once destroyed. Players start locked in my bricks and will after destroying a few bricks be able to shoot rockets at other players.

Pickups will increase the following stats of the player :
- Rocket Blast Radius +-
- Rocket Velocity +-
- Rocket Cooldown +-
- Rocket Modifiers? Perhaps modifiers such as Triple Shot(Shoot 3 rockets at once with a delayed cooldown), Napalm Rockets (Inflict Burning Area after detonation) or Sticky Rockets (Stick to hit surface for a while before exploding) could be a thing.
- Player Speed +-
- Player Lives +

# Game Structure and Scene Flow
The game will feature 4(or 5 if the option menu gets an individual scene while in game) scenes which are
- Main Menu
- Game
- Score Menu
- Options Menu

As well as a
- Preload Scene

The game will boot into to instantiate important game features.

The relation between these scenes can be found inside the [activity diagram and class diagram](https://github.com/Cheezegami/HKU-KernMGameDev/tree/master/Rocketeer%20Man%20Files/UML) found within the UML folder of this project.

# Learning Goals
I want to learn about the following aspects of C# development.
- Proper use of polymorphism and class instantiation within Unity.
- Using Class Properties and Constructor Parameters.
- Proper use of static classes/methods and switch statements within the Unity Environment.
- Using a preloaded scene and game manager within Unity and/or a Singleton as a solution to that.
- Interfaces and perhaps generics if I can find a way to fit it into my game.
- Look into including delegates and/or events.
- Object Pools
- Making awesome games.

# Technic Plan - Kernmodule Game Development 1
### Week 1
- [x] Start Course.
### Week 2
- [x] Conceptuate and Ideate.
### Week 3
- [x] UML Class Diagram and Activity Diagram start.
### Week 4 (28/9 - 5/10) 
- [x] Finish UML Class Diagram.
- [x] Finish UML Acitivity Diagram.
- [x] Determine which patterns to learn.
- [x] Technic Plan.
- [x] Empty Class Mockup.
- [x] Work on Scene Flow. (Menu - Game - Finish Screen)
- [x] Work on implementing basic functionality (Character, ~~Movement~~ -> ~~Map Instancing~~). 
### Week 5 (5/10 - 12/10) 
- [ ] Finish basic functionality (Character, Movement, Map Instancing).
- [ ] Work on gameplay functionality (Shooting -> Tile Destruction -> Explosion Radius, Projectile Behavior.
### Week 6 (12/10 - 19/10)
- [ ] Finish gameplay functionality (Shooting -> Tile Destruction -> Explosion Radius, Projectile Behavior).
- [ ] Work on Core functionality (UI & Menu's -> Gameplay Flow (AI Instancing, Winning, Selection, Options) -> AI Behavior/Multiplayer mode).
- [ ] \(Optional) Make Multiplayer mode.
### Week 7 (19/10 - 26/10)
- [ ] Bug testing.
- [ ] Finish Core Functionality.
- [ ] Finish Missing Functionality.

