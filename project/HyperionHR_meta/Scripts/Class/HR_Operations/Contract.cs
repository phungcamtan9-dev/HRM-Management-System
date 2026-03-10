using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class Contract
    {
        // Fields
    private string _maHopDong;
    private DateTime _ngayBatDau;
    private DateTime _ngayKetThuc;
    private string _loaiHopDong;

    // Properties
    public string MaHopDong { get { return _maHopDong; } set { _maHopDong = value; } }
    public DateTime NgayBatDau { get { return _ngayBatDau; } set { _ngayBatDau = value; } }
    public DateTime NgayKetThuc { get { return _ngayKetThuc; } set { _ngayKetThuc = value; } }
    public string LoaiHopDong { get { return _loaiHopDong; } set { _loaiHopDong = value; } }

    // Constructor
    public Contract(string ma, DateTime batDau, DateTime ketThuc, string loai)
    {
        _maHopDong = ma;
        _ngayBatDau = batDau;
        _ngayKetThuc = ketThuc;
        _loaiHopDong = loai;
    }

    // Operations
    public void PheDuyetHD() 
    { 
        Console.WriteLine("Đã duyệt hợp đồng: " + _maHopDong); 
    }
    public void TuChoiHD() 
    { 
        Console.WriteLine("Từ chối hợp đồng: " + _maHopDong); 
    }
    public void CapNhatThongTinHD() 
    { 
        Console.WriteLine("Cập nhật thông tin thành công."); 
    }
    }
}
