using packageTask.DrawingAlgorithms.LineDrawing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace packageTask.Forms.LineDrawing
{
    public partial class LineDrawingForm : Form
    {
        public LineDrawingForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Button target = sender as Button;
            object res;

            Boolean isDDA = target.Text == "DDA" ? true : false;

            float stX, stY, enX, enY;

            if (!validateInput(out stX, out stY, out enX, out enY))
            {
                Console.WriteLine("Invalid Input: Input should be a number");
                return;
            }


            Point p1 = new Point((int)stX, (int)stY);
            Point p2 = new Point((int)enX, (int)enY);

            if (isDDA) res = DDA.run(p1, p2);

            else res = Bresenham.run(p1, p2);



            DrawingForm drawingForm = new DrawingForm();


            drawingForm.Visible = true;

            if (res is DDA.Result)
            {
                DDATable DDAT = new DDATable();
                DDAT.Visible = true;

                drawingForm.draw((res as DDA.Result).points, DrawingForm.Type.line);

                DDAT.fillTable(res);

            }
            else
            {
                BresenhamTable BresenhamT = new BresenhamTable();
                BresenhamT.Visible = true;

                drawingForm.draw((res as Bresenham.Result).points, DrawingForm.Type.line);

                BresenhamT.fillTable(res);

            }

        }

        private bool validateInput(out float stX, out float stY, out float enX, out float enY)
        {

            stX = stY = enX = enY = 0;

            if (float.TryParse(x1.Text, out stX) && float.TryParse(y1.Text, out stY) && float.TryParse(x2.Text, out enX) && float.TryParse(y2.Text, out enY))
                return true;


            return false;
        }

    }
}
