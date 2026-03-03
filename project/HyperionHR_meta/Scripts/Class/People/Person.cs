using System;

namespace HyperionHR_meta.Scripts.Class.People
{
    public abstract class Person
    {
        private string hoTen { get; set; }
        private string gioiTinh { get; set; }
        private DateTime ngaySinh { get; set; }
        private string sdt { get; set; }
        private string email { get; set; }
        private string diaChi { get; set; }

        public Person() { }

        public Person(string hoTen, string gioiTinh, DateTime ngaySinh,
                      string sdt, string email, string diaChi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
        }


    }
}