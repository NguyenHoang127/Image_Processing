namespace XLA12_Sharpening_Image
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
            this.box_img = new System.Windows.Forms.PictureBox();
            this.box_sharpening = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_sharpening)).BeginInit();
            this.SuspendLayout();
            // 
            // box_img
            // 
            this.box_img.Location = new System.Drawing.Point(65, 87);
            this.box_img.Name = "box_img";
            this.box_img.Size = new System.Drawing.Size(512, 512);
            this.box_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_img.TabIndex = 0;
            this.box_img.TabStop = false;
            // 
            // box_sharpening
            // 
            this.box_sharpening.Location = new System.Drawing.Point(739, 87);
            this.box_sharpening.Name = "box_sharpening";
            this.box_sharpening.Size = new System.Drawing.Size(512, 512);
            this.box_sharpening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_sharpening.TabIndex = 1;
            this.box_sharpening.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(475, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 20146195";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(206, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hình Gốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(920, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hình sau khi làm sắc nét";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_sharpening);
            this.Controls.Add(this.box_img);
            this.Name = "Form1";
            this.Text = "Color Image Sharpening";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_sharpening)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_img;
        private System.Windows.Forms.PictureBox box_sharpening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

