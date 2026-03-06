using System;

namespace Bai4
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public SinhVien(string ma, string ten, DateTime ns)
        {
            MaSV = ma;
            HoTen = ten;
            NgaySinh = ns;
        }

        public virtual string getInfor()
        {
            return "Mã SV: " + MaSV +
                   "\nHọ tên: " + HoTen +
                   "\nNgày sinh: " + NgaySinh.ToShortDateString();
        }
    }
}