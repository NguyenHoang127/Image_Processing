using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA06_RGB_CMYK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA06_RGB-CMYK\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình

            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            imgBox_Goc.Image = hinhmau;

            //Chạy hàm chuyển đổi
            List <Bitmap> CMYK = ChuyenDoiRGBSangCMYK(hinhmau);
            imgBox_Cyan.Image    = CMYK[0];
            imgBox_Magenta.Image = CMYK[1];
            imgBox_Yellow.Image  = CMYK[2];
            imgBox_Black.Image   = CMYK[3];
        }

        public List<Bitmap> ChuyenDoiRGBSangCMYK(Bitmap hinhmau)
        {
            //Tạo 1 list để chứa 4 kênh màu C-M-Y-K
            List<Bitmap> CMYK = new List<Bitmap>();

            //Mỗi kênh màu được hiển thị bởi 1 hình bitmap
            Bitmap cyan_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap magenta_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap yellow_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap black_img = new Bitmap(hinhmau.Width, hinhmau.Height);

            for (int x = 0; x < hinhmau.Width; x++)
                for (int y = 0; y < hinhmau.Height; y++)
                {
                    //Đọc giá trị pixel tại điểm ảnh có vị trí(x,y) nằm trong kiểu dữ liệu color thì bao gồm R,G,B 
                    //Và độ trong suốt
                    Color pixel = hinhmau.GetPixel(x, y);

                    // Mỗi pixel chứa 4 thông số gồm giá trị màu R,G,B và độ trong suốt
                    // Mỗi giá trị kênh màu chiếm 1 byte từ 0 đến 255
                    byte R = pixel.R; //Giá trị kênh RED
                    byte G = pixel.G; //Giá trị kênh GREEN
                    byte B = pixel.B; //Giá trị kênh BLUE
                    byte A = pixel.A; //Giá trị độ trong suốt

                    //Set giá trị pixel đọc được cho các hình chứa
                    //Các kênh màu tương ứng R,G,B
                    //Màu cyan là trộn G-B
                    cyan_img.SetPixel(x, y, Color.FromArgb(A, 0, G, B));
                    //Màu magenta là trộn R-B
                    magenta_img.SetPixel(x, y, Color.FromArgb(A, R, 0, B));
                    //Màu Yellow là trộn R-G
                    yellow_img.SetPixel(x, y, Color.FromArgb(A, R, G, 0));
                    //Màu đen là lấy min(R,G,B)
                    byte K = Math.Min(R, Math.Min(G, B));
                    black_img.SetPixel(x, y, Color.FromArgb(A, K, K, K));
                }
            //Add các hình tương ứng vào các kênh màu C-M-Y-K tương ứng
            //Do list là kiểu dữ liệu là mảng không cần quan tâm có bị tràn kích thước hay không(khác so với C)
            CMYK.Add(cyan_img);
            CMYK.Add(magenta_img);
            CMYK.Add(yellow_img);
            CMYK.Add(black_img);

            return CMYK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
