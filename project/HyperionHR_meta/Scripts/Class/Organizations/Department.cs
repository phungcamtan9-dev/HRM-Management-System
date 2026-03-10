using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Organizations
{
    public class Department
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public List<Employee> NhanVien { get; set; }

        public Department()
        {
            NhanVien = new List<Employee>();
        }

        public Department(string maPB, string tenPB, List<Employee> nhanVien)
        {
            MaPB = maPB;
            TenPB = tenPB;
            NhanVien = nhanVien;
        }
    }
}
