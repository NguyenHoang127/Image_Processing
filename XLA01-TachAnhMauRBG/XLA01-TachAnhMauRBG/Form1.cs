using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA01_TachAnhMauRBG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA01-TachAnhMauRBG\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            
            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            imgBox_Goc.Image = hinhmau;

            // Khai báo 3 hình bitmap để chứa 3 hình kênh R,G,B

            Bitmap red_img   = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap green_img = new Bitmap(hinhmau.Width, hinhmau.Height);
            Bitmap blue_img  = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Mỗi hình là 1 ma trận 2 chiều nên sẽ dùng 2 vòng for để quét tất cả điểm ảnh(pixel) có trong hình
            for (int x = 0; x<hinhmau.Width; x++)
                for(int y = 0; y<hinhmau.Height; y++)
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

                    red_img.SetPixel(x, y, Color.FromArgb(A, R,0,0));
                    green_img.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue_img.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));    

                }
            //Hiển thị lên 3 hình kênh màu R,G,B tại các pixBox đã tạo
            imgBox_Red.Image = red_img;
            imgBox_Green.Image = green_img;
            imgBox_Blue.Image = blue_img;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void imgBox_Goc_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void imgBox_Goc_Click_1(object sender, EventArgs e)
        {

        }
    }
}
