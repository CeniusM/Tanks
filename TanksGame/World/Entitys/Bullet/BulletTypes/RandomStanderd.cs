using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    class RandomStanderdBullet : BulletBase
    {
        private Random _rnd = new Random();
        public RandomStanderdBullet(Vector2 vector2, Position2 position2) : base(vector2, position2, 25)
        {
            vec2.x += _rnd.NextSingle() - 0.5f;
            vec2.y += _rnd.NextSingle() - 0.5f;
        }

        public override void Update(Map map, float deltaTime)
        {
            pos2.AddVector(vec2);
            timeAlive -= 1 * deltaTime;
        }
    }
}