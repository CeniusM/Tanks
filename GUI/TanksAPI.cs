using Tanks;
using Tanks.World.Entitys;

namespace winForm
{
    class TanksAPI
    {
        private Form1 _form;
        private FormGUI _formGUI;
        private List<Bitmap> tankSprites = new List<Bitmap>();
        private Brush TextBrush = new SolidBrush(Color.Black);
        public TanksAPI(Form1 form, int tankScale)
        {
            _form = form;
            _formGUI = new FormGUI(form);
            tankSprites.Add(ResizeBitmap(new Bitmap(@"TanksGame\World\Entitys\Sprites\Tanks\tank1v1.bmp"), tankScale, tankScale));
        }

        public void PrintTanksWorld(Tanks.World.TankWorld tankWorld, int fps)
        {
            // _formGUI.Reset(0, 0, _form.Height, _form.Width, tankWorld.map.backGround); // use GPU aka compute shader, or another thread
            // _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, tankWorld.map.backGround);
            _formGUI.Clear(tankWorld.map.backGround);

            int tankScale = 20;
            const int bulletSize = 100;
            // if (Tanks.GameLogic.CollisionDetection.CollisionDetector.TankAndShotsCollision(tankWorld.tanks, tankWorld.bullets) != -1)
            //     _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, Color.Red);


            foreach (Tank tank in tankWorld.tanks)
            {
                Bitmap tankS = tankSprites[0];
                Graphics gfx = Graphics.FromImage(tankS);
                // gfx.Clear(tankWorld.map.backGround);
                gfx.TranslateTransform(800 >> 1, 800 >> 1);
                gfx.RotateTransform((tank.rotation * 57 + 90)); // the times 57.29, makes it from radiates to degrees
                                                                // CS_MyConsole.MyConsole.WriteLine(tank.rotation + "");
                gfx.TranslateTransform(-tankS.Width / 2, -tankS.Height / 2);
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(tankS, 0, 0);
                _formGUI.DrawBitmap(tankS, (int)tank.position.x - (int)(tank.hitbox.width / 2), (int)tank.position.y - (int)(tank.hitbox.height / 2));
            }

            foreach (Bullet bullet in tankWorld.bullets)
            {
                _formGUI.DrawSquare((int)bullet.pos2.x + ((bulletSize / tankScale) >> 1), (int)bullet.pos2.y - +((bulletSize / tankScale) >> 1), bulletSize / tankScale, bulletSize / tankScale, Color.Black);
            }


            _form.graphicsObj.DrawString(fps + "", new Font(FontFamily.GenericSansSerif, 20), TextBrush, 0, 0);

            _formGUI.Print();
        }
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
    }
}