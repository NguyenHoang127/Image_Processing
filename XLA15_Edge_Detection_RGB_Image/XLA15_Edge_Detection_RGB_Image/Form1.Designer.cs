namespace XLA15_Edge_Detection_RGB_Image
{
    partial class XLA15
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
            this.label6 = new System.Windows.Forms.Label();
            this.value_threshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Edge = new System.Windows.Forms.Button();
            this.edge_box = new System.Windows.Forms.PictureBox();
            this.box_img = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edge_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(307, -101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // value_threshold
            // 
            this.value_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_threshold.Location = new System.Drawing.Point(226, 142);
            this.value_threshold.Name = "value_threshold";
            this.value_threshold.Size = new System.Drawing.Size(93, 30);
            this.value_threshold.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(85, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Threshold: ";
            // 
            // Edge
            // 
            this.Edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Edge.Location = new System.Drawing.Point(356, 116);
            this.Edge.Name = "Edge";
            this.Edge.Size = new System.Drawing.Size(158, 83);
            this.Edge.TabIndex = 29;
            this.Edge.Text = "Edge Detection";
            this.Edge.UseVisualStyleBackColor = true;
            this.Edge.Click += new System.EventHandler(this.Edge_Click);
            // 
            // edge_box
            // 
            this.edge_box.Location = new System.Drawing.Point(762, 298);
            this.edge_box.Name = "edge_box";
            this.edge_box.Size = new System.Drawing.Size(512, 512);
            this.edge_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edge_box.TabIndex = 28;
            this.edge_box.TabStop = false;
            // 
            // box_img
            // 
            this.box_img.Location = new System.Drawing.Point(52, 298);
            this.box_img.Name = "box_img";
            this.box_img.Size = new System.Drawing.Size(512, 512);
            this.box_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_img.TabIndex = 27;
            this.box_img.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(844, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Edge Detection Sobel RGB Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(189, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Original Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(457, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // XLA15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 838);
            this.Controls.Add(this.value_threshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edge);
            this.Controls.Add(this.edge_box);
            this.Controls.Add(this.box_img);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "XLA15";
            this.Text = "Nhận dạng đường biên dùng phương pháp Sobel với ảnh màu RGB";
            this.Load += new System.EventHandler(this.XLA15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edge_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox value_threshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Edge;
        private System.Windows.Forms.PictureBox edge_box;
        private System.Windows.Forms.PictureBox box_img;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

