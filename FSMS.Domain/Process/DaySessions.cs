using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DaySession
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public string SessionName { get; set; }
        public bool IsSessionClosed { get; set; }
    }
}
