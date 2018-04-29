using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Roster
    {

        public int Id { get; set; }

        [Required]
        public string ShiftName{ get; set; }

        [Required]
        public int DayStartID { get; set; }
        [Required]
        public int ShiftID { get; set; }
        [Required]
        public int NozzelID { get; set; }
        [Required]
        public int PumperID { get; set; }
        public int PlanStartH { get; set; }
        public int PlanStartM { get; set; }
        public int ActualEndH { get; set; }
        public int AcutalEndM { get; set; }
        public int TotalNoOfWorkigH { get; set; }

    }
}
