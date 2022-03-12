using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;
using Tanks.World;

namespace Tanks.World.Entitys.BulletTypes
{
    abstract class BulletBase : IBullet
    {
        protected BulletBase(Vector2 vector2, Position2 position2, float timeAlive, int bulletSize)
        {
            vec2 = vector2;
            pos2 = position2;
            this.timeAlive = timeAlive;
            this.size = bulletSize;
        }
        public Vector2 vec2 { get; protected set; }
        public Position2 pos2 { get; protected set; }
        public float timeAlive { get; protected set; }
        public int size { get; protected set; }
        public abstract void Update(Map map, float deltaTime);
    }
}