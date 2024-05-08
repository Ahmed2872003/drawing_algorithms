using packageTask.DrawingAlgorithms.LineDrawing;
using packageTask.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace packageTask.Forms.Transformation
{

    public partial class TransformationForm : Form
    {
        readonly private DrawingForm drawingForm = new DrawingForm();

        readonly private Graphics drawingPanelG;

        readonly private PointF[] defTrianglePoints = new PointF[] {
            new PointF(-50, 0),
            new PointF(50, 0),
            new PointF(0, 75)
        };

        readonly private PointF[] trianglePoints = new PointF[3];

        private Point prevTranslate = new Point(0, 0);

        public TransformationForm()
        {
            defTrianglePoints.CopyTo(trianglePoints, 0);

            InitializeComponent();
            drawingPanel.Paint += InitialDisplay;

            drawingPanelG = drawingPanel.CreateGraphics();
        }

        private List<List<PointF>> DrawTriangle()
        {

            Size panelS = drawingPanel.Size;
            Pen b = new Pen(Color.LawnGreen, 2);

            PointF p1 = CustomPoint.convertToUnit(trianglePoints[0], panelS);
            PointF p2 = CustomPoint.convertToUnit(trianglePoints[1], panelS);
            PointF p3 = CustomPoint.convertToUnit(trianglePoints[2], panelS);

            drawingPanelG.DrawLine(b, p1, p2);
            drawingPanelG.DrawLine(b, p1, p3);
            drawingPanelG.DrawLine(b, p2, p3);

            p1 = trianglePoints[0];
            p2 = trianglePoints[1];
            p3 = trianglePoints[2];


            return new List<List<PointF>>
            {
                DDA.run(p1, p2).points,
                DDA.run(p1, p3).points,
                DDA.run(p2, p3).points
            };

        }

        // 2D Transformations
        private void ApplyTranslate(Point T)
        {
            for (int i = 0; i < trianglePoints.Length; i++)
            {
                ref PointF p = ref trianglePoints[i];


                // back to origin to origin
                p.X -= prevTranslate.X;
                p.Y -= prevTranslate.Y;

                // Apply translation
                p.X += T.X;
                p.Y += T.Y;
            }

            prevTranslate = T;

        }

        // Events
        private void drawBtn_Click(object sender, EventArgs e)
        {
            bool transformChecked = false;

            if (TRB.Checked)
            {
                Point T = new Point(TTBX.Value, TTBY.Value);

                ApplyTranslate(T);

                transformChecked = true;
            }

            if (transformChecked)
            {
                drawingPanelG.Clear(Color.White);

                drawingForm.drawCoordinates(ref drawingPanel);

                TransformTable TT = new TransformTable();

                TT.Visible = true;

                TT.fillTable(DrawTriangle());




            }


        }

        private void TranslateChanged(object sender, EventArgs e)
        {
            tTxtBX.Text = TTBX.Value.ToString();
            tTxtBY.Text = TTBY.Value.ToString();
        }

        private void InitialDisplay(object sender, EventArgs e)
        {
            Console.WriteLine("Hey");
            drawingForm.drawCoordinates(ref drawingPanel);
            DrawTriangle();
            drawingPanel.Paint -= InitialDisplay;
        }

    }
}
