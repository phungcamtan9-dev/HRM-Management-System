using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    [Serializable]
    public class Salary
    {
        public string MaLuong { get; set; }
        public double LuongCoBan { get; set; }

        public Salary()
        {
        }

        public Salary(string maLuong, double luongCoBan)
        {
            MaLuong = maLuong;
            LuongCoBan = luongCoBan;
        }
    }
}
