using System;
using System.Collections.Generic;

namespace BTHocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int number = Input.NhapSoLuongSinhVien();
            List<HocSinh> listHocSinh = new List<HocSinh>();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"\n-- Nhập thông tin cho sinh viên thứ {i} --");
                HocSinh hocSinh = Input.NhapThongTinHocSinh(i);
                listHocSinh.Add(hocSinh);
            }

            Output.HienThiDanhSach(listHocSinh);

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
