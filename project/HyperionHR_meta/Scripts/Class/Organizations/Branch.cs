using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;

namespace HyperionHR_meta.Scripts.Class.Organizations
{
    [Serializable]
    public class Branch
    {
        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaChi { get; set; }

        // Cập nhật: Người quản lý chi nhánh phải là nhân viên FullTime
        public FullTimeEmployee NguoiQuanLy { get; set; }

        public List<Department> DanhSachPB { get; set; }

        public Branch()
        {
            DanhSachPB = new List<Department>();
        }

        public Branch(string maCN, string tenCN, string diaChi, FullTimeEmployee nguoiQuanLy)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
            NguoiQuanLy = nguoiQuanLy;
            DanhSachPB = new List<Department>();
        }

        // Thêm phòng ban vào chi nhánh
        public void AddDepartment(Department dept)
        {
            if (dept != null && !DanhSachPB.Contains(dept))
            {
                DanhSachPB.Add(dept);
            }
        }
    }
}