using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class TotalizeReading:BaseEntity
    {
        public int Id { get; set; }
        public int DayID { get; set; }
        public int NozzelID { get; set; }
        public int ShiftID { get; set; }
        public decimal CussreentReading { get; set; }
        public decimal NewReading { get; set; }
        public decimal SIH { get; set; }
        public decimal UPrice { get; set; }
        public decimal Value { get; set; }

    }
}
