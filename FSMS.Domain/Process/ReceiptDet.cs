using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class ReceiptDet
    {
        public int Id { get; set; }
        public int HedId { get; set; }
        public int Sequence { get; set; }
        public int CustomerId { get; set; }
        public int Paytype { get; set; }
        public string PaytypeDesc { get; set; }
        public decimal HeadAmt { get; set; }
        public decimal PaiedAmt { get; set; }
        public int ReferanceID { get; set; }
        public DateTime RecordDate { get; set; }
        public string CQNo { get; set; }
        public DateTime CQDate { get; set; }
        public bool IsReconsile { get; set; }
        public DateTime ReconsileDate { get; set; }
        public int ReconsiledUserId { get; set; }
        public bool IsReturned { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int ReturneddUserId { get; set; }
        public bool iscancelled { get; set; }
        public DateTime cancelledDate { get; set; }
        public int cancelledId { get; set; }
        public string ReasonToReturn { get; set; }
    }
}
