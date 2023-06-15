using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA15_Edge_Detection_RGB_Image
{
    public partial class XLA15 : Form
    {
        Bitmap hinhmau;
        public XLA15()
        {
            InitializeComponent();
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA11_LamMuotAnh\Lenna.jpg";
            hinhmau = new Bitmap(Address_Pic);
            box_img.Image = hinhmau;
        }
        public Bitmap Image_RGB_Edge_Detection(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi nhận dạng đường biên
            Bitmap Image_Edge_Detection = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Lấy giá trị ngưỡng để so sánh
            double D_threshold = double.Parse(value_threshold.Text);

            int[,] Sobel_matrix_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] Sobel_matrix_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            for (int x = 1; x < hinhmau.Width - 1; x++)
                for (int y = 1; y < hinhmau.Height - 1; y++)
                {
                    double Gra_x_R = 0, Gra_x_G = 0, Gra_x_B = 0;
                    double Gra_y_R = 0, Gra_y_G = 0, Gra_y_B = 0;
                    double Gxx = 0, Gyy = 0, Gxy = 0;
                    double theta = 0,Ftheta = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Tính Gradien 3 kênh màu R_G_B theo phương x
                            Gra_x_R += R * Sobel_matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gra_x_G += G * Sobel_matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gra_x_B += B * Sobel_matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];

                            //Tính Gradien 3 kênh màu R_G_B theo phương y
                            Gra_y_R += R * Sobel_matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gra_y_G += G * Sobel_matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gra_y_B += B * Sobel_matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                        }

                    //Tính các giá trị gxx,gyy,gxy
                    Gxx = Math.Pow(Math.Abs(Gra_x_R), 2) + Math.Pow(Math.Abs(Gra_x_G), 2)  + Math.Pow(Math.Abs(Gra_x_B), 2);
                    Gyy = Math.Pow(Math.Abs(Gra_y_R), 2) + Math.Pow(Math.Abs(Gra_y_G), 2)  + Math.Pow(Math.Abs(Gra_y_B), 2);
                    Gxy = Gra_x_R * Gra_y_R + Gra_x_G * Gra_y_G + Gra_x_B * Gra_y_B;

                    //Tính góc theta
                    theta = Math.Atan2((2 * Gxy), (Gxx - Gyy)) / 2;

                    //Tính giá trị Ftheta
                    Ftheta = Math.Sqrt(((Gxx+Gyy)+((Gxx-Gyy)*Math.Cos(2*theta))+(2*Gxy*Math.Sin(2*theta)))*0.5);

                    //So sánh
                    if (Ftheta < D_threshold) //Thuộc background
                    {
                        Image_Edge_Detection.SetPixel(x, y, Color.FromArgb((byte)0, (byte)0, (byte)0));
                    }

                    else
                    {
                        Image_Edge_Detection.SetPixel(x, y, Color.FromArgb((byte)255, (byte)255, (byte)255));
                    }

                }
            return Image_Edge_Detection;
        }
        private void XLA15_Load(object sender, EventArgs e)
        {

        }

        private void Edge_Click(object sender, EventArgs e)
        {
            Bitmap Image_Edge = Image_RGB_Edge_Detection(hinhmau);
            edge_box.Image = Image_Edge;
        }
    }
}
