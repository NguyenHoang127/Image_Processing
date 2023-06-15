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

# Ảnh Dùng Để Chứa Kết Quả Chuyển Đổi Làm Sắc Nét
sharpening_img = Image.new(imgPIL.mode, imgPIL.size)

for x in range(1,width-1):
    for y in range(1,height-1):

        #Khai báo 3 biến để chứa tổng laplacian
        Rs = 0
        Gs = 0
        Bs = 0

        #Tao ma tran mask
        mask = [[0,-1,0],[-1,4,-1],[0,-1,0]]

        for i in range(x-1,x+2):
            for j in range(y-1,y+2):
                # Lấy điểm màu tại từng vị trí
                R,G,B = imgPIL.getpixel((i,j))

                Rs += R*mask[(abs(x-i-1))][(abs(y-j-1))]
                Gs += G*mask[(abs(x-i-1))][(abs(y-j-1))]
                Bs += B*mask[(abs(x-i-1))][(abs(y-j-1))]

        #Lấy giá trị điểm ảnh điểm đang xét
        R_C,G_C,B_C = imgPIL.getpixel((i,j))

        #Tính giá trị điểm ảnh sau khi làm nét
        R_SP = R_C + 1*Rs
        G_SP = G_C + 1*Gs
        B_SP = B_C + 1*Bs

        #So sánh điều kiện
        if (R_SP > 255):  R_SP = 255
        if (G_SP > 255):  G_SP = 255 
        if (B_SP > 255):  B_SP = 255 

        if (R_SP < 0):  R_SP = 0
        if (G_SP < 0):  G_SP = 0
        if (B_SP < 0):  B_SP = 0

        sharpening_img.putpixel((x,y),(np.uint8(B_SP),np.uint8(G_SP),np.uint8(R_SP)))


#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
sharpening_img   = np.array(sharpening_img)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img) 
cv.imshow('Hinh sau khi lam sac net',sharpening_img)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()