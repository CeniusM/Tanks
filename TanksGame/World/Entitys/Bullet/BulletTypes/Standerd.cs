using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    class Standerd // this is the tank ingame, and the player is handeling the players input
    {
        public const float Speed = 10;
        public const float TimeAlive = 100; // in seconds ish i think, nope
        public static void Update(Bullet bullet, float deltaTime)
        {
            // bullet.pos2.AddVector(bullet.vector2); // idk why it dosent work
            bullet.pos2.x += bullet.vector2.x;
            bullet.pos2.y += bullet.vector2.y;
            bullet.timeAlive -= deltaTime;
        }
    }
}