﻿using packageTask.Forms.EllipseDrawing;
using packageTask.Forms.LineDrawing;
using packageTask.Forms.Transformation;
using System;
using System.Windows.Forms;

namespace packageTask.Forms
{
    public partial class MenuFrom : Form
    {
        public MenuFrom()
        {
            InitializeComponent();
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            LineDrawingForm lineDrawingForm = new LineDrawingForm();

            lineDrawingForm.Visible = true;
        }

        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            EllipseForm ellipseForm = new EllipseForm();

            ellipseForm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransformationForm transformationForm = new TransformationForm();

            transformationForm.Visible = true;
        }
    }
}
