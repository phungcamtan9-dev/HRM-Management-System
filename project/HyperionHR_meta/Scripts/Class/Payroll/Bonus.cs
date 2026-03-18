using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    [Serializable]
    public class Bonus
    {
        public string MaThuong { get; set; }
        public string TenThuong { get; set; }
        public double SoTien { get; set; }

        public Bonus()
        {
        }

        public Bonus(string maThuong, string tenThuong, double soTien)
        {
            MaThuong = maThuong;
            TenThuong = tenThuong;
            SoTien = soTien;
        }
    }
}
