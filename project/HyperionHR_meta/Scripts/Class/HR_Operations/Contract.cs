using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    [Serializable]
    public class Contract : IApprovable
    {
        public string MaHopDong { get; set; }
        public Employee NhanVien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string LoaiHopDong { get; set; }

        private string TrangThaiDuyet;

        public Contract()
        {
            TrangThaiDuyet = "Pending";
        }

        public Contract(string maHopDong, Employee nhanVien, DateTime ngayBatDau, DateTime ngayKetThuc, string loaiHopDong)
        {
            MaHopDong = maHopDong;
            NhanVien = nhanVien;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            LoaiHopDong = loaiHopDong;
            TrangThaiDuyet = "Pending";
        }

        public void Approve() { TrangThaiDuyet = "Approved"; }
        public void Reject() { TrangThaiDuyet = "Rejected"; }
        public string GetStatus() { return TrangThaiDuyet; }
    }
}

