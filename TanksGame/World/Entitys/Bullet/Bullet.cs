using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Bullet // this is the tank ingame, and the player is handeling the players input
    {
        public Position2 pos2;//{ get; private set; }
        public Vector2 vector2;//{ get; private set; }
        public Map map;// { get; private set; }
        public float timeAlive;
        public int bulletType;//{ get; private set; }
        public Bullet(Position2 pos2, Vector2 vector2, Map map, int bulletType)
        {
            this.pos2 = pos2;
            this.vector2 = vector2;
            this.map = map;
            this.timeAlive = BulletTypes.Standerd.TimeAlive;
            this.bulletType = bulletType;
            // this.vector2.Scale(GetBulletTypeSpeed(bulletType)); // idk why this dosent work
            this.vector2.x *= GetBulletTypeSpeed(bulletType);
            this.vector2.y *= GetBulletTypeSpeed(bulletType);
        }

        public void Update(float deltaTime)
        {
            if (bulletType == 1)
            {
                BulletTypes.Standerd.Update(this, deltaTime);
            }
        }

        private float GetBulletTypeSpeed(int bulletType)
        {
            if (bulletType == 1)
            {
                return BulletTypes.Standerd.Speed;
            }

            CS_MyConsole.MyConsole.WriteLine("Error: bulletType: " + bulletType + ", Is invalid");
            throw new NotImplementedException("Error: bulletType: " + bulletType + ", Is invalid");
        }
    }
}