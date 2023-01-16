
namespace gameoflife
{
    partial class gameoflifemain
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
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.numSSize = new System.Windows.Forms.NumericUpDown();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrid
            // 
            this.pbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGrid.Location = new System.Drawing.Point(21, 61);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(1097, 493);
            this.pbGrid.TabIndex = 0;
            this.pbGrid.TabStop = false;
            this.pbGrid.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numSSize
            // 
            this.numSSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSSize.Location = new System.Drawing.Point(135, 585);
            this.numSSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numSSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSSize.Name = "numSSize";
            this.numSSize.Size = new System.Drawing.Size(67, 26);
            this.numSSize.TabIndex = 1;
            this.numSSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRest.Location = new System.Drawing.Point(228, 577);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(97, 41);
            this.btnRest.TabIndex = 3;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdvance.Location = new System.Drawing.Point(818, 578);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(98, 41);
            this.btnAdvance.TabIndex = 4;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGo.Location = new System.Drawing.Point(941, 578);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 41);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "cell size";
            // 
            // gameoflifemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 636);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSSize);
            this.Controls.Add(this.pbGrid);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "gameoflifemain";
            this.Text = "game of life";
            this.Load += new System.EventHandler(this.gameoflifemain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.NumericUpDown numSSize;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
    }
}

