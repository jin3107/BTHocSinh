using System;

namespace BTHocSinh
{
    internal static class Input
    {
        public static int NhapSoLuongSinhVien()
        {
            int number;
            while (true)
            {
                Console.Write("Nhập số lượng sinh viên: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Số lượng sinh viên không hợp lệ! Vui lòng nhập lại.");
                }
            }
            return number;
        }

        public static HocSinh NhapThongTinHocSinh(int stt)
        {
            HocSinh hocSinh = new HocSinh();
            while (true)
            {
                Console.Write($"Nhập họ tên sinh viên thứ {stt}: ");
                string hoTen = Console.ReadLine();
                try
                {
                    hocSinh.HoTen = hoTen;
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write($"Nhập lớp sinh viên thứ {stt}: ");
                string lopHoc = Console.ReadLine();
                try
                {
                    hocSinh.LopHoc = lopHoc;
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            hocSinh.DToan = NhapDiem("Toán", stt);
            hocSinh.DLy = NhapDiem("Lý", stt);
            hocSinh.DHoa = NhapDiem("Hóa", stt);

            return hocSinh;
        }

        private static double NhapDiem(string monHoc, int stt)
        {
            double diem;
            while (true)
            {
                Console.Write($"Nhập Điểm {monHoc} cho sinh viên thứ {stt}: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out diem))
                {
                    try
                    {
                        switch (monHoc.ToLower())
                        {
                            case "toán":
                                hocTemp.DToan = diem;
                                break;
                            case "lý":
                                hocTemp.DLy = diem;
                                break;
                            case "hóa":
                                hocTemp.DHoa = diem;
                                break;
                        }
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine($"Điểm {monHoc} không hợp lệ! Vui lòng nhập lại.");
                }
            }
            return diem;
        }

        private static HocSinh hocTemp = new HocSinh();
    }
}
