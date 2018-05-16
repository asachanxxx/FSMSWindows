using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UnloadingDipReadings
    {
        public int Id { get; set; }
        public int HedID { get; set; }
        public int TankD { get; set; }
        public string TankName { get; set; }
        public decimal BeforeDipReading { get; set; }
        public decimal AfterDipReading { get; set; }
        public decimal BeforeTankQty { get; set; }
        public decimal AfterTankQty { get; set; }
        public decimal TotalFuelQty { get; set; }
        public decimal Difference { get; set; }

 
    }
}
