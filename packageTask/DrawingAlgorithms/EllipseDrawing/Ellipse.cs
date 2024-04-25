using System;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.DrawingAlgorithms.EllipseDrawing
{
    internal class Ellipse
    {
        public class Result
        {
            public List<string> pks = new List<string>();
            public List<PointF> points = new List<PointF>();
            public List<PointF> originPoints = new List<PointF>();
            public int ry = 0;
            public int rx = 0;
        }

        public static Result run(Point center, int rx, int ry)
        {
            Result res = new Result();

            Point currPoint = new Point(0, ry);

            int rySquare = (int)Math.Pow(ry, 2);

            int rxSquare = (int)Math.Pow(rx, 2);

            double twoRySquareX;
            double twoRxSquareY;

            res.ry = ry;
            res.rx = rx;

            part1(center, rx, ry, rxSquare, rySquare, out twoRxSquareY, out twoRySquareX, ref currPoint, ref res);
            part2(center, rx, ry, rxSquare, rySquare, out twoRxSquareY, out twoRySquareX, ref currPoint, ref res);


            return res;

        }

        private static void part1(Point center, int rx, int ry, int rxSquare, int rySquare, out double twoRxSquareY, out double twoRySquareX, ref Point currPoint, ref Result res)
        {
            twoRySquareX = 2 * rySquare * currPoint.X;

            twoRxSquareY = 2 * rxSquare * currPoint.Y;

            double p = Math.Pow(ry, 2) - Math.Pow(rx, 2) * ry + (double)(.25 * Math.Pow(rx, 2));

            res.originPoints.Add(currPoint);

            res.pks.Add("--");

            plotPoint(center, currPoint, ref res);

            while (twoRySquareX < twoRxSquareY)
            {
                res.pks.Add(p.ToString());

                if (p < 0)
                {
                    currPoint.X++;
                    twoRySquareX = 2 * rySquare * currPoint.X;
                    p += twoRySquareX + rySquare;
                }
                else
                {
                    currPoint.X++;
                    currPoint.Y--;

                    twoRxSquareY = 2 * rxSquare * currPoint.Y;
                    twoRySquareX = 2 * rySquare * currPoint.X;

                    p += twoRySquareX - twoRxSquareY + rySquare;
                }

                res.originPoints.Add(currPoint);

                plotPoint(center, currPoint, ref res);

            }



        }

        private static void part2(Point center, int rx, int ry, int rxSquare, int rySquare, out double twoRxSquareY, out double twoRySquareX, ref Point currPoint, ref Result res)
        {
            twoRySquareX = 2 * rySquare * currPoint.X;
            twoRxSquareY = 2 * rxSquare * currPoint.Y;


            double p = rySquare * Math.Pow(currPoint.X + .5, 2) + rxSquare * Math.Pow(currPoint.Y - 1, 2) - rxSquare * rySquare;

            while (currPoint.Y > 0)
            {
                res.pks.Add(p.ToString());

                if (p > 0)
                {
                    currPoint.Y--;
                    twoRxSquareY = 2 * rxSquare * currPoint.Y;

                    p += -1 * twoRxSquareY + rxSquare;
                }
                else
                {
                    currPoint.X++;
                    currPoint.Y--;

                    twoRySquareX = 2 * rySquare * currPoint.X;
                    twoRxSquareY = 2 * rxSquare * currPoint.Y;

                    p += twoRySquareX - twoRxSquareY + rxSquare;

                }

                res.originPoints.Add(currPoint);

                plotPoint(center, currPoint, ref res);
            }
        }

        private static void plotPoint(Point center, Point p, ref Result res)
        {
            res.points.Add(new Point(center.X + p.X, center.Y + p.Y));
            res.points.Add(new Point(center.X + p.X, center.Y - p.Y));
            res.points.Add(new Point(center.X - p.X, center.Y + p.Y));
            res.points.Add(new Point(center.X - p.X, center.Y - p.Y));

        }
    }
}
