using Tanks.World.Entitys;
using Tanks.GameLogic.Math;
using MyPhysics.Vectors;
using winForm;

namespace Tanks.World
{
    class TankWorld
    {
        public List<Tank> tanks;
        public Map map = new Map();
        private Form1 _form;
        public TankWorld(Form1 form)
        {
            tanks = new List<Tank>();
            tanks.Add(new Tank(new Player()));
            _form = form; // only used for key events

            _form.KeyUp += KeyUp;
            _form.KeyDown += KeyDown;
        }

        public void Start()
        {

        }

        public void Update(float deltaTime)
        {
            foreach (Tank tank in tanks)
            {
                if (tank.player!.keysPressed[0] == 0b1)
                {
                    if (tank.player!.keysPressed[1] == 0b1)
                    {
                        tank.vector.Reset();
                    }
                    else
                    {
                        tank.vector = VectorMath.GetVectorHeading2D(tank.angle);
                    }
                }
                else if (tank.player!.keysPressed[1] == 0b1)
                {
                    if (tank.player!.keysPressed[0] == 0b1)
                    {
                        tank.vector.Reset();
                    }
                    else
                    {
                        Vector2 newVector = VectorMath.GetVectorHeading2D(tank.angle);
                        newVector.Scale(-1);
                        tank.vector = newVector;
                    }
                }
                else if (tank.player!.keysPressed[2] == 0b1)
                {
                    tank.TurnRight(deltaTime);
                }
                else if (tank.player!.keysPressed[3] == 0b1)
                {
                    tank.TurnLeft(deltaTime);
                }
                else if (tank.player!.keysPressed[4] == 0b1)
                {
                    // not implementet
                }

                tank.position.AddVector(tank.vector);
                tank.vector = new MyPhysics.Vectors.Vector2();
            }
        }

        private void KeyUp(object? sender, KeyEventArgs e)
        {
            foreach (Tank tank in tanks)
            {
                if (tank.player == null) continue;
                tank.player.UpdateKey(e.KeyValue, 0);
            }
        }

        private void KeyDown(object? sender, KeyEventArgs e)
        {
            foreach (Tank tank in tanks)
            {
                if (tank.player == null) continue;
                tank.player.UpdateKey(e.KeyValue, 1);
            }
        }
    }
}