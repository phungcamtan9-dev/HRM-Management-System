using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class LeaveType
    {
        // Fields
    private string _maLoai;
    private string _tenLoai;

    // Properties
    public string MaLoai { get { return _maLoai; } set { _maLoai = value; } }
    public string TenLoai { get { return _tenLoai; } set { _tenLoai = value; } }

    // Constructor
    public LeaveType(string ma, string ten)
    {
        _maLoai = ma;
        _tenLoai = ten;
    }

    // Operation
    public void CapNhatTenLoaiNghi() 
    { 
        Console.WriteLine("Tên loại nghỉ đã đổi thành: " + _tenLoai); 
    }
    }
}
