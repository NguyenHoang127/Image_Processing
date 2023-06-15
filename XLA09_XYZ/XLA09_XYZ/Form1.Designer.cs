namespace XLA09_XYZ
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
            this.img_XYZ = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.img_Z = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img_Y = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img_X = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.img_orig = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_XYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).BeginInit();
            this.SuspendLayout();
            // 
            // img_XYZ
            // 
            this.img_XYZ.Location = new System.Drawing.Point(1440, 541);
            this.img_XYZ.Name = "img_XYZ";
            this.img_XYZ.Size = new System.Drawing.Size(370, 370);
            this.img_XYZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_XYZ.TabIndex = 35;
            this.img_XYZ.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(1571, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hình XYZ";
            // 
            // img_Z
            // 
            this.img_Z.Location = new System.Drawing.Point(1006, 541);
            this.img_Z.Name = "img_Z";
            this.img_Z.Size = new System.Drawing.Size(370, 370);
            this.img_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Z.TabIndex = 33;
            this.img_Z.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1132, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kênh Z";
            // 
            // img_Y
            // 
            this.img_Y.Location = new System.Drawing.Point(570, 541);
            this.img_Y.Name = "img_Y";
            this.img_Y.Size = new System.Drawing.Size(370, 370);
            this.img_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Y.TabIndex = 31;
            this.img_Y.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(682, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kênh Y";
            // 
            // img_X
            // 
            this.img_X.Location = new System.Drawing.Point(127, 541);
            this.img_X.Name = "img_X";
            this.img_X.Size = new System.Drawing.Size(370, 370);
            this.img_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_X.TabIndex = 29;
            this.img_X.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(246, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kênh X";
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(834, 242);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(125, 97);
            this.run.TabIndex = 27;
            this.run.Text = "RGB to XYZ";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // img_orig
            // 
            this.img_orig.Location = new System.Drawing.Point(122, 103);
            this.img_orig.Name = "img_orig";
            this.img_orig.Size = new System.Drawing.Size(370, 370);
            this.img_orig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_orig.TabIndex = 26;
            this.img_orig.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(207, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hình Gốc: RGB gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(744, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 2016195";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.img_XYZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.img_Z);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_Y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.img_orig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuyển Đổi Ảnh RGB Sang XYZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.img_XYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_XYZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox img_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.PictureBox img_orig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

