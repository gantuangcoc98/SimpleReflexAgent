namespace Simple_Reflex_Agent
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.quadrant3 = new System.Windows.Forms.Label();
            this.quadrant4 = new System.Windows.Forms.Label();
            this.quadrant1 = new System.Windows.Forms.Label();
            this.quadrant2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 585);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // quadrant3
            // 
            this.quadrant3.AutoSize = true;
            this.quadrant3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quadrant3.Location = new System.Drawing.Point(160, 360);
            this.quadrant3.Name = "quadrant3";
            this.quadrant3.Size = new System.Drawing.Size(50, 13);
            this.quadrant3.TabIndex = 1;
            this.quadrant3.Text = "SAMPLE";
            // 
            // quadrant4
            // 
            this.quadrant4.AutoSize = true;
            this.quadrant4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quadrant4.Location = new System.Drawing.Point(537, 360);
            this.quadrant4.Name = "quadrant4";
            this.quadrant4.Size = new System.Drawing.Size(50, 13);
            this.quadrant4.TabIndex = 2;
            this.quadrant4.Text = "SAMPLE";
            // 
            // quadrant1
            // 
            this.quadrant1.AutoSize = true;
            this.quadrant1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quadrant1.Location = new System.Drawing.Point(537, 90);
            this.quadrant1.Name = "quadrant1";
            this.quadrant1.Size = new System.Drawing.Size(50, 13);
            this.quadrant1.TabIndex = 3;
            this.quadrant1.Text = "SAMPLE";
            // 
            // quadrant2
            // 
            this.quadrant2.AutoSize = true;
            this.quadrant2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quadrant2.Location = new System.Drawing.Point(160, 90);
            this.quadrant2.Name = "quadrant2";
            this.quadrant2.Size = new System.Drawing.Size(50, 13);
            this.quadrant2.TabIndex = 4;
            this.quadrant2.Text = "SAMPLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(893, 585);
            this.Controls.Add(this.quadrant2);
            this.Controls.Add(this.quadrant1);
            this.Controls.Add(this.quadrant4);
            this.Controls.Add(this.quadrant3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Vacuum Cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label quadrant3;
        private System.Windows.Forms.Label quadrant4;
        private System.Windows.Forms.Label quadrant1;
        private System.Windows.Forms.Label quadrant2;
    }
}

