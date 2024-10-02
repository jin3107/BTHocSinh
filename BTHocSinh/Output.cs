using System;
using System.Collections.Generic;
using System.Text;

namespace BTHocSinh
{
    internal static class Output
    {
        public static void HienThiDanhSach(List<HocSinh> danhSach)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("\n\n----- DANH SÁCH SINH VIÊN -----\n");
            foreach (var hocSinh in danhSach)
            {
                HienThiHocSinh(hocSinh);
            }
        }

        public static void HienThiHocSinh(HocSinh hocSinh)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine($"Họ tên: {hocSinh.HoTen}");
            Console.WriteLine($"Lớp học: {hocSinh.LopHoc}");
            Console.WriteLine($"Điểm Toán: {hocSinh.DToan}");
            Console.WriteLine($"Điểm Lý: {hocSinh.DLy}");
            Console.WriteLine($"Điểm Hóa: {hocSinh.DHoa}");
            Console.WriteLine($"Điểm Trung Bình: {hocSinh.DiemTB():F2}");
            Console.WriteLine("\n----------------------------------------\n\n");
        }
    }
}
