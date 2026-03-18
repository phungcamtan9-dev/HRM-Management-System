using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    [Serializable]
    public class Deduction
    {
        public string MaKhauTru { get; set; }
        public string TenKhoanTru { get; set; }
        public double SoTien { get; set; }

        public Deduction()
        {
        }

        public Deduction(string maKhauTru, string tenKhoanTru, double soTien)
        {
            MaKhauTru = maKhauTru;
            TenKhoanTru = tenKhoanTru;
            SoTien = soTien;
        }
    }
}
