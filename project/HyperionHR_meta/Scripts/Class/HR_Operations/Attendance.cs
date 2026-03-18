using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class Attendance : IAttendanceService
    {
        public Employee NhanVien { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public List<AttendanceRecord> Records { get; set; }

        public Attendance()
        {
            Records = new List<AttendanceRecord>();
        }

        // ==========================================
        // THỰC THI INTERFACE CHẤM CÔNG
        // ==========================================
        public void CheckIn(DateTime gioVao)
        {
            AttendanceRecord recordMoi = new AttendanceRecord();
            recordMoi.Ngay = gioVao.Date;
            recordMoi.GioVao = gioVao.TimeOfDay;
            recordMoi.TrangThai = "Đã Check-in";

            Records.Add(recordMoi);
        }

        public void CheckOut(DateTime gioRa)
        {
            // Tìm record của ngày hôm nay để cập nhật giờ ra
            foreach (AttendanceRecord record in Records)
            {
                if (record.Ngay == gioRa.Date)
                {
                    record.GioRa = gioRa.TimeOfDay;
                    record.TrangThai = "Hoàn thành";
                    return;
                }
            }
        }

        public double CalculateWorkingHours() // tính giờ làm
        {
            double tongGio = 0;
            foreach (AttendanceRecord record in Records)
            {
                if (record.GioRa > record.GioVao)
                {
                    TimeSpan thoiGianLam = record.GioRa - record.GioVao;
                    tongGio = tongGio + thoiGianLam.TotalHours;
                }
            }
            return tongGio;
        }
    }
}
