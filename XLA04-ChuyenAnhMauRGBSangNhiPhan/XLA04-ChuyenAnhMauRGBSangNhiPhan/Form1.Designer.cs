namespace XLA04_ChuyenAnhMauRGBSangNhiPhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img_Luminance_Box = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgBox_Nhiphan = new System.Windows.Forms.PictureBox();
            this.vScrollBarHinhNhiPhan = new System.Windows.Forms.VScrollBar();
            this.lblNguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Nhiphan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(167, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình Mức Xám Luminance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(462, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // img_Luminance_Box
            // 
            this.img_Luminance_Box.Location = new System.Drawing.Point(52, 168);
            this.img_Luminance_Box.Name = "img_Luminance_Box";
            this.img_Luminance_Box.Size = new System.Drawing.Size(512, 512);
            this.img_Luminance_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Luminance_Box.TabIndex = 2;
            this.img_Luminance_Box.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(929, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hình Nhị Phân";
            // 
            // imgBox_Nhiphan
            // 
            this.imgBox_Nhiphan.Location = new System.Drawing.Point(715, 168);
            this.imgBox_Nhiphan.Name = "imgBox_Nhiphan";
            this.imgBox_Nhiphan.Size = new System.Drawing.Size(512, 512);
            this.imgBox_Nhiphan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_Nhiphan.TabIndex = 4;
            this.imgBox_Nhiphan.TabStop = false;
            // 
            // vScrollBarHinhNhiPhan
            // 
            this.vScrollBarHinhNhiPhan.Location = new System.Drawing.Point(1277, 168);
            this.vScrollBarHinhNhiPhan.Maximum = 255;
            this.vScrollBarHinhNhiPhan.Name = "vScrollBarHinhNhiPhan";
            this.vScrollBarHinhNhiPhan.Size = new System.Drawing.Size(21, 512);
            this.vScrollBarHinhNhiPhan.TabIndex = 5;
            this.vScrollBarHinhNhiPhan.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarHinhNhiPhan_Scroll);
            // 
            // lblNguong
            // 
            this.lblNguong.AutoSize = true;
            this.lblNguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNguong.Location = new System.Drawing.Point(1237, 133);
            this.lblNguong.Name = "lblNguong";
            this.lblNguong.Size = new System.Drawing.Size(92, 20);
            this.lblNguong.TabIndex = 6;
            this.lblNguong.Text = "Threshold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 787);
            this.Controls.Add(this.lblNguong);
            this.Controls.Add(this.vScrollBarHinhNhiPhan);
            this.Controls.Add(this.imgBox_Nhiphan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_Luminance_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuyển Ảnh Màu RGB Sang Nhị Phân";
            ((System.ComponentModel.ISupportInitialize)(this.img_Luminance_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Nhiphan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img_Luminance_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgBox_Nhiphan;
        private System.Windows.Forms.VScrollBar vScrollBarHinhNhiPhan;
        private System.Windows.Forms.Label lblNguong;
    }
}

