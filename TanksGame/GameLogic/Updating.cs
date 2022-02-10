namespace Tanks.GameLogic
{
    class Updating
    {
        public event EventHandler? updatingStarted;
        public bool updating = false;
        public event EventHandler? updatingStoped;
        public void UpdateStarted()
        {
            updating = true;
            // updatingStarted!.Invoke(this, EventArgs.Empty);
        }
        public void UpdateStoped()
        {
            updating = false;
            // updatingStoped!.Invoke(this, EventArgs.Empty);
        }
    }
}