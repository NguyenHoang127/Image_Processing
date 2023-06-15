import cv2 as cv #Khai báo thư viện OpenCV
import numpy as np #Thư viện tính toán chuyên dụng dùng cho ma trận
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import math

#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

def donothing(x):
    pass
cv.namedWindow('Anh Sau Khi Lam Muot')

#Đọc ảnh màu dùng thư viện OpenCV được mã hóa thành ma trận 3 chiều 
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

#Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

# Ảnh Dùng Để Chứa Kết Quả Chuyển Đổi Làm Mượt
smooth_img = Image.new(imgPIL.mode, imgPIL.size)

def SmoothedImage_3x3(imgPIL):    
        img_3x3   = Image.new(imgPIL.mode, imgPIL.size)

        for x in range(1,width-1):
            for y in range(1,height-1):
                #Khai báo 3 biến để chứa tổng
                Rs = 0
                Gs = 0
                Bs = 0

                for i in range(x-1,x+2):
                    for j in range(y-1,y+2):
                        # Lấy điểm màu tại từng vị trí
                        R,G,B = imgPIL.getpixel((i,j))

                        Rs += R
                        Gs += G
                        Bs += B

                K = 3*3
                Rs = int(Rs/K)
                Gs = int(Gs/K)
                Bs = int(Bs/K)

                img_3x3.putpixel((x,y),(np.uint8(Bs),np.uint8(Gs),np.uint8(Rs)))
        return img_3x3

def SmoothedImage_5x5(imgPIL):    
        img_5x5   = Image.new(imgPIL.mode, imgPIL.size)

        for x in range(2,width-2):
            for y in range(2,height-2):
                #Khai báo 5 biến để chứa tổng
                Rs = 0
                Gs = 0
                Bs = 0

                for i in range(x-2,x+3):
                    for j in range(y-2,y+3):
                        # Lấy điểm màu tại từng vị trí
                        R,G,B = imgPIL.getpixel((i,j))

                        Rs += R
                        Gs += G
                        Bs += B

                K = 5*5
                Rs = int(Rs/K)
                Gs = int(Gs/K)
                Bs = int(Bs/K)

                img_5x5.putpixel((x,y),(np.uint8(Bs),np.uint8(Gs),np.uint8(Rs)))
        
        return img_5x5

def SmoothedImage_7x7(imgPIL):    
        img_7x7   = Image.new(imgPIL.mode, imgPIL.size)

        for x in range(3,width-3):
            for y in range(3,height-3):
                #Khai báo 3 biến để chứa tổng
                Rs = 0
                Gs = 0
                Bs = 0

                for i in range(x-3,x+4):
                    for j in range(y-3,y+4):
                        # Lấy điểm màu tại từng vị trí
                        R,G,B = imgPIL.getpixel((i,j))

                        Rs += R
                        Gs += G
                        Bs += B

                K = 7*7
                Rs = int(Rs/K)
                Gs = int(Gs/K)
                Bs = int(Bs/K)

                img_7x7.putpixel((x,y),(np.uint8(Bs),np.uint8(Gs),np.uint8(Rs)))
        return img_7x7

def SmoothedImage_9x9(imgPIL):    
        img_9x9   = Image.new(imgPIL.mode, imgPIL.size)

        for x in range(4,width-4):
            for y in range(4,height-4):
                #Khai báo 3 biến để chứa tổng
                Rs = 0
                Gs = 0
                Bs = 0

                for i in range(x-4,x+5):
                    for j in range(y-4,y+5):
                        # Lấy điểm màu tại từng vị trí
                        R,G,B = imgPIL.getpixel((i,j))

                        Rs += R
                        Gs += G
                        Bs += B

                K = 9*9
                Rs = int(Rs/K)
                Gs = int(Gs/K)
                Bs = int(Bs/K)

                img_9x9.putpixel((x,y),(np.uint8(Bs),np.uint8(Gs),np.uint8(Rs)))
        return img_9x9
        
cv.createTrackbar('Value','Anh Sau Khi Lam Muot',0,4,donothing)
while True:
    Muc_Gia_Tri = cv.getTrackbarPos('Value','Anh Sau Khi Lam Muot')
    if(Muc_Gia_Tri == 1):
         smooth_img = SmoothedImage_3x3(imgPIL)
    elif(Muc_Gia_Tri == 2):
         smooth_img = SmoothedImage_5x5(imgPIL)
    elif(Muc_Gia_Tri == 3):
        smooth_img = SmoothedImage_7x7(imgPIL)
    elif(Muc_Gia_Tri == 4):
        smooth_img = SmoothedImage_9x9(imgPIL)     
         
    #Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
    smooth_cv  = np.array(smooth_img)  

    #Resize kích thước ảnh
    dim = (500, 500)
    img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
    smooth_res = cv.resize(smooth_cv, dim, interpolation = cv.INTER_AREA)

    #Hiển thị hình dùng thư viện OpenCV
    cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
    cv.imshow('Anh Sau Khi Lam Muot',smooth_res)

    #Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
    k = cv.waitKey(1)
    if k == ord('q'):
        break

#-----------------------------------------------------------------------------------------
#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()


              

