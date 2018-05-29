using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class PaymentType
    {
        public int ID { get; set; }
        public string ShortCode { get; set; }
        public string FullName { get; set; }
        public bool IsCheque { get; set; }
        public bool IscreditCard { get; set; }
        public bool IsDebitCard { get; set; }

    }
}
