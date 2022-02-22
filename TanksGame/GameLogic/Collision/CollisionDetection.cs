using Tanks.World;
using Tanks.World.Entitys;

namespace Tanks.GameLogic.CollisionDetection
{
    class CollisionDetector
    {
        public int TankAndShotsCollision(List<Tank> tanks, List<Bullet> bullets) // returns the index of the hit tank
        {
            for (int i = 0; i < tanks.Count; i++)
            {
                for (int j = 0; j < bullets.Count; j++)
                {
                    
                }
            }
            return -1;
        }
    }
}