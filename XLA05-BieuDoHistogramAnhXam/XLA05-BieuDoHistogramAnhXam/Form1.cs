using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace XLA05_BieuDoHistogramAnhXam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tạo đường dẫn hình ảnh
            string linkanh = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA05-BieuDoHistogramAnhXam\bird_small.jpg";
            Bitmap Original_img = new Bitmap(linkanh);
            //Hiển thị hình RGB gốc
            img_Original.Image = Original_img;
            //Hiển thị hình mức xám theo phương pháp Luminance
            Bitmap HinhMucXam = ChuyenhinhRGBSangHinhXamLuminance(Original_img);
            img_Luminance.Image = HinhMucXam;

            //Bây giờ gọi các hàm đã viết để vẽ biểu đồ histogram
            //Tính histogram
            double[] histogram = TinhHistogram(HinhMucXam);

            //Chuyển đổi kiểu dữ liệu
            PointPairList points = ChuyenDoiHistogram(histogram);

            // Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();


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

        //Tính Histogram của ảnh xám
        public double[] TinhHistogram(Bitmap HinhMucXam)
        {
            //Mỗi pixel mức xám có giá trị từ 0-256 do đó ta khai báo một mảng có 256 phần tử
            //dùng kiểu double vì tính toán tổng số đếm có dữ liệu lớn
            double[] histogram = new double[256];

            for (int x = 0; x<HinhMucXam.Width;x++)
                for(int y = 0;y<HinhMucXam.Height;y++)
                {
                    Color color = HinhMucXam.GetPixel(x, y);
                    byte gray = color.R;//Trong hình mức xám thì giá trị R=G=B

                    //Giá trị gray tính ra cũng chính là phần tử thứ gray trong mảng histogram
                    histogram[gray]++;
                }
            return histogram;
        }

        PointPairList ChuyenDoiHistogram(double[] histogram)
        {
            //pointpairlist là kiểu dữ liệu của ZedGraph để vẽ biểu đồ
            //Gồm 1 cặp dữ liệu (i-->x,histogram[i] -->y)
            PointPairList points = new PointPairList();

            for(int i = 0;i<histogram.Length;i++)
            {
                //i tương ứng trục ngang từ 0-255,histogram[i] là số lượng pixel màu i tương ứng trục đứng, là số pixel cùng mức xám
                points.Add(i, histogram[i]);
            }
            return points;
        }

        //Thiết lập 1 biểu đồ trong ZedGraph
        public GraphPane BieuDoHistogram(PointPairList histogram)
        {
            //GraphPane là đối tượng biểu đồ trong ZedGraph
            GraphPane gp = new GraphPane();
            gp.Title.Text = @"Biểu đồ Histogram"; //Tên của biểu đồ
            gp.Rect = new Rectangle(0, 0, 700, 500); //Khung chứa biểu đồ 

            //Thiết lập trục ngang
            gp.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5; //Mõi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1; //Mỗi bước trong một bước chính là 1

            //Thiết lập trục đứng
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng mức xám";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000; //SỐ này phải lớn hơn kích thước ảnh (w x h)
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            //Dùng biểu đồ dạng bar để biểu diễn 
            gp.AddBar("Histogram", histogram,Color.BlueViolet);
            return gp;

        }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zGHistogram_Load(object sender, EventArgs e)
        {

        }
    }
}
