    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    [Serializable]
    public class Tax
    {
        public string MaThue { get; set; }
        public double TyLeThue { get; set; }

        public Tax()
        {
        }

        public Tax(string maThue, double tyLeThue)
        {
            MaThue = maThue;
            TyLeThue = tyLeThue;
        }
    }
}
