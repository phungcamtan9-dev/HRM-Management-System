using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.People
{
    public class QuanLy : NhanVienFullTime
    {
        private double phuCapQuanLy;

        public double PhuCapQuanLy
        {
            get { return phuCapQuanLy; }
            set { phuCapQuanLy = value; }
        }

        public QuanLy() { }

        public QuanLy(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
                      string sdt, string email, string diaChi,
                      string queQuan, string chucVu, string phongBan,
                      double luongCoBan, double phuCap,
                      double phuCapQuanLy)
            : base(maNV, hoTen, gioiTinh, ngaySinh, sdt, email, diaChi,
                   queQuan, chucVu, phongBan, luongCoBan, phuCap)
        {
            this.phuCapQuanLy = phuCapQuanLy;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + phuCapQuanLy;
        }


    }
}
