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

namespace XLA05_BieuDoHistogramAnhMauRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tạo đường dẫn hình ảnh
            string linkanh = @"C:\Users\HOANG DOAN\Xu_Li_Anh\XLA05-BieuDoHistogramAnhMauRGB\bird_small.jpg";
            Bitmap Original_img = new Bitmap(linkanh);
            //Hiển thị hình RGB gốc
            img_Original.Image = Original_img;


            //Bây giờ gọi các hàm đã viết để vẽ biểu đồ histogram
            //Tính histogram
            double[,] histogram = TinhHistogram(Original_img);

            //Chuyển đổi kiểu dữ liệu
            List<PointPairList> points = ChuyenDoiHistogram(histogram);

            // Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();
        }

        //Tính Histogram của ảnh màu RGB
        public double[,] TinhHistogram(Bitmap Original_img)
        {
            //Mỗi pixel mức xám có giá trị từ 0-256 do đó ta khai báo một mảng có 256 phần tử
            //dùng kiểu double vì tính toán tổng số đếm có dữ liệu lớn
            //Dùng mảng 2 chiều để chứa thông tin cho 3 kênh R-G-B
            //Số 3 là đại diện cho 3 layout và 256 là vị trí tương ứng giá trị màu 0 --> 255
            double[,] histogram = new double[3,256];

            for (int x = 0; x < Original_img.Width; x++)
                for (int y = 0; y < Original_img.Height; y++)
                {
                    Color color = Original_img.GetPixel(x, y);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    //histogram của kênh màu R
                    histogram[0,R]++;
                    //histogram của kênh màu G
                    histogram[1,G]++;
                    //histogram của kênh màu B
                    histogram[2,B]++;
                }
            return histogram; //Trả mảng 2 chiếu chứa thông tin của histogram của R-G-B
        }

        List<PointPairList> ChuyenDoiHistogram(double[,] histogram)
        {
            //Dùng một mảng không cần khai báo trước số phần tử đê chứa thông số histogram
            List<PointPairList> points = new List<PointPairList>();

            PointPairList redPoints = new PointPairList(); //Chuyển đổi histogram kênh đỏ
            PointPairList greenPoints = new PointPairList(); //Chuyển đổi histogram kênh green
            PointPairList bluePoints = new PointPairList(); //Chuyển đổi histogram kênh blue


            for (int i = 0; i < 256; i++)
            {
                //i tương ứng trục ngang từ 0-255,histogram[i] là số lượng pixel màu i tương ứng trục đứng, là số pixel cùng mức xám
                redPoints.Add(i, histogram[0,i]);
                greenPoints.Add(i, histogram[1, i]);
                bluePoints.Add(i, histogram[2, i]);
            }

            //Sau vòng lặp for ta sẽ add giá trị các red,green, blue point tương ứng vào list
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);
            return points;
        }

        //Thiết lập 1 biểu đồ trong ZedGraph
        public GraphPane BieuDoHistogram(List<PointPairList> histogram)
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
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng giá trị màu";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000; //SỐ này phải lớn hơn kích thước ảnh (w x h)
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            //Dùng biểu đồ dạng bar để biểu diễn 
            gp.AddBar("Histogram's Red", histogram[0], Color.Red);
            gp.AddBar("Histogram's Green", histogram[1], Color.Green);
            gp.AddBar("Histogram's Blue", histogram[2], Color.Blue);
            return gp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
