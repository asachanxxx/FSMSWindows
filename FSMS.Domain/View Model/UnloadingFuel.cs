using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UnloadingFuel
    {
        public int Id { get; set; }
        public string FuelType { get; set; }
        public decimal Quntity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Additions { get; set; }
        public decimal Deductions { get; set; }
        public decimal Net { get; set; }
    }
}
