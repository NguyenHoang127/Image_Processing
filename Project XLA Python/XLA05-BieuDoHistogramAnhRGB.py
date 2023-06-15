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

def TinhHistogram(HinhMauPIL):
    histogram = np.zeros((3,256), np.uint)  #Vì có 256 phần tử vì có pixel 0 -->255
    #Lấy kích thước ảnh [[][][]]
    width = HinhMauPIL.size[0]
    height = HinhMauPIL.size[1]

    for x in range(width):
        for y in range(height):

            #Lấy giá trị điểm ảnh tại vị trí (x,y)
            R,G,B = imgPIL.getpixel((x,y))

            #Giá trị màu tính ra
            histogram[0,R] +=  1
            histogram[1,G] +=  1
            histogram[2,B] +=  1

    return histogram

#Vẽ biểu đồ histogram
def VeBieuDoHistogram(his):
     w = 6
     h = 5
     plt.figure('Biểu đồ Histogram của ảnh màu',figsize=(((w,h))),dpi=100)
     trucX = np.zeros(256)
     trucX = np.linspace(0,255,255) #là bắt đầu điểm cuối,điểm đầu,khoảng
     plt.plot(trucX,his[0,0:255],color ='red')
     plt.plot(trucX,his[1,0:255],color ='green')
     plt.plot(trucX,his[2,0:255],color ='blue')
     plt.title('Biểu đồ Histogram')
     plt.xlabel('Giá trị mức màu')
     plt.ylabel('Số điểm cùng giá trị màu')
     plt.show()

#-------------------------------------------Chương trình chính-------------------------------------

#Tính histogram
his = TinhHistogram(imgPIL)

#Chuyển ảnh PIL sang OpenCV để hiển thị 
cv.imshow('Anh Mau RGB',img)

#Hiển thị biểu đồ Histogram
VeBieuDoHistogram(his)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()

