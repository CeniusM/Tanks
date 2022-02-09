namespace Tanks
{
    class TanksGame
    {
        public bool isRunning = false;
        public GameLogic.Updating updating = new GameLogic.Updating();
        public void Start()
        {

        }

        public void Update()
        {
            updating.updatingStarted.Invoke(this, EventArgs.Empty);
            updating.updating = true;



            updating.updating = false;
            updating.updatingStoped.Invoke(this, EventArgs.Empty);
        }
    }
}