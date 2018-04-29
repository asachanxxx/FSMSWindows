using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class CashCollection
    {
        public int Id { get; set; }
        public int DayID { get; set; }
        public int PumperId { get; set; }
        public decimal Value { get; set; }
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public bool IsProcessed { get; set; }
        public int ProcessedBy { get; set; }
        public DateTime ProcessedDate { get; set; }
        public bool HasBreakdown { get; set; }
        public decimal TotalOtherExpenses { get; set; }
    }
}
