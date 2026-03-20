using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using System;

namespace HyperionHR_meta.Scripts.Class.Person
{
    [Serializable]
    public class Employee
    {
        // ==========================================
        // THUỘC TÍNH CÁ NHÂN 
        // ==========================================
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        // ==========================================
        // THUỘC TÍNH CÔNG VIỆC
        // ==========================================
        public string MaNhanVien { get; set; }
        public Department PhongBan { get; set; }
        public Position ChucVu { get; set; }
        public Contract HopDong { get; set; }

        // Constructor rỗng 
        public Employee()
        {
        }

        // Constructor đầy đủ tham số
        public Employee(string id, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string soDienThoai,
                        string maNhanVien, Department phongBan, Position chucVu, Contract hopDong)
        {
            // Gán dữ liệu cá nhân
            Id = id;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Email = email;
            SoDienThoai = soDienThoai;

            // Gán dữ liệu công việc
            MaNhanVien = maNhanVien;
            PhongBan = phongBan;
            ChucVu = chucVu;
            HopDong = hopDong;
        }

        public virtual string HienThiThongTin()
        {
            return "";
        }

        // ==========================================
        // HÀM ẢO: TÍNH LƯƠNG 
        // ==========================================
        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}