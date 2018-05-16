using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UnloadingHed:BaseEntity
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal Additions { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetTotal { get; set; }
        public bool isProcessed { get; set; }

    }
}
