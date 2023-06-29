# PRN-prj
Để test kết nối với camera điện thoại thì tải app Droid Cam về (dành cho Android, còn Iphone thì có app Ip Webcam nhưng t chưa test)
Điện thoại và máy tính kết nối cùng 1 wifi (bắt buộc/ có thể dùng 3g nhưng cũng phải cùng 3g)
Tải về xong bật app lên thì tìm Wifi Ip có kiểu:192.168.... mỗi mạng sẽ mỗi khác
Thay vào trong  mjp.ParseStream(new Uri(" http://192.168.27.100:4747/video?640x480"));  bằng IP của điện thoại mình
Chạy winform nhấn button1 để khởi động liên kết, button2 để chụp
