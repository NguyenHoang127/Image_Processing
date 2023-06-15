using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA11_LamMuotAnh
{
    public partial class Form1 : Form
    {
        Bitmap hinhmau;        
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA11_LamMuotAnh\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            box_img.Image = hinhmau;

        }

        public Bitmap ColorImageSmoothing3x3(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi làm mượt
            Bitmap SmoothedImage_3x3 = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 1 đến x = width -1 và tương tự với y
            for(int x = 1;x<hinhmau.Width - 1; x++)
                for(int y = 1;y<hinhmau.Height - 1; y++)

                {
                    //Biến để khai báo giá trị cộng dồn của các điểm ảnh trong mặt nạ nên phải khai báo kiểu int
                    //Để chứa các giá trị cộng dồn của pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    for(int i = x - 1; i <= x+1; i++)
                        for(int j = y - 1; j <= y+1 ; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cộng dồn tất cả điểm ảnh trên từng layout
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    //Tính theo công thức 6.6.1 trong sách
                    byte K = 3*3;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //SetPixel ảnh đã làm mượt vào bitmap
                    SmoothedImage_3x3.SetPixel(x, y, Color.FromArgb(Rs,Gs,Bs));
                }
            return SmoothedImage_3x3;
        }

        public Bitmap ColorImageSmoothing5x5(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi làm mượt
            Bitmap SmoothedImage_5x5 = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 2 đến x = width -2 và tương tự với y
            for (int x = 2; x < hinhmau.Width - 2; x++)
                for (int y = 2; y < hinhmau.Height - 2; y++)

                {
                    //Biến để khai báo giá trị cộng dồn của các điểm ảnh trong mặt nạ nên phải khai báo kiểu int
                    //Để chứa các giá trị cộng dồn của pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cộng dồn tất cả điểm ảnh trên từng layout
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    //Tính theo công thức 6.6.1 trong sách
                    byte K = 5 * 5;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //SetPixel ảnh đã làm mượt vào bitmap
                    SmoothedImage_5x5.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage_5x5;
        }

        public Bitmap ColorImageSmoothing7x7(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi làm mượt
            Bitmap SmoothedImage_7x7 = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 1 đến x = width -1 và tương tự với y
            for (int x = 3; x < hinhmau.Width - 3; x++)
                for (int y = 3; y < hinhmau.Height - 3; y++)

                {
                    //Biến để khai báo giá trị cộng dồn của các điểm ảnh trong mặt nạ nên phải khai báo kiểu int
                    //Để chứa các giá trị cộng dồn của pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cộng dồn tất cả điểm ảnh trên từng layout
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    //Tính theo công thức 6.6.1 trong sách
                    byte K = 7 * 7;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //SetPixel ảnh đã làm mượt vào bitmap
                    SmoothedImage_7x7.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage_7x7;
        }

        public Bitmap ColorImageSmoothing9x9(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi làm mượt
            Bitmap SmoothedImage_9x9 = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 4 đến x = width -4 và tương tự với y
            for (int x = 4; x < hinhmau.Width - 4; x++)
                for (int y = 4; y < hinhmau.Height - 4; y++)

                {
                    //Biến để khai báo giá trị cộng dồn của các điểm ảnh trong mặt nạ nên phải khai báo kiểu int
                    //Để chứa các giá trị cộng dồn của pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cộng dồn tất cả điểm ảnh trên từng layout
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    //Tính theo công thức 6.6.1 trong sách
                    byte K = 9 * 9;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //SetPixel ảnh đã làm mượt vào bitmap
                    SmoothedImage_9x9.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage_9x9;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_3x3_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage_3x3 = ColorImageSmoothing3x3(hinhmau);
            box_3x3.Image = SmoothedImage_3x3;
        }
            
        private void BT_5x5_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage_5x5 = ColorImageSmoothing5x5(hinhmau);
            box_5x5.Image = SmoothedImage_5x5;
        }

        private void BT_7x7_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage_7x7 = ColorImageSmoothing7x7(hinhmau);
            box_7x7.Image = SmoothedImage_7x7;
        }

        private void BT_9x9_Click(object sender, EventArgs e)
        {
            Bitmap SmoothedImage_9x9 = ColorImageSmoothing9x9(hinhmau);
            box_9x9.Image = SmoothedImage_9x9;
        }
    }
}
