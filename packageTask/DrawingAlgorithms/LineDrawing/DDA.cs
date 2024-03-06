using System;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.DrawingAlgorithms.LineDrawing
{
    public class DDA
    {
        public class Result
        {
            public List<PointF> points = new List<PointF>();

            public override string ToString()
            {
                string rep = "";

                foreach (PointF p in points)
                {
                    rep += p.ToString() + '\n';
                }

                return rep;
            }
        }
        public static Result run(Point p1, Point p2)
        {
            Result res = new Result();

            int dx = p2.X - p1.X, dy = p2.Y - p1.Y, steps;

            float xIncrement, yIncrement, x = p1.X, y = p1.Y;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / steps;
            yIncrement = (float)dy / steps;

            for (int k = 0; k < steps + 1; k++)
            {
                res.points.Add(new PointF(x, y));
                x += xIncrement;
                y += yIncrement;
            }

            return res;
        }
    }
} // New Commnet
