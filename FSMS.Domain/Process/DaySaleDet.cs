using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DaySaleDet
    {

        public int Id { get; set; }
        public int DaySaleHedId { get; set; }
        public decimal Value { get; set; }
        public decimal SystemValue { get; set; }
        public int VehicleID { get; set; }
        public int RFCardID { get; set; }
        public int SaleId { get; set; }
        public string  CardReferance { get; set; }
        public string VoucherNO { get; set; }
        public Decimal PumperValue { get; set; }
        public Decimal ActualValue { get; set; }
        public Decimal ActualTotalDifference { get; set; }
        public string Iscancel { get; set; }
        public DateTime CencelledDate { get; set; }
        public int CancelledUserId { get; set; }
        public string CancelReason { get; set; }

    }
}
