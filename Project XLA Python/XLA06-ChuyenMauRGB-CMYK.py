#Đoàn Nguyễn Hoàng - 20146195

import cv2 as cv #Khai báo thư viện OpenCV
import numpy as np #Thư viện tính toán chuyên dụng dùng cho ma trận
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 

#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

#Đọc ảnh màu dùng thư viện OpenCV được mã hóa thành ma trận 3 chiều 
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

#Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang CYMK
cyan   = Image.new(imgPIL.mode, imgPIL.size)
magenta = Image.new(imgPIL.mode, imgPIL.size)
yellow = Image.new(imgPIL.mode, imgPIL.size)
black = Image.new(imgPIL.mode, imgPIL.size)

#Mỗi hình là một ma trận 2 chiều dùng 2 vòng for để đọc hết điểm ảnh bgr
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Thiết lập màu cho các kênh theo thứ tự (B,G,R)
        cyan.putpixel((x,y),(B,G,0))
        magenta.putpixel((x,y),(B,0,R))
        yellow.putpixel((x,y),(0,G,R))
        #Tính toán giá trị màu đen
        K = np.uint8(min(R,G,B))
        black.putpixel((x,y),(K,K,K))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
cyan_Cv   = np.array(cyan)
magenta_Cv  = np.array(magenta)
yellow_Cv  = np.array(yellow)
black_Cv  = np.array(black)   

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
cyan_res = cv.resize(cyan_Cv, dim, interpolation = cv.INTER_AREA)
magenta_res = cv.resize(magenta_Cv, dim, interpolation = cv.INTER_AREA)
yellow_res = cv.resize(yellow_Cv, dim, interpolation = cv.INTER_AREA)
black_res = cv.resize(black_Cv, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh Cyan',cyan_res)
cv.imshow('Kenh Magenta',magenta_res)
cv.imshow('Kenh Yellow',yellow_res)
cv.imshow('Kenh Black',black_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()