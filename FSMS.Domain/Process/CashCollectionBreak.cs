using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class CashCollectionBreak
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public int CashCollId { get; set; }
        public int DayId { get; set; }
        public int PumperId { get; set; }
        public int SessionId { get; set; }
        public decimal Value { get; set; }
        public decimal SystemValue { get; set; }
        public int VehicleID { get; set; }
        public int RFCardID { get; set; }
        public int SaleId { get; set; }
        public string CardReferance { get; set; }
        public string VoucherNO { get; set; }
        public bool Iscancel { get; set; }
        public DateTime CencelledDate { get; set; }
        public int CancelledUserId { get; set; }
        public int BankId { get; set; }
        public int ColelctionDate { get; set; }
        public DateTime RecordDate { get; set; }

    }
}
