using HyperionHR_meta.Scripts.Class.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class.Person;
using System.Diagnostics.Contracts;

namespace HyperionHR_meta.Scripts.Class.Person
{
    public class PartTimeEmployee : Employee
    {
        public double SoGioLam { get; set; }
        public double HeSoLuongGio { get; set; }

        public PartTimeEmployee()
        {
        }

        public PartTimeEmployee(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai,
                                string maNhanVien, Department phongBan, Position chucVu,
                                double soGioLam, double heSoLuongGio)
            : base(id, hoTen, ngaySinh, email, soDienThoai, maNhanVien, phongBan, chucVu)
        {
            SoGioLam = soGioLam;
            HeSoLuongGio = heSoLuongGio;
        }
    }
}
