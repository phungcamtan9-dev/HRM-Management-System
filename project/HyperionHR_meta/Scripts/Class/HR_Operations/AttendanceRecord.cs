using System;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class AttendanceRecord
    {
        public DateTime Ngay { get; set; }
        public TimeSpan? GioVao { get; set; } // Đã thêm ?
        public TimeSpan? GioRa { get; set; }  // Đã thêm ?
        public string TrangThai { get; set; }

        public AttendanceRecord() { }

        public AttendanceRecord(DateTime ngay, TimeSpan? gioVao, TimeSpan? gioRa, string trangThai)
        {
            Ngay = ngay;
            GioVao = gioVao;
            GioRa = gioRa;
            TrangThai = trangThai;
        }
    }
} 