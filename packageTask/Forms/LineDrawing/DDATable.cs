using packageTask.DrawingAlgorithms.LineDrawing;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.Forms.LineDrawing
{
    public class DDATable : TableForm
    {
        private List<string> columns = new List<string>() { "K", "X", "Y", "(X, Y)" };
        public DDATable()
        {
            InitializeTable(columns);
        }

        override
        public void fillTable(object gRes)
        {
            if (!(gRes is DDA.Result)) return;

            DDA.Result res = gRes as DDA.Result;


            for (int i = 0; i < res.points.Count; i++)
            {
                PointF pt = res.points[i];
                int roundedX = (int)Math.Round(pt.X);
                int roundedY = (int)Math.Round(pt.Y);

                DGV.Rows.Add(i, res.points[i].X.ToString("0.00"), res.points[i].Y.ToString("0.00"), "(" + roundedX + ", " + roundedY + ")");
            }
        }
    }
}
