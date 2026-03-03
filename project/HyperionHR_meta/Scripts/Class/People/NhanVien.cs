using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.People
{
    public abstract class NhanVien : Person
    {
        private string maNV { get; set; }
        private string queQuan { get; set; }
        private string chucVu { get; set; }
        private string phongBan { get; set; }


        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
                        string sdt, string email, string diaChi,
                        string queQuan, string chucVu, string phongBan)
            : base(hoTen, gioiTinh, ngaySinh, sdt, email, diaChi)
        {
            this.maNV = maNV;
            this.queQuan = queQuan;
            this.chucVu = chucVu;
            this.phongBan = phongBan;
        }

        public abstract double TinhLuong();
    }
}
