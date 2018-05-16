using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class PumperWorkingHour
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int SessionId { get; set; }
        public int PumperId { get; set; }
        public decimal Hours { get; set; }

    }
}
