﻿using packageTask.DrawingAlgorithms.EllipseDrawing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace packageTask.Forms.EllipseDrawing
{
    public partial class EllipseForm : Form
    {
        bool isEllipseMode = true;

        public EllipseForm()
        {
            InitializeComponent();
            circlePanel.Enabled = false;
        }

        private void toggleMode(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;

            if (RB.Text == "Circle")
            {
                isEllipseMode = false;
                ellipsePanel.Enabled = false;
                circlePanel.Enabled = true;
            }
            else
            {

                isEllipseMode = true;
                ellipsePanel.Enabled = true;
                circlePanel.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xCenter, yCenter, r, xr, yr;

            if (!int.TryParse(xCenterTB.Text, out xCenter) || !int.TryParse(yCenterTB.Text, out yCenter))
            {
                Console.WriteLine("Enter a valid center point (Integer value)");
                return;
            }


            if (isEllipseMode)
            {
                if (!int.TryParse(xRadiusTB.Text, out xr) || !int.TryParse(yRadiusTB.Text, out yr))
                {
                    Console.WriteLine("Enter a valid xr and yr");
                    return;
                }
                drawEllipse(new Point(xCenter, yCenter), xr, yr);
            }
            else
            {
                if (!int.TryParse(radiusTB.Text, out r))
                {
                    Console.WriteLine("Enter a valid radius (Integer value)");
                    return;
                }

                drawCircle(new Point(xCenter, yCenter), r);
            }
        }

        private void drawCircle(Point center, int r)
        {
            Circle.Result result = Circle.run(center, r);

            DrawingForm DrawingForm = new DrawingForm();
            CircleTable circleTable = new CircleTable();

            DrawingForm.Visible = true;
            circleTable.Visible = true;

            DrawingForm.draw(result.points, DrawingForm.Type.ellipse);

            circleTable.fillTable(result);

        }

        private void drawEllipse(Point center, int rx, int ry)
        {
            Ellipse.Result result = Ellipse.run(center, rx, ry);

            DrawingForm DrawingForm = new DrawingForm();
            EllipseTable ellipseTable = new EllipseTable();

            DrawingForm.Visible = true;
            ellipseTable.Visible = true;

            DrawingForm.draw(result.points, DrawingForm.Type.ellipse);

            ellipseTable.fillTable(result);
        }


    }
}
