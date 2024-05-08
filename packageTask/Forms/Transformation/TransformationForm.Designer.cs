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
            this.SCTBX = new System.Windows.Forms.TrackBar();
            this.SCRB = new System.Windows.Forms.RadioButton();
            this.scTxtBX = new System.Windows.Forms.TextBox();
            this.scTxtBY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SCTBY = new System.Windows.Forms.TrackBar();
            this.ReflectionGroup = new System.Windows.Forms.GroupBox();
            this.RORB = new System.Windows.Forms.RadioButton();
            this.RXRB = new System.Windows.Forms.RadioButton();
            this.RYRB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.RFRB = new System.Windows.Forms.RadioButton();
            this.resetBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCTBY)).BeginInit();
            this.ReflectionGroup.SuspendLayout();
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
            // SCTBX
            // 
            this.SCTBX.LargeChange = 1;
            this.SCTBX.Location = new System.Drawing.Point(53, 332);
            this.SCTBX.Maximum = 6;
            this.SCTBX.Minimum = -6;
            this.SCTBX.Name = "SCTBX";
            this.SCTBX.Size = new System.Drawing.Size(104, 56);
            this.SCTBX.TabIndex = 32;
            this.SCTBX.ValueChanged += new System.EventHandler(this.ShearingChanged);
            // 
            // SCRB
            // 
            this.SCRB.AutoSize = true;
            this.SCRB.Location = new System.Drawing.Point(25, 297);
            this.SCRB.Name = "SCRB";
            this.SCRB.Size = new System.Drawing.Size(64, 20);
            this.SCRB.TabIndex = 31;
            this.SCRB.TabStop = true;
            this.SCRB.Text = "Shear";
            this.SCRB.UseVisualStyleBackColor = true;
            // 
            // scTxtBX
            // 
            this.scTxtBX.BackColor = System.Drawing.Color.White;
            this.scTxtBX.Enabled = false;
            this.scTxtBX.Location = new System.Drawing.Point(163, 335);
            this.scTxtBX.Name = "scTxtBX";
            this.scTxtBX.Size = new System.Drawing.Size(49, 22);
            this.scTxtBX.TabIndex = 30;
            this.scTxtBX.Text = "0";
            // 
            // scTxtBY
            // 
            this.scTxtBY.BackColor = System.Drawing.Color.White;
            this.scTxtBY.Enabled = false;
            this.scTxtBY.Location = new System.Drawing.Point(426, 335);
            this.scTxtBY.Name = "scTxtBY";
            this.scTxtBY.Size = new System.Drawing.Size(46, 22);
            this.scTxtBY.TabIndex = 29;
            this.scTxtBY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Y";
            // 
            // SCTBY
            // 
            this.SCTBY.LargeChange = 1;
            this.SCTBY.Location = new System.Drawing.Point(316, 332);
            this.SCTBY.Maximum = 6;
            this.SCTBY.Minimum = -6;
            this.SCTBY.Name = "SCTBY";
            this.SCTBY.Size = new System.Drawing.Size(104, 56);
            this.SCTBY.TabIndex = 26;
            this.SCTBY.ValueChanged += new System.EventHandler(this.ShearingChanged);
            // 
            // ReflectionGroup
            // 
            this.ReflectionGroup.Controls.Add(this.button1);
            this.ReflectionGroup.Controls.Add(this.RYRB);
            this.ReflectionGroup.Controls.Add(this.RXRB);
            this.ReflectionGroup.Controls.Add(this.RORB);
            this.ReflectionGroup.Location = new System.Drawing.Point(53, 410);
            this.ReflectionGroup.Name = "ReflectionGroup";
            this.ReflectionGroup.Size = new System.Drawing.Size(367, 100);
            this.ReflectionGroup.TabIndex = 37;
            this.ReflectionGroup.TabStop = false;
            // 
            // RORB
            // 
            this.RORB.AutoSize = true;
            this.RORB.Location = new System.Drawing.Point(6, 32);
            this.RORB.Name = "RORB";
            this.RORB.Size = new System.Drawing.Size(63, 20);
            this.RORB.TabIndex = 0;
            this.RORB.TabStop = true;
            this.RORB.Text = "Origin";
            this.RORB.UseVisualStyleBackColor = true;
            // 
            // RXRB
            // 
            this.RXRB.AutoSize = true;
            this.RXRB.Location = new System.Drawing.Point(123, 32);
            this.RXRB.Name = "RXRB";
            this.RXRB.Size = new System.Drawing.Size(64, 20);
            this.RXRB.TabIndex = 1;
            this.RXRB.TabStop = true;
            this.RXRB.Text = "X-axis";
            this.RXRB.UseVisualStyleBackColor = true;
            // 
            // RYRB
            // 
            this.RYRB.AutoSize = true;
            this.RYRB.Location = new System.Drawing.Point(244, 32);
            this.RYRB.Name = "RYRB";
            this.RYRB.Size = new System.Drawing.Size(65, 20);
            this.RYRB.TabIndex = 2;
            this.RYRB.TabStop = true;
            this.RYRB.Text = "Y-axis";
            this.RYRB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Uncheck";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RFRB
            // 
            this.RFRB.AutoSize = true;
            this.RFRB.Location = new System.Drawing.Point(25, 394);
            this.RFRB.Name = "RFRB";
            this.RFRB.Size = new System.Drawing.Size(70, 20);
            this.RFRB.TabIndex = 38;
            this.RFRB.TabStop = true;
            this.RFRB.Text = "Reflect";
            this.RFRB.UseVisualStyleBackColor = true;
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(570, 603);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(75, 23);
            this.resetBTN.TabIndex = 39;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // TransformationForm
            // 
            this.ClientSize = new System.Drawing.Size(1403, 657);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.RFRB);
            this.Controls.Add(this.ReflectionGroup);
            this.Controls.Add(this.SCTBX);
            this.Controls.Add(this.SCRB);
            this.Controls.Add(this.scTxtBX);
            this.Controls.Add(this.scTxtBY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SCTBY);
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
            ((System.ComponentModel.ISupportInitialize)(this.SCTBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCTBY)).EndInit();
            this.ReflectionGroup.ResumeLayout(false);
            this.ReflectionGroup.PerformLayout();
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
        private System.Windows.Forms.TrackBar SCTBX;
        private System.Windows.Forms.RadioButton SCRB;
        private System.Windows.Forms.TextBox scTxtBX;
        private System.Windows.Forms.TextBox scTxtBY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar SCTBY;
        private System.Windows.Forms.GroupBox ReflectionGroup;
        private System.Windows.Forms.RadioButton RYRB;
        private System.Windows.Forms.RadioButton RXRB;
        private System.Windows.Forms.RadioButton RORB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RFRB;
        private System.Windows.Forms.Button resetBTN;
    }
}