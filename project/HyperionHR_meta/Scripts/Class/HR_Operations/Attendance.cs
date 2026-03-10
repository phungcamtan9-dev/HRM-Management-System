using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionHR_meta.Scripts.Class.Person;

namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public class Attendance
    {
        public List<AttendanceRecord> Records { get; set; }

        public Attendance()
        {
            Records = new List<AttendanceRecord>();
        }

        public Attendance(List<AttendanceRecord> records)
        {
            Records = records;
        }
    }
}
