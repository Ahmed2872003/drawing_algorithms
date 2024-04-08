using packageTask.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace packageTask.Forms
{
    public partial class DrawingForm : Form
    {
        public enum Type { line, ellipse };

        public DrawingForm()
        {
            InitializeComponent();

        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("(" + this.Width + ", " + this.Height + ")");

        }
        private void drawCoordinates()
        {
            Graphics g = drawingPanel.CreateGraphics();
            float width = drawingPanel.Width;
            float height = drawingPanel.Height;

            // Draw x-axis
            g.DrawLine(Pens.Gray, new PointF(0, height / 2), new PointF(width, height / 2));
            // Draw y-axis
            g.DrawLine(Pens.Gray, new PointF(width / 2, 0), new PointF(width / 2, height));

            // Draw x and y labels
            g.DrawString("X", DefaultFont, Brushes.Black, new PointF(width - 15, height / 2 - 15));
            g.DrawString("Y", DefaultFont, Brushes.Black, new PointF(width / 2 + 10, 0));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawCoordinates();
        }
        public void draw(List<PointF> points, Type type)
        {
            Graphics g = drawingPanel.CreateGraphics();

            Size drawingPanelSize = drawingPanel.Size;

            Brush brush = Brushes.LawnGreen;

            foreach (PointF point in points)
            {
                int x = (int)Math.Round(point.X);
                int y = (int)Math.Round(point.Y);

                ScreenPoint customPoint = new ScreenPoint(x, y);

                PointF p = customPoint.toUnit(drawingPanelSize);

                switch (type)
                {
                    case Type.line:
                        g.FillRectangle(brush, new Rectangle((int)p.X, (int)p.Y, 3, 3));
                        break;
                    case Type.ellipse:
                        g.FillEllipse(brush, new Rectangle((int)p.X, (int)p.Y, 3, 3));
                        break;
                }


            }


        }





        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
