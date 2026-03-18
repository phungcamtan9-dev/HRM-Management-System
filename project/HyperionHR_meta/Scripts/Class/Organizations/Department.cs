using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;

namespace HyperionHR_meta.Scripts.Class.Organizations
{
    [Serializable]
    public class Department
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }

        public FullTimeEmployee NguoiQuanLy { get; private set; }

        public List<Employee> NhanVien { get; private set; }

        public Department()
        {
            NhanVien = new List<Employee>();
        }

        public Department(string maPB, string tenPB)
        {
            MaPB = maPB;
            TenPB = tenPB;
            NhanVien = new List<Employee>();
        }

        // ==========================================
        // METHODS
        // ==========================================

        // Thêm nhân viên
        public void AddEmployee(Employee emp)
        {
            if (emp != null && !NhanVien.Contains(emp))
            {
                NhanVien.Add(emp);
                emp.PhongBan = this; // Đồng bộ 2 chiều
            }
        }

        // Xóa nhân viên
        public void RemoveEmployee(Employee emp)
        {
            if (NhanVien.Contains(emp))
            {
                NhanVien.Remove(emp);
                emp.PhongBan = null; // Tránh lỗi dữ liệu
            }
        }

        // Hàm bổ nhiệm Quản lý cho phòng ban
        public void AssignManager(FullTimeEmployee manager)
        {
            if (manager != null)
            {
                // Ràng buộc nghiệp vụ: Kiểm tra mã chức vụ có chứa chữ "QL" không
                if (manager.ChucVu != null && manager.ChucVu.MaChucVu.Contains("QL"))
                {
                    NguoiQuanLy = manager;

                    // Nếu người quản lý chưa có trong danh sách nhân viên phòng ban thì thêm vào
                    if (!NhanVien.Contains(manager))
                    {
                        AddEmployee(manager);
                    }
                }
                else
                {
                    throw new Exception("Nhân viên này không có chức vụ Quản lý (Không có mã QL)!");
                }
            }
        }
    }
}