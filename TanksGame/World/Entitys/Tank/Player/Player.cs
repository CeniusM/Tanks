using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Player
    {
        public char[] keyBinds =    // just for now / testing, and later it needs to be dirfrent for each player
        {
            'w', // forward
            's', // backwars
            'd', // right
            'a', // left
            ' ' // shoot
        };
        public List<Keys> keysPressed = new List<Keys>();
        public Player()
        {

        }
    }
}