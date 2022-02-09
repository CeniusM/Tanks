using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Player
    {
        public const float Speed = 0.1f;
        public const float Gravity = 0.1f;
        public Hitbox hitbox;
        public Position2 position;
        public Vector2 vector;
        public List<Keys> keysPressed = new List<Keys>();
        public Player()
        {
            position = new Position2();
            vector = new Vector2();
        }
        public Player(Position2 position)
        {
            this.position = new Position2(position);
            vector = new Vector2();
        }
        public Player(Player player)
        {
            hitbox = new Hitbox(player.hitbox);
        }
    }
}