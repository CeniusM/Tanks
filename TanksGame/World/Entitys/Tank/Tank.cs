using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Tank // this is the tank ingame, and the player is handeling the players input
    {
        public const float Speed = 0.1f;
        public const float Gravity = 0.1f;
        public Player? player; // could also be an ai, so implement so it isent nesecerely a player
        public Hitbox2 hitbox = new Hitbox2();
        public Position2 position;
        public Vector2 vector;
        public int rotation = 0; // 0 - 360
        public Tank(Player Player)
        {
            player = Player;
            position = new Position2();
            vector = new Vector2();
        }
        public Tank()
        {
            // add an ai :D
            position = new Position2();
            vector = new Vector2();
        }
        public Tank(Position2 position)
        {
            // add an ai :D
            this.position = new Position2(position);
            vector = new Vector2();
        }
        public Tank(Tank tank)
        {
            // add an ai :D
            hitbox = new Hitbox2(tank.hitbox);
            position = new Position2(tank.position);
            vector = new Vector2(tank.vector);
        }
    }
}