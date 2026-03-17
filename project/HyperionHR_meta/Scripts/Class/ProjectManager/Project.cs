using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.ProjectManager
{
    internal class Project
    {

public class ProjectMember
    {
        private Employee nhanVien;
        private ProjectRole vaiTro;
        private DateTime ngayThamGia;

        // Constructor
        public ProjectMember() { }

        public ProjectMember(Employee nv, ProjectRole vt, DateTime ngay)
        {
            this.nhanVien = nv;
            this.vaiTro = vt;
            this.ngayThamGia = ngay;
        }

        // Getter Setter
        public Employee NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        public ProjectRole VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }

        public DateTime NgayThamGia
        {
            get { return ngayThamGia; }
            set { ngayThamGia = value; }
        }

        // Method
        public void CapNhatVaiTroTrongDA(ProjectRole vaiTroMoi)
        {
            this.vaiTro = vaiTroMoi;
        }

        public void RoiDA()
        {
            Console.WriteLine("Nhan vien da roi du an");
        }
    }
}
}
