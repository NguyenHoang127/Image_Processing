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

#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang GrayScale
luminance = Image.new(imgPIL.mode, imgPIL.size)

#Mỗi ảnh là một ma trận 2 chiều nên dùng sẽ dùng 2 vòng lặp for để quét hết kích thước của ảnh
#Đọc hết các điểm ảnh
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh mức xám dùng phương pháp Luminance
        gray_luminance = np.uint8(0.2126*R+0.7152*G+0.0722*B)

        #Gán giá trị mức xám cho các ảnh
        luminance.putpixel((x,y),(gray_luminance,gray_luminance,gray_luminance))


#Lấy các thông số ảnh xám
width_L = luminance.size[0]
height_L = luminance.size[1]

#Ma trận Sobel
Sobel_matrix_x = [ [ -1, -2, -1 ], [ 0, 0, 0 ], [ 1, 2, 1 ] ]
Sobel_matrix_y = [ [ -1, 0, 1 ] , [ -2, 0, 2 ], [ -1, 0, 1 ] ]

for x in range(1,width_L-1):
    for y in range(1,height_L-1):

        #Khai báo 3 biến để chứa tổng Gradien x va y va bien cua vector
        Gradien_x = 0
        Gradien_y = 0
        Magnitude_V = 0


        for i in range(x-1,x+2):
            for j in range(y-1,y+2):
                # Lấy điểm màu tại từng vị trí
                R,G,B = imgPIL.getpixel((i,j))

                Gradien_x += R*Sobel_matrix_x[(abs(x-i-1))][(abs(y-j-1))]
                Gradien_y += R*Sobel_matrix_y[(abs(x-i-1))][(abs(y-j-1))]

        Magnitude_V = abs(Gradien_x) + abs(Gradien_y)
        D0 = 255

        if(Magnitude_V<=D0):
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