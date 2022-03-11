using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    class StandardBullet : BulletBase
    {
        public StandardBullet(Vector2 vector2, Position2 position2) : base(vector2, position2, 50) { }
        public override void Update(Map map, float deltaTime)
        {
            pos2.AddVector(vec2);
            timeAlive -= 1 * deltaTime;
        }
    }
}