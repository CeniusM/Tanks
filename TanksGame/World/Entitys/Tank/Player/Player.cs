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
        public int[] keysPressed = new int[5];
        public Player()
        {

        }

        public Player(int[] KeyBinds)
        {
            keyBinds = KeyBinds;
        }

        public void UpdateKey(int key, int OnOff)
        {
            for (int i = 0; i < 5; i++)
            {
                if (key == keyBinds[i])
                {
                    keysPressed[i] = OnOff;
                    break;
                }
            }
        }

        // public void UpdateKeyOld(int key, int type) // 1 = pressed down, 0 = unpressed, and the values is using the ASCII system
        // {
        // public List<int> keysPressed = new List<int>(); // in the class
        //     if (type == 1)
        //     {
        //         if (!keysPressed.Contains(key)) keysPressed.Add(key);
        //     }
        //     else
        //     {
        //         if (keysPressed.Contains(key)) keysPressed.Remove(key);
        //     }
        // }
    }
}