using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Tank // this is the tank ingame, and the player is handeling the players input
    {
        public const float Speed = 0.1f;
        public const float Gravity = 0.1f;
        public Hitbox hitbox;
        public Position2 position;
        public Vector2 vector;
        public Tank()
        {
            position = new Position2();
            vector = new Vector2();
        }
        public Tank(Position2 position)
        {
            this.position = new Position2(position);
            vector = new Vector2();
        }
        public Tank(Tank player)
        {
            hitbox = new Hitbox(player.hitbox);
        }
    }
}