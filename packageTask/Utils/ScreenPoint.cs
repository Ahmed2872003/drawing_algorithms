using System.Drawing;

namespace packageTask.Utils
{
    internal class CustomPoint
    {
        public float X;
        public float Y;


        public CustomPoint(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public CustomPoint(int X, int Y) : this((float)X, (float)Y)
        {
        }

        public CustomPoint(PointF p) : this(p.X, p.Y)
        {
        }

        public CustomPoint(Point p) : this(p.X, p.Y)
        {
        }

        public PointF toUnit(Size screenSize)
        {
            return CustomPoint.convertToUnit(new PointF(X, Y), screenSize);
        }

        public static PointF convertToUnit(PointF p, Size screenSize)
        {
            float x = screenSize.Width / 2 + p.X;
            float y = screenSize.Height / 2 - p.Y;

            return new PointF(x, y);
        }


    }
}
