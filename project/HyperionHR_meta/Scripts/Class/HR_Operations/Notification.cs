using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class Notification
    {
        public string MaThongBao { get; set; }
        public string NoiDung { get; set; }
        public Version NguoiNhan { get; set; }
        public bool DaDoc { get; set; }

        public Notification()
        {
        }

        public Notification(string maThongBao, string noiDung, Version nguoiNhan, bool daDoc)
        {
            MaThongBao = maThongBao;
            NoiDung = noiDung;
            NguoiNhan = nguoiNhan;
            DaDoc = daDoc;
        }
    }
}
