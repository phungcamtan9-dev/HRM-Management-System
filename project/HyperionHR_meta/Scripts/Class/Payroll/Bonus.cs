using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    internal class Bonus
    {
        private string _maThuong;
    private string _tenThuong;
    private double _soTien;

    public string MaThuong  { get => _maThuong;  set => _maThuong = value; }
    public string TenThuong { get => _tenThuong; set => _tenThuong = value; }
    public double SoTien    { get => _soTien;    set => _soTien = value; }

    public Bonus(string maThuong, string tenThuong, double soTien)
    {
        _maThuong  = maThuong;
        _tenThuong = tenThuong;
        _soTien    = soTien;
    }

    public void TinhThuongNhanVien() { }
    }
}
