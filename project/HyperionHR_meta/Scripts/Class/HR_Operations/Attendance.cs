using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class Attendance
    {
        // Constructor khởi tạo không tham số
    public Attendance() { }

    // Operation: Ghi nhận giờ vào làm
    public void GhiNhanGioVao(Employee nhanVien)
    {
        // Sử dụng kiểu dữ liệu tường minh, không dùng var
        string thongBao = "Đã ghi nhận giờ vào cho nhân viên: " + nhanVien.HoTen;
        Console.WriteLine(thongBao);
    }

    // Operation: Ghi nhận giờ ra (tan ca)
    public void GhiNhanGioRa(Employee nhanVien)
    {
        string thongBao = "Đã ghi nhận giờ ra cho nhân viên: " + nhanVien.HoTen;
        Console.WriteLine(thongBao);
    }

    // Operation: Tính tổng số ngày làm việc trong tháng
    public int TinhTongNgayLam(Employee nhanVien)
    {
        // Logic giả định: Trả về số ngày làm việc tiêu chuẩn
        int tongNgay = 22; 
        return tongNgay;
    }
    }
}
