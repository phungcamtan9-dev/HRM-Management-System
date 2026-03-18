using HyperionHR_meta.Scripts.Class;
using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    [Serializable]
    public class Payroll : ISalaryCalculator, IApprovable
    {
        public string MaBangLuong { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public Employee NhanVien { get; set; }

        // Các danh sách chi tiết cấu thành lương
        public List<Allowance> DanhSachPhuCap { get; set; }
        public List<Bonus> DanhSachThuong { get; set; }
        public List<Deduction> DanhSachKhauTru { get; set; }
        public List<Insurance> DanhSachBaoHiem { get; set; }
        public Tax ThueApDung { get; set; }

        private string TrangThaiDuyet; // Pending, Approved, Rejected

        public Payroll()
        {
            DanhSachPhuCap = new List<Allowance>();
            DanhSachThuong = new List<Bonus>();
            DanhSachKhauTru = new List<Deduction>();
            DanhSachBaoHiem = new List<Insurance>();
            TrangThaiDuyet = "Pending";
        }


        // ==========================================
        // KHỞI TẠO DỮ LIỆU TỰ ĐỘNG: đưa vào cách tính lương về các khoản phụ cấp, thuế, bảo hiểm, khấu trừ, thưởng,...
        // ==========================================
        public void ThietLapLuatTinhLuong()
        {
            // 1. Nếu là FullTimeEmployee
            if (NhanVien is FullTimeEmployee)
            {
                FullTimeEmployee ftEmp = (FullTimeEmployee)NhanVien;

                // Xử lý Phụ cấp theo Chức vụ
                if (ftEmp.ChucVu != null)
                {
                    if (ftEmp.ChucVu.MaChucVu == "QLIT001")
                    {
                        DanhSachPhuCap.Add(new Allowance("PC01", "Phụ cấp Quản lý IT", 200000));
                    }
                    else if (ftEmp.ChucVu.MaChucVu.Contains("QL"))
                    {
                        DanhSachPhuCap.Add(new Allowance("PC02", "Phụ cấp Quản lý", 150000));
                    }
                    else
                    {
                        DanhSachPhuCap.Add(new Allowance("PC03", "Phụ cấp Fulltime", 100000));
                    }
                }

                // Xử lý Bảo hiểm (Fulltime có cả BHXH 10% và BHYT 70k)
                DanhSachBaoHiem.Add(new Insurance("BH01", "BHXH", 0.10, 0)); // 10%
                DanhSachBaoHiem.Add(new Insurance("BH02", "BHYT", 0, 70000)); // 70k cố định

                // Xử lý Thuế (10%)
                ThueApDung = new Tax("TAX01", 0.10);
            }
            // 2. Nếu là PartTimeEmployee
            else if (NhanVien is PartTimeEmployee)
            {
                // Parttime chỉ có BHYT 70k, không có phụ cấp, không thuế
                DanhSachBaoHiem.Add(new Insurance("BH02", "BHYT", 0, 70000));
                ThueApDung = new Tax("TAX_FREE", 0);
            }
        }

        // ==========================================
        // THỰC THI INTERFACE: ISalaryCalculator
        // ==========================================
        public double CalculateGrossSalary()
        {
            // Tận dụng tính đa hình: Tự biết lấy Lương Cơ Bản hay Lương Giờ
            double tongThuNhap = NhanVien.TinhLuong();

            foreach (Allowance pc in DanhSachPhuCap)
            {
                tongThuNhap = tongThuNhap + pc.SoTien;
            }
            foreach (Bonus th in DanhSachThuong)
            {
                tongThuNhap = tongThuNhap + th.SoTien;
            }

            return tongThuNhap;
        }

        public double CalculateDeductions()
        {
            double tongKhauTru = 0;
            double gross = CalculateGrossSalary(); // Lấy tổng thu nhập làm gốc để tính %

            // Tính tiền bảo hiểm
            foreach (Insurance bh in DanhSachBaoHiem)
            {
                tongKhauTru = tongKhauTru + bh.SoTienCoDinh + (gross * bh.TyLe);
            }

            // Tính tiền phạt/khấu trừ khác
            foreach (Deduction kt in DanhSachKhauTru)
            {
                tongKhauTru = tongKhauTru + kt.SoTien;
            }

            // Tính Thuế
            if (ThueApDung != null)
            {
                tongKhauTru = tongKhauTru + (gross * ThueApDung.TyLeThue);
            }

            return tongKhauTru;
        }

        public double CalculateNetSalary()
        {
            return CalculateGrossSalary() - CalculateDeductions();
        }

        // ==========================================
        // THỰC THI INTERFACE: IApprovable
        // ==========================================
        public void Approve() { TrangThaiDuyet = "Approved"; }
        public void Reject() { TrangThaiDuyet = "Rejected"; }
        public string GetStatus() { return TrangThaiDuyet; }

    }
}
