namespace HyperionHR_meta.Scripts.Class.Payrolls
{
    public interface ISalaryCalculator
    {
        double CalculateGrossSalary(); // Tính tổng thu nhập (Lương + Phụ cấp + Thưởng)
        double CalculateDeductions();  // Tính tổng khấu trừ (Bảo hiểm + Thuế + Phạt)
        double CalculateNetSalary();   // Tính thực lãnh (Gross - Deductions)
    }
}
