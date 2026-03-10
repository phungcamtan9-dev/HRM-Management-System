using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class.Person;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class AttendanceRecord
    {
        public DateTime Ngay { get; set; }
        public TimeSpan GioVao { get; set; }
        public TimeSpan GioRa { get; set; }
        public string TrangThai { get; set; }

        public AttendanceRecord()
        {
        }

        public AttendanceRecord(DateTime ngay, TimeSpan gioVao, TimeSpan gioRa, string trangThai)
        {
            Ngay = ngay;
            GioVao = gioVao;
            GioRa = gioRa;
            TrangThai = trangThai;
        }
    }
}
