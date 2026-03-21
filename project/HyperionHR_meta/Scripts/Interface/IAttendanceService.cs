using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Interface
{
    public interface IAttendanceService
    {
        string CheckIn(DateTime gioVao);
        string CheckOut(DateTime gioRa);
        double CalculateWorkingHours();
    }
}
