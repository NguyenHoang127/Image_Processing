using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA08_HSV
{
    public partial class Form1 : Form
    {
        List<Bitmap> HSV;
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA08_HSV\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            img_orig.Image = hinhmau;

            //Sử dụng hàm chuyển đổi
            HSV = ChuyenDoiRGBSangHSV(hinhmau);

        }

        public List<Bitmap> ChuyenDoiRGBSangHSV(Bitmap hinhmau)
        {
            //Tạo 1 list để chứa 4 kênh HUE - SATURATION - VALUE
            List<Bitmap> HSV = new List<Bitmap>();

            //Mỗi kênh màu được hiển thị bởi 1 hình bitmap
            Bitmap hue_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap saturation_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap itensity_img = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Đây là hình HSV kết hợp cả ba kênh
            Bitmap hsi_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            for (int x = 0; x < hinhmau.Width; x++)
                for (int y = 0; y < hinhmau.Height; y++)
                {
                    Color pixel = hinhmau.GetPixel(x, y);

                    //Khai báo kiểu double cho R-G_B vì tính toán các giá trị HSV đều trả
                    // về kiểu double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Tính H
                    // t1 là phần tử của cthuc
                    double t1 = ((R - G) + (R - B)) / 2;
                    // t2 là phần mẫu của cthuc
                    double t2 = Math.Sqrt(Math.Pow((R - G), 2) + (R - B) * (G - B));
                    //Tinh goc theta
                    double theta = Math.Acos(t1 / t2);

                    //Công thức tính giá trị Hue
                    double H = 0;
                    if (B <= G)
                        H = theta;
                    else
                        H = 2 * Math.PI - theta;

                    H = H * 180 / Math.PI;

                    //Tinh S
                    //Do giá tri S nằm trong khoảng [0,1]
                    //Để bitmap có thể hiển thị phải chuyển S trong khoảng [0,255]
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);

                    //Công thức tính intensity
                    double V = Math.Max(R, Math.Max(B, G));


                    hue_img.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    saturation_img.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (byte)(S * 255)));
                    itensity_img.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));
                    hsi_img.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S * 255), (byte)V));
                }

            HSV.Add(hue_img);
            HSV.Add(saturation_img);
            HSV.Add(itensity_img);
            HSV.Add(hsi_img);

            return HSV;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void run_Click(object sender, EventArgs e)
        {
            //Hiển thị kết quả
            img_Hue.Image = HSV[0];
            img_Satur.Image = HSV[1];
            img_Iten.Image = HSV[2];
            img_HSI.Image = HSV[3];
        }
    }
}
