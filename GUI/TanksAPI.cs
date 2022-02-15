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
            // _formGUI.Reset(0, 0, _form.Height, _form.Width, tankWorld.map.backGround); // use GPU aka compute shader
            _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, tankWorld.map.backGround);

            foreach (Tank tank in tankWorld.tanks)
            {
                Bitmap tankS = new Bitmap(@"TanksGame\World\Entitys\Sprites\Tanks\tank1v1.bmp");
                Graphics gfx = Graphics.FromImage(tankS);
                gfx.TranslateTransform(tankS.Width >> 1, tankS.Height >> 1);
                gfx.RotateTransform(tank.rotation);
                // CS_MyConsole.MyConsole.WriteLine(tank.rotation + "");
                gfx.TranslateTransform(-tankS.Width / 2, -tankS.Height / 2);
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(tankS, 0, 0);
                _formGUI.DrawBitmap(tankS, (int)tank.position.x, (int)tank.position.y);
            }

            _formGUI.Print();
        }
    }
}