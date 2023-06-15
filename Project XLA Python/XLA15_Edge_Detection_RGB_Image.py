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

# Ảnh Dùng Để Chứa Kết Quả Chuyển Đổi Lấy Đường Viền
Edge_Detection_img = Image.new(imgPIL.mode, imgPIL.size)

#Ma trận Sobel
Sobel_matrix_x = [ [ -1, -2, -1 ], [ 0, 0, 0 ], [ 1, 2, 1 ] ]
Sobel_matrix_y = [ [ -1, 0, 1 ] , [ -2, 0, 2 ], [ -1, 0, 1 ]]

for x in range(1,width-1):
    for y in range(1,height-1):

        Gra_x_R = Gra_x_G = Gra_x_B = 0
        Gra_y_R = Gra_y_G = Gra_y_B = 0
        Gxx = Gyy = Gxy = 0
        theta = Ftheta = 0

        for i in range(x-1,x+2):
            for j in range(y-1,y+2):
                # Lấy điểm màu tại từng vị trí
                R,G,B = imgPIL.getpixel((i,j))

                Gra_x_R += R * Sobel_matrix_x[abs(x - i - 1)][abs(y - j - 1)]
                Gra_x_G += G * Sobel_matrix_x[abs(x - i - 1)][abs(y - j - 1)]
                Gra_x_B += B * Sobel_matrix_x[abs(x - i - 1)][abs(y - j - 1)]

                Gra_y_R += R * Sobel_matrix_y[abs(x - i - 1)][abs(y - j - 1)]
                Gra_y_G += G * Sobel_matrix_y[abs(x - i - 1)][abs(y - j - 1)]
                Gra_y_B += B * Sobel_matrix_y[abs(x - i - 1)][abs(y - j - 1)]

        
        Gxx = math.pow(abs(Gra_x_R), 2) + math.pow(abs(Gra_x_G), 2)  + math.pow(abs(Gra_x_B), 2)
        Gyy = math.pow(abs(Gra_y_R), 2) + math.pow(abs(Gra_y_G), 2)  + math.pow(abs(Gra_y_B), 2)
        Gxy = (Gra_x_R * Gra_y_R) + (Gra_x_G * Gra_y_G) + (Gra_x_B * Gra_y_B)

        theta = math.atan2((2 * Gxy),(Gxx - Gyy))*0.5

        Ftheta = math.sqrt(((Gxx+Gyy)+((Gxx-Gyy)*math.cos(2*theta))+(2*Gxy*math.sin(2*theta)))*0.5)

        D0 = 130

        if(Ftheta<D0):
            Edge_Detection_img.putpixel((x,y),(np.uint8(0),np.uint8(0),np.uint8(0)))
        else:
            Edge_Detection_img.putpixel((x,y),(np.uint8(255),np.uint8(255),np.uint8(255)))


#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Edge_Detection_img   = np.array(Edge_Detection_img)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img) 
cv.imshow('Hinh sau khi lay duong vien voi nguong la 130',Edge_Detection_img)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()