using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    class Standerd // this is the tank ingame, and the player is handeling the players input
    {
        public const float Speed = 20;
        public const float TimeAlive = 100; // in seconds ish i think, nope
        public static void Update(Bullet bullet, float deltaTime)
        {
            // bullet.pos2.AddVector(bullet.vector2); // idk why it dosent work
            bullet.pos2.x += bullet.vector2.x * deltaTime;
            bullet.pos2.y += bullet.vector2.y * deltaTime;
            bullet.timeAlive -= deltaTime;

            if (bullet.pos2.x > 700)
                bullet.vector2.x = -Math.Abs(bullet.vector2.x);
            else if (bullet.pos2.x < 0)
                bullet.vector2.x = Math.Abs(bullet.vector2.x);
            if (bullet.pos2.y > 700)
                bullet.vector2.y = -Math.Abs(bullet.vector2.y);
            else if (bullet.pos2.y < 0)
                bullet.vector2.y = Math.Abs(bullet.vector2.y);
        }
    }
}