using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class LeaveType
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LeaveType()
        {
        }

        public LeaveType(string maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}
