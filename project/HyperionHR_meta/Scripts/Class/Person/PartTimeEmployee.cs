using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.HR_Operations;
using System;

namespace HyperionHR_meta.Scripts.Class.Person
{
    [Serializable]
    public class PartTimeEmployee : Employee
    {
        public double SoGioLam { get; set; }
        public double MucLuongTheoGio { get; set; }
        public double SoGioLamTrongThang { get; set; }

        public PartTimeEmployee()
        {
        }

        public PartTimeEmployee(string id, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string soDienThoai,
                                string maNhanVien, Department phongBan, Position chucVu, Contract hopDong,
                                double soGioLam, double mucLuongTheoGio)
            : base(id, hoTen, ngaySinh, gioiTinh, email, soDienThoai, maNhanVien, phongBan, chucVu, hopDong)
        {
            SoGioLam = soGioLam;
            MucLuongTheoGio = mucLuongTheoGio;
        }

        public override string HienThiThongTin()
        {
            return base.HienThiThongTin() + "Nhân viên Part-time";
        }

        // ==========================================
        // GHI ĐÈ HÀM TÍNH LƯƠNG CỦA PART-TIME
        // ==========================================
        public override double TinhLuong()
        {
            return SoGioLamTrongThang * 30000;
        }
    }
}