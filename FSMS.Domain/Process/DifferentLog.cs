namespace FSMS.Domain
{
    public class DifferentLog:BaseEntity
    {
        public int Id { get; set; }
        public int DayID { get; set; }
        public int PumperId { get; set; }
        public int SessionId { get; set; }
        public decimal CashTotal { get; set; }
        public decimal CardTotal { get; set; }
        public decimal VoucherTotal { get; set; }
        public decimal Expenses { get; set; }
        public decimal Testing { get; set; }
        public decimal TotalCollection { get; set; }
        public decimal SystemTotal { get; set; }
        public decimal Differences { get; set; }
        public bool IsFinal { get; set; }
        public bool IgnoreDiff { get; set; }
        public bool DiffCaculated { get; set; }
        public bool OriginalPrinted { get; set; }

    }
}