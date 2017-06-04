create proc ht_hangnhap
(
@ngay1 date,
@ngay2 date
)
as
select ct.so_pn,ngaynhap,ma_ncc,ct.ma_kho ,ct.ma_hh,ct.soluong,ct.dongia  
from chitietphieunhap ct, phieunhap1 pn1 
where ct.so_pn=pn1.so_pn and ngaynhap between @ngay1 and @ngay2


create proc ht_hangxuat
(
@ngay1 date,
@ngay2 date
)
as
select ct.so_px,ngayxuat,ct.ma_kho,ma_khach ,ct.ma_hh,ct.soluong,ct.dongia  
from CTphieuxuat ct, phieuxuat px 
where ct.so_px=px.so_px and ngayxuat between @ngay1 and @ngay2