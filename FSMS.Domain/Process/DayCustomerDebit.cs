using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DayCustomerDebit:BaseEntity
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int SessionId { get; set; }
        public int CustomerID { get; set; }
        public int VehicleId { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal PaiedAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime PayDate { get; set; }
        public bool IsCancel { get; set; }

    }
}
