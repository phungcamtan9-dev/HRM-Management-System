using HyperionHR_meta.Scripts.Class.Person;
public class Department
{
    public string MaPB { get; set; }
    public string TenPB { get; set; }

    public List<Employee> NhanVien { get; private set; }

    public Department()
    {
        NhanVien = new List<Employee>();
    }

    public Department(string maPB, string tenPB)
    {
        MaPB = maPB;
        TenPB = tenPB;
        NhanVien = new List<Employee>();
    }

    // ✅ Thêm nhân viên (quan trọng)
    public void AddEmployee(Employee emp)
    {
        if (emp != null && !NhanVien.Contains(emp))
        {
            NhanVien.Add(emp);
            emp.PhongBan = this; // đồng bộ 2 chiều
        }
    }

    // ✅ Xóa nhân viên
    public void RemoveEmployee(Employee emp)
    {
        if (NhanVien.Contains(emp))
        {
            NhanVien.Remove(emp);
            emp.PhongBan = null; // tránh lỗi dữ liệu
        }
    }
}