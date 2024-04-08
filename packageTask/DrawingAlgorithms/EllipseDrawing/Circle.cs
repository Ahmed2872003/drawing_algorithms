using System.Collections.Generic;
using System.Drawing;

namespace packageTask.DrawingAlgorithms.EllipseDrawing
{
    public class Circle
    {
        public class Result
        {
            public List<string> pks = new List<string>();
            public List<PointF> points = new List<PointF>();
            public List<PointF> originPoints = new List<PointF>();
        }

        public static Result run(Point center, int radius)
        {
            Result res = new Result();

            Point currPoint = new Point(0, radius);

            int pk = 1 - radius;

            res.pks.Add("--");

            res.originPoints.Add(currPoint);

            plotPoint(center, currPoint, ref res);

            while (currPoint.X < currPoint.Y)
            {
                currPoint.X++;

                res.pks.Add(pk.ToString());

                if (pk < 0) pk += 2 * currPoint.X + 1;
                else
                {
                    currPoint.Y--;
                    pk += 2 * (currPoint.X - currPoint.Y) + 1;
                }

                res.originPoints.Add(currPoint);

                plotPoint(center, currPoint, ref res);
            }


            return res;
        }

        private static void plotPoint(Point center, Point p, ref Result res)
        {
            res.points.Add(new Point(center.X + p.X, center.Y + p.Y));
            res.points.Add(new Point(center.X + p.X, center.Y - p.Y));
            res.points.Add(new Point(center.X - p.X, center.Y + p.Y));
            res.points.Add(new Point(center.X - p.X, center.Y - p.Y));

            res.points.Add(new Point(center.X + p.Y, center.Y + p.X));
            res.points.Add(new Point(center.X + p.Y, center.Y - p.X));
            res.points.Add(new Point(center.X - p.Y, center.Y + p.X));
            res.points.Add(new Point(center.X - p.Y, center.Y - p.X));

        }

    }
}
