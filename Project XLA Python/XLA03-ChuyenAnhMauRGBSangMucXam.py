import cv2 as cv
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import numpy as np

#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

#Đọc ảnh màu dùng thư viện openCV
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

#Tạo một ảnh cùng kích thước và mode với ảnh imgPIL
#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang GrayScale
average   = Image.new(imgPIL.mode, imgPIL.size)
lightness = Image.new(imgPIL.mode, imgPIL.size)
luminance = Image.new(imgPIL.mode, imgPIL.size)

#Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Mỗi ảnh là một ma trận 2 chiều nên dùng sẽ dùng 2 vòng lặp for để quét hết kích thước của ảnh
#Đọc hết các điểm ảnh
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R,G,B = imgPIL.getpixel((x,y))

        #Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh mức xám dùng phương pháp Average
        gray_average = np.uint8((R+G+B)/3)
        #Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh mức xám dùng phương pháp Lightness
        gray_lightness = np.uint8((max(R,G,B)+min(R,G,B))/2)
        #Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh mức xám dùng phương pháp Luminance
        gray_luminance = np.uint8(0.2126*R+0.7152*G+0.0722*B)

        #Gán giá trị mức xám cho các ảnh
        average.putpixel((x,y),(gray_average,gray_average,gray_average))
        lightness.putpixel((x,y),(gray_lightness,gray_lightness,gray_lightness))
        luminance.putpixel((x,y),(gray_luminance,gray_luminance,gray_luminance))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
anhxam_average    = np.array(average)
anhxam_lightness  = np.array(lightness)
anhxam_luminance  = np.array(luminance)  

#Resize kích thước ảnh
dim = (370, 370)
img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
average_res = cv.resize(anhxam_average, dim, interpolation = cv.INTER_AREA)
lightness_res = cv.resize(anhxam_lightness, dim, interpolation = cv.INTER_AREA)
luminance_res = cv.resize(anhxam_luminance, dim, interpolation = cv.INTER_AREA)

#Hiển thị hình dùng thư viện OpenCV
cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
cv.imshow('Kenh anh mau xam Average',average_res)
cv.imshow('Kenh anh mau xam Lightness',lightness_res)
cv.imshow('Kenh anh mau xam Luminance',luminance_res)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv.waitKey()

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()

        