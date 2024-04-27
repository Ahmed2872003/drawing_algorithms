using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace packageTask.Forms.Transformation
{

    public partial class TransformationForm : Form
    {

        private Image image;

        private Matrix matrix = new Matrix();

        static Point prevTransP = new Point(0, 0);
        static PointF prevScale = new PointF(1f, 1f);
        static PointF prevShear = new PointF(0f, 0f);

        static float prevRotateAngle = 0;

        public TransformationForm()
        {
            InitializeComponent();

            string imagePath = Path.GetFullPath("../../assets/supertriangle.png");

            textBox1.Text = imagePath;

            LoadImage(imagePath);
        }

        private void LoadImage(string imagePath)
        {

            this.image = Image.FromFile(imagePath);

            pictureBox1.Image = image;

        }

        private Bitmap ApplyTranslation(Image image, Point T)
        {
            Bitmap transformedImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(transformedImage))
            {

                matrix.Translate(-prevTransP.X, -prevTransP.Y);

                matrix.Translate(T.X, T.Y);

                g.Transform = matrix;
                g.DrawImage(image, new Point(0, 0));
            }

            prevTransP.X = T.X;
            prevTransP.Y = T.Y;

            return transformedImage;
        }

        private Bitmap ApplyRotation(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                matrix.Translate(image.Width / 2, image.Height / 2);

                matrix.Rotate(-prevRotateAngle);

                matrix.Rotate(angle);

                matrix.Translate(-image.Width / 2, -image.Height / 2);

                g.Transform = matrix;

                g.DrawImage(image, new Point(0, 0));
            }

            prevRotateAngle = angle;

            return rotatedImage;
        }

        private Bitmap ApplyScaling(Image image, PointF S)
        {
            Bitmap scaledImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(scaledImage))
            {

                matrix.Translate(image.Width / 2, image.Height / 2);

                matrix.Scale(1 / prevScale.X, 1 / prevScale.Y);

                matrix.Scale(S.X, S.Y);

                matrix.Translate(-image.Width / 2, -image.Height / 2);

                g.Transform = matrix;

                g.DrawImage(image, new Point(0, 0));
            }

            prevScale = S;

            return scaledImage;
        }


        private Bitmap ApplyShearing(Image image, PointF SH)
        {
            Bitmap scaledImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(scaledImage))
            {

                matrix.Translate(image.Width / 2, image.Height / 2);

                matrix.Shear(-prevShear.X, -prevShear.Y);

                matrix.Shear(SH.X, SH.Y);

                matrix.Translate(-image.Width / 2, -image.Height / 2);

                g.Transform = matrix;

                g.DrawImage(image, new Point(0, 0));
            }

            prevShear = SH;



            return scaledImage;

        }


        private void transTrackBar_ValueChanged(object sender, System.EventArgs e)
        {

            tranXTB.Text = transTrackBarX.Value.ToString();
            tranYTB.Text = transTrackBarY.Value.ToString();

            if (tranCB.Checked)
                pictureBox1.Image = ApplyTranslation(image, new Point(transTrackBarX.Value, transTrackBarY.Value));

            else
                pictureBox1.Image = ApplyTranslation(image, new Point(0, 0));

        }


        private void CheckBoxListener(object sender, System.EventArgs e)
        {

            CheckBox targetCB = (sender as CheckBox);

            string transformation = targetCB.Text;


            if (!listBox1.Items.Contains(transformation) && targetCB.Checked) listBox1.Items.Add(transformation);

            else if (listBox1.Items.Contains(transformation) && !targetCB.Checked) listBox1.Items.Remove(transformation);


            switch (transformation)
            {
                case "Translate":
                    transTrackBar_ValueChanged(sender, e);
                    break;
                case "Rotate":
                    trackBar2_ValueChanged(sender, e);
                    break;
                case "Scale":
                    Scale_trackBar_ValueChanged(sender, e);
                    break;
                case "Shear":
                    Shear_trackBar_ValueChanged(sender, e);
                    break;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);

                pictureBox1.Image = image;

                textBox1.Text = openFileDialog.FileName;

                Reset(null, null);
            }
        }


        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            degreeTB.Text = angelTrackBar.Value + "°";

            if (rotCB.Checked)
                pictureBox1.Image = ApplyRotation(image, angelTrackBar.Value);
            else
                pictureBox1.Image = ApplyRotation(image, 0);
        }
        private void Scale_trackBar_ValueChanged(object sender, EventArgs e)
        {
            PointF S = new PointF(scaleTrackBarX.Value / 10f, scaleTrackBarY.Value / 10f);

            scaleYTB.Text = S.Y.ToString();
            scaleXTB.Text = S.X.ToString();

            if (scaleCB.Checked)
                pictureBox1.Image = ApplyScaling(image, S);
            else
                pictureBox1.Image = ApplyScaling(image, new PointF(1, 1));
        }


        private void Shear_trackBar_ValueChanged(object sender, EventArgs e)
        {


            PointF SH = new PointF(shearTrackBarX.Value / 10f, shearTrackBarY.Value / 10f);

            shearXTB.Text = SH.X.ToString();
            shearYTB.Text = SH.Y.ToString();

            if (shearCB.Checked)
                pictureBox1.Image = ApplyShearing(image, SH);
            else
                pictureBox1.Image = ApplyShearing(image, new PointF(0, 0));
        }


        private void Reset(object sender, EventArgs e)
        {

            tranCB.Checked = rotCB.Checked = shearCB.Checked = scaleCB.Checked = false;

            angelTrackBar.Value = 0;
            transTrackBarX.Value = transTrackBarY.Value = 0;
            shearTrackBarX.Value = shearTrackBarY.Value = 0;
            scaleTrackBarX.Value = scaleTrackBarY.Value = 10;

            matrix = new Matrix();

            listBox1.Items.Clear();

            pictureBox1.BackColor = Color.White;

            pictureBox1.Image = image;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog.Color;
            }


        }

    }
}
