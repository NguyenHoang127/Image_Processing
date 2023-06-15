using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA04_ChuyenAnhMauRGBSangNhiPhan
{
    public partial class Form1 : Form
    {
        Bitmap Original_img;
        public Form1()
        {
            InitializeComponent();
            // Tạo đường dẫn hình ảnh
            string linkanh = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA04-ChuyenAnhMauRGBSangNhiPhan\lena.jpg";
            Original_img = new Bitmap(linkanh);

            //Hiển thị hình mức xám theo phương pháp Luminance
            img_Luminance_Box.Image = ChuyenhinhRGBSangHinhXamLuminance(Original_img); 

        }

        public Bitmap ChuyenhinhRGBSangHinhXamLuminance(Bitmap Original_img)
        {
            //Điểm tọa độ (0,0) của hình là điểm góc trái trên cùng của hình chiều x tính từ trái qua phải
            //Và chiều y tính từ trên xuống dưới
            Bitmap HinhMucXam = new Bitmap(Original_img.Width, Original_img.Height);

            for (int x = 0; x < Original_img.Width; x++)
                for (int y = 0; y < Original_img.Height; y++)
                {
                    //Lấy 3 màu RGB tại điểm ảnh
                    Color pixel = Original_img.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    //Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte gray = (byte)((0.2126 * R + 0.7152 * G + 0.0722 * B));

                    //Gán giá trị mức xám vừa tính vào hình mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(A, gray, gray, gray));

                }
            return HinhMucXam;
        }

        public Bitmap ChuyenHinhRGBSangNhiPhan(Bitmap Original_img, byte threshold)
        {
            Bitmap HinhNhiPhan = new Bitmap(Original_img.Width, Original_img.Height);

            for (int x = 0; x < Original_img.Width; x++)
                for (int y = 0; y < Original_img.Height; y++)
                {
                    //Lấy 3 màu RGB tại điểm ảnh
                    Color pixel = Original_img.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    //Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte nhiphan = (byte)((0.2126 * R + 0.7152 * G + 0.0722 * B));

                    //Phân loại điểm ảnh nhị phân dựa vào giá trị ngưỡng 
                    if (nhiphan < threshold)
                        nhiphan = 0;
                    else
                        nhiphan = 255;

                    //Gán giá trị nhị phân vừa tính vào hình nhị phân
                    HinhNhiPhan.SetPixel(x, y, Color.FromArgb(A, nhiphan, nhiphan, nhiphan));

                }
            return HinhNhiPhan;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBarHinhNhiPhan_Scroll(object sender, ScrollEventArgs e)
        {
            //Lấy giá trị ngưỡng từ giá trị của thanh cuộn
            //Do value kiểu int nên cần ép kiểu về byte
            byte Threshold = (byte)vScrollBarHinhNhiPhan.Value;

            //Cho hiển thị giá trị ngưỡng
            lblNguong.Text = Threshold.ToString();

            //Gọi hàm tính ảnh nhị phân và cho hiển thị
            imgBox_Nhiphan.Image = ChuyenHinhRGBSangNhiPhan(Original_img, Threshold);

        }
    }
}
