namespace XLA03_ChuyenAnhMauRGBSangAnhXam
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
            this.img_Goc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.img_Original = new System.Windows.Forms.PictureBox();
            this.img_Average = new System.Windows.Forms.PictureBox();
            this.img_Lightness = new System.Windows.Forms.PictureBox();
            this.img_Luminance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Goc
            // 
            this.img_Goc.AutoSize = true;
            this.img_Goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_Goc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.img_Goc.Location = new System.Drawing.Point(152, 65);
            this.img_Goc.Name = "img_Goc";
            this.img_Goc.Size = new System.Drawing.Size(153, 18);
            this.img_Goc.TabIndex = 0;
            this.img_Goc.Text = "Hình Ảnh RGB Gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(631, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình Ảnh Mức Xám Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(90, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình Ảnh Mức Xám Lightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(610, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hình Ảnh Mức Xám Luminance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(341, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // img_Original
            // 
            this.img_Original.Location = new System.Drawing.Point(31, 98);
            this.img_Original.Name = "img_Original";
            this.img_Original.Size = new System.Drawing.Size(390, 390);
            this.img_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Original.TabIndex = 5;
            this.img_Original.TabStop = false;
            this.img_Original.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // img_Average
            // 
            this.img_Average.Location = new System.Drawing.Point(522, 98);
            this.img_Average.Name = "img_Average";
            this.img_Average.Size = new System.Drawing.Size(390, 390);
            this.img_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Average.TabIndex = 6;
            this.img_Average.TabStop = false;
            // 
            // img_Lightness
            // 
            this.img_Lightness.Location = new System.Drawing.Point(31, 562);
            this.img_Lightness.Name = "img_Lightness";
            this.img_Lightness.Size = new System.Drawing.Size(390, 390);
            this.img_Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Lightness.TabIndex = 7;
            this.img_Lightness.TabStop = false;
            // 
            // img_Luminance
            // 
            this.img_Luminance.Location = new System.Drawing.Point(522, 562);
            this.img_Luminance.Name = "img_Luminance";
            this.img_Luminance.Size = new System.Drawing.Size(390, 390);
            this.img_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Luminance.TabIndex = 8;
            this.img_Luminance.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(977, 1055);
            this.Controls.Add(this.img_Luminance);
            this.Controls.Add(this.img_Lightness);
            this.Controls.Add(this.img_Average);
            this.Controls.Add(this.img_Original);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_Goc);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Chuyển Ảnh Màu RGB Sang Mức Xám (GrayScale)";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.img_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label img_Goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img_Original;
        private System.Windows.Forms.PictureBox img_Average;
        private System.Windows.Forms.PictureBox img_Lightness;
        private System.Windows.Forms.PictureBox img_Luminance;
    }
}

