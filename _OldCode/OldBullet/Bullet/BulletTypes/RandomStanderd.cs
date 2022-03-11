// using MyPhysics.Vectors;
// using MyPhysics.Positions;
// using Tanks.World.EntityData;
// using Tanks.World;

// namespace Tanks.World.Entitys.BulletTypes
// {
//     class RandomStanderd // this is the tank ingame, and the player is handeling the players input
//     {
//         private static Random _rnd = new Random();
//         public static float Speed
//         {
//             get
//             {
//                 const float speed = 20;
//                 float newSpeed = speed;
//                 newSpeed += _rnd.Next(0, 20);
//                 newSpeed -= 10;
//                 return newSpeed;
//             }
//         }

//         public const float TimeAlive = 50; // in seconds ish i think, nope
//         public static void Update(Bullet bullet, float deltaTime)
//         {
//             // bullet.pos2.AddVector(bullet.vector2); // idk why it dosent work
//             bullet.pos2.x += bullet.vector2.x * deltaTime;
//             bullet.pos2.y += bullet.vector2.y * deltaTime;
//             bullet.timeAlive -= deltaTime;

//             if (bullet.pos2.x > 700)
//                 bullet.vector2.x = -Math.Abs(bullet.vector2.x);
//             else if (bullet.pos2.x < 0)
//                 bullet.vector2.x = Math.Abs(bullet.vector2.x);
//             if (bullet.pos2.y > 700)
//                 bullet.vector2.y = -Math.Abs(bullet.vector2.y);
//             else if (bullet.pos2.y < 0)
//                 bullet.vector2.y = Math.Abs(bullet.vector2.y);
//         }
//     }
// }