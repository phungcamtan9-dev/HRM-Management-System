using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Person
{
    [Serializable]
    public class Admin : Person
    {
        public Admin()
        {
        }

        public Admin(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai)
            : base(id, hoTen, ngaySinh, email, soDienThoai)
        {
        }
    }
}
