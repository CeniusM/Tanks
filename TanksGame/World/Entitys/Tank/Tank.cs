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
        private float stering = 0.25f;
        public float rotation = 0; // this is in radiants, 1 radiant = 57.3f degrees, 360 degrees = 6.28f radiants
        private float rotationScale = 6.28f;
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
            if (rotation > rotationScale)
                rotation -= rotationScale;
        }

        public void TurnLeft(float deltaTime)
        {
            rotation -= stering * deltaTime;
            if (rotation < 0)
                rotation += rotationScale;
        }
    }
}