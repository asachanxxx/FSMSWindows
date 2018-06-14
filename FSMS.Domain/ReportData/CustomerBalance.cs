using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain.ReportData
{
    public class CustomerBalance
    {
        public DateTime RecDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string DocNo { get; set; }
        public string DC { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal Current_Balance { get; set; }

    }
}
