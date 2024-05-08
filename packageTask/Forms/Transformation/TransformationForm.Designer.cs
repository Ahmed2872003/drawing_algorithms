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
            ((System.ComponentModel.ISupportInitialize)(this.TTBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTBY)).BeginInit();
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
            // TransformationForm
            // 
            this.ClientSize = new System.Drawing.Size(1403, 657);
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
    }
}