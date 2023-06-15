using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA09_XYZ
{
    public partial class Form1 : Form
    {
        List<Bitmap> XYZ;
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA09_XYZ\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            img_orig.Image = hinhmau;

            //Sử dụng hàm chuyển đổi
            XYZ = ChuyenDoiRGBSangXYZ(hinhmau);
        }

        public List<Bitmap> ChuyenDoiRGBSangXYZ(Bitmap hinhmau)
        {
            //Tạo 1 list để chứa 4 kênh X-Y-Z-XYZ
            List<Bitmap> XYZ = new List<Bitmap>();

            //Mỗi kênh màu được hiển thị bởi 1 hình bitmap
            Bitmap X_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap Y_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap Z_img = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Đây là hình XYZ kết hợp cả ba kênh
            Bitmap XYZ_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            for (int x = 0; x < hinhmau.Width; x++)
                for (int y = 0; y < hinhmau.Height; y++)
                {
                    Color pixel = hinhmau.GetPixel(x, y);

                    //Khai báo kiểu double cho R-G_B vì tính toán các giá trị HSV đều trả
                    // về kiểu double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Tính X
                    double X = 0.4124564 * R + 0.3575761 * G + 0.1804375 * B;

                    //Tinh Y
                    double Y = 0.2126729 * R + 0.7151522 * G + 0.0721750 * B;

                    //Tinh Z
                    double Z = 0.0193339 * R + 0.1191920 * G + 0.9503041 * B;


                    X_img.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    Y_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Z_img.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    XYZ_img.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));
                }

            XYZ.Add(X_img);
            XYZ.Add(Y_img);
            XYZ.Add(Z_img);
            XYZ.Add(XYZ_img);

            return XYZ;

        }

        private void run_Click(object sender, EventArgs e)
        {
            //Hiển thị kết quả
            img_X.Image = XYZ[0];
            img_Y.Image = XYZ[1];
            img_Z.Image = XYZ[2];
            img_XYZ.Image = XYZ[3];
        }
    }
}
