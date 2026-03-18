using HyperionHR_meta.Scripts.Class.Person;
using System;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class LeaveRequest : IApprovable
    {
        public string MaDon { get; set; }
        public Employee NhanVien { get; set; }
        public string LoaiNghiPhep { get; set; } // các kiểu lý do: "Nghỉ ốm", "Nghỉ phép năm", "Nghỉ việc"
        public int SoNgayNghi { get; set; }

        private string TrangThaiDuyet;

        // ==========================================
        // KHAI BÁO SỰ KIỆN (EVENT)
        // ==========================================

        // Khai báo delegate quy định định dạng của sự kiện
        public delegate void LeaveRequestApprovedHandler(LeaveRequest sender);

        // Khai báo sự kiện dựa trên delegate trên
        public event LeaveRequestApprovedHandler OnLeaveRequestApproved;

        public LeaveRequest()
        {
            TrangThaiDuyet = "Pending";
        }

        public LeaveRequest(string maDon, Employee nhanVien, string loaiNghiPhep, int soNgayNghi)
        {
            MaDon = maDon;
            NhanVien = nhanVien;
            LoaiNghiPhep = loaiNghiPhep;
            SoNgayNghi = soNgayNghi;
            TrangThaiDuyet = "Pending";
        }

        // ==========================================
        // KÍCH HOẠT SỰ KIỆN KHI DUYỆT ĐƠN
        // ==========================================
        public void Approve()
        {
            TrangThaiDuyet = "Approved";

            // Nếu có ai đó đang "lắng nghe" sự kiện này (khác null)
            if (OnLeaveRequestApproved != null)
            {
                // Thì kích hoạt sự kiện, báo cho họ biết đơn này (this) vừa được duyệt!
                OnLeaveRequestApproved(this);
            }
        }

        public void Reject() { TrangThaiDuyet = "Rejected"; }
        public string GetStatus() { return TrangThaiDuyet; }
    }
}