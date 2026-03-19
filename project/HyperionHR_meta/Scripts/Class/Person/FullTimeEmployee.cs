using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.HR_Operations;
using System;

namespace HyperionHR_meta.Scripts.Class.Person
{
    [Serializable]
    public class FullTimeEmployee : Employee
    {
        public double LuongCoBan { get; set; }
        public double PhuCapQuanLy { get; set; }

        public FullTimeEmployee()
        {
        }

        public FullTimeEmployee(string id, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string soDienThoai,
                                string maNhanVien, Department phongBan, Position chucVu, Contract hopDong,
                                double luongCoBan, double phuCapQuanLy)
            : base(id, hoTen, ngaySinh, gioiTinh, email, soDienThoai, maNhanVien, phongBan, chucVu, hopDong)
        {
            LuongCoBan = luongCoBan;
            PhuCapQuanLy = phuCapQuanLy;
        }

        public override string HienThiThongTin()
        {
            return base.HienThiThongTin() + " (Nhân viên Full-time)";
        }

        // ==========================================
        // GHI ĐÈ HÀM TÍNH LƯƠNG CỦA FULL-TIME
        // ==========================================
        public override double TinhLuong()
        {
            double tongLuong = LuongCoBan;

            // Kiểm tra nếu là quản lý (Mã chức vụ có chữ "QL") thì cộng phụ cấp
            if (ChucVu != null && ChucVu.MaChucVu.Contains("QL"))
            {
                tongLuong = tongLuong + PhuCapQuanLy;
            }

            return tongLuong;
        }
    }
}