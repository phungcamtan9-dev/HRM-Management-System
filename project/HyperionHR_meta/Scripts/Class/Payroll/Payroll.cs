using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class; // Add the appropriate namespace where Employee is defined

// Minimal placeholder Employee class so the Payroll file compiles.
// Replace this with the real Employee implementation located elsewhere in your project.
namespace HyperionHR_meta.Scripts.Class
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        // Add other properties/methods as needed or remove this placeholder
    }
}

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    public interface ISalaryCalculator
    {
        double TinhLuongCoBanNV();
    }
public interface IApprovable
{
    void PheDuyetBangLuong();
    void TuChoiBangLuong();
}
    internal class Payroll
    {
        private string _maBangLuong;
    private int _thang;
    private int _nam;
    private Employee _nhanVien;
    private double _tongLuong;

    public string MaBangLuong { get => _maBangLuong; set => _maBangLuong = value; }
    public int Thang           { get => _thang;       set => _thang = value; }
    public int Nam             { get => _nam;         set => _nam = value; }
    public Employee NhanVien   { get => _nhanVien;    set => _nhanVien = value; }
    public double TongLuong    { get => _tongLuong;   set => _tongLuong = value; }

    public Payroll(string maBangLuong, int thang, int nam, Employee nhanVien, double tongLuong)
    {
        _maBangLuong = maBangLuong;
        _thang       = thang;
        _nam         = nam;
        _nhanVien    = nhanVien;
        _tongLuong   = tongLuong;
    }

    public double TinhTongLuongNhanVien() { return _tongLuong; }

    public void PheDuyetBangLuong()       { }

}
    }
