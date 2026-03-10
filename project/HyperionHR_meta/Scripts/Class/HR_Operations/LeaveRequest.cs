using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class LeaveRequest
    {
        public string MaDon { get; set; }
        public Employee NhanVien { get; set; }
        public LeaveType LoaiNghiPhep { get; set; }
        public int SoNgayNghi { get; set; }

        public LeaveRequest()
        {
        }

        public LeaveRequest(string maDon, Employee nhanVien, LeaveType loaiNghiPhep, int soNgayNghi)
        {
            MaDon = maDon;
            NhanVien = nhanVien;
            LoaiNghiPhep = loaiNghiPhep;
            SoNgayNghi = soNgayNghi;
        }
    }
}
