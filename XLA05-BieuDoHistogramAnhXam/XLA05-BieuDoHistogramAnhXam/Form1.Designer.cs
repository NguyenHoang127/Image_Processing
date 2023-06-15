namespace XLA05_BieuDoHistogramAnhXam
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
            this.img_Original = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.img_Luminance = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.img_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Original
            // 
            this.img_Original.Location = new System.Drawing.Point(41, 51);
            this.img_Original.Name = "img_Original";
            this.img_Original.Size = new System.Drawing.Size(500, 381);
            this.img_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Original.TabIndex = 0;
            this.img_Original.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // img_Luminance
            // 
            this.img_Luminance.Location = new System.Drawing.Point(41, 455);
            this.img_Luminance.Name = "img_Luminance";
            this.img_Luminance.Size = new System.Drawing.Size(500, 381);
            this.img_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Luminance.TabIndex = 2;
            this.img_Luminance.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh Gốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ảnh Xám";
            // 
            // zGHistogram
            // 
            this.zGHistogram.ForeColor = System.Drawing.Color.Black;
            this.zGHistogram.Location = new System.Drawing.Point(737, 71);
            this.zGHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(969, 682);
            this.zGHistogram.TabIndex = 5;
            this.zGHistogram.UseExtendedPrintDialog = true;
            this.zGHistogram.Load += new System.EventHandler(this.zGHistogram_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 924);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_Luminance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_Original);
            this.Name = "Form1";
            this.Text = "Biểu Đồ Histogram Ảnh Xám";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_Luminance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

