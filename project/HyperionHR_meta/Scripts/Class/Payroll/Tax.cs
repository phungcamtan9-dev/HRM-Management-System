    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    internal class Tax
    {
        private string _maThue;
        private double _tyLeThue;

        public string MaThue { get => _maThue; set => _maThue = value; }
        public double TyLeThue { get => _tyLeThue; set => _tyLeThue = value; }

        public Tax(string maThue, double tyLeThue)
        {
            _maThue = maThue;
            _tyLeThue = tyLeThue;
        }

        public double TinhThueThuNhap()
        {
            return 0;
        }
    }
}
