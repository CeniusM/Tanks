namespace Tanks.World.EntityData
{
    struct Hitbox
    {
        public float height;
        public float width;
        public Hitbox()
        {
            height = 0;
            width = 0;
        }
        public Hitbox(float height, float width)
        {
            this.height = height;
            this.width = width;
        }
        public Hitbox(Hitbox hitbox)
        {
            height = hitbox.height;
            width = hitbox.width;
        }
    }
}