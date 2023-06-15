using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA14_Edge_Detection_Grayscale_Image
{
    public partial class XLA_14 : Form
    {
        Bitmap hinhmau;
        Bitmap gray_image;
        public XLA_14()
        {
            InitializeComponent();
            string Address_Pic = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA11_LamMuotAnh\Lenna.jpg";
            hinhmau = new Bitmap(Address_Pic);
            box_img.Image = hinhmau;

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

        public Bitmap Image_Edge_Detection(Bitmap gray_image)
        {
            //Tạo 1 biến đã chứa ảnh sau khi nhận dạng đường biên
            Bitmap Image_Edge_Detection = new Bitmap(gray_image.Width, gray_image.Height);

            //Lấy giá trị ngưỡng
            double D_threshold = double.Parse(value_threshold.Text);

            int[,] Sobel_matrix_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] Sobel_matrix_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            //Tiến hành quét ảnh vì bỏ đường viền nên chỉ quét từ x = 1 đến x = width -1 và tương tự với y
            for (int x = 1; x < gray_image.Width - 1; x++)
                for (int y = 1; y < gray_image.Height - 1; y++)
                {
                    int Gradien_x = 0, Gradien_y = 0;
                    double Magnitude_V = 0;
                    
                    //Quét mặt nạ 3x3 từng điểm cần xét trong ảnh từ đường viền ngoài cùng
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = hinhmau.GetPixel(i, j);
                            //Lấy điểm màu ở vị trí xung quanh điểm cần lấy nằm trong khuôn mặt nạ 3x3
                            byte R = color.R;  //Vì ảnh đầu  vào là ảnh xám nên giá trị điểm ảnh trên 3 layout là như nhau 

                            //Tinh Gradien theo từng phương cụ thể là x và y
                            Gradien_x += R * Sobel_matrix_x[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                            Gradien_y += R * Sobel_matrix_y[Math.Abs(x - i - 1), Math.Abs(y - j - 1)];
                        }

                    //Tính biên độ của Vector
                    Magnitude_V = Math.Abs(Gradien_x) + Math.Abs(Gradien_y);

                    //So sánh với giá trị ngưỡng để xác định đường viền
                    if (Magnitude_V <= D_threshold) //Thuộc background
                    {
                        Image_Edge_Detection.SetPixel(x, y, Color.FromArgb((byte)0, (byte)0, (byte)0));
                    }

                    else
                    {
                        Image_Edge_Detection.SetPixel(x, y, Color.FromArgb((byte)255,(byte)255,(byte)255));
                    }

                }
            return Image_Edge_Detection;
        }

        private void XLA_14_Load(object sender, EventArgs e)
        {

        }

        private void Edge_Click(object sender, EventArgs e)
        {
            gray_image = ChuyenhinhRGBSangHinhXamLuminance(hinhmau);
            Bitmap Image_Edge = Image_Edge_Detection(gray_image);
            edge_box.Image = Image_Edge;
        }
    }
}
