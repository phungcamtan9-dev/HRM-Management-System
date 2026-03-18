using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Interface
{
    public interface IAttendanceService
    {
        void CheckIn(DateTime gioVao);
        void CheckOut(DateTime gioRa);
        double CalculateWorkingHours();
    }
}
