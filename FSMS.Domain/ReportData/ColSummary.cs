using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain.ReportData
{
    public  class ColSummary
    {
        public int DayId { get; set; }
        public string Day { get; set; }
        public int SaleId { get; set; }
        public string SaleName { get; set; }
        public int PumperID { get; set; }
        public string PumperName { get; set; }
        public decimal Total { get; set; }

        

    }
}
