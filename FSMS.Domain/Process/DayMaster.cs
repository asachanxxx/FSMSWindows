using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DayMaster
    {
        public int Id { get; set; }
        public string DateStamp { get; set; }
        public string Day { get; set; }
        public int Progress { get; set; }
        public bool Iscancel { get; set; }
        public DateTime CencelledDate { get; set; }
        public int CancelledUserId { get; set; }
        public string CancelReason { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsShiftCreated { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }


    }
}
