import cv2 as cv #Khai báo thư viện OpenCV
import numpy as np #Thư viện tính toán chuyên dụng dùng cho ma trận
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import math


#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

#Đọc ảnh màu dùng thư viện OpenCV được mã hóa thành ma trận 3 chiều 
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

#Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

# Ảnh Dùng Để Chứa Kết Quả Phân đoạn
segmentation_img = Image.new(imgPIL.mode, imgPIL.size)

#Tọa độ diện tích để tích vector A
x1 = 80
y1 = 400
x2 = 150
y2 = 500

#Ngưỡng
D0 = 45

vector_A= np.zeros(3,int)

for x in range(x1,x2+1):
    for y in range(y1,y2+1):

        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        vector_A[0] += R
        vector_A[1] += G
        vector_A[2] += B

size = abs(x2-x1)*abs(y2-y1)

vector_A[0] /= size
vector_A[1] /= size
vector_A[2] /= size

for x in range(width):
    for y in range(height):

        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        Z_R,Z_G,Z_B = imgPIL.getpixel((x,y))

        #Euclidean distance
        D = math.sqrt(pow((Z_R-vector_A[0]),2)+pow((Z_G-vector_A[1]),2)+pow((Z_B-vector_A[2]),2))

        if(D<=D0):
            Z_R = Z_G = Z_B = 255
            segmentation_img.putpixel((x,y),(np.uint8(Z_B),np.uint8(Z_G),np.uint8(Z_R)))
        else:
            segmentation_img.putpixel((x,y),(np.uint8(Z_B),np.uint8(Z_G),np.uint8(Z_R)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
segmentation_img_cv   = np.array(segmentation_img)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img) 
cv.imshow('Hinh sau khi phan doan voi nguong 45 va x1=80 y1=400 x2=150 y2=500',segmentation_img_cv)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()

