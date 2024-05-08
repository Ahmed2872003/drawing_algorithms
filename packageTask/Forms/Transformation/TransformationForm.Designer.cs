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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.TTBX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TTBY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tTxtBY = new System.Windows.Forms.TextBox();
            this.tTxtBX = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.TRB = new System.Windows.Forms.RadioButton();
            this.RRB = new System.Windows.Forms.RadioButton();
            this.rTxtBTheta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBTheta = new System.Windows.Forms.TrackBar();
            this.SRB = new System.Windows.Forms.RadioButton();
            this.sTxtBX = new System.Windows.Forms.TextBox();
            this.sTxtBY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STBY = new System.Windows.Forms.TrackBar();
            this.STBX = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBX)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(651, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(740, 633);
            this.drawingPanel.TabIndex = 0;
            // 
            // TTBX
            // 
            this.TTBX.LargeChange = 1;
            this.TTBX.Location = new System.Drawing.Point(53, 47);
            this.TTBX.Maximum = 370;
            this.TTBX.Minimum = -370;
            this.TTBX.Name = "TTBX";
            this.TTBX.Size = new System.Drawing.Size(104, 56);
            this.TTBX.TabIndex = 2;
            this.TTBX.ValueChanged += new System.EventHandler(this.TranslateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // TTBY
            // 
            this.TTBY.LargeChange = 1;
            this.TTBY.Location = new System.Drawing.Point(316, 47);
            this.TTBY.Maximum = 316;
            this.TTBY.Minimum = -316;
            this.TTBY.Name = "TTBY";
            this.TTBY.Size = new System.Drawing.Size(104, 56);
            this.TTBY.TabIndex = 4;
            this.TTBY.ValueChanged += new System.EventHandler(this.TranslateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // tTxtBY
            // 
            this.tTxtBY.BackColor = System.Drawing.Color.White;
            this.tTxtBY.Enabled = false;
            this.tTxtBY.Location = new System.Drawing.Point(426, 50);
            this.tTxtBY.Name = "tTxtBY";
            this.tTxtBY.Size = new System.Drawing.Size(46, 22);
            this.tTxtBY.TabIndex = 7;
            this.tTxtBY.Text = "0";
            // 
            // tTxtBX
            // 
            this.tTxtBX.BackColor = System.Drawing.Color.White;
            this.tTxtBX.Enabled = false;
            this.tTxtBX.Location = new System.Drawing.Point(163, 50);
            this.tTxtBX.Name = "tTxtBX";
            this.tTxtBX.Size = new System.Drawing.Size(49, 22);
            this.tTxtBX.TabIndex = 8;
            this.tTxtBX.Text = "0";
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(35, 603);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 9;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // TRB
            // 
            this.TRB.AutoSize = true;
            this.TRB.Location = new System.Drawing.Point(25, 12);
            this.TRB.Name = "TRB";
            this.TRB.Size = new System.Drawing.Size(85, 20);
            this.TRB.TabIndex = 10;
            this.TRB.TabStop = true;
            this.TRB.Text = "Translate";
            this.TRB.UseVisualStyleBackColor = true;
            // 
            // RRB
            // 
            this.RRB.AutoSize = true;
            this.RRB.Location = new System.Drawing.Point(25, 113);
            this.RRB.Name = "RRB";
            this.RRB.Size = new System.Drawing.Size(68, 20);
            this.RRB.TabIndex = 17;
            this.RRB.TabStop = true;
            this.RRB.Text = "Rotate";
            this.RRB.UseVisualStyleBackColor = true;
            // 
            // rTxtBTheta
            // 
            this.rTxtBTheta.BackColor = System.Drawing.Color.White;
            this.rTxtBTheta.Enabled = false;
            this.rTxtBTheta.Location = new System.Drawing.Point(163, 151);
            this.rTxtBTheta.Name = "rTxtBTheta";
            this.rTxtBTheta.Size = new System.Drawing.Size(49, 22);
            this.rTxtBTheta.TabIndex = 16;
            this.rTxtBTheta.Text = "0°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Θ";
            // 
            // RTBTheta
            // 
            this.RTBTheta.LargeChange = 1;
            this.RTBTheta.Location = new System.Drawing.Point(53, 148);
            this.RTBTheta.Maximum = 360;
            this.RTBTheta.Minimum = -360;
            this.RTBTheta.Name = "RTBTheta";
            this.RTBTheta.Size = new System.Drawing.Size(104, 56);
            this.RTBTheta.TabIndex = 11;
            this.RTBTheta.ValueChanged += new System.EventHandler(this.RotateChanged);
            // 
            // SRB
            // 
            this.SRB.AutoSize = true;
            this.SRB.Location = new System.Drawing.Point(25, 210);
            this.SRB.Name = "SRB";
            this.SRB.Size = new System.Drawing.Size(63, 20);
            this.SRB.TabIndex = 24;
            this.SRB.TabStop = true;
            this.SRB.Text = "Scale";
            this.SRB.UseVisualStyleBackColor = true;
            // 
            // sTxtBX
            // 
            this.sTxtBX.BackColor = System.Drawing.Color.White;
            this.sTxtBX.Enabled = false;
            this.sTxtBX.Location = new System.Drawing.Point(163, 248);
            this.sTxtBX.Name = "sTxtBX";
            this.sTxtBX.Size = new System.Drawing.Size(49, 22);
            this.sTxtBX.TabIndex = 23;
            this.sTxtBX.Text = "1";
            // 
            // sTxtBY
            // 
            this.sTxtBY.BackColor = System.Drawing.Color.White;
            this.sTxtBY.Enabled = false;
            this.sTxtBY.Location = new System.Drawing.Point(426, 248);
            this.sTxtBY.Name = "sTxtBY";
            this.sTxtBY.Size = new System.Drawing.Size(46, 22);
            this.sTxtBY.TabIndex = 22;
            this.sTxtBY.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Y";
            // 
            // STBY
            // 
            this.STBY.LargeChange = 1;
            this.STBY.Location = new System.Drawing.Point(316, 245);
            this.STBY.Maximum = 80;
            this.STBY.Minimum = 20;
            this.STBY.Name = "STBY";
            this.STBY.Size = new System.Drawing.Size(104, 56);
            this.STBY.TabIndex = 19;
            this.STBY.Value = 20;
            this.STBY.ValueChanged += new System.EventHandler(this.ScaleChanged);
            // 
            // STBX
            // 
            this.STBX.LargeChange = 1;
            this.STBX.Location = new System.Drawing.Point(53, 245);
            this.STBX.Maximum = 80;
            this.STBX.Minimum = 20;
            this.STBX.Name = "STBX";
            this.STBX.Size = new System.Drawing.Size(104, 56);
            this.STBX.TabIndex = 25;
            this.STBX.Value = 20;
            this.STBX.ValueChanged += new System.EventHandler(this.ScaleChanged);
            // 
            // TransformationForm
            // 
            this.ClientSize = new System.Drawing.Size(1403, 657);
            this.Controls.Add(this.STBX);
            this.Controls.Add(this.SRB);
            this.Controls.Add(this.sTxtBX);
            this.Controls.Add(this.sTxtBY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.STBY);
            this.Controls.Add(this.RRB);
            this.Controls.Add(this.rTxtBTheta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBTheta);
            this.Controls.Add(this.TRB);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.tTxtBX);
            this.Controls.Add(this.tTxtBY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TTBY);
            this.Controls.Add(this.TTBX);
            this.Controls.Add(this.drawingPanel);
            this.Name = "TransformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TTBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TrackBar TTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TTBY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTxtBY;
        private System.Windows.Forms.TextBox tTxtBX;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.RadioButton TRB;
        private System.Windows.Forms.RadioButton RRB;
        private System.Windows.Forms.TextBox rTxtBTheta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar RTBTheta;
        private System.Windows.Forms.RadioButton SRB;
        private System.Windows.Forms.TextBox sTxtBX;
        private System.Windows.Forms.TextBox sTxtBY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar STBY;
        private System.Windows.Forms.TrackBar STBX;
    }
}