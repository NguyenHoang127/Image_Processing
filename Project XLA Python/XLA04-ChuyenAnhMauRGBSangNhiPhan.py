import cv2 as cv
from PIL import Image #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import numpy as np

def donothing(x):
    pass
cv.namedWindow('Anh Nhi Phan (Binary)')

#Khai báo đường dẫn filehinh
filehinh = r'lena.jpg'

#Đọc ảnh màu dùng thư viện openCV
img = cv.imread(filehinh,cv.IMREAD_COLOR)

#Đọc ảnh màu PIL. Ảnh PIL sẽ dùng để thực hiện các tác vụ tính toán và xử lý
imgPIL = Image.open(filehinh)

#Tạo một ảnh cùng kích thước và mode với ảnh imgPIL
#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Binary
binary = Image.new(imgPIL.mode, imgPIL.size)

#Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]
 #Tạo thanh track bar
cv.createTrackbar('Value','Anh Nhi Phan (Binary)',0,255,donothing)
while True:
    
    Threshold = cv.getTrackbarPos('Value','Anh Nhi Phan (Binary)')
    #Mỗi ảnh là một ma trận 2 chiều nên dùng sẽ dùng 2 vòng lặp for để quét hết kích thước của ảnh
    #Đọc hết các điểm ảnh
    for x in range(width):
        for y in range(height):
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
            R,G,B = imgPIL.getpixel((x,y))

        #Công thức chuyển đổi điểm ảnh màu RGB thành điểm ảnh mức xám dùng phương pháp Luminance
            binary_value = np.uint8(0.2126*R+0.7152*G+0.0722*B)

        #Xác định giá trị điểm nhị phân
            if (binary_value < Threshold):
                binary.putpixel((x,y),(0,0,0))
            else:
                binary.putpixel((x,y),(255,255,255))


    #Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
    binary_cv  = np.array(binary)  

    #Resize kích thước ảnh
    dim = (500, 500)
    img_res = cv.resize(img, dim, interpolation = cv.INTER_AREA)
    binary_res = cv.resize(binary_cv, dim, interpolation = cv.INTER_AREA)

    #Hiển thị hình dùng thư viện OpenCV
    cv.imshow('Hinh mau RGB goc co gai Lenna',img_res) 
    cv.imshow('Anh Nhi Phan (Binary)',binary_res)

    #Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
    k = cv.waitKey(1)
    if k == ord('q'):
        break

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv.destroyAllWindows()

        

