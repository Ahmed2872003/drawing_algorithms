namespace packageTask.Forms.Transformation
{
    partial class TransformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.transTrackBarX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transTrackBarY = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.angelTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.degreeTB = new System.Windows.Forms.TextBox();
            this.tranCB = new System.Windows.Forms.CheckBox();
            this.rotCB = new System.Windows.Forms.CheckBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tranYTB = new System.Windows.Forms.TextBox();
            this.tranXTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.scaleXTB = new System.Windows.Forms.TextBox();
            this.scaleYTB = new System.Windows.Forms.TextBox();
            this.scaleCB = new System.Windows.Forms.CheckBox();
            this.scaleTrackBarY = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.scaleTrackBarX = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.transTrackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transTrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBarX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // transTrackBarX
            // 
            this.transTrackBarX.Location = new System.Drawing.Point(575, 81);
            this.transTrackBarX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transTrackBarX.Maximum = 200;
            this.transTrackBarX.Minimum = -200;
            this.transTrackBarX.Name = "transTrackBarX";
            this.transTrackBarX.Size = new System.Drawing.Size(103, 56);
            this.transTrackBarX.TabIndex = 2;
            this.transTrackBarX.ValueChanged += new System.EventHandler(this.transTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // transTrackBarY
            // 
            this.transTrackBarY.Location = new System.Drawing.Point(575, 128);
            this.transTrackBarY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transTrackBarY.Maximum = 200;
            this.transTrackBarY.Minimum = -200;
            this.transTrackBarY.Name = "transTrackBarY";
            this.transTrackBarY.Size = new System.Drawing.Size(103, 56);
            this.transTrackBarY.TabIndex = 6;
            this.transTrackBarY.ValueChanged += new System.EventHandler(this.transTrackBar_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select image";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 527);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(827, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Angle";
            // 
            // angelTrackBar
            // 
            this.angelTrackBar.Location = new System.Drawing.Point(870, 81);
            this.angelTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angelTrackBar.Maximum = 360;
            this.angelTrackBar.Minimum = -360;
            this.angelTrackBar.Name = "angelTrackBar";
            this.angelTrackBar.Size = new System.Drawing.Size(103, 56);
            this.angelTrackBar.TabIndex = 11;
            this.angelTrackBar.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(912, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 10;
            // 
            // degreeTB
            // 
            this.degreeTB.Location = new System.Drawing.Point(979, 89);
            this.degreeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeTB.Name = "degreeTB";
            this.degreeTB.ReadOnly = true;
            this.degreeTB.Size = new System.Drawing.Size(49, 22);
            this.degreeTB.TabIndex = 13;
            this.degreeTB.Text = "0°";
            // 
            // tranCB
            // 
            this.tranCB.AutoSize = true;
            this.tranCB.Location = new System.Drawing.Point(557, 26);
            this.tranCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tranCB.Name = "tranCB";
            this.tranCB.Size = new System.Drawing.Size(96, 20);
            this.tranCB.TabIndex = 14;
            this.tranCB.Text = "Translation";
            this.tranCB.UseVisualStyleBackColor = true;
            this.tranCB.CheckedChanged += new System.EventHandler(this.CheckBoxListener);
            // 
            // rotCB
            // 
            this.rotCB.AutoSize = true;
            this.rotCB.Location = new System.Drawing.Point(817, 28);
            this.rotCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotCB.Name = "rotCB";
            this.rotCB.Size = new System.Drawing.Size(79, 20);
            this.rotCB.TabIndex = 15;
            this.rotCB.Text = "Rotation";
            this.rotCB.UseVisualStyleBackColor = true;
            this.rotCB.CheckedChanged += new System.EventHandler(this.CheckBoxListener);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(981, 487);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(84, 30);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.Reset);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(547, 389);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 84);
            this.listBox1.TabIndex = 17;
            // 
            // tranYTB
            // 
            this.tranYTB.Location = new System.Drawing.Point(684, 139);
            this.tranYTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tranYTB.Name = "tranYTB";
            this.tranYTB.ReadOnly = true;
            this.tranYTB.Size = new System.Drawing.Size(49, 22);
            this.tranYTB.TabIndex = 18;
            this.tranYTB.Text = "0";
            // 
            // tranXTB
            // 
            this.tranXTB.Location = new System.Drawing.Point(684, 89);
            this.tranXTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tranXTB.Name = "tranXTB";
            this.tranXTB.ReadOnly = true;
            this.tranXTB.Size = new System.Drawing.Size(49, 22);
            this.tranXTB.TabIndex = 19;
            this.tranXTB.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Transformation order";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 487);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scaleXTB
            // 
            this.scaleXTB.Location = new System.Drawing.Point(684, 242);
            this.scaleXTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleXTB.Name = "scaleXTB";
            this.scaleXTB.ReadOnly = true;
            this.scaleXTB.Size = new System.Drawing.Size(49, 22);
            this.scaleXTB.TabIndex = 28;
            this.scaleXTB.Text = "1";
            // 
            // scaleYTB
            // 
            this.scaleYTB.Location = new System.Drawing.Point(684, 292);
            this.scaleYTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleYTB.Name = "scaleYTB";
            this.scaleYTB.ReadOnly = true;
            this.scaleYTB.Size = new System.Drawing.Size(49, 22);
            this.scaleYTB.TabIndex = 27;
            this.scaleYTB.Text = "1";
            // 
            // scaleCB
            // 
            this.scaleCB.AutoSize = true;
            this.scaleCB.Location = new System.Drawing.Point(557, 179);
            this.scaleCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleCB.Name = "scaleCB";
            this.scaleCB.Size = new System.Drawing.Size(74, 20);
            this.scaleCB.TabIndex = 26;
            this.scaleCB.Text = "Scaling";
            this.scaleCB.UseVisualStyleBackColor = true;
            this.scaleCB.CheckedChanged += new System.EventHandler(this.CheckBoxListener);
            // 
            // scaleTrackBarY
            // 
            this.scaleTrackBarY.Location = new System.Drawing.Point(575, 281);
            this.scaleTrackBarY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleTrackBarY.Maximum = 20;
            this.scaleTrackBarY.Minimum = 1;
            this.scaleTrackBarY.Name = "scaleTrackBarY";
            this.scaleTrackBarY.Size = new System.Drawing.Size(103, 56);
            this.scaleTrackBarY.TabIndex = 25;
            this.scaleTrackBarY.Value = 10;
            this.scaleTrackBarY.ValueChanged += new System.EventHandler(this.Scale_trackBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "X";
            // 
            // scaleTrackBarX
            // 
            this.scaleTrackBarX.Location = new System.Drawing.Point(575, 234);
            this.scaleTrackBarX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleTrackBarX.Maximum = 20;
            this.scaleTrackBarX.Minimum = 1;
            this.scaleTrackBarX.Name = "scaleTrackBarX";
            this.scaleTrackBarX.Size = new System.Drawing.Size(103, 56);
            this.scaleTrackBarX.TabIndex = 22;
            this.scaleTrackBarX.Value = 10;
            this.scaleTrackBarX.ValueChanged += new System.EventHandler(this.Scale_trackBar_ValueChanged);
            // 
            // TransformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 561);
            this.Controls.Add(this.scaleXTB);
            this.Controls.Add(this.scaleYTB);
            this.Controls.Add(this.scaleCB);
            this.Controls.Add(this.scaleTrackBarY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.scaleTrackBarX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tranXTB);
            this.Controls.Add(this.tranYTB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.rotCB);
            this.Controls.Add(this.tranCB);
            this.Controls.Add(this.degreeTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.angelTrackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transTrackBarY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transTrackBarX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransformationForm";
            ((System.ComponentModel.ISupportInitialize)(this.transTrackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transTrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBarX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar transTrackBarX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar transTrackBarY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar angelTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox degreeTB;
        private System.Windows.Forms.CheckBox tranCB;
        private System.Windows.Forms.CheckBox rotCB;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tranYTB;
        private System.Windows.Forms.TextBox tranXTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox scaleXTB;
        private System.Windows.Forms.TextBox scaleYTB;
        private System.Windows.Forms.CheckBox scaleCB;
        private System.Windows.Forms.TrackBar scaleTrackBarY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar scaleTrackBarX;
    }
}