using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class PumpClosing
    {
        public int Id { get; set; }
        public int DayID { get; set; }
        public int SessionID { get; set; }
        public int NozzelID { get; set; }
        public int PumperID { get; set; }
        public decimal TotalHours { get; set; }
        public decimal StartTotalizer { get; set; }
        public decimal EndTotalizer { get; set; }
        public decimal Reading { get; set; }
        public decimal Price { get; set; }
        public decimal Value { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime ProcessDate { get; set; }
        public int ProcessedBy { get; set; }

    }
}
