using packageTask.DrawingAlgorithms.EllipseDrawing;
using System.Collections.Generic;

namespace packageTask.Forms.EllipseDrawing
{
    internal class CircleTable : TableForm
    {
        private List<string> columns = new List<string>() { "K", "Pk", "(X, Y)", "2X", "2Y" };

        public CircleTable()
        {
            InitializeTable(columns);
        }


        public override void fillTable(object res)
        {
            if (!(res is Circle.Result)) return;

            Circle.Result result = res as Circle.Result;

            for (int i = 0; i < result.originPoints.Count; i++)
            {
                int X = (int)result.originPoints[i].X;
                int Y = (int)result.originPoints[i].Y;

                DGV.Rows.Add(i, result.pks[i], "(" + X + ", " + Y + ")", 2 * X, 2 * Y);
            }




        }
    }
}