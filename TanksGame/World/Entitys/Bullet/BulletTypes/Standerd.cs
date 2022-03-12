using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    class StandardBullet : BulletBase
    {
        public StandardBullet(Vector2 vector2, Position2 position2) : base(vector2, position2, 100, 10) { }
        public override void Update(Map map, float deltaTime)
        {
            pos2.AddVector(vec2);
            timeAlive -= 1 * deltaTime;


            if (pos2.x > 800)
                vec2.x = -Math.Abs(vec2.x);
            else if (pos2.x < 0)
                vec2.x = Math.Abs(vec2.x);
            if (pos2.y > 800)
                vec2.y = -Math.Abs(vec2.y);
            else if (pos2.y < 0)
                vec2.y = Math.Abs(vec2.y);
        }
    }
}