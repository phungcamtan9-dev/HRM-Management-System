using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts;

namespace HyperionHR_meta.Scripts.Class.Person
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public Person()
        {
        }

        public Person(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai)
        {
            Id = id;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}
