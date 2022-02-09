using Tanks;

namespace winForm
{
    class PlayTanks
    {
        private Form1 _Form;
        public EventHandler? stopEvent;
        public TanksGame tanksGame;
        public PlayTanks(Form1 form)
        {
            _Form = form;
            tanksGame = new TanksGame();
        }

        public void Play()
        {

        }

        public void Stop() => stopEvent!.Invoke(this, EventArgs.Empty);
    }
}