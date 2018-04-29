using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class SystemLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string LogMessage { get; set; }
        public int User { get; set; }

    }
}
