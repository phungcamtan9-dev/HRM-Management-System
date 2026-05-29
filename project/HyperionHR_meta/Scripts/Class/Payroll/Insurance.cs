using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payrolls
{
     [Serializable]
    public class Insurance
    {
        public string MaBaoHiem { get; set; }
        public string LoaiBaoHiem { get; set; }
        public double TyLe { get; set; } // Ví dụ: 0.1 cho 10%
        public double SoTienCoDinh { get; set; } // Ví dụ: 70000

        public Insurance() { }

        public Insurance(string maBaoHiem, string loaiBaoHiem, double tyLe, double soTienCoDinh)
        {
            MaBaoHiem = maBaoHiem;
            LoaiBaoHiem = loaiBaoHiem;
            TyLe = tyLe;
            SoTienCoDinh = soTienCoDinh;
        }
    }
}
