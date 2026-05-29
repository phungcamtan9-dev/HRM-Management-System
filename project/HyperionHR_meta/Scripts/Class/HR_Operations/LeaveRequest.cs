using HyperionHR_meta.Scripts.Class.Person;
using System;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class LeaveRequest : IApprovable
    {
        public string MaDon { get; set; }
        public Employee NhanVien { get; set; }
        public string LoaiNghiPhep { get; set; } // Nghỉ việc, nghỉ phép
        public int SoNgayNghi { get; set; }
        public string LyDo { get; set; } // Ốm, việc riêng, đu lịch,...

        private string TrangThai; // Pending, Approved, Rejected

        // ==========================================
        // KHAI BÁO CÁC SỰ KIỆN (EVENTS) CỐT LÕI
        // ==========================================
        public delegate void LeaveRequestHandler(LeaveRequest sender);
        [field: NonSerialized] // Em tắt chỗ này để nó kh lỗi vì delegate lưu trên Ram nên nó kh cho Save file về@@ khi mở app sẽ tự nối lại ở hàm khác
        public event LeaveRequestHandler OnLeaveRequestCreated;

        [field: NonSerialized]
        public event LeaveRequestHandler OnLeaveRequestApproved;

        [field: NonSerialized]
        public event LeaveRequestHandler OnLeaveRequestRejected;

        // Constructor
        public LeaveRequest(string maDon, Employee nhanVien, string loaiNghiPhep, int soNgay, string lyDo)
        {
            MaDon = maDon;
            NhanVien = nhanVien;
            LoaiNghiPhep = loaiNghiPhep;
            SoNgayNghi = soNgay;
            LyDo = lyDo;
            TrangThai = "Pending";
        }

        // ==========================================
        // CÁC HÀM XỬ LÝ KÍCH HOẠT SỰ KIỆN
        // ==========================================
        public void Submit()
        {
            // Nếu có ai đang "nghe" sự kiện này thì báo cho họ
            if (OnLeaveRequestCreated != null) OnLeaveRequestCreated(this);
        }

        public void Approve()
        {
            TrangThai = "Approved";
            if (OnLeaveRequestApproved != null) OnLeaveRequestApproved(this);
        }

        public void Reject()
        {
            TrangThai = "Rejected";
            if (OnLeaveRequestRejected != null) OnLeaveRequestRejected(this);
        }

        public string GetStatus()
        {
            return TrangThai;
        }
    }
}