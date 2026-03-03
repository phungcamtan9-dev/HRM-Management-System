using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.People
{
    public class NhanVienPartTime : NhanVien
    {
        private double luongTheoGio;
        private double tongGioLam;

        public double LuongTheoGio
        {
            get { return luongTheoGio; }
            set { luongTheoGio = value; }
        }

        public double TongGioLam
        {
            get { return tongGioLam; }
            set { tongGioLam = value; }
        }

        public NhanVienPartTime() { }

        public NhanVienPartTime(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
                                string sdt, string email, string diaChi,
                                string queQuan, string chucVu, string phongBan,
                                double luongTheoGio, double tongGioLam)
            : base(maNV, hoTen, gioiTinh, ngaySinh, sdt, email, diaChi, queQuan, chucVu, phongBan)
        {
            this.luongTheoGio = luongTheoGio;
            this.tongGioLam = tongGioLam;
        }

        public override double TinhLuong()
        {
            return luongTheoGio * tongGioLam;
        }


    }
}
