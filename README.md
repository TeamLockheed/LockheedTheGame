LockheedTheGame
===============

Role-playing game made in SFML.NET

1. Who are we ? – Our team is named LockHeed and it consists of 5 of people :
-glava ( Plamen Hristov )
-kibork( Dimitar Bonev )
-petrovaliev95 ( Daniel Petrovaliev )
-alexxdim94 (Alexander Dimitrov)
-LittleNinja (Alexander Stoimenov)

2. Our game – it consists of 32 classes (5 of which are abstract) and 1 engine class, 9 interfaces and 3 enumerations. Currently we have classes for the following things :
 - Character ( can be a Mage, Rogue or Warrior) – has a Stats property which is a structure. The character implements three interfaces : ICollidable, IDrawable and IMoveable
- Enemy – same as Character but with a few differences, has an Update() method, which makes the enemy change its coordinates according to those of the Character and spawns randomly in each Level
- Level – Consists of list of Enemies, list of Obstacles and a list of Doors,  has a generateSingleLevel(), which speaks for itself and generates one or two doors with random position , 4 random obstacles with random coordinates, and a random number of enemies which spawn outside of the level.
-Map – Consists of a 2D array of levels which illustrates where every single level leads to
- Door – each door has a position and a level id, where the door leads to
- Obstacle – Consists of 3 obstacles ( ChestObstacle, DeadlyObstacle, ObstructedObstacle). The ChestObstacle can be opened and it consists of 4 items, the DeadlyObstacle is an insta-kill hole and the ObstructedObstacle is a generic rock which blocks your way.
Skill – implements the ICastable and ILearnable interfaces , can be ProjectileSkill or a NovaSkill. The ProjectileSkill creates a projectile and rotates it towards the mouse coordinates where you have clicked and moves towards there. If it collides with an enemy both are removed from the game. The NovaSkill was to be same as the ProjectileSkill except that it was supposed to create 18 to 36 projectiles, all turned from degrees of 0 to 360, creating the illusion of a spherical effect. The skill has a Tier which is unlocked by a Character.
Weapon – has a type, handling (OneHanded, TwoHanded)
EntityManager – static class for updating the character , the enemies and projectiles, drawing them, and drawing the level
IDrawable – Contains a SpriteSheet object and a Draw() method
IMoveable – Contains X and Y coordinates and a Move() method
ICollidable – Contains a BoundingBox (a FloatRect() from the sfml library)







