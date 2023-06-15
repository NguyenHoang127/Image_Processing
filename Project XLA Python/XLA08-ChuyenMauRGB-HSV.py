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

#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang HSV
hue   = Image.new(imgPIL.mode, imgPIL.size)
saturation = Image.new(imgPIL.mode, imgPIL.size)
value = Image.new(imgPIL.mode, imgPIL.size)
hsi = Image.new(imgPIL.mode, imgPIL.size)

#Mỗi hình là một ma trận 2 chiều dùng 2 vòng for để đọc hết điểm ảnh bgr
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Tính toán các giá trị HSV
        # Tính H - góc theta
        t1 = ((R - G) + (R - B)) / 2
        t2 = t2 = math.sqrt(math.pow((R - G), 2) + (R - B) * (G - B))
        theta = math.acos(t1 / t2)

        #Công thức tính giá trị H
        H = 0
        if (B <= G):
            H = theta
        else:
            H = 2 * math.pi - theta

        H = H * 180 / math.pi
        
        #Tính giá trị S
        S = 1 - 3 * (min(R, G, B)) / (R + G + B)

        #Tính giá trị V
        V = max(R,G,B)
        
        #Thiết lập màu cho các kênh VSH
        hue.putpixel((x,y),(np.uint8(H),np.uint8(H),np.uint8(H)))
        saturation.putpixel((x,y),(np.uint8(S*255),np.uint8(S*255),np.uint8(S*255)))
        value.putpixel((x,y),(np.uint8(V),np.uint8(V),np.uint8(V)))

        hsi.putpixel((x,y),(np.uint8(V),np.uint8(S*255),np.uint8(H)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
hue_Cv   = np.array(hue)
saturation_Cv  = np.array(saturation)
value_Cv  = np.array(value)
hsi_Cv  = np.array(hsi)   

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
hue_res = cv.resize(hue_Cv, dim, interpolation = cv.INTER_AREA)
saturation_res = cv.resize(saturation_Cv, dim, interpolation = cv.INTER_AREA)
value_res = cv.resize(value_Cv, dim, interpolation = cv.INTER_AREA)
hsi_res = cv.resize(hsi_Cv, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh Hue',hue_res)
cv.imshow('Kenh Saturation',saturation_res)
cv.imshow('Kenh Value',value_res)
cv.imshow('Kenh HSV',hsi_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()