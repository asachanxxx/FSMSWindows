using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UnloadingDet
    {

        public int Id { get; set; }
        public int HedId { get; set; }
        public int FuelId { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public decimal Additions { get; set; }
        public decimal Deductions { get; set; }
        public decimal GrossQty { get; set; }
        public decimal GrossAmt { get; set; }
        public decimal NetAmt { get; set; }

    }
}
