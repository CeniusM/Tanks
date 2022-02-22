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

            int tankScale = 20;
            const int bulletSize = 100;

            foreach (Tank tank in tankWorld.tanks)
            {
                Bitmap tankS = new Bitmap(new Bitmap(@"TanksGame\World\Entitys\Sprites\Tanks\tank1v1.bmp"), new Size(_form.Height / tankScale, _form.Width / tankScale));
                Graphics gfx = Graphics.FromImage(tankS);
                gfx.TranslateTransform(tankS.Width >> 1, tankS.Height >> 1);
                gfx.RotateTransform((tank.rotation * 57 + 90)); // the times 57.29, makes it from radiates to degrees
                // CS_MyConsole.MyConsole.WriteLine(tank.rotation + "");
                gfx.TranslateTransform(-tankS.Width / 2, -tankS.Height / 2);
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(tankS, 0, 0);
                _formGUI.DrawBitmap(tankS, (int)tank.position.x - (int)(tank.hitbox.width / 2), (int)tank.position.y - (int)(tank.hitbox.height / 2));
            }

            foreach (Bullet bullet in tankWorld.bullets)
            {
                _formGUI.DrawSquare((int)bullet.pos2.x - (bulletSize >> 1), (int)bullet.pos2.y - (bulletSize >> 1), bulletSize / tankScale, bulletSize / tankScale, Color.Black);
            }

            _formGUI.Print();
        }
    }
}