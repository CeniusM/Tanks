using Tanks.World.Entitys;
using Tanks.GameLogic.Math;
using MyPhysics.Vectors;
using MyPhysics.Positions;
using winForm;

namespace Tanks.World
{
    class TankWorld
    {
        public List<Tank> tanks;
        public List<Bullet> bullets;
        public Map map = new Map();
        private Form1 _form;
        public TankWorld(Form1 form)
        {
            tanks = new List<Tank>();
            bullets = new List<Bullet>();
            tanks.Add(new Tank(new Player()));

            Keybinds keybinds = new Keybinds(Keys.I, Keys.K, Keys.L, Keys.J, Keys.U);
            tanks.Add(new Tank(new Player(keybinds)));
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
                        tank.vector = VectorMath.GetVectorHeading2D(tank.rotation);
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
                        Vector2 newVector = VectorMath.GetVectorHeading2D(tank.rotation);
                        newVector.Scale(-0.5f);
                        tank.vector = newVector;
                    }
                }
                if (tank.player!.keysPressed[2] == 0b1)
                {
                    tank.TurnRight(deltaTime);
                }
                if (tank.player!.keysPressed[3] == 0b1)
                {
                    tank.TurnLeft(deltaTime);
                }
                if (tank.player!.keysPressed[4] == 0b1)
                {
                    Bullet newBullet = new Bullet(new Position2(tank.position.x + tank.hitbox.width, tank.position.y + tank.hitbox.height), VectorMath.GetVectorHeading2D(tank.rotation), map, 1);
                    bullets.Add(newBullet);
                }

                tank.vector.Scale(Tank.Speed);
                tank.position.AddVector(tank.vector, deltaTime);
                tank.vector = new MyPhysics.Vectors.Vector2();
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Update(deltaTime);
                if (bullets[i].timeAlive < 0)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < bullets.Count; i++)
            {

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

            // CS_MyConsole.MyConsole.WriteLine(e.KeyValue + "");

            // for debugging
            if (e.KeyValue == 80) // p, and will print a report of the data in the world
            {
                for (int i = 0; i < tanks.Count; i++)
                {
                    CS_MyConsole.MyConsole.WriteLine(tanks[i].rotation + ". tank " + i);
                }
            }
            else if (e.KeyValue == 81) // q, and will print a report of the data in the world
            {
                for (int i = 0; i < tanks.Count; i++)
                {
                    CS_MyConsole.MyConsole.WriteLine(tanks[i].position.x + ". " + tanks[i].position.y + ". tank " + i);
                }
            }
        }
    }
}