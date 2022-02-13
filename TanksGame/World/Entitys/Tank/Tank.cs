using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Tank // this is the tank ingame, and the player is handeling the players input
    {
        public const float Speed = 10f;
        public const float Gravity = 0.1f;
        public Player? player; // could also be an ai, so implement so it isent nesecerely a player
        public Hitbox2 hitbox = new Hitbox2();
        public Position2 position;
        public Vector2 vector;
        public bool HaveJustShot = false;
        public float stering = 0.001f;
        private float rotation = 0; // 0 - 1 = 0 - 360, and right is 0, up or down is 90, left is 180, down or up is 270
        public int angle
        {
            get
            {
                return (int)(rotation * 360);
            }
        }
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

        public void TurnRight(float deltaTime)
        {
            rotation += stering * deltaTime;
            if (rotation > 1)
                rotation -= 1;
        }

        public void TurnLeft(float deltaTime)
        {
            rotation -= stering * deltaTime;
            if (rotation < 0)
                rotation += 1;
        }
    }
}