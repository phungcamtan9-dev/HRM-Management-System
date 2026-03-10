using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    internal class Allowance
    {
    private string _maPhuCap;
    private string _tenPhuCap;
    private double _soTien;

    public string MaPhuCap  { get => _maPhuCap;  set => _maPhuCap = value; }
    public string TenPhuCap { get => _tenPhuCap; set => _tenPhuCap = value; }
    public double SoTien    { get => _soTien;    set => _soTien = value; }

    public Allowance(string maPhuCap, string tenPhuCap, double soTien)
    {
        _maPhuCap  = maPhuCap;
        _tenPhuCap = tenPhuCap;
        _soTien    = soTien;
    }

    public double TinhTongPhuCapNV() { return _soTien; }
    }
}
