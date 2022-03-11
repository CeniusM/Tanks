using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    interface IBullet
    {
        Vector2 vec2 { get; }
        Position2 pos2 { get; }
        float timeAlive { get; }
        public void Update(Map map, float deltaTime);
    }
}