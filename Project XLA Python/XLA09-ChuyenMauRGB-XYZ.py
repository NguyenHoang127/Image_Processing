#Đoàn Nguyễn Hoàng - 20146195

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

#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang XYZ
x_img   = Image.new(imgPIL.mode, imgPIL.size)
y_img = Image.new(imgPIL.mode, imgPIL.size)
z_img = Image.new(imgPIL.mode, imgPIL.size)
xyz_img = Image.new(imgPIL.mode, imgPIL.size)

#Mỗi hình là một ma trận 2 chiều dùng 2 vòng for để đọc hết điểm ảnh bgr
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Tính toán các giá trị XYZ
        #Tính X
        X = 0.4124564 * R + 0.3575761 * G + 0.1804375 * B

        #Tinh Y
        Y = 0.2126729 * R + 0.7151522 * G + 0.0721750 * B

        #Tinh Z
        Z = 0.0193339 * R + 0.1191920 * G + 0.9503041 * B
        
        #Thiết lập màu cho các kênh ZYX
        x_img.putpixel((x,y),(np.uint8(X),np.uint8(X),np.uint8(X)))
        y_img.putpixel((x,y),(np.uint8(Y),np.uint8(Y),np.uint8(Y)))
        z_img.putpixel((x,y),(np.uint8(Z),np.uint8(Z),np.uint8(Z)))
        xyz_img.putpixel((x,y),(np.uint8(Z),np.uint8(Y),np.uint8(X)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
x_Cv   = np.array(x_img)
y_Cv  = np.array(y_img)
z_Cv  = np.array(z_img)
xyz_Cv  = np.array(xyz_img)   

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
x_res = cv.resize(x_Cv, dim, interpolation = cv.INTER_AREA)
y_res = cv.resize(y_Cv, dim, interpolation = cv.INTER_AREA)
z_res = cv.resize(z_Cv, dim, interpolation = cv.INTER_AREA)
xyz_res = cv.resize(xyz_Cv, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh X',x_res)
cv.imshow('Kenh Y',y_res)
cv.imshow('Kenh Z',z_res)
cv.imshow('Kenh XYZ',xyz_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()