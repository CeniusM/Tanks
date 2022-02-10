using Tanks;

namespace winForm
{
    class PlayTanks
    {
        private Form1 _Form;
        public TanksGame tanksGame;
        public PlayTanks(Form1 form)
        {
            _Form = form;
            tanksGame = new TanksGame(form);
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
            // throw new NotImplementedException();
            int i = 0;
            if (i == 1)
                i = 2;
        }
    }
}