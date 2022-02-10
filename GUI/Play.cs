using Tanks;

namespace winForm
{
    class PlayTanks
    {
        private Form1 _Form;
        public event EventHandler? stopEvent;
        public TanksGame tanksGame;
        public PlayTanks(Form1 form)
        {
            _Form = form;
            tanksGame = new TanksGame(form, stopEvent!);
            tanksGame.printScreenEvent += PrintGame;
        }

        public void Play()
        {
            tanksGame.Start();

            // do the ui :D
        }

        public void Stop()
        {
            stopEvent!.Invoke(this, EventArgs.Empty);
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