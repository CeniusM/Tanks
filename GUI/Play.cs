using Tanks;

namespace winForm
{
    class PlayTanks
    {
        private Form1 _form;
        private TanksAPI _tanksAPI;
        public TanksGame tanksGame;
        public int fps = 100;
        public PlayTanks(Form1 form)
        {
            _form = form;
            tanksGame = new TanksGame(form);
            _tanksAPI = new TanksAPI(form, tanksGame.tankWorld, 100);
            // tanksGame.printScreenEvent += PrintGame;
        }

        public void Play()
        {
            Thread gameThread = new Thread(tanksGame.Start);
            gameThread.Start();
            tanksGame.printScreenEvent += PrintGame;
        }

        public void Stop()
        {
            tanksGame.Stop();
        }

        private void PrintGame(object? sender, EventArgs e)
        {
            _tanksAPI.PrintTanksWorld(fps);
        }
    }
}