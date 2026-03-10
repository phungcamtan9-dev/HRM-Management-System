using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class LeaveRequest
    {
        // Fields
    private string _maDon;
    private Employee _nhanVien;
    private LeaveType _loaiNghiPhep;
    private int _soNgayNghi;

    // Properties
    public string MaDon { get { return _maDon; } set { _maDon = value; } }
    public Employee NhanVien { get { return _nhanVien; } set { _nhanVien = value; } }
    public LeaveType LoaiNghiPhep { get { return _loaiNghiPhep; } set { _loaiNghiPhep = value; } }
    public int SoNgayNghi { get { return _soNgayNghi; } set { _soNgayNghi = value; } }

    // Constructor
    public LeaveRequest(string ma, Employee nv, LeaveType loai, int soNgay)
    {
        _maDon = ma;
        _nhanVien = nv;
        _loaiNghiPhep = loai;
        _soNgayNghi = soNgay;
    }

    // Operations
    public void PheDuyetDonNghi() 
    { 
        Console.WriteLine("Đơn nghỉ " + _maDon + " được phê duyệt."); 
    }
    public void TuChoiDonNghi() 
    { 
        Console.WriteLine("Đơn nghỉ " + _maDon + " bị từ chối."); 
    }
    public int TinhSoNgayNghi() 
    { 
        return _soNgayNghi; 
    }
    }
}
