using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class RfCardMaster : BaseEntity
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public int IssuedBy { get; set; }
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// 1- Unoccupied 2- Assigned 3- Cancel - 4- Damage
        /// </summary>
        public int CardStatus { get; set; }
    }
}
