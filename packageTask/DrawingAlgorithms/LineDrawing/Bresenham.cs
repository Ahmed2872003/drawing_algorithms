using System;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.DrawingAlgorithms.LineDrawing
{
    public class Bresenham
    {
        private enum Octant { first, second, third, fourth, fifth, sixth, seventh, eighth };
        public class Result
        {
            public List<PointF> points = new List<PointF>();
            public List<string> p = new List<string>();

            override
            public string ToString()
            {
                string res = "";

                for (int i = 0; i < points.Count; i++)
                {
                    res += "{ x: " + points[i].X + ", y: " + points[i].Y + ", p: " + p[i] + " }\n";
                }
                return res;
            }
        }

        public static Result run(Point p1, Point p2)
        {
            int xStep, yStep;

            Octant octant = determineOctant(p1, p2);

            configureCoordinates(ref p1, ref p2, octant);

            determineXYStep(out xStep, out yStep, octant);

            int dx = Math.Abs(p2.X - p1.X), dy = Math.Abs(p2.Y - p1.Y);
            int x = p1.X, y = p1.Y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            Result res = new Result();


            res.p.Add("--");

            do
            {
                if (octant == Octant.second || octant == Octant.third || octant == Octant.sixth || octant == Octant.seventh)
                    res.points.Add(new PointF(y, x));
                else
                    res.points.Add(new PointF(x, y));

                // Adding pk for next x and next y
                res.p.Add(p.ToString());

                x += xStep;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y += yStep;
                    p += twoDyMinusDx;
                }



            } while (x != p2.X);

            if (octant == Octant.second || octant == Octant.third || octant == Octant.sixth || octant == Octant.seventh)
                res.points.Add(new PointF(y, x));
            else
                res.points.Add(new PointF(x, y));

            return res;

        }

        private static Octant determineOctant(Point p1, Point p2)
        {

            float dx = p2.X - p1.X, dy = p2.Y - p1.Y;
            float slope = dy / dx;

            if (p1.X < p2.X)
            {
                if (slope >= -1 && slope <= 0) return Octant.eighth;
            }
            else if (p1.X > p2.X)
            {
                if (slope >= -1 && slope <= 0) return Octant.fourth;
                else if (slope > 0 && slope <= 1) return Octant.fifth;
            }

            if (p1.Y < p2.Y)
            {
                if (slope > 1 && slope <= float.PositiveInfinity) return Octant.second;
                else if (slope >= float.NegativeInfinity && slope < -1) return Octant.third;
            }
            else if (p1.Y > p2.Y)
            {
                if (slope >= float.NegativeInfinity && slope < -1) return Octant.seventh;
                else if (slope > 1 && slope <= float.PositiveInfinity) return Octant.sixth;
            }

            return Octant.first;

        }

        private static void configureCoordinates(ref Point p1, ref Point p2, Octant octant)
        {
            if (octant == Octant.second || octant == Octant.third || octant == Octant.sixth || octant == Octant.seventh)
            {
                int x1Temp = p1.X;
                int x2Temp = p2.X;

                p1.X = p1.Y;
                p1.Y = x1Temp;

                p2.X = p2.Y;
                p2.Y = x2Temp;

            }
        }

        private static void determineXYStep(out int xStep, out int yStep, Octant octant)
        {
            if (octant == Octant.fourth || octant == Octant.fifth || octant == Octant.sixth || octant == Octant.seventh)
                xStep = -1;
            else
                xStep = 1;

            if (octant == Octant.third || octant == Octant.fifth || octant == Octant.sixth || octant == Octant.eighth)
                yStep = -1;
            else
                yStep = 1;
        }

    }
}
