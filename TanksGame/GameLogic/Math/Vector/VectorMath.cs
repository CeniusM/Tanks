using MyPhysics.Vectors;

namespace Tanks.GameLogic.Math
{
    class VectorMath
    {
        public static Vector2 GetVectorHeading2D(float angle) // 0 - 360, and will return a vector with speed 1 in the correckt angle
        {
            float x = MathF.Cos(angle);
            float y = MathF.Sin(angle);

            return new Vector2(x, y);
        }
    }
}