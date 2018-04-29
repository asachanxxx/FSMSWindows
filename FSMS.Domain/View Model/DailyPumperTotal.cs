using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{

   // DayID PumperId    SaleId SaleType    EmployeeName Day Total
    public class DailyPumperTotal
    {
        public int DayID { get; set; }
        public int PumperId { get; set; }
        public int SaleId { get; set; }
        public string SaleType { get; set; }
        public string EmployeeName { get; set; }
        public string Day { get; set; }
        public decimal Total { get; set; }

    }
}
