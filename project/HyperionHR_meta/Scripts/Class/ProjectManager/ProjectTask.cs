using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.ProjectManager
{
    internal class ProjectTask
    {
        private string maTask;
        private string tenTask;
        private List<Employee> nguoiPhuTrach;
        private double tienDo;
        private string trangThai;

        // Constructor
        public ProjectTask()
        {
            nguoiPhuTrach = new List<Employee>();
        }

        public ProjectTask(string ma, string ten, List<Employee> ds)
        {
            this.maTask = ma;
            this.tenTask = ten;
            this.nguoiPhuTrach = ds;
            this.tienDo = 0;
            this.trangThai = "Chua bat dau";
        }

        // Getter Setter
        public string MaTask
        {
            get { return maTask; }
            set { maTask = value; }
        }

        public string TenTask
        {
            get { return tenTask; }
            set { tenTask = value; }
        }

        public List<Employee> NguoiPhuTrach
        {
            get { return nguoiPhuTrach; }
            set { nguoiPhuTrach = value; }
        }

        public double TienDo
        {
            get { return tienDo; }
            set { tienDo = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Method
        public void CapNhatTienDoTask(double tienDoMoi)
        {
            this.tienDo = tienDoMoi;
        }

        public void DanhDauHoanThanhTask()
        {
            this.tienDo = 100;
            this.trangThai = "Hoan thanh";
        }
    }
}
