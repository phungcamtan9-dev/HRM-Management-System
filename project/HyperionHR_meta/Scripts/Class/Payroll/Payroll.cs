using HyperionHR_meta.Scripts.Class;
using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HyperionHR_meta.Scripts.Class.Payroll
{
    public class Payroll
    {
        public string MaBangLuong { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public Employee NhanVien { get; set; }
        public double TongLuong { get; set; }

        public Payroll()
        {
        }

        public Payroll(string maBangLuong, int thang, int nam, Employee nhanVien, double tongLuong)
        {
            MaBangLuong = maBangLuong;
            Thang = thang;
            Nam = nam;
            NhanVien = nhanVien;
            TongLuong = tongLuong;
        }
    }
}
