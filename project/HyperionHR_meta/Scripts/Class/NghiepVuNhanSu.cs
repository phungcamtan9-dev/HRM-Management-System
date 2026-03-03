public class ChamCong
{
    public string MaChamCong { get; set; }
    public string MaNV { get; set; }
    public DateTime NgayLam { get; set; }
    public TimeSpan GioVaoCa { get; set; }
    public TimeSpan GioRaCa { get; set; }
    public double SoGioLam { get; set; }
    public double TangCa { get; set; }
    public string TrangThai { get; set; }

    public ChamCong(string maChamCong, string maNV, DateTime ngayLam,
                    TimeSpan gioVaoCa, TimeSpan gioRaCa,
                    double soGioLam, double tangCa, string trangThai)
    {
        MaChamCong = maChamCong;
        MaNV = maNV;
        NgayLam = ngayLam;
        GioVaoCa = gioVaoCa;
        GioRaCa = gioRaCa;
        SoGioLam = soGioLam;
        TangCa = tangCa;
        TrangThai = trangThai;
    }
}
public class Luong
{
    public string MaLuong { get; set; }
    public string MaNV { get; set; }
    public double Thuong { get; set; }
    public double PhuCap { get; set; }
    public double Thue { get; set; }

    public Luong(string maLuong, string maNV, double thuong, double phuCap, double thue)
    {
        MaLuong = maLuong;
        MaNV = maNV;
        Thuong = thuong;
        PhuCap = phuCap;
        Thue = thue;
    }
}
public class HopDongLaoDong
{
    public string SoHopDong { get; set; }
    public string MaNV { get; set; }
    public DateTime NgayKy { get; set; }
    public string LoaiHopDong { get; set; }
    public DateTime ThoiHan { get; set; }

    public HopDongLaoDong(string soHopDong, string maNV, DateTime ngayKy,
                           string loaiHopDong, DateTime thoiHan)
    {
        SoHopDong = soHopDong;
        MaNV = maNV;
        NgayKy = ngayKy;
        LoaiHopDong = loaiHopDong;
        ThoiHan = thoiHan;
    }
}
public class BaoHiem
{
    public string SoBaoHiem { get; set; }
    public string MaNV { get; set; }
    public DateTime NgayCap { get; set; }
    public DateTime NgayHetHan { get; set; }
    public string NoiDangKy { get; set; }

    public BaoHiem(string soBaoHiem, string maNV, DateTime ngayCap,
                   DateTime ngayHetHan, string noiDangKy)
    {
        SoBaoHiem = soBaoHiem;
        MaNV = maNV;
        NgayCap = ngayCap;
        NgayHetHan = ngayHetHan;
        NoiDangKy = noiDangKy;
    }
}
