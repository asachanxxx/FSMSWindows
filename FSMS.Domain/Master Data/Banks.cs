using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Banks
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }
    public class BankBranch
    {
        public int Id { get; set; }
        public string BankCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
