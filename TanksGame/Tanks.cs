using Tanks.World;
using winForm;

namespace Tanks
{
    class TanksGame
    {
        public bool isRunning = false;
        public GameLogic.Updating updating = new GameLogic.Updating();
        public TankWorld tankWorld;
        private Form1 _form;
        public event EventHandler? printScreenEvent;
        public TanksGame(Form1 form)
        {
            _form = form;
            tankWorld = new TankWorld(_form);
        }

        public void Start()
        {
            isRunning = true;
            TimeCycle();
        }

        public void Update(float deltaTime)
        {
            updating.UpdateStarted();

            tankWorld.Update(deltaTime);
            printScreenEvent!.Invoke(this, EventArgs.Empty);

            updating.UpdateStoped();
        }

        private void TimeCycle() // uses deltaTime
        {
            var watch = new System.Diagnostics.Stopwatch();
            float deltaTimeSec = 0;

            // int MaxUpdatesASec = 60; // never gonna hit it tho :(
            // int TimePerUpdate = 1000 / MaxUpdatesASec;

            while (isRunning)
            {
                watch.Start();
                Update(deltaTimeSec);
                printScreenEvent!.Invoke(this, EventArgs.Empty);
                // if (watch.ElapsedMilliseconds < MaxUpdatesASec) // sets a max upadte a sec amout
                //     Thread.Sleep((int)(MaxUpdatesASec - watch.ElapsedMilliseconds) - 10);
                watch.Stop();
                deltaTimeSec = (float)watch.ElapsedMilliseconds / 100;
                watch.Reset();
            }
        }

        public void Stop()
        {
            isRunning = false;
        }
    }
}