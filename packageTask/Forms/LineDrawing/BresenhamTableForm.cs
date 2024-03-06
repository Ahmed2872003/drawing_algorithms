using packageTask.DrawingAlgorithms.LineDrawing;
using System.Drawing;
using System.Windows.Forms;

namespace packageTask.Forms.LineDrawing
{
    public partial class BresenhamTableForm : Form
    {
        public BresenhamTableForm()
        {
            InitializeComponent();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fillTable(Bresenham.Result res)
        {
            for (int i = 0; i < res.points.Count; i++)
            {
                PointF pt = res.points[i];

                DGV.Rows.Add(i, res.p[i], "(" + res.points[i].X + ", " + res.points[i].Y + ")");
            }
        }
    }
}
