using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using System;
using System.Text.Json.Serialization;

namespace HyperionHR_meta.Scripts.Class.Person
{
    [Serializable]
    [JsonDerivedType(typeof(FullTimeEmployee), typeDiscriminator: "FullTime")]
    [JsonDerivedType(typeof(PartTimeEmployee), typeDiscriminator: "PartTime")]
    public class Employee : Person
    {
        public string MaNhanVien { get; set; }
        public Department PhongBan { get; set; }
        public Position ChucVu { get; set; }
        public Contract HopDong { get; set; }

        public Employee()
        {
        }

        public Employee(string id, string hoTen, DateTime ngaySinh, string gioiTinh ,string email, string soDienThoai,
                        string maNhanVien, Department phongBan, Position chucVu, Contract hopDong)
            : base(id, hoTen, ngaySinh, gioiTinh, email, soDienThoai)
        {
            MaNhanVien = maNhanVien;
            PhongBan = phongBan;
            ChucVu = chucVu;
            HopDong = hopDong;
        }

        public virtual string HienThiThongTin()
        {
            return "Mã NV: " + MaNhanVien + " - Tên: " + HoTen;
        }

        // ==========================================
        // HÀM ẢO: TÍNH LƯƠNG (Để các lớp con tự định nghĩa)
        // ==========================================
        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}