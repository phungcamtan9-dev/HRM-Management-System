using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Organizations
{
    public class Branch
    {
        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaChi { get; set; }
        public Employee NguoiQuanLy { get; set; }
        public List<Department> DanhSachPB { get; set; }

        public Branch()
        {
            DanhSachPB = new List<Department>();
        }

        public Branch(string maCN, string tenCN, string diaChi, Employee nguoiQuanLy, List<Department> danhSachPB)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
            NguoiQuanLy = nguoiQuanLy;
            DanhSachPB = danhSachPB;
        }
    }
}
