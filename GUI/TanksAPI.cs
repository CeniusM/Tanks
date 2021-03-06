using Tanks;
using Tanks.World.Entitys;

namespace winForm
{
    class TanksAPI
    {
        private Form1 _form;
        private FormGUI _formGUI;
        private Tanks.World.TankWorld tankWorld;
        private List<Bitmap> tankSprites = new List<Bitmap>();
        private Brush TextBrush = new SolidBrush(Color.Black);
        public TanksAPI(Form1 form, Tanks.World.TankWorld tankWorld, int tankScale)
        {
            _form = form;
            _formGUI = new FormGUI(form);
            this.tankWorld = tankWorld;
            tankSprites.Add(ResizeBitmap(new Bitmap(@"TanksGame\World\Entitys\Sprites\Tanks\tank1v1.bmp"), Tanks.World.Entitys.Tank.Size, Tanks.World.Entitys.Tank.Size));
        }

        public void PrintTanksWorld(int fps)
        {
            // _formGUI.Reset(0, 0, _form.Height, _form.Width, tankWorld.map.backGround); // use GPU aka compute shader, or another thread
            // _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, tankWorld.map.backGround);
            _formGUI.Clear(tankWorld.map.backGround);
            // if (Tanks.GameLogic.CollisionDetection.CollisionDetector.TankAndShotsCollision(tankWorld.tanks, tankWorld.bullets) != -1)
            //     _formGUI.DrawSquare(0, 0, _form.Height, _form.Width, Color.Red);


            foreach (Tank tank in tankWorld.tanks)
            {
                Bitmap tankS = new Bitmap(tankSprites[0].Width, tankSprites[0].Height);
                Graphics gfx = Graphics.FromImage(tankS);
                // gfx.Clear(tankWorld.map.backGround);
                gfx.TranslateTransform(tankS.Width >> 1, tankS.Height >> 1);
                gfx.RotateTransform((tank.rotation * 57 + 90)); // the times 57.29, makes it from radiates to degrees
                                                                // CS_MyConsole.MyConsole.WriteLine(tank.rotation + "");
                gfx.TranslateTransform(-tankS.Width / 2, -tankS.Height / 2);
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(tankSprites[0], 0, 0);
                _formGUI.DrawBitmap(tankS, (int)tank.position.x - (int)(tank.hitbox.width / 2), (int)tank.position.y - (int)(tank.hitbox.height / 2));
            }

            foreach (IBullet bullet in tankWorld.bullets)
            {
                _formGUI.DrawSquare((int)bullet.pos2.x, (int)bullet.pos2.y, (bullet.size >> 1), (bullet.size >> 1), Color.Black);
                // _formGUI.DrawSquare((int)bullet.pos2.x - (bulletSize >> 1), (int)bullet.pos2.y - (bulletSize >> 1), (bulletSize >> 1), (bulletSize >> 1), Color.Black);
                // _formGUI.DrawSquare((int)bullet.pos2.x + ((bulletSize / tankScale) >> 1), (int)bullet.pos2.y - +((bulletSize / tankScale) >> 1), bulletSize / tankScale, bulletSize / tankScale, Color.Black);
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