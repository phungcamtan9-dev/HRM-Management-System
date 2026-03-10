using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Payroll
{
    internal class Insurance
    {
        private string _maBaoHiem;
    private string _loaiBaoHiem;
    private double _tyLe;

    public string MaBaoHiem   { get => _maBaoHiem;   set => _maBaoHiem = value; }
    public string LoaiBaoHiem { get => _loaiBaoHiem; set => _loaiBaoHiem = value; }
    public double TyLe        { get => _tyLe;        set => _tyLe = value; }

    public Insurance(string maBaoHiem, string loaiBaoHiem, double tyLe)
    {
        _maBaoHiem   = maBaoHiem;
        _loaiBaoHiem = loaiBaoHiem;
        _tyLe        = tyLe;
    }

    public double TinhBaoHiemNV() 
    {
            return 0; 
    }

    }
}
