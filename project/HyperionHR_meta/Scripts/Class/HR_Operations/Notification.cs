using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class Notification
    {
        public string MaThongBao { get; set; }
        public string NoiDung { get; set; }
        public Employee NguoiNhan { get; set; } 
        public bool DaDoc { get; set; }

        public Notification() { }

        public Notification(string maThongBao, string noiDung, Employee nguoiNhan)
        {
            MaThongBao = maThongBao;
            NoiDung = noiDung;
            NguoiNhan = nguoiNhan;
            DaDoc = false; // Mặc định khi tạo là chưa đọc
        }
    }
}

