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

#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang YCrCb
Y_img   = Image.new(imgPIL.mode, imgPIL.size)
Cb_img = Image.new(imgPIL.mode, imgPIL.size)
Cr_img = Image.new(imgPIL.mode, imgPIL.size)
YCbCr_img = Image.new(imgPIL.mode, imgPIL.size)

#Mỗi hình là một ma trận 2 chiều dùng 2 vòng for để đọc hết điểm ảnh bgr
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Tính toán các giá trị YCrCb
        #Tính Y
        Y = 16 + (65.738*R/256) + (129.057*G/256) + (25.064*B/256)

        #Tinh Cb
        Cb = 128 - (37.945*R/256) - (74.494*G/256) + (112.439*B/256)

        #Tinh Cr
        Cr = 128 + (112.439*R/256) - (94.154*G/256) - (18.285*B/256)
        
        #Thiết lập màu cho các kênh YCbCr
        Y_img.putpixel((x,y),(np.uint8(Y),np.uint8(Y),np.uint8(Y)))
        Cb_img.putpixel((x,y),(np.uint8(Cb),np.uint8(Cb),np.uint8(Cb)))
        Cr_img.putpixel((x,y),(np.uint8(Cr),np.uint8(Cr),np.uint8(Cr)))
        YCbCr_img.putpixel((x,y),(np.uint8(Cr),np.uint8(Cb),np.uint8(Y)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Y_Cv   = np.array(Y_img)
Cb_Cv  = np.array(Cr_img)
Cr_Cv  = np.array(Cb_img)
YCbCr_Cv  = np.array(YCbCr_img)   

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
Y_res = cv.resize(Y_Cv, dim, interpolation = cv.INTER_AREA)
Cb_res = cv.resize(Cb_Cv, dim, interpolation = cv.INTER_AREA)
Cr_res = cv.resize(Cr_Cv, dim, interpolation = cv.INTER_AREA)
YCbCr_res = cv.resize(YCbCr_Cv, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh Y',Y_res)
cv.imshow('Kenh Cr',Cb_res)
cv.imshow('Kenh Cb',Cr_res)
cv.imshow('Kenh YCbCr',YCbCr_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()