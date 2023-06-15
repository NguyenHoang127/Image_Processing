import cv2 as cv
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import numpy as np
import matplotlib.pyplot as plt #Thư viện để vẽ biểu đồ

#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

#Đọc ảnh màu dùng thư viện openCV
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

def ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL):
    luminance = Image.new(imgPIL.mode, imgPIL.size)
    
    #Lấy kích thước của ảnh từ imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]
    
    for x in range(width):
        for y in range(height):
            #Lấy giá trị điểm ảnh tại vị trí (x,y)
            R,G,B = imgPIL.getpixel((x,y))

            gray_luminance = np.uint8(0.2126*R+0.7152*G+0.0722*B)

            #Gán giá trị mức xám cho các ảnh
            luminance.putpixel((x,y),(gray_luminance,gray_luminance,gray_luminance))

    return luminance

def TinhHistogram(HinhXamPIL):
    histogram = np.zeros(256) #Vì có 256 phần tử vì có pixel 0 -->255
    #Lấy kích thước ảnh
    width = HinhXamPIL.size[0]
    height = HinhXamPIL.size[1]

    for x in range(width):
        for y in range(height):
            # Lấy giá trị xám tại điểm (x,y)
            gR,gG,gB = HinhXamPIL.getpixel((x,y))

            #Giá trị gray tính ra cũng chính là phần tử thứ gray
            histogram[gR] = histogram[gR]+ 1

    return histogram

#Vẽ biểu đồ histogram
def VeBieuDoHistogram(his):
     w = 6
     h = 5
     plt.figure('Biểu đồ Histogram ảnh xám',figsize=(((w,h))),dpi=100)
     trucX = np.zeros(256)
     trucX = np.linspace(0,256,256)
     plt.plot(trucX,his,color ='orange')
     plt.title('Biểu đồ Histogram')
     plt.xlabel('Giá trị mức xám')
     plt.ylabel('Số điểm cùng giá trị mức xám')
     plt.show()

#-------------------------------------------Chương trình chính-------------------------------------

#Chuyển sang ảnh mức xám
HinhXamPIL = ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL)

#Tính histogram
his = TinhHistogram(HinhXamPIL)

#Chuyển ảnh PIL sang OpenCV để hiển thị 
HinhXamCV  = np.array(HinhXamPIL)
cv.imshow('Anh Muc Xam',HinhXamCV)
cv.imshow('Anh Mau RGB',img)

#Hiển thị biểu đồ Histogram
VeBieuDoHistogram(his)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()

