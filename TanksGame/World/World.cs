using Tanks.World.Entitys;
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