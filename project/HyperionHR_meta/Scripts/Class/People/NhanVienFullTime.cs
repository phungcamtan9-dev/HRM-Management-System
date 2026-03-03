
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.People
{
    public class NhanVienFullTime : NhanVien
    {
        private double luongCoBan;
        private double phuCap;

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public double PhuCap
        {
            get { return phuCap; }
            set { phuCap = value; }
        }

        public NhanVienFullTime() { }

        public NhanVienFullTime(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
                                string sdt, string email, string diaChi,
                                string queQuan, string chucVu, string phongBan,
                                double luongCoBan, double phuCap)
            : base(maNV, hoTen, gioiTinh, ngaySinh, sdt, email, diaChi, queQuan, chucVu, phongBan)
        {
            this.luongCoBan = luongCoBan;
            this.phuCap = phuCap;
        }

        
    }
}
