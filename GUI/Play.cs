using Tanks;

namespace winForm
{
    class PlayTanks
    {
        private Form1 _form;
        private TanksAPI _tanksAPI;
        public TanksGame tanksGame;
        public PlayTanks(Form1 form)
        {
            _form = form;
            tanksGame = new TanksGame(form);
            _tanksAPI = new TanksAPI(form);
            tanksGame.printScreenEvent += PrintGame;
        }

        public void Play()
        {
            tanksGame.Start();
        }

        public void Stop()
        {
            tanksGame.Stop();
        }

        private void PrintGame(object? sender, EventArgs e)
        {
            _tanksAPI.PrintTanksWorld(tanksGame.tankWorld);
        }
    }
}