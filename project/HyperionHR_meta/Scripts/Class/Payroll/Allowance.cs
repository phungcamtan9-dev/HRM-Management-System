using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    public class Allowance
    {
        public string MaPhuCap { get; set; }
        public string TenPhuCap { get; set; }
        public double SoTien { get; set; }

        public Allowance()
        {
        }

        public Allowance(string maPhuCap, string tenPhuCap, double soTien)
        {
            MaPhuCap = maPhuCap;
            TenPhuCap = tenPhuCap;
            SoTien = soTien;
        }
    }
}
