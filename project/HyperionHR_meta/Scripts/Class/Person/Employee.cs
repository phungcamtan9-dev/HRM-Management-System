using HyperionHR_meta.Scripts.Class.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Person
{
    public class Employee : Person
    {
        public string MaNhanVien { get; set; }
        public Department PhongBan { get; set; }
        public Position ChucVu { get; set; }
        //public Contract HopDong { get; set; }

        public Employee()
        {
        }

        public Employee(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai,
                        string maNhanVien, Department phongBan, Position chucVu)// Contract hopDong)
            : base(id, hoTen, ngaySinh, email, soDienThoai)
        {
            MaNhanVien = maNhanVien;
            PhongBan = phongBan;
            ChucVu = chucVu;
            //HopDong = hopDong;
        }
    }
}
