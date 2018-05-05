using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DayAssignWorkers
    {
        public int Id { get; set; }
        public int DayID { get; set; }
        public int SessionID { get; set; }
        public int NozzelID { get; set; }
        public int PumperID { get; set; }
        public DateTime AssignTime { get; set; }
        public bool IsOpen { get; set; }
        public DateTime ClosedTime { get; set; }
        public int ClosedBy { get; set; }
        public int SeqNo { get; set; }



    }
}
