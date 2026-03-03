public class ChucVu
{

    public string MaCV { get; set; }
    public string TenChucVu { get; set; }
    public double HeSoLuong { get; set; }


    public ChucVu(string maCV, string tenChucVu, double heSoLuong)
    {
        MaCV = maCV;
        TenChucVu = tenChucVu;
        HeSoLuong = heSoLuong;
    }
}