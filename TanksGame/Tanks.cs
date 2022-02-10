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
        private event EventHandler? _stopEvent;
        public TanksGame(Form1 form, EventHandler stopEvent)
        {
            _form = form;
            tankWorld = new TankWorld(_form);
            _stopEvent = stopEvent; // used to stop the program
            _stopEvent += Stop;
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

            updating.UpdateStoped();
        }

        private void TimeCycle() // uses deltaTime
        {
            var watch = new System.Diagnostics.Stopwatch();
            float deltaTimeSec = 0;

            while (isRunning)
            {
                watch.Start();
                Update(deltaTimeSec);
                printScreenEvent!.Invoke(this, EventArgs.Empty);
                watch.Stop();
                deltaTimeSec = watch.ElapsedMilliseconds / 100;
                watch.Reset();
            }
        }

        private void Stop(object? sender, EventArgs e)
        {
            isRunning = false;
        }
    }
}