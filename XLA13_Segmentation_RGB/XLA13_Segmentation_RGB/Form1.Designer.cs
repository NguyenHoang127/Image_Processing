namespace XLA13_Segmentation_RGB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1_box = new System.Windows.Forms.TextBox();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.y1_box = new System.Windows.Forms.TextBox();
            this.y2_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.value_threshold = new System.Windows.Forms.TextBox();
            this.Segmentation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box_img = new System.Windows.Forms.PictureBox();
            this.segmentation_box = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentation_box)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.y2_box);
            this.groupBox1.Controls.Add(this.y1_box);
            this.groupBox1.Controls.Add(this.x2_box);
            this.groupBox1.Controls.Add(this.x1_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(59, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area Average Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "y1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(201, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "y2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(200, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "x2: ";
            // 
            // x1_box
            // 
            this.x1_box.Location = new System.Drawing.Point(72, 48);
            this.x1_box.Name = "x1_box";
            this.x1_box.Size = new System.Drawing.Size(93, 34);
            this.x1_box.TabIndex = 1;
            // 
            // x2_box
            // 
            this.x2_box.Location = new System.Drawing.Point(236, 48);
            this.x2_box.Name = "x2_box";
            this.x2_box.Size = new System.Drawing.Size(93, 34);
            this.x2_box.TabIndex = 5;
            // 
            // y1_box
            // 
            this.y1_box.Location = new System.Drawing.Point(71, 102);
            this.y1_box.Name = "y1_box";
            this.y1_box.Size = new System.Drawing.Size(93, 34);
            this.y1_box.TabIndex = 6;
            // 
            // y2_box
            // 
            this.y2_box.Location = new System.Drawing.Point(236, 102);
            this.y2_box.Name = "y2_box";
            this.y2_box.Size = new System.Drawing.Size(93, 34);
            this.y2_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(443, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Threshold: ";
            // 
            // value_threshold
            // 
            this.value_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_threshold.Location = new System.Drawing.Point(584, 22);
            this.value_threshold.Name = "value_threshold";
            this.value_threshold.Size = new System.Drawing.Size(93, 30);
            this.value_threshold.TabIndex = 12;
            // 
            // Segmentation
            // 
            this.Segmentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Segmentation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Segmentation.Location = new System.Drawing.Point(475, 78);
            this.Segmentation.Name = "Segmentation";
            this.Segmentation.Size = new System.Drawing.Size(158, 83);
            this.Segmentation.TabIndex = 13;
            this.Segmentation.Text = "Segmentation";
            this.Segmentation.UseVisualStyleBackColor = true;
            this.Segmentation.Click += new System.EventHandler(this.Segmentation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(871, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Original Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(814, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Segmented Image";
            // 
            // box_img
            // 
            this.box_img.Location = new System.Drawing.Point(33, 302);
            this.box_img.Name = "box_img";
            this.box_img.Size = new System.Drawing.Size(512, 512);
            this.box_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_img.TabIndex = 17;
            this.box_img.TabStop = false;
            // 
            // segmentation_box
            // 
            this.segmentation_box.Location = new System.Drawing.Point(761, 302);
            this.segmentation_box.Name = "segmentation_box";
            this.segmentation_box.Size = new System.Drawing.Size(512, 512);
            this.segmentation_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.segmentation_box.TabIndex = 18;
            this.segmentation_box.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 896);
            this.Controls.Add(this.segmentation_box);
            this.Controls.Add(this.box_img);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Segmentation);
            this.Controls.Add(this.value_threshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Segmentation_RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentation_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1_box;
        private System.Windows.Forms.TextBox y2_box;
        private System.Windows.Forms.TextBox y1_box;
        private System.Windows.Forms.TextBox x2_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox value_threshold;
        private System.Windows.Forms.Button Segmentation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox box_img;
        private System.Windows.Forms.PictureBox segmentation_box;
    }
}

