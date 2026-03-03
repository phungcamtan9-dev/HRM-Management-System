using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class
{


    public class QuanLyNhanSuSystem
    {
        public List<string> DSNhanVien { get; set; }
        public List<string> DSPhongBan { get; set; }
        public List<string> DSChamCong { get; set; }
        public List<string> DSLuong { get; set; }
        public List<TaiKhoan> DSTaiKhoan { get; set; }

        // Constructor mặc định
        public QuanLyNhanSuSystem()
        {
            DSNhanVien = new List<string>();
            DSPhongBan = new List<string>();
            DSChamCong = new List<string>();
            DSLuong = new List<string>();
            DSTaiKhoan = new List<TaiKhoan>();
        }

        // Constructor có tham số
        public QuanLyNhanSuSystem(List<string> dsNhanVien,
                                  List<string> dsPhongBan,
                                  List<string> dsChamCong,
                                  List<string> dsLuong,
                                  List<TaiKhoan> dsTaiKhoan)
        {
            DSNhanVien = dsNhanVien;
            DSPhongBan = dsPhongBan;
            DSChamCong = dsChamCong;
            DSLuong = dsLuong;
            DSTaiKhoan = dsTaiKhoan;
        }
    }
}
