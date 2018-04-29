using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class RosterViewModel
    {


        public int Id { get; set; }
        public string ShiftName { get; set; }
        public string DayStart { get; set; }
        public string Shift { get; set; }
        public string Nozzel { get; set; }
        public string Pumper { get; set; }
        public int TotalNoOfWorkigH { get; set; }


    }
}
