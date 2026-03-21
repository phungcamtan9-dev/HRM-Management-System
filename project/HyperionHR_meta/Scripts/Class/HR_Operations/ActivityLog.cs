using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class.Person;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class ActivityLog
    {
        public string LogId { get; set; }
        public string TenTaiKhoan { get; set; }
        public string HanhDong { get; set; } // tui không biết nói sao bro giúp tui
        public DateTime ThoiGian { get; set; }

        public ActivityLog() { }

        public ActivityLog(string logId, string tenTaiKhoan, string hanhDong, DateTime thoiGian)
        {
            LogId = logId;
            TenTaiKhoan = tenTaiKhoan;
            HanhDong = hanhDong;
            ThoiGian = thoiGian;
        }
    }
}
