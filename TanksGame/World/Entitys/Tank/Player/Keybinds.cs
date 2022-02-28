using MyPhysics.Vectors;
using MyPhysics.Positions;
using Tanks.World.EntityData;

namespace Tanks.World.Entitys
{
    readonly struct Keybinds
    {
        public const int KeyBindAmount = 5;
        public readonly int[] KeybindsArr;
        public readonly int Up;
        public readonly int Down;
        public readonly int Right;
        public readonly int Left;
        public readonly int Shoot;
        public Keybinds(int Up, int Down, int Right, int Left, int Shoot)
        {
            this.Up = Up;
            this.Down = Down;
            this.Right = Right;
            this.Left = Left;
            this.Shoot = Shoot;

            KeybindsArr = new int[KeyBindAmount];
            KeybindsArr[0] = this.Up;
            KeybindsArr[1] = this.Down;
            KeybindsArr[2] = this.Right;
            KeybindsArr[3] = this.Left;
            KeybindsArr[4] = this.Shoot;
        }
        public Keybinds(Keys Up, Keys Down, Keys Right, Keys Left, Keys Shoot)
        {
            this.Up = (int)Up;
            this.Down = (int)Down;
            this.Right = (int)Right;
            this.Left = (int)Left;
            this.Shoot = (int)Shoot;


            KeybindsArr = new int[KeyBindAmount];
            KeybindsArr[0] = this.Up;
            KeybindsArr[1] = this.Down;
            KeybindsArr[2] = this.Right;
            KeybindsArr[3] = this.Left;
            KeybindsArr[4] = this.Shoot;
        }
    }
}