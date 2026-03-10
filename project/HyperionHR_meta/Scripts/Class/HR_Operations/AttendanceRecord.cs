using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class AttendanceRecord
    {
        // Fields
    private DateTime _ngay;
    private DateTime _gioVao;
    private DateTime _gioRa;
    private string _trangThai;

    // Properties
    public DateTime Ngay 
    { 
        get { return _ngay; } 
        set { _ngay = value; } 
    }
    public DateTime GioVao 
    { 
        get { return _gioVao; } 
        set { _gioVao = value; } 
    }
    public DateTime GioRa 
    { 
        get { return _gioRa; } 
        set { _gioRa = value; } 
    }
    public string TrangThai 
    { 
        get { return _trangThai; } 
        set { _trangThai = value; } 
    }

    // Constructor
    public AttendanceRecord(DateTime ngay, DateTime gioVao, DateTime gioRa, string trangThai)
    {
        _ngay = ngay;
        _gioVao = gioVao;
        _gioRa = gioRa;
        _trangThai = trangThai;
    }

    // Operations
    public double TinhSoGioLamTrongNgay()
    {
        TimeSpan thoiGian = _gioRa - _gioVao;
        return thoiGian.TotalHours;
    }

    public bool KiemTraDiTreHayVeSom()
    {
        return _gioVao.Hour > 8 || _gioRa.Hour < 17;
    }
    }
}
