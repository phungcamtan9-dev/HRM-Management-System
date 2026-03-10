using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.Person
{
    internal class Person
    {
         private string _id;
    private string _hoTen;
    private DateTime _ngaySinh;
    private string _email;
    private string _soDienThoai;

    public string Id             { get => _id;           set => _id = value; }
    public string HoTen          { get => _hoTen;        set => _hoTen = value; }
    public DateTime NgaySinh     { get => _ngaySinh;     set => _ngaySinh = value; }
    public string Email          { get => _email;        set => _email = value; }
    public string SoDienThoai    { get => _soDienThoai;  set => _soDienThoai = value; }

    public Person(string id, string hoTen, DateTime ngaySinh, string email, string soDienThoai)
    {
        _id           = id;
        _hoTen        = hoTen;
        _ngaySinh     = ngaySinh;
        _email        = email;
        _soDienThoai  = soDienThoai;
    }

    public void HienThiThongTin() { }
    public void CapNhatThongTin() { }
    }
}
