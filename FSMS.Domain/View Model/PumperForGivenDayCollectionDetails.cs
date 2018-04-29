using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class PumperForGivenDayCollectionDetails
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Vehicle { get; set; }
        public string RFCard { get; set; }
        public string VoucherNO { get; set; }
        public string CardNo { get; set; }
        public string Bank { get; set; }
    }
}
