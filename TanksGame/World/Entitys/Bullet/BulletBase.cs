using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    abstract class BulletBase : IBullet
    {
        protected BulletBase(Vector2 vector2, Position2 position2, float timeAlive)
        {
            vec2 = vector2;
            pos2 = position2;
            this.timeAlive = timeAlive;
        }
        public Vector2 vec2 { get; protected set; }
        public Position2 pos2 { get; protected set; }
        public float timeAlive { get; protected set; }
        public abstract void Update(Map map, float deltaTime);
    }
}