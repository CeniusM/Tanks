using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    class Player
    {
        public Keybinds Keybinds;
        public int[] keysPressed = new int[Keybinds.KeyBindAmount];
        public Player()
        {
            Keybinds = new Keybinds(Keys.W, Keys.S, Keys.D, Keys.A, Keys.Space);
        }

        public Player(Keybinds KeyBinds)
        {
            this.Keybinds = KeyBinds;
        }

        public void UpdateKey(int key, int OnOff)
        {
            for (int i = 0; i < Keybinds.KeyBindAmount; i++)
            {
                if (key == Keybinds.KeybindsArr[i])
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