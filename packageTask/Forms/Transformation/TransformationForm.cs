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
            new PointF(0, 120)
        };

        readonly private PointF[] trianglePoints = new PointF[3];

        // Previous Transformations
        private Point prevTranslation = new Point(0, 0);
        private int prevRotation = 0;
        private PointF prevScaling = new PointF(1.0f, 1.0f);

        TransformTable TT = null;

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
        private void ApplyTranslation(Point T)
        {
            for (int i = 0; i < trianglePoints.Length; i++)
            {
                ref PointF p = ref trianglePoints[i];


                // back to origin to origin
                TranslatePoint(ref p, new Point(-prevTranslation.X, -prevTranslation.Y));

                // Apply translation
                TranslatePoint(ref p, T);
            }

            prevTranslation = T;

        }

        private void TranslatePoint(ref PointF p, Point T)
        {
            p.X += T.X;
            p.Y += T.Y;
        }

        private void ApplyRotation(int theta)
        {
            Point originalT = prevTranslation;
            // back to origin
            ApplyTranslation(new Point(0, 0));

            for (int i = 0; i < trianglePoints.Length; i++)
            {
                ref PointF p = ref trianglePoints[i];



                // Rotate to default
                RotatePoint(ref p, -prevRotation);

                // Apply new rotation
                RotatePoint(ref p, theta);



            }

            // take back the point to the original position
            ApplyTranslation(originalT);


            prevRotation = theta;
        }
        private void RotatePoint(ref PointF p, int theta)
        {
            float radians = theta * (float)Math.PI / 180f;

            float oldX = p.X;

            p.X = (float)(p.X * Math.Cos(radians) - p.Y * Math.Sin(radians));

            p.Y = (float)(oldX * Math.Sin(radians) + p.Y * Math.Cos(radians));
        }

        private void ApplyScaling(PointF S)
        {
            ApplyTranslation(new Point(0, 0));

            for (int i = 0; i < trianglePoints.Length; i++)
            {

                ScalePoint(ref trianglePoints[i], new PointF(1 / prevScaling.X, 1 / prevScaling.Y));

                ScalePoint(ref trianglePoints[i], S);

            }

            ApplyTranslation(prevTranslation);

            prevScaling = S;
        }
        private void ScalePoint(ref PointF p, PointF S)
        {
            p.X *= S.X;
            p.Y *= S.Y;
        }

        // Events
        private void drawBtn_Click(object sender, EventArgs e)
        {
            bool transformChecked = false;

            if (TRB.Checked)
            {
                Point T = new Point(TTBX.Value, TTBY.Value);

                ApplyTranslation(T);

                transformChecked = true;
            }

            if (RRB.Checked)
            {
                ApplyRotation(-RTBTheta.Value);

                transformChecked = true;
            }

            if (SRB.Checked)
            {
                float sx = STBX.Value != 0 ? STBX.Value : 1;
                float sy = STBY.Value != 0 ? STBY.Value : 1;

                ApplyScaling(new PointF(sx / 20f, sy / 20f));


                transformChecked = true;
            }


            if (transformChecked)
            {
                drawingPanelG.Clear(Color.White);

                drawingForm.drawCoordinates(ref drawingPanel);

                if (TT == null || TT.IsDisposed)
                {
                    TT = new TransformTable();
                    TT.Visible = true;
                }
                else TT.DGV.Rows.Clear();


                TT.fillTable(DrawTriangle());


            }


        }

        private void TranslateChanged(object sender, EventArgs e)
        {
            tTxtBX.Text = TTBX.Value.ToString();
            tTxtBY.Text = TTBY.Value.ToString();
        }

        private void RotateChanged(object sender, EventArgs e)
        {
            rTxtBTheta.Text = RTBTheta.Value.ToString() + "°";
        }

        private void ScaleChanged(object sender, EventArgs e)
        {
            sTxtBX.Text = (STBX.Value / 20f).ToString();
            sTxtBY.Text = (STBY.Value / 20f).ToString();
        }
        private void InitialDisplay(object sender, EventArgs e)
        {
            drawingForm.drawCoordinates(ref drawingPanel);
            DrawTriangle();
            drawingPanel.Paint -= InitialDisplay;
        }


    }
}
