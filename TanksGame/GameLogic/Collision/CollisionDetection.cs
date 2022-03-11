using Tanks.World;
using Tanks.World.Entitys;

namespace Tanks.GameLogic.CollisionDetection
{
    class CollisionDetector
    {
        public static int TankAndShotsCollision(List<Tank> tanks, List<IBullet> bullets) // returns the index of the hit tank
        {
            for (int i = 0; i < tanks.Count; i++)
            {
                for (int j = 0; j < bullets.Count; j++)
                {
                    if (bullets[j].pos2.x > (tanks[i].position.x - (tanks[i].hitbox.width / 2))) // left
                        if (bullets[j].pos2.x < (tanks[i].position.x + (tanks[i].hitbox.width / 2))) // right
                            if (bullets[j].pos2.y > (tanks[i].position.y - (tanks[i].hitbox.height / 2))) // top
                                if (bullets[j].pos2.y < (tanks[i].position.y + (tanks[i].hitbox.height / 2))) // buttom
                                    return i;
                }
            }
            return -1;
        }
    }
}