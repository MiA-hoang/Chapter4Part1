using System;

namespace Bai4
{
    public class SinhVienCN : SinhVien
    {
        public string ChuyenNganh { get; set; }
        public double DiemTB { get; set; }
        public SinhVienCN(string ma, string ten, DateTime ns,string cn, double diem): base(ma, ten, ns)
        {
            ChuyenNganh = cn;
            DiemTB = diem;
        }

        public string XepLoai()
        {
            if (DiemTB >= 8) return "Giỏi";
            else if (DiemTB >= 7) return "Khá";
            else if (DiemTB >= 5) return "Trung bình";
            else return "Yếu";
        }

        public override string getInfor()
        {
            return base.getInfor() +
                   "\nChuyên ngành: " + ChuyenNganh +
                   "\nĐiểm TB: " + DiemTB +
                   "\nXếp loại: " + XepLoai();
        }
    }
}