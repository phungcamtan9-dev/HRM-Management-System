using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class Contract
    {
        public string MaHopDong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string LoaiHopDong { get; set; }

        public Contract()
        {
        }

        public Contract(string maHopDong, DateTime ngayBatDau, DateTime ngayKetThuc, string loaiHopDong)
        {
            MaHopDong = maHopDong;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            LoaiHopDong = loaiHopDong;
        }
    }
}
