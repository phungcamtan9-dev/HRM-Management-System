using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Payroll;
using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Person
{
    public class FullTimeEmployee : Employee
    {
        public Insurance BaoHiem { get; set; }
        public Allowance PhuCap { get; set; }

        public FullTimeEmployee()
        {
        }

        public FullTimeEmployee(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai,
                                string maNhanVien, Department phongBan, Position chucVu, Contract hopDong,
                                Insurance baoHiem, Allowance phuCap)
            : base(id, hoTen, ngaySinh, email, soDienThoai, maNhanVien, phongBan, chucVu, hopDong)
        {
            BaoHiem = baoHiem;
            PhuCap = phuCap;
        }
    }
}
