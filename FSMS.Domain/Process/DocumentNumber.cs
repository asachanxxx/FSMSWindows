using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DocumentNumber
    {

        public int Id { get; set; }
        public string ScreenID { get; set; }
        public string ScreenName { get; set; }
        public int Serial { get; set; }
        public string Prefix { get; set; }
        public int TempSerial { get; set; }

    }
}
