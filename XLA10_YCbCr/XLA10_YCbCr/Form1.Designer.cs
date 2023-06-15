namespace XLA10_YCbCr
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
            this.img_YCbCr = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.img_Cr = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img_Cb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img_Y = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.img_orig = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_YCbCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).BeginInit();
            this.SuspendLayout();
            // 
            // img_YCbCr
            // 
            this.img_YCbCr.Location = new System.Drawing.Point(1436, 573);
            this.img_YCbCr.Name = "img_YCbCr";
            this.img_YCbCr.Size = new System.Drawing.Size(370, 370);
            this.img_YCbCr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_YCbCr.TabIndex = 47;
            this.img_YCbCr.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(1567, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Hình YCbCr";
            // 
            // img_Cr
            // 
            this.img_Cr.Location = new System.Drawing.Point(1002, 573);
            this.img_Cr.Name = "img_Cr";
            this.img_Cr.Size = new System.Drawing.Size(370, 370);
            this.img_Cr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Cr.TabIndex = 45;
            this.img_Cr.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1135, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Kênh Cr";
            // 
            // img_Cb
            // 
            this.img_Cb.Location = new System.Drawing.Point(566, 573);
            this.img_Cb.Name = "img_Cb";
            this.img_Cb.Size = new System.Drawing.Size(370, 370);
            this.img_Cb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Cb.TabIndex = 43;
            this.img_Cb.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(708, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Kênh Cb";
            // 
            // img_Y
            // 
            this.img_Y.Location = new System.Drawing.Point(123, 573);
            this.img_Y.Name = "img_Y";
            this.img_Y.Size = new System.Drawing.Size(370, 370);
            this.img_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Y.TabIndex = 41;
            this.img_Y.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(242, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kênh Y";
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(803, 272);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(164, 97);
            this.run.TabIndex = 39;
            this.run.Text = "RGB to YCbCr";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // img_orig
            // 
            this.img_orig.Location = new System.Drawing.Point(118, 135);
            this.img_orig.Name = "img_orig";
            this.img_orig.Size = new System.Drawing.Size(370, 370);
            this.img_orig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_orig.TabIndex = 38;
            this.img_orig.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(203, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Hình Gốc: RGB gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(740, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 2016195";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.img_YCbCr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.img_Cr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_Cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img_Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.img_orig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuyển Đổi Ảnh Màu RGB sang YCbCr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.img_YCbCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_YCbCr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox img_Cr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_Cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.PictureBox img_orig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

