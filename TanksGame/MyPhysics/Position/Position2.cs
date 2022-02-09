namespace MyPhysics.Positions
{
    public struct Position2
    {
        public float x = 0f;
        public float y = 0f;
        public Position2()
        {

        }

        public Position2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Position2(Position2 other)
        {
            this.x = other.x;
            this.y = other.y;
        }
    }
}