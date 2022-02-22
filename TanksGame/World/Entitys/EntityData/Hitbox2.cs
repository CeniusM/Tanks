namespace Tanks.World.EntityData
{
    struct Hitbox2
    {
        public float height;
        public float width;
        public Hitbox2()
        {
            height = 1;
            width = 1;
        }
        public Hitbox2(float height, float width)
        {
            this.height = height;
            this.width = width;
        }
        public Hitbox2(Hitbox2 hitbox)
        {
            height = hitbox.height;
            width = hitbox.width;
        }
    }
}