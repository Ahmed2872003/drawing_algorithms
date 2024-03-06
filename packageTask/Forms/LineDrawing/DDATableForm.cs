using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using packageTask.DrawingAlgorithms.LineDrawing;

namespace packageTask.Forms.LineDrawing
{
    public partial class DDATableForm : Form
    {
        public DDATableForm()
        {
            InitializeComponent();
        }


        public void fillTable(DDA.Result res) {

            for(int i = 0; i < res.points.Count; i++) {
                PointF pt = res.points[i];
                int roundedX = (int)Math.Round(pt.X);
                int roundedY = (int)Math.Round(pt.Y);

                DGV.Rows.Add(i, res.points[i].X.ToString("0.00"), res.points[i].Y.ToString("0.00"), "(" + roundedX +", " + roundedY + ")");
            }
        }

    }
}
