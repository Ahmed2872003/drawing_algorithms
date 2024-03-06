namespace packageTask.Forms
{
    partial class MenuFrom
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
            this.lineBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(118, 137);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(151, 30);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.Text = "Line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(118, 173);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(151, 30);
            this.circleBtn.TabIndex = 1;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(118, 209);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(151, 30);
            this.ellipseBtn.TabIndex = 2;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            // 
            // MenuFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 399);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.lineBtn);
            this.Name = "MenuFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button ellipseBtn;
    }
}