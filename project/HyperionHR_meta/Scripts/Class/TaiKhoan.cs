using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class
{
    public class TaiKhoan
    {
        public string MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string QuyenHan { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgayTao { get; set; }

        // Constructor không tham số
        public TaiKhoan()
        {
            NgayTao = DateTime.Now;
            TrangThai = true;
        }

        // Constructor có tham số
        public TaiKhoan(string maTaiKhoan, string tenDangNhap, string matKhau, string quyenHan, bool trangThai)
        {
            MaTaiKhoan = maTaiKhoan;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            QuyenHan = quyenHan;
            TrangThai = trangThai;
            NgayTao = DateTime.Now;
        }
    }
}

