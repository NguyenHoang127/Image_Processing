namespace XLA08_HSV
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
            this.run = new System.Windows.Forms.Button();
            this.img_orig = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_HSI = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.img_Iten = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img_Satur = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img_Hue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Iten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Satur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hue)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(781, 201);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(125, 97);
            this.run.TabIndex = 15;
            this.run.Text = "RGB to HSV";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // img_orig
            // 
            this.img_orig.Location = new System.Drawing.Point(69, 62);
            this.img_orig.Name = "img_orig";
            this.img_orig.Size = new System.Drawing.Size(370, 370);
            this.img_orig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_orig.TabIndex = 14;
            this.img_orig.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(154, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hình Gốc: RGB gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(691, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 2016195";
            // 
            // img_HSI
            // 
            this.img_HSI.Location = new System.Drawing.Point(1387, 500);
            this.img_HSI.Name = "img_HSI";
            this.img_HSI.Size = new System.Drawing.Size(370, 370);
            this.img_HSI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_HSI.TabIndex = 23;
            this.img_HSI.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(1472, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hình HSV";
            // 
            // img_Iten
            // 
            this.img_Iten.Location = new System.Drawing.Point(953, 500);
            this.img_Iten.Name = "img_Iten";
            this.img_Iten.Size = new System.Drawing.Size(370, 370);
            this.img_Iten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Iten.TabIndex = 21;
            this.img_Iten.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1079, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kênh Value";
            // 
            // img_Satur
            // 
            this.img_Satur.Location = new System.Drawing.Point(517, 500);
            this.img_Satur.Name = "img_Satur";
            this.img_Satur.Size = new System.Drawing.Size(370, 370);
            this.img_Satur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Satur.TabIndex = 19;
            this.img_Satur.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(629, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kênh Saturation";
            // 
            // img_Hue
            // 
            this.img_Hue.Location = new System.Drawing.Point(74, 500);
            this.img_Hue.Name = "img_Hue";
            this.img_Hue.Size = new System.Drawing.Size(370, 370);
            this.img_Hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Hue.TabIndex = 17;
            this.img_Hue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(193, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kênh Hue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 1055);
            this.Controls.Add(this.img_HSI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.img_Iten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_Satur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img_Hue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.img_orig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuyển Đổi Ảnh RGB Sang HSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_orig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Iten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Satur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Hue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.PictureBox img_orig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_HSI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox img_Iten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_Satur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img_Hue;
        private System.Windows.Forms.Label label3;
    }
}

