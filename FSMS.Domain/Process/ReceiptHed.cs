using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    [Dapper.Contrib.Extensions.Table("ReceiptHeds")]
    public class ReceiptHed
    {
        public int Id { get; set; }
        public string Docno { get; set; }
        public DateTime RecordDate { get; set; }
        public int CustomerId { get; set; }
        public int Status { get; set; }
        public int ReferanceNo { get; set; }
        public string Memo { get; set; }
        public string Recivedfrom { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime processDate { get; set; }
        public int ProcessUserID { get; set; }
        public bool IsGLUpdate { get; set; }
        public bool iscancelled { get; set; }
        public DateTime CancelledDate { get; set; }
        public int CancelledUser { get; set; }
        public string CancelledReason { get; set; }

        [Write(false)]
        [Computed]
        [NotMapped]
        public List<ReceiptDet> ReceiptDets { get; set; }
    }
}
