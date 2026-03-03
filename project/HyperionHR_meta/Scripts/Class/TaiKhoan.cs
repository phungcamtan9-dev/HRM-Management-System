using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class
{



public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string QuyenHan { get; set; }

        // Constructor mặc định
        public TaiKhoan()
        {
        }

        // Constructor có tham số
        public TaiKhoan(string tenDangNhap, string matKhau, string quyenHan)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            QuyenHan = quyenHan;
        }
    }
}

