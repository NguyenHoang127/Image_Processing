using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA12_Sharpening_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tạo 1 đường dẫn đến nơi chứa ảnh mẫu
            //Lưu ý: Cần phải có ký tự @ để C# biết là chuỗi Unicode để không bị báo lỗi
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA11_LamMuotAnh\Lenna.jpg";

            // Tạo 1 biến chứa hình bitmap được load từ file hình
            
            Bitmap hinhmau = new Bitmap(Address_Pic);

            //Hiển thị hình gốc vào imgBox_Goc đã tạo
            box_img.Image = hinhmau;

            Bitmap Image_Sh = Image_Sharpening(hinhmau);
            box_sharpening.Image = Image_Sh;
        }

        public Bitmap Image_Sharpening(Bitmap hinhmau)
        {
            //Tạo 1 biến đã chứa ảnh sau khi làm sắc nét
            Bitmap Image_Sharpening = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 1 đến x = width -1 và tương tự với y
            for (int x = 1; x < hinhmau.Width - 1; x++)
                for (int y = 1; y < hinhmau.Height - 1; y++)

                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    int[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Tinh Laplacian

                            Rs += R * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gs += G * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Bs += B * matrix[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];

                        }

                    Color center = hinhmau.GetPixel(x, y);
                    byte R_C = center.R;
                    byte G_C = center.G;
                    byte B_C = center.B;

                    //Tính điểm ảnh sau khi làm nét
                    int R_SP = R_C + 1 * Rs;
                    int G_SP = G_C + 1 * Gs;
                    int B_SP = B_C + 1 * Bs;

                    //So sánh điều kiện để tránh vượt quá giá trị của 1 byte
                    if (R_SP > 255) { R_SP = 255; }
                    if (G_SP > 255) { G_SP = 255; }
                    if (B_SP > 255) { B_SP = 255; } 

                    if (R_SP < 0) { R_SP = 0; }
                    if (G_SP < 0) { G_SP = 0; }
                    if (B_SP < 0) { B_SP = 0; }

                    //SetPixel ảnh đã làm mượt vào bitmap
                    Image_Sharpening.SetPixel(x, y, Color.FromArgb((byte)R_SP,(byte) G_SP,(byte) B_SP));
                }
            return Image_Sharpening;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
