using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    public class Insurance
    {
        public string MaBaoHiem { get; set; }
        public string LoaiBaoHiem { get; set; }
        public double TyLe { get; set; }

        public Insurance()
        {
        }

        public Insurance(string maBaoHiem, string loaiBaoHiem, double tyLe)
        {
            MaBaoHiem = maBaoHiem;
            LoaiBaoHiem = loaiBaoHiem;
            TyLe = tyLe;
        }
    }
}
