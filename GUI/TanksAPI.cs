using Tanks;
using Tanks.World.Entitys;

namespace winForm
{
    class TanksAPI
    {
        private Form1 _form;
        private FormGUI _formGUI;
        public TanksAPI(Form1 form)
        {
            _form = form;
            _formGUI = new FormGUI(form);
        }

        public void PrintTanksWorld(Tanks.World.TankWorld tankWorld)
        {
            _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, tankWorld.map.backGround);

            foreach (Tank tank in tankWorld.tanks)
            {
                _formGUI.DrawBitmap(new Bitmap(@"TanksGame\World\Entitys\Sprites\Tanks\tank1v1.bmp"), (int)tank.position.x, (int)tank.position.y);
            }

            _formGUI.Print();
        }
    }
}