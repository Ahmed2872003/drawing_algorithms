using packageTask.DrawingAlgorithms.LineDrawing;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.Forms.LineDrawing
{
    public class BresenhamTable : TableForm
    {
        private List<string> columns = new List<string>() { "K", "P K", "(X k+1, Y k+1)" };
        public BresenhamTable()
        {
            InitializeTable(columns);
        }

        override
        public void fillTable(object gRes)
        {
            if (!(gRes is Bresenham.Result)) return;

            Bresenham.Result res = gRes as Bresenham.Result;

            for (int i = 0; i < res.points.Count; i++)
            {
                PointF pt = res.points[i];

                DGV.Rows.Add(i, res.p[i], "(" + res.points[i].X + ", " + res.points[i].Y + ")");
            }

        }
    }
}
