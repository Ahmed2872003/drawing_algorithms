using System;
using System.Collections.Generic;
using System.Drawing;

namespace packageTask.Forms.Transformation
{
    public class TransformTable : TableForm
    {
        List<string> columns = new List<string>() { "(X, Y)" };


        public TransformTable()
        {
            InitializeTable(columns);
        }

        override
        public void fillTable(object res)
        {
            if (!(res is List<List<PointF>>)) return;





            foreach (List<PointF> list in res as List<List<PointF>>)
            {
                foreach (PointF point in list)
                {
                    DGV.Rows.Add("(" + Math.Round(point.X).ToString("0.00") + ", " + Math.Round(point.Y).ToString("0.00") + ")");
                }
            }
        }
    }
}
