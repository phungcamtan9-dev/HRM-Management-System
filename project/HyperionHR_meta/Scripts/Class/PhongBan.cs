public class PhongBan
{

    public string MaPB { get; set; }
    public string TenPhong { get; set; }
    public string DiaChi { get; set; }

   
    public PhongBan(string maPB, string tenPhong, string diaChi)
    {
        MaPB = maPB;
        TenPhong = tenPhong;
        DiaChi = diaChi;
    }
}