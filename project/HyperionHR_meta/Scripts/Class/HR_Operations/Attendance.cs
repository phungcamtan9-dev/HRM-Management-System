using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Interface;
using System;
using System.Collections.Generic;

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
        public string CheckIn(DateTime gioVao)
        {
            // 1. Kiểm tra xem hôm nay đã check-in chưa
            foreach (AttendanceRecord r in Records)
            {
                if (r.Ngay == gioVao.Date) return "Hôm nay bạn đã Check-in rồi nhé!";
            }

            // 2. Tạo record mới
            AttendanceRecord recordMoi = new AttendanceRecord();
            recordMoi.Ngay = gioVao.Date;
            recordMoi.GioVao = gioVao.TimeOfDay;

            // 3. Logic đi trễ (Sau 8h30)
            TimeSpan gioLam = new TimeSpan(8, 30, 0);
            if (gioVao.TimeOfDay > gioLam)
                recordMoi.TrangThai = "Đi trễ";
            else
                recordMoi.TrangThai = "Đúng giờ";

            Records.Add(recordMoi);
            return $"Check-in thành công lúc {gioVao.ToString("HH:mm:ss")}";
        }

        public string CheckOut(DateTime gioRa)
        {
            // Tìm record của ngày hôm nay
            foreach (AttendanceRecord record in Records)
            {
                if (record.Ngay == gioRa.Date)
                {
                    if (record.GioRa != null) return "Hôm nay bạn đã Check-out rồi, về nghỉ thôi!";

                    record.GioRa = gioRa.TimeOfDay;

                    // Logic về sớm (Trước 17h30)
                    TimeSpan gioTanCa = new TimeSpan(17, 30, 0);
                    if (gioRa.TimeOfDay < gioTanCa)
                        record.TrangThai += ", Về sớm";
                    else
                        record.TrangThai += ", Hoàn thành";

                    return $"Check-out thành công lúc {gioRa.ToString("HH:mm:ss")}";
                }
            }
            return "Bạn chưa Check-in sáng nay nên không thể Check-out!";
        }

        public double CalculateWorkingHours()
        {
            double tongGio = 0;
            foreach (AttendanceRecord record in Records)
            {
                if (record.GioVao != null && record.GioRa != null && record.GioRa > record.GioVao)
                {
                    TimeSpan thoiGianLam = record.GioRa.Value - record.GioVao.Value;
                    tongGio += thoiGianLam.TotalHours;
                }
            }
            return Math.Round(tongGio, 2);
        }
    }
}