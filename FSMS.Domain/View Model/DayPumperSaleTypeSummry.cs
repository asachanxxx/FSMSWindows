using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DayPumperSaleTypeSummry
    {
        public int DayID { get; set; }
        public int PumperId { get; set; }
        public decimal Cashtotal { get; set; }
        public decimal Cardtotal { get; set; }
        public decimal Vouchertotal { get; set; }
        public decimal Expensetotal { get; set; }
        public decimal TestingTotal { get; set; }
    }
}
