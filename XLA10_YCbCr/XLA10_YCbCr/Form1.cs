using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA10_YCbCr
{
    public partial class Form1 : Form
    {
        List<Bitmap> YCbCr;
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA10_YCbCr\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            img_orig.Image = hinhmau;

            //Sử dụng hàm chuyển đổi
            YCbCr = ChuyenDoiRGBSangYCbCr(hinhmau);
        }

        public List<Bitmap> ChuyenDoiRGBSangYCbCr(Bitmap hinhmau)
        {
            //Tạo 1 list để chứa 4 kênh YCbCr
            List<Bitmap> YCbCr = new List<Bitmap>();

            //Mỗi kênh màu được hiển thị bởi 1 hình bitmap
            Bitmap Y_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap Cb_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap Cr_img = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Đây là hình YCbCr kết hợp cả ba kênh
            Bitmap YCbCr_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            for (int x = 0; x < hinhmau.Width; x++)
                for (int y = 0; y < hinhmau.Height; y++)
                {
                    Color pixel = hinhmau.GetPixel(x, y);

                    //Khai báo kiểu double cho R-G_B vì tính toán các giá trị YCbCr đều trả
                    // về kiểu double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Tinh Y
                    double Y = 16 + (65.738 * R / 256) + (129.057 * G / 256) + (25.064 * B / 256);

                    //Tinh Cb
                    double Cb = 128 - (37.945 * R / 256) - (74.494 * G / 256) + (112.439 * B / 256);

                    //Tinh Cr
                    double Cr = 128 + (112.439 * R / 256) - (94.154 * G / 256) - (18.285 * B / 256);


                    Y_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Cb_img.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));
                    Cr_img.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    YCbCr_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cb, (byte)Cr));
                }

            YCbCr.Add(Y_img);
            YCbCr.Add(Cb_img);
            YCbCr.Add(Cr_img);
            YCbCr.Add(YCbCr_img);

            return YCbCr;

        }
        private void run_Click(object sender, EventArgs e)
        {
            //Hiển thị kết quả
            img_Y.Image = YCbCr[0];
            img_Cb.Image = YCbCr[1];
            img_Cr.Image = YCbCr[2];
            img_YCbCr.Image = YCbCr[3];
        }
    }
}
