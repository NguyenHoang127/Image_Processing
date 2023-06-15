using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA13_Segmentation_RGB
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
            hinhmau = new Bitmap(Address_Pic);
            box_img.Image = hinhmau;
        }

        public Bitmap Segmentation_Image(Bitmap hinhmau)
        {
            //Tạo 1 biến để chứa ảnh sau khi xóa phông
            Bitmap Segmentation_Image = new Bitmap(hinhmau.Width, hinhmau.Height);

            //Lấy các tọa độ 2 điểm
            int x1 = int.Parse(x1_box.Text);
            int y1 = int.Parse(y1_box.Text);
            int x2 = int.Parse(x2_box.Text);
            int y2 = int.Parse(y2_box.Text);

            //Tinh vector TB màu
            double[] a_vetor = Vector_Average_Color(hinhmau, x1, y1, x2, y2);

            //Lấy giá trị ngưỡng
            double Do = double.Parse(value_threshold.Text);

            for (int x=0;x<hinhmau.Width;x++)
                for(int y=0;y<hinhmau.Height;y++)
                {
                    Color color = hinhmau.GetPixel(x, y);
                    double Z_R = color.R;
                    double Z_G = color.G;
                    double Z_B = color.B;

                    //Using Euclidean distance
                    double D = Math.Sqrt(Math.Pow((Z_R - a_vetor[0]), 2) + Math.Pow((Z_G - a_vetor[1]), 2) + Math.Pow((Z_B - a_vetor[2]), 2));

                    if(D<=Do) //Thuộc background
                    {
                        Z_R = Z_G = Z_B = 255;
                        Segmentation_Image.SetPixel(x, y, Color.FromArgb((byte)Z_R,(byte)Z_G,(byte)Z_B));
                    }

                    else
                    {
                        Segmentation_Image.SetPixel(x, y, Color.FromArgb((byte)Z_R, (byte)Z_G, (byte)Z_B));
                    }

                }
            return Segmentation_Image;

        }

        double [] Vector_Average_Color(Bitmap hinhmau,int x1,int y1,int x2,int y2)
        {
            double[] a = new double[3];
            a[0] = a[1] = a[2] = 0;

            //Quét diện tích 
            for(int x=x1;x<=x2;x++)
                for(int y=y1;y<=y2;y++)
                {
                    Color pixel = hinhmau.GetPixel(x, y);
                    a[0] += pixel.R;
                    a[1] += pixel.G;
                    a[2] += pixel.B;

                }
            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

            a[0] /= size;
            a[1] /= size;
            a[2] /= size;

            return a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Segmentation_Click(object sender, EventArgs e)
        {
            Bitmap Image_Segmetation = Segmentation_Image(hinhmau);
            segmentation_box.Image = Image_Segmetation;
        }
    }
}
