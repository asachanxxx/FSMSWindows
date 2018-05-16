using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UnloadingNozzelReading
    {
        public int Id { get; set; }
        public int HedId { get; set; }
        public int TankId { get; set; }
        public int NozzelId { get; set; }
        public string NozzelName { get; set; }
        public decimal Reading { get; set; }

    }
}
