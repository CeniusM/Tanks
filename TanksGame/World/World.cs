using Tanks.World.Entitys;
using Tanks.World.Entitys.BulletTypes;
using Tanks.GameLogic.Math;
using MyPhysics.Vectors;
using MyPhysics.Positions;
using winForm;

namespace Tanks.World
{
    class TankWorld
    {
        public List<Tank> tanks;
        public List<IBullet> bullets;
        public Map map = new Map();
        private Form1 _form;
        public TankWorld(Form1 form)
        {
            tanks = new List<Tank>();
            bullets = new List<IBullet>();
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
                    Vector2 newVec2 = VectorMath.GetVectorHeading2D(tank.rotation);
                    newVec2.Scale(5);
                    IBullet newBullet = new RandomStanderdBullet(newVec2, new Position2(tank.position.x + tank.hitbox.width / 2, tank.position.y + tank.hitbox.height / 2));
                    bullets.Add(newBullet);
                }

                tank.vector.Scale(Tank.Speed);
                tank.position.AddVector(tank.vector, deltaTime);
                tank.vector = new MyPhysics.Vectors.Vector2();
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Update(map, deltaTime);
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
        }
    }
}