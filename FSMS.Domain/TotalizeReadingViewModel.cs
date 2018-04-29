using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class TotalizeReadingViewModel
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string Nozzel { get; set; }
        public decimal CussreentReading { get; set; }
        public decimal NewReading { get; set; }
        public decimal SIH { get; set; }
        public decimal UPrice { get; set; }
        public decimal Value { get; set; }
    }
}
