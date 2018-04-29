using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DaySaleHed
    {
        public int Id { get; set; }
        [Required]
        public int DayStartID { get; set; }
        public string DocumentNO { get; set; }
        public int PumperID { get; set; }
        public int SaleID { get; set; }
        public Decimal PumperTotalValue { get; set; }
        public Decimal ActualTotalValue { get; set; }
        public Decimal ActualTotalDifference { get; set; }
        public int Status { get; set; }
        public DateTime CencelledDate { get; set; }
        public int CancelledUserId { get; set; }
        public string CancelReason { get; set; }

    }
}
