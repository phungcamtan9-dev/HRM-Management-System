using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.System
{
    public class EmployeeFactory
    {
        // ==========================================
        // HÀM TẠO NHÂN VIÊN (FACTORY METHOD)
        // ==========================================
        public static Employee CreateEmployee(string loaiNhanVien, string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai, string maNhanVien)
        {
            if (loaiNhanVien == "FullTime")
            {
                FullTimeEmployee ftEmp = new FullTimeEmployee();
                ftEmp.Id = id;
                ftEmp.HoTen = hoTen;
                ftEmp.NgaySinh = ngaySinh;
                ftEmp.Email = email;
                ftEmp.SoDienThoai = soDienThoai;
                ftEmp.MaNhanVien = maNhanVien;

                // Trả về đối tượng FullTime (nhưng dưới dạng lớp cha Employee nhờ Đa hình)
                return ftEmp;
            }
            else if (loaiNhanVien == "PartTime")
            {
                PartTimeEmployee ptEmp = new PartTimeEmployee();
                ptEmp.Id = id;
                ptEmp.HoTen = hoTen;
                ptEmp.NgaySinh = ngaySinh;
                ptEmp.Email = email;
                ptEmp.SoDienThoai = soDienThoai;
                ptEmp.MaNhanVien = maNhanVien;

                // Trả về đối tượng PartTime
                return ptEmp;
            }
            else
            {
                // Ném ra lỗi nếu truyền sai loại
                throw new Exception("Loại nhân viên không hợp lệ trong hệ thống!");
            }
        }
    }
}
