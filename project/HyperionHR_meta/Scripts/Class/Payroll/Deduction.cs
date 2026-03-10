using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    internal class Deduction
    {
        private string _maKhauTru;
        private string _tenKhoanTru;
        private double _soTien;

        public string MaKhauTru { get => _maKhauTru; set => _maKhauTru = value; }
        public string TenKhoanTru { get => _tenKhoanTru; set => _tenKhoanTru = value; }
        public double SoTien { get => _soTien; set => _soTien = value; }

        public Deduction(string maKhauTru, string tenKhoanTru, double soTien)
        {
            _maKhauTru = maKhauTru;
            _tenKhoanTru = tenKhoanTru;
            _soTien = soTien;
        }

        public double TinhKhoanTruNV()
        {
            return 0;
        }
    }
}
