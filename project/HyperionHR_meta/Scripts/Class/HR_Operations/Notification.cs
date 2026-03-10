using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    internal class Notification
    {
        // Fields
    private string _maThongBao;
    private string _noiDung;
    private Person _nguoiNhan;
    private bool _daDoc;

    // Properties
    public string MaThongBao { get { return _maThongBao; } set { _maThongBao = value; } }
    public string NoiDung { get { return _noiDung; } set { _noiDung = value; } }
    public Person NguoiNhan { get { return _nguoiNhan; } set { _nguoiNhan = value; } }
    public bool DaDoc { get { return _daDoc; } set { _daDoc = value; } }

    // Constructor
    public Notification(string ma, string noiDung, Person nguoiNhan)
    {
        _maThongBao = ma;
        _noiDung = noiDung;
        _nguoiNhan = nguoiNhan;
        _daDoc = false;
    }

    // Operations
    public void GuiThongBao() 
    { 
        Console.WriteLine("Gửi tới " + _nguoiNhan.HoTen + ": " + _noiDung); 
    }
    public void DanhDauDaDoc() 
    { 
        _daDoc = true; 
    }
    }
}
