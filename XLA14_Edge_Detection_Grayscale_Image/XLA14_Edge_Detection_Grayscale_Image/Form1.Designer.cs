namespace XLA14_Edge_Detection_Grayscale_Image
{
    partial class XLA_14
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box_img = new System.Windows.Forms.PictureBox();
            this.edge_box = new System.Windows.Forms.PictureBox();
            this.Edge = new System.Windows.Forms.Button();
            this.value_threshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(445, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đoàn Nguyễn Hoàng - 20146195";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(177, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Original Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(861, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Edge Detection Sobel Image";
            // 
            // box_img
            // 
            this.box_img.Location = new System.Drawing.Point(40, 292);
            this.box_img.Name = "box_img";
            this.box_img.Size = new System.Drawing.Size(512, 512);
            this.box_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_img.TabIndex = 18;
            this.box_img.TabStop = false;
            // 
            // edge_box
            // 
            this.edge_box.Location = new System.Drawing.Point(750, 292);
            this.edge_box.Name = "edge_box";
            this.edge_box.Size = new System.Drawing.Size(512, 512);
            this.edge_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edge_box.TabIndex = 19;
            this.edge_box.TabStop = false;
            // 
            // Edge
            // 
            this.Edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Edge.Location = new System.Drawing.Point(344, 110);
            this.Edge.Name = "Edge";
            this.Edge.Size = new System.Drawing.Size(158, 83);
            this.Edge.TabIndex = 20;
            this.Edge.Text = "Edge Detection";
            this.Edge.UseVisualStyleBackColor = true;
            this.Edge.Click += new System.EventHandler(this.Edge_Click);
            // 
            // value_threshold
            // 
            this.value_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_threshold.Location = new System.Drawing.Point(214, 136);
            this.value_threshold.Name = "value_threshold";
            this.value_threshold.Size = new System.Drawing.Size(93, 30);
            this.value_threshold.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(73, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Threshold: ";
            // 
            // XLA_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 844);
            this.Controls.Add(this.value_threshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edge);
            this.Controls.Add(this.edge_box);
            this.Controls.Add(this.box_img);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "XLA_14";
            this.Text = "Nhận dạng đường biên dùng phương pháp Sobel với ảnh xám";
            this.Load += new System.EventHandler(this.XLA_14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox box_img;
        private System.Windows.Forms.PictureBox edge_box;
        private System.Windows.Forms.Button Edge;
        private System.Windows.Forms.TextBox value_threshold;
        private System.Windows.Forms.Label label5;
    }
}

