using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class.Person;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class ActivityLog
    {
        public string LogId { get; set; }
        public Version NguoiThucHien { get; set; }
        public string HanhDong { get; set; }
        public DateTime ThoiGian { get; set; }

        public ActivityLog()
        {
        }

        public ActivityLog(string logId, Version nguoiThucHien, string hanhDong, DateTime thoiGian)
        {
            LogId = logId;
            NguoiThucHien = nguoiThucHien;
            HanhDong = hanhDong;
            ThoiGian = thoiGian;
        }
    }
}
