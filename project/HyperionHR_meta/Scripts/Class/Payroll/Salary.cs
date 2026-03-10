using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    
    internal class Salary : ISalaryCalculator
    {
         private string _maLuong;
    private double _luongCoBan;

    public string MaLuong    { get => _maLuong;    set => _maLuong = value; }
    public double LuongCoBan { get => _luongCoBan; set => _luongCoBan = value; }

    public Salary(string maLuong, double luongCoBan)
    {
        _maLuong    = maLuong;
        _luongCoBan = luongCoBan;
    }

    public double TinhLuongCoBanNV() { return _luongCoBan; }
    }
}
