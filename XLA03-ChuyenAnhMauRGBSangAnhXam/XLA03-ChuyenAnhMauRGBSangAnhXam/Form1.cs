using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA03_ChuyenAnhMauRGBSangAnhXam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tạo đường dẫn hình ảnh
            string linkanh = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA03-ChuyenAnhMauRGBSangAnhXam\lena.jpg";
            Bitmap Original_img = new Bitmap(linkanh);
            //Hiển thị hình RGB gốc
            img_Original.Image = Original_img;
            //Hiển thị hình mức xám theo phương pháp Average
            img_Average.Image = ChuyenhinhRGBSangHinhXamAverage(Original_img);
            //Hiển thị hình mức xám theo phương pháp Lightness
            img_Lightness.Image = ChuyenhinhRGBSangHinhXamLightness(Original_img);
            //Hiển thị hình mức xám theo phương pháp Luminance
            img_Luminance.Image = ChuyenhinhRGBSangHinhXamLuminance(Original_img);
        }

        public Bitmap ChuyenhinhRGBSangHinhXamLightness(Bitmap Original_img)
        {
            //Điểm tọa độ (0,0) của hình là điểm góc trái trên cùng của hình chiều x tính từ trái qua phải
            //Và chiều y tính từ trên xuống dưới
            Bitmap HinhMucXam = new Bitmap(Original_img.Width, Original_img.Height);

            for(int x = 0;x<Original_img.Width;x++)
                for(int y = 0;y<Original_img.Height;y++)
                {
                    //Lấy 3 màu RGB tại điểm ảnh
                    Color pixel = Original_img.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    //Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);

                    //Gán giá trị mức xám vừa tính vào hình mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(A,gray, gray, gray));
                 
                }
            return HinhMucXam;
        }

        public Bitmap ChuyenhinhRGBSangHinhXamAverage(Bitmap Original_img)
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
                    byte gray = (byte)((R + G + B) / 3);

                    //Gán giá trị mức xám vừa tính vào hình mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(A,gray, gray, gray));

                }
            return HinhMucXam;
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
                    byte gray = (byte)((0.2126*R + 0.7152*G + 0.0722*B));

                    //Gán giá trị mức xám vừa tính vào hình mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(A,gray, gray, gray));

                }
            return HinhMucXam;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
