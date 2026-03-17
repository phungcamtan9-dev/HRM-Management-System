using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.ProjectManager
{
    internal class ProjectRole
    {
        private string maRoleDA;
        private string tenRoleDA;
        private List<Permission> danhSachQuyen;

        // Constructor
        public ProjectRole()
        {
            danhSachQuyen = new List<Permission>();
        }

        public ProjectRole(string ma, string ten)
        {
            this.maRoleDA = ma;
            this.tenRoleDA = ten;
            this.danhSachQuyen = new List<Permission>();
        }

        // Getter Setter
        public string MaRoleDA
        {
            get { return maRoleDA; }
            set { maRoleDA = value; }
        }

        public string TenRoleDA
        {
            get { return tenRoleDA; }
            set { tenRoleDA = value; }
        }

        public List<Permission> DanhSachQuyen
        {
            get { return danhSachQuyen; }
            set { danhSachQuyen = value; }
        }

        // Method
        public void ThemQuyenDA(Permission p)
        {
            danhSachQuyen.Add(p);
        }

        public void XoaQuyenDA(Permission p)
        {
            danhSachQuyen.Remove(p);
        }
    }
}
