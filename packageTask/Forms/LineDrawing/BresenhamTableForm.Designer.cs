namespace packageTask.Forms.LineDrawing
{
    partial class BresenhamTableForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K,
            this.pk,
            this.XY});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(630, 450);
            this.DGV.TabIndex = 1;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // K
            // 
            this.K.HeaderText = "K";
            this.K.MinimumWidth = 6;
            this.K.Name = "K";
            this.K.ReadOnly = true;
            this.K.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.K.Width = 125;
            // 
            // pk
            // 
            this.pk.HeaderText = "pk";
            this.pk.MinimumWidth = 6;
            this.pk.Name = "pk";
            this.pk.Width = 125;
            // 
            // XY
            // 
            this.XY.HeaderText = "(X K+1 , Y K+1)";
            this.XY.MinimumWidth = 6;
            this.XY.Name = "XY";
            this.XY.Width = 125;
            // 
            // BresenhamTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.DGV);
            this.Name = "BresenhamTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bresenham";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn XY;
    }
}