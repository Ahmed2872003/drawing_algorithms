using packageTask.DrawingAlgorithms.EllipseDrawing;
using System;
using System.Collections.Generic;

namespace packageTask.Forms.EllipseDrawing
{
    internal class EllipseTable : TableForm
    {
        private List<string> columns = new List<string>() { "K", "P", "(X, Y)", "(2ry^2)*X", "(2rx^2)*Y" };

        public EllipseTable()
        {
            InitializeTable(columns);
        }


        public override void fillTable(object res)
        {
            if (!(res is Ellipse.Result)) return;

            Ellipse.Result result = res as Ellipse.Result;

            for (int i = 0; i < result.originPoints.Count; i++)
            {
                int X = (int)result.originPoints[i].X;
                int Y = (int)result.originPoints[i].Y;

                double twoRySquareX = 2 * Math.Pow(result.ry, 2) * X;
                double twoRxSquarey = 2 * Math.Pow(result.rx, 2) * Y;

                DGV.Rows.Add(i, result.pks[i], "(" + X + ", " + Y + ")", twoRySquareX, twoRxSquarey);
            }
        }
    }
}
