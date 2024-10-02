using System;
using System.Text;

namespace BTHocSinh
{
    internal class HocSinh
    {
        private string hoTen;
        private string lopHoc;
        private double dToan;
        private double dLy;
        private double dHoa;

        public HocSinh() { }

        public HocSinh(string hoTen, string lopHoc, double dToan, double dLy, double dHoa)
        {
            this.hoTen = hoTen;
            this.lopHoc = lopHoc;
            this.dToan = dToan;
            this.dLy = dLy;
            this.dHoa = dHoa;
        }

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    hoTen = value.Trim();
                else
                    throw new ArgumentException("Họ tên không được để trống.");
            }
        }

        public string LopHoc
        {
            get { return lopHoc; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lopHoc = value.Trim();
                else
                    throw new ArgumentException("Lớp học không được để trống.");
            }
        }

        public double DToan
        {
            get { return dToan; }
            set
            {
                if (value >= 0 && value <= 10)
                    dToan = value;
                else
                    throw new ArgumentException("Điểm Toán phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DLy
        {
            get { return dLy; }
            set
            {
                if (value >= 0 && value <= 10)
                    dLy = value;
                else
                    throw new ArgumentException("Điểm Lý phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DHoa
        {
            get { return dHoa; }
            set
            {
                if (value >= 0 && value <= 10)
                    dHoa = value;
                else
                    throw new ArgumentException("Điểm Hóa phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DiemTB()
        {
            return (dToan + dLy + dHoa) / 3.0;
        }
    }
}
