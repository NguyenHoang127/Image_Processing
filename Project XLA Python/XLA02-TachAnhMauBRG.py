#Đoàn Nguyễn Hoàng - 20146195

import cv2 as cv
import numpy as np #Thư viện tính toán chuyên dụng dùng cho ma trận

#Đọc ảnh màu dùng thư viện OpenCV được mã hóa thành ma trận 3 chiều 
img = cv.imread('Lenna.jpg',cv.IMREAD_COLOR)


#Lấy kích thước của ảnh
width = len(img)      #Lấy số phần tử mảng 2 chiều với cách tính là mảng 2 chiều là 1 mảng đơn vị trong mảng 3 chiều
height  = len(img[1]) #Lấy số phần tử mảng 1 chiều trong mảng 2 chiều


#Khai báo 3 biến để chứa hình 3 kênh R-G-B
red   = np.zeros((width,height,3), np.uint8)  # Số 3 là 3 kênh R-G-B, mỗi kênh 8bit 
green = np.zeros((width,height,3), np.uint8)
blue  = np.zeros((width,height,3), np.uint8)

#Ban đầu set zero cho tất cả điểm ảnh có trong 3 kênh trong mỗi hình
red  [:] = [0,0,0]
green[:] = [0,0,0]
blue [:] = [0,0,0]

#Mỗi hình là một ma trận 2 chiều dùng 2 vòng for để đọc hết điểm ảnh bgr
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R = img[x,y,2]
        G = img[x,y,1]
        B = img[x,y,0]  

        #Thiết lập màu cho các kênh
        red  [x,y,2] = R
        green[x,y,1] = G
        blue [x,y,0] = B

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
red_res = cv.resize(red, dim, interpolation = cv.INTER_AREA)
green_res = cv.resize(green, dim, interpolation = cv.INTER_AREA)
blue_res = cv.resize(blue, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh RED',red_res)
cv.imshow('Kenh GREEN',green_res)
cv.imshow('Kenh BLUE',blue_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()