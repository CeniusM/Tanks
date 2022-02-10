using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Player
    {
        public int[] keyBinds =    // just for now / testing, and later it needs to be dirfrent for each player
        {
            ((int)Keys.W), // forward
            ((int)Keys.S), // backwars
            ((int)Keys.D), // right
            ((int)Keys.A), // left
            ((int)Keys.Space) // shoot
        };
        public List<int> keysPressed = new List<int>();
        public Player()
        {

        }

        public Player(int[] KeyBinds)
        {
            keyBinds = KeyBinds;
        }

        public void UpdateKey(int key, int type) // 1 = pressed down, 0 = unpressed
        {
            if (!keyBinds.Contains(key)) return;
            if (type == 1)
            {
                if (!keysPressed.Contains(key)) keysPressed.Add(key);
            }
            else
            {
                if (keysPressed.Contains(key)) keysPressed.Remove(key);
            }
        }
    }
}