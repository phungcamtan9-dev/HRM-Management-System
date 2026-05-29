using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Organizations
{
    [Serializable]
    public class Position
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }

        public Position()
        {
        }

        public Position(string maChucVu, string tenChucVu, string moTa)
        {
            MaChucVu = maChucVu;
            TenChucVu = tenChucVu;
            MoTa = moTa;
        }

    }
}
