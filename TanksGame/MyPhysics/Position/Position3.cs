namespace MyPhysics.Positions
{
    public class Position3
    {
        public float x = 0f;
        public float y = 0f;
        public float z = 0f;
        public Position3()
        {

        }

        public Position3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Position3(Position3 other)
        {
            this.x = other.x;
            this.y = other.y;
            this.z = other.z;
        }
    }
}